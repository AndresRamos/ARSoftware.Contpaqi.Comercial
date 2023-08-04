using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MahApps.Metro.Controls.Dialogs;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.Models;
using Sdk.Extras.WpfApp.Views.Facturas;

namespace Sdk.Extras.WpfApp.ViewModels.Facturas;

public class ListadoFacturasViewModel : ObservableRecipient, IRecipient<MostrarDetallesFacturaMessage>
{
    private readonly IClienteProveedorRepository<ClienteProveedorLookup> _clienteProveedorRepository;
    private readonly IConceptoDocumentoRepository<ConceptoDocumento> _conceptoDocumentoRepository;
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IDocumentoRepository<DocumentoLookup> _documentoRepository;
    private ClienteProveedorLookup _clienteSeleccionado;
    private ConceptoDocumento _conceptoSeleccionado;
    private DocumentoLookup _documentoSeleccionado;
    private string _duracionBusqueda;
    private DateTime _fechaFin = DateTime.Today;
    private DateTime _fechaInicio = DateTime.Today;
    private string _filtro;

    public ListadoFacturasViewModel(IDialogCoordinator dialogCoordinator, IDocumentoRepository<DocumentoLookup> documentoRepository,
        IClienteProveedorRepository<ClienteProveedorLookup> clienteProveedorRepository,
        IConceptoDocumentoRepository<ConceptoDocumento> conceptoDocumentoRepository)
    {
        _dialogCoordinator = dialogCoordinator;
        _documentoRepository = documentoRepository;
        _clienteProveedorRepository = clienteProveedorRepository;
        _conceptoDocumentoRepository = conceptoDocumentoRepository;

        DocumentosView = CollectionViewSource.GetDefaultView(Documentos);
        DocumentosView.Filter = ProductosView_Filter;
        InicializarCommand = new RelayCommand(Inicializar);
        BuscarConFiltroCommand = new AsyncRelayCommand(BuscarConFiltroAsync, PuedeBuscaConFiltroAsync);
        MostrarDetallesFacturaViewCommand = new AsyncRelayCommand(MostrarDetallesFacturaViewAsync, CanMostrarDetallesFacturaViewAsync);
        CrearFacturaViewCommand = new AsyncRelayCommand(CrearFacturaViewAsync);
    }

    public IAsyncRelayCommand BuscarConFiltroCommand { get; }

    public ObservableCollection<ClienteProveedorLookup> Clientes { get; } = new();

    public ClienteProveedorLookup ClienteSeleccionado
    {
        get => _clienteSeleccionado;
        set
        {
            SetProperty(ref _clienteSeleccionado, value);
            RaiseGuards();
        }
    }

    public ObservableCollection<ConceptoDocumento> Conceptos { get; } = new();

    public ConceptoDocumento ConceptoSeleccionado
    {
        get => _conceptoSeleccionado;
        set
        {
            SetProperty(ref _conceptoSeleccionado, value);
            RaiseGuards();
        }
    }

    public IAsyncRelayCommand CrearFacturaViewCommand { get; }

    public ObservableCollection<DocumentoLookup> Documentos { get; } = new();

    public DocumentoLookup DocumentoSeleccionado
    {
        get => _documentoSeleccionado;
        set
        {
            SetProperty(ref _documentoSeleccionado, value);
            RaiseGuards();
        }
    }

    public ICollectionView DocumentosView { get; }

    public string DuracionBusqueda
    {
        get => _duracionBusqueda;
        set => SetProperty(ref _duracionBusqueda, value);
    }

    public DateTime FechaFin
    {
        get => _fechaFin;
        set
        {
            SetProperty(ref _fechaFin, value);
            RaiseGuards();
        }
    }

    public DateTime FechaInicio
    {
        get => _fechaInicio;
        set
        {
            SetProperty(ref _fechaInicio, value);
            RaiseGuards();
        }
    }

    public string Filtro
    {
        get => _filtro;
        set
        {
            SetProperty(ref _filtro, value);
            DocumentosView.Refresh();
            OnPropertyChanged(nameof(NumeroDocumentos));
        }
    }

    public IRelayCommand InicializarCommand { get; }
    public IAsyncRelayCommand MostrarDetallesFacturaViewCommand { get; }

    public int NumeroDocumentos => DocumentosView.Cast<object>().Count();

    public string Title => "Facturas";

    public void Receive(MostrarDetallesFacturaMessage message)
    {
        var window = new DetallesFacturaView();
        window.ViewModel.Inicializar(message.FacturaId);
        window.Show();
    }

    public async Task BuscarConFiltroAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Documentos.Clear();

            IEnumerable<DocumentoLookup> documentos = ClienteSeleccionado.CIDCLIENTEPROVEEDOR == 0
                ? _documentoRepository.TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(FechaInicio, FechaFin,
                    ConceptoSeleccionado.CCODIGOCONCEPTO,
                    Clientes.Where(c => c.CIDCLIENTEPROVEEDOR != 0).Select(c => c.CCODIGOCLIENTE).ToList())
                : _documentoRepository.TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(FechaInicio, FechaFin,
                    ConceptoSeleccionado.CCODIGOCONCEPTO, ClienteSeleccionado.CCODIGOCLIENTE);

            foreach (DocumentoLookup documento in documentos.OrderByDescending(d => d.CFOLIO))
            {
                CargarRelaciones(documento);
                Documentos.Add(documento);
                progressDialogController.SetMessage($"Numero de documentos: {Documentos.Count}");
                await Task.Delay(20);
            }

            stopwatch.Stop();
            DuracionBusqueda = stopwatch.Elapsed.ToString("g");
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
        finally
        {
            await progressDialogController.CloseAsync();
            OnPropertyChanged(nameof(NumeroDocumentos));
        }
    }

    public bool CanMostrarDetallesFacturaViewAsync()
    {
        return DocumentoSeleccionado != null;
    }

    private void CargarClientes()
    {
        Clientes.Clear();
        Clientes.Add(new ClienteProveedorLookup
        {
            CIDCLIENTEPROVEEDOR = 0,
            CCODIGOCLIENTE = null,
            Estatus = 0,
            CRAZONSOCIAL = "Todos",
            CRFC = null,
            Tipo = TipoCliente.Cliente
        });
        foreach (ClienteProveedorLookup cliente in _clienteProveedorRepository.TraerClientes().OrderBy(c => c.CRAZONSOCIAL))
            Clientes.Add(cliente);

        ClienteSeleccionado = Clientes.FirstOrDefault();
    }

    private void CargarConceptos()
    {
        Conceptos.Clear();
        foreach (ConceptoDocumento concepto in _conceptoDocumentoRepository.TraerPorDocumentoModeloId(DocumentoModeloEnum.Factura.Value)
                     .OrderBy(c => c.CNOMBRECONCEPTO))
            Conceptos.Add(concepto);

        ConceptoSeleccionado = Conceptos.FirstOrDefault();
    }

    private void CargarRelaciones(DocumentoLookup documento)
    {
        documento.ConceptoDocumento = _conceptoDocumentoRepository.BuscarPorId(documento.CIDCONCEPTODOCUMENTO);
        documento.ClienteProveedor = _clienteProveedorRepository.BuscarPorId(documento.CIDCLIENTEPROVEEDOR);
    }

    public async Task CrearFacturaViewAsync()
    {
        try
        {
            var window = new CrearFacturaView();
            window.ViewModel.Inicializar();
            window.Show();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public void Inicializar()
    {
        CargarConceptos();
        CargarClientes();
    }

    public async Task MostrarDetallesFacturaViewAsync()
    {
        try
        {
            var window = new DetallesFacturaView();
            window.ViewModel.Inicializar(DocumentoSeleccionado.CIDDOCUMENTO);
            window.Show();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    private bool ProductosView_Filter(object obj)
    {
        if (!(obj is DocumentoLookup documento)) throw new ArgumentNullException(nameof(obj));

        return documento.Contains(Filtro);
    }

    public bool PuedeBuscaConFiltroAsync()
    {
        return FechaInicio <= FechaFin && ConceptoSeleccionado != null && ClienteSeleccionado != null;
    }

    private void RaiseGuards()
    {
        BuscarConFiltroCommand.NotifyCanExecuteChanged();
        MostrarDetallesFacturaViewCommand.NotifyCanExecuteChanged();
        CrearFacturaViewCommand.NotifyCanExecuteChanged();
    }
}

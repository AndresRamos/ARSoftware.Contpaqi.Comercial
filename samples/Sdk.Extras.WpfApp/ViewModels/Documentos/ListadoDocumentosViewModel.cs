using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MahApps.Metro.Controls.Dialogs;
using Sdk.Extras.WpfApp.Models;

namespace Sdk.Extras.WpfApp.ViewModels.Documentos;

public class ListadoDocumentosViewModel : ObservableRecipient
{
    private readonly IAgenteRepository<Agente> _agenteRepository;
    private readonly IAlmacenRepository<Almacen> _almacenRepository;
    private readonly IClienteProveedorRepository<ClienteProveedorLookup> _clienteProveedorLookupRepository;
    private readonly IClienteProveedorRepository<ClienteProveedor> _clienteProveedorRepository;
    private readonly IConceptoDocumentoRepository<ConceptoDocumento> _conceptoDocumentoRepository;
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IDireccionRepository<Direccion> _direccionRepository;
    private readonly IDocumentoRepository<Documento> _documentoRepository;
    private readonly IMovimientoRepository<Movimiento> _movimientoRepository;
    private readonly IProductoRepository<Producto> _productoRepository;
    private readonly IValorClasificacionRepository<ValorClasificacion> _valorClasificacionRepository;
    private ClienteProveedorLookup _clienteProveedorSeleccionado;
    private ConceptoDocumento _conceptoSeleccionado;
    private Documento _documentoSeleccionado;
    private string _duracionBusqueda;
    private DateTime _fechaFin = DateTime.Today;
    private DateTime _fechaInicio = DateTime.Today;
    private string _filtro;

    public ListadoDocumentosViewModel(IDialogCoordinator dialogCoordinator, IDocumentoRepository<Documento> documentoRepository,
        IClienteProveedorRepository<ClienteProveedorLookup> clienteProveedorLookupRepository,
        IConceptoDocumentoRepository<ConceptoDocumento> conceptoDocumentoRepository, IMovimientoRepository<Movimiento> movimientoRepository,
        IAgenteRepository<Agente> agenteRepository, IProductoRepository<Producto> productoRepository,
        IAlmacenRepository<Almacen> almacenRepository, IValorClasificacionRepository<ValorClasificacion> valorClasificacionRepository,
        IDireccionRepository<Direccion> direccionRepository, IClienteProveedorRepository<ClienteProveedor> clienteProveedorRepository)
    {
        _dialogCoordinator = dialogCoordinator;
        _documentoRepository = documentoRepository;
        _clienteProveedorLookupRepository = clienteProveedorLookupRepository;
        _conceptoDocumentoRepository = conceptoDocumentoRepository;
        _movimientoRepository = movimientoRepository;
        _agenteRepository = agenteRepository;
        _productoRepository = productoRepository;
        _almacenRepository = almacenRepository;
        _valorClasificacionRepository = valorClasificacionRepository;
        _direccionRepository = direccionRepository;
        _clienteProveedorRepository = clienteProveedorRepository;

        DocumentosView = CollectionViewSource.GetDefaultView(Documentos);
        DocumentosView.Filter = ProductosView_Filter;
        InicializarCommand = new RelayCommand(Inicializar);
        BuscarTodoCommand = new AsyncRelayCommand(BuscarTodoAsync);
        BuscarConFiltroCommand = new AsyncRelayCommand(BuscarConFiltroAsync, PuedeBuscaConFiltroAsync);
    }

    public IAsyncRelayCommand BuscarConFiltroCommand { get; }

    public IAsyncRelayCommand BuscarTodoCommand { get; }

    public ClienteProveedorLookup ClienteProveedorSeleccionado
    {
        get => _clienteProveedorSeleccionado;
        set
        {
            SetProperty(ref _clienteProveedorSeleccionado, value);
            RaiseGuards();
        }
    }

    public ObservableCollection<ClienteProveedorLookup> ClientesProveedores { get; } = new();

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

    public ObservableCollection<Documento> Documentos { get; } = new();

    public Documento DocumentoSeleccionado
    {
        get => _documentoSeleccionado;
        set => SetProperty(ref _documentoSeleccionado, value);
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

    public int NumeroDocumentos => DocumentosView.Cast<object>().Count();

    public string Title => "Documentos";

    public async Task BuscarConFiltroAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Documentos.Clear();
            foreach (Documento documento in _documentoRepository.TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(FechaInicio,
                         FechaFin, ConceptoSeleccionado.CCODIGOCONCEPTO, ClienteProveedorSeleccionado.CCODIGOCLIENTE))
            {
                CargarRelaciones(documento);
                Documentos.Add(documento);
                progressDialogController.SetMessage($"Numero de documentos: {Documentos.Count}");
                await Task.Delay(50);
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

    public async Task BuscarTodoAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Documentos.Clear();
            foreach (Documento documento in _documentoRepository.TraerTodo())
            {
                CargarRelaciones(documento);
                Documentos.Add(documento);
                progressDialogController.SetMessage($"Numero de documentos: {Documentos.Count}");
                await Task.Delay(50);
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

    private void CargarClientes()
    {
        ClientesProveedores.Clear();
        foreach (ClienteProveedorLookup clienteProveedor in _clienteProveedorLookupRepository.TraerTodo().OrderBy(c => c.CRAZONSOCIAL))
            ClientesProveedores.Add(clienteProveedor);
    }

    private void CargarConceptos()
    {
        Conceptos.Clear();
        foreach (ConceptoDocumento concepto in _conceptoDocumentoRepository.TraerTodo().OrderBy(c => c.CNOMBRECONCEPTO))
            Conceptos.Add(concepto);
    }

    private void CargarRelaciones(Documento documento)
    {
        documento.ConceptoDocumento = _conceptoDocumentoRepository.BuscarPorId(documento.CIDCONCEPTODOCUMENTO);
        documento.ClienteProveedor = _clienteProveedorRepository.BuscarPorId(documento.CIDCLIENTEPROVEEDOR);
        documento.Agente = _agenteRepository.BuscarPorId(documento.CIDAGENTE);
        documento.DireccionFiscal = _direccionRepository.BuscarPorDocumento(documento.CIDDOCUMENTO, TipoDireccion.Fiscal);
        documento.DireccionEnvio = _direccionRepository.BuscarPorDocumento(documento.CIDDOCUMENTO, TipoDireccion.Envio);
        documento.Movimientos = _movimientoRepository.TraerPorDocumentoId(documento.CIDDOCUMENTO).ToList();
        foreach (Movimiento movimiento in documento.Movimientos)
        {
            movimiento.Producto = _productoRepository.BuscarPorId(movimiento.CIDPRODUCTO);
            movimiento.Almacen = _almacenRepository.BuscarPorId(movimiento.CIDALMACEN);
            movimiento.ValorClasificacion = _valorClasificacionRepository.BuscarPorId(movimiento.CIDVALORCLASIFICACION);
        }
    }

    public void Inicializar()
    {
        CargarConceptos();
        CargarClientes();
    }

    private bool ProductosView_Filter(object obj)
    {
        if (!(obj is Documento documento)) throw new ArgumentNullException(nameof(obj));

        return documento.Contains(Filtro);
    }

    public bool PuedeBuscaConFiltroAsync()
    {
        return FechaInicio <= FechaFin && ConceptoSeleccionado != null && ClienteProveedorSeleccionado != null;
    }

    private void RaiseGuards()
    {
        BuscarTodoCommand.NotifyCanExecuteChanged();
        BuscarConFiltroCommand.NotifyCanExecuteChanged();
    }
}

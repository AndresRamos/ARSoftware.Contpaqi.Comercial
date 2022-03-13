using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Facturas;

public class CrearFacturaViewModel : ObservableRecipient
{
    private readonly IAgenteRepository<Agente> _agenteRepository;
    private readonly IClienteProveedorRepository<ClienteProveedorLookup> _clienteProveedorRepository;
    private readonly IConceptoDocumentoRepository<ConceptoDocumento> _conceptoDocumentoRepository;
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IDocumentoRepository<Documento> _documentoRepository;
    private readonly IDocumentoService _documentoService;
    private Agente _agenteSeleccionado;
    private ClienteProveedorLookup _clienteSeleccionado;
    private ConceptoDocumento _conceptoSeleccionado;
    private DateTime _fecha = DateTime.Today;
    private double _folio;
    private int _moneda = 1;
    private string _referencia;
    private string _serie;
    private double _tipoCambio = 1;

    public CrearFacturaViewModel(IDocumentoService documentoService,
                                 IConceptoDocumentoRepository<ConceptoDocumento> conceptoDocumentoRepository,
                                 IClienteProveedorRepository<ClienteProveedorLookup> clienteProveedorRepository,
                                 IDialogCoordinator dialogCoordinator,
                                 IDocumentoRepository<Documento> documentoRepository,
                                 IAgenteRepository<Agente> agenteRepository)
    {
        _documentoService = documentoService;
        _conceptoDocumentoRepository = conceptoDocumentoRepository;
        _clienteProveedorRepository = clienteProveedorRepository;
        _dialogCoordinator = dialogCoordinator;
        _documentoRepository = documentoRepository;
        _agenteRepository = agenteRepository;

        InicializarCommand = new RelayCommand(Inicializar);
        CrearFacturaCommand = new AsyncRelayCommand(CrearFacturaAsync);
        BuscarSiguienteFolioCommand = new AsyncRelayCommand(BuscarSiguienteFolioAsync, CanBuscarSiguienteFolio);
        CancelarCommand = new RelayCommand(CerrarVista);
    }

    public string Title => "Crear Factura";

    public DateTime Fecha
    {
        get => _fecha;
        set => SetProperty(ref _fecha, value);
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

    public string Serie
    {
        get => _serie;
        set => SetProperty(ref _serie, value);
    }

    public double Folio
    {
        get => _folio;
        set => SetProperty(ref _folio, value);
    }

    public ObservableCollection<ClienteProveedorLookup> Clientes { get; } = new();

    public ClienteProveedorLookup ClienteSeleccionado
    {
        get => _clienteSeleccionado;
        set => SetProperty(ref _clienteSeleccionado, value);
    }

    public ObservableCollection<Agente> Agentes { get; } = new();

    public Agente AgenteSeleccionado
    {
        get => _agenteSeleccionado;
        set => SetProperty(ref _agenteSeleccionado, value);
    }

    public int Moneda
    {
        get => _moneda;
        set => SetProperty(ref _moneda, value);
    }

    public double TipoCambio
    {
        get => _tipoCambio;
        set => SetProperty(ref _tipoCambio, value);
    }

    public string Referencia
    {
        get => _referencia;
        set => SetProperty(ref _referencia, value);
    }

    public IRelayCommand InicializarCommand { get; }
    public IAsyncRelayCommand CrearFacturaCommand { get; }
    public IAsyncRelayCommand BuscarSiguienteFolioCommand { get; }
    public IRelayCommand CancelarCommand { get; }

    public async Task BuscarSiguienteFolioAsync()
    {
        try
        {
            tLlaveDoc siguienteSerieFolio = _documentoRepository.BuscarSiguienteSerieYFolio(ConceptoSeleccionado.CCODIGOCONCEPTO);

            Serie = siguienteSerieFolio.aSerie;
            Folio = siguienteSerieFolio.aFolio;
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public bool CanBuscarSiguienteFolio()
    {
        return ConceptoSeleccionado != null;
    }

    private void CargarAgentes()
    {
        Agentes.Clear();
        foreach (Agente agente in _agenteRepository.TraerTodo().OrderBy(a => a.CNOMBREAGENTE))
        {
            Agentes.Add(agente);
        }

        AgenteSeleccionado = Agentes.FirstOrDefault();
    }

    private void CargarClientes()
    {
        Clientes.Clear();
        foreach (ClienteProveedorLookup cliente in _clienteProveedorRepository.TraerClientes().OrderBy(c => c.CRAZONSOCIAL))
        {
            Clientes.Add(cliente);
        }

        ClienteSeleccionado = Clientes.FirstOrDefault();
    }

    private void CargarConceptosFactura()
    {
        Conceptos.Clear();
        foreach (ConceptoDocumento concepto in _conceptoDocumentoRepository.TraerPorDocumentoModeloId(DocumentoModelo.Factura.Id)
                     .OrderBy(c => c.CNOMBRECONCEPTO))
        {
            Conceptos.Add(concepto);
        }

        ConceptoSeleccionado = Conceptos.FirstOrDefault();
    }

    public void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    public async Task CrearFacturaAsync()
    {
        try
        {
            var documento = new tDocumento
            {
                aFecha = Fecha.ToSdkFecha(),
                aCodConcepto = ConceptoSeleccionado.CCODIGOCONCEPTO,
                aSerie = Serie,
                aFolio = Folio,
                aCodigoCteProv = ClienteSeleccionado.CCODIGOCLIENTE,
                aCodigoAgente = AgenteSeleccionado.CCODIGOAGENTE,
                aNumMoneda = Moneda,
                aTipoCambio = TipoCambio,
                aReferencia = Referencia
            };

            int facturaId = _documentoService.Crear(documento);
            Messenger.Send(new MostrarDetallesFacturaMessage(facturaId));
            CerrarVista();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public void Inicializar()
    {
        CargarConceptosFactura();
        CargarClientes();
        CargarAgentes();
    }

    private void RaiseGuards()
    {
        InicializarCommand.NotifyCanExecuteChanged();
        CrearFacturaCommand.NotifyCanExecuteChanged();
        BuscarSiguienteFolioCommand.NotifyCanExecuteChanged();
    }
}

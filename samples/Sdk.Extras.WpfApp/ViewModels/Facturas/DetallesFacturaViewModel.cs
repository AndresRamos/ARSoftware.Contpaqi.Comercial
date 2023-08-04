using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Win32;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.Models;
using Sdk.Extras.WpfApp.Views.Movimientos;

namespace Sdk.Extras.WpfApp.ViewModels.Facturas;

public class DetallesFacturaViewModel : ObservableRecipient
{
    private readonly IAgenteRepository<Agente> _agenteRepository;
    private readonly IAlmacenRepository<Almacen> _almacenRepository;
    private readonly IClienteProveedorRepository<ClienteProveedor> _clienteProveedorRepository;
    private readonly IConceptoDocumentoRepository<ConceptoDocumento> _conceptoDocumentoRepository;
    private readonly ConfiguracionAplicacion _configuracionAplicacion;
    private readonly IContpaqiSdk _contpaqiSdk;
    private readonly IDatosCfdiRepository _datosCfdiRepository;
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IDireccionRepository<Direccion> _direccionRepository;
    private readonly IDireccionService _direccionService;
    private readonly IDocumentoRepository<Documento> _documentoRepository;
    private readonly IDocumentoService _documentoService;
    private readonly IMovimientoRepository<Movimiento> _movimientoRepository;
    private readonly IMovimientoService _movimientoService;
    private readonly IProductoRepository<Producto> _productoRepository;
    private readonly IValorClasificacionRepository<ValorClasificacion> _valorClasificacionRepository;
    private DatosCfdi _datosCfdi;
    private Documento _factura = new();
    private Movimiento _movimientoSeleccionado;

    public DetallesFacturaViewModel(IDocumentoRepository<Documento> documentoRepository, IDialogCoordinator dialogCoordinator,
        IMovimientoService movimientoService, IDocumentoService documentoService, IDatosCfdiRepository datosCfdiRepository,
        ConfiguracionAplicacion configuracionAplicacion, IDireccionService direccionService, IAgenteRepository<Agente> agenteRepository,
        IAlmacenRepository<Almacen> almacenRepository, IClienteProveedorRepository<ClienteProveedor> clienteProveedorRepository,
        IConceptoDocumentoRepository<ConceptoDocumento> conceptoDocumentoRepository, IDireccionRepository<Direccion> direccionRepository,
        IMovimientoRepository<Movimiento> movimientoRepository, IProductoRepository<Producto> productoRepository,
        IValorClasificacionRepository<ValorClasificacion> valorClasificacionRepository, IContpaqiSdk contpaqiSdk)
    {
        _documentoRepository = documentoRepository;
        _dialogCoordinator = dialogCoordinator;
        _movimientoService = movimientoService;
        _documentoService = documentoService;
        _datosCfdiRepository = datosCfdiRepository;
        _configuracionAplicacion = configuracionAplicacion;
        _direccionService = direccionService;
        _agenteRepository = agenteRepository;
        _almacenRepository = almacenRepository;
        _clienteProveedorRepository = clienteProveedorRepository;
        _conceptoDocumentoRepository = conceptoDocumentoRepository;
        _direccionRepository = direccionRepository;
        _movimientoRepository = movimientoRepository;
        _productoRepository = productoRepository;
        _valorClasificacionRepository = valorClasificacionRepository;
        _contpaqiSdk = contpaqiSdk;

        CrearMovimientoCommand = new AsyncRelayCommand(CrearMovimientoAsync);
        EditarMovimientoCommand = new AsyncRelayCommand(EditarMovimientoAsync, CanEditarMovimientoAsync);
        EliminarMovimientoCommand = new AsyncRelayCommand(EliminarMovimientoAsync, CanEliminarMovimientoAsync);

        GuardarDocumentoCommand = new AsyncRelayCommand(GuardarDocumentoAsync);
        CancelarDocumentoCommand = new AsyncRelayCommand(CancelarDocumentoAsync);
        CancelarDocumentoAdministrativamenteCommand = new AsyncRelayCommand(CancelarDocumentoAdministrativamenteAsync);
        EliminarDocumentoCommand = new AsyncRelayCommand(EliminarDocumentoAsync);
        TimbrarDocumentoCommand = new AsyncRelayCommand(TimbrarDocumentoAsync);
        GenerarPdfDocumentoCommand = new AsyncRelayCommand(GenerarPdfDocumentoAsync);
        GenerarXmlDocumentoCommand = new AsyncRelayCommand(GenerarXmlDocumentoAsync);

        BuscarDatosCfdiCommand = new AsyncRelayCommand(BuscarDatosCfdiAsync);
    }

    public IAsyncRelayCommand BuscarDatosCfdiCommand { get; }
    public IAsyncRelayCommand CancelarDocumentoAdministrativamenteCommand { get; }
    public IAsyncRelayCommand CancelarDocumentoCommand { get; }

    public IAsyncRelayCommand CrearMovimientoCommand { get; }

    public DatosCfdi DatosCfdi
    {
        get => _datosCfdi;
        set => SetProperty(ref _datosCfdi, value);
    }

    public IAsyncRelayCommand EditarMovimientoCommand { get; }
    public IAsyncRelayCommand EliminarDocumentoCommand { get; }
    public IAsyncRelayCommand EliminarMovimientoCommand { get; }

    public Documento Factura
    {
        get => _factura;
        set => SetProperty(ref _factura, value);
    }

    public IAsyncRelayCommand GenerarPdfDocumentoCommand { get; }
    public IAsyncRelayCommand GenerarXmlDocumentoCommand { get; }
    public IAsyncRelayCommand GuardarDocumentoCommand { get; }

    public Movimiento MovimientoSeleccionado
    {
        get => _movimientoSeleccionado;
        set
        {
            SetProperty(ref _movimientoSeleccionado, value);
            RaiseGuards();
        }
    }

    public IAsyncRelayCommand TimbrarDocumentoCommand { get; }

    public string Title => "Detalles De Factura";

    public double TotalImpuestos => Factura?.CIMPUESTO1 ?? 0 + Factura?.CIMPUESTO2 ?? 0 + Factura?.CIMPUESTO3 ?? 0;

    public async Task BuscarDatosCfdiAsync()
    {
        try
        {
            DatosCfdi = _datosCfdiRepository.BuscarPorDocumentoId(Factura.CIDDOCUMENTO);
            await _dialogCoordinator.ShowMessageAsync(this, "Proceso Terminado", "Proceso terminado.");
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public async Task CancelarDocumentoAdministrativamenteAsync()
    {
        try
        {
            MessageDialogResult messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this,
                "Cancelar Documento Administrativamente", "Esta seguro de querer cancelar este documento?",
                MessageDialogStyle.AffirmativeAndNegative,
                new MetroDialogSettings { AffirmativeButtonText = "Cancelar Documento", NegativeButtonText = "Cancelar" });

            if (messageDialogResult != MessageDialogResult.Affirmative) return;

            _documentoService.CancelarAdministrativamente(Factura.CIDDOCUMENTO);

            CargarFactura(Factura.CIDDOCUMENTO);

            await _dialogCoordinator.ShowMessageAsync(this, "Documento Cancelado", "Documento cancelado.");
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public async Task CancelarDocumentoAsync()
    {
        try
        {
            MessageDialogResult messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this, "Cancelar Documento",
                "Esta seguro de querer cancelar este documento?", MessageDialogStyle.AffirmativeAndNegative,
                new MetroDialogSettings { AffirmativeButtonText = "Cancelar Documento", NegativeButtonText = "Cancelar" });

            if (messageDialogResult != MessageDialogResult.Affirmative) return;

            string contrasenaCertificado =
                await _dialogCoordinator.ShowInputAsync(this, "Contrasena Del Certificado", "Proporcione la contrasena del certificado.");

            if (string.IsNullOrWhiteSpace(contrasenaCertificado)) return;

            _documentoService.Cancelar(Factura.CIDDOCUMENTO, contrasenaCertificado);

            CargarFactura(Factura.CIDDOCUMENTO);

            await _dialogCoordinator.ShowMessageAsync(this, "Documento Cancelado", "Documento cancelado.");
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public bool CanEditarMovimientoAsync()
    {
        return MovimientoSeleccionado != null;
    }

    public bool CanEliminarMovimientoAsync()
    {
        return MovimientoSeleccionado != null;
    }

    private void CargarFactura(int facturaId)
    {
        Factura = _documentoRepository.BuscarPorId(facturaId);
        CargarRelaciones(Factura);
        if (_contpaqiSdk is ComercialSdkExtended) _documentoService.DesbloquearDocumento(facturaId);
        OnPropertyChanged(nameof(TotalImpuestos));
        OnPropertyChanged(nameof(Factura));
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

    public void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    public async Task CrearMovimientoAsync()
    {
        try
        {
            var window = new CrearMovimientoView();
            window.ViewModel.Inicializar(Factura.CIDDOCUMENTO);
            window.ShowDialog();
            CargarFactura(Factura.CIDDOCUMENTO);
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
        finally
        {
            RaiseGuards();
        }
    }

    public async Task EditarMovimientoAsync()
    {
        try
        {
            var window = new EditarMovimientoView();
            window.ViewModel.Inicializar(Factura.CIDDOCUMENTO, MovimientoSeleccionado.CIDMOVIMIENTO);
            window.ShowDialog();
            CargarFactura(Factura.CIDDOCUMENTO);
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
        finally
        {
            RaiseGuards();
        }
    }

    public async Task EliminarDocumentoAsync()
    {
        try
        {
            MessageDialogResult messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this, "Eliminar Documento",
                "Esta seguro de querer eliminar este documento?", MessageDialogStyle.AffirmativeAndNegative,
                new MetroDialogSettings { AffirmativeButtonText = "Eliminar", NegativeButtonText = "Cancelar" });

            if (messageDialogResult != MessageDialogResult.Affirmative) return;

            _documentoService.Eliminar(Factura.CIDDOCUMENTO);

            await _dialogCoordinator.ShowMessageAsync(this, "Documento Eliminado", "Documento eliminado.");

            CerrarVista();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public async Task EliminarMovimientoAsync()
    {
        MessageDialogResult messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this, "Eliminar Movimiento",
            "Esta seguro de querer eliminar este movimiento?", MessageDialogStyle.AffirmativeAndNegative,
            new MetroDialogSettings { AffirmativeButtonText = "Eliminar", NegativeButtonText = "Cancelar" });

        if (messageDialogResult != MessageDialogResult.Affirmative) return;

        try
        {
            _movimientoService.Eliminar(Factura.CIDDOCUMENTO, MovimientoSeleccionado.CIDMOVIMIENTO);
            CargarFactura(Factura.CIDDOCUMENTO);
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public async Task GenerarPdfDocumentoAsync()
    {
        try
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = _contpaqiSdk is ComercialSdkExtended
                    ? $"Comercial (*{ExtensionesPlantillaPdfSdk.Comercial})|*{ExtensionesPlantillaPdfSdk.Comercial}"
                    : $"Factura Electronica (*{ExtensionesPlantillaPdfSdk.FacturaElectronica})|*{ExtensionesPlantillaPdfSdk.FacturaElectronica}"
            };
            bool? showDialog = openFileDialog.ShowDialog();
            if (showDialog == true)
            {
                _documentoService.GenerarDocumentoDigital(Factura.ConceptoDocumento.CCODIGOCONCEPTO, Factura.CSERIEDOCUMENTO,
                    Factura.CFOLIO, TipoArchivoDigital.Pdf, openFileDialog.FileName);

                string rutaArchivo = ArchivoDigitalHelper.GenerarRutaArchivoDigital(TipoArchivoDigital.Pdf,
                    _configuracionAplicacion.Empresa.CRUTADATOS, Factura.CSERIEDOCUMENTO,
                    Factura.CFOLIO.ToString(CultureInfo.InvariantCulture));

                MessageDialogResult messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this, "Archivo PDF Generado",
                    "Archivo PDF generado.", MessageDialogStyle.AffirmativeAndNegativeAndSingleAuxiliary,
                    new MetroDialogSettings
                    {
                        AffirmativeButtonText = "Abrir Archivo",
                        NegativeButtonText = "Cancelar",
                        FirstAuxiliaryButtonText = "Copiar Ruta"
                    });

                if (messageDialogResult == MessageDialogResult.Affirmative)
                    new Process { StartInfo = new ProcessStartInfo(rutaArchivo) { UseShellExecute = true } }.Start();
                else if (messageDialogResult == MessageDialogResult.FirstAuxiliary) Clipboard.SetText(rutaArchivo);
            }
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public async Task GenerarXmlDocumentoAsync()
    {
        try
        {
            _documentoService.GenerarDocumentoDigital(Factura.ConceptoDocumento.CCODIGOCONCEPTO, Factura.CSERIEDOCUMENTO, Factura.CFOLIO,
                TipoArchivoDigital.Xml);

            string rutaArchivo = ArchivoDigitalHelper.GenerarRutaArchivoDigital(TipoArchivoDigital.Xml,
                _configuracionAplicacion.Empresa.CRUTADATOS, Factura.CSERIEDOCUMENTO,
                Factura.CFOLIO.ToString(CultureInfo.InvariantCulture));

            MessageDialogResult messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this, "Archivo XML Generado",
                "Archivo XML generado.", MessageDialogStyle.AffirmativeAndNegativeAndSingleAuxiliary,
                new MetroDialogSettings
                {
                    AffirmativeButtonText = "Abrir Archivo", NegativeButtonText = "Cancelar", FirstAuxiliaryButtonText = "Copiar Ruta"
                });

            if (messageDialogResult == MessageDialogResult.Affirmative)
                new Process { StartInfo = new ProcessStartInfo(rutaArchivo) { UseShellExecute = true } }.Start();
            else if (messageDialogResult == MessageDialogResult.FirstAuxiliary) Clipboard.SetText(rutaArchivo);
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public async Task GuardarDocumentoAsync()
    {
        try
        {
            var datos = new Dictionary<string, string>();

            datos.Add("CFECHAVENCIMIENTO", Factura.CFECHAVENCIMIENTO.ToSdkFecha());
            datos.Add("CFECHAENTREGARECEPCION", Factura.CFECHAENTREGARECEPCION.ToSdkFecha());
            datos.Add("CLUGAREXPE", Factura.CLUGAREXPE);
            datos.Add("CCONDIPAGO", Factura.CCONDIPAGO);
            datos.Add("CREFERENCIA", Factura.CREFERENCIA);
            datos.Add("COBSERVACIONES", Factura.COBSERVACIONES);
            datos.Add("CDESTINATARIO", Factura.CDESTINATARIO);
            datos.Add("CNUMEROGUIA", Factura.CNUMEROGUIA);
            datos.Add("CMENSAJERIA", Factura.CMENSAJERIA);
            datos.Add("CCUENTAMENSAJERIA", Factura.CCUENTAMENSAJERIA);
            datos.Add("CNUMEROCAJAS", Factura.CNUMEROCAJAS.ToString(CultureInfo.InvariantCulture));
            datos.Add("CPESO", Factura.CPESO.ToString(CultureInfo.InvariantCulture));
            datos.Add("CTEXTOEXTRA1", Factura.CTEXTOEXTRA1);
            datos.Add("CTEXTOEXTRA2", Factura.CTEXTOEXTRA2);
            datos.Add("CTEXTOEXTRA3", Factura.CTEXTOEXTRA3);

            _documentoService.Actualizar(Factura.CIDDOCUMENTO, datos);

            if (Factura.DireccionFiscal != null && Factura.DireccionFiscal.CIDDIRECCION != 0)
            {
                Dictionary<string, string> datosDireccion = Factura.DireccionFiscal.ToDatosDictionary<admDomicilios>();
                datosDireccion.Remove("CIDDIRECCION");
                datosDireccion.Remove("CIDCATALOGO");
                datosDireccion.Remove("CTIPOCATALOGO");
                datosDireccion.Remove("CTIPODIRECCION");
                _direccionService.Actualizar(Factura.DireccionFiscal.CIDDIRECCION, datosDireccion);
            }

            if (Factura.DireccionEnvio != null && Factura.DireccionEnvio.CIDDIRECCION != 0)
            {
                Dictionary<string, string> datosDireccion = Factura.DireccionEnvio.ToDatosDictionary<admDomicilios>();
                datosDireccion.Remove("CIDDIRECCION");
                datosDireccion.Remove("CIDCATALOGO");
                datosDireccion.Remove("CTIPOCATALOGO");
                datosDireccion.Remove("CTIPODIRECCION");
                _direccionService.Actualizar(Factura.DireccionEnvio.CIDDIRECCION, datosDireccion);
            }

            CargarFactura(Factura.CIDDOCUMENTO);

            await _dialogCoordinator.ShowMessageAsync(this, "Documento Guardado", "Documento guardado.");
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public void Inicializar(int facturaId)
    {
        CargarFactura(facturaId);
    }

    private void RaiseGuards()
    {
        CrearMovimientoCommand.NotifyCanExecuteChanged();
        EditarMovimientoCommand.NotifyCanExecuteChanged();
        EliminarMovimientoCommand.NotifyCanExecuteChanged();
        BuscarDatosCfdiCommand.NotifyCanExecuteChanged();
    }

    public async Task TimbrarDocumentoAsync()
    {
        try
        {
            string dialogResult =
                await _dialogCoordinator.ShowInputAsync(this, "Contrasena Del Certificado", "Proporcione la contrasena del certificado.");

            if (string.IsNullOrWhiteSpace(dialogResult)) return;

            _documentoService.Timbrar(Factura.ConceptoDocumento.CCODIGOCONCEPTO, Factura.CSERIEDOCUMENTO, Factura.CFOLIO, dialogResult);

            CargarFactura(Factura.CIDDOCUMENTO);

            await _dialogCoordinator.ShowMessageAsync(this, "Documento Timbrado", "Documento timbrado.");
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }
}

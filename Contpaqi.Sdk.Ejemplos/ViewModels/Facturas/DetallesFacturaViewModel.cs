using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows;
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.Models;
using Contpaqi.Sdk.Ejemplos.Views.Movimientos;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Models.Enums;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Microsoft.Win32;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Facturas
{
    public class DetallesFacturaViewModel : ObservableRecipient
    {
        private readonly ConfiguracionAplicacion _configuracionAplicacion;
        private readonly IDatosCfdiRepository _datosCfdiRepository;
        private readonly IDialogCoordinator _dialogCoordinator;
        private readonly IDireccionService _direccionService;
        private readonly IDocumentoRepository<Documento> _documentoRepository;
        private readonly IDocumentoService _documentoService;
        private readonly IMovimientoService _movimientoService;
        private DatosCfdi _datosCfdi;
        private Documento _factura;
        private Movimiento _movimientoSeleccionado;

        public DetallesFacturaViewModel(IDocumentoRepository<Documento> documentoRepository, IDialogCoordinator dialogCoordinator, IMovimientoService movimientoService, IDocumentoService documentoService, IDatosCfdiRepository datosCfdiRepository, ConfiguracionAplicacion configuracionAplicacion, IDireccionService direccionService)
        {
            _documentoRepository = documentoRepository;
            _dialogCoordinator = dialogCoordinator;
            _movimientoService = movimientoService;
            _documentoService = documentoService;
            _datosCfdiRepository = datosCfdiRepository;
            _configuracionAplicacion = configuracionAplicacion;
            _direccionService = direccionService;

            CrearMovimientoCommand = new AsyncRelayCommand(CrearMovimientoAsync);
            EditarMovimientoCommand = new AsyncRelayCommand(EditarMovimientoAsync, CanEditarMovimientoAsync);
            EliminarMovimientoCommand = new AsyncRelayCommand(EliminarMovimientoAsync, CanEliminarMovimientoAsync);

            GuardarDocumentoCommand = new AsyncRelayCommand(GuardarDocumentoAsync);
            CancelarDocumentoCommand = new AsyncRelayCommand(CancelarDocumentoAsync);
            EliminarDocumentoCommand = new AsyncRelayCommand(EliminarDocumentoAsync);
            TimbrarDocumentoCommand = new AsyncRelayCommand(TimbrarDocumentoAsync);
            GenerarPdfDocumentoCommand = new AsyncRelayCommand(GenerarPdfDocumentoAsync);
            GenerarXmlDocumentoCommand = new AsyncRelayCommand(GenerarXmlDocumentoAsync);

            BuscarDatosCfdiCommand = new AsyncRelayCommand(BuscarDatosCfdiAsync);
        }

        public string Title => "Detalles De Factura";

        public Documento Factura
        {
            get => _factura;
            set => SetProperty(ref _factura, value);
        }

        public Movimiento MovimientoSeleccionado
        {
            get => _movimientoSeleccionado;
            set
            {
                SetProperty(ref _movimientoSeleccionado, value);
                RaiseGuards();
            }
        }

        public IAsyncRelayCommand CrearMovimientoCommand { get; }
        public IAsyncRelayCommand EditarMovimientoCommand { get; }
        public IAsyncRelayCommand EliminarMovimientoCommand { get; }
        public IAsyncRelayCommand GuardarDocumentoCommand { get; }
        public IAsyncRelayCommand CancelarDocumentoCommand { get; }
        public IAsyncRelayCommand EliminarDocumentoCommand { get; }
        public IAsyncRelayCommand TimbrarDocumentoCommand { get; }
        public IAsyncRelayCommand GenerarPdfDocumentoCommand { get; }
        public IAsyncRelayCommand GenerarXmlDocumentoCommand { get; }
        public IAsyncRelayCommand BuscarDatosCfdiCommand { get; }

        public double TotalImpuestos => Factura?.TotalImpuesto1 ?? 0 + Factura?.TotalImpuesto2 ?? 0 + Factura?.TotalImpuesto3 ?? 0;

        public DatosCfdi DatosCfdi
        {
            get => _datosCfdi;
            set => SetProperty(ref _datosCfdi, value);
        }

        public void Inicializar(int facturaId)
        {
            CargarFactura(facturaId);
        }

        public void CargarFactura(int facturaId)
        {
            Factura = _documentoRepository.BuscarPorId(facturaId);
            OnPropertyChanged(nameof(TotalImpuestos));
        }

        public async Task CrearMovimientoAsync()
        {
            try
            {
                var window = new CrearMovimientoView();
                window.ViewModel.Inicializar(Factura.Id);
                window.ShowDialog();
                CargarFactura(Factura.Id);
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

        public async Task EditarMovimientoAsync()
        {
            try
            {
                var window = new EditarMovimientoView();
                window.ViewModel.Inicializar(Factura.Id, MovimientoSeleccionado.Id);
                window.ShowDialog();
                CargarFactura(Factura.Id);
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        public bool CanEliminarMovimientoAsync()
        {
            return MovimientoSeleccionado != null;
        }

        public async Task EliminarMovimientoAsync()
        {
            var messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this,
                "Eliminar Movimiento",
                "Esta seguro de querer eliminar este movimiento?",
                MessageDialogStyle.AffirmativeAndNegative,
                new MetroDialogSettings { AffirmativeButtonText = "Eliminar", NegativeButtonText = "Cancelar" });

            if (messageDialogResult != MessageDialogResult.Affirmative)
            {
                return;
            }

            try
            {
                _movimientoService.Eliminar(Factura.Id, MovimientoSeleccionado.Id);
                CargarFactura(Factura.Id);
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

                datos.Add("CFECHAVENCIMIENTO", Factura.FechaVencimiento.ToSdkString());
                datos.Add("CFECHAENTREGARECEPCION", Factura.FechaEntregaRecepcion.ToSdkString());
                datos.Add("CLUGAREXPE", Factura.LugaExpedicion);
                datos.Add("CCONDIPAGO", Factura.CondicionesPago);
                datos.Add("CREFERENCIA", Factura.Referencia);
                datos.Add("COBSERVACIONES", Factura.Observaciones);
                datos.Add("CDESTINATARIO", Factura.Destinatario);
                datos.Add("CNUMEROGUIA", Factura.NumeroGuia);
                datos.Add("CMENSAJERIA", Factura.MensajeriaNombre);
                datos.Add("CCUENTAMENSAJERIA", Factura.MensajeriaCuenta);
                datos.Add("CNUMEROCAJAS", Factura.NumeroCajas.ToString(CultureInfo.InvariantCulture));
                datos.Add("CPESO", Factura.PesoEnvio.ToString(CultureInfo.InvariantCulture));
                datos.Add("CTEXTOEXTRA1", Factura.TextoExtra1);
                datos.Add("CTEXTOEXTRA2", Factura.TextoExtra2);
                datos.Add("CTEXTOEXTRA3", Factura.TextoExtra3);

                _documentoService.Actualizar(Factura.Id, datos);

                if (Factura.DireccionFiscal != null && Factura.DireccionFiscal.Id != 0)
                {
                    var datosDireccion = Factura.DireccionFiscal.ToDatosDictionary();
                    datosDireccion.Remove("CIDDIRECCION");
                    datosDireccion.Remove("CIDCATALOGO");
                    datosDireccion.Remove("CTIPOCATALOGO");
                    datosDireccion.Remove("CTIPODIRECCION");
                    _direccionService.Actualizar(Factura.DireccionFiscal.Id, datosDireccion);
                }

                if (Factura.DireccionEnvio != null && Factura.DireccionEnvio.Id != 0)
                {
                    var datosDireccion = Factura.DireccionEnvio.ToDatosDictionary();
                    datosDireccion.Remove("CIDDIRECCION");
                    datosDireccion.Remove("CIDCATALOGO");
                    datosDireccion.Remove("CTIPOCATALOGO");
                    datosDireccion.Remove("CTIPODIRECCION");
                    _direccionService.Actualizar(Factura.DireccionEnvio.Id, datosDireccion);
                }

                CargarFactura(Factura.Id);

                await _dialogCoordinator.ShowMessageAsync(this, "Documento Guardado", "Documento guardado.");
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
                var messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this, "Eliminar Documento", "Esta seguro de querer cancelar este documento?", MessageDialogStyle.AffirmativeAndNegative, new MetroDialogSettings { AffirmativeButtonText = "Eliminar", NegativeButtonText = "Cancelar" });

                if (messageDialogResult != MessageDialogResult.Affirmative)
                {
                    return;
                }

                var dialogResult = await _dialogCoordinator.ShowInputAsync(this, "Contrasena Del Certificado", "Proporcione la contrasena del certificado.");

                if (string.IsNullOrWhiteSpace(dialogResult))
                {
                    return;
                }

                _documentoService.Cancelar(Factura.Id, dialogResult);

                CargarFactura(Factura.Id);

                await _dialogCoordinator.ShowMessageAsync(this, "Documento Cancelado", "Documento cancelado.");
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        public async Task EliminarDocumentoAsync()
        {
            try
            {
                var messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this, "Eliminar Documento", "Esta seguro de querer eliminar este documento?", MessageDialogStyle.AffirmativeAndNegative, new MetroDialogSettings { AffirmativeButtonText = "Eliminar", NegativeButtonText = "Cancelar" });

                if (messageDialogResult != MessageDialogResult.Affirmative)
                {
                    return;
                }

                _documentoService.Eliminar(Factura.Id);

                await _dialogCoordinator.ShowMessageAsync(this, "Documento Eliminado", "Documento eliminado.");

                CerrarVista();
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        public void CerrarVista()
        {
            Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
        }

        public async Task TimbrarDocumentoAsync()
        {
            try
            {
                var dialogResult = await _dialogCoordinator.ShowInputAsync(this, "Contrasena Del Certificado", "Proporcione la contrasena del certificado.");

                if (string.IsNullOrWhiteSpace(dialogResult))
                {
                    return;
                }

                _documentoService.Timbrar(Factura.ConceptoDocumento.Codigo, Factura.Serie, Factura.Folio, dialogResult);

                CargarFactura(Factura.Id);

                await _dialogCoordinator.ShowMessageAsync(this, "Documento Timbrado", "Documento timbrado.");
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
                var openFileDialog = new OpenFileDialog();
                var showDialog = openFileDialog.ShowDialog();
                if (showDialog == true)
                {
                    _documentoService.GenerarDocumentoDigital(Factura.ConceptoDocumento.Codigo, Factura.Serie, Factura.Folio, TipoArchivoDigitalEnum.Pdf, openFileDialog.FileName);

                    var rutaArchivo = ArchivoDigitalHelper.GenerarRutaArchivoDigital(TipoArchivoDigitalEnum.Pdf, _configuracionAplicacion.Empresa.Ruta, Factura.Serie, Factura.Folio.ToString(CultureInfo.InvariantCulture));

                    var messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this, "Archivo PDF Generado", "Archivo PDF generado.", MessageDialogStyle.AffirmativeAndNegativeAndSingleAuxiliary, new MetroDialogSettings { AffirmativeButtonText = "Abrir Archivo", NegativeButtonText = "Cancelar", FirstAuxiliaryButtonText = "Copiar Ruta" });

                    if (messageDialogResult == MessageDialogResult.Affirmative)
                    {
                        new Process { StartInfo = new ProcessStartInfo(rutaArchivo) { UseShellExecute = true } }.Start();
                    }
                    else if (messageDialogResult == MessageDialogResult.FirstAuxiliary)
                    {
                        Clipboard.SetText(rutaArchivo);
                    }
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
                _documentoService.GenerarDocumentoDigital(Factura.ConceptoDocumento.Codigo, Factura.Serie, Factura.Folio, TipoArchivoDigitalEnum.Xml, "");

                var rutaArchivo = ArchivoDigitalHelper.GenerarRutaArchivoDigital(TipoArchivoDigitalEnum.Xml, _configuracionAplicacion.Empresa.Ruta, Factura.Serie, Factura.Folio.ToString(CultureInfo.InvariantCulture));

                var messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this, "Archivo XML Generado", "Archivo XML generado.", MessageDialogStyle.AffirmativeAndNegativeAndSingleAuxiliary, new MetroDialogSettings { AffirmativeButtonText = "Abrir Archivo", NegativeButtonText = "Cancelar", FirstAuxiliaryButtonText = "Copiar Ruta" });

                if (messageDialogResult == MessageDialogResult.Affirmative)
                {
                    new Process { StartInfo = new ProcessStartInfo(rutaArchivo) { UseShellExecute = true } }.Start();
                }
                else if (messageDialogResult == MessageDialogResult.FirstAuxiliary)
                {
                    Clipboard.SetText(rutaArchivo);
                }
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        public async Task BuscarDatosCfdiAsync()
        {
            try
            {
                DatosCfdi = _datosCfdiRepository.BuscarPorDocumentoId(Factura.Id);
                await _dialogCoordinator.ShowMessageAsync(this, "Proceso Terminado", "Proceso terminado.");
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        private void RaiseGuards()
        {
            CrearMovimientoCommand.NotifyCanExecuteChanged();
            EditarMovimientoCommand.NotifyCanExecuteChanged();
            EliminarMovimientoCommand.NotifyCanExecuteChanged();

            BuscarDatosCfdiCommand.NotifyCanExecuteChanged();
        }
    }
}
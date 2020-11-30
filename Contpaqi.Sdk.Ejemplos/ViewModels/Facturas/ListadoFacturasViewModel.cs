using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.Views.Facturas;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Models.Enums;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Facturas
{
    public class ListadoFacturasViewModel : ObservableRecipient, IRecipient<MostrarDetallesFacturaMessage>
    {
        private readonly IClienteProveedorRepository<ClienteProveedorLookup> _clienteProveedorRepository;
        private readonly IConceptoDocumentoRepository<ConceptoDocumento> _conceptoDocumentoRepository;
        private readonly IDialogCoordinator _dialogCoordinator;
        private readonly IDocumentoRepository<Documento> _documentoRepository;
        private ClienteProveedorLookup _clienteSeleccionado;
        private ConceptoDocumento _conceptoSeleccionado;
        private Documento _documentoSeleccionado;
        private string _duracionBusqueda;
        private DateTime _fechaFin = DateTime.Today;
        private DateTime _fechaInicio = DateTime.Today;
        private string _filtro;

        public ListadoFacturasViewModel(IDialogCoordinator dialogCoordinator, IDocumentoRepository<Documento> documentoRepository, IClienteProveedorRepository<ClienteProveedorLookup> clienteProveedorRepository, IConceptoDocumentoRepository<ConceptoDocumento> conceptoDocumentoRepository)
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

        public string Title => "Facturas";

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

        public DateTime FechaInicio
        {
            get => _fechaInicio;
            set
            {
                SetProperty(ref _fechaInicio, value);
                RaiseGuards();
            }
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

        public ObservableCollection<Documento> Documentos { get; } = new ObservableCollection<Documento>();

        public ICollectionView DocumentosView { get; }

        public Documento DocumentoSeleccionado
        {
            get => _documentoSeleccionado;
            set
            {
                SetProperty(ref _documentoSeleccionado, value);
                RaiseGuards();
            }
        }

        public ObservableCollection<ConceptoDocumento> Conceptos { get; } = new ObservableCollection<ConceptoDocumento>();

        public ConceptoDocumento ConceptoSeleccionado
        {
            get => _conceptoSeleccionado;
            set
            {
                SetProperty(ref _conceptoSeleccionado, value);
                RaiseGuards();
            }
        }

        public ObservableCollection<ClienteProveedorLookup> Clientes { get; } = new ObservableCollection<ClienteProveedorLookup>();

        public ClienteProveedorLookup ClienteSeleccionado
        {
            get => _clienteSeleccionado;
            set
            {
                SetProperty(ref _clienteSeleccionado, value);
                RaiseGuards();
            }
        }

        public int NumeroDocumentos => DocumentosView.Cast<object>().Count();

        public string DuracionBusqueda
        {
            get => _duracionBusqueda;
            set => SetProperty(ref _duracionBusqueda, value);
        }

        public IAsyncRelayCommand BuscarConFiltroCommand { get; }
        public IRelayCommand InicializarCommand { get; }
        public IAsyncRelayCommand MostrarDetallesFacturaViewCommand { get; }
        public IAsyncRelayCommand CrearFacturaViewCommand { get; }

        public void Receive(MostrarDetallesFacturaMessage message)
        {
            var window = new DetallesFacturaView();
            window.ViewModel.Inicializar(message.FacturaId);
            window.Show();
        }

        public void Inicializar()
        {
            CargarConceptos();
            CargarClientes();
        }

        public bool PuedeBuscaConFiltroAsync()
        {
            return FechaInicio <= FechaFin && ConceptoSeleccionado != null && ClienteSeleccionado != null;
        }

        public async Task BuscarConFiltroAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Documentos.Clear();

                var documentos = ClienteSeleccionado.Id == 0
                    ? _documentoRepository.TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(FechaInicio, FechaFin, ConceptoSeleccionado.Codigo, Clientes.Where(c => c.Id != 0).Select(c => c.Codigo).ToList())
                    : _documentoRepository.TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(FechaInicio, FechaFin, ConceptoSeleccionado.Codigo, ClienteSeleccionado.Codigo);

                foreach (var documento in documentos.OrderByDescending(d => d.Folio))
                {
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

        private void CargarConceptos()
        {
            Conceptos.Clear();
            foreach (var concepto in _conceptoDocumentoRepository.TraerPorDocumentoModeloId(DocumentoModelo.Factura.Id).OrderBy(c => c.Nombre))
            {
                Conceptos.Add(concepto);
            }

            ConceptoSeleccionado = Conceptos.FirstOrDefault();
        }

        private void CargarClientes()
        {
            Clientes.Clear();
            Clientes.Add(new ClienteProveedorLookup
            {
                Id = 0,
                Codigo = null,
                Estatus = 0,
                RazonSocial = "Todos",
                Rfc = null,
                Tipo = TipoClienteEnum.Cliente
            });
            foreach (var cliente in _clienteProveedorRepository.TraerClientes().OrderBy(c => c.RazonSocial))
            {
                Clientes.Add(cliente);
            }

            ClienteSeleccionado = Clientes.FirstOrDefault();
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

        public bool CanMostrarDetallesFacturaViewAsync()
        {
            return DocumentoSeleccionado != null;
        }

        public async Task MostrarDetallesFacturaViewAsync()
        {
            try
            {
                var window = new DetallesFacturaView();
                window.ViewModel.Inicializar(DocumentoSeleccionado.Id);
                window.Show();
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        private void RaiseGuards()
        {
            BuscarConFiltroCommand.NotifyCanExecuteChanged();
            MostrarDetallesFacturaViewCommand.NotifyCanExecuteChanged();
            CrearFacturaViewCommand.NotifyCanExecuteChanged();
        }

        private bool ProductosView_Filter(object obj)
        {
            if (!(obj is Documento documento))
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return string.IsNullOrWhiteSpace(Filtro) ||
                   documento.Id.ToString().IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   documento.ConceptoDocumento.Codigo.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   documento.ConceptoDocumento.Nombre.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   documento.Serie.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   documento.Folio.ToString(CultureInfo.InvariantCulture).IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
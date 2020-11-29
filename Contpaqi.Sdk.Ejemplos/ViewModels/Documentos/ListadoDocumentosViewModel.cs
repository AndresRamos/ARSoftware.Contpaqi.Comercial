using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Documentos
{
    public class ListadoDocumentosViewModel : ObservableRecipient
    {
        private readonly IClienteProveedorRepository<ClienteProveedorLookup> _clienteProveedorRepository;
        private readonly IConceptoDocumentoRepository<ConceptoDocumento> _conceptoDocumentoRepository;
        private readonly IDialogCoordinator _dialogCoordinator;
        private readonly IDocumentoRepository<Documento> _documentoRepository;
        private ClienteProveedorLookup _clienteProveedorSeleccionado;
        private ConceptoDocumento _conceptoSeleccionado;
        private Documento _documentoSeleccionado;
        private string _duracionBusqueda;
        private DateTime _fechaFin = DateTime.Today;
        private DateTime _fechaInicio = DateTime.Today;
        private string _filtro;

        public ListadoDocumentosViewModel(IDialogCoordinator dialogCoordinator, IDocumentoRepository<Documento> documentoRepository, IClienteProveedorRepository<ClienteProveedorLookup> clienteProveedorRepository, IConceptoDocumentoRepository<ConceptoDocumento> conceptoDocumentoRepository)
        {
            _dialogCoordinator = dialogCoordinator;
            _documentoRepository = documentoRepository;
            _clienteProveedorRepository = clienteProveedorRepository;
            _conceptoDocumentoRepository = conceptoDocumentoRepository;

            DocumentosView = CollectionViewSource.GetDefaultView(Documentos);
            DocumentosView.Filter = ProductosView_Filter;
            InicializarCommand = new RelayCommand(Inicializar);
            BuscarTodoCommand = new AsyncRelayCommand(BuscarTodoAsync);
            BuscarConFiltroCommand = new AsyncRelayCommand(BuscarConFiltroAsync, PuedeBuscaConFiltroAsync);
        }

        public string Title => "Documentos";

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
            set => SetProperty(ref _documentoSeleccionado, value);
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

        public ObservableCollection<ClienteProveedorLookup> ClientesProveedores { get; } = new ObservableCollection<ClienteProveedorLookup>();

        public ClienteProveedorLookup ClienteProveedorSeleccionado
        {
            get => _clienteProveedorSeleccionado;
            set
            {
                SetProperty(ref _clienteProveedorSeleccionado, value);
                RaiseGuards();
            }
        }

        public int NumeroDocumentos => DocumentosView.Cast<object>().Count();

        public string DuracionBusqueda
        {
            get => _duracionBusqueda;
            set => SetProperty(ref _duracionBusqueda, value);
        }

        public IAsyncRelayCommand BuscarTodoCommand { get; }
        public IAsyncRelayCommand BuscarConFiltroCommand { get; }
        public IRelayCommand InicializarCommand { get; }

        public void Inicializar()
        {
            CargarConceptos();
            CargarClientes();
        }

        public async Task BuscarTodoAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Documentos.Clear();
                foreach (var documento in _documentoRepository.GetAll())
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

        public bool PuedeBuscaConFiltroAsync()
        {
            return FechaInicio <= FechaFin && ConceptoSeleccionado != null && ClienteProveedorSeleccionado != null;
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
                foreach (var documento in _documentoRepository.GetByRangoFechaAndCodigoConceptoAndCodigoClienteProveedor(FechaInicio, FechaFin, ConceptoSeleccionado.Codigo, ClienteProveedorSeleccionado.Codigo))
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
            foreach (var concepto in _conceptoDocumentoRepository.GetAll().OrderBy(c => c.Nombre))
            {
                Conceptos.Add(concepto);
            }
        }

        private void CargarClientes()
        {
            ClientesProveedores.Clear();
            foreach (var clienteProveedor in _clienteProveedorRepository.GetAll().OrderBy(c => c.RazonSocial))
            {
                ClientesProveedores.Add(clienteProveedor);
            }
        }

        private void RaiseGuards()
        {
            BuscarConFiltroCommand.NotifyCanExecuteChanged();
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
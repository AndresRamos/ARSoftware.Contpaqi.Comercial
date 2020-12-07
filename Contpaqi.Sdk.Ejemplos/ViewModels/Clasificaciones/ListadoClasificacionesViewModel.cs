using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using Contpaqi.Sdk.Ejemplos.Views.ValoresClasificacion;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Models.Enums;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Clasificaciones
{
    public class ListadoClasificacionesViewModel : ObservableRecipient
    {
        private readonly IClasificacionRepository<Clasificacion> _clasificacionRepository;
        private readonly IDialogCoordinator _dialogCoordinator;

        private readonly IValorClasificacionService _valorClasificacionService;
        private Clasificacion _clasificacionSeleccionada;
        private string _duracionBusqueda;
        private string _filtro;
        private TipoClasificacionEnum? _ultimoCatalogoCargado;
        private ValorClasificacion _valorClasificacionSeleccionado;

        public ListadoClasificacionesViewModel(IClasificacionRepository<Clasificacion> clasificacionRepository, IDialogCoordinator dialogCoordinator, IValorClasificacionService valorClasificacionService)
        {
            _clasificacionRepository = clasificacionRepository;
            _dialogCoordinator = dialogCoordinator;
            _valorClasificacionService = valorClasificacionService;
            Clasificaciones = new ObservableCollection<Clasificacion>();
            ClasificacionesView = CollectionViewSource.GetDefaultView(Clasificaciones);
            ClasificacionesView.Filter = UnidadesMedidaView_Filter;

            BuscarClasificacionesCommand = new AsyncRelayCommand(BuscarClasificacionesAsync);
            BuscarClasificacionesDeAgenteCommand = new AsyncRelayCommand(BuscarClasificacionesDeAgenteAsync);
            BuscarClasificacionesDeClienteCommand = new AsyncRelayCommand(BuscarClasificacionesDeClienteAsync);
            BuscarClasificacionesDeProveedorCommand = new AsyncRelayCommand(BuscarClasificacionesDeProveedorAsync);
            BuscarClasificacionesDeAlmacenCommand = new AsyncRelayCommand(BuscarClasificacionesDeAlmacenAsync);
            BuscarClasificacionesDeProductoCommand = new AsyncRelayCommand(BuscarClasificacionesDeProductoAsync);

            CrearValorClasificacionCommand = new AsyncRelayCommand(CrearValorClasificacionAsync, CanCrearValorClasificacionAsync);
            EditarValorClasificacionCommand = new AsyncRelayCommand(EditarValorClasificacionAsync, CanEditarValorClasificacionAsync);
            EliminarValorClasificacionCommand = new AsyncRelayCommand(EliminarValorClasificacionAsync, CanEliminarValorClasificacionAsync);
        }

        public string Title => "Clasificaciones";

        public string Filtro
        {
            get => _filtro;
            set
            {
                SetProperty(ref _filtro, value);
                ClasificacionesView.Refresh();
                OnPropertyChanged(nameof(NumeroClasificaciones));
            }
        }

        public ObservableCollection<Clasificacion> Clasificaciones { get; }

        public ICollectionView ClasificacionesView { get; }

        public Clasificacion ClasificacionSeleccionada
        {
            get => _clasificacionSeleccionada;
            set
            {
                SetProperty(ref _clasificacionSeleccionada, value);
                RaiseGuards();
            }
        }

        public ValorClasificacion ValorClasificacionSeleccionado
        {
            get => _valorClasificacionSeleccionado;
            set
            {
                SetProperty(ref _valorClasificacionSeleccionado, value);
                RaiseGuards();
            }
        }

        public int NumeroClasificaciones => ClasificacionesView.Cast<object>().Count();

        public string DuracionBusqueda
        {
            get => _duracionBusqueda;
            private set => SetProperty(ref _duracionBusqueda, value);
        }

        public IAsyncRelayCommand BuscarClasificacionesCommand { get; }
        public IAsyncRelayCommand BuscarClasificacionesDeAgenteCommand { get; }
        public IAsyncRelayCommand BuscarClasificacionesDeClienteCommand { get; }
        public IAsyncRelayCommand BuscarClasificacionesDeProveedorCommand { get; }
        public IAsyncRelayCommand BuscarClasificacionesDeAlmacenCommand { get; }
        public IAsyncRelayCommand BuscarClasificacionesDeProductoCommand { get; }
        public IAsyncRelayCommand CrearValorClasificacionCommand { get; }
        public IAsyncRelayCommand EditarValorClasificacionCommand { get; }
        public IAsyncRelayCommand EliminarValorClasificacionCommand { get; }

        public async Task BuscarClasificacionesAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            _ultimoCatalogoCargado = null;

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Clasificaciones.Clear();
                foreach (var unidadMedida in _clasificacionRepository.TraerTodo())
                {
                    Clasificaciones.Add(unidadMedida);
                    progressDialogController.SetMessage($"Numero de clasificaciones: {Clasificaciones.Count}");
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
                OnPropertyChanged(nameof(NumeroClasificaciones));
            }
        }

        public async Task BuscarClasificacionesDeAgenteAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            _ultimoCatalogoCargado = TipoClasificacionEnum.Agente;

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Clasificaciones.Clear();
                foreach (var unidadMedida in _clasificacionRepository.TraerPorTipo(TipoClasificacionEnum.Agente))
                {
                    Clasificaciones.Add(unidadMedida);
                    progressDialogController.SetMessage($"Numero de clasificaciones: {Clasificaciones.Count}");
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
                OnPropertyChanged(nameof(NumeroClasificaciones));
            }
        }

        public async Task BuscarClasificacionesDeClienteAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            _ultimoCatalogoCargado = TipoClasificacionEnum.Cliente;

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Clasificaciones.Clear();
                foreach (var unidadMedida in _clasificacionRepository.TraerPorTipo(TipoClasificacionEnum.Cliente))
                {
                    Clasificaciones.Add(unidadMedida);
                    progressDialogController.SetMessage($"Numero de clasificaciones: {Clasificaciones.Count}");
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
                OnPropertyChanged(nameof(NumeroClasificaciones));
            }
        }

        public async Task BuscarClasificacionesDeProveedorAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            _ultimoCatalogoCargado = TipoClasificacionEnum.Proveedor;

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Clasificaciones.Clear();
                foreach (var unidadMedida in _clasificacionRepository.TraerPorTipo(TipoClasificacionEnum.Proveedor))
                {
                    Clasificaciones.Add(unidadMedida);
                    progressDialogController.SetMessage($"Numero de clasificaciones: {Clasificaciones.Count}");
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
                OnPropertyChanged(nameof(NumeroClasificaciones));
            }
        }

        public async Task BuscarClasificacionesDeAlmacenAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            _ultimoCatalogoCargado = TipoClasificacionEnum.Almacen;

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Clasificaciones.Clear();
                foreach (var unidadMedida in _clasificacionRepository.TraerPorTipo(TipoClasificacionEnum.Almacen))
                {
                    Clasificaciones.Add(unidadMedida);
                    progressDialogController.SetMessage($"Numero de clasificaciones: {Clasificaciones.Count}");
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
                OnPropertyChanged(nameof(NumeroClasificaciones));
            }
        }

        public async Task BuscarClasificacionesDeProductoAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            _ultimoCatalogoCargado = TipoClasificacionEnum.Producto;

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Clasificaciones.Clear();
                foreach (var unidadMedida in _clasificacionRepository.TraerPorTipo(TipoClasificacionEnum.Producto))
                {
                    Clasificaciones.Add(unidadMedida);
                    progressDialogController.SetMessage($"Numero de clasificaciones: {Clasificaciones.Count}");
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
                OnPropertyChanged(nameof(NumeroClasificaciones));
            }
        }

        public async Task CrearValorClasificacionAsync()
        {
            try
            {
                var window = new CrearValorClasificacionView();
                window.ViewModel.Inicializar(ClasificacionSeleccionada.Id);
                window.ShowDialog();
                await CargarUltimaBusqueda();
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        public bool CanCrearValorClasificacionAsync()
        {
            return ClasificacionSeleccionada != null;
        }

        public async Task EditarValorClasificacionAsync()
        {
            try
            {
                var window = new EditarValorClasificacionView();
                window.ViewModel.Inicializar(ValorClasificacionSeleccionado.Id);
                window.ShowDialog();
                await CargarUltimaBusqueda();
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        public bool CanEditarValorClasificacionAsync()
        {
            return ValorClasificacionSeleccionado != null;
        }

        public async Task EliminarValorClasificacionAsync()
        {
            var messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this,
                "Eliminar Valor De Clasificacion",
                "Esta seguro de querer eliminar este valor de clasificacion?",
                MessageDialogStyle.AffirmativeAndNegative,
                new MetroDialogSettings {AffirmativeButtonText = "Eliminar", NegativeButtonText = "Cancelar"});

            if (messageDialogResult != MessageDialogResult.Affirmative)
            {
                return;
            }

            try
            {
                _valorClasificacionService.Eliminar(ValorClasificacionSeleccionado.Id);
                await CargarUltimaBusqueda();
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        public bool CanEliminarValorClasificacionAsync()
        {
            return ValorClasificacionSeleccionado != null;
        }

        private void RaiseGuards()
        {
            CrearValorClasificacionCommand.NotifyCanExecuteChanged();
            EditarValorClasificacionCommand.NotifyCanExecuteChanged();
            EliminarValorClasificacionCommand.NotifyCanExecuteChanged();
        }

        private bool UnidadesMedidaView_Filter(object obj)
        {
            if (!(obj is Clasificacion clasificaciones))
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return string.IsNullOrWhiteSpace(Filtro) ||
                   clasificaciones.Id.ToString().IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   clasificaciones.Nombre.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private async Task CargarUltimaBusqueda()
        {
            switch (_ultimoCatalogoCargado)
            {
                case TipoClasificacionEnum.Agente:
                    await BuscarClasificacionesDeAgenteAsync();
                    break;
                case TipoClasificacionEnum.Cliente:
                    await BuscarClasificacionesDeClienteAsync();
                    break;
                case TipoClasificacionEnum.Proveedor:
                    await BuscarClasificacionesDeProveedorAsync();
                    break;
                case TipoClasificacionEnum.Almacen:
                    await BuscarClasificacionesDeAlmacenAsync();
                    break;
                case TipoClasificacionEnum.Producto:
                    await BuscarClasificacionesDeProductoAsync();
                    break;
                case null:
                    await BuscarClasificacionesAsync();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
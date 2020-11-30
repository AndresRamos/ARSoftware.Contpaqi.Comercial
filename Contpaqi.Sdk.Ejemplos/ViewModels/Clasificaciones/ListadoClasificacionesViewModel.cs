using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
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
        private Clasificacion _clasificacionSeleccionada;
        private string _duracionBusqueda;
        private string _filtro;

        public ListadoClasificacionesViewModel(IClasificacionRepository<Clasificacion> clasificacionRepository, IDialogCoordinator dialogCoordinator)
        {
            _clasificacionRepository = clasificacionRepository;
            _dialogCoordinator = dialogCoordinator;
            Clasificaciones = new ObservableCollection<Clasificacion>();
            ClasificacionesView = CollectionViewSource.GetDefaultView(Clasificaciones);
            ClasificacionesView.Filter = UnidadesMedidaView_Filter;

            BuscarClasificacionesCommand = new AsyncRelayCommand(BuscarClasificacionesAsync);
            BuscarClasificacionesDeAgenteCommand = new AsyncRelayCommand(BuscarClasificacionesDeAgenteAsync);
            BuscarClasificacionesDeClienteCommand = new AsyncRelayCommand(BuscarClasificacionesDeClienteAsync);
            BuscarClasificacionesDeProveedorCommand = new AsyncRelayCommand(BuscarClasificacionesDeProveedorAsync);
            BuscarClasificacionesDeAlmacenCommand = new AsyncRelayCommand(BuscarClasificacionesDeAlmacenAsync);
            BuscarClasificacionesDeProductoCommand = new AsyncRelayCommand(BuscarClasificacionesDeProductoAsync);
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
            set => SetProperty(ref _clasificacionSeleccionada, value);
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

        public async Task BuscarClasificacionesAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

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
    }
}
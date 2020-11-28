using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;
using Contpaqi.Sdk.Extras.Modelos.Enums;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Productos
{
    public class ListadoProductosViewModel : ObservableRecipient
    {
        private readonly IDialogCoordinator _dialogCoordinator;
        private readonly IProductoRepositorio _productoRepositorio;
        private bool _buscarObjectosRelacionados;
        private string _duracionBusqueda;
        private string _filtro;
        private Producto _productoSeleccionado;

        public ListadoProductosViewModel(IProductoRepositorio productoRepositorio, IDialogCoordinator dialogCoordinator)
        {
            _productoRepositorio = productoRepositorio;
            _dialogCoordinator = dialogCoordinator;
            ProductosView = CollectionViewSource.GetDefaultView(Productos);
            ProductosView.Filter = ProductosView_Filter;

            BuscarTodoCommand = new AsyncRelayCommand(BuscarTodoAsync);
            BuscarProductosCommand = new AsyncRelayCommand(BuscarProductosAsync);
            BuscarServiciosCommand = new AsyncRelayCommand(BuscarServiciosAsync);
            BuscarPaquetesCommand = new AsyncRelayCommand(BuscarPaquetesAsync);
        }

        public string Title => "Productos";

        public string Filtro
        {
            get => _filtro;
            set
            {
                SetProperty(ref _filtro, value);
                ProductosView.Refresh();
                OnPropertyChanged(nameof(NumeroProductos));
            }
        }

        public ObservableCollection<Producto> Productos { get; } = new ObservableCollection<Producto>();

        public ICollectionView ProductosView { get; }

        public Producto ProductoSeleccionado
        {
            get => _productoSeleccionado;
            set => SetProperty(ref _productoSeleccionado, value);
        }

        public int NumeroProductos => ProductosView.Cast<object>().Count();

        public bool BuscarObjectosRelacionados
        {
            get => _buscarObjectosRelacionados;
            set => SetProperty(ref _buscarObjectosRelacionados, value);
        }

        public string DuracionBusqueda
        {
            get => _duracionBusqueda;
            set => SetProperty(ref _duracionBusqueda, value);
        }

        public IAsyncRelayCommand BuscarTodoCommand { get; }
        public IAsyncRelayCommand BuscarProductosCommand { get; }
        public IAsyncRelayCommand BuscarServiciosCommand { get; }
        public IAsyncRelayCommand BuscarPaquetesCommand { get; }

        public async Task BuscarTodoAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Productos.Clear();
                foreach (var producto in _productoRepositorio.TraerTodo())
                {
                    Productos.Add(producto);
                    progressDialogController.SetMessage($"Numero de productos: {Productos.Count}");
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
                OnPropertyChanged(nameof(NumeroProductos));
            }
        }

        public async Task BuscarProductosAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Productos.Clear();
                foreach (var producto in _productoRepositorio.TraerPorTipo(TipoProductoEnum.Producto))
                {
                    Productos.Add(producto);
                    progressDialogController.SetMessage($"Numero de productos: {Productos.Count}");
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
                OnPropertyChanged(nameof(NumeroProductos));
            }
        }

        public async Task BuscarServiciosAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Productos.Clear();

                foreach (var servicio in _productoRepositorio.TraerPorTipo(TipoProductoEnum.Servicio))
                {
                    Productos.Add(servicio);
                    progressDialogController.SetMessage($"Numero de servicios: {Productos.Count}");
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
                OnPropertyChanged(nameof(NumeroProductos));
            }
        }

        public async Task BuscarPaquetesAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Productos.Clear();
                foreach (var paquete in _productoRepositorio.TraerPorTipo(TipoProductoEnum.Paquete))
                {
                    Productos.Add(paquete);
                    progressDialogController.SetMessage($"Numero de paquetes: {Productos.Count}");
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
                OnPropertyChanged(nameof(NumeroProductos));
            }
        }

        private bool ProductosView_Filter(object obj)
        {
            var producto = obj as Producto;
            if (producto is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return string.IsNullOrWhiteSpace(Filtro) ||
                   producto.Codigo.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   producto.Nombre.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   producto.Descripcion.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
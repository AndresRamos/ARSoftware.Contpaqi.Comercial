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
using Sdk.Extras.WpfApp.Views.Productos;

namespace Sdk.Extras.WpfApp.ViewModels.Productos;

public class ListadoProductosViewModel : ObservableRecipient
{
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IProductoRepository<Producto> _productoRepository;
    private readonly IUnidadMedidaRepository<UnidadMedida> _unidadMedidaRepository;
    private readonly IValorClasificacionRepository<ValorClasificacion> _valorClasificacionRepository;
    private bool _buscarObjectosRelacionados;
    private string _duracionBusqueda;
    private string _filtro;
    private Producto _productoSeleccionado;

    public ListadoProductosViewModel(IProductoRepository<Producto> productoRepository, IDialogCoordinator dialogCoordinator,
        IUnidadMedidaRepository<UnidadMedida> unidadMedidaRepository,
        IValorClasificacionRepository<ValorClasificacion> valorClasificacionRepository)
    {
        _productoRepository = productoRepository;
        _dialogCoordinator = dialogCoordinator;
        _unidadMedidaRepository = unidadMedidaRepository;
        _valorClasificacionRepository = valorClasificacionRepository;
        ProductosView = CollectionViewSource.GetDefaultView(Productos);
        ProductosView.Filter = ProductosView_Filter;

        BuscarTodoCommand = new AsyncRelayCommand(BuscarTodoAsync);
        BuscarProductosCommand = new AsyncRelayCommand(BuscarProductosAsync);
        BuscarServiciosCommand = new AsyncRelayCommand(BuscarServiciosAsync);
        BuscarPaquetesCommand = new AsyncRelayCommand(BuscarPaquetesAsync);
        CrearProductoCommand = new AsyncRelayCommand(CrearProductoAsync);
        EditarProductoCommand = new AsyncRelayCommand(EditarProductoAsync, CanEditarProducto);
    }

    public bool BuscarObjectosRelacionados
    {
        get => _buscarObjectosRelacionados;
        set => SetProperty(ref _buscarObjectosRelacionados, value);
    }

    public IAsyncRelayCommand BuscarPaquetesCommand { get; }
    public IAsyncRelayCommand BuscarProductosCommand { get; }
    public IAsyncRelayCommand BuscarServiciosCommand { get; }

    public IAsyncRelayCommand BuscarTodoCommand { get; }
    public IAsyncRelayCommand CrearProductoCommand { get; }

    public string DuracionBusqueda
    {
        get => _duracionBusqueda;
        set => SetProperty(ref _duracionBusqueda, value);
    }

    public IAsyncRelayCommand EditarProductoCommand { get; }

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

    public int NumeroProductos => ProductosView.Cast<object>().Count();

    public ObservableCollection<Producto> Productos { get; } = new();

    public Producto ProductoSeleccionado
    {
        get => _productoSeleccionado;
        set
        {
            SetProperty(ref _productoSeleccionado, value);
            RaiseGuards();
        }
    }

    public ICollectionView ProductosView { get; }

    public string Title => "Productos";

    private async Task BuscarPaquetesAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Productos.Clear();
            foreach (Producto paquete in _productoRepository.TraerPorTipo(TipoProducto.Paquete))
            {
                CargarRelaciones(paquete);
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

    private async Task BuscarProductosAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Productos.Clear();
            foreach (Producto producto in _productoRepository.TraerPorTipo(TipoProducto.Producto))
            {
                CargarRelaciones(producto);
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

    private async Task BuscarServiciosAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Productos.Clear();

            foreach (Producto servicio in _productoRepository.TraerPorTipo(TipoProducto.Servicio))
            {
                CargarRelaciones(servicio);
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

    private async Task BuscarTodoAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Productos.Clear();
            foreach (Producto producto in _productoRepository.TraerTodo())
            {
                CargarRelaciones(producto);
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

    private bool CanEditarProducto()
    {
        return ProductoSeleccionado is not null;
    }

    private void CargarRelaciones(Producto producto)
    {
        producto.UnidadBase = _unidadMedidaRepository.BuscarPorId(producto.CIDUNIDADBASE);
        producto.UnidadNoConvertible = _unidadMedidaRepository.BuscarPorId(producto.CIDUNIDADNOCONVERTIBLE);
        producto.ValorClasificacion1 = _valorClasificacionRepository.BuscarPorId(producto.CIDVALORCLASIFICACION1);
        producto.ValorClasificacion2 = _valorClasificacionRepository.BuscarPorId(producto.CIDVALORCLASIFICACION2);
        producto.ValorClasificacion3 = _valorClasificacionRepository.BuscarPorId(producto.CIDVALORCLASIFICACION3);
        producto.ValorClasificacion4 = _valorClasificacionRepository.BuscarPorId(producto.CIDVALORCLASIFICACION4);
        producto.ValorClasificacion5 = _valorClasificacionRepository.BuscarPorId(producto.CIDVALORCLASIFICACION5);
        producto.ValorClasificacion6 = _valorClasificacionRepository.BuscarPorId(producto.CIDVALORCLASIFICACION6);
    }

    private async Task CrearProductoAsync()
    {
        try
        {
            var window = new EditarProductoView();
            window.ViewModel.Inicializar();
            window.Show();
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

    private async Task EditarProductoAsync()
    {
        try
        {
            var window = new EditarProductoView();
            window.ViewModel.Inicializar(ProductoSeleccionado.CIDPRODUCTO);
            window.Show();
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

    private bool ProductosView_Filter(object obj)
    {
        if (obj is not Producto producto) throw new ArgumentNullException(nameof(obj));

        return producto.Contains(Filtro);
    }

    private void RaiseGuards()
    {
        BuscarTodoCommand.NotifyCanExecuteChanged();
        BuscarProductosCommand.NotifyCanExecuteChanged();
        BuscarServiciosCommand.NotifyCanExecuteChanged();
        BuscarPaquetesCommand.NotifyCanExecuteChanged();
        CrearProductoCommand.NotifyCanExecuteChanged();
        EditarProductoCommand.NotifyCanExecuteChanged();
    }
}

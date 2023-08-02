using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MahApps.Metro.Controls.Dialogs;
using Sdk.Extras.WpfApp.Models;
using Sdk.Extras.WpfApp.Views.Clasificaciones;
using Sdk.Extras.WpfApp.Views.ValoresClasificacion;

namespace Sdk.Extras.WpfApp.ViewModels.Clasificaciones;

public class ListadoClasificacionesViewModel : ObservableRecipient
{
    private readonly IClasificacionRepository<Clasificacion> _clasificacionRepository;
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IValorClasificacionRepository<ValorClasificacion> _valorClasificacionRepository;

    private readonly IValorClasificacionService _valorClasificacionService;
    private Clasificacion _clasificacionSeleccionada;
    private string _duracionBusqueda;
    private string _filtro;
    private TipoClasificacion? _ultimoCatalogoCargado;
    private ValorClasificacion _valorClasificacionSeleccionado;

    public ListadoClasificacionesViewModel(IClasificacionRepository<Clasificacion> clasificacionRepository,
        IDialogCoordinator dialogCoordinator, IValorClasificacionService valorClasificacionService,
        IValorClasificacionRepository<ValorClasificacion> valorClasificacionRepository)
    {
        _clasificacionRepository = clasificacionRepository;
        _dialogCoordinator = dialogCoordinator;
        _valorClasificacionService = valorClasificacionService;
        _valorClasificacionRepository = valorClasificacionRepository;
        Clasificaciones = new ObservableCollection<Clasificacion>();
        ClasificacionesView = CollectionViewSource.GetDefaultView(Clasificaciones);
        ClasificacionesView.Filter = UnidadesMedidaView_Filter;

        BuscarClasificacionesCommand = new AsyncRelayCommand(BuscarClasificacionesAsync);
        BuscarClasificacionesDeAgenteCommand = new AsyncRelayCommand(BuscarClasificacionesDeAgenteAsync);
        BuscarClasificacionesDeClienteCommand = new AsyncRelayCommand(BuscarClasificacionesDeClienteAsync);
        BuscarClasificacionesDeProveedorCommand = new AsyncRelayCommand(BuscarClasificacionesDeProveedorAsync);
        BuscarClasificacionesDeAlmacenCommand = new AsyncRelayCommand(BuscarClasificacionesDeAlmacenAsync);
        BuscarClasificacionesDeProductoCommand = new AsyncRelayCommand(BuscarClasificacionesDeProductoAsync);

        EditarClasificacionCommand = new AsyncRelayCommand(EditarClasificacionAsync, CanEditarClasificacion);

        CrearValorClasificacionCommand = new AsyncRelayCommand(CrearValorClasificacionAsync, CanCrearValorClasificacionAsync);
        EditarValorClasificacionCommand = new AsyncRelayCommand(EditarValorClasificacionAsync, CanEditarValorClasificacionAsync);
        EliminarValorClasificacionCommand = new AsyncRelayCommand(EliminarValorClasificacionAsync, CanEliminarValorClasificacionAsync);
    }

    public IAsyncRelayCommand BuscarClasificacionesCommand { get; }
    public IAsyncRelayCommand BuscarClasificacionesDeAgenteCommand { get; }
    public IAsyncRelayCommand BuscarClasificacionesDeAlmacenCommand { get; }
    public IAsyncRelayCommand BuscarClasificacionesDeClienteCommand { get; }
    public IAsyncRelayCommand BuscarClasificacionesDeProductoCommand { get; }
    public IAsyncRelayCommand BuscarClasificacionesDeProveedorCommand { get; }

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

    public IAsyncRelayCommand CrearValorClasificacionCommand { get; }

    public string DuracionBusqueda
    {
        get => _duracionBusqueda;
        private set => SetProperty(ref _duracionBusqueda, value);
    }

    public IAsyncRelayCommand EditarClasificacionCommand { get; }
    public IAsyncRelayCommand EditarValorClasificacionCommand { get; }
    public IAsyncRelayCommand EliminarValorClasificacionCommand { get; }

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

    public int NumeroClasificaciones => ClasificacionesView.Cast<object>().Count();

    public string Title => "Clasificaciones";

    public ValorClasificacion ValorClasificacionSeleccionado
    {
        get => _valorClasificacionSeleccionado;
        set
        {
            SetProperty(ref _valorClasificacionSeleccionado, value);
            RaiseGuards();
        }
    }

    public async Task BuscarClasificacionesAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        _ultimoCatalogoCargado = null;

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Clasificaciones.Clear();
            foreach (Clasificacion clasificacion in _clasificacionRepository.TraerTodo())
            {
                clasificacion.Valores = _valorClasificacionRepository.TraerPorClasificacionId(clasificacion.CIDCLASIFICACION).ToList();

                Clasificaciones.Add(clasificacion);
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
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        _ultimoCatalogoCargado = TipoClasificacion.Agente;

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Clasificaciones.Clear();
            foreach (Clasificacion unidadMedida in _clasificacionRepository.TraerPorTipo(TipoClasificacion.Agente))
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
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        _ultimoCatalogoCargado = TipoClasificacion.Almacen;

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Clasificaciones.Clear();
            foreach (Clasificacion unidadMedida in _clasificacionRepository.TraerPorTipo(TipoClasificacion.Almacen))
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
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        _ultimoCatalogoCargado = TipoClasificacion.Cliente;

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Clasificaciones.Clear();
            foreach (Clasificacion unidadMedida in _clasificacionRepository.TraerPorTipo(TipoClasificacion.Cliente))
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
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        _ultimoCatalogoCargado = TipoClasificacion.Producto;

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Clasificaciones.Clear();
            foreach (Clasificacion unidadMedida in _clasificacionRepository.TraerPorTipo(TipoClasificacion.Producto))
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
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        _ultimoCatalogoCargado = TipoClasificacion.Proveedor;

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Clasificaciones.Clear();
            foreach (Clasificacion unidadMedida in _clasificacionRepository.TraerPorTipo(TipoClasificacion.Proveedor))
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

    public bool CanCrearValorClasificacionAsync()
    {
        return ClasificacionSeleccionada != null;
    }

    private bool CanEditarClasificacion()
    {
        return ClasificacionSeleccionada is not null;
    }

    public bool CanEditarValorClasificacionAsync()
    {
        return ValorClasificacionSeleccionado != null;
    }

    public bool CanEliminarValorClasificacionAsync()
    {
        return ValorClasificacionSeleccionado != null;
    }

    private async Task CargarUltimaBusqueda()
    {
        switch (_ultimoCatalogoCargado)
        {
            case TipoClasificacion.Agente:
                await BuscarClasificacionesDeAgenteAsync();
                break;
            case TipoClasificacion.Cliente:
                await BuscarClasificacionesDeClienteAsync();
                break;
            case TipoClasificacion.Proveedor:
                await BuscarClasificacionesDeProveedorAsync();
                break;
            case TipoClasificacion.Almacen:
                await BuscarClasificacionesDeAlmacenAsync();
                break;
            case TipoClasificacion.Producto:
                await BuscarClasificacionesDeProductoAsync();
                break;
            case null:
                await BuscarClasificacionesAsync();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public async Task CrearValorClasificacionAsync()
    {
        try
        {
            var window = new CrearValorClasificacionView();
            window.ViewModel.Inicializar(ClasificacionSeleccionada.CIDCLASIFICACION);
            window.ShowDialog();
            await CargarUltimaBusqueda();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    private async Task EditarClasificacionAsync()
    {
        try
        {
            var window = new EditarClasificacionView();
            window.ViewModel.Inicializar(ClasificacionSeleccionada.CIDCLASIFICACION);
            window.ShowDialog();

            await _dialogCoordinator.ShowMessageAsync(this, "Volver A Buscar Catalogo",
                "Para ver los cambios reflejados volver a buscar el catalogo.");
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public async Task EditarValorClasificacionAsync()
    {
        try
        {
            var window = new EditarValorClasificacionView();
            window.ViewModel.Inicializar(ValorClasificacionSeleccionado.CIDCLASIFICACION);
            window.ShowDialog();
            await CargarUltimaBusqueda();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public async Task EliminarValorClasificacionAsync()
    {
        MessageDialogResult messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this, "Eliminar Valor De Clasificacion",
            "Esta seguro de querer eliminar este valor de clasificacion?", MessageDialogStyle.AffirmativeAndNegative,
            new MetroDialogSettings { AffirmativeButtonText = "Eliminar", NegativeButtonText = "Cancelar" });

        if (messageDialogResult != MessageDialogResult.Affirmative) return;

        try
        {
            _valorClasificacionService.Eliminar(ValorClasificacionSeleccionado.CIDCLASIFICACION);
            await CargarUltimaBusqueda();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    private void RaiseGuards()
    {
        EditarClasificacionCommand.NotifyCanExecuteChanged();
        CrearValorClasificacionCommand.NotifyCanExecuteChanged();
        EditarValorClasificacionCommand.NotifyCanExecuteChanged();
        EliminarValorClasificacionCommand.NotifyCanExecuteChanged();
    }

    private bool UnidadesMedidaView_Filter(object obj)
    {
        if (!(obj is Clasificacion clasificacion)) throw new ArgumentNullException(nameof(obj));

        return clasificacion.Contains(Filtro);
    }
}

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MahApps.Metro.Controls.Dialogs;
using Sdk.Extras.WpfApp.Models;
using Sdk.Extras.WpfApp.Views.Almacenes;

namespace Sdk.Extras.WpfApp.ViewModels.Almacenes;

public class ListadoAlmacenesViewModel : ObservableRecipient
{
    private readonly IAlmacenRepository<Almacen> _almacenRepository;
    private readonly IDialogCoordinator _dialogCoordinator;
    private Almacen _almacenSeleccionado;
    private string _duracionBusqueda;
    private string _filtro;

    public ListadoAlmacenesViewModel(IAlmacenRepository<Almacen> almacenRepository, IDialogCoordinator dialogCoordinator)
    {
        _almacenRepository = almacenRepository;
        _dialogCoordinator = dialogCoordinator;
        Almacenes = new ObservableCollection<Almacen>();
        AlmacenesView = CollectionViewSource.GetDefaultView(Almacenes);
        AlmacenesView.Filter = AlmacenesView_Filter;

        BuscarAlmacenesCommand = new AsyncRelayCommand(BuscarAlmacenesAsync);
        CrearAlmacenCommand = new AsyncRelayCommand(CrearAlmacenAsync);
        EditarAlmacenCommand = new AsyncRelayCommand(EditarAlmacenAsync, CanEditarAlmacen);
    }

    public ObservableCollection<Almacen> Almacenes { get; }

    public ICollectionView AlmacenesView { get; }

    public Almacen AlmacenSeleccionado
    {
        get => _almacenSeleccionado;
        set
        {
            SetProperty(ref _almacenSeleccionado, value);
            RaiseGuards();
        }
    }

    public IAsyncRelayCommand BuscarAlmacenesCommand { get; }
    public IAsyncRelayCommand CrearAlmacenCommand { get; }

    public string DuracionBusqueda
    {
        get => _duracionBusqueda;
        private set => SetProperty(ref _duracionBusqueda, value);
    }

    public IAsyncRelayCommand EditarAlmacenCommand { get; }

    public string Filtro
    {
        get => _filtro;
        set
        {
            SetProperty(ref _filtro, value);
            AlmacenesView.Refresh();
            OnPropertyChanged(nameof(NumeroAlmacenes));
        }
    }

    public int NumeroAlmacenes => AlmacenesView.Cast<object>().Count();

    public string Title => "Almacenes";

    private bool AlmacenesView_Filter(object obj)
    {
        if (!(obj is Almacen almacen)) throw new ArgumentNullException(nameof(obj));

        return almacen.Contains(Filtro);
    }

    public async Task BuscarAlmacenesAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Almacenes.Clear();
            foreach (Almacen almacen in _almacenRepository.TraerTodo())
            {
                Almacenes.Add(almacen);
                progressDialogController.SetMessage($"Numero de almacenes: {Almacenes.Count}");
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
            OnPropertyChanged(nameof(NumeroAlmacenes));
        }
    }

    private bool CanEditarAlmacen()
    {
        return AlmacenSeleccionado is not null;
    }

    private async Task CrearAlmacenAsync()
    {
        try
        {
            var window = new EditarAlmacenView();
            window.ViewModel.Inicializar();
            window.ShowDialog();

            await _dialogCoordinator.ShowMessageAsync(this, "Volver A Buscar Catalogo",
                "Para ver los cambios reflejados volver a buscar el catalogo.");
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    private async Task EditarAlmacenAsync()
    {
        try
        {
            var window = new EditarAlmacenView();
            window.ViewModel.Inicializar(AlmacenSeleccionado.CIDALMACEN);
            window.ShowDialog();

            await _dialogCoordinator.ShowMessageAsync(this, "Volver A Buscar Catalogo",
                "Para ver los cambios reflejados volver a buscar el catalogo.");
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    private void RaiseGuards()
    {
        BuscarAlmacenesCommand.NotifyCanExecuteChanged();
        CrearAlmacenCommand.NotifyCanExecuteChanged();
        EditarAlmacenCommand.NotifyCanExecuteChanged();
    }
}

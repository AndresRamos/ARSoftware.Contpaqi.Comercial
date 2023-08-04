using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MahApps.Metro.Controls.Dialogs;
using Sdk.Extras.WpfApp.Models;
using Sdk.Extras.WpfApp.Views.UnidadesMedida;

namespace Sdk.Extras.WpfApp.ViewModels.UnidadesMedida;

public class ListadoUnidadesMedidaViewModel : ObservableRecipient
{
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IUnidadMedidaRepository<UnidadMedida> _unidadMedidaRepository;
    private readonly IUnidadMedidaService _unidadMedidaService;
    private string _duracionBusqueda;
    private string _filtro;
    private UnidadMedida _unidadMedidaSeleccionada;

    public ListadoUnidadesMedidaViewModel(IUnidadMedidaRepository<UnidadMedida> unidadMedidaRepository,
        IDialogCoordinator dialogCoordinator, IUnidadMedidaService unidadMedidaService)
    {
        _unidadMedidaRepository = unidadMedidaRepository;
        _dialogCoordinator = dialogCoordinator;
        _unidadMedidaService = unidadMedidaService;
        UnidadesMedida = new ObservableCollection<UnidadMedida>();
        UnidadesMedidaView = CollectionViewSource.GetDefaultView(UnidadesMedida);
        UnidadesMedidaView.Filter = UnidadesMedidaView_Filter;

        BuscarUnidadesCommand = new AsyncRelayCommand(BuscarUnidadesAsync);
        CrearUnidadCommand = new AsyncRelayCommand(CrearUnidadAsync);
        EditarUnidadCommand = new AsyncRelayCommand(EditarUnidadAsync, CanEditarUnidad);
        EliminarUnidadCommand = new AsyncRelayCommand(EliminarUnidadAsync, CanEliminarUnidad);
    }

    public IAsyncRelayCommand BuscarUnidadesCommand { get; }
    public IAsyncRelayCommand CrearUnidadCommand { get; }

    public string DuracionBusqueda
    {
        get => _duracionBusqueda;
        private set => SetProperty(ref _duracionBusqueda, value);
    }

    public IAsyncRelayCommand EditarUnidadCommand { get; }
    public IAsyncRelayCommand EliminarUnidadCommand { get; }

    public string Filtro
    {
        get => _filtro;
        set
        {
            SetProperty(ref _filtro, value);
            UnidadesMedidaView.Refresh();
            OnPropertyChanged(nameof(NumeroUnidades));
        }
    }

    public int NumeroUnidades => UnidadesMedidaView.Cast<object>().Count();

    public string Title => "Unidades De Medida";

    public ObservableCollection<UnidadMedida> UnidadesMedida { get; }

    public ICollectionView UnidadesMedidaView { get; }

    public UnidadMedida UnidadMedidaSeleccionada
    {
        get => _unidadMedidaSeleccionada;
        set
        {
            SetProperty(ref _unidadMedidaSeleccionada, value);
            RaiseGuards();
        }
    }

    private async Task BuscarUnidadesAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            UnidadesMedida.Clear();
            foreach (UnidadMedida unidadMedida in _unidadMedidaRepository.TraerTodo())
            {
                UnidadesMedida.Add(unidadMedida);
                progressDialogController.SetMessage($"Numero de unidades: {UnidadesMedida.Count}");
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
            OnPropertyChanged(nameof(NumeroUnidades));
        }
    }

    private bool CanEditarUnidad()
    {
        return UnidadMedidaSeleccionada is not null;
    }

    private bool CanEliminarUnidad()
    {
        return UnidadMedidaSeleccionada is not null;
    }

    private async Task CrearUnidadAsync()
    {
        try
        {
            var window = new EditarUnidadMedidaView();
            window.ViewModel.Inicializar();
            window.Show();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    private async Task EditarUnidadAsync()
    {
        try
        {
            var window = new EditarUnidadMedidaView();
            window.ViewModel.Inicializar(UnidadMedidaSeleccionada.CIDUNIDAD);
            window.Show();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    private async Task EliminarUnidadAsync()
    {
        try
        {
            MessageDialogResult messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this, "Eliminar Unidad De Medida",
                "Esta seguro de querer eliminar la unidad de medida?", MessageDialogStyle.AffirmativeAndNegative,
                new MetroDialogSettings { AffirmativeButtonText = "Si", NegativeButtonText = "Cancelar" });

            if (messageDialogResult != MessageDialogResult.Affirmative) return;

            _unidadMedidaService.Eliminar(UnidadMedidaSeleccionada.CIDUNIDAD);

            await BuscarUnidadesAsync();
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

    private void RaiseGuards()
    {
        BuscarUnidadesCommand.NotifyCanExecuteChanged();
        CrearUnidadCommand.NotifyCanExecuteChanged();
        EditarUnidadCommand.NotifyCanExecuteChanged();
        EliminarUnidadCommand.NotifyCanExecuteChanged();
    }

    private bool UnidadesMedidaView_Filter(object obj)
    {
        if (!(obj is UnidadMedida unidadMedida)) throw new ArgumentNullException(nameof(obj));

        return unidadMedida.Contains(Filtro);
    }
}

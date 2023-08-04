using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MahApps.Metro.Controls.Dialogs;

namespace Sdk.Extras.WpfApp.ViewModels.Parametros;

public class ParametrosViewModel : ObservableRecipient
{
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IParametrosRepository<Models.Parametros> _parametrosRepository;
    private string _duracionBusqueda;

    public ParametrosViewModel(IParametrosRepository<Models.Parametros> parametrosRepository, IDialogCoordinator dialogCoordinator)
    {
        _parametrosRepository = parametrosRepository;
        _dialogCoordinator = dialogCoordinator;

        BuscarParametrosCommand = new AsyncRelayCommand(CargarParametrosAsync);
    }

    public IAsyncRelayCommand BuscarParametrosCommand { get; }

    public string DuracionBusqueda
    {
        get => _duracionBusqueda;
        private set => SetProperty(ref _duracionBusqueda, value);
    }

    public ObservableCollection<Models.Parametros> Parametros { get; } = new();

    public string Title => "Parametros";

    private async Task CargarParametrosAsync()
    {
        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Parametros.Clear();
            Parametros.Add(_parametrosRepository.Buscar());
            stopwatch.Stop();
            DuracionBusqueda = stopwatch.Elapsed.ToString("g");
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }
}

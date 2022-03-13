using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Parametros;

public class ParametrosViewModel : ObservableRecipient
{
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IParametrosRepository<Sdk.Extras.Models.Parametros> _parametrosRepository;
    private string _duracionBusqueda;

    public ParametrosViewModel(IParametrosRepository<Sdk.Extras.Models.Parametros> parametrosRepository,
                               IDialogCoordinator dialogCoordinator)
    {
        _parametrosRepository = parametrosRepository;
        _dialogCoordinator = dialogCoordinator;

        BuscarParametrosCommand = new AsyncRelayCommand(CargarParametrosAsync);
    }

    public string Title => "Parametros";

    public ObservableCollection<Sdk.Extras.Models.Parametros> Parametros { get; } = new();

    public IAsyncRelayCommand BuscarParametrosCommand { get; }

    public string DuracionBusqueda
    {
        get => _duracionBusqueda;
        private set => SetProperty(ref _duracionBusqueda, value);
    }

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

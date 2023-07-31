using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Data;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MahApps.Metro.Controls.Dialogs;

namespace Sdk.Extras.WpfApp.ViewModels.Errores;

public class ListadoErroresViewModel : ObservableRecipient
{
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly ISdkErrorRepository<SdkError> _sdkErrorRepository;
    private int _codigoFin = int.MaxValue - 1;
    private int _codigoInicio;
    private string _duracionBusqueda;
    private string _filtro;

    public ListadoErroresViewModel(ISdkErrorRepository<SdkError> sdkErrorRepository, IDialogCoordinator dialogCoordinator)
    {
        _sdkErrorRepository = sdkErrorRepository;
        _dialogCoordinator = dialogCoordinator;

        ErroresView = CollectionViewSource.GetDefaultView(Errores);
        ErroresView.Filter = ErroresView_Filter;

        BuscarErroresCommand = new AsyncRelayCommand(BuscarErroresAsync, CanBuscarErrores);
    }

    public IAsyncRelayCommand BuscarErroresCommand { get; }

    public int CodigoFin
    {
        get => _codigoFin;
        set
        {
            SetProperty(ref _codigoFin, value);
            BuscarErroresCommand.NotifyCanExecuteChanged();
        }
    }

    public int CodigoInicio
    {
        get => _codigoInicio;
        set
        {
            SetProperty(ref _codigoInicio, value);
            BuscarErroresCommand.NotifyCanExecuteChanged();
        }
    }

    public string DuracionBusqueda
    {
        get => _duracionBusqueda;
        set => SetProperty(ref _duracionBusqueda, value);
    }

    public ObservableCollection<SdkError> Errores { get; } = new();

    public ICollectionView ErroresView { get; }

    public string Filtro
    {
        get => _filtro;
        set
        {
            SetProperty(ref _filtro, value);
            ErroresView.Refresh();
        }
    }

    public string Title { get; } = "Errores";

    public async Task BuscarErroresAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        Errores.Clear();

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = CodigoInicio; i <= CodigoFin; i++)
            {
                Debug.WriteLine(i);
                string errorMensaje = _sdkErrorRepository.BuscarMensajePorNumero(i);
                if (errorMensaje is "" or "CACSql.dll" or "Plataforma" or ".") continue;

                Errores.Add(new SdkError(i, errorMensaje));
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
            OnPropertyChanged(string.Empty);
        }
    }

    public bool CanBuscarErrores()
    {
        return CodigoInicio <= CodigoFin;
    }

    private bool ErroresView_Filter(object obj)
    {
        var error = obj as SdkError;
        if (error is null) throw new ArgumentException("El tipo no es valido", nameof(obj));

        return string.IsNullOrWhiteSpace(Filtro) ||
               error.Numero.ToString().IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               error.Mensaje.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0;
    }
}

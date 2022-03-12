using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Data;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Errores;

public class ListadoErroresViewModel : ObservableRecipient
{
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly ISdkErrorRepository<SdkError> _sdkErrorRepository;
    private string _duracionBusqueda;
    private string _filtro;

    public ListadoErroresViewModel(ISdkErrorRepository<SdkError> sdkErrorRepository, IDialogCoordinator dialogCoordinator)
    {
        _sdkErrorRepository = sdkErrorRepository;
        _dialogCoordinator = dialogCoordinator;

        ErroresView = CollectionViewSource.GetDefaultView(Errores);
        ErroresView.Filter = ErroresView_Filter;

        BuscarErroresCommand = new AsyncRelayCommand(BuscarErroresAsync);
    }

    public string Title { get; } = "Errores";

    public string Filtro
    {
        get => _filtro;
        set
        {
            SetProperty(ref _filtro, value);
            ErroresView.Refresh();
        }
    }

    public List<SdkError> Errores { get; } = new();

    public ICollectionView ErroresView { get; }

    public IAsyncRelayCommand BuscarErroresCommand { get; }

    public string DuracionBusqueda
    {
        get => _duracionBusqueda;
        set => SetProperty(ref _duracionBusqueda, value);
    }

    private bool ErroresView_Filter(object obj)
    {
        var error = obj as SdkError;
        if (error is null)
        {
            throw new ArgumentException("El tipo no es valido", nameof(obj));
        }

        return string.IsNullOrWhiteSpace(Filtro) ||
               error.Numero.ToString().IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               error.Mensaje.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    public async Task BuscarErroresAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        Errores.Clear();

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (var i = 0; i < int.MaxValue; i++)
            {
                string errorMensaje = _sdkErrorRepository.BuscarMensajePorNumero(i);
                if (errorMensaje == string.Empty || errorMensaje == "CACSql.dll")
                {
                    continue;
                }

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
}

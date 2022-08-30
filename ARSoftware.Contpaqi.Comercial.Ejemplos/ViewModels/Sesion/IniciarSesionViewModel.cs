using System;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MahApps.Metro.Controls.Dialogs;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Sesion;

public sealed class IniciarSesionViewModel : ObservableRecipient
{
    private readonly IComercialSdkSesionService _comercialSdkSesionService;
    private readonly IDialogCoordinator _dialogCoordinator;
    private string _contrasena = string.Empty;
    private string _contrasenaContabilidad = string.Empty;
    private string _nombreUsuario = "SUPERVISOR";
    private string _nombreUsuarioContabilidad = "SUPERVISOR";

    public IniciarSesionViewModel(IComercialSdkSesionService comercialSdkSesionService, IDialogCoordinator dialogCoordinator)
    {
        _comercialSdkSesionService = comercialSdkSesionService;
        _dialogCoordinator = dialogCoordinator;
        IniciarSesionSdkCommand = new AsyncRelayCommand(IniciarSesionSdkAsync);
        IniciarSesionSdkParametrosCommand = new AsyncRelayCommand(IniciarSesionSdkParametrosAsync, CanIniciarSesionSdkParametrosAsync);
        IniciarSesionSdkParametrosContabilidadCommand = new AsyncRelayCommand(IniciarSesionSdkParametrosContabilidadAsync,
            CanIniciarSesionSdkParametrosContabilidadAsync);
        CerrarVistaCommand = new RelayCommand(CerrarVista);
    }

    public string Title { get; } = "Iniciar Sesion";

    public string NombreUsuario
    {
        get => _nombreUsuario;
        set
        {
            SetProperty(ref _nombreUsuario, value);
            RaiseGuards();
        }
    }

    public string Contrasena
    {
        get => _contrasena;
        set
        {
            SetProperty(ref _contrasena, value);
            RaiseGuards();
        }
    }

    public string NombreUsuarioContabilidad
    {
        get => _nombreUsuarioContabilidad;
        set
        {
            SetProperty(ref _nombreUsuarioContabilidad, value);
            RaiseGuards();
        }
    }

    public string ContrasenaContabilidad
    {
        get => _contrasenaContabilidad;
        set
        {
            SetProperty(ref _contrasenaContabilidad, value);
            RaiseGuards();
        }
    }

    public IAsyncRelayCommand IniciarSesionSdkCommand { get; }
    public IAsyncRelayCommand IniciarSesionSdkParametrosCommand { get; }
    public IAsyncRelayCommand IniciarSesionSdkParametrosContabilidadCommand { get; }
    public IRelayCommand CerrarVistaCommand { get; }

    public async Task IniciarSesionSdkAsync()
    {
        try
        {
            _comercialSdkSesionService.IniciarSesionSdk();
            CerrarVista();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public async Task IniciarSesionSdkParametrosAsync()
    {
        try
        {
            _comercialSdkSesionService.IniciarSesionSdk(NombreUsuario, Contrasena);
            CerrarVista();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public bool CanIniciarSesionSdkParametrosAsync()
    {
        return !string.IsNullOrWhiteSpace(NombreUsuario);
    }

    public bool CanIniciarSesionSdkParametrosContabilidadAsync()
    {
        return !string.IsNullOrWhiteSpace(NombreUsuario) && !string.IsNullOrWhiteSpace(NombreUsuarioContabilidad);
    }

    public async Task IniciarSesionSdkParametrosContabilidadAsync()
    {
        try
        {
            _comercialSdkSesionService.IniciarSesionSdk(NombreUsuario, Contrasena, NombreUsuarioContabilidad, ContrasenaContabilidad);
            CerrarVista();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    private void RaiseGuards()
    {
        IniciarSesionSdkCommand.NotifyCanExecuteChanged();
        IniciarSesionSdkParametrosCommand.NotifyCanExecuteChanged();
        IniciarSesionSdkParametrosContabilidadCommand.NotifyCanExecuteChanged();
        CerrarVistaCommand.NotifyCanExecuteChanged();
    }
}

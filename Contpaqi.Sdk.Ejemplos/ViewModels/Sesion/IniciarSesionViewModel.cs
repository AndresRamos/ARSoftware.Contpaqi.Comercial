using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Extras.Interfaces;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Sesion
{
    public sealed class IniciarSesionViewModel : ObservableRecipient
    {
        private readonly IComercialSdkSesionServicio _comercialSdkSesionServicio;
        private readonly IDialogCoordinator _dialogCoordinator;
        private string _contrasena = string.Empty;
        private string _nombreUsuario = "SUPERVISOR";

        public IniciarSesionViewModel(IComercialSdkSesionServicio comercialSdkSesionServicio, IDialogCoordinator dialogCoordinator)
        {
            _comercialSdkSesionServicio = comercialSdkSesionServicio;
            _dialogCoordinator = dialogCoordinator;
            IniciarSesionSdkCommand = new AsyncRelayCommand(IniciarSesionSdkAsync);
            IniciarSesionSdkParametrosCommand = new AsyncRelayCommand(IniciarSesionSdkParametrosAsync, CanIniciarSesionSdkParametrosAsync);
            CerrarVistaCommand = new RelayCommand(CerrarVista);
        }

        public string Title { get; } = "Iniciar Sesion";

        public string NombreUsuario
        {
            get => _nombreUsuario;
            set => SetProperty(ref _nombreUsuario, value);
        }

        public string Contrasena
        {
            get => _contrasena;
            set => SetProperty(ref _contrasena, value);
        }

        public IAsyncRelayCommand IniciarSesionSdkCommand { get; }
        public IAsyncRelayCommand IniciarSesionSdkParametrosCommand { get; }
        public ICommand CerrarVistaCommand { get; }

        public async Task IniciarSesionSdkAsync()
        {
            try
            {
                _comercialSdkSesionServicio.IniciarSesionSdk();
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
                _comercialSdkSesionServicio.IniciarSesionSdk(NombreUsuario, Contrasena);
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

        public void CerrarVista()
        {
            Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
        }
    }
}
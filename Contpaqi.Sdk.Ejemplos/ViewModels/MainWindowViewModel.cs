using System;
using System.Threading.Tasks;
using Contpaqi.Sdk.Ejemplos.Views.Clientes;
using Contpaqi.Sdk.Ejemplos.Views.Empresas;
using Contpaqi.Sdk.Ejemplos.Views.Sesion;
using Contpaqi.Sdk.Extras.Interfaces;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Contpaqi.Sdk.Ejemplos.ViewModels
{
    public class MainWindowViewModel : ObservableRecipient
    {
        private readonly IComercialSdkSesionServicio _comercialSdkSesionServicio;
        private readonly IDialogCoordinator _dialogCoordinator;

        public MainWindowViewModel(IDialogCoordinator dialogCoordinator, IComercialSdkSesionServicio comercialSdkSesionServicio)
        {
            _dialogCoordinator = dialogCoordinator;
            _comercialSdkSesionServicio = comercialSdkSesionServicio;

            MostrarIniciarSesionViewCommand = new AsyncRelayCommand(MostrarIniciarSesionViewAsync, CanMostrarIniciarSesionView);
            TerminarSesionCommand = new AsyncRelayCommand(TerminarSesionAsync, CanTerminarSesionAsync);
            AbrirEmpresaCommand = new AsyncRelayCommand(AbrirEmpresaAsync, CanAbrirEmpresaAsync);
            CerrarEmpresaCommand = new AsyncRelayCommand(CerrarEmpresaAsync, CanCerrarEmpresaAsync);
            MostarListadoClientesViewCommand = new RelayCommand(MostarListadoClientesView, CanMostarListadoClientesView);
        }

        public IAsyncRelayCommand MostrarIniciarSesionViewCommand { get; }
        public IAsyncRelayCommand TerminarSesionCommand { get; }
        public IAsyncRelayCommand AbrirEmpresaCommand { get; }
        public IAsyncRelayCommand CerrarEmpresaCommand { get; }
        public IRelayCommand MostarListadoClientesViewCommand { get; }

        public async Task MostrarIniciarSesionViewAsync()
        {
            try
            {
                var window = new IniciarSesionView();
                window.ShowDialog();
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

        public bool CanMostrarIniciarSesionView()
        {
            return _comercialSdkSesionServicio.PuedeIniciarSesion;
        }

        public async Task TerminarSesionAsync()
        {
            try
            {
                _comercialSdkSesionServicio.TerminarSesionSdk();
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

        public bool CanTerminarSesionAsync()
        {
            return _comercialSdkSesionServicio.PuedeTerminarSesion;
        }

        public async Task AbrirEmpresaAsync()
        {
            try
            {
                var window = new SeleccionarEmpresaView();
                window.ShowDialog();
                if (window.ViewModel.SeleccionoEmpresa)
                {
                    _comercialSdkSesionServicio.AbrirEmpresa(window.ViewModel.EmpresaSeleccionada.Ruta);
                }
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

        public bool CanAbrirEmpresaAsync()
        {
            return _comercialSdkSesionServicio.PuedeAbrirEmpresa;
        }

        public async Task CerrarEmpresaAsync()
        {
            try
            {
                _comercialSdkSesionServicio.CerrarEmpresa();
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

        public bool CanCerrarEmpresaAsync()
        {
            return _comercialSdkSesionServicio.PuedeCerrarEmpresa;
        }

        public void MostarListadoClientesView()
        {
            var window = new ListadoClientesView();
            window.Show();
        }

        public bool CanMostarListadoClientesView()
        {
            return _comercialSdkSesionServicio.SdkInicializado && _comercialSdkSesionServicio.EmpresaAbierta;
        }

        private void RaiseGuards()
        {
            MostrarIniciarSesionViewCommand.NotifyCanExecuteChanged();
            TerminarSesionCommand.NotifyCanExecuteChanged();
            AbrirEmpresaCommand.NotifyCanExecuteChanged();
            CerrarEmpresaCommand.NotifyCanExecuteChanged();
            MostarListadoClientesViewCommand.NotifyCanExecuteChanged();
        }
    }
}
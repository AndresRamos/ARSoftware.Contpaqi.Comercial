using System;
using System.Threading.Tasks;
using Contpaqi.Sdk.Ejemplos.Views.Agentes;
using Contpaqi.Sdk.Ejemplos.Views.Almacenes;
using Contpaqi.Sdk.Ejemplos.Views.Clientes;
using Contpaqi.Sdk.Ejemplos.Views.Empresas;
using Contpaqi.Sdk.Ejemplos.Views.Sesion;
using Contpaqi.Sdk.Extras.Interfaces;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Contpaqi.Sdk.Ejemplos.ViewModels
{
    public class MainViewModel : ObservableRecipient
    {
        private readonly IComercialSdkSesionServicio _comercialSdkSesionServicio;
        private readonly IDialogCoordinator _dialogCoordinator;

        public MainViewModel(IDialogCoordinator dialogCoordinator, IComercialSdkSesionServicio comercialSdkSesionServicio)
        {
            _dialogCoordinator = dialogCoordinator;
            _comercialSdkSesionServicio = comercialSdkSesionServicio;

            MostrarIniciarSesionViewCommand = new AsyncRelayCommand(MostrarIniciarSesionViewAsync, CanMostrarIniciarSesionView);
            TerminarSesionCommand = new AsyncRelayCommand(TerminarSesionAsync, CanTerminarSesionAsync);
            AbrirEmpresaCommand = new AsyncRelayCommand(AbrirEmpresaAsync, CanAbrirEmpresaAsync);
            CerrarEmpresaCommand = new AsyncRelayCommand(CerrarEmpresaAsync, CanCerrarEmpresaAsync);
            MostrarListadoClientesViewCommand = new RelayCommand(MostrarListadoClientesView, IsSdkListo);
            MostrarListadoProveedoresViewCommand = new RelayCommand(MostrarListadoProveedoresView, IsSdkListo);
            MostrarListadoAgentesViewCommand = new RelayCommand(MostrarListadoAgentesView, IsSdkListo);
            MostrarListadoAlmacenesViewCommand = new RelayCommand(MostrarListadoAlmacenesView, IsSdkListo);
        }

        public IAsyncRelayCommand MostrarIniciarSesionViewCommand { get; }
        public IAsyncRelayCommand TerminarSesionCommand { get; }
        public IAsyncRelayCommand AbrirEmpresaCommand { get; }
        public IAsyncRelayCommand CerrarEmpresaCommand { get; }
        public IRelayCommand MostrarListadoClientesViewCommand { get; }
        public IRelayCommand MostrarListadoProveedoresViewCommand { get; }
        public IRelayCommand MostrarListadoAgentesViewCommand { get; }
        public IRelayCommand MostrarListadoAlmacenesViewCommand { get; }

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

        public bool IsSdkListo()
        {
            return _comercialSdkSesionServicio.SdkInicializado && _comercialSdkSesionServicio.EmpresaAbierta;
        }

        public void MostrarListadoClientesView()
        {
            var window = new ListadoClientesView();
            window.Show();
        }

        public void MostrarListadoProveedoresView()
        {
            var window = new ListadoProveedoresView();
            window.Show();
        }

        public void MostrarListadoAgentesView()
        {
            var window = new ListadoAgentesView();
            window.Show();
        }

        public void MostrarListadoAlmacenesView()
        {
            var window = new ListadoAlmacenesView();
            window.Show();
        }

        private void RaiseGuards()
        {
            MostrarIniciarSesionViewCommand.NotifyCanExecuteChanged();
            TerminarSesionCommand.NotifyCanExecuteChanged();
            AbrirEmpresaCommand.NotifyCanExecuteChanged();
            CerrarEmpresaCommand.NotifyCanExecuteChanged();
            MostrarListadoClientesViewCommand.NotifyCanExecuteChanged();
            MostrarListadoProveedoresViewCommand.NotifyCanExecuteChanged();
            MostrarListadoAgentesViewCommand.NotifyCanExecuteChanged();
            MostrarListadoAlmacenesViewCommand.NotifyCanExecuteChanged();
        }
    }
}
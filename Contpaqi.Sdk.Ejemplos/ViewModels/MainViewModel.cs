using System;
using System.Text;
using System.Threading.Tasks;
using Contpaqi.Sdk.Ejemplos.Views.Agentes;
using Contpaqi.Sdk.Ejemplos.Views.Almacenes;
using Contpaqi.Sdk.Ejemplos.Views.Clasificaciones;
using Contpaqi.Sdk.Ejemplos.Views.Clientes;
using Contpaqi.Sdk.Ejemplos.Views.Conceptos;
using Contpaqi.Sdk.Ejemplos.Views.Documentos;
using Contpaqi.Sdk.Ejemplos.Views.Empresas;
using Contpaqi.Sdk.Ejemplos.Views.Productos;
using Contpaqi.Sdk.Ejemplos.Views.Sesion;
using Contpaqi.Sdk.Ejemplos.Views.UnidadesMedida;
using Contpaqi.Sdk.Extras.Interfaces;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Contpaqi.Sdk.Ejemplos.ViewModels
{
    public class MainViewModel : ObservableRecipient
    {
        private readonly IComercialSdkSesionService _comercialSdkSesionService;
        private readonly IDialogCoordinator _dialogCoordinator;

        public MainViewModel(IDialogCoordinator dialogCoordinator, IComercialSdkSesionService comercialSdkSesionService)
        {
            _dialogCoordinator = dialogCoordinator;
            _comercialSdkSesionService = comercialSdkSesionService;

            MostrarIniciarSesionViewCommand = new AsyncRelayCommand(MostrarIniciarSesionViewAsync, CanMostrarIniciarSesionView);
            TerminarSesionCommand = new AsyncRelayCommand(TerminarSesionAsync, CanTerminarSesionAsync);
            AbrirEmpresaCommand = new AsyncRelayCommand(AbrirEmpresaAsync, CanAbrirEmpresaAsync);
            CerrarEmpresaCommand = new AsyncRelayCommand(CerrarEmpresaAsync, CanCerrarEmpresaAsync);
            MostrarListadoClientesViewCommand = new RelayCommand(MostrarListadoClientesView, IsSdkListo);
            MostrarListadoAgentesViewCommand = new RelayCommand(MostrarListadoAgentesView, IsSdkListo);
            MostrarListadoAlmacenesViewCommand = new RelayCommand(MostrarListadoAlmacenesView, IsSdkListo);
            MostrarListadoProductosViewCommand = new RelayCommand(MostrarListadoProductosView, IsSdkListo);
            MostrarListadoConceptosViewCommand = new RelayCommand(MostrarListadoConceptosView, IsSdkListo);
            MostrarListadoUnidadesMedidaViewCommand = new RelayCommand(MostrarListadoUnidadesMedidaView, IsSdkListo);
            MostrarListadoClasificacionesViewCommand = new RelayCommand(MostrarListadoClasificacionesView, IsSdkListo);
            MostrarListadoDocumentosViewCommand = new RelayCommand(MostrarListadoDocumentosViewAsync, IsSdkListo);
        }

        public IAsyncRelayCommand MostrarIniciarSesionViewCommand { get; }
        public IAsyncRelayCommand TerminarSesionCommand { get; }
        public IAsyncRelayCommand AbrirEmpresaCommand { get; }
        public IAsyncRelayCommand CerrarEmpresaCommand { get; }
        public IRelayCommand MostrarListadoClientesViewCommand { get; }
        public IRelayCommand MostrarListadoAgentesViewCommand { get; }
        public IRelayCommand MostrarListadoAlmacenesViewCommand { get; }
        public IRelayCommand MostrarListadoProductosViewCommand { get; }
        public IRelayCommand MostrarListadoConceptosViewCommand { get; }
        public IRelayCommand MostrarListadoUnidadesMedidaViewCommand { get; }
        public IRelayCommand MostrarListadoClasificacionesViewCommand { get; }
        public IRelayCommand MostrarListadoDocumentosViewCommand { get; }

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
            return _comercialSdkSesionService.PuedeIniciarSesion;
        }

        public async Task TerminarSesionAsync()
        {
            try
            {
                _comercialSdkSesionService.TerminarSesionSdk();
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
            return _comercialSdkSesionService.PuedeTerminarSesion;
        }

        public async Task AbrirEmpresaAsync()
        {
            try
            {
                var window = new SeleccionarEmpresaView();
                window.ShowDialog();
                if (window.ViewModel.SeleccionoEmpresa)
                {
                    _comercialSdkSesionService.AbrirEmpresa(window.ViewModel.EmpresaSeleccionada.Ruta);
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
            return _comercialSdkSesionService.PuedeAbrirEmpresa;
        }

        public async Task CerrarEmpresaAsync()
        {
            try
            {
                _comercialSdkSesionService.CerrarEmpresa();
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
            return _comercialSdkSesionService.PuedeCerrarEmpresa;
        }

        public bool IsSdkListo()
        {
            return _comercialSdkSesionService.SdkInicializado && _comercialSdkSesionService.EmpresaAbierta;
        }

        public void MostrarListadoClientesView()
        {
            var window = new ListadoClientesView();
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

        public void MostrarListadoProductosView()
        {
            var window = new ListadoProductosView();
            window.Show();
        }

        public void MostrarListadoConceptosView()
        {
            var window = new ListadoConceptosView();
            window.Show();
        }

        public void MostrarListadoUnidadesMedidaView()
        {
            var window = new ListadoUnidadesMedidaView();
            window.Show();
        }

        public void MostrarListadoClasificacionesView()
        {
            var window = new ListadoClasificacionesView();
            window.Show();
        }

        public void MostrarListadoDocumentosViewAsync()
        {
            var window = new ListadoDocumentosView();
            window.Show();
        }

        public string Mensaje => GetMensage();

        public string GetMensage()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("En este proyecto podran enonctrar varios ejemplos de como utilizar el SDK para listar los multiples catalogos del sistema.");
            stringBuilder.AppendLine("Para mas informacion visiten la documentscion en Github en https://github.com/AndresRamos/Contpaqi");
            stringBuilder.AppendLine("Tambien pueden encontrar mas informacion acerca de otras utilerias en https://www.arsoft.net");
            return stringBuilder.ToString();
        }

        private void RaiseGuards()
        {
            MostrarIniciarSesionViewCommand.NotifyCanExecuteChanged();
            TerminarSesionCommand.NotifyCanExecuteChanged();
            AbrirEmpresaCommand.NotifyCanExecuteChanged();
            CerrarEmpresaCommand.NotifyCanExecuteChanged();
            MostrarListadoClientesViewCommand.NotifyCanExecuteChanged();
            MostrarListadoAgentesViewCommand.NotifyCanExecuteChanged();
            MostrarListadoAlmacenesViewCommand.NotifyCanExecuteChanged();
            MostrarListadoProductosViewCommand.NotifyCanExecuteChanged();
            MostrarListadoConceptosViewCommand.NotifyCanExecuteChanged();
            MostrarListadoUnidadesMedidaViewCommand.NotifyCanExecuteChanged();
            MostrarListadoClasificacionesViewCommand.NotifyCanExecuteChanged();
            MostrarListadoDocumentosViewCommand.NotifyCanExecuteChanged();
        }
    }
}
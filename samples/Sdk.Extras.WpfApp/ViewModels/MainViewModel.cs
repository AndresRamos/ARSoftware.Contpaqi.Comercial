using System;
using System.Text;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MahApps.Metro.Controls.Dialogs;
using Sdk.Extras.WpfApp.Models;
using Sdk.Extras.WpfApp.Views.Agentes;
using Sdk.Extras.WpfApp.Views.Almacenes;
using Sdk.Extras.WpfApp.Views.Clasificaciones;
using Sdk.Extras.WpfApp.Views.Clientes;
using Sdk.Extras.WpfApp.Views.Conceptos;
using Sdk.Extras.WpfApp.Views.Documentos;
using Sdk.Extras.WpfApp.Views.Empresas;
using Sdk.Extras.WpfApp.Views.Errores;
using Sdk.Extras.WpfApp.Views.Facturas;
using Sdk.Extras.WpfApp.Views.Parametros;
using Sdk.Extras.WpfApp.Views.Productos;
using Sdk.Extras.WpfApp.Views.Sesion;
using Sdk.Extras.WpfApp.Views.UnidadesMedida;

namespace Sdk.Extras.WpfApp.ViewModels;

public class MainViewModel : ObservableRecipient
{
    private readonly IComercialSdkSesionService _comercialSdkSesionService;
    private readonly ConfiguracionAplicacion _configuracionAplicacion;
    private readonly IDialogCoordinator _dialogCoordinator;

    public MainViewModel(IDialogCoordinator dialogCoordinator, IComercialSdkSesionService comercialSdkSesionService,
        ConfiguracionAplicacion configuracionAplicacion)
    {
        _dialogCoordinator = dialogCoordinator;
        _comercialSdkSesionService = comercialSdkSesionService;
        _configuracionAplicacion = configuracionAplicacion;

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
        MostrarListadoFacturasViewCommand = new RelayCommand(MostrarListadoFacturasViewAsync, IsSdkListo);
        MostrarListadoErroresViewCommand = new RelayCommand(MostrarListadoErroresViewAsync, IsSdkListo);
        MostrarParametrosViewCommand = new RelayCommand(MostrarParametrosViewAsync, IsSdkListo);
    }

    public IAsyncRelayCommand AbrirEmpresaCommand { get; }
    public IAsyncRelayCommand CerrarEmpresaCommand { get; }

    public string Mensaje => GetMensage();

    public IAsyncRelayCommand MostrarIniciarSesionViewCommand { get; }
    public IRelayCommand MostrarListadoAgentesViewCommand { get; }
    public IRelayCommand MostrarListadoAlmacenesViewCommand { get; }
    public IRelayCommand MostrarListadoClasificacionesViewCommand { get; }
    public IRelayCommand MostrarListadoClientesViewCommand { get; }
    public IRelayCommand MostrarListadoConceptosViewCommand { get; }
    public IRelayCommand MostrarListadoDocumentosViewCommand { get; }
    public IRelayCommand MostrarListadoErroresViewCommand { get; }
    public IRelayCommand MostrarListadoFacturasViewCommand { get; }
    public IRelayCommand MostrarListadoProductosViewCommand { get; }
    public IRelayCommand MostrarListadoUnidadesMedidaViewCommand { get; }
    public IRelayCommand MostrarParametrosViewCommand { get; }
    public IAsyncRelayCommand TerminarSesionCommand { get; }

    public async Task AbrirEmpresaAsync()
    {
        try
        {
            var window = new SeleccionarEmpresaView();
            window.ShowDialog();
            if (window.ViewModel.SeleccionoEmpresa)
            {
                _comercialSdkSesionService.AbrirEmpresa(window.ViewModel.EmpresaSeleccionada.CRUTADATOS);
                _configuracionAplicacion.Empresa = window.ViewModel.EmpresaSeleccionada;
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
        return _comercialSdkSesionService.CanAbrirEmpresa;
    }

    public bool CanCerrarEmpresaAsync()
    {
        return _comercialSdkSesionService.CanCerrarEmpresa;
    }

    public bool CanMostrarIniciarSesionView()
    {
        return _comercialSdkSesionService.CanIniciarSesion;
    }

    public bool CanTerminarSesionAsync()
    {
        return _comercialSdkSesionService.CanTerminarSesion;
    }

    public async Task CerrarEmpresaAsync()
    {
        try
        {
            _comercialSdkSesionService.CerrarEmpresa();
            _configuracionAplicacion.Empresa = null;
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

    public string GetMensage()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(
            "En este proyecto podran enonctrar varios ejemplos de como utilizar el SDK para listar los multiples catalogos del sistema y tambien como dar de alta documentos como facturas.");
        return stringBuilder.ToString();
    }

    public bool IsSdkListo()
    {
        return _comercialSdkSesionService.IsSdkInicializado && _comercialSdkSesionService.IsEmpresaAbierta;
    }

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

    public void MostrarListadoClasificacionesView()
    {
        var window = new ListadoClasificacionesView();
        window.Show();
    }

    public void MostrarListadoClientesView()
    {
        var window = new ListadoClientesView();
        window.Show();
    }

    public void MostrarListadoConceptosView()
    {
        var window = new ListadoConceptosView();
        window.Show();
    }

    public void MostrarListadoDocumentosViewAsync()
    {
        var window = new ListadoDocumentosView();
        window.Show();
    }

    public void MostrarListadoErroresViewAsync()
    {
        var window = new ListadoErroresView();
        window.Show();
    }

    public void MostrarListadoFacturasViewAsync()
    {
        var window = new ListadoFacturasView();
        window.Show();
    }

    public void MostrarListadoProductosView()
    {
        var window = new ListadoProductosView();
        window.Show();
    }

    public void MostrarListadoUnidadesMedidaView()
    {
        var window = new ListadoUnidadesMedidaView();
        window.Show();
    }

    public void MostrarParametrosViewAsync()
    {
        var window = new ParametrosView();
        window.Show();
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
        MostrarListadoFacturasViewCommand.NotifyCanExecuteChanged();
        MostrarListadoErroresViewCommand.NotifyCanExecuteChanged();
        MostrarParametrosViewCommand.NotifyCanExecuteChanged();
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
}

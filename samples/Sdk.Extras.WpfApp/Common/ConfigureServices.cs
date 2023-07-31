using ARSoftware.Contpaqi.Comercial.Sdk;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sdk.Extras.WpfApp.Models;
using Sdk.Extras.WpfApp.ViewModels;
using Sdk.Extras.WpfApp.ViewModels.Agentes;
using Sdk.Extras.WpfApp.ViewModels.Almacenes;
using Sdk.Extras.WpfApp.ViewModels.Clasificaciones;
using Sdk.Extras.WpfApp.ViewModels.Clientes;
using Sdk.Extras.WpfApp.ViewModels.Conceptos;
using Sdk.Extras.WpfApp.ViewModels.Direcciones;
using Sdk.Extras.WpfApp.ViewModels.Documentos;
using Sdk.Extras.WpfApp.ViewModels.Empresas;
using Sdk.Extras.WpfApp.ViewModels.Errores;
using Sdk.Extras.WpfApp.ViewModels.Facturas;
using Sdk.Extras.WpfApp.ViewModels.Movimientos;
using Sdk.Extras.WpfApp.ViewModels.Parametros;
using Sdk.Extras.WpfApp.ViewModels.Productos;
using Sdk.Extras.WpfApp.ViewModels.Sesion;
using Sdk.Extras.WpfApp.ViewModels.UnidadesMedida;
using Sdk.Extras.WpfApp.ViewModels.ValoresClasificacion;
using Sdk.Extras.WpfApp.Views;

namespace Sdk.Extras.WpfApp.Common;

public static class ConfigureServices
{
    public static IServiceCollection AddWpfAppServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.RegisterViewModels();
        services.RegisterInfrastructureServices();

        var sdkOption = configuration.GetValue<TipoContpaqiSdk>("ContpaqiConfig:Sdk");
        services.AddContpaqiComercialSdkServices(sdkOption);

        return services;
    }

    private static void RegisterInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton(DialogCoordinator.Instance);
    }

    private static void RegisterViewModels(this IServiceCollection services)
    {
        services.AddSingleton<ConfiguracionAplicacion>();
        services.AddSingleton<MainView>();
        services.AddTransient<MainViewModel>();

        // Agentes
        services.AddTransient<EditarAgenteViewModel>();
        services.AddTransient<ListadoAgentesViewModel>();
        services.AddTransient<SeleccionarAgenteViewModel>();

        // Almacenes
        services.AddTransient<ListadoAlmacenesViewModel>();
        services.AddTransient<EditarAlmacenViewModel>();
        services.AddTransient<SeleccionarAlmacenViewModel>();

        // Clasificaciones
        services.AddTransient<EditarClasificacionViewModel>();
        services.AddTransient<ListadoClasificacionesViewModel>();

        // Clientes
        services.AddTransient<ListadoClientesViewModel>();
        services.AddTransient<EditarClienteProveedorViewModel>();

        // Conceptos
        services.AddTransient<ListadoConceptosViewModel>();

        // Documentos
        services.AddTransient<ListadoDocumentosViewModel>();

        // Direcciones
        services.AddTransient<EditarDireccionViewModel>();

        // Empresas
        services.AddTransient<SeleccionarEmpresaViewModel>();

        // Errores
        services.AddTransient<ListadoErroresViewModel>();

        // Facturas
        services.AddTransient<CrearFacturaViewModel>();
        services.AddTransient<DetallesFacturaViewModel>();
        services.AddTransient<ListadoFacturasViewModel>();

        // Movimientos
        services.AddTransient<CrearMovimientoViewModel>();
        services.AddTransient<EditarMovimientoViewModel>();

        // Parametros
        services.AddTransient<ParametrosViewModel>();

        // Productos
        services.AddTransient<ListadoProductosViewModel>();
        services.AddTransient<EditarProductoViewModel>();

        // Sesion
        services.AddTransient<IniciarSesionViewModel>();

        // Unidades
        services.AddTransient<ListadoUnidadesMedidaViewModel>();
        services.AddTransient<EditarUnidadMedidaViewModel>();

        // Valores Clasificacion
        services.AddTransient<CrearValorClasificacionViewModel>();
        services.AddTransient<EditarValorClasificacionViewModel>();
        services.AddTransient<SeleccionarValorClasificacionViewModel>();
    }
}

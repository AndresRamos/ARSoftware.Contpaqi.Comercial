using ARSoftware.Contpaqi.Comercial.Ejemplos.Models;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Agentes;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Almacenes;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Clasificaciones;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Clientes;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Conceptos;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Direcciones;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Documentos;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Empresas;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Errores;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Facturas;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Movimientos;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Parametros;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Productos;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Sesion;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.UnidadesMedida;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.ValoresClasificacion;
using ARSoftware.Contpaqi.Comercial.Ejemplos.Views;
using ARSoftware.Contpaqi.Comercial.Sdk;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Common;

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

    private static void RegisterInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton(DialogCoordinator.Instance);
    }
}
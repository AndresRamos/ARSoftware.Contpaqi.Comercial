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
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;
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
        services.RegisterSdkServices(configuration);

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

    private static void RegisterSdkServices(this IServiceCollection services, IConfiguration configuration)
    {
        var sdkOption = configuration.GetValue<TipoContpaqiSdk>("ContpaqiConfig:Sdk");

        switch (sdkOption)
        {
            case TipoContpaqiSdk.Comercial:
                services.AddSingleton<IContpaqiSdk, ComercialSdkExtended>();
                break;
            case TipoContpaqiSdk.Adminpaq:
                services.AddSingleton<IContpaqiSdk, AdminpaqSdkExtended>();
                break;
            case TipoContpaqiSdk.FacturaElectronica:
                services.AddSingleton<IContpaqiSdk, FacturaElectronicaSdkExtended>();
                break;
        }

        // Agentes
        services.AddSingleton(typeof(IAgenteRepository<>), typeof(AgenteRepository<>));
        services.AddSingleton<IAgenteService, AgenteService>();

        // Almacenes
        services.AddSingleton(typeof(IAlmacenRepository<>), typeof(AlmacenRepository<>));
        services.AddSingleton<IAlmacenService, AlmacenService>();

        // Clasificaciones
        services.AddSingleton(typeof(IClasificacionRepository<>), typeof(ClasificacionRepository<>));
        services.AddSingleton<IClasificacionService, ClasificacionService>();

        //Clientes
        services.AddSingleton(typeof(IClienteProveedorRepository<>), typeof(ClienteProveedorRepository<>));
        services.AddSingleton<IClienteProveedorService, ClienteProveedorService>();

        // Conceptos
        services.AddSingleton(typeof(IConceptoDocumentoRepository<>), typeof(ConceptoDocumentoRepository<>));
        services.AddSingleton<IConceptoDocumentoService, ConceptoDocumentoService>();

        // Datos CFDI
        services.AddSingleton<IDatosCfdiRepository, DatosCfdiRepository>();

        // Direcciones
        services.AddSingleton(typeof(IDireccionRepository<>), typeof(DireccionRepository<>));
        services.AddSingleton<IDireccionService, DireccionService>();

        // Documentos
        services.AddSingleton(typeof(IDocumentoRepository<>), typeof(DocumentoRepository<>));
        services.AddSingleton<IDocumentoService, DocumentoService>();

        // Empresas
        services.AddSingleton<IEmpresaRepository<Empresa>, EmpresaRepository>();

        // Monedas
        services.AddSingleton<IMonedaRepository<Moneda>, MonedaRepository>();

        // Errores
        services.AddSingleton<ISdkErrorRepository<SdkError>, SdkErrorRepository>();

        // Movimientos
        services.AddSingleton(typeof(IMovimientoRepository<>), typeof(MovimientoRepository<>));
        services.AddSingleton<IMovimientoService, MovimientoService>();

        // Parametros
        services.AddSingleton(typeof(IParametrosRepository<>), typeof(ParametrosRepository<>));

        // Productos
        services.AddSingleton(typeof(IProductoRepository<>), typeof(ProductoRepository<>));
        services.AddSingleton<IProductoService, ProductoService>();

        // Sesion
        services.AddSingleton<IComercialSdkSesionService, ComercialSdkSesionService>();

        // Unidades
        services.AddSingleton(typeof(IUnidadMedidaRepository<>), typeof(UnidadMedidaRepository<>));
        services.AddSingleton<IUnidadMedidaService, UnidadMedidaService>();

        // Valores Clasificacion
        services.AddSingleton(typeof(IValorClasificacionRepository<>), typeof(ValorClasificacionRepository<>));
        services.AddSingleton<IValorClasificacionService, ValorClasificacionService>();
    }

    private static void RegisterInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton(DialogCoordinator.Instance);
    }
}

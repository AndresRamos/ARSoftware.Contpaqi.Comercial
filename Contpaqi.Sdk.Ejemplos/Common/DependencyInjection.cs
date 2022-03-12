using System;
using Contpaqi.Sdk.Ejemplos.Models;
using Contpaqi.Sdk.Ejemplos.ViewModels;
using Contpaqi.Sdk.Ejemplos.ViewModels.Agentes;
using Contpaqi.Sdk.Ejemplos.ViewModels.Almacenes;
using Contpaqi.Sdk.Ejemplos.ViewModels.Clasificaciones;
using Contpaqi.Sdk.Ejemplos.ViewModels.Clientes;
using Contpaqi.Sdk.Ejemplos.ViewModels.Conceptos;
using Contpaqi.Sdk.Ejemplos.ViewModels.Direcciones;
using Contpaqi.Sdk.Ejemplos.ViewModels.Documentos;
using Contpaqi.Sdk.Ejemplos.ViewModels.Empresas;
using Contpaqi.Sdk.Ejemplos.ViewModels.Errores;
using Contpaqi.Sdk.Ejemplos.ViewModels.Facturas;
using Contpaqi.Sdk.Ejemplos.ViewModels.Movimientos;
using Contpaqi.Sdk.Ejemplos.ViewModels.Parametros;
using Contpaqi.Sdk.Ejemplos.ViewModels.Productos;
using Contpaqi.Sdk.Ejemplos.ViewModels.Sesion;
using Contpaqi.Sdk.Ejemplos.ViewModels.UnidadesMedida;
using Contpaqi.Sdk.Ejemplos.ViewModels.ValoresClasificacion;
using Contpaqi.Sdk.Extras;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Repositories;
using Contpaqi.Sdk.Extras.Services;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Extensions.DependencyInjection;

namespace Contpaqi.Sdk.Ejemplos.Common;

public static class DependencyInjection
{
    public static IServiceProvider Configure()
    {
        var services = new ServiceCollection();

        services.RegisterViewModels();
        services.RegisterInfrastructureServices();
        services.RegisterSdkServices();

        return services.BuildServiceProvider();
    }

    private static void RegisterViewModels(this IServiceCollection services)
    {
        services.AddSingleton<ConfiguracionAplicacion>();
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

    private static void RegisterSdkServices(this IServiceCollection services)
    {
        services.AddSingleton<IContpaqiSdk, ComercialSdkExtended>();

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

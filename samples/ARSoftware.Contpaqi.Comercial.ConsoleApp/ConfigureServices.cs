using ARSoftware.Contpaqi.Comercial.Sdk.Extras;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ARSoftware.Contpaqi.Comercial.ConsoleApp;

public static class ConfigureServices
{
    public static IServiceCollection AddSdkServices(this IServiceCollection services)
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

        return services;
    }
}

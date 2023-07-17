using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddContpaqiComercialSdkServices(this IServiceCollection services,
            TipoContpaqiSdk tipoContpaqiSdk = TipoContpaqiSdk.Comercial)
        {
            switch (tipoContpaqiSdk)
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
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoContpaqiSdk), tipoContpaqiSdk,
                        "El valor no es un tipo de SDK valido.");
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

            // Parámetros
            services.AddSingleton(typeof(IParametrosRepository<>), typeof(ParametrosRepository<>));

            // Productos
            services.AddSingleton(typeof(IProductoRepository<>), typeof(ProductoRepository<>));
            services.AddSingleton<IProductoService, ProductoService>();

            // Sesión
            services.AddSingleton<IComercialSdkSesionService, ComercialSdkSesionService>();

            // Unidades
            services.AddSingleton(typeof(IUnidadMedidaRepository<>), typeof(UnidadMedidaRepository<>));
            services.AddSingleton<IUnidadMedidaService, UnidadMedidaService>();

            // Valores Clasificación
            services.AddSingleton(typeof(IValorClasificacionRepository<>), typeof(ValorClasificacionRepository<>));
            services.AddSingleton<IValorClasificacionService, ValorClasificacionService>();

            return services;
        }
    }
}
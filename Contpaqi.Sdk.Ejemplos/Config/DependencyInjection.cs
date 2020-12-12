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

namespace Contpaqi.Sdk.Ejemplos.Config
{
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
            services.AddTransient<ListadoAgentesViewModel>();
            services.AddTransient<SeleccionarAgenteViewModel>();

            // Almacenes
            services.AddTransient<ListadoAlmacenesViewModel>();
            services.AddTransient<SeleccionarAlmacenViewModel>();

            // Clasificaciones
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

            // Productos
            services.AddTransient<ListadoProductosViewModel>();

            // Sesion
            services.AddTransient<IniciarSesionViewModel>();

            // Unidades
            services.AddTransient<ListadoUnidadesMedidaViewModel>();

            // Valores Clasificacion
            services.AddTransient<CrearValorClasificacionViewModel>();
            services.AddTransient<EditarValorClasificacionViewModel>();
            services.AddTransient<SeleccionarValorClasificacionViewModel>();
        }

        private static void RegisterSdkServices(this IServiceCollection services)
        {
            services.AddSingleton<IContpaqiSdk, ComercialSdkExtended>();

            // Agentes
            services.AddSingleton<IAgenteRepository<Agente>, AgenteRepository>();

            // Almacenes
            services.AddTransient<IAlmacenRepository<Almacen>, AlmacenRepository>();

            // Clasificaciones
            services.AddSingleton<IClasificacionRepository<Clasificacion>, ClasificacionRepository>();

            //Clientes
            services.AddSingleton<IClienteProveedorRepository<ClienteProveedor>, ClienteProveedorRepository>();
            services.AddSingleton<IClienteProveedorRepository<ClienteProveedorLookup>, ClienteProveedorLookupRepository>();
            services.AddSingleton<IClienteProveedorService, ClienteProveedorService>();

            // Conceptos
            services.AddSingleton<IConceptoDocumentoRepository<ConceptoDocumento>, ConceptoDocumentoRepository>();

            // Datos CFDI
            services.AddSingleton<IDatosCfdiRepository, DatosCfdiRepository>();

            // Direcciones
            services.AddSingleton<IDireccionRepository<Direccion>, DireccionRepository>();
            services.AddSingleton<IDireccionService, DireccionService>();

            // Documentos
            services.AddSingleton<IDocumentoRepository<Documento>, DocumentoRepository>();
            services.AddSingleton<IDocumentoService, DocumentoService>();

            // Empresas
            services.AddSingleton<IEmpresaRepository<Empresa>, EmpresaRepository>();

            // Errores
            services.AddSingleton<ISdkErrorRepository<SdkError>, SdkErrorRepository>();

            // Movimientos
            services.AddSingleton<IMovimientoRepository<Movimiento>, MovimientoRepository>();
            services.AddSingleton<IMovimientoService, MovimientoService>();

            // Productos
            services.AddSingleton<IProductoRepository<Producto>, ProductoRepository>();
            services.AddSingleton<IProductoRepository<ProductoLookup>, ProductoLookupRepository>();

            // Sesion
            services.AddSingleton<IComercialSdkSesionService, ComercialSdkSesionService>();

            // Unidades
            services.AddSingleton<IUnidadMedidaRepository<UnidadMedida>, UnidadMedidaRepository>();

            // Valores Clasificacion
            services.AddSingleton<IValorClasificacionRepository<ValorClasificacion>, ValorClasificacionRepository>();
            services.AddSingleton<IValorClasificacionService, ValorClasificacionService>();
        }

        private static void RegisterInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton(provider => DialogCoordinator.Instance);
        }
    }
}
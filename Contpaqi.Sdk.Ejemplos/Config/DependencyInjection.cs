using System;
using Contpaqi.Sdk.Ejemplos.ViewModels;
using Contpaqi.Sdk.Ejemplos.ViewModels.Agentes;
using Contpaqi.Sdk.Ejemplos.ViewModels.Almacenes;
using Contpaqi.Sdk.Ejemplos.ViewModels.Clasificaciones;
using Contpaqi.Sdk.Ejemplos.ViewModels.Clientes;
using Contpaqi.Sdk.Ejemplos.ViewModels.Conceptos;
using Contpaqi.Sdk.Ejemplos.ViewModels.Documentos;
using Contpaqi.Sdk.Ejemplos.ViewModels.Empresas;
using Contpaqi.Sdk.Ejemplos.ViewModels.Productos;
using Contpaqi.Sdk.Ejemplos.ViewModels.Sesion;
using Contpaqi.Sdk.Ejemplos.ViewModels.UnidadesMedida;
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
            services.AddTransient<MainViewModel>();

            // Agentes
            services.AddTransient<ListadoAgentesViewModel>();

            // Almacenes
            services.AddTransient<ListadoAlmacenesViewModel>();

            // Clasificaciones
            services.AddTransient<ListadoClasificacionesViewModel>();

            // Clientes
            services.AddTransient<ListadoClientesViewModel>();

            // Conceptos
            services.AddTransient<ListadoConceptosViewModel>();

            // Conceptos
            services.AddTransient<ListadoDocumentosViewModel>();

            // Empresas
            services.AddTransient<SeleccionarEmpresaViewModel>();

            // Productos
            services.AddTransient<ListadoProductosViewModel>();

            // Sesion
            services.AddTransient<IniciarSesionViewModel>();

            // Sesion
            services.AddTransient<ListadoUnidadesMedidaViewModel>();
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

            // Conceptos
            services.AddSingleton<IConceptoDocumentoRepository<ConceptoDocumento>, ConceptoDocumentoRepository>();

            // Conceptos
            services.AddSingleton<IDocumentoRepository<Documento>, DocumentoRepository>();

            // Empresas
            services.AddSingleton<IEmpresaRepository<Empresa>, EmpresaRepository>();

            // Productos
            services.AddSingleton<IProductoRepository<Producto>, ProductoRepository>();

            // Sesion
            services.AddSingleton<IComercialSdkSesionService, ComercialSdkSesionService>();

            // Sesion
            services.AddSingleton<IUnidadMedidaRepository<UnidadMedida>, UnidadMedidaRepository>();
        }

        private static void RegisterInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton(provider => DialogCoordinator.Instance);
        }
    }
}
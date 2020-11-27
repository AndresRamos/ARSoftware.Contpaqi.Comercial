using System;
using Contpaqi.Sdk.Ejemplos.ViewModels;
using Contpaqi.Sdk.Ejemplos.ViewModels.Agentes;
using Contpaqi.Sdk.Ejemplos.ViewModels.Almacenes;
using Contpaqi.Sdk.Ejemplos.ViewModels.Clientes;
using Contpaqi.Sdk.Ejemplos.ViewModels.Empresas;
using Contpaqi.Sdk.Ejemplos.ViewModels.Sesion;
using Contpaqi.Sdk.Extras;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Repositorios;
using Contpaqi.Sdk.Extras.Servicios;
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

            // Clientes
            services.AddTransient<ListadoClientesViewModel>();
            services.AddTransient<ListadoProveedoresViewModel>();

            // Empresas
            services.AddTransient<SeleccionarEmpresaViewModel>();

            // Sesion
            services.AddTransient<IniciarSesionViewModel>();
        }

        private static void RegisterSdkServices(this IServiceCollection services)
        {
            services.AddSingleton<IContpaqiSdk, ComercialSdkExtended>();

            // Agentes
            services.AddSingleton<IAgenteRepositorio, AgenteRepositorio>();

            // Almacenes
            services.AddTransient<IAlmacenRepositorio, AlmacenRepositorio>();

            //Clientes
            services.AddSingleton<IClienteProveedorRepositorio, ClienteProveedorRepositorio>();

            // Empresas
            services.AddSingleton<IEmpresaRepositorio, EmpresaRepositorio>();

            // Sesion
            services.AddSingleton<IComercialSdkSesionServicio, ComercialSdkSesionServicio>();
        }

        private static void RegisterInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton(provider => DialogCoordinator.Instance);
        }
    }
}
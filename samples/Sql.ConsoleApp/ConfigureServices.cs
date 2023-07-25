using ARSoftware.Contpaqi.Comercial.Sql;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Factories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Sql.ConsoleApp;

public static class ConfigureServices
{
    public static readonly string ContpaqiConnectionString =
        @"Data Source=AR-SERVER\COMPAC;User ID=sa;Password=Sdmramos1;Connect Timeout=30;";

    public static readonly string NombreBaseDatosEmpresa = "adUNIVERSIDAD_ROBOTICA";

    public static IServiceCollection AddSqlServices(this IServiceCollection services)
    {
        // Registrar generales context
        services.AddDbContext<ContpaqiComercialGeneralesDbContext>(builder =>
            builder.UseSqlServer(
                ContpaqiComercialSqlConnectionStringFactory.CreateContpaqiComercialGeneralesConnectionString(ContpaqiConnectionString)));

        // Registrar empresa context
        services.AddDbContext<ContpaqiComercialEmpresaDbContext>(builder =>
            builder.UseSqlServer(
                ContpaqiComercialSqlConnectionStringFactory.CreateContpaqiComercialEmpresaConnectionString(ContpaqiConnectionString,
                    NombreBaseDatosEmpresa)));

        // Registrar repositorios
        services.AddContpaqiComercialSqlRepositories();

        // Registrar ejemplos
        services.AddEjemplos();

        return services;
    }

    private static void AddEjemplos(this IServiceCollection services)
    {
        services.AddSingleton<BuscarAgenteConRepositorio>();
        services.AddSingleton<BuscarAgenteDtoConRepositorio>();

        services.AddSingleton<EjemplosAlmacen>();
        services.AddSingleton<EjemplosClasificacion>();
        services.AddSingleton<EjemplosCliente>();
        services.AddSingleton<EjemplosConcepto>();
        services.AddSingleton<EjemplosDocumentoModelo>();
        services.AddSingleton<EjemplosDocumento>();
        services.AddSingleton<EjemplosEmpresa>();
        services.AddSingleton<EjemplosMoneda>();
        services.AddSingleton<EjemplosMovimiento>();
        services.AddSingleton<EjemplosParametros>();
        services.AddSingleton<EjemplosProducto>();
        services.AddSingleton<EjemplosUnidadMedida>();
        services.AddSingleton<EjemplosValorClasificacion>();
    }
}
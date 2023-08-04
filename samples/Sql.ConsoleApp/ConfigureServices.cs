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

    public static void AddEjemplos(this IServiceCollection services)
    {
        services.AddSingleton<BuscarAgentesConRepositorio>();
        services.AddSingleton<BuscarAgentesDtoConRepositorio>();

        services.AddSingleton<BuscarAlmacenesConRepositorio>();
        services.AddSingleton<BuscarAlmacenesDtoConRepositorio>();

        services.AddSingleton<BuscarClasificacionesConRepositorio>();

        services.AddSingleton<BuscarClientesProveedoresConRepositorio>();
        services.AddSingleton<BuscarClientesProveedoresDtoConRepositorio>();

        services.AddSingleton<BuscarConceptosDocumentoConRepositorio>();
        services.AddSingleton<BuscarConceptosDocumentoDtoConRepositorio>();

        services.AddSingleton<BuscarDocumentosModeloConRepositorio>();
        services.AddSingleton<BuscarDocumentosModeloDtoConRepositorio>();

        services.AddSingleton<BuscarDocumentosConRepositorio>();
        services.AddSingleton<BuscarDocumentosDtoConRepositorio>();

        services.AddSingleton<BuscarEmpresasConRepositorio>();
        services.AddSingleton<BuscarEmpresasDtoConRepositorio>();

        services.AddSingleton<BuscarMonedasConRepositorio>();
        services.AddSingleton<BuscarMonedasDtoConRepositorio>();

        services.AddSingleton<BuscarMovimientosConRepositorio>();
        services.AddSingleton<BuscarMovimientosDtoConRepositorio>();

        services.AddSingleton<BuscarParametrosConRepositorio>();
        services.AddSingleton<BuscarParametrosDtoConRepositorio>();

        services.AddSingleton<BuscarProductosConRepositorio>();
        services.AddSingleton<BuscarProductosDtoConRepositorio>();

        services.AddSingleton<BuscarUnidadesMedidaConRepositorio>();
        services.AddSingleton<BuscarUnidadesMedidaDtoConRepositorio>();

        services.AddSingleton<BuscarValoresClasificacionConRepositorio>();
    }

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

        return services;
    }
}

using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Factories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Sql.ConsoleApp.Ejemplos;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(collection =>
    {
        var connectionString = @"Data Source=AR-SERVER\COMPAC;User ID=sa;Password=Sdmramos1;Connect Timeout=30;";
        var nombreBaseDatosEmpresa = "adUNIVERSIDAD_ROBOTICA";

        // Registrar generales context
        collection.AddDbContext<ContpaqiComercialGeneralesDbContext>(builder =>
            builder.UseSqlServer(
                ContpaqiComercialSqlConnectionStringFactory.CreateContpaqiComercialGeneralesConnectionString(connectionString)));

        // Registrar empresa context
        collection.AddDbContext<ContpaqiComercialEmpresaDbContext>(builder =>
            builder.UseSqlServer(
                ContpaqiComercialSqlConnectionStringFactory.CreateContpaqiComercialEmpresaConnectionString(connectionString,
                    nombreBaseDatosEmpresa)));

        collection.AddSingleton<EjemplosEmpresa>();
        collection.AddSingleton<EjemplosProducto>();
        collection.AddSingleton<EjemplosCliente>();
    })
    .ConfigureLogging(builder => { builder.AddSimpleConsole(options => { options.SingleLine = true; }); })
    .Build();
await host.StartAsync();

var logger = host.Services.GetRequiredService<ILogger<Program>>();
logger.LogInformation("Iniciando Programa");
try
{
    // Ejemplos del uso del SDK
    // Se pueden ejecutar de forma independiente
    // Comenta los ejemplos que no quieras ejecutar

    host.Services.GetRequiredService<EjemplosEmpresa>().CorrerEjemplos();

    host.Services.GetRequiredService<EjemplosProducto>().CorrerEjemplos();

    host.Services.GetRequiredService<EjemplosCliente>().CorrerEjemplos();
}
catch (Exception e)
{
    logger.LogCritical(e, "Ocurrio un error");
}

await host.StopAsync();

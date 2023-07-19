using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Sql.ConsoleApp;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(services => { services.AddSqlServices(); })
    .ConfigureLogging(builder =>
    {
        builder.SetMinimumLevel(LogLevel.Information);

        builder.AddFilter("Microsoft", LogLevel.Warning);
        builder.AddSimpleConsole(options => { options.SingleLine = true; });
    })
    .Build();

await host.StartAsync();

var logger = host.Services.GetRequiredService<ILogger<Program>>();

try
{
    logger.LogInformation("Iniciando Programa");

    // Ejemplos del uso del SDK
    // Se pueden ejecutar de forma independiente
    // Descomenta los ejemplos que no quieras ejecutar

    //host.Services.GetRequiredService<EjemplosEmpresa>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosAgente>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosAlmacen>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosClasificacion>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosProducto>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosCliente>().CorrerEjemplos();
}
catch (Exception e)
{
    logger.LogCritical(e, "Ocurrio un error");
}

await host.StopAsync();
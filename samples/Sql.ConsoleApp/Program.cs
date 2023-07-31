using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using Sql.ConsoleApp;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(services =>
    {
        services.AddSqlServices();
        services.AddEjemplos();
    })
    .ConfigureLogging(builder => { builder.ClearProviders(); })
    .UseSerilog((_, loggerConfiguration) =>
    {
        loggerConfiguration.MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Information);
        loggerConfiguration.WriteTo.Console(LogEventLevel.Information);
    })
    .Build();

await host.StartAsync();

var logger = host.Services.GetRequiredService<ILogger<Program>>();

try
{
    // 1. Busca la clase con los ejemplos que quieras probar utilizando el proveedor de servicios.
    // 2. Ejecuta el metodo que quieras probar.
    var ejemplo = host.Services.GetRequiredService<BuscarEmpresasConRepositorio>();
    ejemplo.TraerTodo();
}
catch (Exception e)
{
    logger.LogCritical(e, "Ocurrio un error.");
}

await host.StopAsync();

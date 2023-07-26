using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using Sql.ConsoleApp;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(services => { services.AddSqlServices(); })
    .ConfigureLogging(builder =>
    {
        //builder.SetMinimumLevel(LogLevel.Information);

        //builder.AddFilter("Microsoft", LogLevel.Warning);
        //builder.AddSimpleConsole(options => { options.SingleLine = true; });
        builder.ClearProviders();
    })
    .UseSerilog((hostingContext, loggerConfiguration) =>
    {
        loggerConfiguration.MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Information);
        loggerConfiguration.WriteTo.Console(LogEventLevel.Information);
        //loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration).Enrich.FromLogContext();
    })
    .Build();

await host.StartAsync();

var logger = host.Services.GetRequiredService<ILogger<Program>>();

try
{
    logger.LogInformation("Iniciando Programa");

    // Ejemplos del uso del SQL
    // Se pueden ejecutar de forma independiente. Descomenta los ejemplos que quieres ejecutar.

    //host.Services.GetRequiredService<EjemplosEmpresa>().CorrerEjemplos();

    //host.Services.GetRequiredService<BuscarAgenteConRepositorio>().CorrerEjemplos();
    //host.Services.GetRequiredService<BuscarAgenteDtoConRepositorio>().CorrerEjemplos();

    //host.Services.GetRequiredService<BuscarAlmacenConRepositorio>().CorrerEjemplos();
    //host.Services.GetRequiredService<BuscarAlmacenDtoConRepositorio>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosClasificacion>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosCliente>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosConcepto>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosDocumentoModelo>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosDocumento>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosMoneda>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosMovimiento>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosParametros>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosProducto>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosUnidadMedida>().CorrerEjemplos();

    //host.Services.GetRequiredService<EjemplosValorClasificacion>().CorrerEjemplos();
}
catch (Exception e)
{
    logger.LogCritical(e, "Ocurrio un error");
}

await host.StopAsync();
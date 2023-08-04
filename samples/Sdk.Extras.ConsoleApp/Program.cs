using ARSoftware.Contpaqi.Comercial.Sdk.Extras;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Sdk.Extras.ConsoleApp;
using Serilog;
using Serilog.Events;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(services =>
    {
        services.AddContpaqiComercialSdkServices();
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
    var iniciarSesion = host.Services.GetRequiredService<IniciarSesion>();
    iniciarSesion.IniciarConParametros();

    var abrirEmpresa = host.Services.GetRequiredService<AbrirEmpresa>();
    abrirEmpresa.Abrir();

    // 1. Busca la clase con los ejemplos que quieras probar utilizando el proveedor de servicios.
    // 2. Ejecuta el metodo que quieras probar.
    var ejemplo = host.Services.GetRequiredService<CrearFactura>();
    ejemplo.Crear();
}
catch (Exception e)
{
    logger.LogCritical(e, "Ocurrio un error");
}
finally
{
    var cerrarEmpresa = host.Services.GetRequiredService<CerrarEmpresa>();
    cerrarEmpresa.Cerrar();

    var terminasSesion = host.Services.GetRequiredService<TerminasSesion>();
    terminasSesion.Terminar();
}

await host.StopAsync();

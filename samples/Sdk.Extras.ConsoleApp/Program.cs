using ARSoftware.Contpaqi.Comercial.Sdk.Extras;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Sdk.Extras.ConsoleApp.Ejemplos;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(collection =>
    {
        collection.AddContpaqiComercialSdkServices();
        collection.AddSingleton<EjemplosConexion>()
            .AddSingleton<EjemplosEmpresa>()
            .AddSingleton<EjemplosCliente>()
            .AddSingleton<EjemplosProducto>()
            .AddSingleton<EjemplosConcepto>()
            .AddSingleton<EjemplosDocumento>();
    })
    .ConfigureLogging(builder => { builder.AddSimpleConsole(options => { options.SingleLine = true; }); })
    .Build();

await host.StartAsync();

var logger = host.Services.GetRequiredService<ILogger<Program>>();
logger.LogInformation("Iniciando Programa");

var conexionSdk = host.Services.GetRequiredService<EjemplosConexion>();

try
{
    conexionSdk.IniciarConexion();

    conexionSdk.AbrirEmpresa();

    // Ejemplos del uso del SDK
    // Se pueden ejecutar de forma independiente
    // Comenta los ejemplos que no quieras ejecutar

    host.Services.GetRequiredService<EjemplosEmpresa>().CorrerEjemplos();

    host.Services.GetRequiredService<EjemplosCliente>().CorrerEjemplos();

    host.Services.GetRequiredService<EjemplosConcepto>().CorrerEjemplos();

    host.Services.GetRequiredService<EjemplosProducto>().CorrerEjemplos();

    host.Services.GetRequiredService<EjemplosDocumento>().CorrerEjemplos();
}
catch (Exception e)
{
    logger.LogCritical(e, "Ocurrio un error");
}
finally
{
    conexionSdk.CerrarEmpresa();

    conexionSdk.TerminarConexion();
}

await host.StopAsync();

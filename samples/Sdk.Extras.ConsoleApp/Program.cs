using ARSoftware.Contpaqi.Comercial.Sdk;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Sdk.Extras.ConsoleApp;
using Sdk.Extras.ConsoleApp.Catalogos;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(collection =>
    {
        collection.AddContpaqiComercialSdkServices(TipoContpaqiSdk.Comercial);
        collection.AddSingleton<ConexionSdk>();
        collection.AddSingleton<EmpresaSdk>();
        collection.AddSingleton<ClienteSdk>();
    })
    .ConfigureLogging(builder => { builder.AddSimpleConsole(options => { options.SingleLine = true; }); })
    .Build();

await host.StartAsync();

var conexionSdk = host.Services.GetRequiredService<ConexionSdk>();

try
{
    var logger = host.Services.GetRequiredService<ILogger<Program>>();
    logger.LogInformation("Iniciando Programa");

    // Iniciar conexion
    var sdk = host.Services.GetRequiredService<IContpaqiSdk>();

    if (sdk is FacturaElectronicaSdkExtended || sdk is AdminpaqSdkExtended)
        conexionSdk.IniciarConexion();
    else if (sdk is ComercialSdkExtended)
        conexionSdk.IniciarConexionConParametros("SUPERVISOR", "");

    // Abrir empresa
    var empresaSdk = host.Services.GetRequiredService<EmpresaSdk>();
    List<Empresa> empresas = empresaSdk.BuscarEmpresas();
    //empresaSdk.LogEmpresas(empresas);
    conexionSdk.AbrirEmpresa(empresas.First(e => e.CIDEMPRESA == 10));
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}
finally
{
    // Cerrar empresa
    conexionSdk.CerrarEmpresa();

    // Terminar conexion
    conexionSdk.TerminarConexion();
}

await host.StopAsync();

// See https://aka.ms/new-console-template for more information

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
    })
    .ConfigureLogging(builder => { builder.AddSimpleConsole(options => { options.SingleLine = true; }); })
    .Build();

await host.StartAsync();

var conexionSdk = host.Services.GetRequiredService<ConexionSdk>();

try
{
    // Iniciar conexion
    var sdk = host.Services.GetRequiredService<IContpaqiSdk>();

    if (sdk is FacturaElectronicaSdkExtended || sdk is AdminpaqSdkExtended)
        conexionSdk.IniciarConexion();
    else if (sdk is ComercialSdkExtended)
        conexionSdk.IniciarConexionConParametros("SUPERVISOR", "");

    // Abrir empresa
    var empresaSdk = host.Services.GetRequiredService<EmpresaSdk>();
    List<Empresa> empresas = empresaSdk.BuscarEmpresas();
    empresaSdk.LogEmpresas(empresas);
    conexionSdk.AbrirEmpresa(empresas.First(e => e.CIDEMPRESA == 10));
    
    // Cerrar empresa
    conexionSdk.CerrarEmpresa();
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}
finally
{
    // Terminar conexion
    conexionSdk.TerminarConexion();
}

await host.StopAsync();

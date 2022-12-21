// See https://aka.ms/new-console-template for more information

using ARSoftware.Contpaqi.Comercial.Sdk;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras;
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
    conexionSdk.IniciarSdk("SUPERVISOR", "");

    var empresaSdk = host.Services.GetRequiredService<EmpresaSdk>();

    List<Empresa> empresas = empresaSdk.BuscarEmpresas();

    Empresa empresaSeleccionada = empresas.First(e => e.CIDEMPRESA == 10);

    conexionSdk.AbrirEmpresa(empresaSeleccionada);

    conexionSdk.CerrarEmpresa();
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}
finally
{
    conexionSdk.TerminarSdk();
}

await host.StopAsync();

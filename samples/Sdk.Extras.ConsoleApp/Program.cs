// See https://aka.ms/new-console-template for more information

using ARSoftware.Contpaqi.Comercial.Sdk;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(collection => { collection.AddContpaqiComercialSdkServices(TipoContpaqiSdk.Comercial); })
    .Build();

await host.StartAsync();

await host.StopAsync();

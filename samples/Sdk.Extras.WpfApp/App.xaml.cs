using System;
using System.Windows;
using System.Windows.Threading;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Sdk.Extras.WpfApp.Common;
using Sdk.Extras.WpfApp.Views;

namespace Sdk.Extras.WpfApp;

/// <summary>
///     Interaction logic for App.xaml
/// </summary>
public partial class App
{
    private readonly IHost _host;
    private readonly ILogger<App> _logger;

    public App()
    {
        _host = Host.CreateDefaultBuilder()
            .ConfigureServices((hostBuilderContext, serviceCollection) =>
            {
                serviceCollection.AddWpfAppServices(hostBuilderContext.Configuration);
            })
            .Build();

        _logger = _host.Services.GetRequiredService<ILogger<App>>();
        Ioc.Default.ConfigureServices(_host.Services.CreateScope().ServiceProvider);
    }

    private void App_OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        MessageBox.Show(e.Exception.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        try
        {
            var comercialSdkSesionServicio = Ioc.Default.GetService<IComercialSdkSesionService>();
            if (comercialSdkSesionServicio != null && comercialSdkSesionServicio.IsSdkInicializado)
                comercialSdkSesionServicio.TerminarSesionSdk();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al terminar la conexion del SDK.");
        }

        _logger.LogInformation("Cerrando aplicacion.");
        using (_host)
        {
            await _host.StopAsync(TimeSpan.FromSeconds(5));
        }

        base.OnExit(e);
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        _logger.LogInformation("Iniciando aplicacion.");
        await _host.StartAsync();
        var window = _host.Services.GetRequiredService<MainView>();
        window.Show();
        base.OnStartup(e);
    }
}

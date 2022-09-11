using System.Windows;
using System.Windows.Threading;
using ARSoftware.Contpaqi.Comercial.Ejemplos.Common;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos;

/// <summary>
///     Interaction logic for App.xaml
/// </summary>
public partial class App
{
    public App()
    {
        Ioc.Default.ConfigureServices(DependencyInjection.Configure());
    }

    public new static App Current => (App)Application.Current;

    protected override void OnExit(ExitEventArgs e)
    {
        var comercialSdkSesionServicio = Ioc.Default.GetService<IComercialSdkSesionService>();
        if (comercialSdkSesionServicio != null && comercialSdkSesionServicio.IsSdkInicializado)
        {
            comercialSdkSesionServicio.TerminarSesionSdk();
        }

        base.OnExit(e);
    }

    private void App_OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        MessageBox.Show(e.Exception.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    }
}

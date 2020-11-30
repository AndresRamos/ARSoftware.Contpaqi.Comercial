using System.Windows;
using System.Windows.Threading;
using Contpaqi.Sdk.Ejemplos.Config;
using Contpaqi.Sdk.Extras.Interfaces;
using Microsoft.Toolkit.Mvvm.DependencyInjection;

namespace Contpaqi.Sdk.Ejemplos
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public App()
        {
            Ioc.Default.ConfigureServices(DependencyInjection.Configure());
        }

        public new static App Current => (App) Application.Current;

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
}
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Sesion;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Sesion
{
    /// <summary>
    ///     Interaction logic for IniciarSesionView.xaml
    /// </summary>
    public partial class IniciarSesionView
    {
        public IniciarSesionView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<IniciarSesionViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public IniciarSesionViewModel ViewModel => (IniciarSesionViewModel) DataContext;
    }
}
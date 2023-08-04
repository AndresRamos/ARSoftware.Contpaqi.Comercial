using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Sesion;

namespace Sdk.Extras.WpfApp.Views.Sesion;

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
                var view = (IniciarSesionView)recipient;
                view.Close();
                Close();
            }
        });
    }

    public IniciarSesionViewModel ViewModel => (IniciarSesionViewModel)DataContext;
}

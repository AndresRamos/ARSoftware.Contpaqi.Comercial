using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Empresas;

namespace Sdk.Extras.WpfApp.Views.Empresas;

/// <summary>
///     Interaction logic for SeleccionarEmpresaView.xaml
/// </summary>
public partial class SeleccionarEmpresaView
{
    public SeleccionarEmpresaView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<SeleccionarEmpresaViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (SeleccionarEmpresaView)recipient;
                view.Close();
            }
        });
    }

    public SeleccionarEmpresaViewModel ViewModel => (SeleccionarEmpresaViewModel)DataContext;
}

using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Facturas;

namespace Sdk.Extras.WpfApp.Views.Facturas;

/// <summary>
///     Interaction logic for CrearFacturaView.xaml
/// </summary>
public partial class CrearFacturaView
{
    public CrearFacturaView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<CrearFacturaViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (CrearFacturaView)recipient;
                view.Close();
            }
        });
    }

    public CrearFacturaViewModel ViewModel => (CrearFacturaViewModel)DataContext;
}

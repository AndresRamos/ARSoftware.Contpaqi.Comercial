using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Facturas;

namespace Sdk.Extras.WpfApp.Views.Facturas;

/// <summary>
///     Interaction logic for DetallesFacturaView.xaml
/// </summary>
public partial class DetallesFacturaView
{
    public DetallesFacturaView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<DetallesFacturaViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (DetallesFacturaView)recipient;
                view.Close();
            }
        });
    }

    public DetallesFacturaViewModel ViewModel => (DetallesFacturaViewModel)DataContext;
}

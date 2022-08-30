using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Facturas;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Facturas;

/// <summary>
///     Interaction logic for CrearFacturaView.xaml
/// </summary>
public partial class CrearFacturaView
{
    public CrearFacturaView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<CrearFacturaViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
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

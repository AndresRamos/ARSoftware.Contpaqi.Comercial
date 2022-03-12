using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Facturas;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Facturas;

/// <summary>
///     Interaction logic for DetallesFacturaView.xaml
/// </summary>
public partial class DetallesFacturaView
{
    public DetallesFacturaView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<DetallesFacturaViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
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

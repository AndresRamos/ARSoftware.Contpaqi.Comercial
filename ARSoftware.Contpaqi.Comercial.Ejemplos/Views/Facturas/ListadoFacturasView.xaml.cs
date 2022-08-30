using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Facturas;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Facturas;

/// <summary>
///     Interaction logic for ListadoFacturasView.xaml
/// </summary>
public partial class ListadoFacturasView
{
    public ListadoFacturasView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoFacturasViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (ListadoFacturasView)recipient;
                    view.Close();
                }
            });
    }

    public ListadoFacturasViewModel ViewModel => (ListadoFacturasViewModel)DataContext;
}

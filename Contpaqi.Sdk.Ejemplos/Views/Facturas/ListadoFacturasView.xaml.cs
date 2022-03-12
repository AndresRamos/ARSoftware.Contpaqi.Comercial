using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Facturas;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Facturas;

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

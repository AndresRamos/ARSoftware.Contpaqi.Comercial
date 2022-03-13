using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Clientes;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Clientes;

/// <summary>
///     Interaction logic for ListadoClientesView.xaml
/// </summary>
public partial class ListadoClientesView
{
    public ListadoClientesView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoClientesViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (ListadoClientesView)recipient;
                    view.Close();
                }
            });
    }

    public ListadoClientesViewModel ViewModel => (ListadoClientesViewModel)DataContext;
}

using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Clientes;

namespace Sdk.Extras.WpfApp.Views.Clientes;

/// <summary>
///     Interaction logic for ListadoClientesView.xaml
/// </summary>
public partial class ListadoClientesView
{
    public ListadoClientesView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoClientesViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
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

using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.UnidadesMedida;

namespace Sdk.Extras.WpfApp.Views.UnidadesMedida;

public partial class ListadoUnidadesMedidaView
{
    public ListadoUnidadesMedidaView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoUnidadesMedidaViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (ListadoUnidadesMedidaView)recipient;
                view.Close();
            }
        });
    }

    public ListadoUnidadesMedidaViewModel ViewModel => (ListadoUnidadesMedidaViewModel)DataContext;
}

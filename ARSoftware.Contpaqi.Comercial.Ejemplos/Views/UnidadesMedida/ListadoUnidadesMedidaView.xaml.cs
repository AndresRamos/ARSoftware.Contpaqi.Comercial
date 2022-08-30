using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.UnidadesMedida;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.UnidadesMedida;

public partial class ListadoUnidadesMedidaView
{
    public ListadoUnidadesMedidaView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoUnidadesMedidaViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
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

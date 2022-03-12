using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.UnidadesMedida;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.UnidadesMedida;

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

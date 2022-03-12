using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.UnidadesMedida;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.UnidadesMedida;

public partial class EditarUnidadMedidaView
{
    public EditarUnidadMedidaView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarUnidadMedidaViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (EditarUnidadMedidaView)recipient;
                    view.Close();
                    Close();
                }
            });
    }

    public EditarUnidadMedidaViewModel ViewModel => (EditarUnidadMedidaViewModel)DataContext;
}

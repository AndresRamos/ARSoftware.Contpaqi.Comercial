using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.UnidadesMedida;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.UnidadesMedida;

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

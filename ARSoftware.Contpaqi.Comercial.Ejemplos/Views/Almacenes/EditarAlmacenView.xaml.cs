using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Almacenes;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Almacenes;

public partial class EditarAlmacenView
{
    public EditarAlmacenView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarAlmacenViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (EditarAlmacenView)recipient;
                    view.Close();
                }
            });
    }

    public EditarAlmacenViewModel ViewModel => (EditarAlmacenViewModel)DataContext;
}

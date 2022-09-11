using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Clasificaciones;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Clasificaciones;

public partial class EditarClasificacionView
{
    public EditarClasificacionView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarClasificacionViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (EditarClasificacionView)recipient;
                    view.Close();
                }
            });
    }

    public EditarClasificacionViewModel ViewModel => (EditarClasificacionViewModel)DataContext;
}

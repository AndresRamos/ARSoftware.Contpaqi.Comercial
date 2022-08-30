using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Agentes;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Agentes;

public partial class EditarAgenteView
{
    public EditarAgenteView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarAgenteViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (EditarAgenteView)recipient;
                    view.Close();
                }
            });
    }

    public EditarAgenteViewModel ViewModel => (EditarAgenteViewModel)DataContext;
}

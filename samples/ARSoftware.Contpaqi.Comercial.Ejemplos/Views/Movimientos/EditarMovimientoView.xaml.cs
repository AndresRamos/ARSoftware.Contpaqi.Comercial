using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Movimientos;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Movimientos;

public partial class EditarMovimientoView
{
    public EditarMovimientoView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarMovimientoViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (EditarMovimientoView)recipient;
                    view.Close();
                    Close();
                }
            });
    }

    public EditarMovimientoViewModel ViewModel => (EditarMovimientoViewModel)DataContext;
}

using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Direcciones;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Direcciones;

/// <summary>
///     Interaction logic for EditarDireccionView.xaml
/// </summary>
public partial class EditarDireccionView
{
    public EditarDireccionView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarDireccionViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (EditarDireccionView)recipient;
                    view.Close();
                }
            });
    }

    public EditarDireccionViewModel ViewModel => (EditarDireccionViewModel)DataContext;
}

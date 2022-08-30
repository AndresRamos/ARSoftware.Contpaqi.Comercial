using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Almacenes;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Almacenes;

/// <summary>
///     Interaction logic for SeleccionarAlmacenView.xaml
/// </summary>
public partial class SeleccionarAlmacenView
{
    public SeleccionarAlmacenView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<SeleccionarAlmacenViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (SeleccionarAlmacenView)recipient;
                    view.Close();
                }
            });
    }

    public SeleccionarAlmacenViewModel ViewModel => (SeleccionarAlmacenViewModel)DataContext;
}

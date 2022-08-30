using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Clientes;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Clientes;

/// <summary>
///     Interaction logic for CrearClienteProveedorView.xaml
/// </summary>
public partial class EditarClienteProveedorView
{
    public EditarClienteProveedorView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarClienteProveedorViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (EditarClienteProveedorView)recipient;
                    view.Close();
                }
            });
    }

    public EditarClienteProveedorViewModel ViewModel => (EditarClienteProveedorViewModel)DataContext;
}

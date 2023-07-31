using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Clientes;

namespace Sdk.Extras.WpfApp.Views.Clientes;

/// <summary>
///     Interaction logic for CrearClienteProveedorView.xaml
/// </summary>
public partial class EditarClienteProveedorView
{
    public EditarClienteProveedorView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarClienteProveedorViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
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

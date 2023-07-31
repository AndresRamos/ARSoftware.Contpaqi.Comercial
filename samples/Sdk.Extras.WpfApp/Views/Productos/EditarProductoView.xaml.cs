using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Productos;

namespace Sdk.Extras.WpfApp.Views.Productos;

public partial class EditarProductoView
{
    public EditarProductoView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarProductoViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (EditarProductoView)recipient;
                view.Close();
            }
        });
    }

    public EditarProductoViewModel ViewModel => (EditarProductoViewModel)DataContext;
}

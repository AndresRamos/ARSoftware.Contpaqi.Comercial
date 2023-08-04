using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Almacenes;

namespace Sdk.Extras.WpfApp.Views.Almacenes;

public partial class EditarAlmacenView
{
    public EditarAlmacenView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarAlmacenViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
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

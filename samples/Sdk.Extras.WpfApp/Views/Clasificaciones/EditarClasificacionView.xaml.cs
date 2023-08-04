using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Clasificaciones;

namespace Sdk.Extras.WpfApp.Views.Clasificaciones;

public partial class EditarClasificacionView
{
    public EditarClasificacionView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarClasificacionViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
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

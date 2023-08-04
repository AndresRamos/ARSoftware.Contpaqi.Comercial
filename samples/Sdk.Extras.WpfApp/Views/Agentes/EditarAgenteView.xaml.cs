using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Agentes;

namespace Sdk.Extras.WpfApp.Views.Agentes;

public partial class EditarAgenteView
{
    public EditarAgenteView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarAgenteViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
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

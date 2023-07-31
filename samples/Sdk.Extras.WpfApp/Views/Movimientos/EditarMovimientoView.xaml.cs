using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Movimientos;

namespace Sdk.Extras.WpfApp.Views.Movimientos;

public partial class EditarMovimientoView
{
    public EditarMovimientoView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarMovimientoViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
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

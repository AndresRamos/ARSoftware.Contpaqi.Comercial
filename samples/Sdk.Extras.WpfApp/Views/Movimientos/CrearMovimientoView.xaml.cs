using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Movimientos;

namespace Sdk.Extras.WpfApp.Views.Movimientos;

/// <summary>
///     Interaction logic for CrearMovimientoView.xaml
/// </summary>
public partial class CrearMovimientoView
{
    public CrearMovimientoView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<CrearMovimientoViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (CrearMovimientoView)recipient;
                view.Close();
            }
        });
    }

    public CrearMovimientoViewModel ViewModel => (CrearMovimientoViewModel)DataContext;
}

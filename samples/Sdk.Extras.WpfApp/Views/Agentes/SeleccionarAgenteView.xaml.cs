using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Agentes;

namespace Sdk.Extras.WpfApp.Views.Agentes;

/// <summary>
///     Interaction logic for SeleccionarAgenteView.xaml
/// </summary>
public partial class SeleccionarAgenteView
{
    public SeleccionarAgenteView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<SeleccionarAgenteViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (SeleccionarAgenteView)recipient;
                view.Close();
            }
        });
    }

    public SeleccionarAgenteViewModel ViewModel => (SeleccionarAgenteViewModel)DataContext;
}

using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Agentes;

namespace Sdk.Extras.WpfApp.Views.Agentes;

/// <summary>
///     Interaction logic for ListadoAgentesView.xaml
/// </summary>
public partial class ListadoAgentesView
{
    public ListadoAgentesView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoAgentesViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (ListadoAgentesView)recipient;
                view.Close();
            }
        });
    }

    public ListadoAgentesViewModel ViewModel => (ListadoAgentesViewModel)DataContext;
}

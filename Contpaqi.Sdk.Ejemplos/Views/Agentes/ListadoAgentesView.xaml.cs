using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Agentes;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Agentes;

/// <summary>
///     Interaction logic for ListadoAgentesView.xaml
/// </summary>
public partial class ListadoAgentesView
{
    public ListadoAgentesView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoAgentesViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
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

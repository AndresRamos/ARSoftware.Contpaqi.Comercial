using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Errores;

namespace Sdk.Extras.WpfApp.Views.Errores;

/// <summary>
///     Interaction logic for ListadoErroresView.xaml
/// </summary>
public partial class ListadoErroresView
{
    public ListadoErroresView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoErroresViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (ListadoErroresView)recipient;
                view.Close();
            }
        });
    }

    public ListadoErroresViewModel ViewModel => (ListadoErroresViewModel)DataContext;
}

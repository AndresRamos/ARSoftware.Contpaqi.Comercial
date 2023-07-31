using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Almacenes;

namespace Sdk.Extras.WpfApp.Views.Almacenes;

/// <summary>
///     Interaction logic for ListadoAlmacenesView.xaml
/// </summary>
public partial class ListadoAlmacenesView
{
    public ListadoAlmacenesView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoAlmacenesViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (ListadoAlmacenesView)recipient;
                view.Close();
            }
        });
    }

    public ListadoAlmacenesViewModel ViewModel => (ListadoAlmacenesViewModel)DataContext;
}

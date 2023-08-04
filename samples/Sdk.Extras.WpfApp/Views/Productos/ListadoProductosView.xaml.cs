using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Productos;

namespace Sdk.Extras.WpfApp.Views.Productos;

/// <summary>
///     Interaction logic for ListadoProductosView.xaml
/// </summary>
public partial class ListadoProductosView
{
    public ListadoProductosView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoProductosViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (ListadoProductosView)recipient;
                view.Close();
                Close();
            }
        });
    }

    public ListadoProductosViewModel ViewModel => (ListadoProductosViewModel)DataContext;
}

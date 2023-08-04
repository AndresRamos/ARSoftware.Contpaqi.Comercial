using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Almacenes;

namespace Sdk.Extras.WpfApp.Views.Almacenes;

/// <summary>
///     Interaction logic for SeleccionarAlmacenView.xaml
/// </summary>
public partial class SeleccionarAlmacenView
{
    public SeleccionarAlmacenView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<SeleccionarAlmacenViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (SeleccionarAlmacenView)recipient;
                view.Close();
            }
        });
    }

    public SeleccionarAlmacenViewModel ViewModel => (SeleccionarAlmacenViewModel)DataContext;
}

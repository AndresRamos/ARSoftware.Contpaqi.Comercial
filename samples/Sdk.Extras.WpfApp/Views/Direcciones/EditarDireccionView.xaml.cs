using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Direcciones;

namespace Sdk.Extras.WpfApp.Views.Direcciones;

/// <summary>
///     Interaction logic for EditarDireccionView.xaml
/// </summary>
public partial class EditarDireccionView
{
    public EditarDireccionView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarDireccionViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (EditarDireccionView)recipient;
                view.Close();
            }
        });
    }

    public EditarDireccionViewModel ViewModel => (EditarDireccionViewModel)DataContext;
}

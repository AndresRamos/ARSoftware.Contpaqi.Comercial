using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.ValoresClasificacion;

namespace Sdk.Extras.WpfApp.Views.ValoresClasificacion;

/// <summary>
///     Interaction logic for EditarValorClasificacionView.xaml
/// </summary>
public partial class EditarValorClasificacionView
{
    public EditarValorClasificacionView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarValorClasificacionViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (EditarValorClasificacionView)recipient;
                view.Close();
            }
        });
    }

    public EditarValorClasificacionViewModel ViewModel => (EditarValorClasificacionViewModel)DataContext;
}

using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.ValoresClasificacion;

namespace Sdk.Extras.WpfApp.Views.ValoresClasificacion;

/// <summary>
///     Interaction logic for SeleccionarValorClasificacionView.xaml
/// </summary>
public partial class SeleccionarValorClasificacionView
{
    public SeleccionarValorClasificacionView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<SeleccionarValorClasificacionViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (SeleccionarValorClasificacionView)recipient;
                view.Close();
            }
        });
    }

    public SeleccionarValorClasificacionViewModel ViewModel => (SeleccionarValorClasificacionViewModel)DataContext;
}

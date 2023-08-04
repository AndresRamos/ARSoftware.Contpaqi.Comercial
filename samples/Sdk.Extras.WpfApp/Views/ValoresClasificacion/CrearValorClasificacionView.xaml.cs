using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.ValoresClasificacion;

namespace Sdk.Extras.WpfApp.Views.ValoresClasificacion;

/// <summary>
///     Interaction logic for CrearValorClasificacionView.xaml
/// </summary>
public partial class CrearValorClasificacionView
{
    public CrearValorClasificacionView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<CrearValorClasificacionViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (CrearValorClasificacionView)recipient;
                view.Close();
            }
        });
    }

    public CrearValorClasificacionViewModel ViewModel => (CrearValorClasificacionViewModel)DataContext;
}

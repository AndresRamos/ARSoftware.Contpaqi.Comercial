using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.ValoresClasificacion;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.ValoresClasificacion;

/// <summary>
///     Interaction logic for SeleccionarValorClasificacionView.xaml
/// </summary>
public partial class SeleccionarValorClasificacionView
{
    public SeleccionarValorClasificacionView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<SeleccionarValorClasificacionViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
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

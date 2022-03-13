using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Movimientos;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Movimientos;

/// <summary>
///     Interaction logic for CrearMovimientoView.xaml
/// </summary>
public partial class CrearMovimientoView
{
    public CrearMovimientoView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<CrearMovimientoViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (CrearMovimientoView)recipient;
                    view.Close();
                }
            });
    }

    public CrearMovimientoViewModel ViewModel => (CrearMovimientoViewModel)DataContext;
}

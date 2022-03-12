using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Agentes;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Agentes;

/// <summary>
///     Interaction logic for SeleccionarAgenteView.xaml
/// </summary>
public partial class SeleccionarAgenteView
{
    public SeleccionarAgenteView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<SeleccionarAgenteViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (SeleccionarAgenteView)recipient;
                    view.Close();
                }
            });
    }

    public SeleccionarAgenteViewModel ViewModel => (SeleccionarAgenteViewModel)DataContext;
}

using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Empresas;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Empresas;

/// <summary>
///     Interaction logic for SeleccionarEmpresaView.xaml
/// </summary>
public partial class SeleccionarEmpresaView
{
    public SeleccionarEmpresaView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<SeleccionarEmpresaViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (SeleccionarEmpresaView)recipient;
                    view.Close();
                }
            });
    }

    public SeleccionarEmpresaViewModel ViewModel => (SeleccionarEmpresaViewModel)DataContext;
}

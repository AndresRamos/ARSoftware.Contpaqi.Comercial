using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.ValoresClasificacion;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.ValoresClasificacion;

/// <summary>
///     Interaction logic for CrearValorClasificacionView.xaml
/// </summary>
public partial class CrearValorClasificacionView
{
    public CrearValorClasificacionView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<CrearValorClasificacionViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
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

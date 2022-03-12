using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Clasificaciones;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Clasificaciones;

public partial class ListadoClasificacionesView
{
    public ListadoClasificacionesView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoClasificacionesViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (ListadoClasificacionesView)recipient;
                    view.Close();
                }
            });
    }

    public ListadoClasificacionesViewModel ViewModel => (ListadoClasificacionesViewModel)DataContext;
}

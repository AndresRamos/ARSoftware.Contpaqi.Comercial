using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Clasificaciones;

namespace Sdk.Extras.WpfApp.Views.Clasificaciones;

public partial class ListadoClasificacionesView
{
    public ListadoClasificacionesView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoClasificacionesViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
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

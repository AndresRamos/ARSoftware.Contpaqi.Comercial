using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Almacenes;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Almacenes;

/// <summary>
///     Interaction logic for ListadoAlmacenesView.xaml
/// </summary>
public partial class ListadoAlmacenesView
{
    public ListadoAlmacenesView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoAlmacenesViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (ListadoAlmacenesView)recipient;
                    view.Close();
                }
            });
    }

    public ListadoAlmacenesViewModel ViewModel => (ListadoAlmacenesViewModel)DataContext;
}

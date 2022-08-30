using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Productos;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Productos;

/// <summary>
///     Interaction logic for ListadoProductosView.xaml
/// </summary>
public partial class ListadoProductosView
{
    public ListadoProductosView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoProductosViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (ListadoProductosView)recipient;
                    view.Close();
                    Close();
                }
            });
    }

    public ListadoProductosViewModel ViewModel => (ListadoProductosViewModel)DataContext;
}

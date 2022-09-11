using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Errores;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Errores;

/// <summary>
///     Interaction logic for ListadoErroresView.xaml
/// </summary>
public partial class ListadoErroresView
{
    public ListadoErroresView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoErroresViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (ListadoErroresView)recipient;
                    view.Close();
                }
            });
    }

    public ListadoErroresViewModel ViewModel => (ListadoErroresViewModel)DataContext;
}

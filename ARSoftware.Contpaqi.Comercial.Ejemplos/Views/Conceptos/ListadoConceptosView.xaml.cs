using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Conceptos;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Conceptos;

/// <summary>
///     Interaction logic for ListadoConceptosView.xaml
/// </summary>
public partial class ListadoConceptosView
{
    public ListadoConceptosView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoConceptosViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (ListadoConceptosView)recipient;
                    view.Close();
                }
            });
    }

    public ListadoConceptosViewModel ViewModel => (ListadoConceptosViewModel)DataContext;
}

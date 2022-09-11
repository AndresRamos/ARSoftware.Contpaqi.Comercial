using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Documentos;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Documentos;

/// <summary>
///     Interaction logic for ListadoDocumetnosView.xaml
/// </summary>
public partial class ListadoDocumentosView
{
    public ListadoDocumentosView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoDocumentosViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (ListadoDocumentosView)recipient;
                    view.Close();
                }
            });
    }

    public ListadoDocumentosViewModel ViewModel => (ListadoDocumentosViewModel)DataContext;
}

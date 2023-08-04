using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Conceptos;

namespace Sdk.Extras.WpfApp.Views.Conceptos;

/// <summary>
///     Interaction logic for ListadoConceptosView.xaml
/// </summary>
public partial class ListadoConceptosView
{
    public ListadoConceptosView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ListadoConceptosViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
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

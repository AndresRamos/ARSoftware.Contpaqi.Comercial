using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Parametros;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Parametros;

public partial class ParametrosView
{
    public ParametrosView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ParametrosViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (ParametrosView)recipient;
                    view.Close();
                    Close();
                }
            });
    }

    public ParametrosViewModel ViewModel => (ParametrosViewModel)DataContext;
}

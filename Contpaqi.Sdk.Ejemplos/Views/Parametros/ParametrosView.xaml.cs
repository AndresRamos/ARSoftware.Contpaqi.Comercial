using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Parametros;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Parametros;

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

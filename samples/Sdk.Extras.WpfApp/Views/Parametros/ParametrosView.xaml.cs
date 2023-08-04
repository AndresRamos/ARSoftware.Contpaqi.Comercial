using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.Parametros;

namespace Sdk.Extras.WpfApp.Views.Parametros;

public partial class ParametrosView
{
    public ParametrosView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<ParametrosViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
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

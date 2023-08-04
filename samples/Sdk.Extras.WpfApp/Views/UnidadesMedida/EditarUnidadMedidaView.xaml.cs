using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.ViewModels.UnidadesMedida;

namespace Sdk.Extras.WpfApp.Views.UnidadesMedida;

public partial class EditarUnidadMedidaView
{
    public EditarUnidadMedidaView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarUnidadMedidaViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
        {
            if (message.Sender == ViewModel && message.IsOpen == false)
            {
                var view = (EditarUnidadMedidaView)recipient;
                view.Close();
                Close();
            }
        });
    }

    public EditarUnidadMedidaViewModel ViewModel => (EditarUnidadMedidaViewModel)DataContext;
}

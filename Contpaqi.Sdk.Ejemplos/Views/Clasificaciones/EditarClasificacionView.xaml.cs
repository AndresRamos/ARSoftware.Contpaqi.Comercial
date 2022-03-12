using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Clasificaciones;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Clasificaciones;

public partial class EditarClasificacionView
{
    public EditarClasificacionView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarClasificacionViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (EditarClasificacionView)recipient;
                    view.Close();
                }
            });
    }

    public EditarClasificacionViewModel ViewModel => (EditarClasificacionViewModel)DataContext;
}

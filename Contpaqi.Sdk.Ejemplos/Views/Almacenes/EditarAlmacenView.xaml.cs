using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Almacenes;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Almacenes;

public partial class EditarAlmacenView
{
    public EditarAlmacenView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarAlmacenViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (EditarAlmacenView)recipient;
                    view.Close();
                }
            });
    }

    public EditarAlmacenViewModel ViewModel => (EditarAlmacenViewModel)DataContext;
}

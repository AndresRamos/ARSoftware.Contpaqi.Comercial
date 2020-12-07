using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Clientes;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Clientes
{
    /// <summary>
    ///     Interaction logic for CrearClienteProveedorView.xaml
    /// </summary>
    public partial class EditarClienteProveedorView
    {
        public EditarClienteProveedorView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<EditarClienteProveedorViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public EditarClienteProveedorViewModel ViewModel => (EditarClienteProveedorViewModel) DataContext;
    }
}
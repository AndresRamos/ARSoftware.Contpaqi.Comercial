using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Facturas;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Facturas
{
    /// <summary>
    ///     Interaction logic for CrearFacturaView.xaml
    /// </summary>
    public partial class CrearFacturaView
    {
        public CrearFacturaView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<CrearFacturaViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public CrearFacturaViewModel ViewModel => (CrearFacturaViewModel) DataContext;
    }
}
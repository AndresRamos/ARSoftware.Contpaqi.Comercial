using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Movimientos;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Movimientos
{
    /// <summary>
    ///     Interaction logic for CrearMovimientoView.xaml
    /// </summary>
    public partial class CrearMovimientoView
    {
        public CrearMovimientoView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<CrearMovimientoViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public CrearMovimientoViewModel ViewModel => (CrearMovimientoViewModel) DataContext;
    }
}
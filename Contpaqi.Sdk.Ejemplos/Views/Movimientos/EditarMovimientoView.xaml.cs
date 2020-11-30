using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Movimientos;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Movimientos
{
    /// <summary>
    ///     Interaction logic for EditarMovimientoView.xaml
    /// </summary>
    public partial class EditarMovimientoView
    {
        public EditarMovimientoView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<EditarMovimientoViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public EditarMovimientoViewModel ViewModel => (EditarMovimientoViewModel) DataContext;
    }
}
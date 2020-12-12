using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Almacenes;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Almacenes
{
    /// <summary>
    ///     Interaction logic for SeleccionarAlmacenView.xaml
    /// </summary>
    public partial class SeleccionarAlmacenView
    {
        public SeleccionarAlmacenView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<SeleccionarAlmacenViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public SeleccionarAlmacenViewModel ViewModel => (SeleccionarAlmacenViewModel)DataContext;
    }
}
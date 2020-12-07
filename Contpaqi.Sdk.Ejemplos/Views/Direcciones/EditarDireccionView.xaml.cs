using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Direcciones;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Direcciones
{
    /// <summary>
    ///     Interaction logic for EditarDireccionView.xaml
    /// </summary>
    public partial class EditarDireccionView
    {
        public EditarDireccionView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<EditarDireccionViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public EditarDireccionViewModel ViewModel => (EditarDireccionViewModel) DataContext;
    }
}
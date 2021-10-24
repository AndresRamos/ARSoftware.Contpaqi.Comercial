using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Agentes;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Agentes
{
    /// <summary>
    ///     Interaction logic for EditarAgenteView.xaml
    /// </summary>
    public partial class EditarAgenteView
    {
        public EditarAgenteView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<EditarAgenteViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public EditarAgenteViewModel ViewModel => (EditarAgenteViewModel)DataContext;
    }
}
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Empresas;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Empresas
{
    /// <summary>
    ///     Interaction logic for SeleccionarEmpresaView.xaml
    /// </summary>
    public partial class SeleccionarEmpresaView
    {
        public SeleccionarEmpresaView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<SeleccionarEmpresaViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public SeleccionarEmpresaViewModel ViewModel => (SeleccionarEmpresaViewModel) DataContext;
    }
}
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.ValoresClasificacion;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.ValoresClasificacion
{
    /// <summary>
    ///     Interaction logic for EditarValorClasificacionView.xaml
    /// </summary>
    public partial class EditarValorClasificacionView
    {
        public EditarValorClasificacionView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<EditarValorClasificacionViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public EditarValorClasificacionViewModel ViewModel => (EditarValorClasificacionViewModel) DataContext;
    }
}
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Clasificaciones;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Clasificaciones
{
    /// <summary>
    ///     Interaction logic for ListadoClasificacionesView.xaml
    /// </summary>
    public partial class ListadoClasificacionesView
    {
        public ListadoClasificacionesView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<ListadoClasificacionesViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public ListadoClasificacionesViewModel ViewModel => (ListadoClasificacionesViewModel) DataContext;
    }
}
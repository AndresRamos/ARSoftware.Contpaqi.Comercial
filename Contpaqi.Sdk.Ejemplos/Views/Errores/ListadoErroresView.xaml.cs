using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Errores;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Errores
{
    /// <summary>
    ///     Interaction logic for ListadoErroresView.xaml
    /// </summary>
    public partial class ListadoErroresView
    {
        public ListadoErroresView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<ListadoErroresViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public ListadoErroresViewModel ViewModel => (ListadoErroresViewModel) DataContext;
    }
}
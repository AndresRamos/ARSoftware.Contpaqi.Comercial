using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Almacenes;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Almacenes
{
    /// <summary>
    ///     Interaction logic for ListadoAlmacenesView.xaml
    /// </summary>
    public partial class ListadoAlmacenesView
    {
        public ListadoAlmacenesView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<ListadoAlmacenesViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public ListadoAlmacenesViewModel ViewModel => (ListadoAlmacenesViewModel) DataContext;
    }
}
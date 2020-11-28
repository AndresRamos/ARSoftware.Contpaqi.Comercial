using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Productos;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Productos
{
    /// <summary>
    ///     Interaction logic for ListadoProductosView.xaml
    /// </summary>
    public partial class ListadoProductosView
    {
        public ListadoProductosView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<ListadoProductosViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public ListadoProductosViewModel ViewModel => (ListadoProductosViewModel) DataContext;
    }
}
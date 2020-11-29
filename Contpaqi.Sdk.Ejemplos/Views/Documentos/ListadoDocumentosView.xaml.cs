using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Documentos;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Documentos
{
    /// <summary>
    ///     Interaction logic for ListadoDocumetnosView.xaml
    /// </summary>
    public partial class ListadoDocumentosView
    {
        public ListadoDocumentosView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<ListadoDocumentosViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public ListadoDocumentosViewModel ViewModel => (ListadoDocumentosViewModel) DataContext;
    }
}
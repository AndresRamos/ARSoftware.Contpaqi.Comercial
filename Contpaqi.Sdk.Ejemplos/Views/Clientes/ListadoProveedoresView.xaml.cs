using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.ViewModels.Clientes;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.Views.Clientes
{
    /// <summary>
    /// Interaction logic for ListadoProveedoresView.xaml
    /// </summary>
    public partial class ListadoProveedoresView 
    {
        public ListadoProveedoresView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<ListadoProveedoresViewModel>();
            WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this, (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    Close();
                }
            });
        }

        public ListadoProveedoresViewModel ViewModel => (ListadoProveedoresViewModel) DataContext;
    }
}

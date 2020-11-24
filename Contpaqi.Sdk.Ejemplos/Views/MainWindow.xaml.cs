using Contpaqi.Sdk.Ejemplos.ViewModels;
using Microsoft.Toolkit.Mvvm.DependencyInjection;

namespace Contpaqi.Sdk.Ejemplos.Views
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<MainWindowViewModel>();
        }

        public MainWindowViewModel ViewModel => (MainWindowViewModel) DataContext;
    }
}
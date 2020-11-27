using Contpaqi.Sdk.Ejemplos.ViewModels;
using Microsoft.Toolkit.Mvvm.DependencyInjection;

namespace Contpaqi.Sdk.Ejemplos.Views
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<MainViewModel>();
        }

        public MainViewModel ViewModel => (MainViewModel) DataContext;
    }
}
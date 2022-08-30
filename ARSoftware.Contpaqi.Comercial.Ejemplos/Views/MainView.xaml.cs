using System.Diagnostics;
using System.Windows.Navigation;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views;

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

    public MainViewModel ViewModel => (MainViewModel)DataContext;

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        new Process { StartInfo = new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true } }.Start();
    }
}

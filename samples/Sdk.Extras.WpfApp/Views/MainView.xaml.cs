using System.Diagnostics;
using System.Windows.Navigation;
using CommunityToolkit.Mvvm.DependencyInjection;
using Sdk.Extras.WpfApp.ViewModels;

namespace Sdk.Extras.WpfApp.Views;

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

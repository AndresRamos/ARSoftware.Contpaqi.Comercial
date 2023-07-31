using CommunityToolkit.Mvvm.ComponentModel;

namespace Sdk.Extras.WpfApp.Models;

public class ConfiguracionAplicacion : ObservableObject
{
    private Empresa _empresa;

    public Empresa Empresa
    {
        get => _empresa;
        set => SetProperty(ref _empresa, value);
    }
}

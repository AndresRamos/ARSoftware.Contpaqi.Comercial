using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Models;

public class ConfiguracionAplicacion : ObservableObject
{
    private Empresa _empresa;

    public Empresa Empresa
    {
        get => _empresa;
        set => SetProperty(ref _empresa, value);
    }
}

using Contpaqi.Sdk.Extras.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace Contpaqi.Sdk.Ejemplos.Models
{
    public class ConfiguracionAplicacion : ObservableObject
    {
        private Empresa _empresa;

        public Empresa Empresa
        {
            get => _empresa;
            set => SetProperty(ref _empresa, value);
        }
    }
}
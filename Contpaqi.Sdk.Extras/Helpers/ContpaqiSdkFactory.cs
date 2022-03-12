using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public class ContpaqiSdkFactory
    {
        public IContpaqiSdk Crear(TipoContpaqiSdk tipoContpaqiSdk)
        {
            switch (tipoContpaqiSdk)
            {
                case TipoContpaqiSdk.Comercial:
                    return new ComercialSdkExtended();

                case TipoContpaqiSdk.Adminpaq:
                    return new AdminpaqSdkExtended();

                case TipoContpaqiSdk.FacturaElectronica:
                    return new FacturaElectronicaSdkExtended();

                default:
                    return null;
            }
        }
    }
}

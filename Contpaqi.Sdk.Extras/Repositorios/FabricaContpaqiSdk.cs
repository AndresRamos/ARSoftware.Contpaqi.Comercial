using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos.Enums;

namespace Contpaqi.Sdk.Extras.Repositorios
{
    public class FabricaContpaqiSdk
    {
        public IContpaqiSdk Crear(ContpaqiSdkEnum sdk)
        {
            switch (sdk)
            {
                case ContpaqiSdkEnum.Comercial:
                    return new ComercialSdkExtended();

                case ContpaqiSdkEnum.Adminpaq:
                    return new AdminpaqSdkExtended();

                case ContpaqiSdkEnum.FacturaElectronica:
                    return new FacturaElectronicaSdkExtended();

                default:
                    return null;
            }
        }
    }
}
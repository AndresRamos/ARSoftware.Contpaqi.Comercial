using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public class ContpaqiSdkFactory
    {
        public IContpaqiSdk Create(ContpaqiSdkEnum sdk)
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
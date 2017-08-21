using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class FabricaContpaqiSdk
    {
        public FabricaContpaqiSdk()
        {
        }

        public ISistemasComercialesSdk Crear(ContpaqiSdkEnum sdk)
        {
            switch (sdk)
            {
                case ContpaqiSdkEnum.Comercial:
                    return new ServicioComercialSdk();

                case ContpaqiSdkEnum.Adminpaq:
                    return new ServicioAdminpaqSdk();

                case ContpaqiSdkEnum.FacturaElectronica:
                    return new ServicioFacturaElectronicaSdk();

                default:
                    return null;
            }
        }
    }
}
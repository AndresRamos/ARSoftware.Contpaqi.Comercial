using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

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
                throw new ArgumentOutOfRangeException(nameof(tipoContpaqiSdk), tipoContpaqiSdk, null);
        }
    }
}

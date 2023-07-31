using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.WpfApp.Models;

public class Direccion : admDomicilios
{
    public TipoCatalogoDireccion TipoCatalogo
    {
        get => TipoCatalogoDireccionHelper.ConvertFromSdkValue(CTIPOCATALOGO);
        set => CTIPOCATALOGO = TipoCatalogoDireccionHelper.ConvertToSdkValue(value);
    }

    public TipoDireccion TipoDireccion
    {
        get => TipoDireccionHelper.ConvertFromSdkValue(CTIPODIRECCION);
        set => CTIPODIRECCION = TipoDireccionHelper.ConvertToSdkValue(value);
    }

    public tDireccion ToTDireccion()
    {
        return new tDireccion
        {
            cCodCteProv = "",
            cTipoCatalogo = (int)TipoCatalogo,
            cTipoDireccion = TipoDireccion == TipoDireccion.Fiscal ? 1 : 2,
            cNombreCalle = CNOMBRECALLE,
            cNumeroExterior = CNUMEROEXTERIOR,
            cNumeroInterior = CNUMEROINTERIOR,
            cColonia = CCOLONIA,
            cCodigoPostal = CCODIGOPOSTAL,
            cTelefono1 = CTELEFONO1,
            cTelefono2 = CTELEFONO2,
            cTelefono3 = CTELEFONO3,
            cTelefono4 = CTELEFONO4,
            cEmail = CEMAIL,
            cDireccionWeb = CDIRECCIONWEB,
            cCiudad = CCIUDAD,
            cEstado = CESTADO,
            cPais = CPAIS,
            cTextoExtra = CTEXTOEXTRA
        };
    }
}

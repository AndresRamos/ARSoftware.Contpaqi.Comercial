using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.WpfApp.Models;

public class Producto : admProductos
{
    public Producto()
    {
        CFECHAEXTRA = SdkDateTimeHelper.CreateDefaultSdkFecha();
        CFECHABAJA = SdkDateTimeHelper.CreateDefaultSdkFecha();
        CFECHAALTAPRODUCTO = DateTime.Today;
        CFECHAERRORCOSTO = SdkDateTimeHelper.CreateDefaultSdkFecha();
        CMETODOCOSTEO = 1;
        CSTATUSPRODUCTO = 1;
        CBANMETODOCOSTEO = 1;
        CBANPRECIO = 1;
        CBANIMPUESTO = 1;
        CFECCOSEX1 = SdkDateTimeHelper.CreateDefaultSdkFecha();
        CFECCOSEX2 = SdkDateTimeHelper.CreateDefaultSdkFecha();
        CFECCOSEX3 = SdkDateTimeHelper.CreateDefaultSdkFecha();
        CFECCOSEX4 = SdkDateTimeHelper.CreateDefaultSdkFecha();
        CFECCOSEX5 = SdkDateTimeHelper.CreateDefaultSdkFecha();
        CDESGLOSAI2 = 1;
    }

    public TipoProducto Tipo
    {
        get => TipoProductoHelper.ConvertFromSdkValue(CTIPOPRODUCTO);
        set => CTIPOPRODUCTO = TipoProductoHelper.ConvertToSdkValue(value);
    }

    public UnidadMedida UnidadBase { get; set; } = new();
    public UnidadMedida UnidadNoConvertible { get; set; } = new();
    public ValorClasificacion ValorClasificacion1 { get; set; } = new();
    public ValorClasificacion ValorClasificacion2 { get; set; } = new();
    public ValorClasificacion ValorClasificacion3 { get; set; } = new();
    public ValorClasificacion ValorClasificacion4 { get; set; } = new();
    public ValorClasificacion ValorClasificacion5 { get; set; } = new();
    public ValorClasificacion ValorClasificacion6 { get; set; } = new();

    public bool Contains(string filtro)
    {
        return string.IsNullOrWhiteSpace(filtro) ||
               CCODIGOPRODUCTO.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CNOMBREPRODUCTO.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CDESCRIPCIONPRODUCTO?.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    public override string ToString()
    {
        return $"{CCODIGOPRODUCTO} - {CNOMBREPRODUCTO}";
    }

    public tProducto ToTProducto()
    {
        return new tProducto
        {
            cCodigoProducto = CCODIGOPRODUCTO,
            cNombreProducto = CNOMBREPRODUCTO,
            cDescripcionProducto = CDESCRIPCIONPRODUCTO ?? string.Empty,
            cTipoProducto = TipoProductoHelper.ConvertToSdkValue(Tipo),
            cFechaAltaProducto = CFECHAALTAPRODUCTO.ToSdkFecha(),
            cFechaBaja = CFECHABAJA.ToSdkFecha(),
            cStatusProducto = CSTATUSPRODUCTO,
            cControlExistencia = CCONTROLEXISTENCIA,
            cMetodoCosteo = CMETODOCOSTEO,
            cCodigoUnidadBase = UnidadBase.CNOMBREUNIDAD,
            cCodigoUnidadNoConvertible = UnidadNoConvertible.CNOMBREUNIDAD,
            cPrecio1 = CPRECIO1,
            cPrecio2 = CPRECIO2,
            cPrecio3 = CPRECIO3,
            cPrecio4 = CPRECIO4,
            cPrecio5 = CPRECIO5,
            cPrecio6 = CPRECIO6,
            cPrecio7 = CPRECIO7,
            cPrecio8 = CPRECIO8,
            cPrecio9 = CPRECIO9,
            cPrecio10 = CPRECIO10,
            cImpuesto1 = CIMPUESTO1,
            cImpuesto2 = CIMPUESTO2,
            cImpuesto3 = CIMPUESTO3,
            cRetencion1 = CRETENCION1,
            cRetencion2 = CRETENCION2,
            cNombreCaracteristica1 = string.Empty,
            cNombreCaracteristica2 = string.Empty,
            cNombreCaracteristica3 = string.Empty,
            cCodigoValorClasificacion1 =
                ValorClasificacion1.CCODIGOVALORCLASIFICACION != "0" ? ValorClasificacion1.CCODIGOVALORCLASIFICACION : string.Empty,
            cCodigoValorClasificacion2 =
                ValorClasificacion2.CCODIGOVALORCLASIFICACION != "0" ? ValorClasificacion2.CCODIGOVALORCLASIFICACION : string.Empty,
            cCodigoValorClasificacion3 =
                ValorClasificacion3.CCODIGOVALORCLASIFICACION != "0" ? ValorClasificacion3.CCODIGOVALORCLASIFICACION : string.Empty,
            cCodigoValorClasificacion4 =
                ValorClasificacion4.CCODIGOVALORCLASIFICACION != "0" ? ValorClasificacion4.CCODIGOVALORCLASIFICACION : string.Empty,
            cCodigoValorClasificacion5 =
                ValorClasificacion5.CCODIGOVALORCLASIFICACION != "0" ? ValorClasificacion5.CCODIGOVALORCLASIFICACION : string.Empty,
            cCodigoValorClasificacion6 =
                ValorClasificacion6.CCODIGOVALORCLASIFICACION != "0" ? ValorClasificacion6.CCODIGOVALORCLASIFICACION : string.Empty,
            cTextoExtra1 = CTEXTOEXTRA1,
            cTextoExtra2 = CTEXTOEXTRA2,
            cTextoExtra3 = CTEXTOEXTRA3,
            cFechaExtra = CFECHAEXTRA.ToSdkFecha(),
            cImporteExtra1 = CIMPORTEEXTRA1,
            cImporteExtra2 = CIMPORTEEXTRA2,
            cImporteExtra3 = CIMPORTEEXTRA3,
            cImporteExtra4 = CIMPORTEEXTRA4
        };
    }
}

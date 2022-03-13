using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Models;

public class ProductoLookup
{
    public int CIDPRODUCTO { get; set; }
    public string CCODIGOPRODUCTO { get; set; }
    public string CNOMBREPRODUCTO { get; set; }
    public int CTIPOPRODUCTO { get; set; }

    public TipoProducto Tipo
    {
        get => TipoProductoHelper.ConvertFromSdkValue(CTIPOPRODUCTO);
        set => CTIPOPRODUCTO = TipoProductoHelper.ConvertToSdkValue(value);
    }

    public override string ToString()
    {
        return $"{CCODIGOPRODUCTO} - {CNOMBREPRODUCTO}";
    }
}

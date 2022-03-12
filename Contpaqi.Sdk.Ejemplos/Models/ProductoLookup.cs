using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Models.Enums;

// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace Contpaqi.Sdk.Ejemplos.Models;

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

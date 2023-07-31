using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace Sdk.Extras.WpfApp.Models;

public class ProductoLookup
{
    public string CCODIGOPRODUCTO { get; set; }
    public int CIDPRODUCTO { get; set; }
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

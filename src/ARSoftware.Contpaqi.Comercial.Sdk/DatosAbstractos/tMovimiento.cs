using System.Runtime.InteropServices;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
public struct tMovimiento
{
    /// <summary>
    ///     Consecutivo del movimiento.
    /// </summary>
    public int aConsecutivo;

    /// <summary>
    ///     Unidades del movimiento.
    /// </summary>
    public double aUnidades;

    /// <summary>
    ///     Precio del movimiento (para doctos. de venta ).
    /// </summary>
    public double aPrecio;

    /// <summary>
    ///     Costo del movimiento (para doctos. de compra).
    /// </summary>
    public double aCosto;

    /// <summary>
    ///     Códogo del producto o servicio.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string aCodProdSer;

    /// <summary>
    ///     Código del Almacén.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string aCodAlmacen;

    /// <summary>
    ///     Referencia del movimiento.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongReferencia)]
    public string aReferencia;

    /// <summary>
    ///     Código de la clasificación.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string aCodClasificacion;
}

using System.Runtime.InteropServices;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
public struct tMovimientoDesc
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
    ///     Precio del movimiento (para doctos. de venta).
    /// </summary>
    public double aPrecio;

    /// <summary>
    ///     Costo del movimiento (para doctos. de compra).
    /// </summary>
    public double aCosto;

    /// <summary>
    ///     Porcentaje del Descuento 1.
    /// </summary>
    public double aPorcDescto1;

    /// <summary>
    ///     Importe del Descuento 1.
    /// </summary>
    public double aImporteDescto1;

    /// <summary>
    ///     Porcentaje del Descuento 2.
    /// </summary>
    public double aPorcDescto2;

    /// <summary>
    ///     Importe del Descuento 2.
    /// </summary>
    public double aImporteDescto2;

    /// <summary>
    ///     Porcentaje del Descuento 3.
    /// </summary>
    public double aPorcDescto3;

    /// <summary>
    ///     Importe del Descuento 3.
    /// </summary>
    public double aImporteDescto3;

    /// <summary>
    ///     Porcentaje del Descuento 4.
    /// </summary>
    public double aPorcDescto4;

    /// <summary>
    ///     Importe del Descuento 4.
    /// </summary>
    public double aImporteDescto4;

    /// <summary>
    ///     Porcentaje del Descuento 5.
    /// </summary>
    public double aPorcDescto5;

    /// <summary>
    ///     Importe del Descuento 5.
    /// </summary>
    public double aImporteDescto5;

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

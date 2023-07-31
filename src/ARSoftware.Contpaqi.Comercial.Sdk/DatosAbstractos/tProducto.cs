using System.Runtime.InteropServices;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
public struct tProducto
{
    /// <summary>
    ///     Código del producto.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string cCodigoProducto;

    /// <summary>
    ///     Nombre del producto.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongNombre)]
    public string cNombreProducto;

    /// <summary>
    ///     Descripción del producto.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongNombreProducto)]
    public string cDescripcionProducto;

    /// <summary>
    ///     1- Producto, 2 - Paquete, 3 - Servicio
    /// </summary>
    public int cTipoProducto;

    /// <summary>
    ///     Fecha de alta del producto.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongFecha)]
    public string cFechaAltaProducto;

    /// <summary>
    ///     Fecha de baja del producto.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongFecha)]
    public string cFechaBaja;

    /// <summary>
    ///     0 - Baja Lógica, 1 – Alta
    /// </summary>
    public int cStatusProducto;

    /// <summary>
    ///     Control de exixtencia.
    /// </summary>
    public int cControlExistencia;

    /// <summary>
    ///     1. Costo Promedio Base a Entradas, Costo Promedio Base a Entradas Almacen Último costo, 2. UEPS, 3. PEPS, 4. Costo
    ///     específico, 5. Costo Estandar.
    /// </summary>
    public int cMetodoCosteo;

    /// <summary>
    ///     Código de la unidad base.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string cCodigoUnidadBase;

    /// <summary>
    ///     Código de la unidad no convertible.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string cCodigoUnidadNoConvertible;

    /// <summary>
    ///     Lista de precios 1.
    /// </summary>
    public double cPrecio1;

    /// <summary>
    ///     Lista de precios 2.
    /// </summary>
    public double cPrecio2;

    /// <summary>
    ///     Lista de precios 3.
    /// </summary>
    public double cPrecio3;

    /// <summary>
    ///     Lista de precios 4.
    /// </summary>
    public double cPrecio4;

    /// <summary>
    ///     Lista de precios 5.
    /// </summary>
    public double cPrecio5;

    /// <summary>
    ///     Lista de precios 6.
    /// </summary>
    public double cPrecio6;

    /// <summary>
    ///     Lista de precios 7.
    /// </summary>
    public double cPrecio7;

    /// <summary>
    ///     Lista de precios 8.
    /// </summary>
    public double cPrecio8;

    /// <summary>
    ///     Lista de precios 9.
    /// </summary>
    public double cPrecio9;

    /// <summary>
    ///     Lista de precios 10.
    /// </summary>
    public double cPrecio10;

    /// <summary>
    ///     Impuesto 1.
    /// </summary>
    public double cImpuesto1;

    /// <summary>
    ///     Impuesto 2.
    /// </summary>
    public double cImpuesto2;

    /// <summary>
    ///     Impuesto 3.
    /// </summary>
    public double cImpuesto3;

    /// <summary>
    ///     Retención 1.
    /// </summary>
    public double cRetencion1;

    /// <summary>
    ///     Retención 1.
    /// </summary>
    public double cRetencion2;

    /// <summary>
    ///     Nombre de la caracteristica 1.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongNombre)]
    public string cNombreCaracteristica1;

    /// <summary>
    ///     Nombre de la caracteristica 2.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongNombre)]
    public string cNombreCaracteristica2;

    /// <summary>
    ///     Nombre de la caracteristica 3.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongNombre)]
    public string cNombreCaracteristica3;

    /// <summary>
    ///     Código del valor de la clasificación 1.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacion1;

    /// <summary>
    ///     Código del valor de la clasificación 2.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacion2;

    /// <summary>
    ///     Código del valor de la clasificación 3.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacion3;

    /// <summary>
    ///     Código del valor de la clasificación 4.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacion4;

    /// <summary>
    ///     Código del valor de la clasificación 5.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacion5;

    /// <summary>
    ///     Código del valor de la clasificación 6.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacion6;

    /// <summary>
    ///     Texto extra 1.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongTextoExtra)]
    public string cTextoExtra1;

    /// <summary>
    ///     Texto extra 2.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongTextoExtra)]
    public string cTextoExtra2;

    /// <summary>
    ///     Texto extra 3.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongTextoExtra)]
    public string cTextoExtra3;

    /// <summary>
    ///     Fecha extra.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongFecha)]
    public string cFechaExtra;

    /// <summary>
    ///     Importe Extra 1.
    /// </summary>
    public double cImporteExtra1;

    /// <summary>
    ///     Importe Extra 2.
    /// </summary>
    public double cImporteExtra2;

    /// <summary>
    ///     Importe Extra 3.
    /// </summary>
    public double cImporteExtra3;

    /// <summary>
    ///     Importe Extra 4.
    /// </summary>
    public double cImporteExtra4;
}

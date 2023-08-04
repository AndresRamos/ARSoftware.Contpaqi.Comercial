using System.Runtime.InteropServices;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
public struct tDocumento
{
    /// <summary>
    ///     Folio del documento.
    /// </summary>
    public double aFolio;

    /// <summary>
    ///     Moneda del documento. 1 = Pesos MN, 2 = Moneda extranjera.
    /// </summary>
    public int aNumMoneda;

    /// <summary>
    ///     Tipo de cambio del documento.
    /// </summary>
    public double aTipoCambio;

    /// <summary>
    ///     Importe del documento. Sólo se usa en documentos de cargo/abono.
    /// </summary>
    public double aImporte;

    /// <summary>
    ///     No tiene uso, valor por omisión = 0 (cero).
    /// </summary>
    public double aDescuentoDoc1;

    /// <summary>
    ///     No tiene uso, valor por omisión = 0 (cero).
    /// </summary>
    public double aDescuentoDoc2;

    /// <summary>
    ///     Valor mayor a 5 que indica una aplicación diferente a los PAQ's.
    /// </summary>
    public int aSistemaOrigen;

    /// <summary>
    ///     Código del concepto del documento.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string aCodConcepto;

    /// <summary>
    ///     Serie del documento.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongSerie)]
    public string aSerie;

    /// <summary>
    ///     Fecha del documento. Formato mm/dd/aaaa Las “/” diagonales son parte del formato.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongFecha)]
    public string aFecha;

    /// <summary>
    ///     Código del Cliente/Proveedor.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string aCodigoCteProv;

    /// <summary>
    ///     Código del Agente.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string aCodigoAgente;

    /// <summary>
    ///     Referencia del Documento.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongReferencia)]
    public string aReferencia;

    /// <summary>
    ///     No tiene uso, valor por omisión = 0 (cero).
    /// </summary>
    public int aAfecta;

    /// <summary>
    ///     Importes de gastos para las compras.
    /// </summary>
    public double aGasto1;

    /// <summary>
    ///     Importes de gastos para las compras.
    /// </summary>
    public double aGasto2;

    /// <summary>
    ///     Importes de gastos para las compras.
    /// </summary>
    public double aGasto3;
}

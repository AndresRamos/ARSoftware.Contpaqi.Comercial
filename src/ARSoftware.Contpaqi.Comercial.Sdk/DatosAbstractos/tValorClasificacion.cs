using System.Runtime.InteropServices;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
public struct tValorClasificacion
{
    /// <summary>
    ///     Clasificación.
    /// </summary>
    public int cClasificacionDe;

    /// <summary>
    ///     Número de la clasificación.
    /// </summary>
    public int cNumClasificacion;

    /// <summary>
    ///     Código del valor de la clasificación.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacion;

    /// <summary>
    ///     Valor de la clasificación.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
    public string cValorClasificacion;
}

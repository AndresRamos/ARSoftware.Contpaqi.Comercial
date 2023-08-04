using System.Runtime.InteropServices;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
public struct tLlaveAper
{
    /// <summary>
    ///     Código de la caja.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string aCodCaja;

    /// <summary>
    ///     Fecha de apertura.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongFecha)]
    public string aFechaApe;
}

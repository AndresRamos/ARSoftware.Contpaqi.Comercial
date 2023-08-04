using System.Runtime.InteropServices;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
public struct tCaracteristicas
{
    /// <summary>
    ///     Unidades del movimiento.
    /// </summary>
    public double aUnidades;

    /// <summary>
    ///     Valor de la caracteristica 1 del movimiento.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
    public string aValorCaracteristica1;

    /// <summary>
    ///     Valor de la caracteristica 2 del movimiento.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
    public string aValorCaracteristica2;

    /// <summary>
    ///     Valor de la caracteristica 3 del movimiento.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
    public string aValorCaracteristica3;
}

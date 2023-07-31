using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
public struct tTipoProducto
{
    /// <summary>
    ///     Tipo de dato abstracto: tSeriesCapas.
    /// </summary>
    public tSeriesCapas aSeriesCapas;

    /// <summary>
    ///     Tipo de dato abstracto: Caracteristicas.
    /// </summary>
    public tCaracteristicas aCaracteristicas;
}

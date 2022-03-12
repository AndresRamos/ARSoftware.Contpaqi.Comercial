using System.Runtime.InteropServices;

// ReSharper disable UnusedType.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming

namespace Contpaqi.Sdk.DatosAbstractos
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tTipoProducto
    {
        public tSeriesCapas aSeriesCapas;
        public tCaracteristicas aCaracteristicas;
    }
}

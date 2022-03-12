using System.Runtime.InteropServices;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

// ReSharper disable UnusedType.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tCaracteristicas
    {
        public double aUnidades;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDescripcion)]
        public string aValorCaracteristica1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDescripcion)]
        public string aValorCaracteristica2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDescripcion)]
        public string aValorCaracteristica3;
    }
}

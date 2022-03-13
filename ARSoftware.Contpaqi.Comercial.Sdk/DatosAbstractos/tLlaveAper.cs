using System.Runtime.InteropServices;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

// ReSharper disable UnusedType.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tLlaveAper
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodigo)]
        public string aCodCaja;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongFecha)]
        public string aFechaApe;
    }
}

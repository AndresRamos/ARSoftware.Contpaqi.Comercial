using System.Runtime.InteropServices;
using Contpaqi.Sdk.Constantes;

// ReSharper disable UnusedType.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming

namespace Contpaqi.Sdk.DatosAbstractos
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

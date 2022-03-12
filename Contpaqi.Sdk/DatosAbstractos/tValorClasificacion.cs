using System.Runtime.InteropServices;
using Contpaqi.Sdk.Constantes;

// ReSharper disable UnusedType.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming

namespace Contpaqi.Sdk.DatosAbstractos
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tValorClasificacion
    {
        public int cClasificacionDe;
        public int cNumClasificacion;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacion;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDescripcion)]
        public string cValorClasificacion;
    }
}

using System.Runtime.InteropServices;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

// ReSharper disable UnusedType.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tUnidad
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongNombre)]
        public string cNombreUnidad;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongAbreviatura)]
        public string cAbreviatura;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongAbreviatura)]
        public string cDespliegue;
    }
}

using System.Runtime.InteropServices;
using Contpaqi.Sdk.Constantes;

// ReSharper disable UnusedType.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming

namespace Contpaqi.Sdk.DatosAbstractos
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tSeriesCapas
    {
        public double aUnidades;
        public double aTipoCambio;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodigo)]
        public string aSeries;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDescripcion)]
        public string aPedimento;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDescripcion)]
        public string aAgencia;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongFecha)]
        public string aFechaPedimento;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDescripcion)]
        public string aNumeroLote;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongFecha)]
        public string aFechaFabricacion;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongFecha)]
        public string aFechaCaducidad;
    }
}

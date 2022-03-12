using System.Runtime.InteropServices;
using Contpaqi.Sdk.Constantes;

// ReSharper disable UnusedType.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming

namespace Contpaqi.Sdk.DatosAbstractos
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tProducto
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodigo)]
        public string cCodigoProducto;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongNombre)]
        public string cNombreProducto;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongNombreProducto)]
        public string cDescripcionProducto;

        public int cTipoProducto;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongFecha)]
        public string cFechaAltaProducto;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongFecha)]
        public string cFechaBaja;

        public int cStatusProducto;
        public int cControlExistencia;
        public int cMetodoCosteo;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodigo)]
        public string cCodigoUnidadBase;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodigo)]
        public string cCodigoUnidadNoConvertible;

        public double cPrecio1;
        public double cPrecio2;
        public double cPrecio3;
        public double cPrecio4;
        public double cPrecio5;
        public double cPrecio6;
        public double cPrecio7;
        public double cPrecio8;
        public double cPrecio9;
        public double cPrecio10;
        public double cImpuesto1;
        public double cImpuesto2;
        public double cImpuesto3;
        public double cRetencion1;
        public double cRetencion2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongNombre)]
        public string cNombreCaracteristica1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongNombre)]
        public string cNombreCaracteristica2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongNombre)]
        public string cNombreCaracteristica3;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacion1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacion2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacion3;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacion4;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacion5;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacion6;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongTextoExtra)]
        public string cTextoExtra1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongTextoExtra)]
        public string cTextoExtra2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongTextoExtra)]
        public string cTextoExtra3;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongFecha)]
        public string cFechaExtra;

        public double cImporteExtra1;
        public double cImporteExtra2;
        public double cImporteExtra3;
        public double cImporteExtra4;
    }
}

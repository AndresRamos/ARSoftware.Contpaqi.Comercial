using System.Runtime.InteropServices;
using Contpaqi.Sdk.Constantes;

// ReSharper disable UnusedType.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming

namespace Contpaqi.Sdk.DatosAbstractos
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tCteProv
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodigo)]
        public string cCodigoCliente;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongNombre)]
        public string cRazonSocial;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongFecha)]
        public string cFechaAlta;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongRFC)]
        public string cRFC;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCURP)]
        public string cCURP;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDenComercial)]
        public string cDenComercial;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongRepLegal)]
        public string cRepLegal;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongNombre)]
        public string cNombreMoneda;

        public int cListaPreciosCliente;
        public double cDescuentoMovto;
        public int cBanVentaCredito;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacionCliente1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacionCliente2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacionCliente3;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacionCliente4;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacionCliente5;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacionCliente6;

        public int cTipoCliente;
        public int cEstatus;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongFecha)]
        public string cFechaBaja;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongFecha)]
        public string cFechaUltimaRevision;

        public double cLimiteCreditoCliente;
        public int cDiasCreditoCliente;
        public int cBanExcederCredito;
        public double cDescuentoProntoPago;
        public int cDiasProntoPago;
        public double cInteresMoratorio;
        public int cDiaPago;
        public int cDiasRevision;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDesCorta)]
        public string cMensajeria;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDescripcion)]
        public string cCuentaMensajeria;

        public int cDiasEmbarqueCliente;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodigo)]
        public string cCodigoAlmacen;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodigo)]
        public string cCodigoAgenteVenta;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodigo)]
        public string cCodigoAgenteCobro;

        public int cRestriccionAgente;
        public double cImpuesto1;
        public double cImpuesto2;
        public double cImpuesto3;
        public double cRetencionCliente1;
        public double cRetencionCliente2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacionProveedor1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacionProveedor2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacionProveedor3;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacionProveedor4;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacionProveedor5;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodValorClasif)]
        public string cCodigoValorClasificacionProveedor6;

        public double cLimiteCreditoProveedor;
        public int cDiasCreditoProveedor;
        public int cTiempoEntrega;
        public int cDiasEmbarqueProveedor;
        public double cImpuestoProveedor1;
        public double cImpuestoProveedor2;
        public double cImpuestoProveedor3;
        public double cRetencionProveedor1;
        public double cRetencionProveedor2;
        public int cBanInteresMoratorio;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongTextoExtra)]
        public string cTextoExtra1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongTextoExtra)]
        public string cTextoExtra2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongTextoExtra)]
        public string cTextoExtra3;

        public double cImporteExtra1;
        public double cImporteExtra2;
        public double cImporteExtra3;
        public double cImporteExtra4;
    }
}

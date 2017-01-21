using System.Runtime.InteropServices;

namespace Contpaqi.SistemasComerciales.Sdk
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tDocumento
    {
        public double aFolio;
        public int aNumMoneda;
        public double aTipoCambio;
        public double aImporte;
        public double aDescuentoDoc1;
        public double aDescuentoDoc2;
        public int aSistemaOrigen;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string aCodConcepto;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongSerie)]
        public string aSerie;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongFecha)]
        public string aFecha;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string aCodigoCteProv;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string aCodigoAgente;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongReferencia)]
        public string aReferencia;
        public int aAfecta;
        public double aGasto1;
        public double aGasto2;
        public double aGasto3;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tLlaveDoc
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string aCodConcepto;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongSerie)]
        public string aSerie;
        public double aFolio;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tMovimiento
    {
        public int aConsecutivo;
        public double aUnidades;
        public double aPrecio;
        public double aCosto;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string aCodProdSer;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string aCodAlmacen;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongReferencia)]
        public string aReferencia;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string aCodClasificacion;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tMovimientoDesc
    {
        public int aConsecutivo;
        public double aUnidades;
        public double aPrecio;
        public double aCosto;
        public double aPorcDescto1;
        public double aImporteDescto1;
        public double aPorcDescto2;
        public double aImporteDescto2;
        public double aPorcDescto3;
        public double aImporteDescto3;
        public double aPorcDescto4;
        public double aImporteDescto4;
        public double aPorcDescto5;
        public double aImporteDescto5;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string aCodProdSer;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string aCodAlmacen;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongReferencia)]
        public string aReferencia;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string aCodClasificacion;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tSeriesCapas
    {
        public double aUnidades;
        public double aTipoCambio;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string aSeries;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDescripcion)]
        public string aPedimento;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDescripcion)]
        public string aAgencia;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongFecha)]
        public string aFechaPedimento;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDescripcion)]
        public string aNumeroLote;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongFecha)]
        public string aFechaFabricacion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongFecha)]
        public string aFechaCaducidad;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tCaracteristicas
    {
        public double aUnidades;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDescripcion)]
        public string aValorCaracteristica1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDescripcion)]
        public string aValorCaracteristica2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDescripcion)]
        public string aValorCaracteristica3;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tTipoProducto
    {
        public tSeriesCapas aSeriesCapas;
        public tCaracteristicas aCaracteristicas;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tLlaveAper
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string aCodCaja;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongFecha)]
        public string aFechaApe;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tProducto
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string cCodigoProducto;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongNombre)]
        public string cNombreProducto;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongNombreProducto)]
        public string cDescripcionProducto;
        public int cTipoProducto;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongFecha)]
        public string cFechaAltaProducto;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongFecha)]
        public string cFechaBaja;
        public int cStatusProducto;
        public int cControlExistencia;
        public int cMetodoCosteo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string cCodigoUnidadBase;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
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
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongNombre)]
        public string cNombreCaracteristica1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongNombre)]
        public string cNombreCaracteristica2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongNombre)]
        public string cNombreCaracteristica3;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacion1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacion2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacion3;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacion4;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacion5;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacion6;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongTextoExtra)]
        public string cTextoExtra1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongTextoExtra)]
        public string cTextoExtra2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongTextoExtra)]
        public string cTextoExtra3;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongFecha)]
        public string cFechaExtra;
        public double cImporteExtra1;
        public double cImporteExtra2;
        public double cImporteExtra3;
        public double cImporteExtra4;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tCteProv
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string cCodigoCliente;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongNombre)]
        public string cRazonSocial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongFecha)]
        public string cFechaAlta;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongRFC)]
        public string cRFC;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCURP)]
        public string cCURP;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDenComercial)]
        public string cDenComercial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongRepLegal)]
        public string cRepLegal;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongNombre)]
        public string cNombreMoneda;
        public int cListaPreciosCliente;
        public double cDescuentoMovto;
        public int cBanVentaCredito;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacionCliente1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacionCliente2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacionCliente3;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacionCliente4;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacionCliente5;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacionCliente6;
        public int cTipoCliente;
        public int cEstatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongFecha)]
        public string cFechaBaja;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongFecha)]
        public string cFechaUltimaRevision;
        public double cLimiteCreditoCliente;
        public int cDiasCreditoCliente;
        public int cBanExcederCredito;
        public double cDescuentoProntoPago;
        public int cDiasProntoPago;
        public double cInteresMoratorio;
        public int cDiaPago;
        public int cDiasRevision;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDesCorta)]
        public string cMensajeria;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDescripcion)]
        public string cCuentaMensajeria;
        public int cDiasEmbarqueCliente;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string cCodigoAlmacen;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string cCodigoAgenteVenta;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string cCodigoAgenteCobro;
        public int cRestriccionAgente;
        public double cImpuesto1;
        public double cImpuesto2;
        public double cImpuesto3;
        public double cRetencionCliente1;
        public double cRetencionCliente2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacionProveedor1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacionProveedor2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacionProveedor3;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacionProveedor4;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacionProveedor5;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
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
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongTextoExtra)]
        public string cTextoExtra1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongTextoExtra)]
        public string cTextoExtra2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongTextoExtra)]
        public string cTextoExtra3;
        public double cImporteExtra1;
        public double cImporteExtra2;
        public double cImporteExtra3;
        public double cImporteExtra4;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tValorClasificacion
    {
        public int cClasificacionDe;
        public int cNumClasificacion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodValorClasif)]
        public string cCodigoValorClasificacion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDescripcion)]
        public string cValorClasificacion;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tUnidad
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongNombre)]
        public string cNombreUnidad;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongAbreviatura)]
        public string cAbreviatura;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongAbreviatura)]
        public string cDespliegue;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tDireccion
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigo)]
        public string cCodCteProv;
        public int cTipoCatalogo;
        public int cTipoDireccion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDescripcion)]
        public string cNombreCalle;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongNumeroExpandido)]
        public string cNumeroExterior;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongNumeroExpandido)]
        public string cNumeroInterior;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDescripcion)]
        public string cColonia;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongCodigoPostal)]
        public string cCodigoPostal;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongTelefono)]
        public string cTelefono1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongTelefono)]
        public string cTelefono2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongTelefono)]
        public string cTelefono3;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongTelefono)]
        public string cTelefono4;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongEmailWeb)]
        public string cEmail;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongEmailWeb)]
        public string cDireccionWeb;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDescripcion)]
        public string cCiudad;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDescripcion)]
        public string cEstado;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDescripcion)]
        public string cPais;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constantes.kLongDescripcion)]
        public string cTextoExtra;
    }
}

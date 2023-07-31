using System.Runtime.InteropServices;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
public struct tCteProv
{
    /// <summary>
    ///     Código del Cliente / Proveedor.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string cCodigoCliente;

    /// <summary>
    ///     Razón social.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongNombre)]
    public string cRazonSocial;

    /// <summary>
    ///     Fecha de alta.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongFecha)]
    public string cFechaAlta;

    /// <summary>
    ///     RFC.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongRFC)]
    public string cRFC;

    /// <summary>
    ///     CURP.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCURP)]
    public string cCURP;

    /// <summary>
    ///     Denominación comercial.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDenComercial)]
    public string cDenComercial;

    /// <summary>
    ///     Representante legal.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongRepLegal)]
    public string cRepLegal;

    /// <summary>
    ///     Nombre de la moneda.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongNombre)]
    public string cNombreMoneda;

    /// <summary>
    ///     Lista de precios.
    /// </summary>
    public int cListaPreciosCliente;

    /// <summary>
    ///     Descuento.
    /// </summary>
    public double cDescuentoMovto;

    /// <summary>
    ///     Bandera de venta a crédito. 0 – No se permite, 1 – Se permite.
    /// </summary>
    public int cBanVentaCredito;

    /// <summary>
    ///     Código del valor de clasificación 1.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacionCliente1;

    /// <summary>
    ///     Código del valor de clasificación 2.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacionCliente2;

    /// <summary>
    ///     Código del valor de clasificación 3.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacionCliente3;

    /// <summary>
    ///     Código del valor de clasificación 4.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacionCliente4;

    /// <summary>
    ///     Código del valor de clasificación 5.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacionCliente5;

    /// <summary>
    ///     Código del valor de clasificación 6.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacionCliente6;

    /// <summary>
    ///     Tipo de cliente. 1. Cliente, 2. Cliente/Proveedor, 3. Proveedor.
    /// </summary>
    public int cTipoCliente;

    /// <summary>
    ///     Estado: 0 – Inactivo, 1 – Activo.
    /// </summary>
    public int cEstatus;

    /// <summary>
    ///     Fecha de baja.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongFecha)]
    public string cFechaBaja;

    /// <summary>
    ///     Fecha de última revisión.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongFecha)]
    public string cFechaUltimaRevision;

    /// <summary>
    ///     Limite de crédito.
    /// </summary>
    public double cLimiteCreditoCliente;

    /// <summary>
    ///     Días de crédito del cliente.
    /// </summary>
    public int cDiasCreditoCliente;

    /// <summary>
    ///     Bandera de exceder crédito. 0 – No se permite, 1 – Se permite.
    /// </summary>
    public int cBanExcederCredito;

    /// <summary>
    ///     Descuento por pronto pago.
    /// </summary>
    public double cDescuentoProntoPago;

    /// <summary>
    ///     Días para pronto pago.
    /// </summary>
    public int cDiasProntoPago;

    /// <summary>
    ///     Interes moratorio.
    /// </summary>
    public double cInteresMoratorio;

    /// <summary>
    ///     Día de pago.
    /// </summary>
    public int cDiaPago;

    /// <summary>
    ///     Días de revisión.
    /// </summary>
    public int cDiasRevision;

    /// <summary>
    ///     Mensajeria.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDesCorta)]
    public string cMensajeria;

    /// <summary>
    ///     Cuenta de mensajeria.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
    public string cCuentaMensajeria;

    /// <summary>
    ///     Dias de embarque del cliente.
    /// </summary>
    public int cDiasEmbarqueCliente;

    /// <summary>
    ///     Código del almacén.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string cCodigoAlmacen;

    /// <summary>
    ///     Código del agente de venta.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string cCodigoAgenteVenta;

    /// <summary>
    ///     Código del agente de cobro.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string cCodigoAgenteCobro;

    /// <summary>
    ///     Restricción de agente.
    /// </summary>
    public int cRestriccionAgente;

    /// <summary>
    ///     Impuesto 1.
    /// </summary>
    public double cImpuesto1;

    /// <summary>
    ///     Impuesto 2.
    /// </summary>
    public double cImpuesto2;

    /// <summary>
    ///     Impuesto 3.
    /// </summary>
    public double cImpuesto3;

    /// <summary>
    ///     Retención al cliente 1.
    /// </summary>
    public double cRetencionCliente1;

    /// <summary>
    ///     Retención al cliente 2.
    /// </summary>
    public double cRetencionCliente2;

    /// <summary>
    ///     Código del valor de clasificación 1.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacionProveedor1;

    /// <summary>
    ///     Código del valor de clasificación 2.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacionProveedor2;

    /// <summary>
    ///     Código del valor de clasificación 3.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacionProveedor3;

    /// <summary>
    ///     Código del valor de clasificación 4.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacionProveedor4;

    /// <summary>
    ///     Código del valor de clasificación 5.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacionProveedor5;

    /// <summary>
    ///     Código del valor de clasificación 6.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodValorClasif)]
    public string cCodigoValorClasificacionProveedor6;

    /// <summary>
    ///     Limite de credito del proveedor.
    /// </summary>
    public double cLimiteCreditoProveedor;

    /// <summary>
    ///     Días de credito del proveedor.
    /// </summary>
    public int cDiasCreditoProveedor;

    /// <summary>
    ///     Tiempo de entrega.
    /// </summary>
    public int cTiempoEntrega;

    /// <summary>
    ///     Días de embarque.
    /// </summary>
    public int cDiasEmbarqueProveedor;

    /// <summary>
    ///     Impuesto proveedor 1.
    /// </summary>
    public double cImpuestoProveedor1;

    /// <summary>
    ///     Impuesto proveedor 2.
    /// </summary>
    public double cImpuestoProveedor2;

    /// <summary>
    ///     Impuesto proveedor 3.
    /// </summary>
    public double cImpuestoProveedor3;

    /// <summary>
    ///     Retención proveedor 1.
    /// </summary>
    public double cRetencionProveedor1;

    /// <summary>
    ///     Retención proveedor 2.
    /// </summary>
    public double cRetencionProveedor2;

    /// <summary>
    ///     Bandera de cálculo de interes moratorio. 0 – No se calculan, 1 – Si se calculan.
    /// </summary>
    public int cBanInteresMoratorio;

    /// <summary>
    ///     Texto extra 1.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongTextoExtra)]
    public string cTextoExtra1;

    /// <summary>
    ///     Texto extra 2.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongTextoExtra)]
    public string cTextoExtra2;

    /// <summary>
    ///     Texto extra 3.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongTextoExtra)]
    public string cTextoExtra3;

    /// <summary>
    ///     Importe extra 1.
    /// </summary>
    public double cImporteExtra1;

    /// <summary>
    ///     Importe extra 2.
    /// </summary>
    public double cImporteExtra2;

    //Importe extra 3.
    public double cImporteExtra3;

    /// <summary>
    ///     Importe extra 4.
    /// </summary>
    public double cImporteExtra4;
}

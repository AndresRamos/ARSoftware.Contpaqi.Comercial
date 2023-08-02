using Ardalis.SmartEnum;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

public sealed class DocumentoModeloEnum : SmartEnum<DocumentoModeloEnum>
{
    public static readonly DocumentoModeloEnum Cotizacion = new("Cotizacion", 1);
    public static readonly DocumentoModeloEnum Pedido = new("Pedido", 2);
    public static readonly DocumentoModeloEnum Remision = new("Remision", 3);
    public static readonly DocumentoModeloEnum Factura = new("Factura", 4);
    public static readonly DocumentoModeloEnum DevolucionSobreVenta = new("Devolucion Sobre Venta", 5);
    public static readonly DocumentoModeloEnum DevolucionDeRemision = new("Devolucion De Remision", 6);
    public static readonly DocumentoModeloEnum NotaDeCredito = new("Nota De Credito", 7);
    public static readonly DocumentoModeloEnum CambioDelCliente = new("Cambio Del Cliente", 8);
    public static readonly DocumentoModeloEnum PagoDeCliente = new("Pago Del Cliente", 9);
    public static readonly DocumentoModeloEnum ChequeRecibido = new("Cheque Recibido", 10);
    public static readonly DocumentoModeloEnum HonorariosDelCliente = new("Honorarios Del Cliente", 11);
    public static readonly DocumentoModeloEnum AbonoDelCliente = new("Abono Del Cliente", 12);
    public static readonly DocumentoModeloEnum NotaDeCargoAlCliente = new("Nota De Cargo Al Cliente", 13);
    public static readonly DocumentoModeloEnum DescuentoPorProntoPago = new("Descuento Por Pronto Pago", 14);
    public static readonly DocumentoModeloEnum Pagare = new("Pagare", 15);
    public static readonly DocumentoModeloEnum InteresMoratorio = new("Interes Moratorio", 16);
    public static readonly DocumentoModeloEnum OrdenDeCompra = new("Orden De Compra", 17);
    public static readonly DocumentoModeloEnum ConsignacionDelProveedor = new("Consignacion Del Proveedor", 18);
    public static readonly DocumentoModeloEnum Compra = new("Compra", 19);
    public static readonly DocumentoModeloEnum DevolucionSobreCompra = new("Devolucion Sobre Compra", 20);
    public static readonly DocumentoModeloEnum DevolucionDeConsignacion = new("Devolucion De Consignacion", 21);
    public static readonly DocumentoModeloEnum NotaDeCreditoDeProveedor = new("Nota De Credito Del Proveedor", 22);
    public static readonly DocumentoModeloEnum PagoAlProveedor = new("Pago Al proveedor", 23);
    public static readonly DocumentoModeloEnum ChequeEmitido = new("Cheque Emitido", 24);
    public static readonly DocumentoModeloEnum HonorariosDelProveedor = new("Honorarios Del Proveedor", 25);
    public static readonly DocumentoModeloEnum AbonoAlProveedor = new("Abono Al Proveedor", 26);
    public static readonly DocumentoModeloEnum CargoDelProveedor = new("Cargo Del Proveedor", 27);
    public static readonly DocumentoModeloEnum UtilidadCambiariaCliente = new("Utilidad Cambiaria Cliente", 28);
    public static readonly DocumentoModeloEnum PerdidaCambiariaCliente = new("Perdida Cambiaria Cliente", 29);
    public static readonly DocumentoModeloEnum UtilidadCambiariaProveedor = new("Utilidad Cambiaria Proveedor", 30);
    public static readonly DocumentoModeloEnum PerdidaCambiariaProveedor = new("Perdida Cambiaria Proveedor", 31);
    public static readonly DocumentoModeloEnum EntradaAlAlmacen = new("Entrada Al Almacen", 32);
    public static readonly DocumentoModeloEnum SalidaDelAlmacen = new("Salida Del Almacen", 33);
    public static readonly DocumentoModeloEnum Traspasos = new("Traspasos", 34);
    public static readonly DocumentoModeloEnum NotaDeVenta = new("Nota De Venta", 35);
    public static readonly DocumentoModeloEnum DevolucionSobreNotaDeVenta = new("Devolucion Sobre Nota De Venta", 36);
    public static readonly DocumentoModeloEnum AjusteAlCosto = new("Ajuste Al Costo", 37);
    public static readonly DocumentoModeloEnum CotizacionDelProveedor = new("Cotización del Proveedor", 38);

    /// <inheritdoc />
    private DocumentoModeloEnum(string name, int value) : base(name, value)
    {
    }
}

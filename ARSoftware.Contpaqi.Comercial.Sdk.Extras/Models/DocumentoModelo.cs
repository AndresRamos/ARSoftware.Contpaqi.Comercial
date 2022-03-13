using System;
using System.Collections.Generic;
using System.Linq;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models
{
    public class DocumentoModelo
    {
        public DocumentoModelo()
        {
        }

        public DocumentoModelo(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public static DocumentoModelo AbonoAlProveedor { get; } = new DocumentoModelo(26, "Abono Al Proveedor");
        public static DocumentoModelo AbonoDelCliente { get; } = new DocumentoModelo(12, "Abono Del Cliente");
        public static DocumentoModelo AjusteAlCosto { get; } = new DocumentoModelo(37, "Ajuste Al Costo");
        public static DocumentoModelo CargoDelProveedor { get; } = new DocumentoModelo(27, "Cargo Del Proveedor");
        public static DocumentoModelo ChequeEmitido { get; } = new DocumentoModelo(24, "Cheque Emitido");
        public static DocumentoModelo ChequeRecibido { get; } = new DocumentoModelo(10, "Cheque Recibido");
        public static DocumentoModelo Compra { get; } = new DocumentoModelo(19, "Compra");
        public static DocumentoModelo ConsignacionDelProveedor { get; } = new DocumentoModelo(18, "Consignacion Del Proveedor");

        public static DocumentoModelo Cotizacion { get; } = new DocumentoModelo(1, "Cotizacion");

        public string Descripcion { get; set; }
        public static DocumentoModelo DescuentoPorProntoPago { get; } = new DocumentoModelo(14, "Descuento Por Pronto Pago");
        public static DocumentoModelo DevolucionDeConsignacion { get; } = new DocumentoModelo(21, "Devolucion De Consignacion");
        public static DocumentoModelo DevolucionDeRemision { get; } = new DocumentoModelo(6, "Devolucion De Remision");
        public static DocumentoModelo DevolucionSobreCompra { get; } = new DocumentoModelo(20, "Devolucion Sobre Compra");
        public static DocumentoModelo DevolucionSobreNotaDeVenta { get; } = new DocumentoModelo(36, "Devolucion Sobre Nota De Venta");
        public static DocumentoModelo DevolucionSobreVenta { get; } = new DocumentoModelo(5, "Devolucion Sobre Venta");
        public static DocumentoModelo EntradaAlAlmacen { get; } = new DocumentoModelo(32, "Entrada Al Almacen");
        public static DocumentoModelo Factura { get; } = new DocumentoModelo(4, "Factura");
        public static DocumentoModelo HonorariosDelCliente { get; } = new DocumentoModelo(11, "Honorarios Del Cliente");
        public static DocumentoModelo HonorariosDelProveedor { get; } = new DocumentoModelo(25, "Honorarios Del Proveedor");

        public int Id { get; set; }
        public static DocumentoModelo InteresMoratorio { get; } = new DocumentoModelo(16, "Interes Moratorio");
        public static DocumentoModelo NotaDeCargoAlCliente { get; } = new DocumentoModelo(13, "Nota De Cargo Al Cliente");
        public static DocumentoModelo NotaDeCredito { get; } = new DocumentoModelo(7, "Nota De Credito");
        public static DocumentoModelo NotaDeCreditoDeProveedor { get; } = new DocumentoModelo(22, "Nota De Credito Del Proveedor");
        public static DocumentoModelo NotaDeVenta { get; } = new DocumentoModelo(35, "Nota De Venta");
        public static DocumentoModelo OrdenDeCompra { get; } = new DocumentoModelo(17, "Orden De Compra");
        public static DocumentoModelo Pagare { get; } = new DocumentoModelo(15, "Pagare");
        public static DocumentoModelo PagoAlProveedor { get; } = new DocumentoModelo(23, "Pago Al proveedor");
        public static DocumentoModelo PagoDeCliente { get; } = new DocumentoModelo(9, "Pago Del Cliente");
        public static DocumentoModelo Pedido { get; } = new DocumentoModelo(2, "Pedido");
        public static DocumentoModelo PerdidaCambiariaCliente { get; } = new DocumentoModelo(29, "Perdida Cambiaria Cliente");
        public static DocumentoModelo PerdidaCambiariaProveedor { get; } = new DocumentoModelo(31, "Perdida Cambiaria Proveedor");
        public static DocumentoModelo Remision { get; } = new DocumentoModelo(3, "Remision");
        public static DocumentoModelo SalidaDelAlmacen { get; } = new DocumentoModelo(33, "Salida Del Almacen");
        public static DocumentoModelo Traspasos { get; } = new DocumentoModelo(34, "Traspasos");
        public static DocumentoModelo UtilidadCambiariaCliente { get; } = new DocumentoModelo(28, "Utilidad Cambiaria Cliente");
        public static DocumentoModelo UtilidadCambiariaProveedor { get; } = new DocumentoModelo(30, "Utilidad Cambiaria Proveedor");

        public static DocumentoModelo FromDescripcion(string descripcion)
        {
            return ToList().Single(r => string.Equals(r.Descripcion, descripcion, StringComparison.OrdinalIgnoreCase));
        }

        public static DocumentoModelo FromId(int id)
        {
            return ToList().Single(r => r.Id == id);
        }

        public static IEnumerable<DocumentoModelo> ToList()
        {
            yield return Cotizacion;
            yield return Pedido;
            yield return Remision;
            yield return Factura;
            yield return DevolucionSobreVenta;
            yield return DevolucionDeRemision;
            yield return NotaDeCredito;
            yield return PagoDeCliente;
            yield return ChequeRecibido;
            yield return HonorariosDelCliente;
            yield return AbonoDelCliente;
            yield return NotaDeCargoAlCliente;
            yield return DescuentoPorProntoPago;
            yield return Pagare;
            yield return InteresMoratorio;
            yield return OrdenDeCompra;
            yield return ConsignacionDelProveedor;
            yield return Compra;
            yield return DevolucionSobreCompra;
            yield return DevolucionDeConsignacion;
            yield return NotaDeCreditoDeProveedor;
            yield return PagoAlProveedor;
            yield return ChequeEmitido;
            yield return HonorariosDelProveedor;
            yield return AbonoAlProveedor;
            yield return CargoDelProveedor;
            yield return UtilidadCambiariaCliente;
            yield return PerdidaCambiariaCliente;
            yield return UtilidadCambiariaProveedor;
            yield return PerdidaCambiariaProveedor;
            yield return EntradaAlAlmacen;
            yield return SalidaDelAlmacen;
            yield return Traspasos;
            yield return NotaDeVenta;
            yield return DevolucionSobreNotaDeVenta;
            yield return AjusteAlCosto;
        }
    }
}

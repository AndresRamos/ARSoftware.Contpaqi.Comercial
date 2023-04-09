using System;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable UnusedMember.Global

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models
{
    public class DocumentoModelo
    {
        public static readonly DocumentoModelo Cotizacion = new DocumentoModelo(1, "Cotizacion");
        public static readonly DocumentoModelo Pedido = new DocumentoModelo(2, "Pedido");
        public static readonly DocumentoModelo Remision = new DocumentoModelo(3, "Remision");
        public static readonly DocumentoModelo Factura = new DocumentoModelo(4, "Factura");
        public static readonly DocumentoModelo DevolucionSobreVenta = new DocumentoModelo(5, "Devolucion Sobre Venta");
        public static readonly DocumentoModelo DevolucionDeRemision = new DocumentoModelo(6, "Devolucion De Remision");
        public static readonly DocumentoModelo NotaDeCredito = new DocumentoModelo(7, "Nota De Credito");
        public static readonly DocumentoModelo CambioDelCliente = new DocumentoModelo(8, "Cambio Del Cliente");
        public static readonly DocumentoModelo PagoDeCliente = new DocumentoModelo(9, "Pago Del Cliente");
        public static readonly DocumentoModelo ChequeRecibido = new DocumentoModelo(10, "Cheque Recibido");
        public static readonly DocumentoModelo HonorariosDelCliente = new DocumentoModelo(11, "Honorarios Del Cliente");
        public static readonly DocumentoModelo AbonoDelCliente = new DocumentoModelo(12, "Abono Del Cliente");
        public static readonly DocumentoModelo NotaDeCargoAlCliente = new DocumentoModelo(13, "Nota De Cargo Al Cliente");
        public static readonly DocumentoModelo DescuentoPorProntoPago = new DocumentoModelo(14, "Descuento Por Pronto Pago");
        public static readonly DocumentoModelo Pagare = new DocumentoModelo(15, "Pagare");
        public static readonly DocumentoModelo InteresMoratorio = new DocumentoModelo(16, "Interes Moratorio");
        public static readonly DocumentoModelo OrdenDeCompra = new DocumentoModelo(17, "Orden De Compra");
        public static readonly DocumentoModelo ConsignacionDelProveedor = new DocumentoModelo(18, "Consignacion Del Proveedor");
        public static readonly DocumentoModelo Compra = new DocumentoModelo(19, "Compra");
        public static readonly DocumentoModelo DevolucionSobreCompra = new DocumentoModelo(20, "Devolucion Sobre Compra");
        public static readonly DocumentoModelo DevolucionDeConsignacion = new DocumentoModelo(21, "Devolucion De Consignacion");
        public static readonly DocumentoModelo NotaDeCreditoDeProveedor = new DocumentoModelo(22, "Nota De Credito Del Proveedor");
        public static readonly DocumentoModelo PagoAlProveedor = new DocumentoModelo(23, "Pago Al proveedor");
        public static readonly DocumentoModelo ChequeEmitido = new DocumentoModelo(24, "Cheque Emitido");
        public static readonly DocumentoModelo HonorariosDelProveedor = new DocumentoModelo(25, "Honorarios Del Proveedor");
        public static readonly DocumentoModelo AbonoAlProveedor = new DocumentoModelo(26, "Abono Al Proveedor");
        public static readonly DocumentoModelo CargoDelProveedor = new DocumentoModelo(27, "Cargo Del Proveedor");
        public static readonly DocumentoModelo UtilidadCambiariaCliente = new DocumentoModelo(28, "Utilidad Cambiaria Cliente");
        public static readonly DocumentoModelo PerdidaCambiariaCliente = new DocumentoModelo(29, "Perdida Cambiaria Cliente");
        public static readonly DocumentoModelo UtilidadCambiariaProveedor = new DocumentoModelo(30, "Utilidad Cambiaria Proveedor");
        public static readonly DocumentoModelo PerdidaCambiariaProveedor = new DocumentoModelo(31, "Perdida Cambiaria Proveedor");
        public static readonly DocumentoModelo EntradaAlAlmacen = new DocumentoModelo(32, "Entrada Al Almacen");
        public static readonly DocumentoModelo SalidaDelAlmacen = new DocumentoModelo(33, "Salida Del Almacen");
        public static readonly DocumentoModelo Traspasos = new DocumentoModelo(34, "Traspasos");
        public static readonly DocumentoModelo NotaDeVenta = new DocumentoModelo(35, "Nota De Venta");
        public static readonly DocumentoModelo DevolucionSobreNotaDeVenta = new DocumentoModelo(36, "Devolucion Sobre Nota De Venta");
        public static readonly DocumentoModelo AjusteAlCosto = new DocumentoModelo(37, "Ajuste Al Costo");
        public static readonly DocumentoModelo CotizacionDelProveedor = new DocumentoModelo(38, "Cotización del Proveedor");

        public DocumentoModelo()
        {
        }

        public DocumentoModelo(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

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
            yield return CambioDelCliente;
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
            yield return CotizacionDelProveedor;
        }
    }
}

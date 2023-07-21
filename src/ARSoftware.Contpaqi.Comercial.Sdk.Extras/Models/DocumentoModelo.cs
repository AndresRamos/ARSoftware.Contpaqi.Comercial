using System;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable UnusedMember.Global

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

public class DocumentoModelo
{
    public static readonly DocumentoModelo Cotizacion = new(1, "Cotizacion");
    public static readonly DocumentoModelo Pedido = new(2, "Pedido");
    public static readonly DocumentoModelo Remision = new(3, "Remision");
    public static readonly DocumentoModelo Factura = new(4, "Factura");
    public static readonly DocumentoModelo DevolucionSobreVenta = new(5, "Devolucion Sobre Venta");
    public static readonly DocumentoModelo DevolucionDeRemision = new(6, "Devolucion De Remision");
    public static readonly DocumentoModelo NotaDeCredito = new(7, "Nota De Credito");
    public static readonly DocumentoModelo CambioDelCliente = new(8, "Cambio Del Cliente");
    public static readonly DocumentoModelo PagoDeCliente = new(9, "Pago Del Cliente");
    public static readonly DocumentoModelo ChequeRecibido = new(10, "Cheque Recibido");
    public static readonly DocumentoModelo HonorariosDelCliente = new(11, "Honorarios Del Cliente");
    public static readonly DocumentoModelo AbonoDelCliente = new(12, "Abono Del Cliente");
    public static readonly DocumentoModelo NotaDeCargoAlCliente = new(13, "Nota De Cargo Al Cliente");
    public static readonly DocumentoModelo DescuentoPorProntoPago = new(14, "Descuento Por Pronto Pago");
    public static readonly DocumentoModelo Pagare = new(15, "Pagare");
    public static readonly DocumentoModelo InteresMoratorio = new(16, "Interes Moratorio");
    public static readonly DocumentoModelo OrdenDeCompra = new(17, "Orden De Compra");
    public static readonly DocumentoModelo ConsignacionDelProveedor = new(18, "Consignacion Del Proveedor");
    public static readonly DocumentoModelo Compra = new(19, "Compra");
    public static readonly DocumentoModelo DevolucionSobreCompra = new(20, "Devolucion Sobre Compra");
    public static readonly DocumentoModelo DevolucionDeConsignacion = new(21, "Devolucion De Consignacion");
    public static readonly DocumentoModelo NotaDeCreditoDeProveedor = new(22, "Nota De Credito Del Proveedor");
    public static readonly DocumentoModelo PagoAlProveedor = new(23, "Pago Al proveedor");
    public static readonly DocumentoModelo ChequeEmitido = new(24, "Cheque Emitido");
    public static readonly DocumentoModelo HonorariosDelProveedor = new(25, "Honorarios Del Proveedor");
    public static readonly DocumentoModelo AbonoAlProveedor = new(26, "Abono Al Proveedor");
    public static readonly DocumentoModelo CargoDelProveedor = new(27, "Cargo Del Proveedor");
    public static readonly DocumentoModelo UtilidadCambiariaCliente = new(28, "Utilidad Cambiaria Cliente");
    public static readonly DocumentoModelo PerdidaCambiariaCliente = new(29, "Perdida Cambiaria Cliente");
    public static readonly DocumentoModelo UtilidadCambiariaProveedor = new(30, "Utilidad Cambiaria Proveedor");
    public static readonly DocumentoModelo PerdidaCambiariaProveedor = new(31, "Perdida Cambiaria Proveedor");
    public static readonly DocumentoModelo EntradaAlAlmacen = new(32, "Entrada Al Almacen");
    public static readonly DocumentoModelo SalidaDelAlmacen = new(33, "Salida Del Almacen");
    public static readonly DocumentoModelo Traspasos = new(34, "Traspasos");
    public static readonly DocumentoModelo NotaDeVenta = new(35, "Nota De Venta");
    public static readonly DocumentoModelo DevolucionSobreNotaDeVenta = new(36, "Devolucion Sobre Nota De Venta");
    public static readonly DocumentoModelo AjusteAlCosto = new(37, "Ajuste Al Costo");
    public static readonly DocumentoModelo CotizacionDelProveedor = new(38, "Cotización del Proveedor");

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

    public static List<DocumentoModelo> ToList()
    {
        return new List<DocumentoModelo>
        {
            Cotizacion,
            Pedido,
            Remision,
            Factura,
            DevolucionSobreVenta,
            DevolucionDeRemision,
            NotaDeCredito,
            CambioDelCliente,
            PagoDeCliente,
            ChequeRecibido,
            HonorariosDelCliente,
            AbonoDelCliente,
            NotaDeCargoAlCliente,
            DescuentoPorProntoPago,
            Pagare,
            InteresMoratorio,
            OrdenDeCompra,
            ConsignacionDelProveedor,
            Compra,
            DevolucionSobreCompra,
            DevolucionDeConsignacion,
            NotaDeCreditoDeProveedor,
            PagoAlProveedor,
            ChequeEmitido,
            HonorariosDelProveedor,
            AbonoAlProveedor,
            CargoDelProveedor,
            UtilidadCambiariaCliente,
            PerdidaCambiariaCliente,
            UtilidadCambiariaProveedor,
            PerdidaCambiariaProveedor,
            EntradaAlAlmacen,
            SalidaDelAlmacen,
            Traspasos,
            NotaDeVenta,
            DevolucionSobreNotaDeVenta,
            AjusteAlCosto,
            CotizacionDelProveedor
        };
    }
}
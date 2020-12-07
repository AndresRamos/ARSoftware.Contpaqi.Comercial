using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class ClienteProveedorHelper
    {
        public static tCteProv ToTCteProv(this ClienteProveedor clienteProveedor)
        {
            return new tCteProv
            {
                cCodigoCliente = clienteProveedor.Codigo,
                cRazonSocial = clienteProveedor.RazonSocial,
                cFechaAlta = clienteProveedor.FechaAlta.ToSdkString(),
                cRFC = clienteProveedor.Rfc,
                cCURP = clienteProveedor.Curp,
                cDenComercial = clienteProveedor.DenominacionComercial,
                cRepLegal = clienteProveedor.RepresentanteLegal,
                cNombreMoneda = clienteProveedor.Moneda.Id == Moneda.Ninguna.Id ? "" : clienteProveedor.Moneda.Nombre,
                cListaPreciosCliente = clienteProveedor.ListaPreciosCliente,
                cDescuentoMovto = clienteProveedor.DescuentoMovimiento,
                cBanVentaCredito = clienteProveedor.BanderaVentaCredito,
                cCodigoValorClasificacionCliente1 = clienteProveedor.ValorClasificacionCliente1.Id != 0 ? clienteProveedor.ValorClasificacionCliente1.Codigo : "",
                cCodigoValorClasificacionCliente2 = clienteProveedor.ValorClasificacionCliente2.Id != 0 ? clienteProveedor.ValorClasificacionCliente2.Codigo : "",
                cCodigoValorClasificacionCliente3 = clienteProveedor.ValorClasificacionCliente3.Id != 0 ? clienteProveedor.ValorClasificacionCliente3.Codigo : "",
                cCodigoValorClasificacionCliente4 = clienteProveedor.ValorClasificacionCliente4.Id != 0 ? clienteProveedor.ValorClasificacionCliente4.Codigo : "",
                cCodigoValorClasificacionCliente5 = clienteProveedor.ValorClasificacionCliente5.Id != 0 ? clienteProveedor.ValorClasificacionCliente5.Codigo : "",
                cCodigoValorClasificacionCliente6 = clienteProveedor.ValorClasificacionCliente6.Id != 0 ? clienteProveedor.ValorClasificacionCliente6.Codigo : "",
                cTipoCliente = (int) clienteProveedor.Tipo,
                cEstatus = (int) clienteProveedor.Estatus,
                cFechaBaja = clienteProveedor.FechaBaja.ToSdkString(),
                cFechaUltimaRevision = clienteProveedor.FechaUltimaRevision.ToSdkString(),
                cLimiteCreditoCliente = clienteProveedor.LimiteCreditoCliente,
                cDiasCreditoCliente = clienteProveedor.DiasCreditoCliente,
                cBanExcederCredito = clienteProveedor.BanderaExcederCredito,
                cDescuentoProntoPago = clienteProveedor.DescuentoProntoPago,
                cDiasProntoPago = clienteProveedor.DiasProntoPago,
                cInteresMoratorio = clienteProveedor.InteresMoratorio,
                cDiaPago = clienteProveedor.DiaPago,
                cDiasRevision = clienteProveedor.DiasRevision,
                cMensajeria = clienteProveedor.Mensajeria,
                cCuentaMensajeria = clienteProveedor.CuentaMensajeria,
                cDiasEmbarqueCliente = clienteProveedor.DiasEmbarqueCliente,
                cCodigoAlmacen = clienteProveedor.Almacen.Id != 0 ? clienteProveedor.Almacen.Codigo : "",
                cCodigoAgenteVenta = clienteProveedor.AgenteVenta.Id != 0 ? clienteProveedor.AgenteVenta.Codigo : "",
                cCodigoAgenteCobro = clienteProveedor.AgenteCobro.Id != 0 ? clienteProveedor.AgenteCobro.Codigo : "",
                cRestriccionAgente = clienteProveedor.RestriccionAgente,
                cImpuesto1 = clienteProveedor.Impuesto1,
                cImpuesto2 = clienteProveedor.Impuesto2,
                cImpuesto3 = clienteProveedor.Impuesto3,
                cRetencionCliente1 = clienteProveedor.RetencionCliente1,
                cRetencionCliente2 = clienteProveedor.RetencionCliente2,
                cCodigoValorClasificacionProveedor1 = clienteProveedor.ValorClasificacionProveedor1.Id != 0 ? clienteProveedor.ValorClasificacionProveedor1.Codigo : "",
                cCodigoValorClasificacionProveedor2 = clienteProveedor.ValorClasificacionProveedor2.Id != 0 ? clienteProveedor.ValorClasificacionProveedor2.Codigo : "",
                cCodigoValorClasificacionProveedor3 = clienteProveedor.ValorClasificacionProveedor3.Id != 0 ? clienteProveedor.ValorClasificacionProveedor3.Codigo : "",
                cCodigoValorClasificacionProveedor4 = clienteProveedor.ValorClasificacionProveedor4.Id != 0 ? clienteProveedor.ValorClasificacionProveedor4.Codigo : "",
                cCodigoValorClasificacionProveedor5 = clienteProveedor.ValorClasificacionProveedor5.Id != 0 ? clienteProveedor.ValorClasificacionProveedor5.Codigo : "",
                cCodigoValorClasificacionProveedor6 = clienteProveedor.ValorClasificacionProveedor6.Id != 0 ? clienteProveedor.ValorClasificacionProveedor6.Codigo : "",
                cLimiteCreditoProveedor = clienteProveedor.LimiteCreditoProveedor,
                cDiasCreditoProveedor = clienteProveedor.DiasCreditoProveedor,
                cTiempoEntrega = clienteProveedor.TiempoEntrega,
                cDiasEmbarqueProveedor = clienteProveedor.DiasEmbarqueProveedor,
                cImpuestoProveedor1 = clienteProveedor.ImpuestoProveedor1,
                cImpuestoProveedor2 = clienteProveedor.ImpuestoProveedor2,
                cImpuestoProveedor3 = clienteProveedor.ImpuestoProveedor3,
                cRetencionProveedor1 = clienteProveedor.RetencionProveedor1,
                cRetencionProveedor2 = clienteProveedor.RetencionProveedor2,
                cBanInteresMoratorio = clienteProveedor.BanderaInteresMoratorio,
                cTextoExtra1 = clienteProveedor.TextoExtra1,
                cTextoExtra2 = clienteProveedor.TextoExtra2,
                cTextoExtra3 = clienteProveedor.TextoExtra3,
                cImporteExtra1 = clienteProveedor.ImporteExtra1,
                cImporteExtra2 = clienteProveedor.ImporteExtra2,
                cImporteExtra3 = clienteProveedor.ImporteExtra3,
                cImporteExtra4 = clienteProveedor.ImporteExtra4
            };
        }
    }
}
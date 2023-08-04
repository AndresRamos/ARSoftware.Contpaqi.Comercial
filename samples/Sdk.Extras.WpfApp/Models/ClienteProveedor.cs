using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.WpfApp.Models;

public class ClienteProveedor : admClientes
{
    public ClienteProveedor()
    {
        Tipo = TipoCliente.ClienteProveedor;
        Estatus = Estatus.Activo;
        CIDMONEDA = 1;
        CIDMONEDA2 = 1;
        CFECHAALTA = DateTime.Today;
        CFECHABAJA = SdkDateTimeHelper.CreateDefaultSdkFecha();
        CFECHAULTIMAREVISION = SdkDateTimeHelper.CreateDefaultSdkFecha();
        CFECHAEXTRA = SdkDateTimeHelper.CreateDefaultSdkFecha();
        CLISTAPRECIOCLIENTE = 1;
        CIDCOMPLEM = -1;
        CIDADDENDA = -1;
    }

    public Agente AgenteCobro { get; set; } = new();
    public Agente AgenteVenta { get; set; } = new();
    public Almacen Almacen { get; set; } = new();

    public Estatus Estatus
    {
        get => EstatusHelper.ConvertFromSdkValue(CESTATUS);
        set => CESTATUS = EstatusHelper.ConvertToSdkValue(value);
    }

    public Moneda Moneda { get; set; } = MonedaEnum.PesoMexicano.ToMoneda();

    public TipoCliente Tipo
    {
        get => TipoClienteHelper.ConvertFromSdkValue(CTIPOCLIENTE);
        set => CTIPOCLIENTE = TipoClienteHelper.ConvertToSdkValue(value);
    }

    public ValorClasificacion ValorClasificacionCliente1 { get; set; } = new();
    public ValorClasificacion ValorClasificacionCliente2 { get; set; } = new();
    public ValorClasificacion ValorClasificacionCliente3 { get; set; } = new();
    public ValorClasificacion ValorClasificacionCliente4 { get; set; } = new();
    public ValorClasificacion ValorClasificacionCliente5 { get; set; } = new();
    public ValorClasificacion ValorClasificacionCliente6 { get; set; } = new();
    public ValorClasificacion ValorClasificacionProveedor1 { get; set; } = new();
    public ValorClasificacion ValorClasificacionProveedor2 { get; set; } = new();
    public ValorClasificacion ValorClasificacionProveedor3 { get; set; } = new();
    public ValorClasificacion ValorClasificacionProveedor4 { get; set; } = new();
    public ValorClasificacion ValorClasificacionProveedor5 { get; set; } = new();
    public ValorClasificacion ValorClasificacionProveedor6 { get; set; } = new();

    public bool Contains(string filtro)
    {
        return string.IsNullOrWhiteSpace(filtro) ||
               CIDCLIENTEPROVEEDOR.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CCODIGOCLIENTE.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CRAZONSOCIAL.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    public override string ToString()
    {
        return $"{CCODIGOCLIENTE} - {CRAZONSOCIAL}";
    }

    public tCteProv ToTCteProv()
    {
        return new tCteProv
        {
            cCodigoCliente = CCODIGOCLIENTE,
            cRazonSocial = CRAZONSOCIAL,
            cFechaAlta = CFECHAALTA.ToSdkFecha(),
            cRFC = CRFC,
            cCURP = CCURP,
            cDenComercial = CDENCOMERCIAL,
            cRepLegal = CREPLEGAL,
            cNombreMoneda = Moneda.Id == MonedaEnum.Ninguna.Value ? "" : Moneda.Nombre,
            cListaPreciosCliente = CLISTAPRECIOCLIENTE,
            cDescuentoMovto = CDESCUENTOMOVTO,
            cBanVentaCredito = CBANVENTACREDITO,
            cCodigoValorClasificacionCliente1 =
                ValorClasificacionCliente1.CIDCLASIFICACION != 0 ? ValorClasificacionCliente1.CCODIGOVALORCLASIFICACION : string.Empty,
            cCodigoValorClasificacionCliente2 =
                ValorClasificacionCliente2.CIDCLASIFICACION != 0 ? ValorClasificacionCliente2.CCODIGOVALORCLASIFICACION : string.Empty,
            cCodigoValorClasificacionCliente3 =
                ValorClasificacionCliente3.CIDCLASIFICACION != 0 ? ValorClasificacionCliente3.CCODIGOVALORCLASIFICACION : string.Empty,
            cCodigoValorClasificacionCliente4 =
                ValorClasificacionCliente4.CIDCLASIFICACION != 0 ? ValorClasificacionCliente4.CCODIGOVALORCLASIFICACION : string.Empty,
            cCodigoValorClasificacionCliente5 =
                ValorClasificacionCliente5.CIDCLASIFICACION != 0 ? ValorClasificacionCliente5.CCODIGOVALORCLASIFICACION : string.Empty,
            cCodigoValorClasificacionCliente6 =
                ValorClasificacionCliente6.CIDCLASIFICACION != 0 ? ValorClasificacionCliente6.CCODIGOVALORCLASIFICACION : string.Empty,
            cTipoCliente = TipoClienteHelper.ConvertToSdkValue(Tipo),
            cEstatus = EstatusHelper.ConvertToSdkValue(Estatus),
            cFechaBaja = CFECHABAJA.ToSdkFecha(),
            cFechaUltimaRevision = CFECHAULTIMAREVISION.ToSdkFecha(),
            cLimiteCreditoCliente = CLIMITECREDITOCLIENTE,
            cDiasCreditoCliente = CDIASCREDITOCLIENTE,
            cBanExcederCredito = CBANEXCEDERCREDITO,
            cDescuentoProntoPago = CDESCUENTOPRONTOPAGO,
            cDiasProntoPago = CDIASPRONTOPAGO,
            cInteresMoratorio = CINTERESMORATORIO,
            cDiaPago = CDIAPAGO,
            cDiasRevision = CDIASREVISION,
            cMensajeria = CMENSAJERIA,
            cCuentaMensajeria = CCUENTAMENSAJERIA,
            cDiasEmbarqueCliente = CDIASEMBARQUECLIENTE,
            cCodigoAlmacen = Almacen.CIDALMACEN != 0 ? Almacen.CCODIGOALMACEN : "",
            cCodigoAgenteVenta = AgenteVenta.CIDAGENTE != 0 ? AgenteVenta.CCODIGOAGENTE : "",
            cCodigoAgenteCobro = AgenteCobro.CIDAGENTE != 0 ? AgenteCobro.CCODIGOAGENTE : "",
            cRestriccionAgente = CRESTRICCIONAGENTE,
            cImpuesto1 = CIMPUESTO1,
            cImpuesto2 = CIMPUESTO2,
            cImpuesto3 = CIMPUESTO3,
            cRetencionCliente1 = CRETENCIONCLIENTE1,
            cRetencionCliente2 = CRETENCIONCLIENTE2,
            cCodigoValorClasificacionProveedor1 =
                ValorClasificacionProveedor1.CIDCLASIFICACION != 0
                    ? ValorClasificacionProveedor1.CCODIGOVALORCLASIFICACION
                    : string.Empty,
            cCodigoValorClasificacionProveedor2 =
                ValorClasificacionProveedor2.CIDCLASIFICACION != 0
                    ? ValorClasificacionProveedor2.CCODIGOVALORCLASIFICACION
                    : string.Empty,
            cCodigoValorClasificacionProveedor3 =
                ValorClasificacionProveedor3.CIDCLASIFICACION != 0
                    ? ValorClasificacionProveedor3.CCODIGOVALORCLASIFICACION
                    : string.Empty,
            cCodigoValorClasificacionProveedor4 =
                ValorClasificacionProveedor4.CIDCLASIFICACION != 0
                    ? ValorClasificacionProveedor4.CCODIGOVALORCLASIFICACION
                    : string.Empty,
            cCodigoValorClasificacionProveedor5 =
                ValorClasificacionProveedor5.CIDCLASIFICACION != 0
                    ? ValorClasificacionProveedor5.CCODIGOVALORCLASIFICACION
                    : string.Empty,
            cCodigoValorClasificacionProveedor6 =
                ValorClasificacionProveedor6.CIDCLASIFICACION != 0
                    ? ValorClasificacionProveedor6.CCODIGOVALORCLASIFICACION
                    : string.Empty,
            cLimiteCreditoProveedor = CLIMITECREDITOPROVEEDOR,
            cDiasCreditoProveedor = CDIASCREDITOPROVEEDOR,
            cTiempoEntrega = CTIEMPOENTREGA,
            cDiasEmbarqueProveedor = CDIASEMBARQUEPROVEEDOR,
            cImpuestoProveedor1 = CIMPUESTOPROVEEDOR1,
            cImpuestoProveedor2 = CIMPUESTOPROVEEDOR2,
            cImpuestoProveedor3 = CIMPUESTOPROVEEDOR3,
            cRetencionProveedor1 = CRETENCIONPROVEEDOR1,
            cRetencionProveedor2 = CRETENCIONPROVEEDOR2,
            cBanInteresMoratorio = CBANINTERESMORATORIO,
            cTextoExtra1 = CTEXTOEXTRA1,
            cTextoExtra2 = CTEXTOEXTRA2,
            cTextoExtra3 = CTEXTOEXTRA3,
            cImporteExtra1 = CIMPORTEEXTRA1,
            cImporteExtra2 = CIMPORTEEXTRA2,
            cImporteExtra3 = CIMPORTEEXTRA3,
            cImporteExtra4 = CIMPORTEEXTRA4
        };
    }
}

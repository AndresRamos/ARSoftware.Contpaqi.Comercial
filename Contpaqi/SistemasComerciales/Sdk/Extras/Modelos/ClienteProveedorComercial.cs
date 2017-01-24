namespace Contpaqi.SistemasComerciales.Sdk.Extras.Modelos
{
    public class ClienteProveedorComercial
    {
        public ClienteProveedorComercial()
        {
            ValorClasificacionCliente1 = new ValorClasificacionComercial();
            ValorClasificacionCliente2 = new ValorClasificacionComercial();
            ValorClasificacionCliente3 = new ValorClasificacionComercial();
            ValorClasificacionCliente4 = new ValorClasificacionComercial();
            ValorClasificacionCliente5 = new ValorClasificacionComercial();
            ValorClasificacionCliente6 = new ValorClasificacionComercial();
            ValorClasificacionProveedor1 = new ValorClasificacionComercial();
            ValorClasificacionProveedor2 = new ValorClasificacionComercial();
            ValorClasificacionProveedor3 = new ValorClasificacionComercial();
            ValorClasificacionProveedor4 = new ValorClasificacionComercial();
            ValorClasificacionProveedor5 = new ValorClasificacionComercial();
            ValorClasificacionProveedor6 = new ValorClasificacionComercial();
        }

        // Propiedades tCteProv
        public string CodigoCliente { get; set; }

        public string RazonSocial { get; set; }

        public string FechaAlta { get; set; }

        public string RFC { get; set; }

        public string CURP { get; set; }

        public string DenominacionComercial { get; set; }

        public string RepresentanteLegal { get; set; }

        public string NombreMoneda { get; set; }

        public int ListaPreciosCliente { get; set; }

        public double DescuentoMovimiento { get; set; }

        public int BanderaVentaCredito { get; set; }

        public string CodigoValorClasificacionCliente1 { get; set; }

        public string CodigoValorClasificacionCliente2 { get; set; }

        public string CodigoValorClasificacionCliente3 { get; set; }

        public string CodigoValorClasificacionCliente4 { get; set; }

        public string CodigoValorClasificacionCliente5 { get; set; }

        public string CodigoValorClasificacionCliente6 { get; set; }

        public int TipoCliente { get; set; }

        public int Estatus { get; set; }

        public string FechaBaja { get; set; }

        public string FechaUltimaRevision { get; set; }

        public double LimiteCreditoCliente { get; set; }

        public int DiasCreditoCliente { get; set; }

        public int BanderaExcederCredito { get; set; }

        public double DescuentoProntoPago { get; set; }

        public int DiasProntoPago { get; set; }

        public double InteresMoratorio { get; set; }

        public int DiaPago { get; set; }

        public int DiasRevision { get; set; }

        public string Mensajeria { get; set; }

        public string CuentaMensajeria { get; set; }

        public int DiasEmbarqueCliente { get; set; }

        public string CodigoAlmacen { get; set; }

        public string CodigoAgenteVenta { get; set; }

        public string CodigoAgenteCobro { get; set; }

        public int RestriccionAgente { get; set; }

        public double Impuesto1 { get; set; }

        public double Impuesto2 { get; set; }

        public double Impuesto3 { get; set; }

        public double RetencionCliente1 { get; set; }

        public double RetencionCliente2 { get; set; }

        public string CodigoValorClasificacionProveedor1 { get; set; }

        public string CodigoValorClasificacionProveedor2 { get; set; }

        public string CodigoValorClasificacionProveedor3 { get; set; }

        public string CodigoValorClasificacionProveedor4 { get; set; }

        public string CodigoValorClasificacionProveedor5 { get; set; }

        public string CodigoValorClasificacionProveedor6 { get; set; }

        public double LimiteCreditoProveedor { get; set; }

        public int DiasCreditoProveedor { get; set; }

        public int TiempoEntrega { get; set; }

        public int DiasEmbarqueProveedor { get; set; }

        public double ImpuestoProveedor1 { get; set; }

        public double ImpuestoProveedor2 { get; set; }

        public double ImpuestoProveedor3 { get; set; }

        public double RetencionProveedor1 { get; set; }

        public double RetencionProveedor2 { get; set; }

        public int BanderaInteresMoratorio { get; set; }

        public string TextoExtra1 { get; set; }

        public string TextoExtra2 { get; set; }

        public string TextoExtra3 { get; set; }

        public double ImporteExtra1 { get; set; }

        public double ImporteExtra2 { get; set; }

        public double ImporteExtra3 { get; set; }

        public double ImporteExtra4 { get; set; }

        // Propiedades Extras
        public int IdCliente { get; set; }

        public int IdValorClasificacionCliente1 { get; set; }

        public int IdValorClasificacionCliente2 { get; set; }

        public int IdValorClasificacionCliente3 { get; set; }

        public int IdValorClasificacionCliente4 { get; set; }

        public int IdValorClasificacionCliente5 { get; set; }

        public int IdValorClasificacionCliente6 { get; set; }

        public int IdValorClasificacionProveedor1 { get; set; }

        public int IdValorClasificacionProveedor2 { get; set; }

        public int IdValorClasificacionProveedor3 { get; set; }

        public int IdValorClasificacionProveedor4 { get; set; }

        public int IdValorClasificacionProveedor5 { get; set; }

        public int IdValorClasificacionProveedor6 { get; set; }

        public ValorClasificacionComercial ValorClasificacionCliente1 { get; set; }

        public ValorClasificacionComercial ValorClasificacionCliente2 { get; set; }

        public ValorClasificacionComercial ValorClasificacionCliente3 { get; set; }

        public ValorClasificacionComercial ValorClasificacionCliente4 { get; set; }

        public ValorClasificacionComercial ValorClasificacionCliente5 { get; set; }

        public ValorClasificacionComercial ValorClasificacionCliente6 { get; set; }

        public ValorClasificacionComercial ValorClasificacionProveedor1 { get; set; }

        public ValorClasificacionComercial ValorClasificacionProveedor2 { get; set; }

        public ValorClasificacionComercial ValorClasificacionProveedor3 { get; set; }

        public ValorClasificacionComercial ValorClasificacionProveedor4 { get; set; }

        public ValorClasificacionComercial ValorClasificacionProveedor5 { get; set; }

        public ValorClasificacionComercial ValorClasificacionProveedor6 { get; set; }
    }
}
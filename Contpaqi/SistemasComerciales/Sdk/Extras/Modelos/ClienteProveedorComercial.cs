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
        public string CodigoCliente;
        public string RazonSocial;
        public string FechaAlta;
        public string RFC;
        public string CURP;
        public string DenominacionComercial;
        public string RepresentanteLegal;
        public string NombreMoneda;
        public int ListaPreciosCliente;
        public double DescuentoMovimiento;
        public int BanderaVentaCredito;
        public string CodigoValorClasificacionCliente1;
        public string CodigoValorClasificacionCliente2;
        public string CodigoValorClasificacionCliente3;
        public string CodigoValorClasificacionCliente4;
        public string CodigoValorClasificacionCliente5;
        public string CodigoValorClasificacionCliente6;
        public int TipoCliente;
        public int Estatus;
        public string FechaBaja;
        public string FechaUltimaRevision;
        public double LimiteCreditoCliente;
        public int DiasCreditoCliente;
        public int BanderaExcederCredito;
        public double DescuentoProntoPago;
        public int DiasProntoPago;
        public double InteresMoratorio;
        public int DiaPago;
        public int DiasRevision;
        public string Mensajeria;
        public string CuentaMensajeria;
        public int DiasEmbarqueCliente;
        public string CodigoAlmacen;
        public string CodigoAgenteVenta;
        public string CodigoAgenteCobro;
        public int RestriccionAgente;
        public double Impuesto1;
        public double Impuesto2;
        public double Impuesto3;
        public double RetencionCliente1;
        public double RetencionCliente2;
        public string CodigoValorClasificacionProveedor1;
        public string CodigoValorClasificacionProveedor2;
        public string CodigoValorClasificacionProveedor3;
        public string CodigoValorClasificacionProveedor4;
        public string CodigoValorClasificacionProveedor5;
        public string CodigoValorClasificacionProveedor6;
        public double LimiteCreditoProveedor;
        public int DiasCreditoProveedor;
        public int TiempoEntrega;
        public int DiasEmbarqueProveedor;
        public double ImpuestoProveedor1;
        public double ImpuestoProveedor2;
        public double ImpuestoProveedor3;
        public double RetencionProveedor1;
        public double RetencionProveedor2;
        public int BanderaInteresMoratorio;
        public string TextoExtra1;
        public string TextoExtra2;
        public string TextoExtra3;
        public double ImporteExtra1;
        public double ImporteExtra2;
        public double ImporteExtra3;
        public double ImporteExtra4;
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

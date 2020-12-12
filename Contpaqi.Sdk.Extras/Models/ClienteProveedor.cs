using System;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Models
{
    public class ClienteProveedor : IClienteProveedor
    {
        public ClienteProveedor()
        {
            FechaAlta = DateTime.Today;
            Estatus = EstatusActivoEnum.Activo;
            IdMoneda = 1;
            Moneda = Moneda.PesoMexicano;
            ValorClasificacionCliente1 = new ValorClasificacion();
            ValorClasificacionCliente2 = new ValorClasificacion();
            ValorClasificacionCliente3 = new ValorClasificacion();
            ValorClasificacionCliente4 = new ValorClasificacion();
            ValorClasificacionCliente5 = new ValorClasificacion();
            ValorClasificacionCliente6 = new ValorClasificacion();
            ValorClasificacionProveedor1 = new ValorClasificacion();
            ValorClasificacionProveedor2 = new ValorClasificacion();
            ValorClasificacionProveedor3 = new ValorClasificacion();
            ValorClasificacionProveedor4 = new ValorClasificacion();
            ValorClasificacionProveedor5 = new ValorClasificacion();
            ValorClasificacionProveedor6 = new ValorClasificacion();

            FechaBaja = new DateTime(1899, 12, 30);
            FechaUltimaRevision = new DateTime(1899, 12, 30);
        }

        // Propiedades tCteProv
        public string Codigo { get; set; }

        public string RazonSocial { get; set; }

        public DateTime FechaAlta { get; set; }

        public string Rfc { get; set; }

        public string Curp { get; set; }

        public string DenominacionComercial { get; set; }

        public string RepresentanteLegal { get; set; }

        public int ListaPreciosCliente { get; set; }

        public double DescuentoMovimiento { get; set; }

        public int BanderaVentaCredito { get; set; }

        public TipoClienteEnum Tipo { get; set; }

        public EstatusActivoEnum Estatus { get; set; }

        public DateTime FechaBaja { get; set; }

        public DateTime FechaUltimaRevision { get; set; }

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

        public int IdAlmacen { get; set; }

        public int IdAgenteVenta { get; set; }

        public int IdAgenteCobro { get; set; }

        public int RestriccionAgente { get; set; }

        public double Impuesto1 { get; set; }

        public double Impuesto2 { get; set; }

        public double Impuesto3 { get; set; }

        public double RetencionCliente1 { get; set; }

        public double RetencionCliente2 { get; set; }

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
        public int Id { get; set; }

        public string NombreLargo { get; set; }

        public int IdMoneda { get; set; }

        public Moneda Moneda { get; set; }

        public string Email1 { get; set; }

        public string Email2 { get; set; }

        public string Email3 { get; set; }

        public string FormaPago { get; set; }

        public string NumeroCuentaPago { get; set; }

        public string UsoCfdi { get; set; }

        public Almacen Almacen { get; set; }

        public Agente AgenteVenta { get; set; }

        public double ComisionVenta { get; set; }

        public Agente AgenteCobro { get; set; }

        public double ComisionCobro { get; set; }

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

        public ValorClasificacion ValorClasificacionCliente1 { get; set; }

        public ValorClasificacion ValorClasificacionCliente2 { get; set; }

        public ValorClasificacion ValorClasificacionCliente3 { get; set; }

        public ValorClasificacion ValorClasificacionCliente4 { get; set; }

        public ValorClasificacion ValorClasificacionCliente5 { get; set; }

        public ValorClasificacion ValorClasificacionCliente6 { get; set; }

        public ValorClasificacion ValorClasificacionProveedor1 { get; set; }

        public ValorClasificacion ValorClasificacionProveedor2 { get; set; }

        public ValorClasificacion ValorClasificacionProveedor3 { get; set; }

        public ValorClasificacion ValorClasificacionProveedor4 { get; set; }

        public ValorClasificacion ValorClasificacionProveedor5 { get; set; }

        public ValorClasificacion ValorClasificacionProveedor6 { get; set; }

        public override string ToString()
        {
            return $"{Codigo} - {RazonSocial}";
        }
    }
}
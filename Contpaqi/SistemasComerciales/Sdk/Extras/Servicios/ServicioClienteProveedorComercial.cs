using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;
using System.Collections.Generic;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioClienteProveedorComercial
    {
        private readonly ServicioErrorComercial _errorComercialServicio;
        private readonly ISistemasComercialesSdk _sdk;
        private readonly ServicioValorClasificacionComercial _servicioValorClasificacionComercial;

        public ServicioClienteProveedorComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _errorComercialServicio = new ServicioErrorComercial(sdk);
            _servicioValorClasificacionComercial = new ServicioValorClasificacionComercial(sdk);
        }

        public ClienteProveedorComercial BuscarClienteProveedor(int idCliente)
        {
            return _sdk.fBuscaIdCteProv(idCliente) == 0 ? LeerDatosClienteProveedorActual() : null;
        }

        public ClienteProveedorComercial BuscarClienteProveedor(string codigoCliente)
        {
            return _sdk.fBuscaCteProv(codigoCliente) == 0 ? LeerDatosClienteProveedorActual() : null;
        }

        public List<ClienteProveedorComercial> TraerClientesProveedores(int tipoCliente)
        {
            List<ClienteProveedorComercial> clientesList = new List<ClienteProveedorComercial>();
            _errorComercialServicio.ResultadoSdk = _sdk.fPosPrimerCteProv();
            StringBuilder tipoDeCliente = new StringBuilder(7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7);
            if (tipoDeCliente.ToString() == tipoCliente.ToString())
            {
                clientesList.Add(LeerDatosClienteProveedorActual());
            }
            while (_sdk.fPosSiguienteCteProv() == 0)
            {
                _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7);
                if (tipoDeCliente.ToString() == tipoCliente.ToString())
                {
                    clientesList.Add(LeerDatosClienteProveedorActual());
                }
                if (_sdk.fPosEOFCteProv() == 1)
                {
                    break;
                }
            };
            return clientesList;
        }

        private ClienteProveedorComercial LeerDatosClienteProveedorActual()
        {
            StringBuilder codigo = new StringBuilder(Constantes.kLongCodigo);
            StringBuilder razonSocial = new StringBuilder(Constantes.kLongNombre);
            StringBuilder fechaAlta = new StringBuilder(9);
            StringBuilder rfc = new StringBuilder(Constantes.kLongRFC);
            StringBuilder curp = new StringBuilder(21);
            StringBuilder denominacionComercial = new StringBuilder(51);
            StringBuilder representanteLegal = new StringBuilder(51);
            StringBuilder nombreMoneda = new StringBuilder(12);
            StringBuilder listaPreciosCliente = new StringBuilder(7);
            StringBuilder descuentoMovimiento = new StringBuilder(9);
            StringBuilder banderaVentaCredito = new StringBuilder(7);
            StringBuilder idValorClasificacionCliente1 = new StringBuilder(12);
            StringBuilder idValorClasificacionCliente2 = new StringBuilder(12);
            StringBuilder idValorClasificacionCliente3 = new StringBuilder(12);
            StringBuilder idValorClasificacionCliente4 = new StringBuilder(12);
            StringBuilder idValorClasificacionCliente5 = new StringBuilder(12);
            StringBuilder idValorClasificacionCliente6 = new StringBuilder(12);
            StringBuilder tipoCliente = new StringBuilder(7);
            StringBuilder estatus = new StringBuilder(7);
            StringBuilder fechaBaja = new StringBuilder(9);
            StringBuilder fechaUltimaRevision = new StringBuilder(9);
            StringBuilder limiteCreditoCliente = new StringBuilder(9);
            StringBuilder diasCreditoCliente = new StringBuilder(12);
            StringBuilder banderaExcederCredito = new StringBuilder(7);
            StringBuilder descuentoProntoPago = new StringBuilder(9);
            StringBuilder diasProntoPago = new StringBuilder(12);
            StringBuilder interesMoratorio = new StringBuilder(9);
            StringBuilder diaPago = new StringBuilder(7);
            StringBuilder diasRevision = new StringBuilder(7);
            StringBuilder mensajeria = new StringBuilder(21);
            StringBuilder cuentaMensajeria = new StringBuilder(61);
            StringBuilder diasEmbarqueCliente = new StringBuilder(7);
            StringBuilder codigoAlmacen = new StringBuilder(12);
            StringBuilder codigoAgenteVenta = new StringBuilder(12);
            StringBuilder CodigoAgenteCobro = new StringBuilder(12);
            StringBuilder restriccionAgente = new StringBuilder(7);
            StringBuilder impuesto1 = new StringBuilder(9);
            StringBuilder impuesto2 = new StringBuilder(9);
            StringBuilder impuesto3 = new StringBuilder(9);
            StringBuilder retencionCliente1 = new StringBuilder(9);
            StringBuilder retencionCliente2 = new StringBuilder(9);
            StringBuilder idValorClasificacionProveedor1 = new StringBuilder(12);
            StringBuilder idValorClasificacionProveedor2 = new StringBuilder(12);
            StringBuilder idValorClasificacionProveedor3 = new StringBuilder(12);
            StringBuilder idValorClasificacionProveedor4 = new StringBuilder(12);
            StringBuilder idValorClasificacionProveedor5 = new StringBuilder(12);
            StringBuilder idValorClasificacionProveedor6 = new StringBuilder(12);
            StringBuilder limiteCreditoProveedor = new StringBuilder(9);
            StringBuilder diasCreditoProveedor = new StringBuilder(12);
            StringBuilder tiempoEntrega = new StringBuilder(12);
            StringBuilder diasEmbarqueProveedor = new StringBuilder(7);
            StringBuilder impuestoProveedor1 = new StringBuilder(9);
            StringBuilder impuestoProveedor2 = new StringBuilder(9);
            StringBuilder impuestoProveedor3 = new StringBuilder(9);
            StringBuilder retencionProveedor1 = new StringBuilder(9);
            StringBuilder retencionProveedor2 = new StringBuilder(9);
            StringBuilder banderaInteresMoratorio = new StringBuilder(7);
            StringBuilder textoExtra1 = new StringBuilder(51);
            StringBuilder textoExtra2 = new StringBuilder(51);
            StringBuilder textoExtra3 = new StringBuilder(51);
            StringBuilder importeExtra1 = new StringBuilder(9);
            StringBuilder importeExtra2 = new StringBuilder(9);
            StringBuilder importeExtra3 = new StringBuilder(9);
            StringBuilder importeExtra4 = new StringBuilder(9);
            StringBuilder id = new StringBuilder(12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CCODIGOCLIENTE", codigo, Constantes.kLongCodigo);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CRAZONSOCIAL", razonSocial, Constantes.kLongNombre);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CFECHAALTA", fechaAlta, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CRFC", rfc, Constantes.kLongRFC);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CCURP", curp, 21);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CDENCOMERCIAL", denominacionComercial, 51);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CREPLEGAL", representanteLegal, 51);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDMONEDA", nombreMoneda, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CLISTAPRECIOCLIENTE", listaPreciosCliente, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CDESCUENTOMOVTO", descuentoMovimiento, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CBANVENTACREDITO", banderaVentaCredito, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDVALORCLASIFCLIENTE1", idValorClasificacionCliente1, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDVALORCLASIFCLIENTE2", idValorClasificacionCliente2, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDVALORCLASIFCLIENTE3", idValorClasificacionCliente3, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDVALORCLASIFCLIENTE4", idValorClasificacionCliente4, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDVALORCLASIFCLIENTE5", idValorClasificacionCliente5, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDVALORCLASIFCLIENTE6", idValorClasificacionCliente6, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoCliente, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CESTATUS", estatus, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CFECHABAJA", fechaBaja, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CFECHAULTIMAREVISION", fechaUltimaRevision, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CLIMITECREDITOCLIENTE", limiteCreditoCliente, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CDIASCREDITOCLIENTE", diasCreditoCliente, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CBANEXCEDERCREDITO", banderaExcederCredito, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CDESCUENTOPRONTOPAGO", descuentoProntoPago, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CDIASPRONTOPAGO", diasProntoPago, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CINTERESMORATORIO", interesMoratorio, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CDIAPAGO", diaPago, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CDIASREVISION", diasRevision, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CMENSAJERIA", mensajeria, 21);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CCUENTAMENSAJERIA", cuentaMensajeria, 61);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CDIASEMBARQUECLIENTE", diasEmbarqueCliente, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDALMACEN", codigoAlmacen, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDAGENTEVENTA", codigoAgenteVenta, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDAGENTECOBRO", CodigoAgenteCobro, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CRESTRICCIONAGENTE", restriccionAgente, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIMPUESTO1", impuesto1, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIMPUESTO2", impuesto2, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIMPUESTO3", impuesto3, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CRETENCIONCLIENTE1", retencionCliente1, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CRETENCIONCLIENTE2", retencionCliente2, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDVALORCLASIFPROVEEDOR1", idValorClasificacionProveedor1, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDVALORCLASIFPROVEEDOR2", idValorClasificacionProveedor2, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDVALORCLASIFPROVEEDOR3", idValorClasificacionProveedor3, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDVALORCLASIFPROVEEDOR4", idValorClasificacionProveedor4, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDVALORCLASIFPROVEEDOR5", idValorClasificacionProveedor5, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDVALORCLASIFPROVEEDOR6", idValorClasificacionProveedor6, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CLIMITECREDITOPROVEEDOR", limiteCreditoProveedor, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CDIASCREDITOPROVEEDOR", diasCreditoProveedor, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CTIEMPOENTREGA", tiempoEntrega, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CDIASEMBARQUEPROVEEDOR", diasEmbarqueProveedor, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIMPUESTOPROVEEDOR1", impuestoProveedor1, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIMPUESTOPROVEEDOR2", impuestoProveedor2, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIMPUESTOPROVEEDOR3", impuestoProveedor3, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CRETENCIONPROVEEDOR1", retencionProveedor1, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CRETENCIONPROVEEDOR2", retencionProveedor2, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CBANINTERESMORATORIO", banderaInteresMoratorio, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CTEXTOEXTRA1", textoExtra1, 51);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CTEXTOEXTRA2", textoExtra2, 51);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CTEXTOEXTRA3", textoExtra3, 51);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIMPORTEEXTRA1", importeExtra1, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIMPORTEEXTRA2", importeExtra2, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIMPORTEEXTRA3", importeExtra3, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIMPORTEEXTRA4", importeExtra4, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoCteProv("CIDCLIENTEPROVEEDOR", id, 12);
            ClienteProveedorComercial clienteProveedor = new ClienteProveedorComercial();
            clienteProveedor.CodigoCliente = codigo.ToString();
            clienteProveedor.RazonSocial = razonSocial.ToString();
            clienteProveedor.FechaAlta = fechaAlta.ToString();
            clienteProveedor.RFC = rfc.ToString();
            clienteProveedor.CURP = curp.ToString();
            clienteProveedor.DenominacionComercial = denominacionComercial.ToString();
            clienteProveedor.RepresentanteLegal = representanteLegal.ToString();
            clienteProveedor.NombreMoneda = nombreMoneda.ToString();
            clienteProveedor.ListaPreciosCliente = int.Parse(listaPreciosCliente.ToString());
            clienteProveedor.DescuentoMovimiento = double.Parse(descuentoMovimiento.ToString());
            clienteProveedor.BanderaVentaCredito = int.TryParse(banderaVentaCredito.ToString(), out int _banderaVentaCredito) ? _banderaVentaCredito : 0;
            clienteProveedor.IdValorClasificacionCliente1 = int.TryParse(idValorClasificacionCliente1.ToString(), out int _idValorClasificacionCliente1) ? _idValorClasificacionCliente1 : 0;
            clienteProveedor.IdValorClasificacionCliente2 = int.TryParse(idValorClasificacionCliente2.ToString(), out int _idValorClasificacionCliente2) ? _idValorClasificacionCliente2 : 0;
            clienteProveedor.IdValorClasificacionCliente3 = int.TryParse(idValorClasificacionCliente3.ToString(), out int _idValorClasificacionCliente3) ? _idValorClasificacionCliente3 : 0;
            clienteProveedor.IdValorClasificacionCliente4 = int.TryParse(idValorClasificacionCliente4.ToString(), out int _idValorClasificacionCliente4) ? _idValorClasificacionCliente4 : 0;
            clienteProveedor.IdValorClasificacionCliente5 = int.TryParse(idValorClasificacionCliente5.ToString(), out int _idValorClasificacionCliente5) ? _idValorClasificacionCliente5 : 0;
            clienteProveedor.IdValorClasificacionCliente6 = int.TryParse(idValorClasificacionCliente6.ToString(), out int _idValorClasificacionCliente6) ? _idValorClasificacionCliente6 : 0;
            clienteProveedor.TipoCliente = int.Parse(tipoCliente.ToString());
            clienteProveedor.Estatus = int.Parse(estatus.ToString());
            clienteProveedor.FechaBaja = fechaBaja.ToString();
            clienteProveedor.FechaUltimaRevision = fechaUltimaRevision.ToString();
            clienteProveedor.LimiteCreditoCliente = double.Parse(limiteCreditoCliente.ToString());
            clienteProveedor.DiasCreditoCliente = int.TryParse(diasCreditoCliente.ToString(), out int _diasCreditoCliente) ? _diasCreditoCliente : 0;
            clienteProveedor.BanderaExcederCredito = int.TryParse(banderaExcederCredito.ToString(), out int _banderaExcederCredito) ? _banderaExcederCredito : 0;
            clienteProveedor.DescuentoProntoPago = double.Parse(descuentoProntoPago.ToString());
            clienteProveedor.DiasProntoPago = int.TryParse(diasProntoPago.ToString(), out int _diasProntoPago) ? _diasProntoPago : 0;
            clienteProveedor.InteresMoratorio = double.Parse(interesMoratorio.ToString());
            clienteProveedor.DiaPago = int.Parse(diaPago.ToString());
            clienteProveedor.DiasRevision = int.Parse(diasRevision.ToString());
            clienteProveedor.Mensajeria = mensajeria.ToString();
            clienteProveedor.CuentaMensajeria = cuentaMensajeria.ToString();
            clienteProveedor.DiasEmbarqueCliente = int.Parse(diasEmbarqueCliente.ToString());
            clienteProveedor.CodigoAlmacen = codigoAlmacen.ToString();
            clienteProveedor.CodigoAgenteVenta = codigoAgenteVenta.ToString();
            clienteProveedor.CodigoAgenteCobro = CodigoAgenteCobro.ToString();
            clienteProveedor.RestriccionAgente = int.TryParse(restriccionAgente.ToString(), out int _restriccionAgente) ? _restriccionAgente : 0;
            clienteProveedor.Impuesto1 = double.Parse(impuesto1.ToString());
            clienteProveedor.Impuesto2 = double.Parse(impuesto2.ToString());
            clienteProveedor.Impuesto3 = double.Parse(impuesto3.ToString());
            clienteProveedor.RetencionCliente1 = double.Parse(retencionCliente1.ToString());
            clienteProveedor.RetencionCliente2 = double.Parse(retencionCliente2.ToString());
            clienteProveedor.IdValorClasificacionProveedor1 = int.TryParse(idValorClasificacionProveedor1.ToString(), out int _idValorClasificacionProveedor1) ? _idValorClasificacionProveedor1 : 0;
            clienteProveedor.IdValorClasificacionProveedor2 = int.TryParse(idValorClasificacionProveedor2.ToString(), out int _idValorClasificacionProveedor2) ? _idValorClasificacionProveedor2 : 0;
            clienteProveedor.IdValorClasificacionProveedor3 = int.TryParse(idValorClasificacionProveedor3.ToString(), out int _idValorClasificacionProveedor3) ? _idValorClasificacionProveedor3 : 0;
            clienteProveedor.IdValorClasificacionProveedor4 = int.TryParse(idValorClasificacionProveedor4.ToString(), out int _idValorClasificacionProveedor4) ? _idValorClasificacionProveedor4 : 0;
            clienteProveedor.IdValorClasificacionProveedor5 = int.TryParse(idValorClasificacionProveedor5.ToString(), out int _idValorClasificacionProveedor5) ? _idValorClasificacionProveedor5 : 0;
            clienteProveedor.IdValorClasificacionProveedor6 = int.TryParse(idValorClasificacionProveedor6.ToString(), out int _idValorClasificacionProveedor6) ? _idValorClasificacionProveedor6 : 0;
            clienteProveedor.LimiteCreditoProveedor = double.Parse(limiteCreditoProveedor.ToString());
            clienteProveedor.DiasCreditoProveedor = int.TryParse(diasCreditoProveedor.ToString(), out int _diasCreditoProveedor) ? _diasCreditoProveedor : 0;
            clienteProveedor.TiempoEntrega = int.TryParse(tiempoEntrega.ToString(), out int _tiempoEntrega) ? _tiempoEntrega : 0;
            clienteProveedor.DiasEmbarqueProveedor = int.Parse(diasEmbarqueProveedor.ToString());
            clienteProveedor.ImpuestoProveedor1 = double.Parse(impuestoProveedor1.ToString());
            clienteProveedor.ImpuestoProveedor2 = double.Parse(impuestoProveedor2.ToString());
            clienteProveedor.ImpuestoProveedor3 = double.Parse(impuestoProveedor3.ToString());
            clienteProveedor.RetencionProveedor1 = double.Parse(retencionProveedor1.ToString());
            clienteProveedor.RetencionProveedor2 = double.Parse(retencionProveedor2.ToString());
            clienteProveedor.BanderaInteresMoratorio = int.TryParse(banderaInteresMoratorio.ToString(), out int _banderaInteresMoratorio) ? _banderaInteresMoratorio : 0;
            clienteProveedor.TextoExtra1 = textoExtra1.ToString();
            clienteProveedor.TextoExtra2 = textoExtra2.ToString();
            clienteProveedor.TextoExtra3 = textoExtra3.ToString();
            clienteProveedor.ImporteExtra1 = double.Parse(importeExtra1.ToString());
            clienteProveedor.ImporteExtra2 = double.Parse(importeExtra2.ToString());
            clienteProveedor.ImporteExtra3 = double.Parse(importeExtra3.ToString());
            clienteProveedor.ImporteExtra4 = double.Parse(importeExtra4.ToString());
            clienteProveedor.IdCliente = int.Parse(id.ToString());
            clienteProveedor.ValorClasificacionCliente1 = _servicioValorClasificacionComercial.BuscaValorClasificacion(clienteProveedor.IdValorClasificacionCliente1);
            clienteProveedor.ValorClasificacionCliente2 = _servicioValorClasificacionComercial.BuscaValorClasificacion(clienteProveedor.IdValorClasificacionCliente2);
            clienteProveedor.ValorClasificacionCliente3 = _servicioValorClasificacionComercial.BuscaValorClasificacion(clienteProveedor.IdValorClasificacionCliente3);
            clienteProveedor.ValorClasificacionCliente4 = _servicioValorClasificacionComercial.BuscaValorClasificacion(clienteProveedor.IdValorClasificacionCliente4);
            clienteProveedor.ValorClasificacionCliente5 = _servicioValorClasificacionComercial.BuscaValorClasificacion(clienteProveedor.IdValorClasificacionCliente5);
            clienteProveedor.ValorClasificacionCliente6 = _servicioValorClasificacionComercial.BuscaValorClasificacion(clienteProveedor.IdValorClasificacionCliente6);
            clienteProveedor.ValorClasificacionProveedor1 = _servicioValorClasificacionComercial.BuscaValorClasificacion(clienteProveedor.IdValorClasificacionProveedor1);
            clienteProveedor.ValorClasificacionProveedor2 = _servicioValorClasificacionComercial.BuscaValorClasificacion(clienteProveedor.IdValorClasificacionProveedor2);
            clienteProveedor.ValorClasificacionProveedor3 = _servicioValorClasificacionComercial.BuscaValorClasificacion(clienteProveedor.IdValorClasificacionProveedor3);
            clienteProveedor.ValorClasificacionProveedor4 = _servicioValorClasificacionComercial.BuscaValorClasificacion(clienteProveedor.IdValorClasificacionProveedor4);
            clienteProveedor.ValorClasificacionProveedor5 = _servicioValorClasificacionComercial.BuscaValorClasificacion(clienteProveedor.IdValorClasificacionProveedor5);
            clienteProveedor.ValorClasificacionProveedor6 = _servicioValorClasificacionComercial.BuscaValorClasificacion(clienteProveedor.IdValorClasificacionProveedor6);
            clienteProveedor.CodigoValorClasificacionCliente1 = clienteProveedor.ValorClasificacionCliente1.CodigoValorClasificacion;
            clienteProveedor.CodigoValorClasificacionCliente2 = clienteProveedor.ValorClasificacionCliente2.CodigoValorClasificacion;
            clienteProveedor.CodigoValorClasificacionCliente3 = clienteProveedor.ValorClasificacionCliente3.CodigoValorClasificacion;
            clienteProveedor.CodigoValorClasificacionCliente4 = clienteProveedor.ValorClasificacionCliente4.CodigoValorClasificacion;
            clienteProveedor.CodigoValorClasificacionCliente5 = clienteProveedor.ValorClasificacionCliente5.CodigoValorClasificacion;
            clienteProveedor.CodigoValorClasificacionCliente6 = clienteProveedor.ValorClasificacionCliente6.CodigoValorClasificacion;
            clienteProveedor.CodigoValorClasificacionProveedor1 = clienteProveedor.ValorClasificacionProveedor1.CodigoValorClasificacion;
            clienteProveedor.CodigoValorClasificacionProveedor2 = clienteProveedor.ValorClasificacionProveedor2.CodigoValorClasificacion;
            clienteProveedor.CodigoValorClasificacionProveedor3 = clienteProveedor.ValorClasificacionProveedor3.CodigoValorClasificacion;
            clienteProveedor.CodigoValorClasificacionProveedor4 = clienteProveedor.ValorClasificacionProveedor4.CodigoValorClasificacion;
            clienteProveedor.CodigoValorClasificacionProveedor5 = clienteProveedor.ValorClasificacionProveedor5.CodigoValorClasificacion;
            clienteProveedor.CodigoValorClasificacionProveedor6 = clienteProveedor.ValorClasificacionProveedor6.CodigoValorClasificacion;
            return clienteProveedor;
        }
    }
}
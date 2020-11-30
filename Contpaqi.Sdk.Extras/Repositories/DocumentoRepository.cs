using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class DocumentoRepository : IDocumentoRepository<Documento>
    {
        private readonly IAgenteRepository<Agente> _agenteRepository;
        private readonly IClienteProveedorRepository<ClienteProveedor> _clienteProveedorRepository;
        private readonly IConceptoDocumentoRepository<ConceptoDocumento> _conceptoDeDocumentoRepository;
        private readonly IMovimientoRepository<Movimiento> _movimientoRepository;
        private readonly IContpaqiSdk _sdk;
        private readonly IDireccionRepository<Direccion> _direccionRepository;

        public DocumentoRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _conceptoDeDocumentoRepository = new ConceptoDocumentoRepository(sdk);
            _clienteProveedorRepository = new ClienteProveedorRepository(sdk);
            _movimientoRepository = new MovimientoRepository(sdk);
            _agenteRepository = new AgenteRepository(sdk);
            _direccionRepository = new DireccionRepository(_sdk);
        }

        public Documento BuscarPorId(int idDocumento)
        {
            return _sdk.fBuscarIdDocumento(idDocumento) == SdkResultConstants.Success ? LeerDatosDocumentoActual() : null;
        }

        public Documento BuscarPorLlave(string codigoConcepto, string serie, string folio)
        {
            return _sdk.fBuscarDocumento(codigoConcepto, serie, folio) == SdkResultConstants.Success ? LeerDatosDocumentoActual() : null;
        }

        public Documento BuscarPorLlave(tLlaveDoc tLlaveDocumento)
        {
            return _sdk.fBuscaDocumento(ref tLlaveDocumento) == SdkResultConstants.Success ? LeerDatosDocumentoActual() : null;
        }

        public tLlaveDoc BuscarSiguienteSerieYFolio(string codigoConcepto)
        {
            double folio = 0;
            var serie = new StringBuilder();
            _sdk.fSiguienteFolio(codigoConcepto, serie, ref folio).ToResultadoSdk(_sdk).ThrowIfError();
            return new tLlaveDoc {aCodConcepto = codigoConcepto, aSerie = serie.ToString(), aFolio = folio};
        }

        public IEnumerable<Documento> TraerTodo()
        {
            _sdk.fPosPrimerDocumento().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosDocumentoActual();
            while (_sdk.fPosSiguienteDocumento() == SdkResultConstants.Success)
            {
                yield return LeerDatosDocumentoActual();
                if (_sdk.fPosEOF() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<Documento> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto, string codigoClienteProveedor)
        {
            _sdk.fCancelaFiltroDocumento().ToResultadoSdk(_sdk).ThrowIfError();

            var resultadoSdk = _sdk.fSetFiltroDocumento(fechaInicio.ToString("MM/dd/yyyy"), fechaFin.ToString("MM/dd/yyyy"), codigoConcepto, codigoClienteProveedor).ToResultadoSdk(_sdk);

            if (!resultadoSdk.IsSuccess)
            {
                _sdk.fCancelaFiltroDocumento().ToResultadoSdk(_sdk).ThrowIfError();

                if (resultadoSdk.Result == 2) // Si el resultado es "2" significa que no hay documentos en el filtro pero no creo que se considere un error para tirar una excepcion
                {
                    yield break;
                }

                resultadoSdk.ThrowIfError();
            }

            _sdk.fPosPrimerDocumento().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosDocumentoActual();
            while (_sdk.fPosSiguienteDocumento() == SdkResultConstants.Success)
            {
                yield return LeerDatosDocumentoActual();
                if (_sdk.fPosEOF() == 1)
                {
                    break;
                }
            }

            _sdk.fCancelaFiltroDocumento().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public IEnumerable<Documento> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto, IEnumerable<string> codigosClienteProveedor)
        {
            foreach (var codigoClienteProveedor in codigosClienteProveedor)
            {
                foreach (var documento in TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(fechaInicio, fechaFin, codigoConcepto, codigoClienteProveedor))
                {
                    yield return documento;
                }
            }
        }

        private Documento LeerDatosDocumentoActual()
        {
            var folio = new StringBuilder(Constantes.kLongitudFolio);
            var numeroMoneda = new StringBuilder(Constantes.kLongitudMoneda);
            var tipoDeCambio = new StringBuilder(9);
            var importe = new StringBuilder(9);
            var sistemaDeOrigen = new StringBuilder(7);
            var fecha = new StringBuilder(Constantes.kLongFecha);
            var fechaVencimiento = new StringBuilder(Constantes.kLongFecha);
            var fechaEntregaRecepcion = new StringBuilder(Constantes.kLongFecha);
            var serie = new StringBuilder(Constantes.kLongSerie);
            var referencia = new StringBuilder(Constantes.kLongReferencia);
            var gasto1 = new StringBuilder(9);
            var gasto2 = new StringBuilder(9);
            var gasto3 = new StringBuilder(9);
            var id = new StringBuilder(12);
            var conceptoId = new StringBuilder(12);
            var clienteId = new StringBuilder(12);
            var agenteId = new StringBuilder(12);
            var observaciones = new StringBuilder(Constantes.kLongMensaje);
            var textoExtra1 = new StringBuilder(Constantes.kLongTextoExtra);
            var textoExtra2 = new StringBuilder(Constantes.kLongTextoExtra);
            var textoExtra3 = new StringBuilder(Constantes.kLongTextoExtra);
            var fechaExtra = new StringBuilder(Constantes.kLongFecha);
            var lugarExpedicion = new StringBuilder(381);
            var formaPago = new StringBuilder(101);
            var metodoPago = new StringBuilder(12);
            var condicionesPago = new StringBuilder(254);
            var destinatario = new StringBuilder(61);
            var numeroGuia = new StringBuilder(61);
            var mensajeriaNombre = new StringBuilder(21);
            var mensajeriaCuenta = new StringBuilder(121);
            var numeroCajas = new StringBuilder(9);
            var pesoEnvio = new StringBuilder(9);
            var totalUnidades = new StringBuilder(9);
            var neto = new StringBuilder(9);
            var totalImpuesto1 = new StringBuilder(9);
            var totalImpuesto2 = new StringBuilder(9);
            var totalImpuesto3 = new StringBuilder(9);
            var totalDescuentos = new StringBuilder(9);
            var total = new StringBuilder(9);

            _sdk.fLeeDatoDocumento("CFOLIO", folio, Constantes.kLongitudFolio).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CIDMONEDA", numeroMoneda, Constantes.kLongitudMoneda).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CTIPOCAMBIO", tipoDeCambio, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CNETO", importe, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CSISTORIG", sistemaDeOrigen, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CFECHA", fecha, Constantes.kLongFecha).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CFECHAVENCIMIENTO", fechaVencimiento, Constantes.kLongFecha).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CFECHAENTREGARECEPCION", fechaEntregaRecepcion, Constantes.kLongFecha).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CSERIEDOCUMENTO", serie, Constantes.kLongSerie).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CREFERENCIA", referencia, Constantes.kLongReferencia).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CGASTO1", gasto1, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CGASTO2", gasto2, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CGASTO3", gasto3, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CIDDOCUMENTO", id, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CIDCONCEPTODOCUMENTO", conceptoId, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CIDCLIENTEPROVEEDOR", clienteId, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CIDAGENTE", agenteId, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("COBSERVACIONES", observaciones, Constantes.kLongMensaje).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CTEXTOEXTRA1", textoExtra1, Constantes.kLongTextoExtra).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CTEXTOEXTRA2", textoExtra2, Constantes.kLongTextoExtra).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CTEXTOEXTRA3", textoExtra3, Constantes.kLongTextoExtra).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CFECHAEXTRA", fechaExtra, Constantes.kLongFecha).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CLUGAREXPE", lugarExpedicion, 381).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CMETODOPAG", formaPago, 101).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CCANTPARCI", metodoPago, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CCONDIPAGO", condicionesPago, 254).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CDESTINATARIO", destinatario, 61).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CNUMEROGUIA", numeroGuia, 61).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CMENSAJERIA", mensajeriaNombre, 21).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CCUENTAMENSAJERIA", mensajeriaCuenta, 121).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CNUMEROCAJAS", numeroCajas, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CPESO", pesoEnvio, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CTOTALUNIDADES", totalUnidades, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CNETO", neto, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CIMPUESTO1", totalImpuesto1, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CIMPUESTO2", totalImpuesto2, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CIMPUESTO3", totalImpuesto3, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CDESCUENTOMOV", totalDescuentos, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CTOTAL", total, 9).ToResultadoSdk(_sdk).ThrowIfError();

            var documento = new Documento();
            documento.Folio = double.Parse(folio.ToString());
            documento.NumeroMoneda = int.Parse(numeroMoneda.ToString());
            documento.TipoDeCambio = double.Parse(tipoDeCambio.ToString());
            documento.Importe = double.Parse(importe.ToString());
            documento.SistemaDeOrigen = int.TryParse(sistemaDeOrigen.ToString(), out var sistemaOrigenResult) ? sistemaOrigenResult : 0;
            documento.Fecha = DateTime.ParseExact(fecha.ToString(), "M/d/yyyy HH:mm:ss:fff", null);
            documento.FechaVencimiento = DateTime.ParseExact(fechaVencimiento.ToString(), "M/d/yyyy HH:mm:ss:fff", null);
            documento.FechaEntregaRecepcion = DateTime.ParseExact(fechaEntregaRecepcion.ToString(), "M/d/yyyy HH:mm:ss:fff", null);
            documento.Serie = serie.ToString();
            documento.Referencia = referencia.ToString();
            documento.Gasto1 = double.Parse(gasto1.ToString());
            documento.Gasto2 = double.Parse(gasto2.ToString());
            documento.Gasto3 = double.Parse(gasto3.ToString());
            documento.Id = int.Parse(id.ToString());
            documento.IdConceptoDocumento = int.Parse(conceptoId.ToString());
            documento.IdClienteProveedor = int.Parse(clienteId.ToString());
            documento.IdAgente = int.TryParse(agenteId.ToString(), out var agenteIdResult) ? agenteIdResult : 0;
            documento.Observaciones = observaciones.ToString();
            documento.TextoExtra1 = textoExtra1.ToString();
            documento.TextoExtra2 = textoExtra2.ToString();
            documento.TextoExtra3 = textoExtra3.ToString();
            documento.FechaExtra = DateTime.ParseExact(fechaExtra.ToString(), "M/d/yyyy HH:mm:ss:fff", null);
            documento.LugaExpedicion = lugarExpedicion.ToString();
            documento.FormaPago = formaPago.ToString();
            documento.MetodoPago = metodoPago.ToString();
            documento.CondicionesPago = condicionesPago.ToString();
            documento.Destinatario = destinatario.ToString();
            documento.NumeroGuia = numeroGuia.ToString();
            documento.MensajeriaNombre = mensajeriaNombre.ToString();
            documento.MensajeriaCuenta = mensajeriaCuenta.ToString();
            documento.NumeroCajas = double.Parse(numeroCajas.ToString());
            documento.PesoEnvio = double.Parse(pesoEnvio.ToString());
            documento.TotalUnidades = double.Parse(totalUnidades.ToString());
            documento.Neto = double.Parse(neto.ToString());
            documento.TotalImpuesto1 = double.Parse(totalImpuesto1.ToString());
            documento.TotalImpuesto2 = double.Parse(totalImpuesto2.ToString());
            documento.TotalImpuesto3 = double.Parse(totalImpuesto3.ToString());
            documento.TotalDescuentos = double.Parse(totalDescuentos.ToString());
            documento.Total = double.Parse(total.ToString());

            documento.ConceptoDocumento = _conceptoDeDocumentoRepository.BuscarPorId(documento.IdConceptoDocumento);
            documento.ClienteProveedor = _clienteProveedorRepository.BuscarPorId(documento.IdClienteProveedor);
            documento.Agente = _agenteRepository.BuscarPorId(documento.IdAgente);
            documento.Movimientos = _movimientoRepository.TraerPorDocumentoId(documento.Id).ToList();
            documento.CodigoConcepto = documento.ConceptoDocumento.Codigo;
            documento.CodigoClienteProveedor = documento.ClienteProveedor.Codigo;
            documento.CodigoAgente = documento.Agente.Codigo;
            documento.DireccionFiscal = _direccionRepository.BuscarPorDocumento(documento.Id, 0);
            documento.DireccionEnvio = _direccionRepository.BuscarPorDocumento(documento.Id, 1);

            return documento;
        }
    }
}
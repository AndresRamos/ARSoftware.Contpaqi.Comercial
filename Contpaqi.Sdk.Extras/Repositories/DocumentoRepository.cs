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

        public DocumentoRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _conceptoDeDocumentoRepository = new ConceptoDocumentoRepository(sdk);
            _clienteProveedorRepository = new ClienteProveedorRepository(sdk);
            _movimientoRepository = new MovimientoRepository(sdk);
            _agenteRepository = new AgenteRepository(sdk);
        }

        public Documento FindById(int idDocumento)
        {
            return _sdk.fBuscarIdDocumento(idDocumento) == SdkResultConstants.Success ? LeerDatosDocumentoActual() : null;
        }

        public Documento FindByLlave(string codigoConcepto, string serie, string folio)
        {
            return _sdk.fBuscarDocumento(codigoConcepto, serie, folio) == SdkResultConstants.Success ? LeerDatosDocumentoActual() : null;
        }

        public Documento FindByLlave(tLlaveDoc tLlaveDocumento)
        {
            return _sdk.fBuscaDocumento(ref tLlaveDocumento) == SdkResultConstants.Success ? LeerDatosDocumentoActual() : null;
        }

        public tLlaveDoc FindNextSerieAndFolio(string codigoConcepto)
        {
            double folio = 0;
            var serie = new StringBuilder();
            _sdk.fSiguienteFolio(codigoConcepto, serie, ref folio).ToResultadoSdk(_sdk).ThrowIfError();
            return new tLlaveDoc {aCodConcepto = codigoConcepto, aSerie = serie.ToString(), aFolio = folio};
        }

        public IEnumerable<Documento> GetAll()
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

        public IEnumerable<Documento> GetByRangoFechaAndCodigoConceptoAndCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto, string codigoClienteProveedor)
        {
            _sdk.fCancelaFiltroDocumento().ToResultadoSdk(_sdk).ThrowIfError();

            var resultadoSdk = _sdk.fSetFiltroDocumento(fechaInicio.ToString("MM/dd/yyyy"), fechaFin.ToString("MM/dd/yyyy"), codigoConcepto, codigoClienteProveedor).ToResultadoSdk(_sdk);

            if (!resultadoSdk.IsSuccess)
            {
                _sdk.fCancelaFiltroDocumento().ToResultadoSdk(_sdk).ThrowIfError();

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

        private Documento LeerDatosDocumentoActual()
        {
            var folio = new StringBuilder(Constantes.kLongitudFolio);
            var numeroMoneda = new StringBuilder(Constantes.kLongitudMoneda);
            var tipoDeCambio = new StringBuilder(9);
            var importe = new StringBuilder(9);
            var sistemaDeOrigen = new StringBuilder(7);
            var fecha = new StringBuilder(Constantes.kLongFecha);
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

            _sdk.fLeeDatoDocumento("CFOLIO", folio, Constantes.kLongitudFolio).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CIDMONEDA", numeroMoneda, Constantes.kLongitudMoneda).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CTIPOCAM01", tipoDeCambio, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CNETO", importe, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CSISTORIG", sistemaDeOrigen, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CFECHA", fecha, Constantes.kLongFecha).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CSERIEDO01", serie, Constantes.kLongSerie).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDocumento("CREFEREN01", referencia, Constantes.kLongReferencia).ToResultadoSdk(_sdk).ThrowIfError();
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

            var documento = new Documento();
            documento.Folio = double.Parse(folio.ToString());
            documento.NumeroMoneda = int.Parse(numeroMoneda.ToString());
            documento.TipoDeCambio = double.Parse(tipoDeCambio.ToString());
            documento.Importe = double.Parse(importe.ToString());
            documento.SistemaDeOrigen = int.TryParse(sistemaDeOrigen.ToString(), out var sistemaOrigenResult) ? sistemaOrigenResult : 0;
            documento.Fecha = DateTime.ParseExact(fecha.ToString(), "M/d/yyyy HH:mm:ss:fff", null);
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
            documento.ConceptoDocumento = _conceptoDeDocumentoRepository.FindById(documento.IdConceptoDocumento);
            documento.ClienteProveedor = _clienteProveedorRepository.FindById(documento.IdClienteProveedor);
            documento.Agente = _agenteRepository.FindById(documento.IdAgente);
            documento.Movimientos = _movimientoRepository.GetAllByDocumentoId(documento.Id).ToList();
            documento.CodigoConcepto = documento.ConceptoDocumento.Codigo;
            documento.CodigoClienteProveedor = documento.ClienteProveedor.Codigo;
            documento.CodigoAgente = documento.Agente.Codigo;
            return documento;
        }
    }
}
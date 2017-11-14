using System;
using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;

namespace Contpaqi.Sdk.Extras.Repositorios
{
    public class DocumentoRepositorio
    {
        private readonly AgenteRepositorio _agenteRepositorio;
        private readonly ClienteProveedorRepositorio _clienteProveedorRepositorio;
        private readonly ConceptoDocumentoRepositorio _conceptoDeDocumentoRepositorio;
        private readonly ErrorContpaqiSdkRepositorio _errorContpaqiSdkRepositorio;
        private readonly MovimientoRepositorio _movimientoRepositorio;
        private readonly IContpaqiSdk _sdk;

        public DocumentoRepositorio(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _errorContpaqiSdkRepositorio = new ErrorContpaqiSdkRepositorio(sdk);
            _conceptoDeDocumentoRepositorio = new ConceptoDocumentoRepositorio(sdk);
            _clienteProveedorRepositorio = new ClienteProveedorRepositorio(sdk);
            _movimientoRepositorio = new MovimientoRepositorio(sdk);
            _agenteRepositorio = new AgenteRepositorio(sdk);
        }

        public void AsignarSerieYFolioAlDocumento(string codigoConcepto, Documento documento)
        {
            double folio = 0;
            var serie = new StringBuilder();
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fSiguienteFolio(codigoConcepto, serie, ref folio);
            documento.Serie = serie.ToString();
            documento.Folio = folio;
        }

        public Documento BuscarDocumento(int idDocumento)
        {
            return _sdk.fBuscarIdDocumento(idDocumento) == 0 ? LeerDatosDocumentoActual() : null;
        }

        public Documento BuscarDocumento(string codigoConcepto, string serie, string folio)
        {
            return _sdk.fBuscarDocumento(codigoConcepto, serie, folio) == 0 ? LeerDatosDocumentoActual() : null;
        }

        public Documento BuscarDocumento(tLlaveDoc tLlaveDocumento)
        {
            return _sdk.fBuscaDocumento(ref tLlaveDocumento) == 0 ? LeerDatosDocumentoActual() : null;
        }

        public tDocumento ExtraerTDocumento(Documento documento)
        {
            var tdocumento = new tDocumento();
            tdocumento.aFolio = documento.Folio;
            tdocumento.aNumMoneda = documento.NumeroMoneda;
            tdocumento.aTipoCambio = documento.TipoDeCambio;
            tdocumento.aImporte = documento.Importe;
            tdocumento.aDescuentoDoc1 = documento.DescuentoDoc1;
            tdocumento.aDescuentoDoc2 = documento.DescuentoDoc2;
            tdocumento.aSistemaOrigen = documento.SistemaDeOrigen;
            tdocumento.aCodConcepto = documento.CodigoConcepto;
            tdocumento.aSerie = documento.Serie;
            tdocumento.aFecha = documento.Fecha.ToString("MM/dd/yyyy");
            tdocumento.aCodigoCteProv = documento.CodigoClienteProveedor;
            tdocumento.aCodigoAgente = documento.CodigoAgente;
            tdocumento.aReferencia = documento.Referencia;
            tdocumento.aAfecta = documento.Afecta;
            tdocumento.aGasto1 = documento.Gasto1;
            tdocumento.aGasto2 = documento.Gasto2;
            tdocumento.aGasto3 = documento.Gasto3;
            return tdocumento;
        }

        public List<Documento> TraerDocumentos()
        {
            var documentosList = new List<Documento>();
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fPosPrimerDocumento();
            documentosList.Add(LeerDatosDocumentoActual());
            while (_sdk.fPosSiguienteDocumento() == 0)
            {
                documentosList.Add(LeerDatosDocumentoActual());
                if (_sdk.fPosEOF() == 1)
                {
                    break;
                }
            }
            return documentosList;
        }

        public List<Documento> TraerDocumentos(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto, string codigoClienteProveedor)
        {
            var result = _sdk.fSetFiltroDocumento(fechaInicio.ToString("MM/dd/yyyy"), fechaFin.ToString("MM/dd/yyyy"), codigoConcepto, codigoClienteProveedor);
            if (result != 0 && result == 2)
            {
                _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fCancelaFiltroDocumento();
                return new List<Documento>();
            }
            _errorContpaqiSdkRepositorio.ResultadoSdk = result;
            var documentos = TraerDocumentos();
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fCancelaFiltroDocumento();
            return documentos;
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
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CFOLIO", folio, Constantes.kLongitudFolio);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CIDMONEDA", numeroMoneda, Constantes.kLongitudMoneda);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CTIPOCAM01", tipoDeCambio, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CNETO", importe, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CSISTORIG", sistemaDeOrigen, 7);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CFECHA", fecha, Constantes.kLongFecha);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CSERIEDO01", serie, Constantes.kLongSerie);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CREFEREN01", referencia, Constantes.kLongReferencia);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CGASTO1", gasto1, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CGASTO2", gasto2, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CGASTO3", gasto3, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CIDDOCUMENTO", id, 12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CIDCONCEPTODOCUMENTO", conceptoId, 12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CIDCLIENTEPROVEEDOR", clienteId, 12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CIDAGENTE", agenteId, 12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("COBSERVACIONES", observaciones, Constantes.kLongMensaje);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CTEXTOEXTRA1", textoExtra1, Constantes.kLongTextoExtra);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CTEXTOEXTRA2", textoExtra2, Constantes.kLongTextoExtra);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CTEXTOEXTRA3", textoExtra3, Constantes.kLongTextoExtra);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDocumento("CFECHAEXTRA", fechaExtra, Constantes.kLongFecha);
            var documento = new Documento();
            documento.Folio = double.Parse(folio.ToString());
            documento.NumeroMoneda = int.Parse(numeroMoneda.ToString());
            documento.TipoDeCambio = double.Parse(tipoDeCambio.ToString());
            documento.Importe = double.Parse(importe.ToString());
            documento.SistemaDeOrigen = int.TryParse(sistemaDeOrigen.ToString(), out var _sistemaOrigen) ? _sistemaOrigen : 0;
            documento.Fecha = DateTime.ParseExact(fecha.ToString(), "M/d/yyyy HH:mm:ss:fff", null);
            documento.Serie = serie.ToString();
            documento.Referencia = referencia.ToString();
            documento.Gasto1 = double.Parse(gasto1.ToString());
            documento.Gasto2 = double.Parse(gasto2.ToString());
            documento.Gasto3 = double.Parse(gasto3.ToString());
            documento.Id = int.Parse(id.ToString());
            documento.IdConceptoDocumento = int.Parse(conceptoId.ToString());
            documento.IdClienteProveedor = int.Parse(clienteId.ToString());
            documento.IdAgente = int.TryParse(agenteId.ToString(), out var _agenteId) ? _agenteId : 0;
            documento.Observaciones = observaciones.ToString();
            documento.TextoExtra1 = textoExtra1.ToString();
            documento.TextoExtra2 = textoExtra2.ToString();
            documento.TextoExtra3 = textoExtra3.ToString();
            documento.FechaExtra = DateTime.ParseExact(fechaExtra.ToString(), "M/d/yyyy HH:mm:ss:fff", null);
            documento.ConceptoDocumento = _conceptoDeDocumentoRepositorio.BuscarConceptoDocumento(documento.IdConceptoDocumento);
            documento.ClienteProveedor = _clienteProveedorRepositorio.BuscarClienteProveedor(documento.IdClienteProveedor);
            documento.Agente = _agenteRepositorio.BuscarAgente(documento.IdAgente);
            documento.Movimientos = _movimientoRepositorio.TraerMovimientos(documento.Id);
            documento.CodigoConcepto = documento.ConceptoDocumento.Codigo;
            documento.CodigoClienteProveedor = documento.ClienteProveedor.Codigo;
            documento.CodigoAgente = documento.Agente.Codigo;
            return documento;
        }
    }
}
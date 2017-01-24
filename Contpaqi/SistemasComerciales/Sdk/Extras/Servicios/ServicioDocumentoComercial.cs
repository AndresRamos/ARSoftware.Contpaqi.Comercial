using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioDocumentoComercial
    {
        private readonly ISistemasComercialesSdk _sdk;
        private readonly ServicioErrorComercial _errorComercialServicio;
        private readonly ServicioConceptoDocumentoComercial _servicioConceptoDeDocumentoComercial;
        private readonly ServicioClienteProveedorComercial _servicioClienteProveedorComercial;
        private readonly ServicioMovimientoComercial _servicioMovimientoComercial;
        private readonly ServicioAgenteComercial _servicioAgenteComercial;

        public ServicioDocumentoComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _errorComercialServicio = new ServicioErrorComercial(sdk);
            _servicioConceptoDeDocumentoComercial = new ServicioConceptoDocumentoComercial(sdk);
            _servicioClienteProveedorComercial = new ServicioClienteProveedorComercial(sdk);
            _servicioMovimientoComercial = new ServicioMovimientoComercial(sdk);
            _servicioAgenteComercial = new ServicioAgenteComercial(sdk);
        }

        public List<DocumentoComercial> TraerDocumentos()
        {
            List<DocumentoComercial> documentosList = new List<DocumentoComercial>();
            _errorComercialServicio.ResultadoSdk = _sdk.fPosPrimerDocumento();
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

        public List<DocumentoComercial> TraerDocumentos(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto, string codigoClienteProveedor)
        {
            _errorComercialServicio.ResultadoSdk = _sdk.fSetFiltroDocumento(fechaInicio.ToString("MM/dd/yyyy"), fechaFin.ToString("MM/dd/yyyy"), codigoConcepto, codigoClienteProveedor);
            List<DocumentoComercial> documentos = TraerDocumentos();
            _errorComercialServicio.ResultadoSdk = _sdk.fCancelaFiltroDocumento();
            return documentos;
        }

        public DocumentoComercial BuscarDocumento(int idDocumento)
        {
            return _sdk.fBuscarIdDocumento(idDocumento) == 0 ? LeerDatosDocumentoActual() : null;
        }

        public DocumentoComercial BuscarDocumento(string codigoConcepto, string serie, string folio)
        {
            return _sdk.fBuscarDocumento(codigoConcepto, serie, folio) == 0 ? LeerDatosDocumentoActual() : null;
        }

        public DocumentoComercial BuscarDocumento(tLlaveDoc tLlaveDocumento)
        {
            return _sdk.fBuscaDocumento(ref tLlaveDocumento) == 0 ? LeerDatosDocumentoActual() : null;
        }

        public void AsignarSerieYFolioAlDocumento(string codigoConcepto, DocumentoComercial documento)
        {
            double folio = 0;
            StringBuilder serie = new StringBuilder();
            _errorComercialServicio.ResultadoSdk = _sdk.fSiguienteFolio(codigoConcepto, serie, ref folio);
            documento.Serie = serie.ToString();
            documento.Folio = folio;
        }

        public tDocumento ExtraerTDocumento(DocumentoComercial documento)
        {
            tDocumento _tdocumento = new tDocumento();
            _tdocumento.aFolio = documento.Folio;
            _tdocumento.aNumMoneda = documento.NumeroMoneda;
            _tdocumento.aTipoCambio = documento.TipoDeCambio;
            _tdocumento.aImporte = documento.Importe;
            _tdocumento.aDescuentoDoc1 = documento.DescuentoDoc1;
            _tdocumento.aDescuentoDoc2 = documento.DescuentoDoc2;
            _tdocumento.aSistemaOrigen = documento.SistemaDeOrigen;
            _tdocumento.aCodConcepto = documento.CodigoConcepto;
            _tdocumento.aSerie = documento.Serie;
            _tdocumento.aFecha = documento.Fecha.ToString("MM/dd/yyyy");
            _tdocumento.aCodigoCteProv = documento.CodigoClienteProveedor;
            _tdocumento.aCodigoAgente = documento.CodigoAgente;
            _tdocumento.aReferencia = documento.Referencia;
            _tdocumento.aAfecta = documento.Afecta;
            _tdocumento.aGasto1 = documento.Gasto1;
            _tdocumento.aGasto2 = documento.Gasto2;
            _tdocumento.aGasto3 = documento.Gasto3;
            return _tdocumento;
        }

        private DocumentoComercial LeerDatosDocumentoActual()
        {
            StringBuilder folio = new StringBuilder(Constantes.kLongitudFolio);
            StringBuilder numeroMoneda = new StringBuilder(Constantes.kLongitudMoneda);
            StringBuilder tipoDeCambio = new StringBuilder(9);
            StringBuilder importe = new StringBuilder(9);
            StringBuilder sistemaDeOrigen = new StringBuilder(7);
            StringBuilder fecha = new StringBuilder(Constantes.kLongFecha);
            StringBuilder serie = new StringBuilder(Constantes.kLongSerie);
            StringBuilder referencia = new StringBuilder(Constantes.kLongReferencia);
            StringBuilder gasto1 = new StringBuilder(9);
            StringBuilder gasto2 = new StringBuilder(9);
            StringBuilder gasto3 = new StringBuilder(9);
            StringBuilder id = new StringBuilder(12);
            StringBuilder conceptoId = new StringBuilder(12);
            StringBuilder clienteId = new StringBuilder(12);
            StringBuilder agenteId = new StringBuilder(12);
            StringBuilder observaciones = new StringBuilder(Constantes.kLongMensaje);
            StringBuilder textoExtra1 = new StringBuilder(Constantes.kLongTextoExtra);
            StringBuilder textoExtra2 = new StringBuilder(Constantes.kLongTextoExtra);
            StringBuilder textoExtra3 = new StringBuilder(Constantes.kLongTextoExtra);
            StringBuilder fechaExtra = new StringBuilder(Constantes.kLongFecha);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CFOLIO", folio, Constantes.kLongitudFolio);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CIDMONEDA", numeroMoneda, Constantes.kLongitudMoneda);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CTIPOCAM01", tipoDeCambio, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CNETO", importe, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CSISTORIG", sistemaDeOrigen, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CFECHA", fecha, Constantes.kLongFecha);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CSERIEDO01", serie, Constantes.kLongSerie);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CREFEREN01", referencia, Constantes.kLongReferencia);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CGASTO1", gasto1, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CGASTO2", gasto2, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CGASTO3", gasto3, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CIDDOCUMENTO", id, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CIDCONCEPTODOCUMENTO", conceptoId, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CIDCLIENTEPROVEEDOR", clienteId, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CIDAGENTE", agenteId, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("COBSERVACIONES", observaciones, Constantes.kLongMensaje);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CTEXTOEXTRA1", textoExtra1, Constantes.kLongTextoExtra);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CTEXTOEXTRA2", textoExtra2, Constantes.kLongTextoExtra);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CTEXTOEXTRA3", textoExtra3, Constantes.kLongTextoExtra);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDocumento("CFECHAEXTRA", fechaExtra, Constantes.kLongFecha);
            DocumentoComercial documento = new DocumentoComercial();
            documento.Folio = double.Parse(folio.ToString());
            documento.NumeroMoneda = int.Parse(numeroMoneda.ToString());
            documento.TipoDeCambio = double.Parse(tipoDeCambio.ToString());
            documento.Importe = double.Parse(importe.ToString());
            documento.SistemaDeOrigen = int.Parse(sistemaDeOrigen.ToString());
            documento.Fecha = DateTime.ParseExact(fecha.ToString(), "M/d/yyyy HH:mm:ss:fff", null);
            documento.Serie = serie.ToString();
            documento.Referencia = referencia.ToString();
            documento.Gasto1 = double.Parse(gasto1.ToString());
            documento.Gasto2 = double.Parse(gasto2.ToString());
            documento.Gasto3 = double.Parse(gasto3.ToString());
            documento.IdDocumento = int.Parse(id.ToString());
            documento.IdConceptoDocumento = int.Parse(conceptoId.ToString());
            documento.IdClienteProveedor = int.Parse(clienteId.ToString());
            documento.IdAgente = int.Parse(agenteId.ToString());
            documento.Observaciones = observaciones.ToString();
            documento.TextoExtra1 = textoExtra1.ToString();
            documento.TextoExtra2 = textoExtra2.ToString();
            documento.TextoExtra3 = textoExtra3.ToString();
            documento.FechaExtra = DateTime.ParseExact(fechaExtra.ToString(), "M/d/yyyy HH:mm:ss:fff", null);
            documento.ConceptoDocumento = _servicioConceptoDeDocumentoComercial.BuscarConceptoDocumento(documento.IdConceptoDocumento);
            documento.ClienteProveedor = _servicioClienteProveedorComercial.BuscarClienteProveedor(documento.IdClienteProveedor);
            documento.Agente = _servicioAgenteComercial.BuscarAgente(documento.IdAgente);
            documento.Movimientos = _servicioMovimientoComercial.TraerMovimientos(documento.IdDocumento);
            documento.CodigoConcepto = documento.ConceptoDocumento.CodigoConcepto;
            documento.CodigoClienteProveedor = documento.ClienteProveedor.CodigoCliente;
            documento.CodigoAgente = documento.Agente.CodigoAgente;
            return documento;
        }
    }
}
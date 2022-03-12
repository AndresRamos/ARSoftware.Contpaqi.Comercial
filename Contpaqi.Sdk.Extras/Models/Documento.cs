using System;
using System.Collections.Generic;
using System.Globalization;
using Contpaqi.Comercial.Sql.Models.Empresa;
using Contpaqi.Sdk.DatosAbstractos;
using Contpaqi.Sdk.Extras.Extensions;

namespace Contpaqi.Sdk.Extras.Models
{
    public class Documento : admDocumentos
    {
        public Agente Agente { get; set; } = new Agente();
        public ClienteProveedor ClienteProveedor { get; set; } = new ClienteProveedor();
        public ConceptoDocumento ConceptoDocumento { get; set; } = new ConceptoDocumento();
        public Direccion DireccionEnvio { get; set; } = new Direccion();
        public Direccion DireccionFiscal { get; set; } = new Direccion();
        public List<Movimiento> Movimientos { get; set; } = new List<Movimiento>();

        public bool Contains(string filtro)
        {
            return string.IsNullOrWhiteSpace(filtro) ||
                   CIDDOCUMENTO.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   ConceptoDocumento.CCODIGOCONCEPTO.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   ConceptoDocumento.CNOMBRECONCEPTO.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   CSERIEDOCUMENTO.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   CFOLIO.ToString(CultureInfo.InvariantCulture).IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public tDocumento ToTDocumento()
        {
            var tdocumento = new tDocumento
            {
                aFolio = CFOLIO,
                aNumMoneda = CIDMONEDA,
                aTipoCambio = CTIPOCAMBIO,
                aImporte = CNETO,
                aDescuentoDoc1 = CDESCUENTODOC1,
                aDescuentoDoc2 = CDESCUENTODOC2,
                aSistemaOrigen = CSISTORIG,
                aCodConcepto = ConceptoDocumento.CCODIGOCONCEPTO,
                aSerie = CSERIEDOCUMENTO,
                aFecha = CFECHA.ToSdkFecha(),
                aCodigoCteProv = ClienteProveedor.CCODIGOCLIENTE,
                aCodigoAgente = Agente.CCODIGOAGENTE,
                aReferencia = CREFERENCIA,
                aAfecta = CAFECTADO,
                aGasto1 = CGASTO1,
                aGasto2 = CGASTO2,
                aGasto3 = CGASTO3
            };
            return tdocumento;
        }
    }
}

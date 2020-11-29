using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class DocumentoHelper
    {
        public static tDocumento ToTDocumento(this Documento documento)
        {
            var tdocumento = new tDocumento
            {
                aFolio = documento.Folio,
                aNumMoneda = documento.NumeroMoneda,
                aTipoCambio = documento.TipoDeCambio,
                aImporte = documento.Importe,
                aDescuentoDoc1 = documento.DescuentoDoc1,
                aDescuentoDoc2 = documento.DescuentoDoc2,
                aSistemaOrigen = documento.SistemaDeOrigen,
                aCodConcepto = documento.CodigoConcepto,
                aSerie = documento.Serie,
                aFecha = documento.Fecha.ToString("MM/dd/yyyy"),
                aCodigoCteProv = documento.CodigoClienteProveedor,
                aCodigoAgente = documento.CodigoAgente,
                aReferencia = documento.Referencia,
                aAfecta = documento.Afecta,
                aGasto1 = documento.Gasto1,
                aGasto2 = documento.Gasto2,
                aGasto3 = documento.Gasto3
            };
            return tdocumento;
        }
    }
}
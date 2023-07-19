namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models
{
    public class LlaveDocumento
    {
        public LlaveDocumento()
        {
        }

        public LlaveDocumento(string codigoConcepto, string serie, double folio)
        {
            CodigoConcepto = codigoConcepto;
            Serie = serie;
            Folio = folio;
        }

        public string CodigoConcepto { get; set; }
        public string Serie { get; set; }
        public double Folio { get; set; }
    }
}
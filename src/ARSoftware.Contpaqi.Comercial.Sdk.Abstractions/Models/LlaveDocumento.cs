namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

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

    public string CodigoConcepto { get; set; } = string.Empty;
    public string Serie { get; set; } = string.Empty;
    public double Folio { get; set; }
}

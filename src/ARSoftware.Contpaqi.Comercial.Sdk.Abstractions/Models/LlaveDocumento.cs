namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

public class LlaveDocumento
{
    public LlaveDocumento()
    {
    }

    public LlaveDocumento(string conceptoCodigo, string serie, double folio)
    {
        ConceptoCodigo = conceptoCodigo;
        Serie = serie;
        Folio = folio;
    }

    public string ConceptoCodigo { get; set; } = string.Empty;
    public string Serie { get; set; } = string.Empty;
    public double Folio { get; set; }
}

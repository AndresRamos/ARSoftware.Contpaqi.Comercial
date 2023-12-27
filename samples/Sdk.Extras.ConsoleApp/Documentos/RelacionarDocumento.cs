using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp;

public sealed class RelacionarDocumento
{
    private readonly IDocumentoService _documentoService;

    public RelacionarDocumento(IDocumentoService documentoService)
    {
        _documentoService = documentoService;
    }

    public void RelacionPorLlave()
    {
        var documento = new tLlaveDoc { aCodConcepto = "PRUEBAFACTURA", aSerie = "PRUEBA", aFolio = 1 };
        var documentoARelacionar = new tLlaveDoc { aCodConcepto = "PRUEBAFACTURA", aSerie = "PRUEBA", aFolio = 2 };

        _documentoService.RelacionarDocumentos(documento, "01", documentoARelacionar);
    }

    public void RelacionPorUuid()
    {
        var documento = new tLlaveDoc { aCodConcepto = "PRUEBAFACTURA", aSerie = "PRUEBA", aFolio = 1 };

        _documentoService.RelacionarDocumentos(documento, "03", "51F58A42-3827-49A3-A1E5-54CADF80F9C6");
    }
}

using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp;

public class DesbloquearDocumento
{
    private readonly IDocumentoService _documentoService;

    public DesbloquearDocumento(IDocumentoService documentoService)
    {
        _documentoService = documentoService;
    }

    public void DesbloquearPorId()
    {
        var documentoId = 1;

        _documentoService.DesbloquearDocumento(documentoId);
    }

    public void DesbloquearPorLlave()
    {
        var conceptoCodigo = "PRUEBAFACTURA";
        var serie = "PRUEBA";
        var folio = 1;

        var llave = new LlaveDocumento(conceptoCodigo, serie, folio);

        _documentoService.DesbloquearDocumento(llave);
    }
}

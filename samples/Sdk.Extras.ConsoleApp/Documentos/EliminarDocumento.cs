using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp;

public class EliminarDocumento
{
    private readonly IDocumentoService _documentoService;

    public EliminarDocumento(IDocumentoService documentoService)
    {
        _documentoService = documentoService;
    }

    public void Eliminar()
    {
        var llaveDocumento = new tLlaveDoc { aCodConcepto = "PRUEBAFACTURA", aSerie = "PRUEBA", aFolio = 1 };

        _documentoService.Eliminar(llaveDocumento);
    }
}

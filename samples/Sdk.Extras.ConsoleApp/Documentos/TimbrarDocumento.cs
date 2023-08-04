using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp;

// ReSharper disable once InconsistentNaming
public class TimbrarDocumento
{
    private readonly IDocumentoService _documentoService;

    public TimbrarDocumento(IDocumentoService documentoService)
    {
        _documentoService = documentoService;
    }

    public void Crear()
    {
        var llaveDocumento = new tLlaveDoc { aCodConcepto = "PRUEBAFACTURA", aSerie = "PRUEBA", aFolio = 1 };
        var contrasenaCertificado = "12345678a";

        _documentoService.Timbrar(llaveDocumento, contrasenaCertificado);
    }
}

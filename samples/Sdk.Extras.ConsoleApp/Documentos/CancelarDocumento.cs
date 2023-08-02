using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp;

public class CancelarDocumento
{
    private readonly IDocumentoService _documentoService;

    public CancelarDocumento(IDocumentoService documentoService)
    {
        _documentoService = documentoService;
    }

    public void Cancelar()
    {
        var llaveDocumento = new tLlaveDoc { aCodConcepto = "PRUEBAFACTURA", aSerie = "PRUEBA", aFolio = 1 };
        var contrasenaCertificado = "12345678a";
        MotivoCancelacionEnum motivoCancelacion = MotivoCancelacionEnum._02;

        _documentoService.Cancelar(llaveDocumento, contrasenaCertificado, motivoCancelacion, string.Empty);
    }

    public void CancelarAdministrativamente()
    {
        var llaveDocumento = new tLlaveDoc { aCodConcepto = "PRUEBAFACTURA", aSerie = "PRUEBA", aFolio = 1 };

        _documentoService.CancelarAdministrativamente(llaveDocumento);
    }
}

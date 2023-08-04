using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace Sdk.Extras.ConsoleApp;

public class SaldarDocumento
{
    private readonly IDocumentoService _documentoService;

    public SaldarDocumento(IDocumentoService documentoService)
    {
        _documentoService = documentoService;
    }

    public void Saldar()
    {
        var documentoPagar = new tLlaveDoc { aCodConcepto = "PRUEBAFACTURA", aSerie = "PRUEBA", aFolio = 1 };
        var documentoPago = new tLlaveDoc { aCodConcepto = "PRUEBAABONO", aSerie = "PRUEBA", aFolio = 1 };
        var importe = 100;
        DateTime fecha = DateTime.Today;
        int moneda = MonedaEnum.PesoMexicano.Value;

        _documentoService.SaldarDocumento(documentoPagar, documentoPago, fecha, importe, moneda);
    }
}

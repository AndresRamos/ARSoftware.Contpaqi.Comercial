using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp;

public class GenerarDocumentoDigitalDocumento
{
    private readonly IDocumentoService _documentoService;

    public GenerarDocumentoDigitalDocumento(IDocumentoService documentoService)
    {
        _documentoService = documentoService;
    }

    public void CrearPdf()
    {
        var llaveDocumento = new tLlaveDoc { aCodConcepto = "PRUEBAFACTURA", aSerie = "PRUEBA", aFolio = 1 };
        var rutaPlantilla =
            @"\\AR-SERVER\Compac\Empresas\Reportes\Formatos Digitales\reportes_Servidor\COMERCIAL\Facturav40.rdl"; // La ruta a la plantilla en mi servidor ya que las pruebas las hago en una temrinal.

        _documentoService.GenerarDocumentoDigital(llaveDocumento, TipoArchivoDigital.Pdf, rutaPlantilla);
    }

    public void CrearXml()
    {
        var llaveDocumento = new tLlaveDoc { aCodConcepto = "PRUEBAFACTURA", aSerie = "PRUEBA", aFolio = 1 };
        _documentoService.GenerarDocumentoDigital(llaveDocumento, TipoArchivoDigital.Xml);
    }
}

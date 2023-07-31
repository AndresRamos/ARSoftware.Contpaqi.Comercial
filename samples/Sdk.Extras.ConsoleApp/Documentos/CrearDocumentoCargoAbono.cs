using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

namespace Sdk.Extras.ConsoleApp;

public class CrearDocumentoCargoAbono
{
    private readonly IDocumentoService _documentoService;

    public CrearDocumentoCargoAbono(IDocumentoService documentoService)
    {
        _documentoService = documentoService;
    }

    public int Crear()
    {
        tLlaveDoc siguienteFolio = _documentoService.BuscarSiguienteSerieYFolio("PRUEBAABONO");

        var documento = new Documento
        {
            Concepto = new ConceptoDocumento { Codigo = "PRUEBAABONO" },
            Serie = siguienteFolio.aSerie,
            Folio = (int)siguienteFolio.aFolio,
            Fecha = DateTime.Today,
            Cliente = new ClienteProveedor { Codigo = "PRUEBA" },
            Referencia = "Referencia",
            Observaciones = "Observaciones",
            Moneda = Moneda.PesoMexicano,
            TipoCambio = 1,
            Total = 100
        };

        int nuevoDocumentoId = _documentoService.CrearCargoAbono(documento);

        return nuevoDocumentoId;
    }
}

using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using Sdk.ConsoleApp.Catalogos;
using Sdk.ConsoleApp.Documentos;

namespace Sdk.ConsoleApp.Pruebas;

internal class DocumentoPrueba
{
    public static int CrearCompraPrueba()
    {
        ConceptoSdk concepto = ConceptoSdk.BuscarConceptoPorCodigo("21");
        ClienteSdk cliente = ClienteSdk.BuscarClientePorCodigo("PROV001");

        tLlaveDoc siguienteFolio = DocumentoSdk.BuscarSiguienteSerieYFolio(concepto.Codigo);

        var nuevoDocumento = new DocumentoSdk
        {
            ConceptoId = concepto.Id,
            Fecha = DateTime.Today,
            Serie = siguienteFolio.aSerie,
            Folio = siguienteFolio.aFolio,
            ClienteId = cliente.Id,
            Referencia = "Referencia compra",
            Observaciones = "Observaciones compra"
        };

        int nuevoDocumentoId = DocumentoSdk.CrearDocumento(nuevoDocumento);

        CrearMovimientoPrueba(nuevoDocumentoId);
        CrearMovimientoPrueba(nuevoDocumentoId);
        CrearMovimientoPrueba(nuevoDocumentoId);

        return nuevoDocumentoId;
    }

    public static int CrearDocumentoAbonoPrueba()
    {
        ConceptoSdk concepto = ConceptoSdk.BuscarConceptoPorCodigo("13");
        ClienteSdk cliente = ClienteSdk.BuscarClientePorCodigo("CTE001");

        tLlaveDoc siguienteFolio = DocumentoSdk.BuscarSiguienteSerieYFolio(concepto.Codigo);

        var nuevoDocumento = new DocumentoSdk
        {
            ConceptoId = concepto.Id,
            Fecha = DateTime.Today,
            Serie = siguienteFolio.aSerie,
            Folio = siguienteFolio.aFolio,
            ClienteId = cliente.Id,
            Referencia = "Referencia abono",
            Observaciones = "Observaciones abono",
            Total = 116
        };

        return DocumentoSdk.CrearDocumentoCargoAbono(nuevoDocumento);
    }

    public static int CrearDocumentoPrueba()
    {
        ConceptoSdk concepto = ConceptoSdk.BuscarConceptoPorCodigo("400");
        ClienteSdk cliente = ClienteSdk.BuscarClientePorCodigo("CTE001");

        tLlaveDoc siguienteFolio = DocumentoSdk.BuscarSiguienteSerieYFolio(concepto.Codigo);

        var nuevoDocumento = new DocumentoSdk
        {
            ConceptoId = concepto.Id,
            Fecha = DateTime.Today,
            Serie = siguienteFolio.aSerie,
            Folio = siguienteFolio.aFolio,
            ClienteId = cliente.Id,
            Referencia = "Referencia documento",
            Observaciones = "Observaciones documento"
        };

        return DocumentoSdk.CrearDocumento(nuevoDocumento);
    }

    public static int CrearFacturaPrueba()
    {
        ConceptoSdk concepto = ConceptoSdk.BuscarConceptoPorCodigo("400");
        ClienteSdk cliente = ClienteSdk.BuscarClientePorCodigo("CTE001");

        tLlaveDoc siguienteFolio = DocumentoSdk.BuscarSiguienteSerieYFolio(concepto.Codigo);

        var nuevoDocumento = new DocumentoSdk
        {
            ConceptoId = concepto.Id,
            Fecha = DateTime.Today,
            Serie = siguienteFolio.aSerie,
            Folio = siguienteFolio.aFolio,
            ClienteId = cliente.Id,
            Referencia = "Referencia factura",
            Observaciones = "Observaciones factura"
        };

        int nuevoDocumentoId = DocumentoSdk.CrearDocumento(nuevoDocumento);

        CrearMovimientoPrueba(nuevoDocumentoId);

        return nuevoDocumentoId;
    }

    public static int CrearMovimientoPrueba(int documentoId)
    {
        ProductoSdk producto = ProductoSdk.BuscarProductoPorCodigo("SERV001");

        var movimiento = new MovimientoSdk
        {
            DocumentoId = documentoId,
            ProductoId = producto.Id,
            Unidades = 1,
            Precio = 100,
            Referencia = "Referencia movimiento",
            Observaciones = "Observaciones movimiento"
        };

        return MovimientoSdk.CrearMovimiento(movimiento);
    }
}

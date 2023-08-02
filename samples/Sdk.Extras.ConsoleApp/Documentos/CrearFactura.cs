using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.ConsoleApp;

public class CrearFactura
{
    private readonly IDocumentoService _documentoService;
    private readonly IMovimientoService _movimientoService;

    public CrearFactura(IDocumentoService documentoService, IMovimientoService movimientoService)
    {
        _documentoService = documentoService;
        _movimientoService = movimientoService;
    }

    public int Crear()
    {
        tLlaveDoc siguienteFolio = _documentoService.BuscarSiguienteSerieYFolio("PRUEBAFACTURA");

        var documento = new Documento
        {
            Concepto = new ConceptoDocumento { Codigo = "PRUEBAFACTURA" },
            Serie = siguienteFolio.aSerie,
            Folio = (int)siguienteFolio.aFolio,
            Fecha = DateTime.Today,
            Cliente = new ClienteProveedor { Codigo = "PRUEBA" },
            Referencia = "Referencia",
            FormaPago = FormaPagoEnum._03,
            MetodoPago = MetodoPagoEnum.PPD,
            Observaciones = "Observaciones",
            Moneda = MonedaEnum.PesoMexicano.ToMoneda(),
            TipoCambio = 1,
            Agente = new Agente { Codigo = "PRUEBA" }
        };

        documento.DatosExtra.Add(nameof(admDocumentos.CTEXTOEXTRA1), "Texto Extra 1");
        documento.DatosExtra.Add(nameof(admDocumentos.CTEXTOEXTRA2), "Texto Extra 2");

        var movimiento = new Movimiento
        {
            Producto = new Producto { Codigo = "PRUEBA" },
            Almacen = new Almacen { Codigo = "1" },
            Unidades = 1,
            Precio = 100,
            Referencia = "Referencia",
            Observaciones = "Observaciones"
        };

        movimiento.DatosExtra.Add(nameof(admMovimientos.CTEXTOEXTRA1), "Texto Extra 1");

        documento.Movimientos.Add(movimiento);

        int nuevoDocumentoId = _documentoService.Crear(documento);

        foreach (Movimiento mov in documento.Movimientos) _movimientoService.Crear(nuevoDocumentoId, mov);

        return nuevoDocumentoId;
    }
}

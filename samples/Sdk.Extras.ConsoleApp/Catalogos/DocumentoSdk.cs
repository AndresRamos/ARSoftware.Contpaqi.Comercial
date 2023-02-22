using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sdk.Extras.ConsoleApp.Catalogos;

public sealed class DocumentoSdk
{
    private readonly IAlmacenRepository<Almacen> _almacenRepository;
    private readonly IClienteProveedorRepository<ClienteProveedor> _clienteProveedorRepository;
    private readonly IConceptoDocumentoRepository<ConceptoDocumento> _conceptoDocumentoRepository;
    private readonly IDocumentoRepository<Documento> _documentoRepository;
    private readonly IDocumentoService _documentoService;
    private readonly ILogger<DocumentoSdk> _logger;
    private readonly IMovimientoRepository<Movimiento> _movimientoRepository;
    private readonly IMovimientoService _movimientoService;
    private readonly IProductoRepository<Producto> _productoRepository;

    public DocumentoSdk(IDocumentoRepository<Documento> documentoRepository,
                        IDocumentoService documentoService,
                        ILogger<DocumentoSdk> logger,
                        IConceptoDocumentoRepository<ConceptoDocumento> conceptoDocumentoRepository,
                        IClienteProveedorRepository<ClienteProveedor> clienteProveedorRepository,
                        IMovimientoService movimientoService,
                        IProductoRepository<Producto> productoRepository,
                        IAlmacenRepository<Almacen> almacenRepository,
                        IMovimientoRepository<Movimiento> movimientoRepository)
    {
        _documentoRepository = documentoRepository;
        _documentoService = documentoService;
        _logger = logger;
        _conceptoDocumentoRepository = conceptoDocumentoRepository;
        _clienteProveedorRepository = clienteProveedorRepository;
        _movimientoService = movimientoService;
        _productoRepository = productoRepository;
        _almacenRepository = almacenRepository;
        _movimientoRepository = movimientoRepository;
    }

    public void CrearDocumentoPrueba()
    {
        _logger.LogInformation("CrearDocumentoPrueba()");
        var documento = new Documento();
        documento.ConceptoDocumento = _conceptoDocumentoRepository.BuscarPorCodigo("400");

        tLlaveDoc siguienteFolio = _documentoService.BuscarSiguienteSerieYFolio(documento.ConceptoDocumento.CCODIGOCONCEPTO);
        documento.CSERIEDOCUMENTO = siguienteFolio.aSerie;
        documento.CFOLIO = siguienteFolio.aFolio;
        _logger.LogInformation("Siguiente Folio: {Folio}", siguienteFolio.aFolio);

        documento.ClienteProveedor = _clienteProveedorRepository.BuscarPorCodigo("CTE001");
        documento.CREFERENCIA = "Referencia doc";

        _logger.LogInformation("_documentoService.Crear();");
        int documentoId = _documentoService.Crear(documento.ToTDocumento());
        _logger.LogInformation("Documento Id: {ID}", documentoId);

        documento.FormaPago = FormaPago._03;
        documento.MetodoPago = MetodoPago.PPD;
        documento.COBSERVACIONES = "Observaciones documento";

        var datosDocumento = new Dictionary<string, string>
        {
            { nameof(admDocumentos.COBSERVACIONES), documento.COBSERVACIONES },
            { nameof(admDocumentos.CMETODOPAG), documento.CMETODOPAG },
            { nameof(admDocumentos.CCANTPARCI), documento.CCANTPARCI.ToString() }
        };

        _logger.LogInformation("_documentoService.Actualizar();");
        _documentoService.Actualizar(documentoId, datosDocumento);

        var movimiento = new Movimiento();
        movimiento.Producto = _productoRepository.BuscarPorCodigo("SERV001");
        movimiento.CUNIDADES = 1;
        movimiento.CPRECIO = 100;
        movimiento.CREFERENCIA = "Referencia mov";
        movimiento.Almacen = _almacenRepository.BuscarPorCodigo("1");

        _logger.LogInformation("_movimientoService.Crear();");
        int movimientoId = _movimientoService.Crear(documentoId, movimiento.ToTMovimiento());

        movimiento.CTEXTOEXTRA1 = "Texto Extra 1";
        movimiento.CTEXTOEXTRA2 = "Texto Extra 2";
        movimiento.COBSERVAMOV = "Observaciones Movimiento";

        var datosMovimiento = new Dictionary<string, string>
        {
            { nameof(admMovimientos.CTEXTOEXTRA1), movimiento.CTEXTOEXTRA1 },
            { nameof(admMovimientos.CTEXTOEXTRA2), movimiento.CTEXTOEXTRA2 },
            { nameof(admMovimientos.COBSERVAMOV), movimiento.COBSERVAMOV }
        };

        _logger.LogInformation("_movimientoService.Actualizar();");
        _movimientoService.Actualizar(movimientoId, datosMovimiento);
    }

    public Documento BuscarDocumentoPorLlave(string concepto, string serie, string folio)
    {
        Documento? documento = _documentoRepository.BuscarPorLlave(concepto, serie, folio);

        BuscarYAsignarRelaciones(documento);

        return documento;
    }

    public List<Documento> BuscarPorFiltro(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto, string codigoCliente)
    {
        _logger.LogInformation("BuscarPorFiltro()");
        List<Documento> documentos = _documentoRepository
            .TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(fechaInicio, fechaFin, codigoConcepto, codigoCliente)
            .ToList();

        foreach (Documento documento in documentos)
            BuscarYAsignarRelaciones(documento);

        return documentos;
    }

    public void BorrarDocumento(string codigoConcepto, string serie, string folio)
    {
        _logger.LogInformation("BorrarDocumento()");
        _documentoService.Eliminar(codigoConcepto, serie, folio);
    }

    public void SaldarDocumento()
    {
        _logger.LogInformation("SaldarDocumento()");
        tLlaveDoc siguienteFolio = _documentoService.BuscarSiguienteSerieYFolio("13");
        var tDocumento = new tDocumento
        {
            aCodConcepto = "13",
            aCodigoCteProv = "CTE001",
            aFecha = DateTime.Today.ToSdkFecha(),
            aNumMoneda = 1,
            aTipoCambio = 1,
            aSerie = siguienteFolio.aSerie,
            aFolio = siguienteFolio.aFolio,
            aImporte = 116
        };

        int documentoPagoId = _documentoService.CrearCargoAbono(tDocumento);

        Documento? documentoPago = _documentoRepository.BuscarPorId(documentoPagoId);
        BuscarYAsignarRelaciones(documentoPago);
        Documento? documentoPagar = _documentoRepository.BuscarPorLlave("400", "FAP", "28");
        BuscarYAsignarRelaciones(documentoPagar);

        _logger.LogInformation("SaldarDocumento()");
        _documentoService.SaldarDocumento(documentoPagar.ToTLlaveDoc(),
            documentoPago.ToTLlaveDoc(),
            DateTime.Today,
            documentoPago.CTOTAL,
            Moneda.PesoMexicano.Id);
    }

    public void TimbrarDocumento()
    {
        _logger.LogInformation("TimbrarDocumento()");
        _documentoService.Timbrar("400", "FAP", 28, "12345678a");
    }

    public void CrearDocumentoDigital(TipoArchivoDigital tipo, string rutaPlantilla, string rutaEmpresa)
    {
        _logger.LogInformation("CrearDocumentoDigital()");
        _documentoService.GenerarDocumentoDigital("400", "FAP", 28, tipo, rutaPlantilla);
        string? rutaArchivo = ArchivoDigitalHelper.GenerarRutaArchivoDigital(tipo, rutaEmpresa, "FAP", "28");
        _logger.LogInformation("Ruta: {Ruta}", rutaArchivo);
    }

    public void CancelarDocumento()
    {
        _logger.LogInformation("CancelarDocumento()");
        Documento? documento = _documentoRepository.BuscarPorLlave("400", "FAP", "28");
        _documentoService.Cancelar(documento.CIDDOCUMENTO, "12345678a", "02", "");
    }

    public void LogDocumento(Documento documento)
    {
        _logger.LogInformation("Concepto:{Concepto}, Serie:{Serie}, Folio{Folio}, Cliente:{Cliente}, Total:{Total}",
            documento.ConceptoDocumento.CNOMBRECONCEPTO,
            documento.CSERIEDOCUMENTO,
            documento.CFOLIO,
            documento.ClienteProveedor.CRAZONSOCIAL,
            documento.CTOTAL);

        foreach (Movimiento movimiento in documento.Movimientos)
        {
            _logger.LogInformation("    Producto:{Producto}, Unidades:{Unidades}, Precio:{Precio}, Total:{Total}",
                movimiento.Producto.CNOMBREPRODUCTO,
                movimiento.CUNIDADES,
                movimiento.CPRECIO,
                movimiento.CTOTAL);
        }
    }

    private void BuscarYAsignarRelaciones(Documento documento)
    {
        documento.ConceptoDocumento = _conceptoDocumentoRepository.BuscarPorId(documento.CIDCONCEPTODOCUMENTO);
        documento.ClienteProveedor = _clienteProveedorRepository.BuscarPorId(documento.CIDCLIENTEPROVEEDOR);

        documento.Movimientos = _movimientoRepository.TraerPorDocumentoId(documento.CIDDOCUMENTO).ToList();

        foreach (Movimiento movimiento in documento.Movimientos)
            movimiento.Producto = _productoRepository.BuscarPorId(movimiento.CIDPRODUCTO);
    }
}

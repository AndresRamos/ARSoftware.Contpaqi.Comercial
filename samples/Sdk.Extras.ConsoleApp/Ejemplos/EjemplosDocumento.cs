using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Sdk.Extras.ConsoleApp.Dtos;

namespace Sdk.Extras.ConsoleApp.Ejemplos;

public sealed class EjemplosDocumento
{
    private const string
        CodigoConceptoFacturaPruebas = "400"; // Este concepto lo di de alta manualmente en Comercial para pruebas de facturas

    private const string CodigoConceptoAbonoPruebas = "13"; // Abono del Cliente
    private const string CodigoClientePruebas = "CTE001"; // Este cliente lo di de alta manualmente en Comercial para pruebas de facturas
    private const string CodigoProductoPruebas = "SERV001"; // Este producto lo di de alta manualmente en Comercial para pruebas de facturas
    private const string ContrasenaCertificadoPruebas = "12345678a";
    private const string CodigoAlmacenPruebas = "1";

    private const string RutaPlantillaPdfPruebas =
        @"\\AR-SERVER\Compac\Empresas\Reportes\Formatos Digitales\reportes_Servidor\COMERCIAL\Facturav40.rdl"; // La ruta a la plantilla en mi servidor ya que las pruebas las hago en una temrinal.

    private const string MotivoCancelacionPruebas = "02";
    private const string UuidReemplazoPruebas = "";
    private const double ImporteAbonoPruebas = 116;
    private readonly IAlmacenRepository<Almacen> _almacenRepository;
    private readonly IClienteProveedorRepository<ClienteProveedor> _clienteProveedorRepository;
    private readonly IConceptoDocumentoRepository<ConceptoDocumento> _conceptoDocumentoRepository;
    private readonly IDocumentoRepository<DocumentoDto> _documentoDtoRepository;
    private readonly IDocumentoRepository<Documento> _documentoRepository;
    private readonly IDocumentoService _documentoService;
    private readonly ILogger<EjemplosDocumento> _logger;
    private readonly IMovimientoRepository<Movimiento> _movimientoRepository;
    private readonly IMovimientoService _movimientoService;
    private readonly IProductoRepository<Producto> _productoRepository;

    public EjemplosDocumento(IDocumentoRepository<Documento> documentoRepository,
                             IDocumentoService documentoService,
                             ILogger<EjemplosDocumento> logger,
                             IConceptoDocumentoRepository<ConceptoDocumento> conceptoDocumentoRepository,
                             IClienteProveedorRepository<ClienteProveedor> clienteProveedorRepository,
                             IMovimientoService movimientoService,
                             IProductoRepository<Producto> productoRepository,
                             IAlmacenRepository<Almacen> almacenRepository,
                             IMovimientoRepository<Movimiento> movimientoRepository,
                             IDocumentoRepository<DocumentoDto> documentoDtoRepository)
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
        _documentoDtoRepository = documentoDtoRepository;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo pruebas de documentos");

        CrearFactura();

        CrearFactura_Borrar();

        CrearFactura_Timbrar();

        CrearFactura_CrearAbono_Saldar_Timbrar();

        CrearFactura_Timbrar_GenerarDocumentos();

        CrearFactura_Timbrar_Cancelar();

        CrearFactura_Timbrar_CancelarAdministrativamente();

        BuscarPorFiltro(DateTime.Today, DateTime.Today, CodigoConceptoFacturaPruebas, CodigoClientePruebas);

        BuscarPorFiltroUtilizandoDto(DateTime.Today, DateTime.Today, CodigoConceptoFacturaPruebas, CodigoClientePruebas);
    }

    private void CrearFactura()
    {
        tLlaveDoc llaveDocumento = CrearFacturaPrueba($"Prueba {nameof(CrearFactura)}");

        BuscarDocumentoPorLlave(llaveDocumento);
    }

    private void CrearFactura_Borrar()
    {
        tLlaveDoc llaveDocumento = CrearFacturaPrueba($"Prueba {nameof(CrearFactura_Borrar)}");

        BuscarDocumentoPorLlave(llaveDocumento);

        BorrarDocumento(llaveDocumento);
    }

    private void CrearFactura_Timbrar()
    {
        tLlaveDoc llaveDocumento = CrearFacturaPrueba($"Prueba {nameof(CrearFactura_Timbrar)}");

        BuscarDocumentoPorLlave(llaveDocumento);

        TimbrarDocumento(llaveDocumento, ContrasenaCertificadoPruebas);
    }

    private void CrearFactura_Timbrar_GenerarDocumentos()
    {
        tLlaveDoc llaveDocumento = CrearFacturaPrueba($"Prueba {nameof(CrearFactura_Timbrar_GenerarDocumentos)}");

        BuscarDocumentoPorLlave(llaveDocumento);

        TimbrarDocumento(llaveDocumento, ContrasenaCertificadoPruebas);

        CrearDocumentoDigital(llaveDocumento, TipoArchivoDigital.Xml, "");

        CrearDocumentoDigital(llaveDocumento, TipoArchivoDigital.Pdf, RutaPlantillaPdfPruebas);
    }

    private void CrearFactura_CrearAbono_Saldar_Timbrar()
    {
        tLlaveDoc llaveDocumento = CrearFacturaPrueba($"Prueba {nameof(CrearFactura_CrearAbono_Saldar_Timbrar)}");

        BuscarDocumentoPorLlave(llaveDocumento);

        tLlaveDoc llaveAbono = CrearAbonoPrueba();

        BuscarDocumentoPorLlave(llaveAbono);

        SaldarDocumento(llaveDocumento, llaveAbono);

        TimbrarDocumento(llaveDocumento, ContrasenaCertificadoPruebas);
    }

    private void CrearFactura_Timbrar_Cancelar()
    {
        tLlaveDoc llaveDocumento = CrearFacturaPrueba($"Prueba {nameof(CrearFactura_Timbrar_Cancelar)}");

        BuscarDocumentoPorLlave(llaveDocumento);

        TimbrarDocumento(llaveDocumento, ContrasenaCertificadoPruebas);

        CancelarDocumento(llaveDocumento);
    }

    private void CrearFactura_Timbrar_CancelarAdministrativamente()
    {
        tLlaveDoc llaveDocumento = CrearFacturaPrueba($"Prueba {nameof(CrearFactura_Timbrar_CancelarAdministrativamente)}");

        BuscarDocumentoPorLlave(llaveDocumento);

        TimbrarDocumento(llaveDocumento, ContrasenaCertificadoPruebas);

        CancelarDocumentoAdministrativamente(llaveDocumento);
    }

    private tLlaveDoc CrearFacturaPrueba(string observacionesDocumento)
    {
        _logger.LogInformation("Creando factura.");
        var documento = new Documento();
        documento.ConceptoDocumento = _conceptoDocumentoRepository.BuscarPorCodigo(CodigoConceptoFacturaPruebas);
        tLlaveDoc siguienteFolio = _documentoService.BuscarSiguienteSerieYFolio(documento.ConceptoDocumento.CCODIGOCONCEPTO);
        documento.CSERIEDOCUMENTO = siguienteFolio.aSerie;
        documento.CFOLIO = siguienteFolio.aFolio;
        documento.CFECHA = DateTime.Today;
        documento.ClienteProveedor = _clienteProveedorRepository.BuscarPorCodigo(CodigoClientePruebas);
        documento.CREFERENCIA = "Referencia doc";
        documento.FormaPago = FormaPago._03;
        documento.MetodoPago = MetodoPago.PPD;
        documento.COBSERVACIONES = observacionesDocumento;
        tDocumento documentoSdk = documento.ToTDocumento();
        _logger.LogInformation("Creando documento.");
        long startTime = Stopwatch.GetTimestamp();
        int documentoId = _documentoService.Crear(documentoSdk);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        // Actualizar datos que no son parte de la estructura tDocumento
        var datosDocumento = new Dictionary<string, string>
        {
            { nameof(admDocumentos.COBSERVACIONES), documento.COBSERVACIONES },
            { nameof(admDocumentos.CMETODOPAG), documento.CMETODOPAG },
            { nameof(admDocumentos.CCANTPARCI), documento.CCANTPARCI.ToString() }
        };

        _logger.LogInformation("Actualizando documento.");
        startTime = Stopwatch.GetTimestamp();
        _documentoService.Actualizar(documentoId, datosDocumento);
        elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        var movimiento = new Movimiento();
        movimiento.Producto = _productoRepository.BuscarPorCodigo(CodigoProductoPruebas);
        movimiento.CUNIDADES = 1;
        movimiento.CPRECIO = 100;
        movimiento.CREFERENCIA = "Referencia mov";
        movimiento.Almacen = _almacenRepository.BuscarPorCodigo(CodigoAlmacenPruebas);
        movimiento.CTEXTOEXTRA1 = "Texto Extra 1";
        movimiento.CTEXTOEXTRA2 = "Texto Extra 2";
        movimiento.COBSERVAMOV = "Observaciones Movimiento";
        tMovimiento movimientoSdk = movimiento.ToTMovimiento();
        _logger.LogInformation("Creando movimiento.");
        startTime = Stopwatch.GetTimestamp();
        int movimientoId = _movimientoService.Crear(documentoId, movimientoSdk);
        elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        // Actualizar datos que no son parte de la estructura tMovimiento
        var datosMovimiento = new Dictionary<string, string>
        {
            { nameof(admMovimientos.CTEXTOEXTRA1), movimiento.CTEXTOEXTRA1 },
            { nameof(admMovimientos.CTEXTOEXTRA2), movimiento.CTEXTOEXTRA2 },
            { nameof(admMovimientos.COBSERVAMOV), movimiento.COBSERVAMOV }
        };

        _logger.LogInformation("Actualizando movimiento.");
        startTime = Stopwatch.GetTimestamp();
        _movimientoService.Actualizar(movimientoId, datosMovimiento);
        elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        return documento.ToTLlaveDoc();
    }

    private Documento? BuscarDocumentoPorLlave(tLlaveDoc llaveDocumento)
    {
        _logger.LogInformation("Buscando documento por llave: {LlaveDocumento}", llaveDocumento);
        long startTime = Stopwatch.GetTimestamp();
        Documento? documento = _documentoRepository.BuscarPorLlave(llaveDocumento);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (documento is not null)
        {
            CargarDatosRelacionados(documento);
            LogDocumento(documento);
        }
        else
        {
            _logger.LogWarning("No se encontro el documento con llave {LlaveDocumento}", llaveDocumento);
        }

        return documento;
    }

    private List<Documento> BuscarPorFiltro(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto, string codigoCliente)
    {
        _logger.LogInformation(
            "Buscando documentos por filtro: FechaInicio: {FechaInicio}, FechaFin: {FechaFin}, CodigoConcepto: {CodigoConcepto}, CodigoCliente: {CodigoCliente}",
            fechaInicio,
            fechaFin,
            codigoConcepto,
            codigoCliente);

        long startTime = Stopwatch.GetTimestamp();
        List<Documento> documentos = _documentoRepository
            .TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(fechaInicio, fechaFin, codigoConcepto, codigoCliente)
            .ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (Documento documento in documentos)
            CargarDatosRelacionados(documento);

        foreach (Documento documento in documentos)
            LogDocumento(documento);

        return documentos;
    }

    private List<DocumentoDto> BuscarPorFiltroUtilizandoDto(DateTime fechaInicio,
                                                            DateTime fechaFin,
                                                            string codigoConcepto,
                                                            string codigoCliente)
    {
        _logger.LogInformation(
            "Buscando documentos por filtro utilizando DTOs: FechaInicio: {FechaInicio}, FechaFin: {FechaFin}, CodigoConcepto: {CodigoConcepto}, CodigoCliente: {CodigoCliente}",
            fechaInicio,
            fechaFin,
            codigoConcepto,
            codigoCliente);

        long startTime = Stopwatch.GetTimestamp();
        List<DocumentoDto> documentos = _documentoDtoRepository
            .TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(fechaInicio, fechaFin, codigoConcepto, codigoCliente)
            .ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (DocumentoDto? documento in documentos)
            LogDocumento(documento);

        return documentos;
    }

    private void BorrarDocumento(tLlaveDoc llaveDoc)
    {
        _logger.LogInformation("Borrando documento.");

        long startTime = Stopwatch.GetTimestamp();
        _documentoService.Eliminar(llaveDoc);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
    }

    private tLlaveDoc CrearAbonoPrueba()
    {
        _logger.LogInformation("Creando abono.");
        tLlaveDoc siguienteFolio = _documentoService.BuscarSiguienteSerieYFolio(CodigoConceptoAbonoPruebas);
        var tDocumento = new tDocumento
        {
            aCodConcepto = siguienteFolio.aCodConcepto,
            aSerie = siguienteFolio.aSerie,
            aFolio = siguienteFolio.aFolio,
            aCodigoCteProv = CodigoClientePruebas,
            aFecha = DateTime.Today.ToSdkFecha(),
            aNumMoneda = 1,
            aTipoCambio = 1,
            aImporte = ImporteAbonoPruebas
        };

        long startTime = Stopwatch.GetTimestamp();
        int documentoPagoId = _documentoService.CrearCargoAbono(tDocumento);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        Documento documentoPago = _documentoRepository.BuscarPorId(documentoPagoId);
        return documentoPago.ToTLlaveDoc();
    }

    private void SaldarDocumento(tLlaveDoc documentoPagar, tLlaveDoc documentoPago)
    {
        _logger.LogInformation("Saldando documento.");
        long startTime = Stopwatch.GetTimestamp();
        _documentoService.SaldarDocumento(documentoPagar, documentoPago, DateTime.Today, ImporteAbonoPruebas, Moneda.PesoMexicano.Id);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
    }

    private void TimbrarDocumento(tLlaveDoc llaveDocumento, string contrasenaCertificado)
    {
        _logger.LogInformation("Timbrando documento.");
        long startTime = Stopwatch.GetTimestamp();
        _documentoService.Timbrar(llaveDocumento, contrasenaCertificado);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
    }

    private void CrearDocumentoDigital(tLlaveDoc llaveDocumento, TipoArchivoDigital tipo, string rutaPlantilla)
    {
        _logger.LogInformation("Creando documento digital.");
        long startTime = Stopwatch.GetTimestamp();
        _documentoService.GenerarDocumentoDigital(llaveDocumento.aCodConcepto,
            llaveDocumento.aSerie,
            llaveDocumento.aFolio,
            tipo,
            rutaPlantilla);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        //string? rutaArchivo = ArchivoDigitalHelper.GenerarRutaArchivoDigital(tipo, rutaEmpresa, "FAP", "28");
        //_logger.LogInformation("Ruta: {Ruta}", rutaArchivo);
    }

    private void CancelarDocumento(tLlaveDoc llaveDoc)
    {
        _logger.LogInformation("Cancelando documento.");
        long startTime = Stopwatch.GetTimestamp();
        _documentoService.Cancelar(llaveDoc, ContrasenaCertificadoPruebas, MotivoCancelacionPruebas, UuidReemplazoPruebas);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
    }

    private void CancelarDocumentoAdministrativamente(tLlaveDoc llaveDoc)
    {
        _logger.LogInformation("Cancelando documento administrativamente.");
        long startTime = Stopwatch.GetTimestamp();
        _documentoService.CancelarAdministrativamente(llaveDoc);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
    }

    private void LogDocumento(Documento documento)
    {
        _logger.LogInformation("Fecha: {Fecha:d}, Concepto: {Concepto}, Serie: {Serie}, Folio: {Folio}, Cliente: {Cliente}, Total: {Total}",
            documento.CFECHA,
            documento.ConceptoDocumento.CNOMBRECONCEPTO,
            documento.CSERIEDOCUMENTO,
            documento.CFOLIO,
            documento.ClienteProveedor.CRAZONSOCIAL,
            documento.CTOTAL);

        foreach (Movimiento movimiento in documento.Movimientos)
        {
            _logger.LogInformation("- Producto: {Producto}, Unidades: {Unidades}, Precio: {Precio}, Total:{Total}",
                movimiento.Producto.CNOMBREPRODUCTO,
                movimiento.CUNIDADES,
                movimiento.CPRECIO,
                movimiento.CTOTAL);
        }
    }

    private void LogDocumento(DocumentoDto documento)
    {
        _logger.LogInformation("Fecha: {Fecha:d}, Concepto: {Concepto}, Serie: {Serie}, Folio: {Folio}, Cliente: {Cliente}, Total: {Total}",
            documento.CFECHA,
            documento.CIDCONCEPTODOCUMENTO,
            documento.CSERIEDOCUMENTO,
            documento.CFOLIO,
            documento.CRAZONSOCIAL,
            documento.CTOTAL);
    }

    private void CargarDatosRelacionados(Documento documento)
    {
        documento.ConceptoDocumento = _conceptoDocumentoRepository.BuscarPorId(documento.CIDCONCEPTODOCUMENTO);
        documento.ClienteProveedor = _clienteProveedorRepository.BuscarPorId(documento.CIDCLIENTEPROVEEDOR);
        documento.Movimientos = _movimientoRepository.TraerPorDocumentoId(documento.CIDDOCUMENTO).ToList();

        foreach (Movimiento movimiento in documento.Movimientos)
            movimiento.Producto = _productoRepository.BuscarPorId(movimiento.CIDPRODUCTO);
    }
}

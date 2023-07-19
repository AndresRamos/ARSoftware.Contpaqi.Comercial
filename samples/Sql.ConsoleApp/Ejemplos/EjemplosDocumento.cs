using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosDocumento
{
    private readonly IDocumentoRepository<admDocumentos> _documentoRepository;
    private readonly ILogger<EjemplosDocumento> _logger;

    public EjemplosDocumento(IDocumentoRepository<admDocumentos> documentoRepository, ILogger<EjemplosDocumento> logger)
    {
        _documentoRepository = documentoRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de documentos.");

        BuscarPorId(1);

        BuscarPorLlave("400", "FAP", "1");

        BuscarPorLlave(new LlaveDocumento("400", "FAP", 1));

        BuscarSiguienteSerieYFolio("400");

        var fechaInicio = new DateTime(DateTime.Today.Year, 1, 1);
        DateTime fechaFin = DateTime.Today;
        TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(fechaInicio, fechaFin, "400", "CTE001");

        TraerTodo();
    }

    private void BuscarPorId(int id)
    {
        _logger.LogInformation("Buscando documento con Id: {Id}", id);

        long startTime = Stopwatch.GetTimestamp();

        admDocumentos? documento = _documentoRepository.BuscarPorId(id);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (documento is not null)
            LogDocumento(documento);
        else
            _logger.LogInformation("No se encontro el documento con Id: {Id}", id);
    }

    private void BuscarPorLlave(string codigoConcepto, string serie, string folio)
    {
        _logger.LogInformation("Buscando documento con Concepto: {Concepto}, Serie: {Serie}, Folio: {Folio}", codigoConcepto, serie, folio);

        long startTime = Stopwatch.GetTimestamp();

        admDocumentos? documento = _documentoRepository.BuscarPorLlave(codigoConcepto, serie, folio);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (documento is not null)
            LogDocumento(documento);
        else
        {
            _logger.LogInformation("No se encontro el documento con Concepto: {Concepto}, Serie: {Serie}, Folio: {Folio}", codigoConcepto,
                serie, folio);
        }
    }

    private void BuscarPorLlave(LlaveDocumento llaveDocumento)
    {
        _logger.LogInformation("Buscando documento con Concepto: {Concepto}, Serie: {Serie}, Folio: {Folio}", llaveDocumento.CodigoConcepto,
            llaveDocumento.Serie, llaveDocumento.Folio);

        long startTime = Stopwatch.GetTimestamp();

        admDocumentos? documento = _documentoRepository.BuscarPorLlave(llaveDocumento);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (documento is not null)
            LogDocumento(documento);
        else
        {
            _logger.LogInformation("No se encontro el documento con Concepto: {Concepto}, Serie: {Serie}, Folio: {Folio}",
                llaveDocumento.CodigoConcepto, llaveDocumento.Serie, llaveDocumento.Folio);
        }
    }

    private void BuscarSiguienteSerieYFolio(string codigoConcepto)
    {
        _logger.LogInformation("Buscando siguiente serie y folio para el concepto: {Concepto}", codigoConcepto);

        long startTime = Stopwatch.GetTimestamp();

        LlaveDocumento? siguienteFolio = _documentoRepository.BuscarSiguienteSerieYFolio(codigoConcepto);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (siguienteFolio is not null)
        {
            _logger.LogInformation("El siguiente folio del concepto {Concepto} es Serie: {Serie}, Folio: {Folio}", codigoConcepto,
                siguienteFolio.Serie, siguienteFolio.Folio);
        }
        else
            _logger.LogInformation("No se encontro el siguiente serie y folio para el concepto: {Concepto}", codigoConcepto);
    }

    private void TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto,
        string codigoClienteProveedor)
    {
        _logger.LogInformation(
            "Buscando documentos con FechaInicio: {FechaInicio}, FechaFin: {FechaFin}, Concepto: {Concepto}, ClienteProveedor: {ClienteProveedor}",
            fechaInicio, fechaFin, codigoConcepto, codigoClienteProveedor);

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admDocumentos> documentos = _documentoRepository.TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(fechaInicio,
            fechaFin, codigoConcepto, codigoClienteProveedor);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admDocumentos documento in documentos) LogDocumento(documento);
    }

    private void TraerTodo()
    {
        _logger.LogInformation("Buscando todos los documentos.");

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admDocumentos> documentos = _documentoRepository.TraerTodo();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admDocumentos documento in documentos) LogDocumento(documento);
    }

    private void LogDocumento(admDocumentos documento)
    {
        _logger.LogInformation("Id: {Id}, Concepto: {Concepto}, Serie: {Serie}, Folio: {Folio}, Fecha: {Fecha:d}, ClienteId: {ClienteId}",
            documento.CIDDOCUMENTO, documento.CIDCONCEPTODOCUMENTO, documento.CSERIEDOCUMENTO, documento.CFOLIO, documento.CFECHA,
            documento.CIDCLIENTEPROVEEDOR);
    }
}
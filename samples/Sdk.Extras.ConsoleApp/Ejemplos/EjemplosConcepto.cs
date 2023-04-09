using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using Microsoft.Extensions.Logging;
using Sdk.Extras.ConsoleApp.Dtos;

namespace Sdk.Extras.ConsoleApp.Ejemplos;

public sealed class EjemplosConcepto
{
    private const int IdPrueba = 1; // Id del concepto Cotizacion
    private const string CodigoPrueba = "4"; // Codigo del concepto de Factura Crédito
    private readonly IConceptoDocumentoRepository<ConceptoDto> _conceptoDocumentoDtoRepository;
    private readonly IConceptoDocumentoRepository<ConceptoDocumento> _conceptoDocumentoRepository;
    private readonly ILogger<EjemplosConcepto> _logger;

    public EjemplosConcepto(IConceptoDocumentoRepository<ConceptoDocumento> conceptoDocumentoRepository,
                            ILogger<EjemplosConcepto> logger,
                            IConceptoDocumentoRepository<ConceptoDto> conceptoDocumentoDtoRepository)
    {
        _conceptoDocumentoRepository = conceptoDocumentoRepository;
        _logger = logger;
        _conceptoDocumentoDtoRepository = conceptoDocumentoDtoRepository;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo pruebas de conceptos.");

        BuscarTodosLosConceptos();

        BuscarTodosLosConceptosUtilizandoDto();

        BuscarConceptosPorDocumentoModelo(DocumentoModelo.Factura);

        BuscarConceptoPorId(IdPrueba);

        BuscarPorCodigo(CodigoPrueba);
    }

    private void BuscarTodosLosConceptos()
    {
        _logger.LogInformation("Buscando todos los conceptos.");
        long startTime = Stopwatch.GetTimestamp();
        List<ConceptoDocumento> conceptos = _conceptoDocumentoRepository.TraerTodo().ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroConceptos} conceptos.", conceptos.Count);
        foreach (ConceptoDocumento concepto in conceptos)
            LogConcepto(concepto);
    }

    private void BuscarTodosLosConceptosUtilizandoDto()
    {
        _logger.LogInformation("Buscando todos los conceptos utilizando un DTO.");
        long startTime = Stopwatch.GetTimestamp();
        List<ConceptoDto> conceptos = _conceptoDocumentoDtoRepository.TraerTodo().ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroConceptos} conceptos.", conceptos.Count);
        foreach (ConceptoDto concepto in conceptos)
            LogConcepto(concepto);
    }

    private void BuscarConceptosPorDocumentoModelo(DocumentoModelo documentoModelo)
    {
        _logger.LogInformation("Buscando conceptos por documento modelo: {Id}.", documentoModelo.Descripcion);
        long startTime = Stopwatch.GetTimestamp();
        List<ConceptoDocumento> conceptos = _conceptoDocumentoRepository.TraerPorDocumentoModeloId(documentoModelo.Id).ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroConceptos} conceptos.", conceptos.Count);
        foreach (ConceptoDocumento? concepto in conceptos)
            LogConcepto(concepto);
    }

    private void BuscarConceptoPorId(int conceptoId)
    {
        _logger.LogInformation("Buscando concepto por id: {Id}.", conceptoId);
        long startTime = Stopwatch.GetTimestamp();
        ConceptoDocumento? concepto = _conceptoDocumentoRepository.BuscarPorId(conceptoId);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        if (concepto is not null)
            LogConcepto(concepto);
        else
            _logger.LogInformation("No se encontro el concepto con id {ConceptoId}", conceptoId);
    }

    private void BuscarPorCodigo(string conceptoCodigo)
    {
        _logger.LogInformation("Buscando concepto por codigo: {Id}.", conceptoCodigo);
        long startTime = Stopwatch.GetTimestamp();
        ConceptoDocumento? concepto = _conceptoDocumentoRepository.BuscarPorCodigo(conceptoCodigo);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        if (concepto is not null)
            LogConcepto(concepto);
        else
            _logger.LogInformation("No se encontro el concepto con id {ConceptoCodigo}", conceptoCodigo);
    }

    private void LogConcepto(ConceptoDocumento conceptoDocumento)
    {
        _logger.LogInformation("Id: {Id}, Codigo: {Codigo}, Nombre: {Nombre}, DocumentoModelo: {DocumentoModelo}",
            conceptoDocumento.CIDCONCEPTODOCUMENTO,
            conceptoDocumento.CCODIGOCONCEPTO,
            conceptoDocumento.CNOMBRECONCEPTO,
            DocumentoModelo.FromId(conceptoDocumento.CIDDOCUMENTODE).Descripcion);
    }

    private void LogConcepto(ConceptoDto conceptoDocumento)
    {
        _logger.LogInformation("Id: {Id}, Codigo: {Codigo}, Nombre: {Nombre}, DocumentoModelo: {DocumentoModelo}",
            conceptoDocumento.CIDCONCEPTODOCUMENTO,
            conceptoDocumento.CCODIGOCONCEPTO,
            conceptoDocumento.CNOMBRECONCEPTO,
            DocumentoModelo.FromId(conceptoDocumento.CIDDOCUMENTODE).Descripcion);
    }
}

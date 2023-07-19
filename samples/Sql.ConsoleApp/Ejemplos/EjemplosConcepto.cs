using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosConcepto
{
    private readonly IConceptoDocumentoRepository<admConceptos> _conceptoDocumentoRepository;
    private readonly ILogger<EjemplosConcepto> _logger;

    public EjemplosConcepto(IConceptoDocumentoRepository<admConceptos> conceptoDocumentoRepository, ILogger<EjemplosConcepto> logger)
    {
        _conceptoDocumentoRepository = conceptoDocumentoRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de conceptos.");

        BuscarPorCodigo("01");

        BuscarPorId(1);

        TraerPorDocumentoModeloId(4);

        TraerTodo();
    }

    private void BuscarPorCodigo(string codigo)
    {
        _logger.LogInformation("Buscando concepto con codigo {Codigo}", codigo);

        long startTime = Stopwatch.GetTimestamp();

        admConceptos? concepto = _conceptoDocumentoRepository.BuscarPorCodigo(codigo);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (concepto is not null)
            LogConcepto(concepto);
        else
            _logger.LogInformation("No se encontro el concepto con codigo: {Codigo}", codigo);
    }

    private void BuscarPorId(int id)
    {
        _logger.LogInformation("Buscando concepto con Id: {Id}.", id);

        long startTime = Stopwatch.GetTimestamp();

        admConceptos? concepto = _conceptoDocumentoRepository.BuscarPorId(id);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (concepto is not null)
            LogConcepto(concepto);
        else
            _logger.LogInformation("No se encontro el concepto con Id: {Id}", id);
    }

    private void TraerPorDocumentoModeloId(int id)
    {
        _logger.LogInformation("Buscando conceptos con DocumentoModeloId: {Id}.", id);

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admConceptos> conceptos = _conceptoDocumentoRepository.TraerPorDocumentoModeloId(id);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admConceptos concepto in conceptos) LogConcepto(concepto);
    }

    private void TraerTodo()
    {
        _logger.LogInformation("Buscando todos los conceptos.");

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admConceptos> conceptos = _conceptoDocumentoRepository.TraerTodo();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admConceptos concepto in conceptos) LogConcepto(concepto);
    }

    private void LogConcepto(admConceptos concepto)
    {
        _logger.LogInformation("Codigo: {Codigo}, Nombre: {Nombre}, DocumentoModeloId: {DocumentoModeloId}", concepto.CCODIGOCONCEPTO,
            concepto.CNOMBRECONCEPTO, concepto.CIDDOCUMENTODE);
    }
}
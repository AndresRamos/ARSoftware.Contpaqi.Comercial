using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using Microsoft.Extensions.Logging;

namespace Sdk.Extras.ConsoleApp.Catalogos;

public sealed class ConceptoSdk
{
    private readonly IConceptoDocumentoRepository<ConceptoDocumento> _conceptoDocumentoRepository;
    private readonly ILogger<ConceptoSdk> _logger;

    public ConceptoSdk(IConceptoDocumentoRepository<ConceptoDocumento> conceptoDocumentoRepository, ILogger<ConceptoSdk> logger)
    {
        _conceptoDocumentoRepository = conceptoDocumentoRepository;
        _logger = logger;
    }

    public IEnumerable<ConceptoDocumento> BuscarTodo()
    {
        _logger.LogInformation("BuscarTodo()");
        return _conceptoDocumentoRepository.TraerTodo().ToList();
    }

    public IEnumerable<ConceptoDocumento> BuscarPorTipo(int id)
    {
        _logger.LogInformation("BuscarPorTipo({id})", id);
        return _conceptoDocumentoRepository.TraerPorDocumentoModeloId(id);
    }

    public ConceptoDocumento BuscarPorId(int id)
    {
        _logger.LogInformation("BuscarPorId({id})", id);
        return _conceptoDocumentoRepository.BuscarPorId(id);
    }

    public ConceptoDocumento BuscarPorCodigo(string codigo)
    {
        _logger.LogInformation("BuscarPorCodiog({codigo})", codigo);
        return _conceptoDocumentoRepository.BuscarPorCodigo(codigo);
    }

    public void LogConceptos(IEnumerable<ConceptoDocumento> conceptos)
    {
        _logger.LogInformation("CONCEPTOS #: {NUMERO}", conceptos.Count());
        foreach (ConceptoDocumento conceptoDocumento in conceptos)
            LogConcepto(conceptoDocumento);
    }

    public void LogConcepto(ConceptoDocumento conceptoDocumento)
    {
        _logger.LogInformation("{Id} - {Codigo} - {Nombre} - {DocumentoModelo}",
            conceptoDocumento.CIDCONCEPTODOCUMENTO,
            conceptoDocumento.CCODIGOCONCEPTO,
            conceptoDocumento.CNOMBRECONCEPTO,
            DocumentoModelo.FromId(conceptoDocumento.CIDDOCUMENTODE).Descripcion);
    }
}

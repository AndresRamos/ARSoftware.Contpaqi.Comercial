using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

public sealed class BuscarConceptosDocumentoDtoConRepositorio : IBuscarConceptosDocumento
{
    private readonly IConceptoDocumentoRepository<ConceptoDocumentoDto> _conceptoDocumentoRepository;
    private readonly ILogger<BuscarConceptosDocumentoDtoConRepositorio> _logger;

    public BuscarConceptosDocumentoDtoConRepositorio(IConceptoDocumentoRepository<ConceptoDocumentoDto> conceptoDocumentoRepository,
        ILogger<BuscarConceptosDocumentoDtoConRepositorio> logger)
    {
        _conceptoDocumentoRepository = conceptoDocumentoRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorCodigo()
    {
        var codigoConcepto = "PRUEBA";

        ConceptoDocumentoDto? concepto = _conceptoDocumentoRepository.BuscarPorCodigo(codigoConcepto);

        _logger.LogInformation("{@Concepto}", concepto);
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idConcepto = 1;

        ConceptoDocumentoDto? concepto = _conceptoDocumentoRepository.BuscarPorId(idConcepto);

        _logger.LogInformation("{@Concepto}", concepto);
    }

    /// <inheritdoc />
    public void TraerPorDocumentoModeloId()
    {
        var idDocumentoModelo = 1;

        List<ConceptoDocumentoDto> conceptos = _conceptoDocumentoRepository.TraerPorDocumentoModeloId(idDocumentoModelo);

        _logger.LogInformation("{@Conceptos}", conceptos);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<ConceptoDocumentoDto> conceptos = _conceptoDocumentoRepository.TraerTodo();

        _logger.LogInformation("{@Conceptos}", conceptos);
    }
}

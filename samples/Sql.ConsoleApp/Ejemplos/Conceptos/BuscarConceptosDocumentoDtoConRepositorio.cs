using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarConceptosDocumentoDtoConRepositorio : IBuscarConceptosDocumento
{
    private readonly ConceptoDocumentoSqlRepository<ConceptoDocumentoDto> _conceptoDocumentoRepository;
    private readonly ILogger<BuscarConceptosDocumentoDtoConRepositorio> _logger;

    public BuscarConceptosDocumentoDtoConRepositorio(ConceptoDocumentoSqlRepository<ConceptoDocumentoDto> conceptoDocumentoRepository,
        ILogger<BuscarConceptosDocumentoDtoConRepositorio> logger)
    {
        _conceptoDocumentoRepository = conceptoDocumentoRepository;
        _logger = logger;
    }

    public void BuscarPorCodigo(string codigoConcepto)
    {
        ConceptoDocumentoDto? concepto = _conceptoDocumentoRepository.BuscarPorCodigo(codigoConcepto);

        _logger.LogInformation("{@Concepto}", concepto);
    }

    public void BuscarPorId(int idConcepto)
    {
        ConceptoDocumentoDto? concepto = _conceptoDocumentoRepository.BuscarPorId(idConcepto);

        _logger.LogInformation("{@Concepto}", concepto);
    }

    public void TraerPorDocumentoModeloId(int idDocumentoModelo)
    {
        List<ConceptoDocumentoDto> conceptos = _conceptoDocumentoRepository.TraerPorDocumentoModeloId(idDocumentoModelo);

        _logger.LogInformation("{@Conceptos}", conceptos);
    }

    public void TraerTodo()
    {
        List<ConceptoDocumentoDto> conceptos = _conceptoDocumentoRepository.TraerTodo();

        _logger.LogInformation("{@Conceptos}", conceptos);
    }

    public void CorrerEjemplos()
    {
        BuscarPorCodigo("01");

        BuscarPorId(1);

        TraerPorDocumentoModeloId(4);

        TraerTodo();
    }
}
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarConceptosDocumentoConRepositorio : IBuscarConceptosDocumento
{
    private readonly ConceptoDocumentoSqlRepository _conceptoDocumentoRepository;
    private readonly ILogger<BuscarConceptosDocumentoConRepositorio> _logger;

    public BuscarConceptosDocumentoConRepositorio(ConceptoDocumentoSqlRepository conceptoDocumentoRepository,
        ILogger<BuscarConceptosDocumentoConRepositorio> logger)
    {
        _conceptoDocumentoRepository = conceptoDocumentoRepository;
        _logger = logger;
    }

    public void BuscarPorCodigo(string codigoConcepto)
    {
        admConceptos? concepto = _conceptoDocumentoRepository.BuscarPorCodigo(codigoConcepto);

        _logger.LogInformation("{@Concepto}", concepto);
    }

    public void BuscarPorId(int idConcepto)
    {
        admConceptos? concepto = _conceptoDocumentoRepository.BuscarPorId(idConcepto);

        _logger.LogInformation("{@Concepto}", concepto);
    }

    public void TraerPorDocumentoModeloId(int idDocumentoModelo)
    {
        List<admConceptos> conceptos = _conceptoDocumentoRepository.TraerPorDocumentoModeloId(idDocumentoModelo);

        _logger.LogInformation("{@Conceptos}", conceptos);
    }

    public void TraerTodo()
    {
        List<admConceptos> conceptos = _conceptoDocumentoRepository.TraerTodo();

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
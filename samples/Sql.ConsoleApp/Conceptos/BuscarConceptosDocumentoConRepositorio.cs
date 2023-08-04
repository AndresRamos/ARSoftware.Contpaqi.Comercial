using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

public sealed class BuscarConceptosDocumentoConRepositorio : IBuscarConceptosDocumento
{
    private readonly IConceptoDocumentoRepository<admConceptos> _conceptoDocumentoRepository;
    private readonly ILogger<BuscarConceptosDocumentoConRepositorio> _logger;

    public BuscarConceptosDocumentoConRepositorio(IConceptoDocumentoRepository<admConceptos> conceptoDocumentoRepository,
        ILogger<BuscarConceptosDocumentoConRepositorio> logger)
    {
        _conceptoDocumentoRepository = conceptoDocumentoRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorCodigo()
    {
        var codigoConcepto = "PRUEBA";

        admConceptos? concepto = _conceptoDocumentoRepository.BuscarPorCodigo(codigoConcepto);

        _logger.LogInformation("{@Concepto}", concepto);
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idConcepto = 1;

        admConceptos? concepto = _conceptoDocumentoRepository.BuscarPorId(idConcepto);

        _logger.LogInformation("{@Concepto}", concepto);
    }

    /// <inheritdoc />
    public void TraerPorDocumentoModeloId()
    {
        var idDocumentoModelo = 1;

        List<admConceptos> conceptos = _conceptoDocumentoRepository.TraerPorDocumentoModeloId(idDocumentoModelo);

        _logger.LogInformation("{@Conceptos}", conceptos);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<admConceptos> conceptos = _conceptoDocumentoRepository.TraerTodo();

        _logger.LogInformation("{@Conceptos}", conceptos);
    }
}

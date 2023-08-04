using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

public sealed class BuscarDocumentosConRepositorio : IBuscarDocumentos
{
    private readonly IDocumentoRepository<admDocumentos> _documentoRepository;
    private readonly ILogger<BuscarDocumentosConRepositorio> _logger;

    public BuscarDocumentosConRepositorio(IDocumentoRepository<admDocumentos> documentoRepository,
        ILogger<BuscarDocumentosConRepositorio> logger)
    {
        _documentoRepository = documentoRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorConceptoSerieFolio()
    {
        var codigoConcepto = "PRUEBA";
        var serie = "PRUEBA";
        double folio = 1;

        admDocumentos? documento = _documentoRepository.BuscarPorLlave(codigoConcepto, serie, folio);

        _logger.LogInformation("{@Documento}", documento);
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idDocumento = 1;

        admDocumentos? documento = _documentoRepository.BuscarPorId(idDocumento);

        _logger.LogInformation("{@Documento}", documento);
    }

    /// <inheritdoc />
    public void BuscarPorLlave()
    {
        var llaveDocumento = new LlaveDocumento { ConceptoCodigo = "PRUEBA", Serie = "PRUEBA", Folio = 1 };

        admDocumentos? documento = _documentoRepository.BuscarPorLlave(llaveDocumento);

        _logger.LogInformation("{@Documento}", documento);
    }

    /// <inheritdoc />
    public void BuscarSiguienteSerieYFolio()
    {
        var codigoConcepto = "PRUEBA";

        LlaveDocumento siguienteFolio = _documentoRepository.BuscarSiguienteSerieYFolio(codigoConcepto);

        _logger.LogInformation("{@SiguienteFolio}", siguienteFolio);
    }

    /// <inheritdoc />
    public void TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor()
    {
        DateTime fechaInicio = DateTime.Today;
        DateTime fechaFin = DateTime.Today;
        var codigoConcepto = "PRUEBA";
        var codigoClienteProveedor = "PRUEBA";

        List<admDocumentos> documentos = _documentoRepository.TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(fechaInicio,
            fechaFin, codigoConcepto, codigoClienteProveedor);

        _logger.LogInformation("{@Documentos}", documentos);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<admDocumentos> documentos = _documentoRepository.TraerTodo();

        _logger.LogInformation("{@Documentos}", documentos);
    }
}

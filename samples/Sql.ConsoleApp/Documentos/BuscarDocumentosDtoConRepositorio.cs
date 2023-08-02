using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

public sealed class BuscarDocumentosDtoConRepositorio : IBuscarDocumentos
{
    private readonly IDocumentoRepository<DocumentoDto> _documentoRepository;
    private readonly ILogger<BuscarDocumentosDtoConRepositorio> _logger;

    public BuscarDocumentosDtoConRepositorio(IDocumentoRepository<DocumentoDto> documentoRepository,
        ILogger<BuscarDocumentosDtoConRepositorio> logger)
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

        DocumentoDto? documento = _documentoRepository.BuscarPorLlave(codigoConcepto, serie, folio);

        _logger.LogInformation("{@Documento}", documento);
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idDocumento = 1;

        DocumentoDto? documento = _documentoRepository.BuscarPorId(idDocumento);

        _logger.LogInformation("{@Documento}", documento);
    }

    /// <inheritdoc />
    public void BuscarPorLlave()
    {
        var llaveDocumento = new LlaveDocumento { ConceptoCodigo = "PRUEBA", Serie = "PRUEBA", Folio = 1 };

        DocumentoDto? documento = _documentoRepository.BuscarPorLlave(llaveDocumento);

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

        List<DocumentoDto> documentos = _documentoRepository.TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(fechaInicio,
            fechaFin, codigoConcepto, codigoClienteProveedor);

        _logger.LogInformation("{@Documentos}", documentos);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<DocumentoDto> documentos = _documentoRepository.TraerTodo();

        _logger.LogInformation("{@Documentos}", documentos);
    }
}

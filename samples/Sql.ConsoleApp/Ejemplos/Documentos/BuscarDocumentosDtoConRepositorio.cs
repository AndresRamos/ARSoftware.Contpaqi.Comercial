using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarDocumentosDtoConRepositorio : IBuscarDocumentos
{
    private readonly DocumentoSqlRepository<DocumentoDto> _documentoRepository;
    private readonly ILogger<BuscarDocumentosDtoConRepositorio> _logger;

    public BuscarDocumentosDtoConRepositorio(DocumentoSqlRepository<DocumentoDto> documentoRepository,
        ILogger<BuscarDocumentosDtoConRepositorio> logger)
    {
        _documentoRepository = documentoRepository;
        _logger = logger;
    }

    public void BuscarPorId(int idDocumento)
    {
        DocumentoDto? documento = _documentoRepository.BuscarPorId(idDocumento);

        _logger.LogInformation("{@Documento}", documento);
    }

    public void BuscarPorLlave(string codigoConcepto, string serie, double folio)
    {
        DocumentoDto? documento = _documentoRepository.BuscarPorLlave(codigoConcepto, serie, folio);

        _logger.LogInformation("{@Documento}", documento);
    }

    public void BuscarPorLlave(LlaveDocumento llaveDocumento)
    {
        DocumentoDto? documento = _documentoRepository.BuscarPorLlave(llaveDocumento);

        _logger.LogInformation("{@Documento}", documento);
    }

    public void BuscarSiguienteSerieYFolio(string codigoConcepto)
    {
        LlaveDocumento siguienteFolio = _documentoRepository.BuscarSiguienteSerieYFolio(codigoConcepto);

        _logger.LogInformation("{@SiguienteFolio}", siguienteFolio);
    }

    public void TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto,
        string codigoClienteProveedor)
    {
        List<DocumentoDto> documentos = _documentoRepository.TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(fechaInicio,
            fechaFin, codigoConcepto, codigoClienteProveedor);

        _logger.LogInformation("{@Documentos}", documentos);
    }

    public void TraerTodo()
    {
        List<DocumentoDto> documentos = _documentoRepository.TraerTodo();

        _logger.LogInformation("{@Documentos}", documentos);
    }

    public void CorrerEjemplos()
    {
        BuscarPorId(1);

        BuscarPorLlave("400", "FAP", 1);

        BuscarPorLlave(new LlaveDocumento("400", "FAP", 1));

        BuscarSiguienteSerieYFolio("400");

        var fechaInicio = new DateTime(DateTime.Today.Year, 1, 1);
        DateTime fechaFin = DateTime.Today;
        TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(fechaInicio, fechaFin, "400", "CTE001");

        TraerTodo();
    }
}
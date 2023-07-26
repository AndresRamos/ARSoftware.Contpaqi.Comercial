using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarDocumentosModeloDtoConRepositorio : IBuscarDocumentosModelo
{
    private readonly DocumentoModeloSqlRepository<DocumentoModeloDto> _documentoModeloRepository;
    private readonly ILogger<BuscarDocumentosModeloDtoConRepositorio> _logger;

    public BuscarDocumentosModeloDtoConRepositorio(DocumentoModeloSqlRepository<DocumentoModeloDto> documentoModeloRepository,
        ILogger<BuscarDocumentosModeloDtoConRepositorio> logger)
    {
        _documentoModeloRepository = documentoModeloRepository;
        _logger = logger;
    }

    public void TraerTodo()
    {
        List<DocumentoModeloDto> documentosModelo = _documentoModeloRepository.TraerTodo();

        _logger.LogInformation("{@DocumentosModelo}", documentosModelo);
    }

    public void CorrerEjemplos()
    {
        TraerTodo();
    }
}
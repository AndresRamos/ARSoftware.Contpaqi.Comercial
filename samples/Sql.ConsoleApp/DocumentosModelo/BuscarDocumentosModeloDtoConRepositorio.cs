using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

public sealed class BuscarDocumentosModeloDtoConRepositorio : IBuscarDocumentosModelo
{
    private readonly IDocumentoRepository<DocumentoModeloDto> _documentoModeloRepository;
    private readonly ILogger<BuscarDocumentosModeloDtoConRepositorio> _logger;

    public BuscarDocumentosModeloDtoConRepositorio(IDocumentoRepository<DocumentoModeloDto> documentoModeloRepository,
        ILogger<BuscarDocumentosModeloDtoConRepositorio> logger)
    {
        _documentoModeloRepository = documentoModeloRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<DocumentoModeloDto> documentosModelo = _documentoModeloRepository.TraerTodo();

        _logger.LogInformation("{@DocumentosModelo}", documentosModelo);
    }
}

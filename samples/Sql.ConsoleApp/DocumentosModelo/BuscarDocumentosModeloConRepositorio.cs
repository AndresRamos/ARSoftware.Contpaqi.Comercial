using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

public sealed class BuscarDocumentosModeloConRepositorio : IBuscarDocumentosModelo
{
    private readonly IDocumentoModeloRepository<admDocumentosModelo> _documentoModeloRepository;
    private readonly ILogger<BuscarDocumentosModeloConRepositorio> _logger;

    public BuscarDocumentosModeloConRepositorio(IDocumentoModeloRepository<admDocumentosModelo> documentoModeloRepository,
        ILogger<BuscarDocumentosModeloConRepositorio> logger)
    {
        _documentoModeloRepository = documentoModeloRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<admDocumentosModelo> documentosModelo = _documentoModeloRepository.TraerTodo();

        _logger.LogInformation("{@DocumentosModelo}", documentosModelo);
    }
}

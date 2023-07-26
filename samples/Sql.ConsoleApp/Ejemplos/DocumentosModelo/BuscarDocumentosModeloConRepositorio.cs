using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarDocumentosModeloConRepositorio : IBuscarDocumentosModelo
{
    private readonly DocumentoModeloSqlRepository _documentoModeloRepository;
    private readonly ILogger<BuscarDocumentosModeloConRepositorio> _logger;

    public BuscarDocumentosModeloConRepositorio(DocumentoModeloSqlRepository documentoModeloRepository,
        ILogger<BuscarDocumentosModeloConRepositorio> logger)
    {
        _documentoModeloRepository = documentoModeloRepository;
        _logger = logger;
    }

    public void TraerTodo()
    {
        List<admDocumentosModelo> documentosModelo = _documentoModeloRepository.TraerTodo();

        _logger.LogInformation("{@DocumentosModelo}", documentosModelo);
    }

    public void CorrerEjemplos()
    {
        TraerTodo();
    }
}
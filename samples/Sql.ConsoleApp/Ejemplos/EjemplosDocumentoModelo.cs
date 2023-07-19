using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosDocumentoModelo
{
    private readonly IDocumentoModeloRepository<admDocumentosModelo> _documentoModeloRepository;
    private readonly ILogger<EjemplosDocumentoModelo> _logger;

    public EjemplosDocumentoModelo(IDocumentoModeloRepository<admDocumentosModelo> documentoModeloRepository,
        ILogger<EjemplosDocumentoModelo> logger)
    {
        _documentoModeloRepository = documentoModeloRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de documentos modelo.");

        TraerTodo();
    }

    private void TraerTodo()
    {
        _logger.LogInformation("Buscando todos los documentos modelo.");

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admDocumentosModelo> documentosModelo = _documentoModeloRepository.TraerTodo();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admDocumentosModelo documentoModelo in documentosModelo) LogDocumentoModelo(documentoModelo);
    }

    private void LogDocumentoModelo(admDocumentosModelo documentosModelo)
    {
        _logger.LogInformation("Id: {Id}, Descripcion: {Descripcion}", documentosModelo.CIDDOCUMENTODE, documentosModelo.CDESCRIPCION);
    }
}
using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosAlmacen
{
    private readonly IAlmacenRepository<admAlmacenes> _almacenRepository;
    private readonly ILogger<EjemplosAlmacen> _logger;

    public EjemplosAlmacen(IAlmacenRepository<admAlmacenes> almacenRepository, ILogger<EjemplosAlmacen> logger)
    {
        _almacenRepository = almacenRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de almacenes.");

        BuscarPorCodigo("01");

        BuscarPorId(1);

        TraerTodo();
    }

    private void BuscarPorCodigo(string codigo)
    {
        _logger.LogInformation("Buscando almacen con Codigo: {Codigo}.", codigo);

        long startTime = Stopwatch.GetTimestamp();

        admAlmacenes? almacen = _almacenRepository.BuscarPorCodigo(codigo);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (almacen is not null)
            LogAlmacen(almacen);
        else
            _logger.LogInformation("No se encontro el almacen con codigo: {Codigo}", codigo);
    }

    private void BuscarPorId(int id)
    {
        _logger.LogInformation("Buscando almacen con Id: {Id}.", id);

        long startTime = Stopwatch.GetTimestamp();

        admAlmacenes? almacen = _almacenRepository.BuscarPorId(id);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (almacen is not null)
            LogAlmacen(almacen);
        else
            _logger.LogInformation("No se encontro el almacen con id: {Id}", id);
    }

    private void TraerTodo()
    {
        _logger.LogInformation("Buscando todos los almacenes.");

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admAlmacenes> almacenes = _almacenRepository.TraerTodo();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admAlmacenes almacen in almacenes) LogAlmacen(almacen);
    }

    private void LogAlmacen(admAlmacenes almacen)
    {
        _logger.LogInformation("Codigo: {Codigo}, Nombre: {Nombre}", almacen.CCODIGOALMACEN, almacen.CNOMBREALMACEN);
    }
}
using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosClasificacion
{
    private readonly IClasificacionRepository<admClasificaciones> _clasificacionRepository;
    private readonly ILogger<EjemplosClasificacion> _logger;

    public EjemplosClasificacion(IClasificacionRepository<admClasificaciones> clasificacionRepository,
        ILogger<EjemplosClasificacion> logger)
    {
        _clasificacionRepository = clasificacionRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de clasificaciones.");

        BuscarPorId(1);

        BuscarPorTipoYNumero(TipoClasificacion.Producto, NumeroClasificacion.Uno);

        TraerPorTipo(TipoClasificacion.Producto);

        TraerTodo();
    }

    private void BuscarPorId(int idClasificacion)
    {
        _logger.LogInformation("Buscando clasificacion con Id: {Id}.", idClasificacion);

        long startTime = Stopwatch.GetTimestamp();

        admClasificaciones? clasificacion = _clasificacionRepository.BuscarPorId(idClasificacion);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (clasificacion is not null)
            LogClasificacion(clasificacion);
        else
            _logger.LogInformation("No se encontro la clasificacion con Id: {Id}", idClasificacion);
    }

    private void BuscarPorTipoYNumero(TipoClasificacion tipo, NumeroClasificacion numero)
    {
        _logger.LogInformation("Buscando clasificacion con Tipo: {Tipo} y Numero: {Numero}.", tipo, numero);

        long startTime = Stopwatch.GetTimestamp();

        admClasificaciones? clasificacion = _clasificacionRepository.BuscarPorTipoYNumero(tipo, numero);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (clasificacion is not null)
            LogClasificacion(clasificacion);
        else
            _logger.LogInformation("No se encontro la clasificacion con Tipo: {Tipo} y Numero: {Numero}", tipo, numero);
    }

    private void TraerPorTipo(TipoClasificacion tipo)
    {
        _logger.LogInformation("Buscando clasificaciones con Tipo: {Tipo}.", tipo);

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admClasificaciones> clasificaciones = _clasificacionRepository.TraerPorTipo(tipo);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admClasificaciones clasificacion in clasificaciones) LogClasificacion(clasificacion);
    }

    private void TraerTodo()
    {
        _logger.LogInformation("Buscando todas las clasificaciones.");

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admClasificaciones> clasificaciones = _clasificacionRepository.TraerTodo();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admClasificaciones clasificacion in clasificaciones) LogClasificacion(clasificacion);
    }

    private void LogClasificacion(admClasificaciones clasificacion)
    {
        _logger.LogInformation("Id: {Id}, Nombre: {Nombre}", clasificacion.CIDCLASIFICACION, clasificacion.CNOMBRECLASIFICACION);
    }
}
using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosUnidadMedida
{
    private readonly ILogger<EjemplosUnidadMedida> _logger;
    private readonly IUnidadMedidaRepository<admUnidadesMedidaPeso> _unidadMedidaRepository;

    public EjemplosUnidadMedida(IUnidadMedidaRepository<admUnidadesMedidaPeso> unidadMedidaRepository, ILogger<EjemplosUnidadMedida> logger)
    {
        _unidadMedidaRepository = unidadMedidaRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de unidades de medida.");

        BuscarPorId(1);

        BuscarPorNombre("SERVICIO");

        TraerTodo();
    }

    private void BuscarPorId(int id)
    {
        _logger.LogInformation("Buscando unidad de medida con Id: {Id}", id);

        long startTime = Stopwatch.GetTimestamp();

        admUnidadesMedidaPeso? unidad = _unidadMedidaRepository.BuscarPorId(id);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (unidad is not null)
            LogUnidad(unidad);
        else
            _logger.LogInformation("No se encontro la unidad de medida con Id: {Id}", id);
    }

    private void BuscarPorNombre(string nombre)
    {
        _logger.LogInformation("Buscando unidad de medida con Nombre: {Nombre}", nombre);

        long startTime = Stopwatch.GetTimestamp();

        admUnidadesMedidaPeso? unidad = _unidadMedidaRepository.BuscarPorNombre(nombre);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (unidad is not null)
            LogUnidad(unidad);
        else
            _logger.LogInformation("No se encontro la unidad de medida con Nombre: {Nombre}", nombre);
    }

    private void TraerTodo()
    {
        _logger.LogInformation("Buscando todas las unidades de medida");

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admUnidadesMedidaPeso> unidades = _unidadMedidaRepository.TraerTodo();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admUnidadesMedidaPeso unidad in unidades) LogUnidad(unidad);
    }

    private void LogUnidad(admUnidadesMedidaPeso unidad)
    {
        _logger.LogInformation("Id: {Id}, Abreviatura: {Abreviatura}, Nombre: {Nombre}, UnidadSAT: {UnidadSAT}", unidad.CIDUNIDAD,
            unidad.CABREVIATURA, unidad.CNOMBREUNIDAD, unidad.CCLAVEINT);
    }
}
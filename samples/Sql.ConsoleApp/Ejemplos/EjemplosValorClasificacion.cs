using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosValorClasificacion
{
    private readonly ILogger<EjemplosValorClasificacion> _logger;
    private readonly IValorClasificacionRepository<admClasificacionesValores> _valorClasificacionRepository;

    public EjemplosValorClasificacion(IValorClasificacionRepository<admClasificacionesValores> valorClasificacionRepository,
        ILogger<EjemplosValorClasificacion> logger)
    {
        _valorClasificacionRepository = valorClasificacionRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de valores de clasificacion.");

        BuscarPorId(1);

        BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacion.Producto, NumeroClasificacion.Uno, "PRO");

        TraerPorClasificacionId(25);

        TraerPorClasificacionTipoYNumero(TipoClasificacion.Producto, NumeroClasificacion.Uno);

        TraerTodo();
    }

    private void BuscarPorId(int id)
    {
        _logger.LogInformation("Buscando valor de clasificacion con Id: {Id}", id);

        long startTime = Stopwatch.GetTimestamp();

        admClasificacionesValores? valor = _valorClasificacionRepository.BuscarPorId(id);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (valor is not null)
            LogValor(valor);
        else
            _logger.LogInformation("No se encontro el valor de clasificacion con Id: {Id}", id);
    }

    private void BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion,
        string codigoValorClasificacion)
    {
        _logger.LogInformation(
            "Buscando valor de clasificacion con TipoClasificacion: {TipoClasificacion}, NumeroClasificacion: {NumeroClasificacion}, CodigoValorClasificacion: {CodigoValorClasificacion}",
            tipoClasificacion, numeroClasificacion, codigoValorClasificacion);

        long startTime = Stopwatch.GetTimestamp();

        admClasificacionesValores? valor = _valorClasificacionRepository.BuscarPorTipoClasificacionNumeroYCodigo(tipoClasificacion,
            numeroClasificacion, codigoValorClasificacion);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (valor is not null)
            LogValor(valor);
        else
        {
            _logger.LogInformation(
                "No se encontro el valor de clasificacion con TipoClasificacion: {TipoClasificacion}, NumeroClasificacion: {NumeroClasificacion}, CodigoValorClasificacion: {CodigoValorClasificacion}",
                tipoClasificacion, numeroClasificacion, codigoValorClasificacion);
        }
    }

    private void TraerPorClasificacionId(int idClasificacion)
    {
        _logger.LogInformation("Buscando valores de clasificacion con IdClasificacion: {IdClasificacion}", idClasificacion);

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admClasificacionesValores> valores = _valorClasificacionRepository.TraerPorClasificacionId(idClasificacion);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admClasificacionesValores valor in valores) LogValor(valor);
    }

    private void TraerPorClasificacionTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion)
    {
        _logger.LogInformation(
            "Buscando valores de clasificacion con TipoClasificacion: {TipoClasificacion}, NumeroClasificacion: {NumeroClasificacion}",
            tipoClasificacion, numeroClasificacion);

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admClasificacionesValores> valores =
            _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(tipoClasificacion, numeroClasificacion);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admClasificacionesValores valor in valores) LogValor(valor);
    }

    private void TraerTodo()
    {
        _logger.LogInformation("Buscando todos los valores de clasificacion");

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admClasificacionesValores> valores = _valorClasificacionRepository.TraerTodo();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admClasificacionesValores valor in valores) LogValor(valor);
    }

    private void LogValor(admClasificacionesValores valor)
    {
        _logger.LogInformation("Id: {Id}, IdClasificaion: {IdClasificaion},  Codigo: {Codigo}, Valor: {Valor}", valor.CIDVALORCLASIFICACION,
            valor.CIDCLASIFICACION, valor.CCODIGOVALORCLASIFICACION, valor.CVALORCLASIFICACION);
    }
}
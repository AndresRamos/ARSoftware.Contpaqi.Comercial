using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;

namespace Sdk.Extras.ConsoleApp;

public class BuscarExistenciasConRepositorio
{
    private readonly IExistenciasRepository _existenciasRepository;
    private readonly ILogger<BuscarExistenciasConRepositorio> _logger;

    public BuscarExistenciasConRepositorio(IExistenciasRepository existenciasRepository, ILogger<BuscarExistenciasConRepositorio> logger)
    {
        _existenciasRepository = existenciasRepository;
        _logger = logger;
    }

    public void BuscaExistencias()
    {
        var codigoProducto = "PRUEBACARA";
        var codigoAlmacen = "PRUEBA";
        DateOnly fecha = DateOnly.FromDateTime(DateTime.Today);

        double existencias = _existenciasRepository.BuscaExistencias(codigoProducto, codigoAlmacen, fecha);

        _logger.LogInformation("Existencias: {Existencias}", existencias);
    }

    public void BuscaExistenciasConCaracteristicas()
    {
        var codigoProducto = "PRUEBACARA";
        var codigoAlmacen = "PRUEBA";
        DateOnly fecha = DateOnly.FromDateTime(DateTime.Today);

        var abreviaturaValorCaracteristica1 = "UV1";
        var abreviaturaValorCaracteristica2 = "DV1";
        var abreviaturaValorCaracteristica3 = "";

        double existencias = _existenciasRepository.BuscaExistenciasConCaracteristicas(codigoProducto, codigoAlmacen, fecha,
            abreviaturaValorCaracteristica1, abreviaturaValorCaracteristica2, abreviaturaValorCaracteristica3);

        _logger.LogInformation("Existencias: {Existencias}", existencias);
    }

    public void BuscaExistenciasConCapas()
    {
        var codigoProducto = "PUEBAPEDIM";
        var codigoAlmacen = "PRUEBA";
        //var pedimento = "11 11 1111 1111111";
        var pedimento = "18 53 3892 8000827";
        var lote = "";

        double existencias = _existenciasRepository.BuscaExistenciasConCapas(codigoProducto, codigoAlmacen, pedimento, lote);

        _logger.LogInformation("Existencias: {Existencias}", existencias);
    }
}

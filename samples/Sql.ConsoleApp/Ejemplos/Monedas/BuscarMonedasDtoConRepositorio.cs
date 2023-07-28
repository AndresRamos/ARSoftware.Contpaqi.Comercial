using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarMonedasDtoConRepositorio : IBuscarMonedas
{
    private readonly ILogger<BuscarMonedasDtoConRepositorio> _logger;
    private readonly MonedaSqlRepository<MonedaDto> _monedaRepository;

    public BuscarMonedasDtoConRepositorio(MonedaSqlRepository<MonedaDto> monedaRepository, ILogger<BuscarMonedasDtoConRepositorio> logger)
    {
        _monedaRepository = monedaRepository;
        _logger = logger;
    }

    public void BuscarPorId(int idMoneda)
    {
        MonedaDto? moneda = _monedaRepository.BuscarPorId(idMoneda);

        _logger.LogInformation("{@Moneda}", moneda);
    }

    public void BuscarPorNombre(string nombreMoneda)
    {
        MonedaDto? moneda = _monedaRepository.BuscarPorNombre(nombreMoneda);

        _logger.LogInformation("{@Moneda}", moneda);
    }

    public void TraerTodo()
    {
        List<MonedaDto> monedas = _monedaRepository.TraerTodo();

        _logger.LogInformation("{@Monedas}", monedas);
    }

    public void CorrerEjemplos()
    {
        BuscarPorId(1);

        BuscarPorNombre("Peso Mexicano");

        TraerTodo();
    }
}
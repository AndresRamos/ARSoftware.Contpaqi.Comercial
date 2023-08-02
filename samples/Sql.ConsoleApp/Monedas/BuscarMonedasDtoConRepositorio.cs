using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

public sealed class BuscarMonedasDtoConRepositorio : IBuscarMonedas
{
    private readonly ILogger<BuscarMonedasDtoConRepositorio> _logger;
    private readonly IMonedaRepository<MonedaDto> _monedaRepository;

    public BuscarMonedasDtoConRepositorio(IMonedaRepository<MonedaDto> monedaRepository, ILogger<BuscarMonedasDtoConRepositorio> logger)
    {
        _monedaRepository = monedaRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idMoneda = 1;

        MonedaDto? moneda = _monedaRepository.BuscarPorId(idMoneda);

        _logger.LogInformation("{@Moneda}", moneda);
    }

    /// <inheritdoc />
    public void BuscarPorNombre()
    {
        var nombreMoneda = "Peso Mexicano";

        MonedaDto? moneda = _monedaRepository.BuscarPorNombre(nombreMoneda);

        _logger.LogInformation("{@Moneda}", moneda);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<MonedaDto> monedas = _monedaRepository.TraerTodo();

        _logger.LogInformation("{@Monedas}", monedas);
    }
}

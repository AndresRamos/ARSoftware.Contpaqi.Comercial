using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

public sealed class BuscarMonedasConRepositorio : IBuscarMonedas
{
    private readonly ILogger<BuscarMonedasConRepositorio> _logger;
    private readonly IMonedaRepository<admMonedas> _monedaRepository;

    public BuscarMonedasConRepositorio(IMonedaRepository<admMonedas> monedaRepository, ILogger<BuscarMonedasConRepositorio> logger)
    {
        _monedaRepository = monedaRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idMoneda = 1;

        admMonedas? moneda = _monedaRepository.BuscarPorId(idMoneda);

        _logger.LogInformation("{@Moneda}", moneda);
    }

    /// <inheritdoc />
    public void BuscarPorNombre()
    {
        var nombreMoneda = "Peso Mexicano";

        admMonedas? moneda = _monedaRepository.BuscarPorNombre(nombreMoneda);

        _logger.LogInformation("{@Moneda}", moneda);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<admMonedas> monedas = _monedaRepository.TraerTodo();

        _logger.LogInformation("{@Monedas}", monedas);
    }
}

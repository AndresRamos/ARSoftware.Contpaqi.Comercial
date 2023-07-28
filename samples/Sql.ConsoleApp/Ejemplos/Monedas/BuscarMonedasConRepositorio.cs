using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarMonedasConRepositorio : IBuscarMonedas
{
    private readonly ILogger<BuscarMonedasConRepositorio> _logger;
    private readonly MonedaSqlRepository _monedaRepository;

    public BuscarMonedasConRepositorio(MonedaSqlRepository monedaRepository, ILogger<BuscarMonedasConRepositorio> logger)
    {
        _monedaRepository = monedaRepository;
        _logger = logger;
    }

    public void BuscarPorId(int idMoneda)
    {
        admMonedas? moneda = _monedaRepository.BuscarPorId(idMoneda);

        _logger.LogInformation("{@Moneda}", moneda);
    }

    public void BuscarPorNombre(string nombreMoneda)
    {
        admMonedas? moneda = _monedaRepository.BuscarPorNombre(nombreMoneda);

        _logger.LogInformation("{@Moneda}", moneda);
    }

    public void TraerTodo()
    {
        List<admMonedas> monedas = _monedaRepository.TraerTodo();

        _logger.LogInformation("{@Monedas}", monedas);
    }

    public void CorrerEjemplos()
    {
        BuscarPorId(1);

        BuscarPorNombre("Peso Mexicano");

        TraerTodo();
    }
}
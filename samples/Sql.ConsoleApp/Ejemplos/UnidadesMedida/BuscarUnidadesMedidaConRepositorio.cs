using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarUnidadesMedidaConRepositorio : IBuscarUnidadesMedida
{
    private readonly ILogger<BuscarUnidadesMedidaConRepositorio> _logger;
    private readonly UnidadMedidaSqlRepository _unidadMedidaRepository;

    public BuscarUnidadesMedidaConRepositorio(UnidadMedidaSqlRepository unidadMedidaRepository,
        ILogger<BuscarUnidadesMedidaConRepositorio> logger)
    {
        _unidadMedidaRepository = unidadMedidaRepository;
        _logger = logger;
    }

    public void BuscarPorId(int id)
    {
        admUnidadesMedidaPeso? unidad = _unidadMedidaRepository.BuscarPorId(id);

        _logger.LogInformation("{@Unidad}", unidad);
    }

    public void BuscarPorNombre(string nombre)
    {
        admUnidadesMedidaPeso? unidad = _unidadMedidaRepository.BuscarPorNombre(nombre);
        _logger.LogInformation("{@Unidad}", unidad);
    }

    public void TraerTodo()
    {
        List<admUnidadesMedidaPeso> unidades = _unidadMedidaRepository.TraerTodo();
        _logger.LogInformation("{@Unidades}", unidades);
    }

    public void CorrerEjemplos()
    {
        BuscarPorId(1);

        BuscarPorNombre("SERVICIO");

        TraerTodo();
    }
}
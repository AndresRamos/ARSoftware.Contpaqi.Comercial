using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarUnidadesMedidaDtoConRepositorio : IBuscarUnidadesMedida
{
    private readonly ILogger<BuscarUnidadesMedidaDtoConRepositorio> _logger;
    private readonly UnidadMedidaSqlRepository<UnidadMedidaDto> _unidadMedidaRepository;

    public BuscarUnidadesMedidaDtoConRepositorio(UnidadMedidaSqlRepository<UnidadMedidaDto> unidadMedidaRepository,
        ILogger<BuscarUnidadesMedidaDtoConRepositorio> logger)
    {
        _unidadMedidaRepository = unidadMedidaRepository;
        _logger = logger;
    }

    public void BuscarPorId(int id)
    {
        UnidadMedidaDto? unidad = _unidadMedidaRepository.BuscarPorId(id);

        _logger.LogInformation("{@Unidad}", unidad);
    }

    public void BuscarPorNombre(string nombre)
    {
        UnidadMedidaDto? unidad = _unidadMedidaRepository.BuscarPorNombre(nombre);
        _logger.LogInformation("{@Unidad}", unidad);
    }

    public void TraerTodo()
    {
        List<UnidadMedidaDto> unidades = _unidadMedidaRepository.TraerTodo();
        _logger.LogInformation("{@Unidades}", unidades);
    }

    public void CorrerEjemplos()
    {
        BuscarPorId(1);

        BuscarPorNombre("SERVICIO");

        TraerTodo();
    }
}
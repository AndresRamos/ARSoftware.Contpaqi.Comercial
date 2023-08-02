using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sdk.Extras.ConsoleApp;

public sealed class BuscarUnidadesMedidaDtoConRepositorio : IBuscarUnidadesMedida
{
    private readonly ILogger<BuscarUnidadesMedidaDtoConRepositorio> _logger;
    private readonly IUnidadMedidaRepository<UnidadMedidaDto> _unidadMedidaRepository;

    public BuscarUnidadesMedidaDtoConRepositorio(IUnidadMedidaRepository<UnidadMedidaDto> unidadMedidaRepository,
        ILogger<BuscarUnidadesMedidaDtoConRepositorio> logger)
    {
        _unidadMedidaRepository = unidadMedidaRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var id = 1;

        UnidadMedidaDto? unidad = _unidadMedidaRepository.BuscarPorId(id);

        _logger.LogInformation("{@Unidad}", unidad);
    }

    /// <inheritdoc />
    public void BuscarPorNombre()
    {
        var nombre = "PZA";

        UnidadMedidaDto? unidad = _unidadMedidaRepository.BuscarPorNombre(nombre);

        _logger.LogInformation("{@Unidad}", unidad);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<UnidadMedidaDto> unidades = _unidadMedidaRepository.TraerTodo();

        _logger.LogInformation("{@Unidades}", unidades);
    }
}

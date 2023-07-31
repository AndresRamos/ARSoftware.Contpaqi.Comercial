using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

public sealed class BuscarUnidadesMedidaConRepositorio : IBuscarUnidadesMedida
{
    private readonly ILogger<BuscarUnidadesMedidaConRepositorio> _logger;
    private readonly IUnidadMedidaRepository<admUnidadesMedidaPeso> _unidadMedidaRepository;

    public BuscarUnidadesMedidaConRepositorio(IUnidadMedidaRepository<admUnidadesMedidaPeso> unidadMedidaRepository,
        ILogger<BuscarUnidadesMedidaConRepositorio> logger)
    {
        _unidadMedidaRepository = unidadMedidaRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var id = 1;

        admUnidadesMedidaPeso? unidad = _unidadMedidaRepository.BuscarPorId(id);

        _logger.LogInformation("{@Unidad}", unidad);
    }

    /// <inheritdoc />
    public void BuscarPorNombre()
    {
        var nombre = "PZA";

        admUnidadesMedidaPeso? unidad = _unidadMedidaRepository.BuscarPorNombre(nombre);

        _logger.LogInformation("{@Unidad}", unidad);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<admUnidadesMedidaPeso> unidades = _unidadMedidaRepository.TraerTodo();

        _logger.LogInformation("{@Unidades}", unidades);
    }
}

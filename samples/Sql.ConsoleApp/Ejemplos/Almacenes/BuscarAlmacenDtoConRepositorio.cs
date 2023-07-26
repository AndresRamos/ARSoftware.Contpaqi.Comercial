using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarAlmacenDtoConRepositorio : IBuscarAlmacen
{
    private readonly AlmacenSqlRepository<AlmacenDto> _almacenRepository;
    private readonly ILogger<BuscarAlmacenConRepositorio> _logger;

    public BuscarAlmacenDtoConRepositorio(AlmacenSqlRepository<AlmacenDto> almacenRepository, ILogger<BuscarAlmacenConRepositorio> logger)
    {
        _almacenRepository = almacenRepository;
        _logger = logger;
    }

    //// <inheritdoc />
    public void BuscarPorCodigo(string codigo)
    {
        AlmacenDto? almacen = _almacenRepository.BuscarPorCodigo(codigo);

        if (almacen is not null)
            _logger.LogInformation("{@Almacen}", almacen);
        else
            _logger.LogWarning("No se encontro el almacén con código: {Codigo}", codigo);
    }

    //// <inheritdoc />
    public void BuscarPorId(int id)
    {
        AlmacenDto? almacen = _almacenRepository.BuscarPorId(id);

        if (almacen is not null)
            _logger.LogInformation("{@Almacen}", almacen);
        else
            _logger.LogWarning("No se encontro el almacén con id: {Id}", id);
    }

    //// <inheritdoc />
    public void TraerTodo()
    {
        List<AlmacenDto> almacenes = _almacenRepository.TraerTodo();

        if (almacenes.Any())
        {
            foreach (AlmacenDto almacen in almacenes) _logger.LogInformation("{@Almacen}", almacen);
        }
        else
            _logger.LogWarning("No se encontraron almacenes.");
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de almacenes.");

        BuscarPorCodigo("01");

        BuscarPorId(1);

        TraerTodo();
    }
}
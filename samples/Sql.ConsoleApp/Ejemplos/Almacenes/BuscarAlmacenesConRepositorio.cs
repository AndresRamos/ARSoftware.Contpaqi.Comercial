using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarAlmacenesConRepositorio : IBuscarAlmacenes
{
    private readonly AlmacenSqlRepository _almacenRepository;
    private readonly ILogger<BuscarAlmacenesConRepositorio> _logger;

    public BuscarAlmacenesConRepositorio(AlmacenSqlRepository almacenRepository, ILogger<BuscarAlmacenesConRepositorio> logger)
    {
        _almacenRepository = almacenRepository;
        _logger = logger;
    }

    //// <inheritdoc />
    public void BuscarPorCodigo(string codigoAlmacen)
    {
        admAlmacenes? almacen = _almacenRepository.BuscarPorCodigo(codigoAlmacen);

        _logger.LogInformation("{@Almacen}", almacen);
    }

    //// <inheritdoc />
    public void BuscarPorId(int idAlmacen)
    {
        admAlmacenes? almacen = _almacenRepository.BuscarPorId(idAlmacen);

        _logger.LogInformation("{@Almacen}", almacen);
    }

    //// <inheritdoc />
    public void TraerTodo()
    {
        List<admAlmacenes> almacenes = _almacenRepository.TraerTodo();

        _logger.LogInformation("{@Almacenes}", almacenes);
    }

    public void CorrerEjemplos()
    {
        BuscarPorCodigo("01");

        BuscarPorId(1);

        TraerTodo();
    }
}
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarClasificacionesConRepositorio : IBuscarClasificaciones
{
    private readonly ClasificacionSqlRepository _clasificacionRepository;
    private readonly ILogger<BuscarClasificacionesConRepositorio> _logger;

    public BuscarClasificacionesConRepositorio(ClasificacionSqlRepository clasificacionRepository,
        ILogger<BuscarClasificacionesConRepositorio> logger)
    {
        _clasificacionRepository = clasificacionRepository;
        _logger = logger;
    }

    public void BuscarPorId(int idClasificacion)
    {
        admClasificaciones? clasificacion = _clasificacionRepository.BuscarPorId(idClasificacion);

        _logger.LogInformation("{@Clasificacion}", clasificacion);
    }

    public void BuscarPorTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion)
    {
        admClasificaciones? clasificacion = _clasificacionRepository.BuscarPorTipoYNumero(tipoClasificacion, numeroClasificacion);

        _logger.LogInformation("{@Clasificacion}", clasificacion);
    }

    public void TraerPorTipo(TipoClasificacion tipoClasificacion)
    {
        List<admClasificaciones> clasificaciones = _clasificacionRepository.TraerPorTipo(tipoClasificacion);

        _logger.LogInformation("{@Clasificaciones}", clasificaciones);
    }

    public void TraerTodo()
    {
        List<admClasificaciones> clasificaciones = _clasificacionRepository.TraerTodo();

        _logger.LogInformation("{@Clasificaciones}", clasificaciones);
    }

    public void CorrerEjemplos()
    {
        BuscarPorId(1);

        BuscarPorTipoYNumero(TipoClasificacion.Producto, NumeroClasificacion.Uno);

        TraerPorTipo(TipoClasificacion.Producto);

        TraerTodo();
    }
}
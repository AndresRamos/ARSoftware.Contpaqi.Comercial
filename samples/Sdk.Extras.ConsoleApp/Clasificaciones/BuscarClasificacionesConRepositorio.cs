using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sdk.Extras.ConsoleApp;

public sealed class BuscarClasificacionesConRepositorio : IBuscarClasificaciones
{
    private readonly IClasificacionRepository<admClasificaciones> _clasificacionRepository;
    private readonly ILogger<BuscarClasificacionesConRepositorio> _logger;

    public BuscarClasificacionesConRepositorio(IClasificacionRepository<admClasificaciones> clasificacionRepository,
        ILogger<BuscarClasificacionesConRepositorio> logger)
    {
        _clasificacionRepository = clasificacionRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idClasificacion = 1;

        admClasificaciones? clasificacion = _clasificacionRepository.BuscarPorId(idClasificacion);

        _logger.LogInformation("{@Clasificacion}", clasificacion);
    }

    /// <inheritdoc />
    public void BuscarPorTipoYNumero()
    {
        var tipoClasificacion = TipoClasificacion.Producto;
        var numeroClasificacion = NumeroClasificacion.Uno;

        admClasificaciones? clasificacion = _clasificacionRepository.BuscarPorTipoYNumero(tipoClasificacion, numeroClasificacion);

        _logger.LogInformation("{@Clasificacion}", clasificacion);
    }

    /// <inheritdoc />
    public void TraerPorTipo()
    {
        var tipoClasificacion = TipoClasificacion.Producto;

        List<admClasificaciones> clasificaciones = _clasificacionRepository.TraerPorTipo(tipoClasificacion);

        _logger.LogInformation("{@Clasificaciones}", clasificaciones);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<admClasificaciones> clasificaciones = _clasificacionRepository.TraerTodo();

        _logger.LogInformation("{@Clasificaciones}", clasificaciones);
    }
}

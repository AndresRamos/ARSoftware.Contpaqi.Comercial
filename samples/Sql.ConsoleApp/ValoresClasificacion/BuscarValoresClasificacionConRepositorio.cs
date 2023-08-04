using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

public sealed class BuscarValoresClasificacionConRepositorio : IBuscarValoresClasificacion
{
    private readonly ILogger<BuscarValoresClasificacionConRepositorio> _logger;
    private readonly IValorClasificacionRepository<admClasificacionesValores> _valorClasificacionRepository;

    public BuscarValoresClasificacionConRepositorio(IValorClasificacionRepository<admClasificacionesValores> valorClasificacionRepository,
        ILogger<BuscarValoresClasificacionConRepositorio> logger)
    {
        _valorClasificacionRepository = valorClasificacionRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var id = 1;

        admClasificacionesValores? valor = _valorClasificacionRepository.BuscarPorId(id);

        _logger.LogInformation("{@Valor}", valor);
    }

    /// <inheritdoc />
    public void BuscarPorTipoClasificacionNumeroYCodigo()
    {
        var tipoClasificacion = TipoClasificacion.Producto;
        var numeroClasificacion = NumeroClasificacion.Uno;
        var codigoValorClasificacion = "1";

        admClasificacionesValores? valor = _valorClasificacionRepository.BuscarPorTipoClasificacionNumeroYCodigo(tipoClasificacion,
            numeroClasificacion, codigoValorClasificacion);

        _logger.LogInformation("{@Valor}", valor);
    }

    /// <inheritdoc />
    public void TraerPorClasificacionId()
    {
        var idClasificacion = 1;

        List<admClasificacionesValores> valores = _valorClasificacionRepository.TraerPorClasificacionId(idClasificacion);

        _logger.LogInformation("{@Valores}", valores);
    }

    /// <inheritdoc />
    public void TraerPorClasificacionTipoYNumero()
    {
        var tipoClasificacion = TipoClasificacion.Producto;
        var numeroClasificacion = NumeroClasificacion.Uno;

        List<admClasificacionesValores> valores =
            _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(tipoClasificacion, numeroClasificacion);

        _logger.LogInformation("{@Valores}", valores);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<admClasificacionesValores> valores = _valorClasificacionRepository.TraerTodo();

        _logger.LogInformation("{@Valores}", valores);
    }
}

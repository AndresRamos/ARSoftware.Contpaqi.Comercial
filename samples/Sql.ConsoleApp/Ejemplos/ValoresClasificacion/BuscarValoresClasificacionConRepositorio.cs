using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarValoresClasificacionConRepositorio : IBuscarValoresClasificacion
{
    private readonly ILogger<BuscarValoresClasificacionConRepositorio> _logger;
    private readonly ValorClasificacionSqlRepository _valorClasificacionRepository;

    public BuscarValoresClasificacionConRepositorio(ValorClasificacionSqlRepository valorClasificacionRepository,
        ILogger<BuscarValoresClasificacionConRepositorio> logger)
    {
        _valorClasificacionRepository = valorClasificacionRepository;
        _logger = logger;
    }

    public void BuscarPorId(int id)
    {
        admClasificacionesValores? valor = _valorClasificacionRepository.BuscarPorId(id);

        _logger.LogInformation("{@Valor}", valor);
    }

    public void BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion,
        string codigoValorClasificacion)
    {
        admClasificacionesValores? valor = _valorClasificacionRepository.BuscarPorTipoClasificacionNumeroYCodigo(tipoClasificacion,
            numeroClasificacion, codigoValorClasificacion);

        _logger.LogInformation("{@Valor}", valor);
    }

    public void TraerPorClasificacionId(int idClasificacion)
    {
        List<admClasificacionesValores> valores = _valorClasificacionRepository.TraerPorClasificacionId(idClasificacion);

        _logger.LogInformation("{@Valores}", valores);
    }

    public void TraerPorClasificacionTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion)
    {
        List<admClasificacionesValores> valores =
            _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(tipoClasificacion, numeroClasificacion);

        _logger.LogInformation("{@Valores}", valores);
    }

    public void TraerTodo()
    {
        List<admClasificacionesValores> valores = _valorClasificacionRepository.TraerTodo();

        _logger.LogInformation("{@Valores}", valores);
    }

    public void CorrerEjemplos()
    {
        BuscarPorId(1);

        BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacion.Producto, NumeroClasificacion.Uno, "PRO");

        TraerPorClasificacionId(25);

        TraerPorClasificacionTipoYNumero(TipoClasificacion.Producto, NumeroClasificacion.Uno);

        TraerTodo();
    }
}
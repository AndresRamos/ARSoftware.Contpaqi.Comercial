using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace Samples.Common;

public interface IBuscarValoresClasificacion
{
    void BuscarPorId(int id);

    void BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion,
        string codigoValorClasificacion);

    void TraerPorClasificacionId(int idClasificacion);
    void TraerPorClasificacionTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion);
    void TraerTodo();
}
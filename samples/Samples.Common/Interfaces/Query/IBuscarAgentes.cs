using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace Samples.Common;

public interface IBuscarAgentes
{
    void BuscarPorCodigo(string codigoAgente);
    void BuscarPorId(int idAgente);
    void TraerPorTipo(TipoAgente tipoAgente);
    void TraerTodo();
}
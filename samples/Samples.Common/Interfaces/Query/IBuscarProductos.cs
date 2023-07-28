using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace Samples.Common;

public interface IBuscarProductos
{
    void BuscarPorCodigo(string codigoProducto);
    void BuscarPorId(int idProducto);
    void TraerPorTipo(TipoProducto tipoProducto);
    void TraerTodo();
}
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace Samples.Common;

public interface IBuscarClientesProveedores
{
    void BuscarPorCodigo(string codigoCliente);
    void BuscarPorId(int idCliente);
    void TraerClientes();
    void TraerPorTipo(TipoCliente tipoCliente);
    void TraerProveedores();
    void TraerTodo();
}
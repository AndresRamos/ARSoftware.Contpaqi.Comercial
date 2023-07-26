using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace Sql.ConsoleApp.Ejemplos;

internal interface IBuscarClientesProveedores
{
    void BuscarPorCodigo(string codigoCliente);
    void BuscarPorId(int idCliente);
    void TraerClientes();
    void TraerPorTipo(TipoCliente tipoCliente);
    void TraerProveedores();
    void TraerTodo();
}
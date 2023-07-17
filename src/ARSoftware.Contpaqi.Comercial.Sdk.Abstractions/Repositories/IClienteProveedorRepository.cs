using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories
{
    public interface IClienteProveedorRepository<T> where T : class, new()
    {
        T BuscarPorCodigo(string codigoCliente);
        T BuscarPorId(int idCliente);
        IEnumerable<T> TraerClientes();
        IEnumerable<T> TraerPorTipo(TipoCliente tipoCliente);
        IEnumerable<T> TraerProveedores();
        IEnumerable<T> TraerTodo();
    }
}
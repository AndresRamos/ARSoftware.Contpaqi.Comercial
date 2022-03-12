using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
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

using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IClienteProveedorRepository<T> where T : IClienteProveedor
    {
        T BuscarPorId(int idCliente);
        T BuscarPorCodigo(string codigoCliente);
        IEnumerable<T> TraerPorTipo(TipoClienteEnum tipoCliente);
        IEnumerable<T> TraerTodo();
        IEnumerable<T> TraerClientes();
        IEnumerable<T> TraerProveedores();
    }
}
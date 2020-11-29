using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IClienteProveedorRepository<T> where T : IClienteProveedor
    {
        T FindById(int idCliente);
        T FindByCodigo(string codigoCliente);
        IEnumerable<T> GetAllByTipo(TipoClienteEnum tipoCliente);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetClientes();
        IEnumerable<T> GetProveedores();
    }
}
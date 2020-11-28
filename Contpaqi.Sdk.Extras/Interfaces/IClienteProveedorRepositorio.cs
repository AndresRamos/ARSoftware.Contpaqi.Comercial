using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Modelos;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IClienteProveedorRepositorio
    {
        ClienteProveedor BuscarClienteProveedor(int idCliente);
        ClienteProveedor BuscarClienteProveedor(string codigoCliente);
        IEnumerable<ClienteProveedor> TraerClientesProveedores(int tipoCliente);
        IEnumerable<ClienteProveedor> TraerClientesProveedores();
        IEnumerable<ClienteProveedor> TraerClientes();
        IEnumerable<ClienteProveedor> TraerProveedores();
    }
}
using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Modelos;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IClienteProveedorRepositorio
    {
        ClienteProveedor BuscarClienteProveedor(int idCliente,bool buscarObjectosRelacionados);
        ClienteProveedor BuscarClienteProveedor(string codigoCliente,bool buscarObjectosRelacionados);
        IEnumerable<ClienteProveedor> TraerClientesProveedores(int tipoCliente,bool buscarObjectosRelacionados);
        IEnumerable<ClienteProveedor> TraerClientesProveedores(bool buscarObjectosRelacionados);
        IEnumerable<ClienteProveedor> TraerClientes(bool buscarObjectosRelacionados);
        IEnumerable<ClienteProveedor> TraerProveedores(bool buscarObjectosRelacionados);
    }
}
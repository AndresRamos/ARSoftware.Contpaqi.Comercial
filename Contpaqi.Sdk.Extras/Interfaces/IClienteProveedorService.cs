using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IClienteProveedorService
    {
        int Crear(tCteProv clienteProveedor);
        void Actualizar(int idClienteProveedor, Dictionary<string, string> datosClienteProveedor);
        void Eliminar(int idClienteProveedor);
        void Actualizar(tCteProv clienteProveedor);
    }
}
using System.Collections.Generic;
using Contpaqi.Sdk.DatosAbstractos;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IClienteProveedorService
    {
        void Actualizar(int idClienteProveedor, Dictionary<string, string> datosClienteProveedor);
        void Actualizar(string codigoClienteProveedor, Dictionary<string, string> datosClienteProveedor);
        void Actualizar(tCteProv clienteProveedor);
        int Crear(tCteProv clienteProveedor);
        int Crear(Dictionary<string, string> datosClienteProveedor);
        void Eliminar(int idClienteProveedor);
        void Eliminar(string codigoClienteProveedor);
    }
}

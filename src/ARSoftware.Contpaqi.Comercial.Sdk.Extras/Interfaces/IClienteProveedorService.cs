using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface IClienteProveedorService
{
    void Actualizar(int idClienteProveedor, Dictionary<string, string> datosClienteProveedor);
    void Actualizar(string codigoClienteProveedor, Dictionary<string, string> datosClienteProveedor);
    void Actualizar(tCteProv clienteProveedor);
    int Crear(tCteProv clienteProveedor);
    int Crear(Dictionary<string, string> datosClienteProveedor);
    int Crear(ClienteProveedor clienteProveedor);
    void Eliminar(int idClienteProveedor);
    void Eliminar(string codigoClienteProveedor);
}

using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface IProductoService
{
    void Actualizar(string codigoProducto, tProducto producto);
    void Actualizar(int idProducto, Dictionary<string, string> datosProducto);
    void Actualizar(string codigoProducto, Dictionary<string, string> datosProducto);
    int Crear(tProducto producto);
    int Crear(Dictionary<string, string> datosProducto);
    int Crear(Producto producto);
    void Eliminar(int idProducto);
    void Eliminar(string codigoProducto);
}

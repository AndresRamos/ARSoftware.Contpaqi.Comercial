using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Modelos;
using Contpaqi.Sdk.Extras.Modelos.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IProductoRepositorio
    {
        Producto BuscarPorId(int idProducto);
        Producto BuscarPorCodigo(string codigoProducto);
        IEnumerable<Producto> TraerTodo();
        IEnumerable<Producto> TraerPorTipo(TipoProductoEnum tipoProducto);
    }
}
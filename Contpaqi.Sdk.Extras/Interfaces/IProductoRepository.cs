using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IProductoRepository<T> where T : IProducto
    {
        T BuscarPorId(int idProducto);
        T BuscarPorCodigo(string codigoProducto);
        IEnumerable<T> TraerTodo();
        IEnumerable<T> TraerPorTipo(TipoProductoEnum tipoProducto);
    }
}
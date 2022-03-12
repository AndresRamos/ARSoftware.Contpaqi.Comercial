using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IProductoRepository<T> where T : class, new()
    {
        T BuscarPorCodigo(string codigoProducto);
        T BuscarPorId(int idProducto);
        IEnumerable<T> TraerPorTipo(TipoProducto tipoProducto);
        IEnumerable<T> TraerTodo();
    }
}

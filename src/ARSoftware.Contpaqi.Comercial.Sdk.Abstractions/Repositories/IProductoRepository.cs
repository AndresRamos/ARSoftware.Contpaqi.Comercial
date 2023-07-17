using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories
{
    public interface IProductoRepository<T> where T : class, new()
    {
        T BuscarPorCodigo(string codigoProducto);
        T BuscarPorId(int idProducto);
        IEnumerable<T> TraerPorTipo(TipoProducto tipoProducto);
        IEnumerable<T> TraerTodo();
    }
}
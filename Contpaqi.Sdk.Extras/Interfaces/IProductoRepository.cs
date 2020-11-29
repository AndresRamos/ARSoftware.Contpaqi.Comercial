using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IProductoRepository<T> where T : IProducto
    {
        T FindById(int idProducto);
        T FindByCodigo(string codigoProducto);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllByTipo(TipoProductoEnum tipoProducto);
    }
}
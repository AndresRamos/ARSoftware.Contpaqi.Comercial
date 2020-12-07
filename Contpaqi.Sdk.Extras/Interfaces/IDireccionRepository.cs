using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IDireccionRepository<T> where T : IDireccion
    {
        T BuscarPorId(int idDireccion);
        T BuscarPorCliente(string codigoClienteProveedor, byte tipoDireccion);
        T BuscarPorDocumento(int idDocumento, byte tipoDireccion);
        IEnumerable<T> TraerTodo();
        IEnumerable<T> TraerPorTipo(TipoCatalogoDireccion tipoCatalogoDireccion);
        IEnumerable<T> TraerPorTipoYIdCatalogo(TipoCatalogoDireccion tipoCatalogoDireccion, int idCatalogo);
    }
}
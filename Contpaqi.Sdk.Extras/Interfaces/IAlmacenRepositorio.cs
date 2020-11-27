using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Modelos;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IAlmacenRepositorio
    {
        Almacen BuscarAlmacen(int idAlmacen);
        Almacen BuscarAlmacen(string codigoAlmacen);
        List<Almacen> TraerAlmacenes();
    }
}
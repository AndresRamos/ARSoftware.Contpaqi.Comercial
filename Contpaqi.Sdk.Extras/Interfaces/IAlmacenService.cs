using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IAlmacenService
    {
        void Actualizar(int idAlmacen, Dictionary<string, string> datosAlmacen);
        void Actualizar(string codigoAlmacen, Dictionary<string, string> datosAlmacen);
        int Crear(Dictionary<string, string> datosAlmacen);
    }
}

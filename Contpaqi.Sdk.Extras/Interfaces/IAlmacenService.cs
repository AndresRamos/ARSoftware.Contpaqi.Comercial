using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IAlmacenService
    {
        int Crear(Dictionary<string, string> datosAlmacen);
        void Actualizar(int almacenId, Dictionary<string, string> datosAlmacen);
        void Actualizar(string almacenCodigo, Dictionary<string, string> datosAlmacen);
    }
}
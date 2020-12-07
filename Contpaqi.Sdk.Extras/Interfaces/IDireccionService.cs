using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IDireccionService
    {
        int Crear(tDireccion direccion);
        int Crear(Dictionary<string, string> datosDireccion);
        void Actualizar(tDireccion direccion);
        void Actualizar(int idDireccion, Dictionary<string, string> datosDireccion);
    }
}
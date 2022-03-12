using System.Collections.Generic;
using Contpaqi.Sdk.DatosAbstractos;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IDireccionService
    {
        void Actualizar(tDireccion direccion);
        void Actualizar(int idDireccion, Dictionary<string, string> datosDireccion);
        int Crear(tDireccion direccion);
        int Crear(Dictionary<string, string> datosDireccion);
    }
}

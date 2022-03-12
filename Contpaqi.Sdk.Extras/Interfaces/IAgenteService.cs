using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IAgenteService
    {
        void Actualizar(int idAgente, Dictionary<string, string> datosAgente);
        void Actualizar(string codigoAgente, Dictionary<string, string> datosAgente);
        int Crear(Dictionary<string, string> datosAgente);
    }
}

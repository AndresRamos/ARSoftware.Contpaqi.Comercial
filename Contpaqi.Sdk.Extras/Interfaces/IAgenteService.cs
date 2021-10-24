using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IAgenteService
    {
        int Crear(Dictionary<string, string> datosAgente);
        void Actualizar(int agenteId, Dictionary<string, string> datosAgente);
        void Actualizar(string agenteCodigo, Dictionary<string, string> datosAgente);
    }
}
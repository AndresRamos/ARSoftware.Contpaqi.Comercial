using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface IAgenteService
{
    void Actualizar(int idAgente, Dictionary<string, string> datosAgente);
    void Actualizar(string codigoAgente, Dictionary<string, string> datosAgente);
    int Crear(Dictionary<string, string> datosAgente);
    int Crear(Agente agente);
}

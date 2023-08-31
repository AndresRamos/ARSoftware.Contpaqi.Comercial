using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.ConsoleApp;

public class CrearAgente
{
    private readonly IAgenteService _ageteService;

    public CrearAgente(IAgenteService ageteService)
    {
        _ageteService = ageteService;
    }

    public int Crear()
    {
        var agente = new Agente { Codigo = "PRUEBA", Nombre = "AGENTE DE PRUEBAS", Tipo = TipoAgente.VentasCobro };

        agente.DatosExtra.Add(nameof(admAgentes.CCOMISIONVENTAAGENTE), "5"); // Comisión de venta del agente.
        agente.DatosExtra.Add(nameof(admAgentes.CTEXTOEXTRA1), "Texto extra 1"); // Texto extra 1.
        agente.DatosExtra.Add(nameof(admAgentes.CTEXTOEXTRA2), "Texto extra 2"); // Texto extra 2.

        int nuevoAgenteId = _ageteService.Crear(agente);

        return nuevoAgenteId;
    }
}

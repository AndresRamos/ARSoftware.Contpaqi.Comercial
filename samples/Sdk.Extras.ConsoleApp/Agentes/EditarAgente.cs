using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.ConsoleApp;

public class EditarAgente
{
    private readonly IAgenteService _agenteService;

    public EditarAgente(IAgenteService agenteService)
    {
        _agenteService = agenteService;
    }

    public void Editar()
    {
        var codigoAgente = "PRUEBA";

        var datosAgente = new Dictionary<string, string>
        {
            { nameof(admAgentes.CNOMBREAGENTE), "AGENTE DE PRUEBAS MODIFICADO" },
            { nameof(admAgentes.CCOMISIONVENTAAGENTE), "5" },
            { nameof(admAgentes.CTEXTOEXTRA1), "Texto Modificado" },
            { nameof(admAgentes.CTEXTOEXTRA2), "Texto Extra 2" }
        };

        _agenteService.Actualizar(codigoAgente, datosAgente);
    }
}

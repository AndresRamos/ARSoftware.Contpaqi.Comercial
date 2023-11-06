using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.ConsoleApp;

public class EditarUnidadMedida
{
    private readonly IUnidadMedidaService _unidadMedidaService;

    public EditarUnidadMedida(IUnidadMedidaService unidadMedidaService)
    {
        _unidadMedidaService = unidadMedidaService;
    }

    public void Editar()
    {
        var nombreUnidad = "PRUEBA";

        var datosUnidad = new Dictionary<string, string>
        {
            { nameof(admUnidadesMedidaPeso.CABREVIATURA), "KG" },
            { nameof(admUnidadesMedidaPeso.CCLAVEINT), "KGM" }, // CCLAVEINT es la clave SAT
            { nameof(admUnidadesMedidaPeso.CCLAVESAT), "01" } // CCLAVESAT es la clave SAT del complemente de comercio exterior
        };

        _unidadMedidaService.Actualizar(nombreUnidad, datosUnidad);
    }
}

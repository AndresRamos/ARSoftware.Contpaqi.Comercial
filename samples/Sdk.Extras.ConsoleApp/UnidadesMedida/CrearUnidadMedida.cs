using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.ConsoleApp;

public class CrearUnidadMedida
{
    private readonly IUnidadMedidaService _unidadMedidaService;

    public CrearUnidadMedida(IUnidadMedidaService unidadMedidaService)
    {
        _unidadMedidaService = unidadMedidaService;
    }

    public int Crear()
    {
        var unidadMedida = new UnidadMedida
        {
            Nombre = "PRUEBA",
            Abreviatura = "PZA",
            ClaveSat = "H87",
            DatosExtra = new Dictionary<string, string>
            {
                // En la base de datos la columan CCLAVESAT es la clave SAT utilizada por el Complemento de Comercio Exterior
                { nameof(admUnidadesMedidaPeso.CCLAVESAT), "06" }
            }
        };

        return _unidadMedidaService.Crear(unidadMedida);
    }
}

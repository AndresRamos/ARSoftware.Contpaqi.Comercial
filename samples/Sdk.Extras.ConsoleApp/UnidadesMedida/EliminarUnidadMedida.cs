using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp;

public class EliminarUnidadMedida
{
    private readonly IUnidadMedidaService _unidadMedidaService;

    public EliminarUnidadMedida(IUnidadMedidaService unidadMedidaService)
    {
        _unidadMedidaService = unidadMedidaService;
    }

    public void Eliminar()
    {
        var nombreUnidad = "PRUEBA";

        _unidadMedidaService.Eliminar(nombreUnidad);
    }
}

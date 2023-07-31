using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp;

public class EliminarMovimiento
{
    private readonly IMovimientoService _movimientoService;

    public EliminarMovimiento(IMovimientoService movimientoService)
    {
        _movimientoService = movimientoService;
    }

    public void Eliminar(int documentoId, int movimientoId)
    {
        _movimientoService.Eliminar(documentoId, movimientoId);
    }
}

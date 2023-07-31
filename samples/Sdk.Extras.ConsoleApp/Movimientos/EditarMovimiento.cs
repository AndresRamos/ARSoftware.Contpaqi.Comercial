using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.ConsoleApp;

public class EditarMovimiento
{
    private readonly IMovimientoService _movimientoService;

    public EditarMovimiento(IMovimientoService movimientoService)
    {
        _movimientoService = movimientoService;
    }

    public void Editar(int movimientoId)
    {
        var datosMovimiento = new Dictionary<string, string>
        {
            { nameof(admMovimientos.CTEXTOEXTRA1), "Texto Extra 1" },
            { nameof(admMovimientos.CTEXTOEXTRA2), "Texto Extra 2" },
            { nameof(admMovimientos.CTEXTOEXTRA3), "Texto Extra 3" },
            { nameof(admMovimientos.CREFERENCIA), "Referencia" },
            { nameof(admMovimientos.COBSERVAMOV), "Observaciones" }
        };

        _movimientoService.Actualizar(movimientoId, datosMovimiento);
    }
}

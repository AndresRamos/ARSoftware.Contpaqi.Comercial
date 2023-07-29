using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.ConsoleApp;

public class CrearMovimiento
{
    private readonly IMovimientoService _movimientoService;

    public CrearMovimiento(IMovimientoService movimientoService)
    {
        _movimientoService = movimientoService;
    }

    public int Crear(int documentoId)
    {
        var movimiento = new Movimiento
        {
            Producto = new Producto { Codigo = "PRUEBA" },
            Almacen = new Almacen { Codigo = "PRUEBA" },
            Unidades = 1,
            Precio = 100,
            Referencia = "Referencia",
            Observaciones = "Observaciones"
        };

        movimiento.DatosExtra.Add(nameof(admMovimientos.CTEXTOEXTRA1), "Texto Extra 1");

        return _movimientoService.Crear(documentoId, movimiento);
    }
}
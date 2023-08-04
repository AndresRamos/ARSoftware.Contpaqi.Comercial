using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.ValueObjects;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
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

    public int CrearMovimientoDescuento(int documentoId)
    {
        var movimiento = new Movimiento
        {
            Producto = new Producto { Codigo = "PRUEBA" },
            Almacen = new Almacen { Codigo = "PRUEBA" },
            Unidades = 1,
            Precio = 100,
            Referencia = "Referencia",
            Observaciones = "Observaciones",
            Descuentos = new DescuentosMovimiento
            {
                Descuento1 =
                {
                    Tasa = 10 // El porcentaje de descuento = 10%
                    // Importe = 10 // Se puede asignar el importe y/o la tasa
                }
                // Se pueden asignar hasta 5 descuentos dependiendo de la configuracion del concepto
                //Descuento2 = { Tasa = 10 },
                //Descuento3 = { Tasa = 10 },
                //Descuento4 = { Tasa = 10 },
                //Descuento5 = { Tasa = 10 },
            }
        };

        movimiento.DatosExtra.Add(nameof(admMovimientos.CTEXTOEXTRA1), "Texto Extra 1");

        return _movimientoService.Crear(documentoId, movimiento);
    }
}

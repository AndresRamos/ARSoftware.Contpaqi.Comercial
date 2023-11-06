using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.ConsoleApp;

public class CrearProducto
{
    private readonly IProductoService _productoService;

    public CrearProducto(IProductoService productoService)
    {
        _productoService = productoService;
    }

    public int Crear()
    {
        var producto = new Producto
        {
            Codigo = "PRUEBA", Nombre = "PRODUCTO DE PRUEBAS", Tipo = TipoProducto.Servicio, ClaveSat = "43231500"
        };

        producto.DatosExtra.Add(nameof(admProductos.CTEXTOEXTRA1), "Texto Extra 1");
        producto.DatosExtra.Add(nameof(admProductos.CTEXTOEXTRA2), "Texto Extra 2");

        return _productoService.Crear(producto);
    }

    public int CrearConUnidadMedida()
    {
        var producto = new Producto
        {
            Codigo = "PRUEBAUNI",
            Nombre = "PRODUCTO CON UNIDAD",
            Tipo = TipoProducto.Producto,
            ControlExistencias = ControlExistencias.Unidades,
            UnidadMedida = new UnidadMedida { Nombre = "PIEZA" },
            ClaveSat = "11121600"
        };

        producto.DatosExtra.Add(nameof(admProductos.CTEXTOEXTRA1), "Texto Extra 1");
        producto.DatosExtra.Add(nameof(admProductos.CTEXTOEXTRA2), "Texto Extra 2");

        return _productoService.Crear(producto);
    }
}

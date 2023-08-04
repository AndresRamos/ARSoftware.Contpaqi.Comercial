using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.ConsoleApp;

public class EditarProducto
{
    private readonly IProductoService _productoService;

    public EditarProducto(IProductoService productoService)
    {
        _productoService = productoService;
    }

    public void Editar()
    {
        var codigoProducto = "PRUEBA";

        var datosProducto = new Dictionary<string, string>
        {
            { nameof(admProductos.CTEXTOEXTRA1), "Texto Extra 1" },
            { nameof(admProductos.CTEXTOEXTRA2), "Texto Extra 2" },
            { nameof(admProductos.CTEXTOEXTRA3), "Texto Extra 3" }
        };

        _productoService.Actualizar(codigoProducto, datosProducto);
    }
}

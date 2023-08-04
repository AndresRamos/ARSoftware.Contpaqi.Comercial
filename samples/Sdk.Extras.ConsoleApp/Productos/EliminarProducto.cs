using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp;

public class EliminarProducto
{
    private readonly IProductoService _productoService;

    public EliminarProducto(IProductoService productoService)
    {
        _productoService = productoService;
    }

    public void Eliminar()
    {
        var codigoProducto = "PRUEBA";

        _productoService.Eliminar(codigoProducto);
    }
}

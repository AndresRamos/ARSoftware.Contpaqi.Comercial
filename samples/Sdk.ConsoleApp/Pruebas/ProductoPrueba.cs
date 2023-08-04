using Sdk.ConsoleApp.Catalogos;

namespace Sdk.ConsoleApp.Pruebas;

public sealed class ProductoPrueba
{
    public static void ActualizarProductoPrueba()
    {
        ProductoSdk producto = ProductoSdk.BuscarProductoPorCodigo("PRODPRUEBA01");

        producto.Nombre = "PRODUCTO PRUEBA MODIFICADO";

        ProductoSdk.ActualizarProducto(producto);
    }

    public static int CrearProductoPrueba()
    {
        var producto = new ProductoSdk { Codigo = "PRODPRUEBA01", Nombre = "PRODUCTO PRUEBA 01", Tipo = 1 };

        return ProductoSdk.CrearProducto(producto);
    }

    public static void EliminarProductoPrueba()
    {
        ProductoSdk producto = ProductoSdk.BuscarProductoPorCodigo("PRODPRUEBA01");

        ProductoSdk.EliminarProducto(producto);
    }
}

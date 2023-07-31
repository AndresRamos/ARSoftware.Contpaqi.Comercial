using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extensiones;

namespace Sdk.ConsoleApp.Catalogos;

/// <summary>
///     Tabla admProductos – Tabla de Productos
/// </summary>
public sealed class ProductoSdk
{
    /// <summary>
    ///     Campo CCODIGOPRODUCTO - Código del producto.
    /// </summary>
    public string Codigo { get; set; }

    /// <summary>
    ///     Campo CIDPRODUCTO - Identificador del producto.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Campo CNOMBREPRODUCTO - Nombre del producto.
    /// </summary>
    public string Nombre { get; set; }

    /// <summary>
    ///     Campo CTIPOPRODUCTO - Tipo de producto: 1 = Producto, 2 = Paquete, 3 = Servicio
    /// </summary>
    public int Tipo { get; set; }

    /// <summary>
    ///     Actualiza un producto.
    /// </summary>
    /// <param name="producto">Producto del que se asignaran los datos a modificar.</param>
    public static void ActualizarProducto(ProductoSdk producto)
    {
        // Buscar el producto por código
        // Si el producto existe el SDK se posiciona en el registro
        ComercialSdk.fBuscaProducto(producto.Codigo).TirarSiEsError();

        // Activar el modo de edición
        ComercialSdk.fEditaProducto().TirarSiEsError();

        // Actualizar los campos del registro donde el SDK esta posicionado
        ComercialSdk.fSetDatoProducto("CNOMBREPRODUCTO", producto.Nombre).TirarSiEsError();

        // Guardar los cambios realizados al registro
        ComercialSdk.fGuardaProducto().TirarSiEsError();
    }

    /// <summary>
    ///     Busca un producto por código.
    /// </summary>
    /// <param name="productoCodigo">El código del producto a buscar.</param>
    /// <returns>El producto a buscar.</returns>
    public static ProductoSdk BuscarProductoPorCodigo(string productoCodigo)
    {
        // Buscar el producto por código
        // Si el producto existe el SDK se posiciona en el registro
        ComercialSdk.fBuscaProducto(productoCodigo).TirarSiEsError();

        // Leer los datos del registro donde el SDK esta posicionado
        return LeerDatosProducto();
    }

    /// <summary>
    ///     Busca un producto por id.
    /// </summary>
    /// <param name="productoId">El id del producto a buscar.</param>
    /// <returns>El producto a buscar.</returns>
    public static ProductoSdk BuscarProductoPorId(int productoId)
    {
        // Buscar el producto por id
        // Si el producto existe el SDK se posiciona en el registro
        ComercialSdk.fBuscaIdProducto(productoId).TirarSiEsError();

        // Leer los datos del registro donde el SDK esta posicionado
        return LeerDatosProducto();
    }

    /// <summary>
    ///     Busca todos los productos.
    /// </summary>
    /// <returns>La lista de productos.</returns>
    public static List<ProductoSdk> BuscarProductos()
    {
        var productosList = new List<ProductoSdk>();

        // Posicionar el SDK en el primer registro
        int resultado = ComercialSdk.fPosPrimerProducto();
        if (resultado == SdkConstantes.CodigoExito)
            // Leer los datos del registro donde el SDK esta posicionado
            productosList.Add(LeerDatosProducto());
        else
            return productosList;

        // Crear un loop y posicionar el SDK en el siguiente registro
        while (ComercialSdk.fPosSiguienteProducto() == SdkConstantes.CodigoExito)
        {
            // Leer los datos del registro donde el SDK esta posicionado
            productosList.Add(LeerDatosProducto());

            // Checar si el SDK esta posicionado en el ultimo registro
            // Si el SDK esta posicionado en el ultimo registro salir del loop
            if (ComercialSdk.fPosEOFProducto() == 1) break;
        }

        return productosList;
    }

    /// <summary>
    ///     Crea un producto nuevo.
    /// </summary>
    /// <param name="producto">Producto del cual se asignaran los datos.</param>
    /// <returns>El id del producto creado.</returns>
    public static int CrearProducto(ProductoSdk producto)
    {
        // Instanciar un producto con la estructura tProducto del SDK
        var productoNuevo = new tProducto
        {
            cCodigoProducto = producto.Codigo,
            cNombreProducto = producto.Nombre,
            cTipoProducto = producto.Tipo,
            cFechaAltaProducto = DateTime.Today.ToString(FormatosFechaSdk.Fecha),
            cStatusProducto = 1
        };

        // Declarar una variable donde se asignara el id del producto nuevo
        var productoNuevoId = 0;

        // Crear producto nuevo
        ComercialSdk.fAltaProducto(ref productoNuevoId, ref productoNuevo).TirarSiEsError();

        return productoNuevoId;
    }

    /// <summary>
    ///     Elimina un producto.
    /// </summary>
    /// <param name="producto">El producto a eliminar.</param>
    public static void EliminarProducto(ProductoSdk producto)
    {
        // Buscar el producto por codigo
        // Si el producto existe el SDK se posiciona en el registro
        ComercialSdk.fBuscaProducto(producto.Codigo).TirarSiEsError();

        // Borrar el registro de la base de datos 
        ComercialSdk.fBorraProducto().TirarSiEsError();
    }

    /// <summary>
    ///     Lee los datos del producto donde el SDK esta posicionado.
    /// </summary>
    /// <returns>Regresa un producto con los sus datos asignados.</returns>
    private static ProductoSdk LeerDatosProducto()
    {
        // Declarar variables a leer de la base de datos
        var idBd = new StringBuilder(3000);
        var codigoBd = new StringBuilder(3000);
        var nombreBd = new StringBuilder(3000);
        var tipoBd = new StringBuilder(3000);

        // Leer los datos del registro donde el SDK esta posicionado
        ComercialSdk.fLeeDatoProducto("CIDPRODUCTO", idBd, 3000).TirarSiEsError();
        ComercialSdk.fLeeDatoProducto("CCODIGOPRODUCTO", codigoBd, 3000).TirarSiEsError();
        ComercialSdk.fLeeDatoProducto("CNOMBREPRODUCTO", nombreBd, 3000).TirarSiEsError();
        ComercialSdk.fLeeDatoProducto("CTIPOPRODUCTO", tipoBd, 3000).TirarSiEsError();

        // Instanciar un producto y asignar los datos de la base de datos
        return new ProductoSdk
        {
            Id = int.Parse(idBd.ToString()),
            Codigo = codigoBd.ToString(),
            Nombre = nombreBd.ToString(),
            Tipo = int.Parse(tipoBd.ToString())
        };
    }

    public override string ToString()
    {
        return $"{Id} - {Codigo} - {Nombre} - {Tipo}";
    }
}

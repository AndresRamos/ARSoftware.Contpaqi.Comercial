using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface IProductoService
{
    /// <summary>
    ///     Actualiza un producto por dato abstracto.
    /// </summary>
    /// <param name="codigoProducto">Código del producto a actualizar.</param>
    /// <param name="producto">Producto a actualizar.</param>
    void Actualizar(string codigoProducto, tProducto producto);

    /// <summary>
    ///     Actualiza un producto por su Id. Los datos a actualizar se pasan en un diccionario donde la llave es el nombre de
    ///     la columna de la tabla de productos en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="idProducto">Id del producto a actualizar.</param>
    /// <param name="datosProducto">Datos del producto a actualizar.</param>
    void Actualizar(int idProducto, Dictionary<string, string> datosProducto);

    /// <summary>
    ///     Actualiza un producto por su código. Los datos a actualizar se pasan en un diccionario donde la llave es el nombre
    ///     de la columna de la tabla de productos en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="codigoProducto">Código del producto a actualizar.</param>
    /// <param name="datosProducto">Datos del producto a actualizar.</param>
    void Actualizar(string codigoProducto, Dictionary<string, string> datosProducto);

    /// <summary>
    ///     Actualiza un producto. Se actualizan todos los campos en el modelo por lo que es necesario que todas las
    ///     propiedades del modelo tengan un valor valido.
    /// </summary>
    /// <param name="producto">Producto a actualizar.</param>
    void Actualizar(Producto producto);

    /// <summary>
    ///     Crea un producto por dato abstracto.
    /// </summary>
    /// <param name="producto">Producto a crear.</param>
    /// <returns>Id del producto creado.</returns>
    int Crear(tProducto producto);

    /// <summary>
    ///     Crear un producto. Los datos del producto se pasan en un diccionario donde la llave es el nombre de la columna de
    ///     la tabla de productos en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="datosProducto">Datos del producto a crear.</param>
    /// <returns>Id del producto creado.</returns>
    int Crear(Dictionary<string, string> datosProducto);

    /// <summary>
    ///     Crea un producto.
    /// </summary>
    /// <param name="producto">Producto a crear.</param>
    /// <returns>Id del producto creado.</returns>
    int Crear(Producto producto);

    /// <summary>
    ///     Elimina un producto por su Id.
    /// </summary>
    /// <param name="idProducto">Id del producto a eliminar.</param>
    void Eliminar(int idProducto);

    /// <summary>
    ///     Elimina un producto por su código.
    /// </summary>
    /// <param name="codigoProducto">Código del producto a eliminar.</param>
    void Eliminar(string codigoProducto);
}

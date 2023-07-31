using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar productos.
/// </summary>
/// <typeparam name="T">
///     El tipo de producto utilizado por el repositorio.
/// </typeparam>
public interface IProductoRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un producto por código.
    /// </summary>
    /// <param name="codigoProducto">
    ///     Código del producto a buscar.
    /// </param>
    /// <returns>
    ///     Un producto, o <see langword="null" /> si no existe un producto con el código proporcionado.
    /// </returns>
    T? BuscarPorCodigo(string codigoProducto);

    /// <summary>
    ///     Busca un producto por id.
    /// </summary>
    /// <param name="idProducto">
    ///     Id del producto a buscar.
    /// </param>
    /// <returns>
    ///     Un producto, o <see langword="null" /> si no existe un producto con el id proporcionado.
    /// </returns>
    T? BuscarPorId(int idProducto);

    /// <summary>
    ///     Busca productos por tipo.
    /// </summary>
    /// <param name="tipoProducto">
    ///     Tipo de los producto a buscar.
    /// </param>
    /// <returns>
    ///     Lista de productos.
    /// </returns>
    List<T> TraerPorTipo(TipoProducto tipoProducto);

    /// <summary>
    ///     Busca todos los productos.
    /// </summary>
    /// <returns>
    ///     Lista de productos.
    /// </returns>
    List<T> TraerTodo();
}

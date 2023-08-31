using System;
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
    ///     Busca las existencias de un producto en un almacén en una fecha determinada.
    /// </summary>
    /// <param name="codigoProducto">Código del producto.</param>
    /// <param name="codigoAlmacen">Código del almacén.</param>
    /// <param name="fecha">Fecha</param>
    /// <returns>
    ///     Las existencias del producto en el almacén en la fecha proporcionada.
    /// </returns>
    double BuscaExistencias(string codigoProducto, string codigoAlmacen, DateOnly fecha);

    /// <summary>
    ///     Busca las existencias de un producto con características en un almacén en una fecha determinada.
    /// </summary>
    /// <param name="codigoProducto">Código del producto.</param>
    /// <param name="codigoAlmacen">Código del almacén.</param>
    /// <param name="fecha">Fecha</param>
    /// <param name="valorCaracteristica1">Valor de la Característica 1 del producto.</param>
    /// <param name="valorCaracteristica2">Valor de la Característica 1 del producto.</param>
    /// <param name="valorCaracteristica3">Valor de la Característica 1 del producto.</param>
    /// <returns>
    ///     Las existencias del producto con características en el almacén en la fecha proporcionada.
    /// </returns>
    double BuscaExistenciasConCaracteristicas(string codigoProducto, string codigoAlmacen, DateOnly fecha, string valorCaracteristica1,
        string valorCaracteristica2, string valorCaracteristica3);

    /// <summary>
    ///     Busca las existencias de un producto por lote o pedimento.
    /// </summary>
    /// <param name="codigoProducto">Código del producto.</param>
    /// <param name="codigoAlmacen">Código del almacén.</param>
    /// <param name="pedimento">Numero de pedimento.</param>
    /// <param name="lote">Numero de lote.</param>
    /// <returns>
    ///     Las existencias del producto por lote o pedimento.
    /// </returns>
    double BuscaExistenciasConCapas(string codigoProducto, string codigoAlmacen, string pedimento, string lote);

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

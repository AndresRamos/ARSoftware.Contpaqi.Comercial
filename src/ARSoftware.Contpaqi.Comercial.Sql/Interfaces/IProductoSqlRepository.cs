using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IProductoRepository{T}" />
public interface IProductoSqlRepository<T> : IProductoRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un producto por código.
    /// </summary>
    /// <param name="codigoProducto">
    ///     Código del producto a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un producto, o <see langword="null" /> si no existe un producto con el código proporcionado.
    /// </returns>
    Task<T?> BuscarPorCodigoAsync(string codigoProducto, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca un producto por id.
    /// </summary>
    /// <param name="idProducto">
    ///     Id del producto a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un producto, o <see langword="null" /> si no existe un producto con el id proporcionado.
    /// </returns>
    Task<T?> BuscarPorIdAsync(int idProducto, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca productos por tipo.
    /// </summary>
    /// <param name="tipoProducto">
    ///     Tipo de los producto a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de productos.
    /// </returns>
    Task<List<T>> TraerPorTipoAsync(TipoProducto tipoProducto, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todos los productos.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de productos.
    /// </returns>
    Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken);
}

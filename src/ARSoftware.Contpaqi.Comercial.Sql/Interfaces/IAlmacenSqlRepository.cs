using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IAlmacenRepository{T}" />
public interface IAlmacenSqlRepository<T> : IAlmacenRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un almacén por código.
    /// </summary>
    /// <param name="codigoAlmacen">Código del almacén a buscar.</param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un almacén, o <see langword="null" /> si no existe un almacén con el código proporcionado.
    /// </returns>
    Task<T?> BuscarPorCodigoAsync(string codigoAlmacen, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca un almacén por id.
    /// </summary>
    /// <param name="idAlmacen">
    ///     Id del almacén a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un almacén, o <see langword="null" /> si no existe un almacén con el id proporcionado.
    /// </returns>
    Task<T?> BuscarPorIdAsync(int idAlmacen, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todos los almacenes.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de almacenes.
    /// </returns>
    Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken);
}

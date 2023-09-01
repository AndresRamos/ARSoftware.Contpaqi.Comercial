using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IMovimientoRepository{T}" />
public interface IMovimientoSqlRepository<T> : IMovimientoRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un movimiento por id.
    /// </summary>
    /// <param name="idMovimiento">
    ///     Id del movimiento a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un movimiento, o <see langword="null" /> si no existe un movimiento con el id proporcionado.
    /// </returns>
    Task<T?> BuscarPorIdAsync(int idMovimiento, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca movimientos por id de documento.
    /// </summary>
    /// <param name="idDocumento">
    ///     Id de documento de los movimientos a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de movimientos.
    /// </returns>
    Task<List<T>> TraerPorDocumentoIdAsync(int idDocumento, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todos los movimientos.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de movimientos.
    /// </returns>
    Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken);
}

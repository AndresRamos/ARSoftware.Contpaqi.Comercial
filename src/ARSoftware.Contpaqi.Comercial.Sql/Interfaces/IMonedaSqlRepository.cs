using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IMonedaRepository{T}" />
public interface IMonedaSqlRepository<T> : IMonedaRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca una moneda por id.
    /// </summary>
    /// <param name="idMoneda">
    ///     Id de la moneda a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Una moneda, o <see langword="null" /> si no existe una moneda con el id proporcionado.
    /// </returns>
    Task<T?> BuscarPorIdAsync(int idMoneda, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca una moneda por nombre.
    /// </summary>
    /// <param name="nombreMoneda">
    ///     Nombre de la moneda a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Una moneda, o <see langword="null" /> si no existe una moneda con el nombre proporcionado.
    /// </returns>
    Task<T?> BuscarPorNombreAsync(string nombreMoneda, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todas las monedas.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de monedas.
    /// </returns>
    Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken);
}

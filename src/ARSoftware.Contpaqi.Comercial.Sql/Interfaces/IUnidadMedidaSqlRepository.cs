using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IUnidadMedidaRepository{T}" />
public interface IUnidadMedidaSqlRepository<T> : IUnidadMedidaRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca una unidad de medida por id.
    /// </summary>
    /// <param name="idUnidad">
    ///     Id de la unidad de medida a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Una unidad de medida, o <see langword="null" /> si no existe una unidad de medida con el id proporcionado.
    /// </returns>
    Task<T?> BuscarPorIdAsync(int idUnidad, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca una unidad de medida por nombre.
    /// </summary>
    /// <param name="nombreUnidad">
    ///     Nombre de la unidad de medida a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Una unidad de medida, o <see langword="null" /> si no existe una unidad de medida con el nombre proporcionado.
    /// </returns>
    Task<T?> BuscarPorNombreAsync(string nombreUnidad, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todas las unidades de medida.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de unidades de medida.
    /// </returns>
    Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken);
}

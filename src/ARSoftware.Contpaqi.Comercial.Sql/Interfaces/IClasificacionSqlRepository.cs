using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IClasificacionRepository{T}" />
public interface IClasificacionSqlRepository<T> : IClasificacionRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca una clasificación por id.
    /// </summary>
    /// <param name="idClasificacion">
    ///     Id de la clasificación a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Una clasificación, o <see langword="null" /> si no existe una clasificación con el id proporcionado.
    /// </returns>
    Task<T?> BuscarPorIdAsyc(int idClasificacion, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca una clasificación por tipo y número.
    /// </summary>
    /// <param name="tipoClasificacion">
    ///     Tipo de la clasificación a buscar.
    /// </param>
    /// <param name="numeroClasificacion">
    ///     Número de la clasificación a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Una clasificación, o <see langword="null" /> si no existe una clasificación con el tipo y número proporcionados.
    /// </returns>
    Task<T?> BuscarPorTipoYNumeroAsync(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion,
        CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todas las clasificaciones de un tipo.
    /// </summary>
    /// <param name="tipoClasificacion">
    ///     Tipo de las clasificaciones a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de clasificaciones.
    /// </returns>
    Task<List<T>> TraerPorTipoAsync(TipoClasificacion tipoClasificacion, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todas las clasificaciones.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de clasificaciones.
    /// </returns>
    Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken);
}

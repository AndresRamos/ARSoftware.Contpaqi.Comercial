using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IValorClasificacionRepository{T}" />
public interface IValorClasificacionSqlRepository<T> : IValorClasificacionRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un valor de clasificación por id.
    /// </summary>
    /// <param name="idValorClasificacion">
    ///     Id del valor de clasificación a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un valor de clasificación, o <see langword="null" /> si no existe un valor de clasificación con el id
    ///     proporcionado.
    /// </returns>
    Task<T?> BuscarPorIdAsync(int idValorClasificacion, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca un valor de clasificación por tipo de clasificación, número de clasificación y código.
    /// </summary>
    /// <param name="tipoClasificacion">
    ///     Tipo de clasificación del valor de clasificación a buscar.
    /// </param>
    /// <param name="numeroClasificacion">
    ///     Número de clasificación del valor de clasificación a buscar.
    /// </param>
    /// <param name="codigoValorClasificacion">
    ///     Código del valor de clasificación a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un valor de clasificación, o <see langword="null" /> si no existe un valor de clasificación con el tipo de
    ///     clasificación, número de clasificación y código proporcionados.
    /// </returns>
    Task<T?> BuscarPorTipoClasificacionNumeroYCodigoAsync(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion,
        string codigoValorClasificacion, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca valores de clasificación por id de clasificación.
    /// </summary>
    /// <param name="idClasificacion">
    ///     Id de la clasificación de los valores de clasificación a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de valores de clasificación.
    /// </returns>
    Task<List<T>> TraerPorClasificacionIdAsync(int idClasificacion, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca valores de clasificación por tipo de clasificación y número de clasificación.
    /// </summary>
    /// <param name="tipoClasificacion">
    ///     Tipo de clasificación de los valores de clasificación a buscar.
    /// </param>
    /// <param name="numeroClasificacion">
    ///     Número de clasificación de los valores de clasificación a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de valores de clasificación.
    /// </returns>
    Task<List<T>> TraerPorClasificacionTipoYNumeroAsync(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion,
        CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todos los valores de clasificación.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de valores de clasificación.
    /// </returns>
    Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken);
}

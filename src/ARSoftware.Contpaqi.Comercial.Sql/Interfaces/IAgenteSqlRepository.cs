using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IAgenteRepository{T}" />
public interface IAgenteSqlRepository<T> : IAgenteRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un agente por código.
    /// </summary>
    /// <param name="codigoAgente">
    ///     Código del agente a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un agente, o <see langword="null" /> si no existe un agente con el código proporcionado.
    /// </returns>
    Task<T?> BuscarPorCodigoAsync(string codigoAgente, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca un agente por id.
    /// </summary>
    /// <param name="idAgente">
    ///     Id del agente a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un agente, o <see langword="null" /> si no existe un agente con el id proporcionado.
    /// </returns>
    Task<T?> BuscarPorIdAsync(int idAgente, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todos los agentes de un tipo.
    /// </summary>
    /// <param name="tipoAgente">
    ///     Tipo de los agentes a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de agentes.
    /// </returns>
    Task<List<T>> TraerPorTipoAsync(TipoAgente tipoAgente, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todos los agentes.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de agentes.
    /// </returns>
    Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken);
}

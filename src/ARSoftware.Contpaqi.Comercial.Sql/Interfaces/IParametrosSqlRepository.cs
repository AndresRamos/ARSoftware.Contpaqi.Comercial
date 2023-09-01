using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IParametrosRepository{T}" />
public interface IParametrosSqlRepository<T> : IParametrosRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca los parámetros de la empresa.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Los parámetros de la empresa.
    /// </returns>
    Task<T> BuscarAsync(CancellationToken cancellationToken);
}

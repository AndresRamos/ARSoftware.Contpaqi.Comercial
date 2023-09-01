using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IDocumentoModeloRepository{T}" />
public interface IDocumentoModeloSqlRepository<T> : IDocumentoModeloRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca todos los documentos modelo.
    /// </summary>
    /// <returns>
    ///     Lista de documentos modelo.
    /// </returns>
    Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken);
}

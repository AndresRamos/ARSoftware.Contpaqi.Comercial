using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IEmpresaRepository{T}" />
public interface IEmpresaSqlRepository<T> : IEmpresaRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca una empresa por su nombre.
    /// </summary>
    /// <param name="nombreEmpresa">
    ///     Nombre de la empresa a buscar.
    /// </param>
    /// <returns>
    ///     Una empresa, o <see langword="null" /> si no existe una empresa con el nombre proporcionado.
    /// </returns>
    Task<T?> BuscarPorNombreAsync(string nombreEmpresa, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todas las empresas.
    /// </summary>
    /// <returns>
    ///     Lista de empresas.
    /// </returns>
    Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken);
}

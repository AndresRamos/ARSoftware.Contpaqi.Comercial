using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IConceptoDocumentoRepository{T}" />
public interface IConceptoDocumentoSqlRepository<T> : IConceptoDocumentoRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un concepto de documento por código.
    /// </summary>
    /// <param name="codigoConcepto">
    ///     Código del concepto de documento a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un concepto de documento, o <see langword="null" /> si no existe un concepto de documento con el código
    ///     proporcionado.
    /// </returns>
    Task<T?> BuscarPorCodigoAsync(string codigoConcepto, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca un concepto de documento por id.
    /// </summary>
    /// <param name="idConcepto">
    ///     Id del concepto de documento a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un concepto de documento, o <see langword="null" /> si no existe un concepto de documento con el id proporcionado.
    /// </returns>
    Task<T?> BuscarPorIdAsync(int idConcepto, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca conceptos de documento por documento modelo.
    /// </summary>
    /// <param name="idDocumentoModelo">
    ///     Id del documento modelo de los conceptos de documento a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de conceptos de documento.
    /// </returns>
    Task<List<T>> TraerPorDocumentoModeloIdAsync(int idDocumentoModelo, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todos los conceptos de documento.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de conceptos de documento.
    /// </returns>
    Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken);
}

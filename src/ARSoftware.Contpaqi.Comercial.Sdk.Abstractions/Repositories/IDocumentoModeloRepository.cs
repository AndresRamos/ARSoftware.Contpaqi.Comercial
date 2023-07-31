using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar documentos modelo.
/// </summary>
/// <typeparam name="T">
///     El tipo de documento modelo utilizado por el repositorio.
/// </typeparam>
public interface IDocumentoModeloRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca todos los documentos modelo.
    /// </summary>
    /// <returns>
    ///     Lista de documentos modelo.
    /// </returns>
    List<T> TraerTodo();
}

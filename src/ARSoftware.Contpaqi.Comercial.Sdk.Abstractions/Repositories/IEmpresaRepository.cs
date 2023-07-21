using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar empresas.
/// </summary>
/// <typeparam name="T">
///     El tipo de empresa utilizado por el repositorio.
/// </typeparam>
public interface IEmpresaRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca todas las empresas.
    /// </summary>
    /// <returns>
    ///     Lista de empresas.
    /// </returns>
    IEnumerable<T> TraerTodo();
}
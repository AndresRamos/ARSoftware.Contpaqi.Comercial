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
    ///     Busca una empresa por su nombre.
    /// </summary>
    /// <param name="nombreEmpresa">
    ///     Nombre de la empresa a buscar.
    /// </param>
    /// <returns>
    ///     Una empresa, o <see langword="null" /> si no existe una empresa con el nombre proporcionado.
    /// </returns>
    T? BuscarPorNombre(string nombreEmpresa);

    /// <summary>
    ///     Busca todas las empresas.
    /// </summary>
    /// <returns>
    ///     Lista de empresas.
    /// </returns>
    List<T> TraerTodo();
}

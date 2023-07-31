using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar unidades de medida.
/// </summary>
/// <typeparam name="T">
///     El tipo de unidad de medida utilizado por el repositorio.
/// </typeparam>
public interface IUnidadMedidaRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca una unidad de medida por id.
    /// </summary>
    /// <param name="idUnidad">
    ///     Id de la unidad de medida a buscar.
    /// </param>
    /// <returns>
    ///     Una unidad de medida, o <see langword="null" /> si no existe una unidad de medida con el id proporcionado.
    /// </returns>
    T? BuscarPorId(int idUnidad);

    /// <summary>
    ///     Busca una unidad de medida por nombre.
    /// </summary>
    /// <param name="nombreUnidad">
    ///     Nombre de la unidad de medida a buscar.
    /// </param>
    /// <returns>
    ///     Una unidad de medida, o <see langword="null" /> si no existe una unidad de medida con el nombre proporcionado.
    /// </returns>
    T? BuscarPorNombre(string nombreUnidad);

    /// <summary>
    ///     Busca todas las unidades de medida.
    /// </summary>
    /// <returns>
    ///     Lista de unidades de medida.
    /// </returns>
    List<T> TraerTodo();
}

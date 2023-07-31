using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar monedas.
/// </summary>
/// <typeparam name="T">
///     El tipo de moneda utilizado por el repositorio.
/// </typeparam>
public interface IMonedaRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca una moneda por id.
    /// </summary>
    /// <param name="idMoneda">
    ///     Id de la moneda a buscar.
    /// </param>
    /// <returns>
    ///     Una moneda, o <see langword="null" /> si no existe una moneda con el id proporcionado.
    /// </returns>
    T? BuscarPorId(int idMoneda);

    /// <summary>
    ///     Busca una moneda por nombre.
    /// </summary>
    /// <param name="nombreMoneda">
    ///     Nombre de la moneda a buscar.
    /// </param>
    /// <returns>
    ///     Una moneda, o <see langword="null" /> si no existe una moneda con el nombre proporcionado.
    /// </returns>
    T? BuscarPorNombre(string nombreMoneda);

    /// <summary>
    ///     Busca todas las monedas.
    /// </summary>
    /// <returns>
    ///     Lista de monedas.
    /// </returns>
    List<T> TraerTodo();
}

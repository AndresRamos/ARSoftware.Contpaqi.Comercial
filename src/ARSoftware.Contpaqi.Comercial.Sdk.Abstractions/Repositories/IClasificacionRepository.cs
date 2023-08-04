using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar clasificaciones.
/// </summary>
/// <typeparam name="T">
///     El tipo de clasificación utilizado por el repositorio.
/// </typeparam>
public interface IClasificacionRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca una clasificación por id.
    /// </summary>
    /// <param name="idClasificacion">
    ///     Id de la clasificación a buscar.
    /// </param>
    /// <returns>
    ///     Una clasificación, o <see langword="null" /> si no existe una clasificación con el id proporcionado.
    /// </returns>
    T? BuscarPorId(int idClasificacion);

    /// <summary>
    ///     Busca una clasificación por tipo y número.
    /// </summary>
    /// <param name="tipoClasificacion">
    ///     Tipo de la clasificación a buscar.
    /// </param>
    /// <param name="numeroClasificacion">
    ///     Número de la clasificación a buscar.
    /// </param>
    /// <returns>
    ///     Una clasificación, o <see langword="null" /> si no existe una clasificación con el tipo y número proporcionados.
    /// </returns>
    T? BuscarPorTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion);

    /// <summary>
    ///     Busca todas las clasificaciones de un tipo.
    /// </summary>
    /// <param name="tipoClasificacion">
    ///     Tipo de las clasificaciones a buscar.
    /// </param>
    /// <returns>
    ///     Lista de clasificaciones.
    /// </returns>
    List<T> TraerPorTipo(TipoClasificacion tipoClasificacion);

    /// <summary>
    ///     Busca todas las clasificaciones.
    /// </summary>
    /// <returns>
    ///     Lista de clasificaciones.
    /// </returns>
    List<T> TraerTodo();
}

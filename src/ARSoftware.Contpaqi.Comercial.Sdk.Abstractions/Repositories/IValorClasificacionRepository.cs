using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar valores de clasificación.
/// </summary>
/// <typeparam name="T">
///     El tipo de valor de clasificación utilizado por el repositorio.
/// </typeparam>
public interface IValorClasificacionRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un valor de clasificación por id.
    /// </summary>
    /// <param name="idValorClasificacion">
    ///     Id del valor de clasificación a buscar.
    /// </param>
    /// <returns>
    ///     Un valor de clasificación, o <see langword="null" /> si no existe un valor de clasificación con el id
    ///     proporcionado.
    /// </returns>
    T? BuscarPorId(int idValorClasificacion);

    /// <summary>
    ///     Busca un valor de clasificación por tipo de clasificación, número de clasificación y código.
    /// </summary>
    /// <param name="tipoClasificacion">
    ///     Tipo de clasificación del valor de clasificación a buscar.
    /// </param>
    /// <param name="numeroClasificacion">
    ///     Número de clasificación del valor de clasificación a buscar.
    /// </param>
    /// <param name="codigoValorClasificacion">
    ///     Código del valor de clasificación a buscar.
    /// </param>
    /// <returns>
    ///     Un valor de clasificación, o <see langword="null" /> si no existe un valor de clasificación con el tipo de
    ///     clasificación, número de clasificación y código proporcionados.
    /// </returns>
    T? BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion,
        string codigoValorClasificacion);

    /// <summary>
    ///     Busca valores de clasificación por id de clasificación.
    /// </summary>
    /// <param name="idClasificacion">
    ///     Id de la clasificación de los valores de clasificación a buscar.
    /// </param>
    /// <returns>
    ///     Lista de valores de clasificación.
    /// </returns>
    List<T> TraerPorClasificacionId(int idClasificacion);

    /// <summary>
    ///     Busca valores de clasificación por tipo de clasificación y número de clasificación.
    /// </summary>
    /// <param name="tipoClasificacion">
    ///     Tipo de clasificación de los valores de clasificación a buscar.
    /// </param>
    /// <param name="numeroClasificacion">
    ///     Número de clasificación de los valores de clasificación a buscar.
    /// </param>
    /// <returns>
    ///     Lista de valores de clasificación.
    /// </returns>
    List<T> TraerPorClasificacionTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion);

    /// <summary>
    ///     Busca todos los valores de clasificación.
    /// </summary>
    /// <returns>
    ///     Lista de valores de clasificación.
    /// </returns>
    List<T> TraerTodo();
}

using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar agentes.
/// </summary>
/// <typeparam name="T">
///     El tipo de agente utilizado por el repositorio.
/// </typeparam>
public interface IAgenteRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un agente por código.
    /// </summary>
    /// <param name="codigoAgente">
    ///     Código del agente a buscar.
    /// </param>
    /// <returns>
    ///     Un agente, o <see langword="null" /> si no existe un agente con el código proporcionado.
    /// </returns>
    T? BuscarPorCodigo(string codigoAgente);

    /// <summary>
    ///     Busca un agente por id.
    /// </summary>
    /// <param name="idAgente">
    ///     Id del agente a buscar.
    /// </param>
    /// <returns>
    ///     Un agente, o <see langword="null" /> si no existe un agente con el id proporcionado.
    /// </returns>
    T? BuscarPorId(int idAgente);

    /// <summary>
    ///     Busca todos los agentes de un tipo.
    /// </summary>
    /// <param name="tipoAgente">
    ///     Tipo de los agentes a buscar.
    /// </param>
    /// <returns>
    ///     Lista de agentes.
    /// </returns>
    List<T> TraerPorTipo(TipoAgente tipoAgente);

    /// <summary>
    ///     Busca todos los agentes.
    /// </summary>
    /// <returns>
    ///     Lista de agentes.
    /// </returns>
    List<T> TraerTodo();
}

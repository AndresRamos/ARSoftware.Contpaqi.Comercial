using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interface de repositorio que define las operaciones que se pueden realizar sobre la tabla de agentes.
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
    ///     Busca todos los agentes.
    /// </summary>
    /// <returns>
    ///     Lista de agentes.
    /// </returns>
    IEnumerable<T> TraerTodo();
}
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar movimientos.
/// </summary>
/// <typeparam name="T">
///     El tipo de movimiento utilizado por el repositorio.
/// </typeparam>
public interface IMovimientoRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un movimiento por id.
    /// </summary>
    /// <param name="idMovimiento">
    ///     Id del movimiento a buscar.
    /// </param>
    /// <returns>
    ///     Un movimiento, o <see langword="null" /> si no existe un movimiento con el id proporcionado.
    /// </returns>
    T? BuscarPorId(int idMovimiento);

    /// <summary>
    ///     Busca movimientos por id de documento.
    /// </summary>
    /// <param name="idDocumento">
    ///     Id de documento de los movimientos a buscar.
    /// </param>
    /// <returns>
    ///     Lista de movimientos.
    /// </returns>
    List<T> TraerPorDocumentoId(int idDocumento);

    /// <summary>
    ///     Busca todos los movimientos.
    /// </summary>
    /// <returns>
    ///     Lista de movimientos.
    /// </returns>
    List<T> TraerTodo();
}

using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interface de repositorio que define las operaciones que se pueden realizar sobre la tabla de almacenes.
/// </summary>
/// <typeparam name="T"> El tipo de almacén utilizado por el repositorio.</typeparam>
public interface IAlmacenRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un almacén por código.
    /// </summary>
    /// <param name="codigoAlmacen">Código del almacén a buscar.</param>
    /// <returns>
    ///     Un almacén, o <see langword="null" /> si no existe un almacén con el código proporcionado.
    /// </returns>
    T? BuscarPorCodigo(string codigoAlmacen);

    /// <summary>
    ///     Busca un almacén por id.
    /// </summary>
    /// <param name="idAlmacen">
    ///     Id del almacén a buscar.
    /// </param>
    /// <returns>
    ///     Un almacén, o <see langword="null" /> si no existe un almacén con el id proporcionado.
    /// </returns>
    T? BuscarPorId(int idAlmacen);

    /// <summary>
    ///     Busca todos los almacenes.
    /// </summary>
    /// <returns>
    ///     Lista de almacenes.
    /// </returns>
    IEnumerable<T> TraerTodo();
}
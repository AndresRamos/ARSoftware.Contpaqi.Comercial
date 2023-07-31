using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar clientes y proveedores.
/// </summary>
/// <typeparam name="T">
///     El tipo de cliente o proveedor utilizado por el repositorio.
/// </typeparam>
public interface IClienteProveedorRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un cliente o proveedor por código.
    /// </summary>
    /// <param name="codigoCliente">
    ///     Código del cliente o proveedor a buscar.
    /// </param>
    /// <returns>
    ///     Un cliente o proveedor, o <see langword="null" /> si no existe un cliente o proveedor con el código proporcionado.
    /// </returns>
    T? BuscarPorCodigo(string codigoCliente);

    /// <summary>
    ///     Busca un cliente o proveedor por id.
    /// </summary>
    /// <param name="idCliente">
    ///     Id del cliente o proveedor a buscar.
    /// </param>
    /// <returns>
    ///     Un cliente o proveedor, o <see langword="null" /> si no existe un cliente o proveedor con el id proporcionado.
    /// </returns>
    T? BuscarPorId(int idCliente);

    /// <summary>
    ///     Busca todos los clientes.
    /// </summary>
    /// <returns>
    ///     Lista de clientes.
    /// </returns>
    List<T> TraerClientes();

    /// <summary>
    ///     Busca clientes o proveedores por tipo.
    /// </summary>
    /// <param name="tipoCliente">
    ///     Tipo de los clientes o proveedores a buscar.
    /// </param>
    /// <returns>
    ///     Lista de clientes o proveedores.
    /// </returns>
    List<T> TraerPorTipo(TipoCliente tipoCliente);

    /// <summary>
    ///     Busca todos los proveedores.
    /// </summary>
    /// <returns>
    ///     Lista de proveedores.
    /// </returns>
    List<T> TraerProveedores();

    /// <summary>
    ///     Busca todos los clientes y proveedores.
    /// </summary>
    /// <returns>
    ///     Lista de clientes y proveedores.
    /// </returns>
    List<T> TraerTodo();
}

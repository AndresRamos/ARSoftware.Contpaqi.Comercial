using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IClienteProveedorRepository{T}" />
public interface IClienteProveedorSqlRepository<T> : IClienteProveedorRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un cliente o proveedor por código.
    /// </summary>
    /// <param name="codigoCliente">
    ///     Código del cliente o proveedor a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un cliente o proveedor, o <see langword="null" /> si no existe un cliente o proveedor con el código proporcionado.
    /// </returns>
    Task<T?> BuscarPorCodigoAsync(string codigoCliente, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca un cliente o proveedor por id.
    /// </summary>
    /// <param name="idCliente">
    ///     Id del cliente o proveedor a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un cliente o proveedor, o <see langword="null" /> si no existe un cliente o proveedor con el id proporcionado.
    /// </returns>
    Task<T?> BuscarPorIdAsync(int idCliente, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todos los clientes.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de clientes.
    /// </returns>
    Task<List<T>> TraerClientesAsync(CancellationToken cancellationToken);

    /// <summary>
    ///     Busca clientes o proveedores por tipo.
    /// </summary>
    /// <param name="tipoCliente">
    ///     Tipo de los clientes o proveedores a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de clientes o proveedores.
    /// </returns>
    Task<List<T>> TraerPorTipoAsync(TipoCliente tipoCliente, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todos los proveedores.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de proveedores.
    /// </returns>
    Task<List<T>> TraerProveedoresAsync(CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todos los clientes y proveedores.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de clientes y proveedores.
    /// </returns>
    Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken);
}

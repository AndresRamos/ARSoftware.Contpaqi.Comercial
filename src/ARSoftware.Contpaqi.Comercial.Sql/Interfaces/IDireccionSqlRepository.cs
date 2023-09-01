using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IDireccionRepository{T}" />
public interface IDireccionSqlRepository<T> : IDireccionRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca una dirección por cliente.
    /// </summary>
    /// <param name="codigoClienteProveedor">
    ///     Código del cliente o proveedor de la dirección a buscar.
    /// </param>
    /// <param name="tipoDireccion">
    ///     Tipo de la dirección a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Una dirección, o <see langword="null" /> si no existe una dirección con el código de cliente o proveedor y tipo de
    ///     dirección proporcionados.
    /// </returns>
    Task<T?> BuscarPorClienteAsync(string codigoClienteProveedor, TipoDireccion tipoDireccion, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca una dirección por documento.
    /// </summary>
    /// <param name="idDocumento">
    ///     Id del documento de la dirección a buscar.
    /// </param>
    /// <param name="tipoDireccion">
    ///     Tipo de la dirección a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Una dirección, o <see langword="null" /> si no existe una dirección con el id de documento y tipo de dirección
    ///     proporcionados.
    /// </returns>
    Task<T?> BuscarPorDocumentoAsync(int idDocumento, TipoDireccion tipoDireccion, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca una dirección por id.
    /// </summary>
    /// <param name="idDireccion">
    ///     Id de la dirección a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Una dirección, o <see langword="null" /> si no existe una dirección con el id proporcionado.
    /// </returns>
    Task<T?> BuscarPorIdAsync(int idDireccion, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca direcciones por tipo de catálogo de dirección.
    /// </summary>
    /// <param name="tipoCatalogoDireccion">
    ///     Tipo de catálogo de dirección de las direcciones a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de direcciones.
    /// </returns>
    Task<List<T>> TraerPorTipoAsync(TipoCatalogoDireccion tipoCatalogoDireccion, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca direcciones por tipo de catálogo de dirección y id de catálogo.
    /// </summary>
    /// <param name="tipoCatalogoDireccion">
    ///     Tipo de catálogo de dirección de las direcciones a buscar.
    /// </param>
    /// <param name="idCatalogo">
    ///     Id del catálogo de las direcciones a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de direcciones.
    /// </returns>
    Task<List<T>> TraerPorTipoYIdCatalogoAsync(TipoCatalogoDireccion tipoCatalogoDireccion, int idCatalogo,
        CancellationToken cancellationToken);

    /// <summary>
    ///     Busca todas las direcciones.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de direcciones.
    /// </returns>
    Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken);
}

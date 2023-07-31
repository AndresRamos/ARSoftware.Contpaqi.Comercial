using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar direcciones.
/// </summary>
/// <typeparam name="T">
///     El tipo de dirección utilizado por el repositorio.
/// </typeparam>
public interface IDireccionRepository<T> where T : class, new()
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
    /// <returns>
    ///     Una dirección, o <see langword="null" /> si no existe una dirección con el código de cliente o proveedor y tipo de
    ///     dirección proporcionados.
    /// </returns>
    T? BuscarPorCliente(string codigoClienteProveedor, TipoDireccion tipoDireccion);

    /// <summary>
    ///     Busca una dirección por documento.
    /// </summary>
    /// <param name="idDocumento">
    ///     Id del documento de la dirección a buscar.
    /// </param>
    /// <param name="tipoDireccion">
    ///     Tipo de la dirección a buscar.
    /// </param>
    /// <returns>
    ///     Una dirección, o <see langword="null" /> si no existe una dirección con el id de documento y tipo de dirección
    ///     proporcionados.
    /// </returns>
    T? BuscarPorDocumento(int idDocumento, TipoDireccion tipoDireccion);

    /// <summary>
    ///     Busca una dirección por id.
    /// </summary>
    /// <param name="idDireccion">
    ///     Id de la dirección a buscar.
    /// </param>
    /// <returns>
    ///     Una dirección, o <see langword="null" /> si no existe una dirección con el id proporcionado.
    /// </returns>
    T? BuscarPorId(int idDireccion);

    /// <summary>
    ///     Busca direcciones por tipo de catálogo de dirección.
    /// </summary>
    /// <param name="tipoCatalogoDireccion">
    ///     Tipo de catálogo de dirección de las direcciones a buscar.
    /// </param>
    /// <returns>
    ///     Lista de direcciones.
    /// </returns>
    List<T> TraerPorTipo(TipoCatalogoDireccion tipoCatalogoDireccion);

    /// <summary>
    ///     Busca direcciones por tipo de catálogo de dirección y id de catálogo.
    /// </summary>
    /// <param name="tipoCatalogoDireccion">
    ///     Tipo de catálogo de dirección de las direcciones a buscar.
    /// </param>
    /// <param name="idCatalogo">
    ///     Id del catálogo de las direcciones a buscar.
    /// </param>
    /// <returns>
    ///     Lista de direcciones.
    /// </returns>
    List<T> TraerPorTipoYIdCatalogo(TipoCatalogoDireccion tipoCatalogoDireccion, int idCatalogo);

    /// <summary>
    ///     Busca todas las direcciones.
    /// </summary>
    /// <returns>
    ///     Lista de direcciones.
    /// </returns>
    List<T> TraerTodo();
}

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IDocumentoRepository{T}" />
public interface IDocumentoSqlRepository<T> : IDocumentoRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un documento por id.
    /// </summary>
    /// <param name="idDocumento">
    ///     Id del documento a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un documento, o <see langword="null" /> si no existe un documento con el id proporcionado.
    /// </returns>
    Task<T?> BuscarPorIdAsync(int idDocumento, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca un documento por llave.
    /// </summary>
    /// <param name="codigoConcepto">
    ///     Código del concepto del documento a buscar.
    /// </param>
    /// <param name="serie">
    ///     Serie del documento a buscar.
    /// </param>
    /// <param name="folio">
    ///     Folio del documento a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un documento, o <see langword="null" /> si no existe un documento con la llave proporcionada.
    /// </returns>
    Task<T?> BuscarPorLlaveAsync(string codigoConcepto, string serie, double folio, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca un documento por llave.
    /// </summary>
    /// <param name="llaveDocumento">
    ///     Llave del documento a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Un documento, o <see langword="null" /> si no existe un documento con la llave proporcionada.
    /// </returns>
    Task<T?> BuscarPorLlaveAsync(LlaveDocumento llaveDocumento, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca documentos por rango de fecha, código de concepto y código de cliente/proveedor.
    /// </summary>
    /// <param name="fechaInicio">
    ///     Fecha de inicio del rango de fecha.
    /// </param>
    /// <param name="fechaFin">
    ///     Fecha de fin del rango de fecha.
    /// </param>
    /// <param name="codigoConcepto">
    ///     Código de concepto de los documentos a buscar.
    /// </param>
    /// <param name="codigoClienteProveedor">
    ///     Código de cliente/proveedor de los documentos a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de documentos.
    /// </returns>
    Task<List<T>> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedorAsync(DateTime fechaInicio, DateTime fechaFin,
        string codigoConcepto, string codigoClienteProveedor, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca documentos por rango de fecha, código de concepto y códigos de cliente/proveedor.
    /// </summary>
    /// <param name="fechaInicio">
    ///     Fecha de inicio del rango de fecha.
    /// </param>
    /// <param name="fechaFin">
    ///     Fecha de fin del rango de fecha.
    /// </param>
    /// <param name="codigoConcepto">
    ///     Código de concepto de los documentos a buscar.
    /// </param>
    /// <param name="codigosClienteProveedor">
    ///     Códigos de cliente/proveedor de los documentos a buscar.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de documentos.
    /// </returns>
    Task<List<T>> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedorAsync(DateTime fechaInicio, DateTime fechaFin,
        string codigoConcepto, IEnumerable<string> codigosClienteProveedor, CancellationToken cancellationToken);

    /// <summary>
    ///     Buscar todos los documentos.
    /// </summary>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Lista de documentos.
    /// </returns>
    Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken);
}

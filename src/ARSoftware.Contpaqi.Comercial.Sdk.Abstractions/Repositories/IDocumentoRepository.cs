using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar documentos.
/// </summary>
/// <typeparam name="T">
///     El tipo de documento utilizado por el repositorio.
/// </typeparam>
public interface IDocumentoRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un documento por id.
    /// </summary>
    /// <param name="idDocumento">
    ///     Id del documento a buscar.
    /// </param>
    /// <returns>
    ///     Un documento, o <see langword="null" /> si no existe un documento con el id proporcionado.
    /// </returns>
    T? BuscarPorId(int idDocumento);

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
    /// <returns>
    ///     Un documento, o <see langword="null" /> si no existe un documento con la llave proporcionada.
    /// </returns>
    T? BuscarPorLlave(string codigoConcepto, string serie, double folio);

    /// <summary>
    ///     Busca un documento por llave.
    /// </summary>
    /// <param name="llaveDocumento">
    ///     Llave del documento a buscar.
    /// </param>
    /// <returns>
    ///     Un documento, o <see langword="null" /> si no existe un documento con la llave proporcionada.
    /// </returns>
    T? BuscarPorLlave(LlaveDocumento llaveDocumento);

    /// <summary>
    ///     Busca el siguiente serie y folio del concepto de documento.
    /// </summary>
    /// <param name="codigoConcepto">
    ///     Código del concepto de documento.
    /// </param>
    /// <returns>
    ///     La siguiente serie y folio del concepto de documento.
    /// </returns>
    LlaveDocumento BuscarSiguienteSerieYFolio(string codigoConcepto);

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
    /// <returns>
    ///     Lista de documentos.
    /// </returns>
    List<T> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto,
        string codigoClienteProveedor);

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
    /// <returns>
    ///     Lista de documentos.
    /// </returns>
    List<T> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto,
        IEnumerable<string> codigosClienteProveedor);

    /// <summary>
    ///     Buscar todos los documentos.
    /// </summary>
    /// <returns>
    ///     Lista de documentos.
    /// </returns>
    List<T> TraerTodo();
}

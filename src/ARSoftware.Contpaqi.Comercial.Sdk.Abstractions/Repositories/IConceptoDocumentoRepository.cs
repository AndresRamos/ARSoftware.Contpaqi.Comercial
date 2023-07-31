using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar conceptos de documento.
/// </summary>
/// <typeparam name="T">
///     El tipo de concepto de documento utilizado por el repositorio.
/// </typeparam>
public interface IConceptoDocumentoRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca un concepto de documento por código.
    /// </summary>
    /// <param name="codigoConcepto">
    ///     Código del concepto de documento a buscar.
    /// </param>
    /// <returns>
    ///     Un concepto de documento, o <see langword="null" /> si no existe un concepto de documento con el código
    ///     proporcionado.
    /// </returns>
    T? BuscarPorCodigo(string codigoConcepto);

    /// <summary>
    ///     Busca un concepto de documento por id.
    /// </summary>
    /// <param name="idConcepto">
    ///     Id del concepto de documento a buscar.
    /// </param>
    /// <returns>
    ///     Un concepto de documento, o <see langword="null" /> si no existe un concepto de documento con el id proporcionado.
    /// </returns>
    T? BuscarPorId(int idConcepto);

    /// <summary>
    ///     Busca conceptos de documento por documento modelo.
    /// </summary>
    /// <param name="idDocumentoModelo">
    ///     Id del documento modelo de los conceptos de documento a buscar.
    /// </param>
    /// <returns>
    ///     Lista de conceptos de documento.
    /// </returns>
    List<T> TraerPorDocumentoModeloId(int idDocumentoModelo);

    /// <summary>
    ///     Busca todos los conceptos de documento.
    /// </summary>
    /// <returns>
    ///     Lista de conceptos de documento.
    /// </returns>
    List<T> TraerTodo();
}

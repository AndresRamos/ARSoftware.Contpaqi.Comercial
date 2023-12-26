using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface IDocumentoService
{
    /// <summary>
    ///     Actualiza un documento por su id. Los datos a actualizar se pasan en un diccionario donde la llave es el nombre de
    ///     la columna de la tabla de documentos en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="documentoId">Id del documento a actualizar.</param>
    /// <param name="datosDocumento">Datos del documento a actualizar.</param>
    void Actualizar(int documentoId, Dictionary<string, string> datosDocumento);

    /// <summary>
    ///     Actualiza un documento por su llave. Los datos a actualizar se pasan en un diccionario donde la llave es el nombre
    ///     de la columna de la tabla de documentos en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="codigoConcepto">Código del concepto de documento del documento a actualizar.</param>
    /// <param name="serie">Serie del documento a actualizar.</param>
    /// <param name="folio">Folio del documento a actualizar.</param>
    /// <param name="datosDocumento">Datos del documento a actualizar.</param>
    void Actualizar(string codigoConcepto, string serie, string folio, Dictionary<string, string> datosDocumento);

    /// <summary>
    ///     Actualiza un documento por su llave. Los datos a actualizar se pasan en un diccionario donde la llave es el nombre
    ///     de la columna de la tabla de documentos en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="tLlaveDocumento">LLave del documento a actualizar.</param>
    /// <param name="datosDocumento">Datos del documento a actualizar.</param>
    void Actualizar(tLlaveDoc tLlaveDocumento, Dictionary<string, string> datosDocumento);

    /// <summary>
    ///     Actualiza un documento por su llave. El codigo del concepto, serie, y folio deben estar asignados. Solamente se
    ///     actualiza los datos que son modificables. Solamente se actualizan los campos del documento a 1 nivel de
    ///     profundidad. No se actualizan los datos de los objectos relacionados.
    /// </summary>
    /// <param name="documento">Documento a actualizar.</param>
    void Actualizar(Documento documento);

    /// <summary>
    ///     Buscar el siguiente folio y serie del concepto de documento.
    /// </summary>
    /// <param name="codigoConcepto">Código del concepto de documento.</param>
    /// <returns>Llave con el siguiente serie y folio del concepto de documento.</returns>
    tLlaveDoc BuscarSiguienteSerieYFolio(string codigoConcepto);

    /// <summary>
    ///     Cancela un documento por id.
    /// </summary>
    /// <param name="idDocumento">Id del documento a cancelar.</param>
    /// <param name="contrasenaCertificado">Contraseña del certificado.</param>
    void Cancelar(int idDocumento, string contrasenaCertificado);

    /// <summary>
    ///     Cancela un documento por id.
    /// </summary>
    /// <param name="idDocumento">Id del documento a cancelar.</param>
    /// <param name="contrasenaCertificado">Contraseña del certificado.</param>
    /// <param name="motivoCancelacion">
    ///     Motivo de cancelación del documento. Los valores posibles son: "01" - Comprobantes emitidos con errores con
    ///     relación, "02" - Comprobantes emitidos con errores sin relación, "03" - No se llevó a cabo la operación, "04" -
    ///     Operación nominativa relacionada en una factura global.
    /// </param>
    /// <param name="uuidRemplazo">UUID del documento que remplaza al documento a cancelar.</param>
    void Cancelar(int idDocumento, string contrasenaCertificado, MotivoCancelacionEnum motivoCancelacion, string uuidRemplazo);

    /// <summary>
    ///     Cancela un documento por su llave.
    /// </summary>
    /// <param name="tLlaveDocumento">LLave del documento a cancelar.</param>
    /// <param name="contrasenaCertificado">Contraseña del certificado.</param>
    /// <param name="motivoCancelacion">
    ///     Motivo de cancelación del documento. Los valores posibles son: "01" - Comprobantes emitidos con errores con
    ///     relación, "02" - Comprobantes emitidos con errores sin relación, "03" - No se llevó a cabo la operación, "04" -
    ///     Operación nominativa relacionada en una factura global.
    /// </param>
    /// <param name="uuidRemplazo">UUID del documento que remplaza al documento a cancelar.</param>
    void Cancelar(tLlaveDoc tLlaveDocumento, string contrasenaCertificado, MotivoCancelacionEnum motivoCancelacion, string uuidRemplazo);

    /// <summary>
    ///     Cancela el documento administrativamente por id.
    /// </summary>
    /// <param name="idDocumento">Id del documento a cancelar.</param>
    void CancelarAdministrativamente(int idDocumento);

    /// <summary>
    ///     Cancela el documento administrativamente por su llave.
    /// </summary>
    /// <param name="codigoConcepto">Código del concepto de documento del documento a cancelar.</param>
    /// <param name="serie">Serie del documento a cancelar.</param>
    /// <param name="folio">Folio del documento a cancelar.</param>
    void CancelarAdministrativamente(string codigoConcepto, string serie, string folio);

    /// <summary>
    ///     Cancela el documento administrativamente por su llave.
    /// </summary>
    /// <param name="tLlaveDocumento">Llave del documento a cancelar.</param>
    void CancelarAdministrativamente(tLlaveDoc tLlaveDocumento);

    /// <summary>
    ///     Crea un documento por dato abstracto.
    /// </summary>
    /// <param name="documento">Documento a crear.</param>
    /// <returns>Id del documento a creado.</returns>
    int Crear(tDocumento documento);

    /// <summary>
    ///     Crea un documento. Los datos del documento se pasan en un diccionario donde la llave es el nombre de la columna de
    ///     la tabla de documentos en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="datosDocumento">Datos del documento a crear.</param>
    /// <returns>Id del documento creado.</returns>
    int Crear(Dictionary<string, string> datosDocumento);

    /// <summary>
    ///     Crea un documento.
    /// </summary>
    /// <param name="documento">Documento a crear.</param>
    /// <returns>Id del documento creado.</returns>
    int Crear(Documento documento);

    /// <summary>
    ///     Crea un documento de cargo o abono por dato abstracto.
    /// </summary>
    /// <param name="documento">Documento a crear.</param>
    /// <returns>Id del documento creado.</returns>
    int CrearCargoAbono(tDocumento documento);

    /// <summary>
    ///     Crea un documento de cargo o abono.
    /// </summary>
    /// <param name="documento">Documento a crear.</param>
    /// <returns>Id del documento creado.</returns>
    int CrearCargoAbono(Documento documento);

    /// <summary>
    ///     Desbloquea un documento por su id.
    /// </summary>
    /// <param name="idDocumento">Id del documento a desbloquear.</param>
    void DesbloquearDocumento(int idDocumento);

    /// <summary>
    ///     Desbloquea un documento por su llave.
    /// </summary>
    /// <param name="llave">Llave del documento a desbloquear.</param>
    void DesbloquearDocumento(LlaveDocumento llave);

    /// <summary>
    ///     Elimina un documento por su id.
    /// </summary>
    /// <param name="idDocumento">Id del documento a eliminar.</param>
    void Eliminar(int idDocumento);

    /// <summary>
    ///     Elimina un documento por su llave.
    /// </summary>
    /// <param name="codigoConcepto">Código del concepto de documento del documento a eliminar.</param>
    /// <param name="serie">Serie del documento a eliminar.</param>
    /// <param name="folio">Folio del documento a eliminar.</param>
    void Eliminar(string codigoConcepto, string serie, string folio);

    /// <summary>
    ///     Elimina un documento por su llave.
    /// </summary>
    /// <param name="tLlaveDocumento">Llave del documento a eliminar.</param>
    void Eliminar(tLlaveDoc tLlaveDocumento);

    /// <summary>
    ///     Genera el XML o PDF de un documento por su llave.
    /// </summary>
    /// <param name="codigoConceptoDocumento">Código del concepto de documento del documento.</param>
    /// <param name="serieDocumento">Serie del documento.</param>
    /// <param name="folioDocumento">Folio del documento.</param>
    /// <param name="tipoArchivo">Tipo de archivo a generar. Los valores posibles son: Xml o Pdf.</param>
    /// <param name="rutaPlantilla">Ruta de la plantilla para generar el PDF.</param>
    void GenerarDocumentoDigital(string codigoConceptoDocumento, string serieDocumento, double folioDocumento,
        TipoArchivoDigital tipoArchivo, string rutaPlantilla = "");

    /// <summary>
    ///     Genera el XML o PDF de un documento por su llave.
    /// </summary>
    /// <param name="documento">Llave del documento.</param>
    /// <param name="tipoArchivo">Tipo de archivo a generar. Los valores posibles son: Xml o Pdf.</param>
    /// <param name="rutaPlantilla">Ruta de la plantilla para generar el PDF.</param>
    void GenerarDocumentoDigital(tLlaveDoc documento, TipoArchivoDigital tipoArchivo, string rutaPlantilla = "");

    void GenerarDocumentoDigital(tLlaveDoc documento, TipoArchivoDigital tipoArchivo, string rutaPlantilla, string rutaDirectorioEmpresa,
        string rutaArchivoDestino);

    void RelacionarDocumentos(tLlaveDoc documento, string tipoRelacion, tLlaveDoc documentoRelacionado);

    void RelacionarDocumentos(tLlaveDoc documento, string tipoRelacion, string uuid);

    /// <summary>
    ///     Salda un documento.
    /// </summary>
    /// <param name="documentoAPagar">Llave del documento a pagar.</param>
    /// <param name="documentoPago">Llave del documento de pago.</param>
    /// <param name="fecha">Fecha de aplicacion.</param>
    /// <param name="importe">Importe a aplicar.</param>
    /// <param name="monedaId">Id de la moneda de pago.</param>
    void SaldarDocumento(tLlaveDoc documentoAPagar, tLlaveDoc documentoPago, DateTime fecha, double importe, int monedaId = 1);

    /// <summary>
    ///     Timbra un documento por su llave.
    /// </summary>
    /// <param name="codigoConceptoDocumento">Código del concepto de documento del documento.</param>
    /// <param name="serieDocumento">Serie del documento.</param>
    /// <param name="folioDocumento">Folio del documento.</param>
    /// <param name="contrasenaCertificado">Contraseña del certificado.</param>
    /// <param name="rutaArchivoAdicional">
    ///     Ruta del archivo adicional a anexar en el timbrado. Utilizado para complementos y
    ///     carta porte.
    /// </param>
    void Timbrar(string codigoConceptoDocumento, string serieDocumento, double folioDocumento, string contrasenaCertificado,
        string rutaArchivoAdicional = "");

    /// <summary>
    ///     Timbra un documento por su llave.
    /// </summary>
    /// <param name="documento">LLave del documento a timbrar.</param>
    /// <param name="contrasenaCertificado">Contraseña del certificado.</param>
    /// <param name="rutaArchivoAdicional">
    ///     Ruta del archivo adicional a anexar en el timbrado. Utilizado para complementos y
    ///     carta porte.
    /// </param>
    void Timbrar(tLlaveDoc documento, string contrasenaCertificado, string rutaArchivoAdicional = "");
}

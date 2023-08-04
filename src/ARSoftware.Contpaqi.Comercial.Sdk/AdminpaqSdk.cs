using System.Runtime.InteropServices;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk;

public static class AdminpaqSdk
{
    [DllImport("MGW_SDK.dll", EntryPoint = "fAbreEmpresa")]
    public static extern int fAbreEmpresa(string aDirectorioEmpresa);

    [DllImport("MGW_SDK.dll", EntryPoint = "fActivarPrecioCompra")]
    public static extern int fActivarPrecioCompra(int aActivar);

    [DllImport("MGW_SDK.dll", EntryPoint = "fActualizaClasificacion")]
    public static extern int fActualizaClasificacion(int aClasificacionDe, int aNumClasificacion, string aNombreClasificacion);

    [DllImport("MGW_SDK.dll", EntryPoint = "fActualizaCteProv")]
    public static extern int fActualizaCteProv(string aCodigoCteProv, ref tCteProv astCteProv);

    [DllImport("MGW_SDK.dll", EntryPoint = "fActualizaDireccion")]
    public static extern int fActualizaDireccion(ref tDireccion astDireccion);

    [DllImport("MGW_SDK.dll", EntryPoint = "fActualizaProducto")]
    public static extern int fActualizaProducto(string aCodigoProducto, ref tProducto astProducto);

    [DllImport("MGW_SDK.dll", EntryPoint = "fActualizaUnidad")]
    public static extern int fActualizaUnidad(string aNombreUnidad, ref tUnidad astUnidad);

    [DllImport("MGW_SDK.dll", EntryPoint = "fActualizaValorClasif")]
    public static extern int fActualizaValorClasif(string aCodigoValorClasif, ref tValorClasificacion astValorClasif);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAfectaDocto")]
    public static extern int fAfectaDocto(ref tLlaveDoc aLlaveDocto, bool aAfecta);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAfectaDocto_Param")]
    public static extern int fAfectaDocto_Param(string aCodConcepto, string aSerie, double aFolio, bool aAfecta);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAfectaSerie")]
    public static extern int fAfectaSerie(int aIdMovto, string aNumeroSerie);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAgregarRelacionCFDI")]
    public static extern int fAgregarRelacionCFDI(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion,
        string aConceptoRelacionar, string aSerieRelacionar, string aFolioRelacionar);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAgregarRelacionCFDI2")]
    public static extern int fAgregarRelacionCFDI2(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion, string aUUID);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaCteProv")]
    public static extern int fAltaCteProv(ref int aIdCteProv, ref tCteProv astCteProv);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaDireccion")]
    public static extern int fAltaDireccion(ref int aIdDireccion, ref tDireccion astDireccion);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaDoctoAjusteIESPSCteProv")]
    public static extern int fAltaDoctoAjusteIESPSCteProv(string aCodigoClienteProveedor, int aEsCliente, string aFechaDocto, int aIdMoneda,
        double aTipoCambio, double aImporteIVA, double aTasaIVA, double aImporteIESPS, double aTasaIESPS, int aIdFacturaBase,
        string aMetodo, string aLugar, ref int aIdDoctoGenerado);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaDoctoAjusteIVAClienteProveedor")]
    public static extern int fAltaDoctoAjusteIVAClienteProveedor(string aCodigoClienteProveedor, int aEsCliente, int aAbsorberAjusteIVA,
        string aFechaDocto, int aIdMoneda, double aTipoCambio, double aImporteIVA, double aTasaIVA, int aIdFacturaBase, string aMetodo,
        string aLugar, ref int aIdDoctoGenerado);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaDocumento")]
    public static extern int fAltaDocumento(ref int aIdDocumento, ref tDocumento aDocumento);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaDocumentoCargoAbono")]
    public static extern int fAltaDocumentoCargoAbono(ref tDocumento aDocumento);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaDocumentoCargoAbonoExtras")]
    public static extern int fAltaDocumentoCargoAbonoExtras(ref tDocumento aDocumento, string aTextoExtra1, string aTextoExtra2,
        string aTextoExtra3, string aFechaExtra, double aImporteExtra1, double aImporteExtra2, double aImporteExtra3,
        double aImporteExtra4);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaMovimiento")]
    public static extern int fAltaMovimiento(int aIdDocumento, ref int aIdMovimiento, ref tMovimiento astMovimiento);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaMovimientoCaracteristicas")]
    public static extern int fAltaMovimientoCaracteristicas(int aIdMovimiento, ref int aIdMovtoCaracteristicas,
        ref tCaracteristicas aCaracteristicas);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaMovimientoCaracteristicas_Param")]
    public static extern int fAltaMovimientoCaracteristicas_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidades,
        string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaMovimientoCDesct")]
    public static extern int fAltaMovimientoCDesct(int aIdDocumento, ref int aIdMovimiento, ref tMovimientoDesc astMovimiento);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaMovimientoEx")]
    public static extern int fAltaMovimientoEx(ref int aIdMovimiento, ref tTipoProducto aTipoProducto);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaMovimientoSeriesCapas")]
    public static extern int fAltaMovimientoSeriesCapas(int aIdMovimiento, ref tSeriesCapas aSeriesCapas);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaMovimientoSeriesCapas_Param")]
    public static extern int fAltaMovimientoSeriesCapas_Param(string aIdMovimiento, string aUnidades, string aTipoCambio, string aSeries,
        string aPedimento, string aAgencia, string aFechaPedimento, string aNumeroLote, string aFechaFabricacion, string aFechaCaducidad);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaMovtoCaracteristicasUnidades")]
    public static extern int fAltaMovtoCaracteristicasUnidades(int aIdMovimiento, ref int aIdMovtoCaracteristicas,
        ref tCaracteristicas aCaracteristicasUnidades);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaMovtoCaracteristicasUnidades_Param")]
    public static extern int fAltaMovtoCaracteristicasUnidades_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidad,
        string aUnidades, string aUnidadesNC, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaProducto")]
    public static extern int fAltaProducto(ref int aIdProducto, ref tProducto astProducto);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaUnidad")]
    public static extern int fAltaUnidad(ref int aIdUnidad, ref tUnidad astUnidad);

    [DllImport("MGW_SDK.dll", EntryPoint = "fAltaValorClasif")]
    public static extern int fAltaValorClasif(ref int aIdValorClasif, ref tValorClasificacion astValorClasif);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBorraCteProv")]
    public static extern int fBorraCteProv();

    [DllImport("MGW_SDK.dll", EntryPoint = "fBorraDocumento")]
    public static extern int fBorraDocumento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fBorraDocumento_CW")]
    public static extern int fBorraDocumento_CW();

    [DllImport("MGW_SDK.dll", EntryPoint = "fBorraProducto")]
    public static extern int fBorraProducto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fBorrarAsociacion")]
    public static extern int fBorrarAsociacion(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBorrarAsociacion_Param")]
    public static extern int fBorrarAsociacion_Param(string aCodConcepto_Pagar, string aSerie_Pagar, double aFolio_Pagar,
        string aCodConcepto_Pago, string aSerie_Pago, double aFolio_Pago);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBorraUnidad")]
    public static extern int fBorraUnidad();

    [DllImport("MGW_SDK.dll", EntryPoint = "fBorraValorClasif")]
    public static extern int fBorraValorClasif();

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaAgente")]
    public static extern int fBuscaAgente(string aCodigoAgente);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaAlmacen")]
    public static extern int fBuscaAlmacen(string aCodigoAlmacen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaClasificacion")]
    public static extern int fBuscaClasificacion(int aClasificacionDe, int aNumClasificacion);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaConceptoDocto")]
    public static extern int fBuscaConceptoDocto(string aCodConcepto);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaCteProv")]
    public static extern int fBuscaCteProv(string aCodCteProv);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaDireccionCteProv")]
    public static extern int fBuscaDireccionCteProv(string aCodCteProv, byte aTipoDireccion);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaDireccionDocumento")]
    public static extern int fBuscaDireccionDocumento(int aIdDocumento, byte aTipoDireccion);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaDireccionEmpresa")]
    public static extern int fBuscaDireccionEmpresa();

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaDocumento")]
    public static extern int fBuscaDocumento(ref tLlaveDoc aLlaveDocto);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaIdAgente")]
    public static extern int fBuscaIdAgente(int aIdAgente);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaIdAlmacen")]
    public static extern int fBuscaIdAlmacen(int aIdAlmacen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaIdClasificacion")]
    public static extern int fBuscaIdClasificacion(int aIdClasificacion);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaIdConceptoDocto")]
    public static extern int fBuscaIdConceptoDocto(int aIdConcepto);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaIdCteProv")]
    public static extern int fBuscaIdCteProv(int aIdCteProv);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaIdProducto")]
    public static extern int fBuscaIdProducto(int aIdProducto);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaIdUnidad")]
    public static extern int fBuscaIdUnidad(int aIdUnidad);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaIdValorClasif")]
    public static extern int fBuscaIdValorClasif(int aIdValorClasif);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaProducto")]
    public static extern int fBuscaProducto(string aCodProducto);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscarDocumento")]
    public static extern int fBuscarDocumento(string aCodConcepto, string aSerie, string aFolio);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscarIdDocumento")]
    public static extern int fBuscarIdDocumento(int aIdDocumento);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscarIdMovimiento")]
    public static extern int fBuscarIdMovimiento(int aIdMovimiento);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaUnidad")]
    public static extern int fBuscaUnidad(string aNombreUnidad);

    [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaValorClasif")]
    public static extern int fBuscaValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodValorClasif);

    [DllImport("MGW_SDK.dll", EntryPoint = "fCalculaMovtoSerieCapa")]
    public static extern int fCalculaMovtoSerieCapa(int aIdMovimiento);

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelaCambiosMovimiento")]
    public static extern int fCancelaCambiosMovimiento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelaComplementoPagoUUID")]
    public static extern int fCancelaComplementoPagoUUID(string aUUID, string aIdDConcepto, string aPass);

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelaDoctoInfo")]
    public static extern int fCancelaDoctoInfo(string aPass);

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelaDocumento")]
    public static extern int fCancelaDocumento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelaDocumento_CW")]
    public static extern int fCancelaDocumento_CW();

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelaDocumentoConMotivo")]
    public static extern int fCancelaDocumentoConMotivo(string aMotivoCancelacion, string aUUIDRemplaza);

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelaFiltroDocumento")]
    public static extern int fCancelaFiltroDocumento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelaFiltroMovimiento")]
    public static extern int fCancelaFiltroMovimiento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelaNominaUUID")]
    public static extern int fCancelaNominaUUID(string aUUID, string aIdDConcepto, string aPass);

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionAgente")]
    public static extern int fCancelarModificacionAgente();

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionAlmacen")]
    public static extern int fCancelarModificacionAlmacen();

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionClasificacion")]
    public static extern int fCancelarModificacionClasificacion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionCteProv")]
    public static extern int fCancelarModificacionCteProv();

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionDireccion")]
    public static extern int fCancelarModificacionDireccion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionDocumento")]
    public static extern int fCancelarModificacionDocumento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionProducto")]
    public static extern int fCancelarModificacionProducto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionUnidad")]
    public static extern int fCancelarModificacionUnidad();

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionValorClasif")]
    public static extern int fCancelarModificacionValorClasif();

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelaUUID")]
    public static extern int fCancelaUUID(string aUUID, string aIdDConcepto, string aPass);

    [DllImport("MGW_SDK.dll", EntryPoint = "fCancelaUUID40")]
    public static extern int fCancelaUUID40(string aUUID, string aMotivoCancelacion, string aUUIDReemplaza, string RFCReceptor,
        double aTotal, string aIdDConcepto, string aPass, ref int aEstatusCancelacion);

    [DllImport("MGW_SDK.dll", EntryPoint = "fCierraEmpresa")]
    public static extern void fCierraEmpresa();

    [DllImport("MGW_SDK.dll", EntryPoint = "fDocumentoBloqueado")]
    public static extern int fDocumentoBloqueado(ref int aImpreso);

    [DllImport("MGW_SDK.dll", EntryPoint = "fDocumentoDevuelto")]
    public static extern int fDocumentoDevuelto(ref int aDevuelto);

    [DllImport("MGW_SDK.dll", EntryPoint = "fDocumentoImpreso")]
    public static extern int fDocumentoImpreso(ref bool aImpreso);

    [DllImport("MGW_SDK.dll", EntryPoint = "fDocumentoUUID")]
    public static extern int fDocumentoUUID(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, StringBuilder atPtrCFDIUUID);

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditaAgente")]
    public static extern int fEditaAgente();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditaAlmacen")]
    public static extern int fEditaAlmacen();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditaClasificacion")]
    public static extern int fEditaClasificacion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditaConceptoDocto")]
    public static extern int fEditaConceptoDocto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditaCteProv")]
    public static extern int fEditaCteProv();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditaDireccion")]
    public static extern int fEditaDireccion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditaMovtoContable")]
    public static extern int fEditaMovtoContable();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditaParametros")]
    public static extern int fEditaParametros();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditaProducto")]
    public static extern int fEditaProducto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditarDocumento")]
    public static extern int fEditarDocumento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditarDocumentoCheqpaq")]
    public static extern int fEditarDocumentoCheqpaq();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditarMovimiento")]
    public static extern int fEditarMovimiento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditaUnidad")]
    public static extern int fEditaUnidad();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditaValorClasif")]
    public static extern int fEditaValorClasif();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEliminarCteProv")]
    public static extern int fEliminarCteProv(string aCodigoCteProv);

    [DllImport("MGW_SDK.dll", EntryPoint = "fEliminarProducto")]
    public static extern int fEliminarProducto(string aCodigoProducto);

    [DllImport("MGW_SDK.dll", EntryPoint = "fEliminarRelacionesCFDIs")]
    public static extern int fEliminarRelacionesCFDIs(string aCodConcepto, string aSerie, string aFolio);

    [DllImport("MGW_SDK.dll", EntryPoint = "fEliminarUnidad")]
    public static extern int fEliminarUnidad(string aNombreUnidad);

    [DllImport("MGW_SDK.dll", EntryPoint = "fEliminarValorClasif")]
    public static extern int fEliminarValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodigoValorClasif);

    [DllImport("MGW_SDK.dll", EntryPoint = "fEmitirDocumento")]
    public static extern int fEmitirDocumento([MarshalAs(UnmanagedType.LPStr)] string aCodConcepto,
        [MarshalAs(UnmanagedType.LPStr)] string aSerie, double aFolio, [MarshalAs(UnmanagedType.LPStr)] string aPassword,
        [MarshalAs(UnmanagedType.LPStr)] string aArchivoAdicional);

    [DllImport("MGW_SDK.dll", EntryPoint = "fEntregEnDiscoXML")]
    public static extern int fEntregEnDiscoXML(string aCodConcepto, string aSerie, double aFolio, int aFormato, string aFormatoAmig);

    [DllImport("MGW_SDK.dll", EntryPoint = "fError")]
    public static extern void fError(int aNumError, StringBuilder aMensaje, int aLen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fGetCantidadParcialidades")]
    public static extern int fGetCantidadParcialidades(StringBuilder atPtrPassword, StringBuilder aCantidadParcialidades);

    [DllImport("MGW_SDK.dll", EntryPoint = "fGetNumParcialidades")]
    public static extern int fGetNumParcialidades(StringBuilder atPtrPassword, StringBuilder aNumParcialidades);

    [DllImport("MGW_SDK.dll", EntryPoint = "fGetSelloDigitalYCadena")]
    public static extern int fGetSelloDigitalYCadena(StringBuilder atPtrPassword, StringBuilder atPtrSelloDigital,
        StringBuilder atPtrCadenaOriginal);

    [DllImport("MGW_SDK.dll", EntryPoint = "fGetSerieCertificado")]
    public static extern int fGetSerieCertificado(StringBuilder atPtrPassword, StringBuilder aSerieCertificado);

    [DllImport("MGW_SDK.dll", EntryPoint = "fGetTamSelloDigitalYCadena")]
    public static extern int fGetTamSelloDigitalYCadena(StringBuilder atPtrPassword, ref int aEspSelloDig, ref int aEspCadOrig);

    [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaAgente")]
    public static extern int fGuardaAgente();

    [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaAlmacen")]
    public static extern int fGuardaAlmacen();

    [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaClasificacion")]
    public static extern int fGuardaClasificacion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaConceptoDocto")]
    public static extern int fGuardaConceptoDocto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaCteProv")]
    public static extern int fGuardaCteProv();

    [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaDireccion")]
    public static extern int fGuardaDireccion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaDocumento")]
    public static extern int fGuardaDocumento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaMovimiento")]
    public static extern int fGuardaMovimiento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaMovtoContable")]
    public static extern int fGuardaMovtoContable();

    [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaParametros")]
    public static extern int fGuardaParametros();

    [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaProducto")]
    public static extern int fGuardaProducto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaUnidad")]
    public static extern int fGuardaUnidad();

    [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaValorClasif")]
    public static extern int fGuardaValorClasif();

    [DllImport("MGW_SDK.dll", EntryPoint = "fInformacionCliente")]
    public static extern int fInformacionCliente(StringBuilder aCodigo, ref int aPermiteCredito, ref double aLimiteCredito,
        ref int aLimiteDoctosVencidos, ref int aPermiteExcederCredito, StringBuilder aFecha, ref double aSaldo, ref double aSaldoPendiente,
        ref int aDoctosVencidos);

    [DllImport("MGW_SDK.dll", EntryPoint = "fInicializaLicenseInfo")]
    public static extern int fInicializaLicenseInfo(byte aSistema);

    [DllImport("MGW_SDK.dll", EntryPoint = "fInicializaSDK")]
    public static extern int fInicializaSDK();

    [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaAgente")]
    public static extern int fInsertaAgente();

    [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaAlmacen")]
    public static extern int fInsertaAlmacen();

    [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaCteProv")]
    public static extern int fInsertaCteProv();

    [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaDatoAddendaDocto")]
    public static extern int fInsertaDatoAddendaDocto(int aIdAddenda, int aIdCatalogo, int aNumCampo, string aDato);

    [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaDatoAddendaMovto")]
    public static extern int fInsertaDatoAddendaMovto(int aIdAddenda, int aIdCatalogo, int aNumCampo, string aDato);

    [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaDatoCompEducativo")]
    public static extern int fInsertaDatoCompEducativo(int aIdServicio, int aNumCampo, string aDato);

    [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaDireccion")]
    public static extern int fInsertaDireccion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaProducto")]
    public static extern int fInsertaProducto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fInsertarDocumento")]
    public static extern int fInsertarDocumento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fInsertarMovimiento")]
    public static extern int fInsertarMovimiento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaUnidad")]
    public static extern int fInsertaUnidad();

    [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaValorClasif")]
    public static extern int fInsertaValorClasif();

    [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoAgente")]
    public static extern int fLeeDatoAgente(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoAlmacen")]
    public static extern int fLeeDatoAlmacen(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoCFDI")]
    public static extern int fLeeDatoCFDI(StringBuilder aValor, int aDato);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoClasificacion")]
    public static extern int fLeeDatoClasificacion(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoConceptoDocto")]
    public static extern int fLeeDatoConceptoDocto(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoCteProv")]
    public static extern int fLeeDatoCteProv(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoDireccion")]
    public static extern int fLeeDatoDireccion(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoDocumento")]
    public static extern int fLeeDatoDocumento(string aCampo, StringBuilder aValor, int aLongitud);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoMovimiento")]
    public static extern int fLeeDatoMovimiento(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoMovtoContable")]
    public static extern int fLeeDatoMovtoContable(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoParametros")]
    public static extern int fLeeDatoParametros(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoProducto")]
    public static extern int fLeeDatoProducto(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoUnidad")]
    public static extern int fLeeDatoUnidad(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoValorClasif")]
    public static extern int fLeeDatoValorClasif(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLlenaRegistroCteProv")]
    public static extern int fLlenaRegistroCteProv(ref tCteProv astCteProv, int aEsAlta);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLlenaRegistroDireccion")]
    public static extern int fLlenaRegistroDireccion(ref tDireccion astDireccion, int aEsAlta);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLlenaRegistroProducto")]
    public static extern int fLlenaRegistroProducto(ref tProducto astProducto, int aEsAlta);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLlenaRegistroUnidad")]
    public static extern int fLlenaRegistroUnidad(ref tUnidad astUnidad);

    [DllImport("MGW_SDK.dll", EntryPoint = "fLlenaRegistroValorClasif")]
    public static extern int fLlenaRegistroValorClasif(ref tValorClasificacion astValorClasif);

    [DllImport("MGW_SDK.dll", EntryPoint = "fModificaCostoEntrada")]
    public static extern int fModificaCostoEntrada(string aIdMovimiento, string aCostoEntrada);

    [DllImport("MGW_SDK.dll", EntryPoint = "fObtenCeryKey")]
    public static extern int fObtenCeryKey(int aIdFirmarl, string aRutaKey, string aRutaCer);

    [DllImport("MGW_SDK.dll", EntryPoint = "fObtieneDatosCFDI")]
    public static extern int fObtieneDatosCFDI(string atPtrPassword);

    [DllImport("MGW_SDK.dll", EntryPoint = "fObtieneLicencia")]
    public static extern int fObtieneLicencia(StringBuilder aCodAcvtiva, StringBuilder aCodSitio, StringBuilder aSerie,
        StringBuilder aTagVersion);

    [DllImport("MGW_SDK.dll", EntryPoint = "fObtienePassProxy")]
    public static extern int fObtienePassProxy(StringBuilder aPassProxy);

    [DllImport("MGW_SDK.dll", EntryPoint = "fObtieneUnidadesPendientes")]
    public static extern int fObtieneUnidadesPendientes(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen,
        StringBuilder aUnidades);

    [DllImport("MGW_SDK.dll", EntryPoint = "fObtieneUnidadesPendientesCarac")]
    public static extern int fObtieneUnidadesPendientesCarac(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen,
        string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, StringBuilder aUnidades);

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorAgente")]
    public static extern int fPosAnteriorAgente();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorAlmacen")]
    public static extern int fPosAnteriorAlmacen();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorClasificacion")]
    public static extern int fPosAnteriorClasificacion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorConceptoDocto")]
    public static extern int fPosAnteriorConceptoDocto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorCteProv")]
    public static extern int fPosAnteriorCteProv();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorDireccion")]
    public static extern int fPosAnteriorDireccion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorDocumento")]
    public static extern int fPosAnteriorDocumento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorMovimiento")]
    public static extern int fPosAnteriorMovimiento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorProducto")]
    public static extern int fPosAnteriorProducto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorUnidad")]
    public static extern int fPosAnteriorUnidad();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorValorClasif")]
    public static extern int fPosAnteriorValorClasif();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOF")]
    public static extern int fPosBOF();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFAgente")]
    public static extern int fPosBOFAgente();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFAlmacen")]
    public static extern int fPosBOFAlmacen();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFClasificacion")]
    public static extern int fPosBOFClasificacion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFConceptoDocto")]
    public static extern int fPosBOFConceptoDocto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFCteProv")]
    public static extern int fPosBOFCteProv();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFDireccion")]
    public static extern int fPosBOFDireccion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFProducto")]
    public static extern int fPosBOFProducto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFUnidad")]
    public static extern int fPosBOFUnidad();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFValorClasif")]
    public static extern int fPosBOFValorClasif();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOF")]
    public static extern int fPosEOF();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFAgente")]
    public static extern int fPosEOFAgente();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFAlmacen")]
    public static extern int fPosEOFAlmacen();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFClasificacion")]
    public static extern int fPosEOFClasificacion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFConceptoDocto")]
    public static extern int fPosEOFConceptoDocto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFCteProv")]
    public static extern int fPosEOFCteProv();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFDireccion")]
    public static extern int fPosEOFDireccion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFMovtoContable")]
    public static extern int fPosEOFMovtoContable();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFProducto")]
    public static extern int fPosEOFProducto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFUnidad")]
    public static extern int fPosEOFUnidad();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFValorClasif")]
    public static extern int fPosEOFValorClasif();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosMovimientoBOF")]
    public static extern int fPosMovimientoBOF();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosMovimientoEOF")]
    public static extern int fPosMovimientoEOF();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerAgente")]
    public static extern int fPosPrimerAgente();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerAlmacen")]
    public static extern int fPosPrimerAlmacen();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerClasificacion")]
    public static extern int fPosPrimerClasificacion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerConceptoDocto")]
    public static extern int fPosPrimerConceptoDocto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerCteProv")]
    public static extern int fPosPrimerCteProv();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerDireccion")]
    public static extern int fPosPrimerDireccion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerDocumento")]
    public static extern int fPosPrimerDocumento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerEmpresa")]
    public static extern int fPosPrimerEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa);

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerMovimiento")]
    public static extern int fPosPrimerMovimiento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerMovtoContable")]
    public static extern int fPosPrimerMovtoContable();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerProducto")]
    public static extern int fPosPrimerProducto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerUnidad")]
    public static extern int fPosPrimerUnidad();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerValorClasif")]
    public static extern int fPosPrimerValorClasif();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteAgente")]
    public static extern int fPosSiguienteAgente();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteAlmacen")]
    public static extern int fPosSiguienteAlmacen();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteClasificacion")]
    public static extern int fPosSiguienteClasificacion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteConceptoDocto")]
    public static extern int fPosSiguienteConceptoDocto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteCteProv")]
    public static extern int fPosSiguienteCteProv();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteDireccion")]
    public static extern int fPosSiguienteDireccion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteDocumento")]
    public static extern int fPosSiguienteDocumento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteEmpresa")]
    public static extern int fPosSiguienteEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa);

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteMovimiento")]
    public static extern int fPosSiguienteMovimiento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteMovtoContable")]
    public static extern int fPosSiguienteMovtoContable();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteProducto")]
    public static extern int fPosSiguienteProducto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteUnidad")]
    public static extern int fPosSiguienteUnidad();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteValorClasif")]
    public static extern int fPosSiguienteValorClasif();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimaConceptoDocto")]
    public static extern int fPosUltimaConceptoDocto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimaDireccion")]
    public static extern int fPosUltimaDireccion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimoAgente")]
    public static extern int fPosUltimoAgente();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimoAlmacen")]
    public static extern int fPosUltimoAlmacen();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimoClasificacion")]
    public static extern int fPosUltimoClasificacion();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimoCteProv")]
    public static extern int fPosUltimoCteProv();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimoDocumento")]
    public static extern int fPosUltimoDocumento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimoMovimiento")]
    public static extern int fPosUltimoMovimiento();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimoProducto")]
    public static extern int fPosUltimoProducto();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimoUnidad")]
    public static extern int fPosUltimoUnidad();

    [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimoValorClasif")]
    public static extern int fPosUltimoValorClasif();

    [DllImport("MGW_SDK.dll", EntryPoint = "fRecosteoProducto")]
    public static extern int fRecosteoProducto(string aCodigoProducto, int aEjercicio, int aPeriodo, string aCodigoClasificacion1,
        string aCodigoClasificacion2, string aCodigoClasificacion3, string aCodigoClasificacion4, string aCodigoClasificacion5,
        string aCodigoClasificacion6, string aNombreBitacora, int aSobreEscribirBitacora, int aEsCalculoArimetico);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRecuperarRelacionesCFDIs")]
    public static extern int fRecuperarRelacionesCFDIs(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion,
        StringBuilder aUUIDs, string aRutaNombreArchivoInfo);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRecuperaTipoProducto")]
    public static extern int fRecuperaTipoProducto(ref bool aUnidades, ref bool aSerie, ref bool aLote, ref bool aPedimento,
        ref bool aCaracteristicas);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaCostoCapa")]
    public static extern int fRegresaCostoCapa(string aCodigoProducto, string aCodigoAlmacen, double aUnidades,
        StringBuilder aImporteCosto);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaCostoEstandar")]
    public static extern int fRegresaCostoEstandar(string aCodigoProducto, StringBuilder aCostoEstandar);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaCostoPromedio")]
    public static extern int fRegresaCostoPromedio(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        StringBuilder aCostoPromedio);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaExistencia")]
    public static extern int fRegresaExistencia(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        ref double aExistencia);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaExistenciaCaracteristicas")]
    public static extern int fRegresaExistenciaCaracteristicas(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes,
        string aDia, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, ref double aExistencia);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaIVACargo")]
    public static extern int fRegresaIVACargo(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero,
        double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaIVACargo_2010")]
    public static extern int fRegresaIVACargo_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16,
        double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10,
        double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaIVACargoRet_2010")]
    public static extern int fRegresaIVACargoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16,
        double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10,
        double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaIVAPago")]
    public static extern int fRegresaIVAPago(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero,
        double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaIVAPago_2010")]
    public static extern int fRegresaIVAPago_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16,
        double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10,
        double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaIVAPagoRet_2010")]
    public static extern int fRegresaIVAPagoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16,
        double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10,
        double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaPrecioVenta")]
    public static extern int fRegresaPrecioVenta(string aCodigoConcepto, string aCodigoCliente, string aCodigoProducto,
        StringBuilder aPrecioVenta);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaUltimoCosto")]
    public static extern int fRegresaUltimoCosto(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        StringBuilder aUltimoCosto);

    [DllImport("MGW_SDK.dll", EntryPoint = "fRegresPorcentajeImpuesto")]
    public static extern int fRegresPorcentajeImpuesto(int aIdConceptoDocumento, int aIdClienteProveedor, int aIdProducto,
        ref double aPorcentajeImpuesto);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSaldarDocumento")]
    public static extern int fSaldarDocumento(ref tLlaveDoc aDoctoaPagar, ref tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda,
        string aFecha);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSaldarDocumento_Param")]
    public static extern int fSaldarDocumento_Param(string aCodConcepto_Pagar, string aSerie_Pagar, double aFolio_Pagar,
        string aCodConcepto_Pago, string aSerie_Pago, double aFolio_Pago, double aImporte, int aIdMoneda, string aFecha);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSaldarDocumentoCheqPAQ")]
    public static extern int fSaldarDocumentoCheqPAQ(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda,
        string aFecha, double aTipoCambioCheqPAQ);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoAgente")]
    public static extern int fSetDatoAgente(string aCampo, string aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoAlmacen")]
    public static extern int fSetDatoAlmacen(string aCampo, string aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoClasificacion")]
    public static extern int fSetDatoClasificacion(string aCampo, string aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoConceptoDocto")]
    public static extern int fSetDatoConceptoDocto(string aCampo, string aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoCteProv")]
    public static extern int fSetDatoCteProv(string aCampo, string aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoDireccion")]
    public static extern int fSetDatoDireccion(string aCampo, string aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoDocumento")]
    public static extern int fSetDatoDocumento(string aCampo, string aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoMovimiento")]
    public static extern int fSetDatoMovimiento(string aCampo, string aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoMovtoContable")]
    public static extern int fSetDatoMovtoContable(string aCampo, string aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoParametros")]
    public static extern int fSetDatoParametros(string aCampo, StringBuilder aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoProducto")]
    public static extern int fSetDatoProducto(string aCampo, string aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoUnidad")]
    public static extern int fSetDatoUnidad(string aCampo, string aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoValorClasif")]
    public static extern int fSetDatoValorClasif(string aCampo, string aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDescripcionProducto")]
    public static extern int fSetDescripcionProducto(string aCampo, string aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetFiltroDocumento")]
    public static extern int fSetFiltroDocumento(string aFechaInicio, string aFechaFin, string aCodigoConcepto, string aCodigoCteProv);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetFiltroMovimiento")]
    public static extern int fSetFiltroMovimiento(int aIdDocumento);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetModoImportacion")]
    public static extern void fSetModoImportacion(bool aImportacion);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetNombrePAQ")]
    public static extern int fSetNombrePAQ(string aSistema);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSiguienteFolio")]
    public static extern int fSiguienteFolio(string aCodigoConcepto, StringBuilder aSerie, ref double aFolio);

    [DllImport("MGW_SDK.dll", EntryPoint = "fTerminaSDK")]
    public static extern void fTerminaSDK();

    [DllImport("MGW_SDK.dll", EntryPoint = "fTimbraComplementoPagoXML")]
    public static extern int fTimbraComplementoPagoXML(string aRutaXML, string aCodConcepto, StringBuilder aUUID, string aRutaDDA,
        string aRutaResultado, string aPass, string aRutaFormato);

    [DllImport("MGW_SDK.dll", EntryPoint = "fTimbraComplementoXML")]
    public static extern int fTimbraComplementoXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA,
        string aRutaResultado, string aPass, string aRutaFormato, int aComplemento);

    [DllImport("MGW_SDK.dll", EntryPoint = "fTimbraNominaXML")]
    public static extern int fTimbraNominaXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA,
        string aRutaResultado, string aPass, string aRutaFormato);

    [DllImport("MGW_SDK.dll", EntryPoint = "fTimbraXML")]
    public static extern int fTimbraXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado,
        string aPass, string aRutaFormato);
}

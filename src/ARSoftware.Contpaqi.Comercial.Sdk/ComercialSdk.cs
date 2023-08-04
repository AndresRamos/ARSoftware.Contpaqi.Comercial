using System.Runtime.InteropServices;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk;

public static class ComercialSdk
{
    [DllImport("MGWServicios.dll", EntryPoint = "fAbreEmpresa")]
    public static extern int fAbreEmpresa(string aDirectorioEmpresa);

    [DllImport("MGWServicios.dll", EntryPoint = "fActivarPrecioCompra")]
    public static extern int fActivarPrecioCompra(int aActivar);

    [DllImport("MGWServicios.dll", EntryPoint = "fActualizaClasificacion")]
    public static extern int fActualizaClasificacion(int aClasificacionDe, int aNumClasificacion, string aNombreClasificacion);

    [DllImport("MGWServicios.dll", EntryPoint = "fActualizaCteProv")]
    public static extern int fActualizaCteProv(string aCodigoCteProv, ref tCteProv astCteProv);

    [DllImport("MGWServicios.dll", EntryPoint = "fActualizaDireccion")]
    public static extern int fActualizaDireccion(ref tDireccion astDireccion);

    [DllImport("MGWServicios.dll", EntryPoint = "fActualizaProducto")]
    public static extern int fActualizaProducto(string aCodigoProducto, ref tProducto astProducto);

    [DllImport("MGWServicios.dll", EntryPoint = "fActualizaUnidad")]
    public static extern int fActualizaUnidad(string aNombreUnidad, ref tUnidad astUnidad);

    [DllImport("MGWServicios.dll", EntryPoint = "fActualizaValorClasif")]
    public static extern int fActualizaValorClasif(string aCodigoValorClasif, ref tValorClasificacion astValorClasif);

    [DllImport("MGWServicios.dll", EntryPoint = "fAfectaDocto")]
    public static extern int fAfectaDocto(ref tLlaveDoc aLlaveDocto, bool aAfecta);

    [DllImport("MGWServicios.dll", EntryPoint = "fAfectaDocto_Param")]
    public static extern int fAfectaDocto_Param(string aCodConcepto, string aSerie, double aFolio, bool aAfecta);

    [DllImport("MGWServicios.dll", EntryPoint = "fAfectaSerie")]
    public static extern int fAfectaSerie(int aIdMovto, string aNumeroSerie);

    [DllImport("MGWServicios.dll", EntryPoint = "fAgregarRelacionCFDI")]
    public static extern int fAgregarRelacionCFDI(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion,
        string aConceptoRelacionar, string aSerieRelacionar, string aFolioRelacionar);

    [DllImport("MGWServicios.dll", EntryPoint = "fAgregarRelacionCFDI2")]
    public static extern int fAgregarRelacionCFDI2(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion, string aUUID);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaCteProv")]
    public static extern int fAltaCteProv(ref int aIdCteProv, ref tCteProv astCteProv);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaCuentaBancariaCliente")]
    public static extern int fAltaCuentaBancariaCliente(ref int aIdCtaBancaria, string aCuentaBancaria, string aNombreCuenta,
        string aNombreMoneda, string aClaveBanco, string aClabe, string aRfcBanco, string aNombreBancoExtranjero, string aCodigoCliente);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaCuentaBancariaEmpresa")]
    public static extern int fAltaCuentaBancariaEmpresa(ref int aIdCtaBancaria, string aCuentaBancaria, string aNombreCuenta,
        string aNombreMoneda, string aClaveBanco, string aClabe, string aRfcBanco, string aNombreBancoExtranjero);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaDireccion")]
    public static extern int fAltaDireccion(ref int aIdDireccion, ref tDireccion astDireccion);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaDoctoAjusteIESPSCteProv")]
    public static extern int fAltaDoctoAjusteIESPSCteProv(string aCodigoClienteProveedor, int aEsCliente, string aFechaDocto, int aIdMoneda,
        double aTipoCambio, double aImporteIVA, double aTasaIVA, double aImporteIESPS, double aTasaIESPS, int aIdFacturaBase,
        string aMetodo, string aLugar, ref int aIdDoctoGenerado);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaDoctoAjusteIVAClienteProveedor")]
    public static extern int fAltaDoctoAjusteIVAClienteProveedor(string aCodigoClienteProveedor, int aEsCliente, int aAbsorberAjusteIVA,
        string aFechaDocto, int aIdMoneda, double aTipoCambio, double aImporteIVA, double aTasaIVA, int aIdFacturaBase, string aMetodo,
        string aLugar, ref int aIdDoctoGenerado);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaDocumento")]
    public static extern int fAltaDocumento(ref int aIdDocumento, ref tDocumento aDocumento);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaDocumentoCargoAbono")]
    public static extern int fAltaDocumentoCargoAbono(ref tDocumento aDocumento);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaDocumentoCargoAbonoExtras")]
    public static extern int fAltaDocumentoCargoAbonoExtras(ref tDocumento aDocumento, string aTextoExtra1, string aTextoExtra2,
        string aTextoExtra3, string aFechaExtra, double aImporteExtra1, double aImporteExtra2, double aImporteExtra3,
        double aImporteExtra4);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimiento")]
    public static extern int fAltaMovimiento(int aIdDocumento, ref int aIdMovimiento, ref tMovimiento astMovimiento);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimientoCaracteristicas")]
    public static extern int fAltaMovimientoCaracteristicas(int aIdMovimiento, ref int aIdMovtoCaracteristicas,
        ref tCaracteristicas aCaracteristicas);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimientoCaracteristicas_Param")]
    public static extern int fAltaMovimientoCaracteristicas_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidades,
        string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimientoCDesct")]
    public static extern int fAltaMovimientoCDesct(int aIdDocumento, ref int aIdMovimiento, ref tMovimientoDesc astMovimiento);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimientoEx")]
    public static extern int fAltaMovimientoEx(ref int aIdMovimiento, ref tTipoProducto aTipoProducto);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimientoSeriesCapas")]
    public static extern int fAltaMovimientoSeriesCapas(int aIdMovimiento, ref tSeriesCapas aSeriesCapas);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimientoSeriesCapas_Param")]
    public static extern int fAltaMovimientoSeriesCapas_Param(string aIdMovimiento, string aUnidades, string aTipoCambio, string aSeries,
        string aPedimento, string aAgencia, string aFechaPedimento, string aNumeroLote, string aFechaFabricacion, string aFechaCaducidad);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovtoCaracteristicasUnidades")]
    public static extern int fAltaMovtoCaracteristicasUnidades(int aIdMovimiento, ref int aIdMovtoCaracteristicas,
        ref tCaracteristicas aCaracteristicasUnidades);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovtoCaracteristicasUnidades_Param")]
    public static extern int fAltaMovtoCaracteristicasUnidades_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidad,
        string aUnidades, string aUnidadesNC, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaProducto")]
    public static extern int fAltaProducto(ref int aIdProducto, ref tProducto astProducto);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaUnidad")]
    public static extern int fAltaUnidad(ref int aIdUnidad, ref tUnidad astUnidad);

    [DllImport("MGWServicios.dll", EntryPoint = "fAltaValorClasif")]
    public static extern int fAltaValorClasif(ref int aIdValorClasif, ref tValorClasificacion astValorClasif);

    [DllImport("MGWServicios.dll", EntryPoint = "fBorraCteProv")]
    public static extern int fBorraCteProv();

    [DllImport("MGWServicios.dll", EntryPoint = "fBorraCuentaBancariaCliente")]
    public static extern int fBorraCuentaBancariaCliente(string aCuentaBancaria, string aCodigoCliente);

    [DllImport("MGWServicios.dll", EntryPoint = "fBorraCuentaBancariaEmpresa")]
    public static extern int fBorraCuentaBancariaEmpresa(string aCuentaBancaria);

    [DllImport("MGWServicios.dll", EntryPoint = "fBorraDocumento")]
    public static extern int fBorraDocumento();

    [DllImport("MGWServicios.dll", EntryPoint = "fBorraDocumento_CW")]
    public static extern int fBorraDocumento_CW();

    [DllImport("MGWServicios.dll", EntryPoint = "fBorraMovimiento")]
    public static extern int fBorraMovimiento(int aIdDocumento, int aIdMovimiento);

    [DllImport("MGWServicios.dll", EntryPoint = "fBorraProducto")]
    public static extern int fBorraProducto();

    [DllImport("MGWServicios.dll", EntryPoint = "fBorrarAsociacion")]
    public static extern int fBorrarAsociacion(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago);

    [DllImport("MGWServicios.dll", EntryPoint = "fBorrarAsociacion_Param")]
    public static extern int fBorrarAsociacion_Param(string aCodConcepto_Pagar, string aSerie_Pagar, double aFolio_Pagar,
        string aCodConcepto_Pago, string aSerie_Pago, double aFolio_Pago);

    [DllImport("MGWServicios.dll", EntryPoint = "fBorraUnidad")]
    public static extern int fBorraUnidad();

    [DllImport("MGWServicios.dll", EntryPoint = "fBorraValorClasif")]
    public static extern int fBorraValorClasif();

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaAgente")]
    public static extern int fBuscaAgente(string aCodigoAgente);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaAlmacen")]
    public static extern int fBuscaAlmacen(string aCodigoAlmacen);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaClasificacion")]
    public static extern int fBuscaClasificacion(int aClasificacionDe, int aNumClasificacion);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaConceptoDocto")]
    public static extern int fBuscaConceptoDocto(string aCodConcepto);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaCteProv")]
    public static extern int fBuscaCteProv(string aCodCteProv);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaDireccionCteProv")]
    public static extern int fBuscaDireccionCteProv(string aCodCteProv, byte aTipoDireccion);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaDireccionDocumento")]
    public static extern int fBuscaDireccionDocumento(int aIdDocumento, byte aTipoDireccion);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaDireccionEmpresa")]
    public static extern int fBuscaDireccionEmpresa();

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaDocumento")]
    public static extern int fBuscaDocumento(ref tLlaveDoc aLlaveDocto);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaIdAgente")]
    public static extern int fBuscaIdAgente(int aIdAgente);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaIdAlmacen")]
    public static extern int fBuscaIdAlmacen(int aIdAlmacen);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaIdClasificacion")]
    public static extern int fBuscaIdClasificacion(int aIdClasificacion);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaIdConceptoDocto")]
    public static extern int fBuscaIdConceptoDocto(int aIdConcepto);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaIdCteProv")]
    public static extern int fBuscaIdCteProv(int aIdCteProv);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaIdProducto")]
    public static extern int fBuscaIdProducto(int aIdProducto);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaIdUnidad")]
    public static extern int fBuscaIdUnidad(int aIdUnidad);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaIdValorClasif")]
    public static extern int fBuscaIdValorClasif(int aIdValorClasif);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaProducto")]
    public static extern int fBuscaProducto(string aCodProducto);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscarDocumento")]
    public static extern int fBuscarDocumento(string aCodConcepto, string aSerie, string aFolio);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscarIdDocumento")]
    public static extern int fBuscarIdDocumento(int aIdDocumento);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscarIdMovimiento")]
    public static extern int fBuscarIdMovimiento(int aIdMovimiento);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaUnidad")]
    public static extern int fBuscaUnidad(string aNombreUnidad);

    [DllImport("MGWServicios.dll", EntryPoint = "fBuscaValorClasif")]
    public static extern int fBuscaValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodValorClasif);

    [DllImport("MGWServicios.dll", EntryPoint = "fCalculaMovtoSerieCapa")]
    public static extern int fCalculaMovtoSerieCapa(int aIdMovimiento);

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelaCambiosMovimiento")]
    public static extern int fCancelaCambiosMovimiento();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelaDoctoInfo")]
    public static extern int fCancelaDoctoInfo(string aPass);

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelaDocumento")]
    public static extern int fCancelaDocumento();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelaDocumento_CW")]
    public static extern int fCancelaDocumento_CW();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelaDocumentoAdministrativamente")]
    public static extern int fCancelaDocumentoAdministrativamente();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelaDocumentoConMotivo")]
    public static extern int fCancelaDocumentoConMotivo(string aMotivoCancelacion, string aUUIDRemplaza);

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelaFiltroDocumento")]
    public static extern int fCancelaFiltroDocumento();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelaFiltroMovimiento")]
    public static extern int fCancelaFiltroMovimiento();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelaNominaUUID")]
    public static extern int fCancelaNominaUUID(string aUUID, string aIdDConcepto, string aPass);

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelarModificacionAgente")]
    public static extern int fCancelarModificacionAgente();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelarModificacionAlmacen")]
    public static extern int fCancelarModificacionAlmacen();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelarModificacionClasificacion")]
    public static extern int fCancelarModificacionClasificacion();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelarModificacionCteProv")]
    public static extern int fCancelarModificacionCteProv();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelarModificacionDireccion")]
    public static extern int fCancelarModificacionDireccion();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelarModificacionDocumento")]
    public static extern int fCancelarModificacionDocumento();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelarModificacionProducto")]
    public static extern int fCancelarModificacionProducto();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelarModificacionUnidad")]
    public static extern int fCancelarModificacionUnidad();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelarModificacionValorClasif")]
    public static extern int fCancelarModificacionValorClasif();

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelaUUID")]
    public static extern int fCancelaUUID(string aUUID, string aIdDConcepto, string aPass);

    [DllImport("MGWServicios.dll", EntryPoint = "fCancelaUUID40")]
    public static extern int fCancelaUUID40(string aUUID, string aMotivoCancelacion, string aUUIDReemplaza, string RFCReceptor,
        double aTotal, string aIdDConcepto, string aPass, ref int aEstatusCancelacion);

    [DllImport("MGWServicios.dll", EntryPoint = "fCierraEmpresa")]
    public static extern void fCierraEmpresa();

    [DllImport("MGWServicios.dll", EntryPoint = "fCuentaBancariaEmpresaDoctos")]
    public static extern int fCuentaBancariaEmpresaDoctos(string aCuentaBancaria);

    [DllImport("MGWServicios.dll", EntryPoint = "fDesbloqueaDocumento")]
    public static extern int fDesbloqueaDocumento();

    [DllImport("MGWServicios.dll", EntryPoint = "fDocumentoBloqueado")]
    public static extern int fDocumentoBloqueado(ref int aImpreso);

    [DllImport("MGWServicios.dll", EntryPoint = "fDocumentoDevuelto")]
    public static extern int fDocumentoDevuelto(ref int aDevuelto);

    [DllImport("MGWServicios.dll", EntryPoint = "fDocumentoImpreso")]
    public static extern int fDocumentoImpreso(ref bool aImpreso);

    [DllImport("MGWServicios.dll", EntryPoint = "fDocumentoUUID")]
    public static extern int fDocumentoUUID(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, StringBuilder atPtrCFDIUUID);

    [DllImport("MGWServicios.dll", EntryPoint = "fEditaAgente")]
    public static extern int fEditaAgente();

    [DllImport("MGWServicios.dll", EntryPoint = "fEditaAlmacen")]
    public static extern int fEditaAlmacen();

    [DllImport("MGWServicios.dll", EntryPoint = "fEditaClasificacion")]
    public static extern int fEditaClasificacion();

    [DllImport("MGWServicios.dll", EntryPoint = "fEditaConceptoDocto")]
    public static extern int fEditaConceptoDocto();

    [DllImport("MGWServicios.dll", EntryPoint = "fEditaCteProv")]
    public static extern int fEditaCteProv();

    [DllImport("MGWServicios.dll", EntryPoint = "fEditaDireccion")]
    public static extern int fEditaDireccion();

    [DllImport("MGWServicios.dll", EntryPoint = "fEditaMovtoContable")]
    public static extern int fEditaMovtoContable();

    [DllImport("MGW_SDK.dll", EntryPoint = "fEditaParametros")]
    public static extern int fEditaParametros();

    [DllImport("MGWServicios.dll", EntryPoint = "fEditaProducto")]
    public static extern int fEditaProducto();

    [DllImport("MGWServicios.dll", EntryPoint = "fEditarDocumento")]
    public static extern int fEditarDocumento();

    [DllImport("MGWServicios.dll", EntryPoint = "fEditarDocumentoCheqpaq")]
    public static extern int fEditarDocumentoCheqpaq();

    [DllImport("MGWServicios.dll", EntryPoint = "fEditarMovimiento")]
    public static extern int fEditarMovimiento();

    [DllImport("MGWServicios.dll", EntryPoint = "fEditaUnidad")]
    public static extern int fEditaUnidad();

    [DllImport("MGWServicios.dll", EntryPoint = "fEditaValorClasif")]
    public static extern int fEditaValorClasif();

    [DllImport("MGWServicios.dll", EntryPoint = "fEliminarCteProv")]
    public static extern int fEliminarCteProv(string aCodigoCteProv);

    [DllImport("MGWServicios.dll", EntryPoint = "fEliminarProducto")]
    public static extern int fEliminarProducto(string aCodigoProducto);

    [DllImport("MGWServicios.dll", EntryPoint = "fEliminarRelacionesCFDIs")]
    public static extern int fEliminarRelacionesCFDIs(string aCodConcepto, string aSerie, string aFolio);

    [DllImport("MGWServicios.dll", EntryPoint = "fEliminarUnidad")]
    public static extern int fEliminarUnidad(string aNombreUnidad);

    [DllImport("MGWServicios.dll", EntryPoint = "fEliminarValorClasif")]
    public static extern int fEliminarValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodigoValorClasif);

    [DllImport("MGWServicios.dll", EntryPoint = "fEmitirDocumento")]
    public static extern int fEmitirDocumento([MarshalAs(UnmanagedType.LPStr)] string aCodConcepto,
        [MarshalAs(UnmanagedType.LPStr)] string aSerie, double aFolio, [MarshalAs(UnmanagedType.LPStr)] string aPassword,
        [MarshalAs(UnmanagedType.LPStr)] string aArchivoAdicional);

    [DllImport("MGWServicios.dll", EntryPoint = "fEntregEnDiscoXML")]
    public static extern int fEntregEnDiscoXML(string aCodConcepto, string aSerie, double aFolio, int aFormato, string aFormatoAmig);

    [DllImport("MGWServicios.dll", EntryPoint = "fError")]
    public static extern void fError(int aNumError, StringBuilder aMensaje, int aLen);

    [DllImport("MGWServicios.dll", EntryPoint = "fGetCantidadParcialidades")]
    public static extern int fGetCantidadParcialidades(StringBuilder atPtrPassword, StringBuilder aCantidadParcialidades);

    [DllImport("MGWServicios.dll", EntryPoint = "fGetDatosCFDI")]
    public static extern int fGetDatosCFDI(StringBuilder aSerieCertEmisor, StringBuilder aFolioFiscalUUID, StringBuilder aSerieCertSAT,
        StringBuilder aFechaHora, StringBuilder aSelloDigCFDI, StringBuilder aSelloSAAT, StringBuilder aCadOrigComplSAT,
        StringBuilder aRegimen, StringBuilder aLugarExpedicion, StringBuilder aMoneda, StringBuilder aFolioFiscalOrig,
        StringBuilder aSerieFolioFiscalOrig, StringBuilder aFechaFolioFiscalOrig, StringBuilder aMontoFolioFiscalOrig);

    [DllImport("MGWServicios.dll", EntryPoint = "fGetNumParcialidades")]
    public static extern int fGetNumParcialidades(StringBuilder atPtrPassword, StringBuilder aNumParcialidades);

    [DllImport("MGWServicios.dll", EntryPoint = "fGetSelloDigitalYCadena")]
    public static extern int fGetSelloDigitalYCadena(StringBuilder atPtrPassword, StringBuilder atPtrSelloDigital,
        StringBuilder atPtrCadenaOriginal);

    [DllImport("MGWServicios.dll", EntryPoint = "fGetSerieCertificado")]
    public static extern int fGetSerieCertificado(StringBuilder atPtrPassword, StringBuilder aSerieCertificado);

    [DllImport("MGWServicios.dll", EntryPoint = "fGetTamSelloDigitalYCadena")]
    public static extern int fGetTamSelloDigitalYCadena(StringBuilder atPtrPassword, ref int aEspSelloDig, ref int aEspCadOrig);

    [DllImport("MGWServicios.dll", EntryPoint = "fGuardaAgente")]
    public static extern int fGuardaAgente();

    [DllImport("MGWServicios.dll", EntryPoint = "fGuardaAlmacen")]
    public static extern int fGuardaAlmacen();

    [DllImport("MGWServicios.dll", EntryPoint = "fGuardaClasificacion")]
    public static extern int fGuardaClasificacion();

    [DllImport("MGWServicios.dll", EntryPoint = "fGuardaConceptoDocto")]
    public static extern int fGuardaConceptoDocto();

    [DllImport("MGWServicios.dll", EntryPoint = "fGuardaCteProv")]
    public static extern int fGuardaCteProv();

    [DllImport("MGWServicios.dll", EntryPoint = "fGuardaDireccion")]
    public static extern int fGuardaDireccion();

    [DllImport("MGWServicios.dll", EntryPoint = "fGuardaDocumento")]
    public static extern int fGuardaDocumento();

    [DllImport("MGWServicios.dll", EntryPoint = "fGuardaMovimiento")]
    public static extern int fGuardaMovimiento();

    [DllImport("MGWServicios.dll", EntryPoint = "fGuardaMovtoContable")]
    public static extern int fGuardaMovtoContable();

    [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaParametros")]
    public static extern int fGuardaParametros();

    [DllImport("MGWServicios.dll", EntryPoint = "fGuardaProducto")]
    public static extern int fGuardaProducto();

    [DllImport("MGWServicios.dll", EntryPoint = "fGuardaUnidad")]
    public static extern int fGuardaUnidad();

    [DllImport("MGWServicios.dll", EntryPoint = "fGuardaValorClasif")]
    public static extern int fGuardaValorClasif();

    [DllImport("MGWServicios.dll", EntryPoint = "fInformacionCliente")]
    public static extern int fInformacionCliente(StringBuilder aCodigo, ref int aPermiteCredito, ref double aLimiteCredito,
        ref int aLimiteDoctosVencidos, ref int aPermiteExcederCredito, StringBuilder aFecha, ref double aSaldo, ref double aSaldoPendiente,
        ref int aDoctosVencidos);

    [DllImport("MGWServicios.dll", EntryPoint = "fInicializaLicenseInfo")]
    public static extern int fInicializaLicenseInfo(byte aSistema);

    [DllImport("MGWServicios.dll", EntryPoint = "fInicializaSDK")]
    public static extern int fInicializaSDK();

    [DllImport("MGWServicios.dll", EntryPoint = "fInicioSesionSDK")]
    public static extern void fInicioSesionSDK(string aUsuario, string aContrasenia);

    [DllImport("MGWServicios.dll", EntryPoint = "fInicioSesionSDKCONTPAQi")]
    public static extern void fInicioSesionSDKCONTPAQi(string aUsuario, string aContrasenia);

    [DllImport("MGWServicios.dll", EntryPoint = "fInsertaAgente")]
    public static extern int fInsertaAgente();

    [DllImport("MGWServicios.dll", EntryPoint = "fInsertaAlmacen")]
    public static extern int fInsertaAlmacen();

    [DllImport("MGWServicios.dll", EntryPoint = "fInsertaCteProv")]
    public static extern int fInsertaCteProv();

    [DllImport("MGWServicios.dll", EntryPoint = "fInsertaDatoAddendaDocto")]
    public static extern int fInsertaDatoAddendaDocto(int aIdAddenda, int aIdCatalogo, int aNumCampo, string aDato);

    [DllImport("MGWServicios.dll", EntryPoint = "fInsertaDatoAddendaMovto")]
    public static extern int fInsertaDatoAddendaMovto(int aIdAddenda, int aIdCatalogo, int aNumCampo, string aDato);

    [DllImport("MGWServicios.dll", EntryPoint = "fInsertaDatoCompEducativo")]
    public static extern int fInsertaDatoCompEducativo(int aIdServicio, int aNumCampo, string aDato);

    [DllImport("MGWServicios.dll", EntryPoint = "fInsertaDireccion")]
    public static extern int fInsertaDireccion();

    [DllImport("MGWServicios.dll", EntryPoint = "fInsertaProducto")]
    public static extern int fInsertaProducto();

    [DllImport("MGWServicios.dll", EntryPoint = "fInsertarDocumento")]
    public static extern int fInsertarDocumento();

    [DllImport("MGWServicios.dll", EntryPoint = "fInsertarMovimiento")]
    public static extern int fInsertarMovimiento();

    [DllImport("MGWServicios.dll", EntryPoint = "fInsertaUnidad")]
    public static extern int fInsertaUnidad();

    [DllImport("MGWServicios.dll", EntryPoint = "fInsertaValorClasif")]
    public static extern int fInsertaValorClasif();

    [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoAgente")]
    public static extern int fLeeDatoAgente(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoAlmacen")]
    public static extern int fLeeDatoAlmacen(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoCFDI")]
    public static extern int fLeeDatoCFDI(StringBuilder aValor, int aDato);

    [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoClasificacion")]
    public static extern int fLeeDatoClasificacion(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoConceptoDocto")]
    public static extern int fLeeDatoConceptoDocto(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoCteProv")]
    public static extern int fLeeDatoCteProv(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoDireccion")]
    public static extern int fLeeDatoDireccion(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoDocumento")]
    public static extern int fLeeDatoDocumento(string aCampo, StringBuilder aValor, int aLongitud);

    [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoMovimiento")]
    public static extern int fLeeDatoMovimiento(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoMovtoContable")]
    public static extern int fLeeDatoMovtoContable(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoParametros")]
    public static extern int fLeeDatoParametros(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoProducto")]
    public static extern int fLeeDatoProducto(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoUnidad")]
    public static extern int fLeeDatoUnidad(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoValorClasif")]
    public static extern int fLeeDatoValorClasif(string aCampo, StringBuilder aValor, int aLen);

    [DllImport("MGWServicios.dll", EntryPoint = "fLlenaRegistroCteProv")]
    public static extern int fLlenaRegistroCteProv(ref tCteProv astCteProv, int aEsAlta);

    [DllImport("MGWServicios.dll", EntryPoint = "fLlenaRegistroDireccion")]
    public static extern int fLlenaRegistroDireccion(ref tDireccion astDireccion, int aEsAlta);

    [DllImport("MGWServicios.dll", EntryPoint = "fLlenaRegistroProducto")]
    public static extern int fLlenaRegistroProducto(ref tProducto astProducto, int aEsAlta);

    [DllImport("MGWServicios.dll", EntryPoint = "fLlenaRegistroUnidad")]
    public static extern int fLlenaRegistroUnidad(ref tUnidad astUnidad);

    [DllImport("MGWServicios.dll", EntryPoint = "fLlenaRegistroValorClasif")]
    public static extern int fLlenaRegistroValorClasif(ref tValorClasificacion astValorClasif);

    [DllImport("MGWServicios.dll", EntryPoint = "fModificaCostoEntrada")]
    public static extern int fModificaCostoEntrada(string aIdMovimiento, string aCostoEntrada);

    [DllImport("MGWServicios.dll", EntryPoint = "fModificaCuentaBancariaCliente")]
    public static extern int fModificaCuentaBancariaCliente(string aCuentaBancaria, string aNombreCuenta, string aNombreMoneda,
        string aClaveBanco, string aRfcBanco, string aClabe, string aNombreExtranjero, string aCodigoCliente);

    [DllImport("MGWServicios.dll", EntryPoint = "fModificaCuentaBancariaEmpresa")]
    public static extern int fModificaCuentaBancariaEmpresa(string aCuentaBancaria, string aNombreCuenta, string aNombreMoneda,
        string aClaveBanco, string aRfcBanco, string aClabe, string aNombreExtranjero);

    [DllImport("MGWServicios.dll", EntryPoint = "fObtenCeryKey")]
    public static extern int fObtenCeryKey(int aIdFirmarl, string aRutaKey, string aRutaCer);

    [DllImport("MGWServicios.dll", EntryPoint = "fObtieneDatosCFDI")]
    public static extern int fObtieneDatosCFDI(string atPtrPassword);

    [DllImport("MGWServicios.dll", EntryPoint = "fObtieneLicencia")]
    public static extern int fObtieneLicencia(StringBuilder aCodAcvtiva, StringBuilder aCodSitio, StringBuilder aSerie,
        StringBuilder aTagVersion);

    [DllImport("MGWServicios.dll", EntryPoint = "fObtienePassProxy")]
    public static extern int fObtienePassProxy(StringBuilder aPassProxy);

    [DllImport("MGWServicios.dll", EntryPoint = "fObtieneUnidadesPendientes")]
    public static extern int fObtieneUnidadesPendientes(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen,
        StringBuilder aUnidades);

    [DllImport("MGWServicios.dll", EntryPoint = "fObtieneUnidadesPendientesCarac")]
    public static extern int fObtieneUnidadesPendientesCarac(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen,
        string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, StringBuilder aUnidades);

    [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorAgente")]
    public static extern int fPosAnteriorAgente();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorAlmacen")]
    public static extern int fPosAnteriorAlmacen();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorClasificacion")]
    public static extern int fPosAnteriorClasificacion();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorConceptoDocto")]
    public static extern int fPosAnteriorConceptoDocto();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorCteProv")]
    public static extern int fPosAnteriorCteProv();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorDireccion")]
    public static extern int fPosAnteriorDireccion();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorDocumento")]
    public static extern int fPosAnteriorDocumento();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorMovimiento")]
    public static extern int fPosAnteriorMovimiento();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorProducto")]
    public static extern int fPosAnteriorProducto();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorUnidad")]
    public static extern int fPosAnteriorUnidad();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorValorClasif")]
    public static extern int fPosAnteriorValorClasif();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosBOF")]
    public static extern int fPosBOF();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosBOFAgente")]
    public static extern int fPosBOFAgente();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosBOFAlmacen")]
    public static extern int fPosBOFAlmacen();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosBOFClasificacion")]
    public static extern int fPosBOFClasificacion();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosBOFConceptoDocto")]
    public static extern int fPosBOFConceptoDocto();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosBOFCteProv")]
    public static extern int fPosBOFCteProv();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosBOFDireccion")]
    public static extern int fPosBOFDireccion();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosBOFProducto")]
    public static extern int fPosBOFProducto();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosBOFUnidad")]
    public static extern int fPosBOFUnidad();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosBOFValorClasif")]
    public static extern int fPosBOFValorClasif();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosEOF")]
    public static extern int fPosEOF();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosEOFAgente")]
    public static extern int fPosEOFAgente();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosEOFAlmacen")]
    public static extern int fPosEOFAlmacen();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosEOFClasificacion")]
    public static extern int fPosEOFClasificacion();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosEOFConceptoDocto")]
    public static extern int fPosEOFConceptoDocto();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosEOFCteProv")]
    public static extern int fPosEOFCteProv();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosEOFDireccion")]
    public static extern int fPosEOFDireccion();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosEOFMovtoContable")]
    public static extern int fPosEOFMovtoContable();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosEOFProducto")]
    public static extern int fPosEOFProducto();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosEOFUnidad")]
    public static extern int fPosEOFUnidad();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosEOFValorClasif")]
    public static extern int fPosEOFValorClasif();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosMovimientoBOF")]
    public static extern int fPosMovimientoBOF();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosMovimientoEOF")]
    public static extern int fPosMovimientoEOF();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerAgente")]
    public static extern int fPosPrimerAgente();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerAlmacen")]
    public static extern int fPosPrimerAlmacen();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerClasificacion")]
    public static extern int fPosPrimerClasificacion();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerConceptoDocto")]
    public static extern int fPosPrimerConceptoDocto();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerCteProv")]
    public static extern int fPosPrimerCteProv();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerDireccion")]
    public static extern int fPosPrimerDireccion();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerDocumento")]
    public static extern int fPosPrimerDocumento();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerEmpresa")]
    public static extern int fPosPrimerEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa);

    [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerMovimiento")]
    public static extern int fPosPrimerMovimiento();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerMovtoContable")]
    public static extern int fPosPrimerMovtoContable();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerProducto")]
    public static extern int fPosPrimerProducto();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerUnidad")]
    public static extern int fPosPrimerUnidad();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerValorClasif")]
    public static extern int fPosPrimerValorClasif();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteAgente")]
    public static extern int fPosSiguienteAgente();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteAlmacen")]
    public static extern int fPosSiguienteAlmacen();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteClasificacion")]
    public static extern int fPosSiguienteClasificacion();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteConceptoDocto")]
    public static extern int fPosSiguienteConceptoDocto();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteCteProv")]
    public static extern int fPosSiguienteCteProv();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteDireccion")]
    public static extern int fPosSiguienteDireccion();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteDocumento")]
    public static extern int fPosSiguienteDocumento();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteEmpresa")]
    public static extern int fPosSiguienteEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa);

    [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteMovimiento")]
    public static extern int fPosSiguienteMovimiento();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteMovtoContable")]
    public static extern int fPosSiguienteMovtoContable();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteProducto")]
    public static extern int fPosSiguienteProducto();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteUnidad")]
    public static extern int fPosSiguienteUnidad();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteValorClasif")]
    public static extern int fPosSiguienteValorClasif();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimaConceptoDocto")]
    public static extern int fPosUltimaConceptoDocto();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimaDireccion")]
    public static extern int fPosUltimaDireccion();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimoAgente")]
    public static extern int fPosUltimoAgente();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimoAlmacen")]
    public static extern int fPosUltimoAlmacen();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimoClasificacion")]
    public static extern int fPosUltimoClasificacion();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimoCteProv")]
    public static extern int fPosUltimoCteProv();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimoDocumento")]
    public static extern int fPosUltimoDocumento();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimoMovimiento")]
    public static extern int fPosUltimoMovimiento();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimoProducto")]
    public static extern int fPosUltimoProducto();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimoUnidad")]
    public static extern int fPosUltimoUnidad();

    [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimoValorClasif")]
    public static extern int fPosUltimoValorClasif();

    [DllImport("MGWServicios.dll", EntryPoint = "fProyectoEmpresaDoctos")]
    public static extern int fProyectoEmpresaDoctos(string aCodigoProyecto);

    [DllImport("MGWServicios.dll", EntryPoint = "fRecosteoProducto")]
    public static extern int fRecosteoProducto(string aCodigoProducto, int aEjercicio, int aPeriodo, string aCodigoClasificacion1,
        string aCodigoClasificacion2, string aCodigoClasificacion3, string aCodigoClasificacion4, string aCodigoClasificacion5,
        string aCodigoClasificacion6, string aNombreBitacora, int aSobreEscribirBitacora, int aEsCalculoArimetico);

    [DllImport("MGWServicios.dll", EntryPoint = "fRecuperarRelacionesCFDIs")]
    public static extern int fRecuperarRelacionesCFDIs(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion,
        StringBuilder aUUIDs, string aRutaNombreArchivoInfo);

    [DllImport("MGWServicios.dll", EntryPoint = "fRecuperaTipoProducto")]
    public static extern int fRecuperaTipoProducto(ref bool aUnidades, ref bool aSerie, ref bool aLote, ref bool aPedimento,
        ref bool aCaracteristicas);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresaCostoCapa")]
    public static extern int fRegresaCostoCapa(string aCodigoProducto, string aCodigoAlmacen, double aUnidades,
        StringBuilder aImporteCosto);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresaCostoEstandar")]
    public static extern int fRegresaCostoEstandar(string aCodigoProducto, StringBuilder aCostoEstandar);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresaCostoPromedio")]
    public static extern int fRegresaCostoPromedio(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        StringBuilder aCostoPromedio);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresaExistencia")]
    public static extern int fRegresaExistencia(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        ref double aExistencia);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresaExistenciaCaracteristicas")]
    public static extern int fRegresaExistenciaCaracteristicas(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes,
        string aDia, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, ref double aExistencia);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresaExistenciaLotePedimento")]
    public static extern int fRegresaExistenciaLotePedimento(string aCodigoProducto, string aCodigoAlmacen, string aPedimento, string aLote,
        ref double aExistencia);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresaIVACargo")]
    public static extern int fRegresaIVACargo(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero,
        double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresaIVACargo_2010")]
    public static extern int fRegresaIVACargo_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16,
        double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10,
        double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresaIVACargoRet_2010")]
    public static extern int fRegresaIVACargoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16,
        double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10,
        double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresaIVAPago")]
    public static extern int fRegresaIVAPago(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero,
        double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresaIVAPago_2010")]
    public static extern int fRegresaIVAPago_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16,
        double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10,
        double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresaIVAPagoRet_2010")]
    public static extern int fRegresaIVAPagoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16,
        double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10,
        double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresaPrecioVenta")]
    public static extern int fRegresaPrecioVenta(string aCodigoConcepto, string aCodigoCliente, string aCodigoProducto,
        StringBuilder aPrecioVenta);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresaUltimoCosto")]
    public static extern int fRegresaUltimoCosto(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        StringBuilder aUltimoCosto);

    [DllImport("MGWServicios.dll", EntryPoint = "fRegresPorcentajeImpuesto")]
    public static extern int fRegresPorcentajeImpuesto(int aIdConceptoDocumento, int aIdClienteProveedor, int aIdProducto,
        ref double aPorcentajeImpuesto);

    [DllImport("MGWServicios.dll", EntryPoint = "fSaldarDocumento")]
    public static extern int fSaldarDocumento(ref tLlaveDoc aDoctoaPagar, ref tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda,
        string aFecha);

    [DllImport("MGWServicios.dll", EntryPoint = "fSaldarDocumento_Param")]
    public static extern int fSaldarDocumento_Param(string aCodConcepto_Pagar, string aSerie_Pagar, double aFolio_Pagar,
        string aCodConcepto_Pago, string aSerie_Pago, double aFolio_Pago, double aImporte, int aIdMoneda, string aFecha);

    [DllImport("MGWServicios.dll", EntryPoint = "fSaldarDocumentoCheqPAQ")]
    public static extern int fSaldarDocumentoCheqPAQ(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda,
        string aFecha, double aTipoCambioCheqPAQ);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoAgente")]
    public static extern int fSetDatoAgente(string aCampo, string aValor);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoAlmacen")]
    public static extern int fSetDatoAlmacen(string aCampo, string aValor);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoClasificacion")]
    public static extern int fSetDatoClasificacion(string aCampo, string aValor);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoConceptoDocto")]
    public static extern int fSetDatoConceptoDocto(string aCampo, string aValor);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoCteProv")]
    public static extern int fSetDatoCteProv(string aCampo, string aValor);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoDireccion")]
    public static extern int fSetDatoDireccion(string aCampo, string aValor);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoDocumento")]
    public static extern int fSetDatoDocumento(string aCampo, string aValor);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoMovimiento")]
    public static extern int fSetDatoMovimiento(string aCampo, string aValor);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoMovtoContable")]
    public static extern int fSetDatoMovtoContable(string aCampo, string aValor);

    [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoParametros")]
    public static extern int fSetDatoParametros(string aCampo, StringBuilder aValor);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoProducto")]
    public static extern int fSetDatoProducto(string aCampo, string aValor);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoUnidad")]
    public static extern int fSetDatoUnidad(string aCampo, string aValor);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoValorClasif")]
    public static extern int fSetDatoValorClasif(string aCampo, string aValor);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetDescripcionProducto")]
    public static extern int fSetDescripcionProducto(string aCampo, string aValor);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetFiltroDocumento")]
    public static extern int fSetFiltroDocumento(string aFechaInicio, string aFechaFin, string aCodigoConcepto, string aCodigoCteProv);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetFiltroMovimiento")]
    public static extern int fSetFiltroMovimiento(int aIdDocumento);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetModoImportacion")]
    public static extern void fSetModoImportacion(bool aImportacion);

    [DllImport("MGWServicios.dll", EntryPoint = "fSetNombrePAQ")]
    public static extern int fSetNombrePAQ(string aSistema);

    [DllImport("MGWServicios.dll", EntryPoint = "fSiguienteFolio")]
    public static extern int fSiguienteFolio(string aCodigoConcepto, StringBuilder aSerie, ref double aFolio);

    [DllImport("MGWServicios.dll", EntryPoint = "fTerminaSDK")]
    public static extern void fTerminaSDK();

    [DllImport("MGWServicios.dll", EntryPoint = "fTimbraComplementoXML")]
    public static extern int fTimbraComplementoXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA,
        string aRutaResultado, string aPass, string aRutaFormato, int aComplemento);

    [DllImport("MGWServicios.dll", EntryPoint = "fTimbraNominaXML")]
    public static extern int fTimbraNominaXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA,
        string aRutaResultado, string aPass, string aRutaFormato);

    [DllImport("MGWServicios.dll", EntryPoint = "fTimbraXML")]
    public static extern int fTimbraXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado,
        string aPass, string aRutaFormato);
}

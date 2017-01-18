using System.Runtime.InteropServices;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk
{
    public static class AdminpaqSdk
    {
        #region Generales

        [DllImport("MGW_SDK.dll", EntryPoint = "fInicializaSDK")]
        public static extern int fInicializaSDK();

        [DllImport("MGW_SDK.dll", EntryPoint = "fTerminaSDK")]
        public static extern void fTerminaSDK();

        [DllImport("MGW_SDK.dll", EntryPoint = "fSetNombrePAQ")]
        public static extern int fSetNombrePAQ(string aSistema);

        [DllImport("MGW_SDK.dll", EntryPoint = "fError")]
        public static extern void fError(int aNumError, StringBuilder aMensaje, int aLen);

        [DllImport("MGW_SDK.dll", EntryPoint = "fInicializaLicenseInfo")]
        public static extern void fInicializaLicenseInfo(int aSistema);

        [DllImport("MGW_SDK.dll", EntryPoint = "fSetModoImportacion")]
        public static extern void fSetModoImportacion(bool aImportacion);

        #endregion

        #region Empresas

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerEmpresa")]
        public static extern int fPosPrimerEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa);

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteEmpresa")]
        public static extern int fPosSiguienteEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa);

        [DllImport("MGWServicios.dll", EntryPoint = "fAbreEmpresa")]
        public static extern int fAbreEmpresa(string aDirectorioEmpresa);

        [DllImport("MGWServicios.dll", EntryPoint = "fCierraEmpresa")]
        public static extern void fCierraEmpresa();

        #endregion

        #region Documentos

        [DllImport("MGWServicios.dll", EntryPoint = "fInsertarDocumento")]
        public static extern int fInsertarDocumento();

        [DllImport("MGWServicios.dll", EntryPoint = "fEditarDocumento")]
        public static extern int fEditarDocumento();

        [DllImport("MGWServicios.dll", EntryPoint = "fGuardaDocumento")]
        public static extern int fGuardaDocumento();

        [DllImport("MGWServicios.dll", EntryPoint = "fCancelarModificacionDocumento")]
        public static extern int fCancelarModificacionDocumento();

        [DllImport("MGWServicios.dll", EntryPoint = "fBorraDocumento")]
        public static extern int fBorraDocumento();

        [DllImport("MGWServicios.dll", EntryPoint = "fCancelaDocumento")]
        public static extern int fCancelaDocumento();

        [DllImport("MGWServicios.dll", EntryPoint = "fBorraDocumento_CW")]
        public static extern int fBorraDocumento_CW();

        [DllImport("MGWServicios.dll", EntryPoint = "fCancelaDocumento_CW")]
        public static extern int fCancelaDocumento_CW();

        [DllImport("MGWServicios.dll", EntryPoint = "fAfectaDocto_Param")]
        public static extern int fAfectaDocto_Param(string aCodConcepto, string aSerie, double aFolio, bool aAfecta);

        [DllImport("MGWServicios.dll", EntryPoint = "fSaldarDocumento_Param")]
        public static extern int fSaldarDocumento_Param(string aCodConcepto_Pagar, string aSerie_Pagar, string aFolio_Pagar, string aCodConcepto_Pago, string aSerie_Pago, string aFolio_Pago, double aImporte, int aIdMoneda, string aFecha);

        [DllImport("MGWServicios.dll", EntryPoint = "fBorrarAsociacion_Param")]
        public static extern int fBorrarAsociacion_Param(string aCodConcepto_Pagar, string aSerie_Pagar, string aFolio_Pagar, string aCodConcepto_Pago, string aSerie_Pago, string aFolio_Pago);

        [DllImport("MGWServicios.dll", EntryPoint = "fEditarDocumentoCheqpaq")]
        public static extern int fEditarDocumentoCheqpaq();

        [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoDocumento")]
        public static extern int fSetDatoDocumento(string aCampo, string aValor);

        [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoDocumento")]
        public static extern int fLeeDatoDocumento(string aCampo, StringBuilder aValor, int aLongitud);

        [DllImport("MGWServicios.dll", EntryPoint = "fSiguienteFolio")]
        public static extern int fSiguienteFolio(string aCodigoConcepto, StringBuilder aSerie, ref double aFolio);

        [DllImport("MGWServicios.dll", EntryPoint = "fSetFiltroDocumento")]
        public static extern int fSetFiltroDocumento(string aFechaInicio, string aFechaFin, string aCodigoConcepto, string aCodigoCteProv);

        [DllImport("MGWServicios.dll", EntryPoint = "fCancelaFiltroDocumento")]
        public static extern int fCancelaFiltroDocumento();

        [DllImport("MGWServicios.dll", EntryPoint = "fDocumentoImpreso")]
        public static extern int fDocumentoImpreso(ref bool aImpreso);

        [DllImport("MGWServicios.dll", EntryPoint = "fDocumentoBloqueado")]
        public static extern int fDocumentoBloqueado(ref int aImpreso);

        [DllImport("MGWServicios.dll", EntryPoint = "fBuscarDocumento")]
        public static extern int fBuscarDocumento(string aCodConcepto, string aSerie, string aFolio);

        [DllImport("MGWServicios.dll", EntryPoint = "fBuscarIdDocumento")]
        public static extern int fBuscarIdDocumento(int aIdDocumento);

        [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerDocumento")]
        public static extern int fPosPrimerDocumento();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimoDocumento")]
        public static extern int fPosUltimoDocumento();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteDocumento")]
        public static extern int fPosSiguienteDocumento();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorDocumento")]
        public static extern int fPosAnteriorDocumento();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosBOF")]
        public static extern int fPosBOF();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosEOF")]
        public static extern int fPosEOF();

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaDocumento")]
        public static extern int fAltaDocumento(ref int aIdDocumento, ref tDocumento aDocumento);

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaDocumentoCargoAbono")]
        public static extern int fAltaDocumentoCargoAbono(tDocumento aDocumento);

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaDocumentoCargoAbonoExtras")]
        public static extern int fAltaDocumentoCargoAbonoExtras(tDocumento aDocumento, string aTextoExtra1, string aTextoExtra2, string aTextoExtra3, string aFechaExtra, double aImporteExtra1, double aImporteExtra2, double aImporteExtra3, double aImporteExtra4);

        [DllImport("MGWServicios.dll", EntryPoint = "fAfectaDocto")]
        public static extern int fAfectaDocto(ref tLlaveDoc aLlaveDocto, bool aAfecta);

        [DllImport("MGWServicios.dll", EntryPoint = "fSaldarDocumento")]
        public static extern int fSaldarDocumento(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha);

        [DllImport("MGWServicios.dll", EntryPoint = "fSaldarDocumentoCheqPAQ")]
        public static extern int fSaldarDocumentoCheqPAQ(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha, double aTipoCambioCheqPAQ);

        [DllImport("MGWServicios.dll", EntryPoint = "fBorrarAsociacion")]
        public static extern int fBorrarAsociacion(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago);

        [DllImport("MGWServicios.dll", EntryPoint = "fRegresaIVACargo")]
        public static extern int fRegresaIVACargo(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas);

        [DllImport("MGWServicios.dll", EntryPoint = "fRegresaIVAPago")]
        public static extern int fRegresaIVAPago(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas);

        [DllImport("MGWServicios.dll", EntryPoint = "fRegresaIVACargo_2010")]
        public static extern int fRegresaIVACargo_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas);

        [DllImport("MGWServicios.dll", EntryPoint = "fRegresaIVAPago_2010")]
        public static extern int fRegresaIVAPago_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas);

        [DllImport("MGWServicios.dll", EntryPoint = "fRegresaIVACargoRet_2010")]
        public static extern int fRegresaIVACargoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI);

        [DllImport("MGWServicios.dll", EntryPoint = "fRegresaIVAPagoRet_2010")]
        public static extern int fRegresaIVAPagoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI);

        [DllImport("MGWServicios.dll", EntryPoint = "fGetTamSelloDigitalYCadena")]
        public static extern int fGetTamSelloDigitalYCadena(StringBuilder atPtrPassword, ref int aEspSelloDig, ref int aEspCadOrig);

        [DllImport("MGWServicios.dll", EntryPoint = "fGetSelloDigitalYCadena")]
        public static extern int fGetSelloDigitalYCadena(StringBuilder atPtrPassword, StringBuilder atPtrSelloDigital, StringBuilder atPtrCadenaOriginal);

        [DllImport("MGWServicios.dll", EntryPoint = "fInicializaLicenseInfo")]
        public static extern int fInicializaLicenseInfo(char aSistema);

        [DllImport("MGWServicios.dll", EntryPoint = "fEmitirDocumento")]
        public static extern int fEmitirDocumento(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, StringBuilder aPassword, StringBuilder aArchivoAdicional);

        [DllImport("MGWServicios.dll", EntryPoint = "fDocumentoUUID")]
        public static extern int fDocumentoUUID(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, StringBuilder atPtrCFDIUUID);

        [DllImport("MGWServicios.dll", EntryPoint = "fGetSerieCertificado")]
        public static extern int fGetSerieCertificado(StringBuilder atPtrPassword, StringBuilder aSerieCertificado);

        [DllImport("MGWServicios.dll", EntryPoint = "fGetNumParcialidades")]
        public static extern int fGetNumParcialidades(StringBuilder atPtrPassword, StringBuilder aNumParcialidades);

        [DllImport("MGWServicios.dll", EntryPoint = "fGetCantidadParcialidades")]
        public static extern int fGetCantidadParcialidades(StringBuilder atPtrPassword, StringBuilder aCantidadParcialidades);

        [DllImport("MGWServicios.dll", EntryPoint = "fActivarPrecioCompra")]
        public static extern int fActivarPrecioCompra(int aActivar);

        [DllImport("MGWServicios.dll", EntryPoint = "fDocumentoDevuelto")]
        public static extern int fDocumentoDevuelto(ref int aDevuelto);

        [DllImport("MGWServicios.dll", EntryPoint = "fEntregEnDiscoXML")]
        public static extern int fEntregEnDiscoXML(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, int aFormato, StringBuilder aFormatoAmig);

        [DllImport("MGWServicios.dll", EntryPoint = "fObtieneDatosCFDI")]
        public static extern int fObtieneDatosCFDI(StringBuilder atPtrPassword);

        [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoCFDI")]
        public static extern int fLeeDatoCFDI(StringBuilder aValor, int aDato);

        [DllImport("MGWServicios.dll", EntryPoint = "fBuscaDocumento")]
        public static extern int fBuscaDocumento(ref tLlaveDoc aLlaveDocto);

        #endregion

        #region Movimientos

        [DllImport("MGWServicios.dll", EntryPoint = "fInsertarMovimiento")]
        public static extern int fInsertarMovimiento();

        [DllImport("MGWServicios.dll", EntryPoint = "fEditarMovimiento")]
        public static extern int fEditarMovimiento();

        [DllImport("MGWServicios.dll", EntryPoint = "fGuardaMovimiento")]
        public static extern int fGuardaMovimiento();

        [DllImport("MGWServicios.dll", EntryPoint = "fCancelaCambiosMovimiento")]
        public static extern int fCancelaCambiosMovimiento();

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimientoCaracteristicas_Param")]
        public static extern int fAltaMovimientoCaracteristicas_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidades, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3);

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovtoCaracteristicasUnidades_Param")]
        public static extern int fAltaMovtoCaracteristicasUnidades_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidad, string aUnidades, string aUnidadesNC, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3);

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimientoSeriesCapas_Param")]
        public static extern int fAltaMovimientoSeriesCapas_Param(string aIdMovimiento, string aUnidades, string aTipoCambio, string aSeries, string aPedimento, string aAgencia, string aFechaPedimento, string aNumeroLote, string aFechaFabricacion, string aFechaCaducidad);

        [DllImport("MGWServicios.dll", EntryPoint = "fCalculaMovtoSerieCapa")]
        public static extern int fCalculaMovtoSerieCapa(int aIdMovimiento);

        [DllImport("MGWServicios.dll", EntryPoint = "fObtieneUnidadesPendientes")]
        public static extern int fObtieneUnidadesPendientes(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen, StringBuilder aUnidades);

        [DllImport("MGWServicios.dll", EntryPoint = "fObtieneUnidadesPendientesCarac")]
        public static extern int fObtieneUnidadesPendientesCarac(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, StringBuilder aUnidades);

        [DllImport("MGWServicios.dll", EntryPoint = "fModificaCostoEntrada")]
        public static extern int fModificaCostoEntrada(string aIdMovimiento, string aCostoEntrada);

        [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoMovimiento")]
        public static extern int fSetDatoMovimiento(string aCampo, string aValor);

        [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoMovimiento")]
        public static extern int fLeeDatoMovimiento(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGWServicios.dll", EntryPoint = "fAfectaSerie")]
        public static extern int fAfectaSerie(int aIdMovto, string aNumeroSerie);

        [DllImport("MGWServicios.dll", EntryPoint = "fSetFiltroMovimiento")]
        public static extern int fSetFiltroMovimiento(int aIdDocumento);

        [DllImport("MGWServicios.dll", EntryPoint = "fCancelaFiltroMovimiento")]
        public static extern int fCancelaFiltroMovimiento();

        [DllImport("MGWServicios.dll", EntryPoint = "fBuscarIdMovimiento")]
        public static extern int fBuscarIdMovimiento(int aIdMovimiento);

        [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerMovimiento")]
        public static extern int fPosPrimerMovimiento();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimoMovimiento")]
        public static extern int fPosUltimoMovimiento();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteMovimiento")]
        public static extern int fPosSiguienteMovimiento();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorMovimiento")]
        public static extern int fPosAnteriorMovimiento();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosMovimientoBOF")]
        public static extern int fPosMovimientoBOF();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosMovimientoEOF")]
        public static extern int fPosMovimientoEOF();

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaDoctoAjusteIVAClienteProveedor")]
        public static extern int fAltaDoctoAjusteIVAClienteProveedor(string aCodigoClienteProveedor, int aEsCliente, int aAbsorberAjusteIVA, string aFechaDocto, int aIdMoneda, double aTipoCambio, double aImporteIVA, double aTasaIVA, int aIdFacturaBase, string aMetodo, string aLugar, ref int aIdDoctoGenerado);

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaDoctoAjusteIESPSCteProv")]
        public static extern int fAltaDoctoAjusteIESPSCteProv(string aCodigoClienteProveedor, int aEsCliente, string aFechaDocto, int aIdMoneda, double aTipoCambio, double aImporteIVA, double aTasaIVA, double aImporteIESPS, double aTasaIESPS, int aIdFacturaBase, string aMetodo, string aLugar, ref int aIdDoctoGenerado);

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimiento")]
        public static extern int fAltaMovimiento(int aIdDocumento, ref int aIdMovimiento, ref tMovimiento astMovimiento);

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimientoEx")]
        public static extern int fAltaMovimientoEx(ref int aIdMovimiento, tTipoProducto aTipoProducto);

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimientoCDesct")]
        public static extern int fAltaMovimientoCDesct(int aIdDocumento, int aIdMovimiento, tMovimientoDesc astMovimiento);

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimientoCaracteristicas")]
        public static extern int fAltaMovimientoCaracteristicas(int aIdMovimiento, int aIdMovtoCaracteristicas, tCaracteristicas aCaracteristicas);

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovtoCaracteristicasUnidades")]
        public static extern int fAltaMovtoCaracteristicasUnidades(int aIdMovimiento, int aIdMovtoCaracteristicas, tCaracteristicas aCaracteristicasUnidades);

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimientoSeriesCapas")]
        public static extern int fAltaMovimientoSeriesCapas(int aIdMovimiento, ref tSeriesCapas aSeriesCapas);

        #endregion

        #region Clientes y Proveedores

        [DllImport("MGWServicios.dll", EntryPoint = "fInsertaCteProv")]
        public static extern int fInsertaCteProv();

        [DllImport("MGWServicios.dll", EntryPoint = "fEditaCteProv")]
        public static extern int fEditaCteProv();

        [DllImport("MGWServicios.dll", EntryPoint = "fGuardaCteProv")]
        public static extern int fGuardaCteProv();

        [DllImport("MGWServicios.dll", EntryPoint = "fBorraCteProv")]
        public static extern int fBorraCteProv();

        [DllImport("MGWServicios.dll", EntryPoint = "fCancelarModificacionCteProv")]
        public static extern int fCancelarModificacionCteProv();

        [DllImport("MGWServicios.dll", EntryPoint = "fEliminarCteProv")]
        public static extern int fEliminarCteProv(string aCodigoCteProv);

        [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoCteProv")]
        public static extern int fSetDatoCteProv(string aCampo, string aValor);

        [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoCteProv")]
        public static extern int fLeeDatoCteProv(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGWServicios.dll", EntryPoint = "fBuscaCteProv")]
        public static extern int fBuscaCteProv(string aCodCteProv);

        [DllImport("MGWServicios.dll", EntryPoint = "fBuscaIdCteProv")]
        public static extern int fBuscaIdCteProv(int aIdCteProv);

        [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerCteProv")]
        public static extern int fPosPrimerCteProv();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimoCteProv")]
        public static extern int fPosUltimoCteProv();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteCteProv")]
        public static extern int fPosSiguienteCteProv();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorCteProv")]
        public static extern int fPosAnteriorCteProv();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosBOFCteProv")]
        public static extern int fPosBOFCteProv();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosEOFCteProv")]
        public static extern int fPosEOFCteProv();

        [DllImport("MGWServicios.dll", EntryPoint = "fInformacionCliente")]
        public static extern int fInformacionCliente(StringBuilder aCodigo, ref int aPermiteCredito, ref double aLimiteCredito, ref int aLimiteDoctosVencidos, ref int aPermiteExcederCredito, StringBuilder aFecha, ref double aSaldo, ref double aSaldoPendiente, ref int aDoctosVencidos);

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaCteProv")]
        public static extern int fAltaCteProv(StringBuilder aIdCteProv, tCteProv astCteProv);

        [DllImport("MGWServicios.dll", EntryPoint = "fActualizaCteProv")]
        public static extern int fActualizaCteProv(StringBuilder aCodigoCteProv, tCteProv astCteProv);

        [DllImport("MGWServicios.dll", EntryPoint = "fLlenaRegistroCteProv")]
        public static extern int fLlenaRegistroCteProv(tCteProv astCteProv, int aEsAlta);

        #endregion

        #region Productos

        [DllImport("MGWServicios.dll", EntryPoint = "fInsertaProducto")]
        public static extern int fInsertaProducto();

        [DllImport("MGWServicios.dll", EntryPoint = "fEditaProducto")]
        public static extern int fEditaProducto();

        [DllImport("MGWServicios.dll", EntryPoint = "fGuardaProducto")]
        public static extern int fGuardaProducto();

        [DllImport("MGWServicios.dll", EntryPoint = "fBorraProducto")]
        public static extern int fBorraProducto();

        [DllImport("MGWServicios.dll", EntryPoint = "fCancelarModificacionProducto")]
        public static extern int fCancelarModificacionProducto();

        [DllImport("MGWServicios.dll", EntryPoint = "fEliminarProducto")]
        public static extern int fEliminarProducto();

        [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoProducto")]
        public static extern int fSetDatoProducto(string aCampo, string aValor);

        [DllImport("MGWServicios.dll", EntryPoint = "fSetDescripcionProducto")]
        public static extern int fSetDescripcionProducto(string aCampo, string aValor);

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaProducto")]
        public static extern int fAltaProducto(ref int aIdProducto, tProduto astProducto);

        [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoProducto")]
        public static extern int fLeeDatoProducto(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGWServicios.dll", EntryPoint = "fRecuperaTipoProducto")]
        public static extern int fRecuperaTipoProducto(ref bool aUnidades, ref bool aSerie, ref bool aLote, ref bool aPedimento, ref bool aCaracteristicas);

        [DllImport("MGWServicios.dll", EntryPoint = "fRecosteoProducto")]
        public static extern int fRecosteoProducto(string aCodigoProducto, int aEjercicio, int aPeriodo, string aCodigoClasificacion1, string aCodigoClasificacion2, string aCodigoClasificacion3, string aCodigoClasificacion4, string aCodigoClasificacion5, string aCodigoClasificacion6, string aNombreBitacora, int aSobreEscribirBitacora, int aEsCalculoArimetico);

        [DllImport("MGWServicios.dll", EntryPoint = "fRegresaPrecioVenta")]
        public static extern int fRegresaPrecioVenta(string aCodigoConcepto, string aCodigoCliente, string aCodigoProducto, StringBuilder aPrecioVenta);

        [DllImport("MGWServicios.dll", EntryPoint = "fBuscaProducto")]
        public static extern int fBuscaProducto(string aCodProducto);

        [DllImport("MGWServicios.dll", EntryPoint = "fBuscaIdProducto")]
        public static extern int fBuscaIdProducto(int aIdProducto);

        [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerProducto")]
        public static extern int fPosPrimerProducto();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimoProducto")]
        public static extern int fPosUltimoProducto();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteProducto")]
        public static extern int fPosSiguienteProducto();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorProducto")]
        public static extern int fPosAnteriorProducto();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosBOFProducto")]
        public static extern int fPosBOFProducto();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosEOFProducto")]
        public static extern int fPosEOFProducto();

        [DllImport("MGWServicios.dll", EntryPoint = "AltaProducto")]
        public static extern int AltaProducto(ref int aIdProducto, tProduto astProducto);

        [DllImport("MGWServicios.dll", EntryPoint = "fActualizaProducto")]
        public static extern int fActualizaProducto(ref int aCodigoProducto, tProduto astProducto);

        [DllImport("MGWServicios.dll", EntryPoint = "fLlenaRegistroProducto")]
        public static extern int fLlenaRegistroProducto(tProduto astProducto, int aEsAlta);

        #endregion

        #region Addendas

        [DllImport("MGWServicios.dll", EntryPoint = "fInsertaDatoCompEducativo")]
        public static extern int fInsertaDatoCompEducativo(int aIdServicio, int aNumCampo, StringBuilder aDato);

        [DllImport("MGWServicios.dll", EntryPoint = "fInsertaDatoAddendaDocto")]
        public static extern int fInsertaDatoAddendaDocto(int aIdAddenda, int aIdCatalogo, int aNumCampo, StringBuilder aDato);

        [DllImport("MGWServicios.dll", EntryPoint = "fInsertaDatoAddendaMovto")]
        public static extern int fInsertaDatoAddendaMovto(int aIdAddenda, int aIdCatalogo, int aNumCampo, StringBuilder aDato);

        [DllImport("MGWServicios.dll", EntryPoint = "fObtenCeryKey")]
        public static extern int fObtenCeryKey(int aIdFirmarl, string aRutaKey, string aRutaCer);

        [DllImport("MGWServicios.dll", EntryPoint = "fObtieneLicencia")]
        public static extern int fObtieneLicencia(StringBuilder aCodAcvtiva, StringBuilder aCodSitio, StringBuilder aSerie, StringBuilder aTagVersion);

        [DllImport("MGWServicios.dll", EntryPoint = "fObtienePassProxy")]
        public static extern int fObtienePassProxy(StringBuilder aPassProxy);

        [DllImport("MGWServicios.dll", EntryPoint = "fTimbraXML")]
        public static extern int fTimbraXML(StringBuilder aRutaXML, StringBuilder aCodCOncepto, StringBuilder aUUID, StringBuilder aRutaDDA, StringBuilder aRutaResultado, StringBuilder aPass, StringBuilder aRutaFormato);

        [DllImport("MGWServicios.dll", EntryPoint = "fTimbraNominaXML")]
        public static extern int fTimbraNominaXML(StringBuilder aRutaXML, StringBuilder aCodCOncepto, StringBuilder aUUID, StringBuilder aRutaDDA, StringBuilder aRutaResultado, StringBuilder aPass, StringBuilder aRutaFormato);

        [DllImport("MGWServicios.dll", EntryPoint = "fTimbraComplementoXML")]
        public static extern int fTimbraComplementoXML(string aRutaXML, string aCodCOncepto, string aUUID, string aRutaDDA, string aRutaResultado, string aPass, string aRutaFormato, int aComplemento);

        [DllImport("MGWServicios.dll", EntryPoint = "fCancelaUUID")]
        public static extern int fCancelaUUID(string aUUID, string aIdDConcepto, string aPass);

        [DllImport("MGWServicios.dll", EntryPoint = "fCancelaNominaUUID")]
        public static extern int fCancelaNominaUUID(string aUUID, string aIdDConcepto, string aPass);

        #endregion

        #region Direcciones

        [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaDireccion")]
        public static extern int fInsertaDireccion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fEditaDireccion")]
        public static extern int fEditaDireccion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaDireccion")]
        public static extern int fGuardaDireccion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionDireccion")]
        public static extern int fCancelarModificacionDireccion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoDireccion")]
        public static extern int fLeeDatoDireccion(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoDireccion")]
        public static extern int fSetDatoDireccion(string aCampo, string aValor);

        [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaDireccionEmpresa")]
        public static extern int fBuscaDireccionEmpresa();

        [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaDireccionCteProv")]
        public static extern int fBuscaDireccionCteProv(string aCodCteProv, int aTipoDireccion);

        [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaDireccionDocumento")]
        public static extern int fBuscaDireccionDocumento(int aIdDocumento, int aTipoDireccion);

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerDireccion")]
        public static extern int fPosPrimerDireccion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimaDireccion")]
        public static extern int fPosUltimaDireccion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteDireccion")]
        public static extern int fPosSiguienteDireccion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorDireccion")]
        public static extern int fPosAnteriorDireccion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFDireccion")]
        public static extern int fPosBOFDireccion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFDireccion")]
        public static extern int fPosEOFDireccion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fAltaDireccion")]
        public static extern int fAltaDireccion(ref int aIdDireccion, ref tDireccion astDireccion);

        [DllImport("MGW_SDK.dll", EntryPoint = "fActualizaDireccion")]
        public static extern int fActualizaDireccion(ref tDireccion astDireccion);

        [DllImport("MGW_SDK.dll", EntryPoint = "fLlenaRegistroDireccion")]
        public static extern int fLlenaRegistroDireccion(ref tDireccion astDireccion, int aEsAlta);

        #endregion

        #region Existencias

        [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaExistencia")]
        public static extern int fRegresaExistencia(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, ref double aExistencia);

        [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaExistenciaCaracteristicas")]
        public static extern int fRegresaExistenciaCaracteristicas(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, ref double aExistencia);

        #endregion

        #region Costo Historico

        [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaCostoPromedio")]
        public static extern int fRegresaCostoPromedio(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, StringBuilder aCostoPromedio);

        [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaUltimoCosto")]
        public static extern int fRegresaUltimoCosto(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, StringBuilder aUltimoCosto);

        [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaCostoEstandar")]
        public static extern int fRegresaCostoEstandar(string aCodigoProducto, StringBuilder aCostoEstandar);

        [DllImport("MGW_SDK.dll", EntryPoint = "fRegresaCostoCapa")]
        public static extern int fRegresaCostoCapa(string aCodigoProducto, string aCodigoAlmacen, double aUnidades, StringBuilder aImporteCosto);

        #endregion

        #region Conceptos De Documentos

        [DllImport("MGWServicios.dll", EntryPoint = "fLeeDatoConceptoDocto")]
        public static extern int fLeeDatoConceptoDocto(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGWServicios.dll", EntryPoint = "fRegresPorcentajeImpuesto")]
        public static extern int fRegresPorcentajeImpuesto(int aIdConceptoDocumento, int aIdClienteProveedor, int aIdProducto, ref double aPorcentajeImpuesto);

        [DllImport("MGWServicios.dll", EntryPoint = "fEditaConceptoDocto")]
        public static extern int fEditaConceptoDocto();

        [DllImport("MGWServicios.dll", EntryPoint = "fSetDatoConceptoDocto")]
        public static extern int fSetDatoConceptoDocto(StringBuilder aCampo, StringBuilder aValor);

        [DllImport("MGWServicios.dll", EntryPoint = "fGuardaConceptoDocto")]
        public static extern int fGuardaConceptoDocto();

        [DllImport("MGWServicios.dll", EntryPoint = "fBuscaConceptoDocto")]
        public static extern int fBuscaConceptoDocto(string aCodConcepto);

        [DllImport("MGWServicios.dll", EntryPoint = "fBuscaIdConceptoDocto")]
        public static extern int fBuscaIdConceptoDocto(int aIdConcepto);

        [DllImport("MGWServicios.dll", EntryPoint = "fPosPrimerConceptoDocto")]
        public static extern int fPosPrimerConceptoDocto();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosUltimaConceptoDocto")]
        public static extern int fPosUltimaConceptoDocto();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosSiguienteConceptoDocto")]
        public static extern int fPosSiguienteConceptoDocto();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosAnteriorConceptoDocto")]
        public static extern int fPosAnteriorConceptoDocto();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosBOFConceptoDocto")]
        public static extern int fPosBOFConceptoDocto();

        [DllImport("MGWServicios.dll", EntryPoint = "fPosEOFConceptoDocto")]
        public static extern int fPosEOFConceptoDocto();

        #endregion

        #region Paramentros

        [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoParametros")]
        public static extern int fLeeDatoParametros(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGW_SDK.dll", EntryPoint = "fEditaParametros")]
        public static extern int fEditaParametros();

        [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaParametros")]
        public static extern int fGuardaParametros();

        [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoParametros")]
        public static extern int fSetDatoParametros(string aCampo, StringBuilder aValor);

        #endregion

        #region Catalago De Clasificaciones

        [DllImport("MGW_SDK.dll", EntryPoint = "fEditaClasificacion")]
        public static extern int fEditaClasificacion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaClasificacion")]
        public static extern int fGuardaClasificacion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionClasificacion")]
        public static extern int fCancelarModificacionClasificacion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fActualizaClasificacion")]
        public static extern int fActualizaClasificacion(int aClasificacionDe, int aNumClasificacion, string aNombreClasificacion);

        [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoClasificacion")]
        public static extern int fLeeDatoClasificacion(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoClasificacion")]
        public static extern int fSetDatoClasificacion(string aCampo, string aValor);

        [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaClasificacion")]
        public static extern int fBuscaClasificacion(int aClasificacionDe, int aNumClasificacion);

        [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaIdClasificacion")]
        public static extern int fBuscaIdClasificacion(int aIdClasificacion);

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerClasificacion")]
        public static extern int fPosPrimerClasificacion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimoClasificacion")]
        public static extern int fPosUltimoClasificacion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteClasificacion")]
        public static extern int fPosSiguienteClasificacion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorClasificacion")]
        public static extern int fPosAnteriorClasificacion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFClasificacion")]
        public static extern int fPosBOFClasificacion();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFClasificacion")]
        public static extern int fPosEOFClasificacion();

        #endregion

        #region Catalogo De Valores De Clasificaciones

        [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaValorClasif")]
        public static extern int fInsertaValorClasif();

        [DllImport("MGW_SDK.dll", EntryPoint = "fEditaValorClasif")]
        public static extern int fEditaValorClasif();

        [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaValorClasif")]
        public static extern int fGuardaValorClasif();

        [DllImport("MGW_SDK.dll", EntryPoint = "fBorraValorClasif")]
        public static extern int fBorraValorClasif();

        [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionValorClasif")]
        public static extern int fCancelarModificacionValorClasif();

        [DllImport("MGW_SDK.dll", EntryPoint = "fEliminarValorClasif")]
        public static extern int fEliminarValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodigoValorClasif);

        [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoValorClasif")]
        public static extern int fSetDatoValorClasif(string aCampo, string aValor);

        [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoValorClasif")]
        public static extern int fLeeDatoValorClasif(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaValorClasif")]
        public static extern int fBuscaValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodValorClasif);

        [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaIdValorClasif")]
        public static extern int fBuscaIdValorClasif(int aIdValorClasif);

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerValorClasif")]
        public static extern int fPosPrimerValorClasif();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimoValorClasif")]
        public static extern int fPosUltimoValorClasif();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteValorClasif")]
        public static extern int fPosSiguienteValorClasif();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorValorClasif")]
        public static extern int fPosAnteriorValorClasif();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFValorClasif")]
        public static extern int fPosBOFValorClasif();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFValorClasif")]
        public static extern int fPosEOFValorClasif();

        [DllImport("MGW_SDK.dll", EntryPoint = "fAltaValorClasif")]
        public static extern int fAltaValorClasif(ref int aIdValorClasif, ref tValorClasificacion astValorClasif);

        [DllImport("MGW_SDK.dll", EntryPoint = "fActualizaValorClasif")]
        public static extern int fActualizaValorClasif(string aCodigoValorClasif, ref tValorClasificacion astValorClasif);

        [DllImport("MGW_SDK.dll", EntryPoint = "fLlenaRegistroValorClasif")]
        public static extern int fLlenaRegistroValorClasif(ref tValorClasificacion astValorClasif);

        #endregion

        #region Catalogo De Unidades De Medida Y Peso

        [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaUnidad")]
        public static extern int fInsertaUnidad();

        [DllImport("MGW_SDK.dll", EntryPoint = "fEditaUnidad")]
        public static extern int fEditaUnidad();

        [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaUnidad")]
        public static extern int fGuardaUnidad();

        [DllImport("MGW_SDK.dll", EntryPoint = "fBorraUnidad")]
        public static extern int fBorraUnidad();

        [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionUnidad")]
        public static extern int fCancelarModificacionUnidad();

        [DllImport("MGW_SDK.dll", EntryPoint = "fEliminarUnidad")]
        public static extern int fEliminarUnidad(string aNombreUnidad);

        [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoUnidad")]
        public static extern int fLeeDatoUnidad(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoValorClasif")]
        public static extern int fSetDatoUnidad(string aCampo, string aValor);

        [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaUnidad")]
        public static extern int fBuscaUnidad(string aNombreUnidad);

        [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaIdUnidad")]
        public static extern int fBuscaIdUnidad(int aIdUnidad);

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerUnidad")]
        public static extern int fPosPrimerUnidad();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimoUnidad")]
        public static extern int fPosUltimoUnidad();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteUnidad")]
        public static extern int fPosSiguienteUnidad();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorUnidad")]
        public static extern int fPosAnteriorUnidad();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFUnidad")]
        public static extern int fPosBOFUnidad();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFUnidad")]
        public static extern int fPosEOFUnidad();

        [DllImport("MGW_SDK.dll", EntryPoint = "fAltaUnidad")]
        public static extern int fAltaUnidad(ref int aIdUnidad, ref tUnidad astUnidad);

        [DllImport("MGW_SDK.dll", EntryPoint = "fActualizaUnidad")]
        public static extern int fActualizaUnidad(string aNombreUnidad, ref tUnidad astUnidad);

        [DllImport("MGW_SDK.dll", EntryPoint = "fLlenaRegistroUnidad")]
        public static extern int fLlenaRegistroUnidad(ref tUnidad astUnidad);

        #endregion

        #region Catalogo De Agentes

        [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaAgente")]
        public static extern int fInsertaAgente();

        [DllImport("MGW_SDK.dll", EntryPoint = "fEditaAgente")]
        public static extern int fEditaAgente();

        [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaAgente")]
        public static extern int fGuardaAgente();

        [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionAgente")]
        public static extern int fCancelarModificacionAgente();

        [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoAgente")]
        public static extern int fSetDatoAgente(string aCampo, string aValor);

        [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoAgente")]
        public static extern int fLeeDatoAgente(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaAgente")]
        public static extern int fBuscaAgente(string aCodigoAgente);

        [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaIdAgente")]
        public static extern int fBuscaIdAgente(int aIdAgente);

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerAgente")]
        public static extern int fPosPrimerAgente();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimoAgente")]
        public static extern int fPosUltimoAgente();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteAgente")]
        public static extern int fPosSiguienteAgente();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorAgente")]
        public static extern int fPosAnteriorAgente();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFAgente")]
        public static extern int fPosBOFAgente();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFAgente")]
        public static extern int fPosEOFAgente();

        #endregion

        #region Catalago De Almacenes

        [DllImport("MGW_SDK.dll", EntryPoint = "fInsertaAlmacen")]
        public static extern int fInsertaAlmacen();

        [DllImport("MGW_SDK.dll", EntryPoint = "fEditaAlmacen")]
        public static extern int fEditaAlmacen();

        [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaAlmacen")]
        public static extern int fGuardaAlmacen();

        [DllImport("MGW_SDK.dll", EntryPoint = "fCancelarModificacionAlmacen")]
        public static extern int fCancelarModificacionAlmacen();

        [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoAlmacen")]
        public static extern int fLeeDatoAlmacen(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoAlmacen")]
        public static extern int fSetDatoAlmacen(string aCampo, string aValor);

        [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaAlmacen")]
        public static extern int fBuscaAlmacen(string aCodigoAlmacen);

        [DllImport("MGW_SDK.dll", EntryPoint = "fBuscaIdAlmacen")]
        public static extern int fBuscaIdAlmacen(int aIdAlmacen);

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerAlmacen")]
        public static extern int fPosPrimerAlmacen();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosUltimoAlmacen")]
        public static extern int fPosUltimoAlmacen();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteAlmacen")]
        public static extern int fPosSiguienteAlmacen();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosAnteriorAlmacen")]
        public static extern int fPosAnteriorAlmacen();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosBOFAlmacen")]
        public static extern int fPosBOFAlmacen();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFAlmacen")]
        public static extern int fPosEOFAlmacen();

        #endregion

        #region Movimientos Contables

        [DllImport("MGW_SDK.dll", EntryPoint = "fEditaMovtoContable")]
        public static extern int fEditaMovtoContable();

        [DllImport("MGW_SDK.dll", EntryPoint = "fGuardaMovtoContable")]
        public static extern int fGuardaMovtoContable();

        [DllImport("MGW_SDK.dll", EntryPoint = "fLeeDatoMovtoContable")]
        public static extern int fLeeDatoMovtoContable(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGW_SDK.dll", EntryPoint = "fSetDatoMovtoContable")]
        public static extern int fSetDatoMovtoContable(string aCampo, string aValor);

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosPrimerMovtoContable")]
        public static extern int fPosPrimerMovtoContable();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosSiguienteMovtoContable")]
        public static extern int fPosSiguienteMovtoContable();

        [DllImport("MGW_SDK.dll", EntryPoint = "fPosEOFMovtoContable")]
        public static extern int fPosEOFMovtoContable();

        #endregion

        #region Constantes

        public const int kLongFecha = 24;

        public const int kLongSerie = 12;

        public const int kLongCodigo = 31;

        public const int kLongNombre = 61;

        public const int kLongRuta = 254;

        public const int kLongReferencia = 21;

        public const int kLongDescripcion = 61;

        public const int kLongCuenta = 101;

        public const int kLongMensaje = 3001;

        public const int kLongNombreProducto = 256;

        public const int kLongAbreviatura = 4;

        public const int kLongCodValorClasif = 4;

        public const int kLongDenComercial = 51;

        public const int kLongRepLegal = 51;

        public const int kLongTextoExtra = 51;

        public const int kLongRFC = 21;

        public const int kLongCURP = 21;

        public const int kLongDesCorta = 21;

        public const int kLongNumeroExtInt = 7;

        public const int kLongNumeroExpandido = 31;

        public const int kLongCodigoPostal = 7;

        public const int kLongTelefono = 16;

        public const int kLongEmailWeb = 51;

        public const int kLongSelloSat = 176;

        public const int kLonSerieCertSAT = 21;

        public const int kLongFechaHora = 36;

        public const int kLongSelloCFDI = 176;

        public const int kLongCadOrigComplSAT = 501;

        public const int kLongitudUUID = 37;

        public const int kLongitudRegimen = 101;

        public const int kLongitudMoneda = 61;

        public const int kLongitudFolio = 17;

        public const int kLongitudMonto = 31;

        public const int kLogitudLugarExpedicion = 401;

        #endregion

        #region Tipos de dato abstractos

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tDocumento
        {
            public double aFolio;

            public int aNumMoneda;

            public double aTipoCambio;

            public double aImporte;

            public double aDescuentoDoc1;

            public double aDescuentoDoc2;

            public int aSistemaOrigen;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string aCodConcepto;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongSerie)]
            public string aSerie;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongFecha)]
            public string aFecha;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string aCodigoCteProv;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string aCodigoAgente;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongReferencia)]
            public string aReferencia;

            public int aAfecta;

            public double aGasto1;

            public double aGasto2;

            public double aGasto3;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tLlaveDoc
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string aCodConcepto;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongSerie)]
            public string aSerie;

            public double aFolio;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tMovimiento
        {
            public int aConsecutivo;

            public double aUnidades;

            public double aPrecio;

            public double aCosto;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string aCodProdSer;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string aCodAlmacen;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongReferencia)]
            public string aReferencia;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string aCodClasificacion;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tMovimientoDesc
        {
            int aConsecutivo;

            double aUnidades;

            double aPrecio;

            double aCosto;

            double aPorcDescto1;

            double aImporteDescto1;

            double aPorcDescto2;

            double aImporteDescto2;

            double aPorcDescto3;

            double aImporteDescto3;

            double aPorcDescto4;

            double aImporteDescto4;

            double aPorcDescto5;

            double aImporteDescto5;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            string aCodProdSer;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            string aCodAlmacen;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongReferencia)]
            string aReferencia;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            string aCodClasificacion;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tSeriesCapas
        {
            public double aUnidades;

            public double aTipoCambio;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string aSeries;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            public string aPedimento;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            public string aAgencia;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongFecha)]
            public string aFechaPedimento;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            public string aNumeroLote;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongFecha)]
            public string aFechaFabricacion;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongFecha)]
            public string aFechaCaducidad;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tCaracteristicas
        {
            double aUnidades;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            string aValorCaracteristica1;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            string aValorCaracteristica2;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            string aValorCaracteristica3;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tTipoProducto
        {
            tSeriesCapas aSeriesCapas;

            tCaracteristicas aCaracteristicas;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tLlaveAper
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            string aCodCaja;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongFecha)]
            string aFechaApe;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tProduto
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string cCodigoProducto;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongNombre)]
            public string cNombreProducto;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongNombreProducto)]
            public string cDescripcionProducto;

            public int cTipoProducto;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongFecha)]
            public string cFechaAltaProducto;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongFecha)]
            public string cFechaBaja;

            public int cStatusProducto;

            public int cControlExistencia;

            public int cMetodoCosteo;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string cCodigoUnidadBase;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string cCodigoUnidadNoConvertible;

            public double cPrecio1;

            public double cPrecio2;

            public double cPrecio3;

            public double cPrecio4;

            public double cPrecio5;

            public double cPrecio6;

            public double cPrecio7;

            public double cPrecio8;

            public double cPrecio9;

            public double cPrecio10;

            public double cImpuesto1;

            public double cImpuesto2;

            public double cImpuesto3;

            public double cRetencion1;

            public double cRetencion2;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongNombre)]
            public string cNombreCaracteristica1;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongNombre)]
            public string cNombreCaracteristica2;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongNombre)]
            public string cNombreCaracteristica3;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacion1;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacion2;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacion3;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacion4;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacion5;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacion6;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongTextoExtra)]
            public string cTextoExtra1;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongTextoExtra)]
            public string cTextoExtra2;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongTextoExtra)]
            public string cTextoExtra3;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongFecha)]
            public string cFechaExtra;

            public double cImporteExtra1;

            public double cImporteExtra2;

            public double cImporteExtra3;

            public double cImporteExtra4;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tCteProv
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string cCodigoCliente;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongNombre)]
            public string cRazonSocial;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongFecha)]
            public string cFechaAlta;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongRFC)]
            public string cRFC;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCURP)]
            public string cCURP;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDenComercial)]
            public string cDenComercial;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongRepLegal)]
            public string cRepLegal;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongNombre)]
            public string cNombreMoneda;

            public int cListaPreciosCliente;

            public double cDescuentoMovto;

            public int cBanVentaCredito;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacionCliente1;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacionCliente2;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacionCliente3;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacionCliente4;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacionCliente5;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacionCliente6;

            public int cTipoCliente;

            public int cEstatus;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongFecha)]
            public string cFechaBaja;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongFecha)]
            public string cFechaUltimaRevision;

            public double cLimiteCreditoCliente;

            public int cDiasCreditoCliente;

            public int cBanExcederCredito;

            public double cDescuentoProntoPago;

            public int cDiasProntoPago;

            public double cInteresMoratorio;

            public int cDiaPago;

            public int cDiasRevision;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDesCorta)]
            public string cMensajeria;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            public string cCuentaMensajeria;

            public int cDiasEmbarqueCliente;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string cCodigoAlmacen;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string cCodigoAgenteVenta;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string cCodigoAgenteCobro;

            public int cRestriccionAgente;

            public double cImpuesto1;

            public double cImpuesto2;

            public double cImpuesto3;

            public double cRetencionCliente1;

            public double cRetencionCliente2;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacionProveedor1;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacionProveedor2;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacionProveedor3;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacionProveedor4;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacionProveedor5;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacionProveedor6;

            public double cLimiteCreditoProveedor;

            public int cDiasCreditoProveedor;

            public int cTiempoEntrega;

            public int cDiasEmbarqueProveedor;

            public double cImpuestoProveedor1;

            public double cImpuestoProveedor2;

            public double cImpuestoProveedor3;

            public double cRetencionProveedor1;

            public double cRetencionProveedor2;

            public int cBanInteresMoratorio;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongTextoExtra)]
            public string cTextoExtra1;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongTextoExtra)]
            public string cTextoExtra2;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongTextoExtra)]
            public string cTextoExtra3;

            public double cImporteExtra1;

            public double cImporteExtra2;

            public double cImporteExtra3;

            public double cImporteExtra4;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tValorClasificacion
        {

            int cClasificacionDe;

            int cNumClasificacion;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            string cCodigoValorClasificacion;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            string cValorClasificacion;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tUnidad
        {

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongNombre)]
            string cNombreUnidad;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongAbreviatura)]
            string cAbreviatura;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongAbreviatura)]
            string cDespliegue;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tDireccion
        {

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            string cCodCteProv;

            int cTipoCatalogo;

            int cTipoDireccion;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            string cNombreCalle;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongNumeroExpandido)]
            string cNumeroExterior;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongNumeroExpandido)]
            string cNumeroInterior;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            string cColonia;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigoPostal)]
            string cCodigoPostal;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongTelefono)]
            string cTelefono1;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongTelefono)]
            string cTelefono2;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongTelefono)]
            string cTelefono3;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongTelefono)]
            string cTelefono4;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongEmailWeb)]
            string cEmail;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongEmailWeb)]
            string cDireccionWeb;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            string cCiudad;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            string cEstado;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            string cPais;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            string cTextoExtra;
        }

        #endregion
    }
}

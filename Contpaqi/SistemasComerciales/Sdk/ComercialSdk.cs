using System.Runtime.InteropServices;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk
{
    public static class ComercialSdk
    {
        #region Generales

        [DllImport("MGWServicios.DLL", EntryPoint = "fInicializaSDK")]
        public static extern int fInicializaSDK();

        [DllImport("MGWServicios.DLL", EntryPoint = "fTerminaSDK")]
        public static extern void fTerminaSDK();

        [DllImport("MGWServicios.DLL", EntryPoint = "fSetNombrePAQ")]
        public static extern int fSetNombrePAQ(string aSistema);

        [DllImport("MGWServicios.DLL", EntryPoint = "fError")]
        public static extern void fError(int aNumError, StringBuilder aMensaje, int aLen);

        [DllImport("MGWServicios.DLL", EntryPoint = "fInicioSesionSDK")]
        public static extern void fInicioSesionSDK(string aUsuario, string aContrasenia);

        [DllImport("MGWServicios.DLL", EntryPoint = "fSetModoImportacion")]
        public static extern void fSetModoImportacion(bool aImportacion);

        #endregion

        #region Empresas

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosPrimerEmpresa")]
        public static extern int fPosPrimerEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa);

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosSiguienteEmpresa")]
        public static extern int fPosSiguienteEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa);

        [DllImport("MGWServicios.dll", EntryPoint = "fAbreEmpresa")]
        public static extern int fAbreEmpresa(string aDirectorioEmpresa);

        [DllImport("MGWServicios.dll", EntryPoint = "fCierraEmpresa")]
        public static extern void fCierraEmpresa();

        #endregion

        #region Documentos

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

        [DllImport("MGWServicios.dll", EntryPoint = "fSaldarDocumento_Param")]
        public static extern int fSaldarDocumento_Param(string aCodConcepto_Pagar, string aSerie_Pagar, string aFolio_Pagar, string aCodConcepto_Pago, string aSerie_Pago, string aFolio_Pago, double aImporte, int aIdMoneda, string aFecha);

        [DllImport("MGWServicios.dll", EntryPoint = "fBorrarAsociacion_Param")]
        public static extern int fBorrarAsociacion_Param(string aCodConcepto_Pagar, string aSerie_Pagar, string aFolio_Pagar, string aCodConcepto_Pago, string aSerie_Pago, string aFolio_Pago);

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

        [DllImport("MGWServicios.dll", EntryPoint = "fSaldarDocumento")]
        public static extern int fSaldarDocumento(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha);

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

        [DllImport("MGWServicios.dll", EntryPoint = "fBuscaDocumento")]
        public static extern int fBuscaDocumento(ref tLlaveDoc aLlaveDocto);

        #endregion

        #region Movimientos

        [DllImport("MGWServicios.dll", EntryPoint = "fInsertarMovimiento")]
        public static extern int fInsertarMovimiento();

        [DllImport("MGWServicios.dll", EntryPoint = "fEditarMovimiento")]
        public static extern int fEditarMovimiento();

        [DllImport("MGWServicios.dll", EntryPoint = "fBorraMovimiento")]
        public static extern int fBorraMovimiento(int aIdDocumento, int aIdMovimiento);

        [DllImport("MGWServicios.dll", EntryPoint = "fDesbloqueaDocumento")]
        public static extern int fDesbloqueaDocumento();

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

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaDoctoAjusteIESPSCteProv")]
        public static extern int fAltaDoctoAjusteIESPSCteProv(string aCodigoClienteProveedor, int aEsCliente, string aFechaDocto, int aIdMoneda, double aTipoCambio, double aImporteIVA, double aTasaIVA, double aImporteIESPS, double aTasaIESPS, int aIdFacturaBase, string aMetodo, string aLugar, ref int aIdDoctoGenerado);

        [DllImport("MGWServicios.dll", EntryPoint = "fAltaMovimiento")]
        public static extern int fAltaMovimiento(int aIdDocumento, ref int aIdMovimiento, ref tMovimiento astMovimiento);

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
        public static extern int fAltaProducto(ref int aIdProducto, tProducto astProducto);

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
        public static extern int AltaProducto(ref int aIdProducto, tProducto astProducto);

        [DllImport("MGWServicios.dll", EntryPoint = "fActualizaProducto")]
        public static extern int fActualizaProducto(ref int aCodigoProducto, tProducto astProducto);

        [DllImport("MGWServicios.dll", EntryPoint = "fLlenaRegistroProducto")]
        public static extern int fLlenaRegistroProducto(tProducto astProducto, int aEsAlta);

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

        #endregion

        #region Direcciones

        [DllImport("MGWServicios.DLL", EntryPoint = "fInsertaDireccion")]
        public static extern int fInsertaDireccion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fEditaDireccion")]
        public static extern int fEditaDireccion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fGuardaDireccion")]
        public static extern int fGuardaDireccion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fCancelarModificacionDireccion")]
        public static extern int fCancelarModificacionDireccion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fLeeDatoDireccion")]
        public static extern int fLeeDatoDireccion(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGWServicios.DLL", EntryPoint = "fSetDatoDireccion")]
        public static extern int fSetDatoDireccion(string aCampo, string aValor);

        [DllImport("MGWServicios.DLL", EntryPoint = "fBuscaDireccionEmpresa")]
        public static extern int fBuscaDireccionEmpresa();

        [DllImport("MGWServicios.DLL", EntryPoint = "fBuscaDireccionCteProv")]
        public static extern int fBuscaDireccionCteProv(string aCodCteProv, int aTipoDireccion);

        [DllImport("MGWServicios.DLL", EntryPoint = "fBuscaDireccionDocumento")]
        public static extern int fBuscaDireccionDocumento(int aIdDocumento, int aTipoDireccion);

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosPrimerDireccion")]
        public static extern int fPosPrimerDireccion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosUltimaDireccion")]
        public static extern int fPosUltimaDireccion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosSiguienteDireccion")]
        public static extern int fPosSiguienteDireccion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosAnteriorDireccion")]
        public static extern int fPosAnteriorDireccion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosBOFDireccion")]
        public static extern int fPosBOFDireccion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosEOFDireccion")]
        public static extern int fPosEOFDireccion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fAltaDireccion")]
        public static extern int fAltaDireccion(ref int aIdDireccion, ref tDireccion astDireccion);

        [DllImport("MGWServicios.DLL", EntryPoint = "fActualizaDireccion")]
        public static extern int fActualizaDireccion(ref tDireccion astDireccion);

        [DllImport("MGWServicios.DLL", EntryPoint = "fLlenaRegistroDireccion")]
        public static extern int fLlenaRegistroDireccion(ref tDireccion astDireccion, int aEsAlta);

        #endregion

        #region Existencias

        [DllImport("MGWServicios.DLL", EntryPoint = "fRegresaExistencia")]
        public static extern int fRegresaExistencia(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, ref double aExistencia);

        [DllImport("MGWServicios.DLL", EntryPoint = "fRegresaExistenciaCaracteristicas")]
        public static extern int fRegresaExistenciaCaracteristicas(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, ref double aExistencia);

        #endregion

        #region Costo Historico

        [DllImport("MGWServicios.DLL", EntryPoint = "fRegresaCostoPromedio")]
        public static extern int fRegresaCostoPromedio(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, StringBuilder aCostoPromedio);

        [DllImport("MGWServicios.DLL", EntryPoint = "fRegresaUltimoCosto")]
        public static extern int fRegresaUltimoCosto(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, StringBuilder aUltimoCosto);

        [DllImport("MGWServicios.DLL", EntryPoint = "fRegresaCostoEstandar")]
        public static extern int fRegresaCostoEstandar(string aCodigoProducto, StringBuilder aCostoEstandar);

        [DllImport("MGWServicios.DLL", EntryPoint = "fRegresaCostoCapa")]
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

        [DllImport("MGWServicios.DLL", EntryPoint = "fLeeDatoParametros")]
        public static extern int fLeeDatoParametros(string aCampo, StringBuilder aValor, int aLen);

        #endregion

        #region Catalago De Clasificaciones

        [DllImport("MGWServicios.DLL", EntryPoint = "fEditaClasificacion")]
        public static extern int fEditaClasificacion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fGuardaClasificacion")]
        public static extern int fGuardaClasificacion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fCancelarModificacionClasificacion")]
        public static extern int fCancelarModificacionClasificacion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fActualizaClasificacion")]
        public static extern int fActualizaClasificacion(int aClasificacionDe, int aNumClasificacion, string aNombreClasificacion);

        [DllImport("MGWServicios.DLL", EntryPoint = "fLeeDatoClasificacion")]
        public static extern int fLeeDatoClasificacion(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGWServicios.DLL", EntryPoint = "fSetDatoClasificacion")]
        public static extern int fSetDatoClasificacion(string aCampo, string aValor);

        [DllImport("MGWServicios.DLL", EntryPoint = "fBuscaClasificacion")]
        public static extern int fBuscaClasificacion(int aClasificacionDe, int aNumClasificacion);

        [DllImport("MGWServicios.DLL", EntryPoint = "fBuscaIdClasificacion")]
        public static extern int fBuscaIdClasificacion(int aIdClasificacion);

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosPrimerClasificacion")]
        public static extern int fPosPrimerClasificacion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosUltimoClasificacion")]
        public static extern int fPosUltimoClasificacion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosSiguienteClasificacion")]
        public static extern int fPosSiguienteClasificacion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosAnteriorClasificacion")]
        public static extern int fPosAnteriorClasificacion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosBOFClasificacion")]
        public static extern int fPosBOFClasificacion();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosEOFClasificacion")]
        public static extern int fPosEOFClasificacion();

        #endregion

        #region Catalogo De Valores De Clasificaciones

        [DllImport("MGWServicios.DLL", EntryPoint = "fInsertaValorClasif")]
        public static extern int fInsertaValorClasif();

        [DllImport("MGWServicios.DLL", EntryPoint = "fEditaValorClasif")]
        public static extern int fEditaValorClasif();

        [DllImport("MGWServicios.DLL", EntryPoint = "fGuardaValorClasif")]
        public static extern int fGuardaValorClasif();

        [DllImport("MGWServicios.DLL", EntryPoint = "fBorraValorClasif")]
        public static extern int fBorraValorClasif();

        [DllImport("MGWServicios.DLL", EntryPoint = "fCancelarModificacionValorClasif")]
        public static extern int fCancelarModificacionValorClasif();

        [DllImport("MGWServicios.DLL", EntryPoint = "fEliminarValorClasif")]
        public static extern int fEliminarValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodigoValorClasif);

        [DllImport("MGWServicios.DLL", EntryPoint = "fSetDatoValorClasif")]
        public static extern int fSetDatoValorClasif(string aCampo, string aValor);

        [DllImport("MGWServicios.DLL", EntryPoint = "fLeeDatoValorClasif")]
        public static extern int fLeeDatoValorClasif(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGWServicios.DLL", EntryPoint = "fBuscaValorClasif")]
        public static extern int fBuscaValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodValorClasif);

        [DllImport("MGWServicios.DLL", EntryPoint = "fBuscaIdValorClasif")]
        public static extern int fBuscaIdValorClasif(int aIdValorClasif);

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosPrimerValorClasif")]
        public static extern int fPosPrimerValorClasif();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosUltimoValorClasif")]
        public static extern int fPosUltimoValorClasif();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosSiguienteValorClasif")]
        public static extern int fPosSiguienteValorClasif();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosAnteriorValorClasif")]
        public static extern int fPosAnteriorValorClasif();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosBOFValorClasif")]
        public static extern int fPosBOFValorClasif();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosEOFValorClasif")]
        public static extern int fPosEOFValorClasif();

        [DllImport("MGWServicios.DLL", EntryPoint = "fAltaValorClasif")]
        public static extern int fAltaValorClasif(ref int aIdValorClasif, ref tValorClasificacion astValorClasif);

        [DllImport("MGWServicios.DLL", EntryPoint = "fActualizaValorClasif")]
        public static extern int fActualizaValorClasif(string aCodigoValorClasif, ref tValorClasificacion astValorClasif);

        [DllImport("MGWServicios.DLL", EntryPoint = "fLlenaRegistroValorClasif")]
        public static extern int fLlenaRegistroValorClasif(ref tValorClasificacion astValorClasif);

        #endregion

        #region Catalogo De Unidades De Medida Y Peso

        [DllImport("MGWServicios.DLL", EntryPoint = "fInsertaUnidad")]
        public static extern int fInsertaUnidad();

        [DllImport("MGWServicios.DLL", EntryPoint = "fEditaUnidad")]
        public static extern int fEditaUnidad();

        [DllImport("MGWServicios.DLL", EntryPoint = "fGuardaUnidad")]
        public static extern int fGuardaUnidad();

        [DllImport("MGWServicios.DLL", EntryPoint = "fBorraUnidad")]
        public static extern int fBorraUnidad();

        [DllImport("MGWServicios.DLL", EntryPoint = "fCancelarModificacionUnidad")]
        public static extern int fCancelarModificacionUnidad();

        [DllImport("MGWServicios.DLL", EntryPoint = "fEliminarUnidad")]
        public static extern int fEliminarUnidad(string aNombreUnidad);

        [DllImport("MGWServicios.DLL", EntryPoint = "fLeeDatoUnidad")]
        public static extern int fLeeDatoUnidad(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGWServicios.DLL", EntryPoint = "fSetDatoValorClasif")]
        public static extern int fSetDatoUnidad(string aCampo, string aValor);

        [DllImport("MGWServicios.DLL", EntryPoint = "fBuscaUnidad")]
        public static extern int fBuscaUnidad(string aNombreUnidad);

        [DllImport("MGWServicios.DLL", EntryPoint = "fBuscaIdUnidad")]
        public static extern int fBuscaIdUnidad(int aIdUnidad);

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosPrimerUnidad")]
        public static extern int fPosPrimerUnidad();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosUltimoUnidad")]
        public static extern int fPosUltimoUnidad();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosSiguienteUnidad")]
        public static extern int fPosSiguienteUnidad();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosAnteriorUnidad")]
        public static extern int fPosAnteriorUnidad();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosBOFUnidad")]
        public static extern int fPosBOFUnidad();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosEOFUnidad")]
        public static extern int fPosEOFUnidad();

        [DllImport("MGWServicios.DLL", EntryPoint = "fAltaUnidad")]
        public static extern int fAltaUnidad(ref int aIdUnidad, ref tUnidad astUnidad);

        [DllImport("MGWServicios.DLL", EntryPoint = "fActualizaUnidad")]
        public static extern int fActualizaUnidad(string aNombreUnidad, ref tUnidad astUnidad);

        [DllImport("MGWServicios.DLL", EntryPoint = "fLlenaRegistroUnidad")]
        public static extern int fLlenaRegistroUnidad(ref tUnidad astUnidad);

        #endregion

        #region Catalogo De Agentes

        [DllImport("MGWServicios.DLL", EntryPoint = "fInsertaAgente")]
        public static extern int fInsertaAgente();

        [DllImport("MGWServicios.DLL", EntryPoint = "fEditaAgente")]
        public static extern int fEditaAgente();

        [DllImport("MGWServicios.DLL", EntryPoint = "fGuardaAgente")]
        public static extern int fGuardaAgente();

        [DllImport("MGWServicios.DLL", EntryPoint = "fCancelarModificacionAgente")]
        public static extern int fCancelarModificacionAgente();

        [DllImport("MGWServicios.DLL", EntryPoint = "fSetDatoAgente")]
        public static extern int fSetDatoAgente(string aCampo, string aValor);

        [DllImport("MGWServicios.DLL", EntryPoint = "fLeeDatoAgente")]
        public static extern int fLeeDatoAgente(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGWServicios.DLL", EntryPoint = "fBuscaAgente")]
        public static extern int fBuscaAgente(string aCodigoAgente);

        [DllImport("MGWServicios.DLL", EntryPoint = "fBuscaIdAgente")]
        public static extern int fBuscaIdAgente(int aIdAgente);

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosPrimerAgente")]
        public static extern int fPosPrimerAgente();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosUltimoAgente")]
        public static extern int fPosUltimoAgente();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosSiguienteAgente")]
        public static extern int fPosSiguienteAgente();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosAnteriorAgente")]
        public static extern int fPosAnteriorAgente();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosBOFAgente")]
        public static extern int fPosBOFAgente();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosEOFAgente")]
        public static extern int fPosEOFAgente();

        #endregion

        #region Catalago De Almacenes

        [DllImport("MGWServicios.DLL", EntryPoint = "fInsertaAlmacen")]
        public static extern int fInsertaAlmacen();

        [DllImport("MGWServicios.DLL", EntryPoint = "fEditaAlmacen")]
        public static extern int fEditaAlmacen();

        [DllImport("MGWServicios.DLL", EntryPoint = "fGuardaAlmacen")]
        public static extern int fGuardaAlmacen();

        [DllImport("MGWServicios.DLL", EntryPoint = "fCancelarModificacionAlmacen")]
        public static extern int fCancelarModificacionAlmacen();

        [DllImport("MGWServicios.DLL", EntryPoint = "fLeeDatoAlmacen")]
        public static extern int fLeeDatoAlmacen(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGWServicios.DLL", EntryPoint = "fSetDatoAlmacen")]
        public static extern int fSetDatoAlmacen(string aCampo, string aValor);

        [DllImport("MGWServicios.DLL", EntryPoint = "fBuscaAlmacen")]
        public static extern int fBuscaAlmacen(string aCodigoAlmacen);

        [DllImport("MGWServicios.DLL", EntryPoint = "fBuscaIdAlmacen")]
        public static extern int fBuscaIdAlmacen(int aIdAlmacen);

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosPrimerAlmacen")]
        public static extern int fPosPrimerAlmacen();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosUltimoAlmacen")]
        public static extern int fPosUltimoAlmacen();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosSiguienteAlmacen")]
        public static extern int fPosSiguienteAlmacen();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosAnteriorAlmacen")]
        public static extern int fPosAnteriorAlmacen();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosBOFAlmacen")]
        public static extern int fPosBOFAlmacen();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosEOFAlmacen")]
        public static extern int fPosEOFAlmacen();

        #endregion

        #region Movimientos Contables

        [DllImport("MGWServicios.DLL", EntryPoint = "fEditaMovtoContable")]
        public static extern int fEditaMovtoContable();

        [DllImport("MGWServicios.DLL", EntryPoint = "fGuardaMovtoContable")]
        public static extern int fGuardaMovtoContable();

        [DllImport("MGWServicios.DLL", EntryPoint = "fLeeDatoMovtoContable")]
        public static extern int fLeeDatoMovtoContable(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGWServicios.DLL", EntryPoint = "fSetDatoMovtoContable")]
        public static extern int fSetDatoMovtoContable(string aCampo, string aValor);

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosPrimerMovtoContable")]
        public static extern int fPosPrimerMovtoContable();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosSiguienteMovtoContable")]
        public static extern int fPosSiguienteMovtoContable();

        [DllImport("MGWServicios.DLL", EntryPoint = "fPosEOFMovtoContable")]
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
            public int aConsecutivo;

            public double aUnidades;

            public double aPrecio;

            public double aCosto;

            public double aPorcDescto1;

            public double aImporteDescto1;

            public double aPorcDescto2;

            public double aImporteDescto2;

            public double aPorcDescto3;

            public double aImporteDescto3;

            public double aPorcDescto4;

            public double aImporteDescto4;

            public double aPorcDescto5;

            public double aImporteDescto5;

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
            public double aUnidades;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            public string aValorCaracteristica1;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            public string aValorCaracteristica2;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            public string aValorCaracteristica3;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tTipoProducto
        {
            public tSeriesCapas aSeriesCapas;

            public tCaracteristicas aCaracteristicas;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tLlaveAper
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string aCodCaja;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongFecha)]
            public string aFechaApe;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tProducto
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
            public int cClasificacionDe;

            public int cNumClasificacion;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodValorClasif)]
            public string cCodigoValorClasificacion;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            public string cValorClasificacion;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tUnidad
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongNombre)]
            public string cNombreUnidad;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongAbreviatura)]
            public string cAbreviatura;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongAbreviatura)]
            public string cDespliegue;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tDireccion
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigo)]
            public string cCodCteProv;

            public int cTipoCatalogo;

            public int cTipoDireccion;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            public string cNombreCalle;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongNumeroExpandido)]
            public string cNumeroExterior;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongNumeroExpandido)]
            public string cNumeroInterior;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            public string cColonia;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongCodigoPostal)]
            public string cCodigoPostal;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongTelefono)]
            public string cTelefono1;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongTelefono)]
            public string cTelefono2;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongTelefono)]
            public string cTelefono3;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongTelefono)]
            public string cTelefono4;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongEmailWeb)]
            public string cEmail;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongEmailWeb)]
            public string cDireccionWeb;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            public string cCiudad;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            public string cEstado;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            public string cPais;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = kLongDescripcion)]
            public string cTextoExtra;
        }

        #endregion
    }
}

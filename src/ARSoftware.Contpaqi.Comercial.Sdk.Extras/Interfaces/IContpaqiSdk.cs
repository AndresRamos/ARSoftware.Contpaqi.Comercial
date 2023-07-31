using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface IContpaqiSdk
{
    int fAbreEmpresa(string aDirectorioEmpresa);

    int fActivarPrecioCompra(int aActivar);

    int fActualizaClasificacion(int aClasificacionDe, int aNumClasificacion, string aNombreClasificacion);

    int fActualizaCteProv(string aCodigoCteProv, ref tCteProv astCteProv);

    int fActualizaDireccion(ref tDireccion astDireccion);

    int fActualizaProducto(string aCodigoProducto, ref tProducto astProducto);

    int fActualizaUnidad(string aNombreUnidad, ref tUnidad astUnidad);

    int fActualizaValorClasif(string aCodigoValorClasif, ref tValorClasificacion astValorClasif);

    int fAfectaDocto(ref tLlaveDoc aLlaveDocto, bool aAfecta);

    int fAfectaDocto_Param(string aCodConcepto, string aSerie, double aFolio, bool aAfecta);

    int fAfectaSerie(int aIdMovto, string aNumeroSerie);

    int fAgregarRelacionCFDI(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion, string aConceptoRelacionar,
        string aSerieRelacionar, string aFolioRelacionar);

    int fAgregarRelacionCFDI2(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion, string aUUID);

    int fAltaCteProv(ref int aIdCteProv, ref tCteProv astCteProv);

    int fAltaCuentaBancariaCliente(ref int aIdCtaBancaria, string aCuentaBancaria, string aNombreCuenta, string aNombreMoneda,
        string aClaveBanco, string aClabe, string aRfcBanco, string aNombreBancoExtranjero, string aCodigoCliente);

    int fAltaCuentaBancariaEmpresa(ref int aIdCtaBancaria, string aCuentaBancaria, string aNombreCuenta, string aNombreMoneda,
        string aClaveBanco, string aClabe, string aRfcBanco, string aNombreBancoExtranjero);

    int fAltaDireccion(ref int aIdDireccion, ref tDireccion astDireccion);

    int fAltaDoctoAjusteIESPSCteProv(string aCodigoClienteProveedor, int aEsCliente, string aFechaDocto, int aIdMoneda, double aTipoCambio,
        double aImporteIVA, double aTasaIVA, double aImporteIESPS, double aTasaIESPS, int aIdFacturaBase, string aMetodo, string aLugar,
        ref int aIdDoctoGenerado);

    int fAltaDoctoAjusteIVAClienteProveedor(string aCodigoClienteProveedor, int aEsCliente, int aAbsorberAjusteIVA, string aFechaDocto,
        int aIdMoneda, double aTipoCambio, double aImporteIVA, double aTasaIVA, int aIdFacturaBase, string aMetodo, string aLugar,
        ref int aIdDoctoGenerado);

    int fAltaDocumento(ref int aIdDocumento, ref tDocumento aDocumento);

    int fAltaDocumentoCargoAbono(ref tDocumento aDocumento);

    int fAltaDocumentoCargoAbonoExtras(ref tDocumento aDocumento, string aTextoExtra1, string aTextoExtra2, string aTextoExtra3,
        string aFechaExtra, double aImporteExtra1, double aImporteExtra2, double aImporteExtra3, double aImporteExtra4);

    int fAltaMovimiento(int aIdDocumento, ref int aIdMovimiento, ref tMovimiento astMovimiento);

    int fAltaMovimientoCaracteristicas(int aIdMovimiento, ref int aIdMovtoCaracteristicas, ref tCaracteristicas aCaracteristicas);

    int fAltaMovimientoCaracteristicas_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidades,
        string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3);

    int fAltaMovimientoCDesct(int aIdDocumento, ref int aIdMovimiento, ref tMovimientoDesc astMovimiento);

    int fAltaMovimientoEx(ref int aIdMovimiento, ref tTipoProducto aTipoProducto);

    int fAltaMovimientoSeriesCapas(int aIdMovimiento, ref tSeriesCapas aSeriesCapas);

    int fAltaMovimientoSeriesCapas_Param(string aIdMovimiento, string aUnidades, string aTipoCambio, string aSeries, string aPedimento,
        string aAgencia, string aFechaPedimento, string aNumeroLote, string aFechaFabricacion, string aFechaCaducidad);

    int fAltaMovtoCaracteristicasUnidades(int aIdMovimiento, ref int aIdMovtoCaracteristicas,
        ref tCaracteristicas aCaracteristicasUnidades);

    int fAltaMovtoCaracteristicasUnidades_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidad, string aUnidades,
        string aUnidadesNC, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3);

    int fAltaProducto(ref int aIdProducto, ref tProducto astProducto);

    int fAltaUnidad(ref int aIdUnidad, ref tUnidad astUnidad);

    int fAltaValorClasif(ref int aIdValorClasif, ref tValorClasificacion astValorClasif);

    int fBorraCteProv();

    int fBorraCuentaBancariaCliente(string aCuentaBancaria, string aCodigoCliente);

    int fBorraCuentaBancariaEmpresa(string aCuentaBancaria);

    int fBorraDocumento();

    int fBorraDocumento_CW();

    int fBorraMovimiento(int aIdDocumento, int aIdMovimiento);

    int fBorraProducto();

    int fBorrarAsociacion(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago);

    int fBorrarAsociacion_Param(string aCodConcepto_Pagar, string aSerie_Pagar, double aFolio_Pagar, string aCodConcepto_Pago,
        string aSerie_Pago, double aFolio_Pago);

    int fBorraUnidad();

    int fBorraValorClasif();

    int fBuscaAgente(string aCodigoAgente);

    int fBuscaAlmacen(string aCodigoAlmacen);

    int fBuscaClasificacion(int aClasificacionDe, int aNumClasificacion);

    int fBuscaConceptoDocto(string aCodConcepto);

    int fBuscaCteProv(string aCodCteProv);

    int fBuscaDireccionCteProv(string aCodCteProv, byte aTipoDireccion);

    int fBuscaDireccionDocumento(int aIdDocumento, byte aTipoDireccion);

    int fBuscaDireccionEmpresa();

    int fBuscaDocumento(ref tLlaveDoc aLlaveDocto);

    int fBuscaIdAgente(int aIdAgente);

    int fBuscaIdAlmacen(int aIdAlmacen);

    int fBuscaIdClasificacion(int aIdClasificacion);

    int fBuscaIdConceptoDocto(int aIdConcepto);

    int fBuscaIdCteProv(int aIdCteProv);

    int fBuscaIdProducto(int aIdProducto);

    int fBuscaIdUnidad(int aIdUnidad);

    int fBuscaIdValorClasif(int aIdValorClasif);

    int fBuscaProducto(string aCodProducto);

    int fBuscarDocumento(string aCodConcepto, string aSerie, string aFolio);

    int fBuscarIdDocumento(int aIdDocumento);

    int fBuscarIdMovimiento(int aIdMovimiento);

    int fBuscaUnidad(string aNombreUnidad);

    int fBuscaValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodValorClasif);

    int fCalculaMovtoSerieCapa(int aIdMovimiento);

    int fCancelaCambiosMovimiento();

    int fCancelaComplementoPagoUUID(string aUUID, string aIdDConcepto, string aPass);

    int fCancelaDoctoInfo(string aPass);

    int fCancelaDocumento();

    int fCancelaDocumento_CW();

    int fCancelaDocumentoAdministrativamente();

    int fCancelaDocumentoConMotivo(string aMotivoCancelacion, string aUUIDRemplaza);

    int fCancelaFiltroDocumento();

    int fCancelaFiltroMovimiento();

    int fCancelaNominaUUID(string aUUID, string aIdDConcepto, string aPass);

    int fCancelarModificacionAgente();

    int fCancelarModificacionAlmacen();

    int fCancelarModificacionClasificacion();

    int fCancelarModificacionCteProv();

    int fCancelarModificacionDireccion();

    int fCancelarModificacionDocumento();

    int fCancelarModificacionProducto();

    int fCancelarModificacionUnidad();

    int fCancelarModificacionValorClasif();

    int fCancelaUUID(string aUUID, string aIdDConcepto, string aPass);

    int fCancelaUUID40(string aUUID, string aMotivoCancelacion, string aUUIDReemplaza, string RFCReceptor, double aTotal,
        string aIdDConcepto, string aPass, ref int aEstatusCancelacion);

    void fCierraEmpresa();

    int fCuentaBancariaEmpresaDoctos(string aCuentaBancaria);

    int fDesbloqueaDocumento();

    int fDocumentoBloqueado(ref int aImpreso);

    int fDocumentoDevuelto(ref int aDevuelto);

    int fDocumentoImpreso(ref bool aImpreso);

    int fDocumentoUUID(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, StringBuilder atPtrCFDIUUID);

    int fEditaAgente();

    int fEditaAlmacen();

    int fEditaClasificacion();

    int fEditaConceptoDocto();

    int fEditaCteProv();

    int fEditaDireccion();

    int fEditaMovtoContable();

    int fEditaParametros();

    int fEditaProducto();

    int fEditarDocumento();

    int fEditarDocumentoCheqpaq();

    int fEditarMovimiento();

    int fEditaUnidad();

    int fEditaValorClasif();

    int fEliminarCteProv(string aCodigoCteProv);

    int fEliminarProducto(string aCodigoProducto);

    int fEliminarRelacionesCFDIs(string aCodConcepto, string aSerie, string aFolio);

    int fEliminarUnidad(string aNombreUnidad);

    int fEliminarValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodigoValorClasif);

    int fEmitirDocumento(string aCodConcepto, string aSerie, double aFolio, string aPassword, string aArchivoAdicional);

    int fEntregEnDiscoXML(string aCodConcepto, string aSerie, double aFolio, int aFormato, string aFormatoAmig);

    void fError(int aNumError, StringBuilder aMensaje, int aLen);

    int fGetCantidadParcialidades(StringBuilder atPtrPassword, StringBuilder aCantidadParcialidades);

    int fGetDatosCFDI(StringBuilder aSerieCertEmisor, StringBuilder aFolioFiscalUUID, StringBuilder aSerieCertSAT, StringBuilder aFechaHora,
        StringBuilder aSelloDigCFDI, StringBuilder aSelloSAAT, StringBuilder aCadOrigComplSAT, StringBuilder aRegimen,
        StringBuilder aLugarExpedicion, StringBuilder aMoneda, StringBuilder aFolioFiscalOrig, StringBuilder aSerieFolioFiscalOrig,
        StringBuilder aFechaFolioFiscalOrig, StringBuilder aMontoFolioFiscalOrig);

    int fGetNumParcialidades(StringBuilder atPtrPassword, StringBuilder aNumParcialidades);

    int fGetSelloDigitalYCadena(StringBuilder atPtrPassword, StringBuilder atPtrSelloDigital, StringBuilder atPtrCadenaOriginal);

    int fGetSerieCertificado(StringBuilder atPtrPassword, StringBuilder aSerieCertificado);

    int fGetTamSelloDigitalYCadena(StringBuilder atPtrPassword, ref int aEspSelloDig, ref int aEspCadOrig);

    int fGuardaAgente();

    int fGuardaAlmacen();

    int fGuardaClasificacion();

    int fGuardaConceptoDocto();

    int fGuardaCteProv();

    int fGuardaDireccion();

    int fGuardaDocumento();

    int fGuardaMovimiento();

    int fGuardaMovtoContable();

    int fGuardaParametros();

    int fGuardaProducto();

    int fGuardaUnidad();

    int fGuardaValorClasif();

    int fInformacionCliente(StringBuilder aCodigo, ref int aPermiteCredito, ref double aLimiteCredito, ref int aLimiteDoctosVencidos,
        ref int aPermiteExcederCredito, StringBuilder aFecha, ref double aSaldo, ref double aSaldoPendiente, ref int aDoctosVencidos);

    int fInicializaLicenseInfo(byte aSistema);

    int fInicializaSDK();

    void fInicioSesionSDK(string aUsuario, string aContrasenia);

    void fInicioSesionSDKCONTPAQi(string aUsuario, string aContrasenia);

    int fInsertaAgente();

    int fInsertaAlmacen();

    int fInsertaCteProv();

    int fInsertaDatoAddendaDocto(int aIdAddenda, int aIdCatalogo, int aNumCampo, string aDato);

    int fInsertaDatoAddendaMovto(int aIdAddenda, int aIdCatalogo, int aNumCampo, string aDato);

    int fInsertaDatoCompEducativo(int aIdServicio, int aNumCampo, string aDato);

    int fInsertaDireccion();

    int fInsertaProducto();

    int fInsertarDocumento();

    int fInsertarMovimiento();

    int fInsertaUnidad();

    int fInsertaValorClasif();

    int fLeeDatoAgente(string aCampo, StringBuilder aValor, int aLen);

    int fLeeDatoAlmacen(string aCampo, StringBuilder aValor, int aLen);

    int fLeeDatoCFDI(StringBuilder aValor, int aDato);

    int fLeeDatoClasificacion(string aCampo, StringBuilder aValor, int aLen);

    int fLeeDatoConceptoDocto(string aCampo, StringBuilder aValor, int aLen);

    int fLeeDatoCteProv(string aCampo, StringBuilder aValor, int aLen);

    int fLeeDatoDireccion(string aCampo, StringBuilder aValor, int aLen);

    int fLeeDatoDocumento(string aCampo, StringBuilder aValor, int aLongitud);

    int fLeeDatoMovimiento(string aCampo, StringBuilder aValor, int aLen);

    int fLeeDatoMovtoContable(string aCampo, StringBuilder aValor, int aLen);

    int fLeeDatoParametros(string aCampo, StringBuilder aValor, int aLen);

    int fLeeDatoProducto(string aCampo, StringBuilder aValor, int aLen);

    int fLeeDatoUnidad(string aCampo, StringBuilder aValor, int aLen);

    int fLeeDatoValorClasif(string aCampo, StringBuilder aValor, int aLen);

    int fLlenaRegistroCteProv(ref tCteProv astCteProv, int aEsAlta);

    int fLlenaRegistroDireccion(ref tDireccion astDireccion, int aEsAlta);

    int fLlenaRegistroProducto(ref tProducto astProducto, int aEsAlta);

    int fLlenaRegistroUnidad(ref tUnidad astUnidad);

    int fLlenaRegistroValorClasif(ref tValorClasificacion astValorClasif);

    int fModificaCostoEntrada(string aIdMovimiento, string aCostoEntrada);

    int fModificaCuentaBancariaCliente(string aCuentaBancaria, string aNombreCuenta, string aNombreMoneda, string aClaveBanco,
        string aRfcBanco, string aClabe, string aNombreExtranjero, string aCodigoCliente);

    int fModificaCuentaBancariaEmpresa(string aCuentaBancaria, string aNombreCuenta, string aNombreMoneda, string aClaveBanco,
        string aRfcBanco, string aClabe, string aNombreExtranjero);

    int fObtenCeryKey(int aIdFirmarl, string aRutaKey, string aRutaCer);

    int fObtieneDatosCFDI(string atPtrPassword);

    int fObtieneLicencia(StringBuilder aCodAcvtiva, StringBuilder aCodSitio, StringBuilder aSerie, StringBuilder aTagVersion);

    int fObtienePassProxy(StringBuilder aPassProxy);

    int fObtieneUnidadesPendientes(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen, StringBuilder aUnidades);

    int fObtieneUnidadesPendientesCarac(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen, string aValorCaracteristica1,
        string aValorCaracteristica2, string aValorCaracteristica3, StringBuilder aUnidades);

    int fPosAnteriorAgente();

    int fPosAnteriorAlmacen();

    int fPosAnteriorClasificacion();

    int fPosAnteriorConceptoDocto();

    int fPosAnteriorCteProv();

    int fPosAnteriorDireccion();

    int fPosAnteriorDocumento();

    int fPosAnteriorMovimiento();

    int fPosAnteriorProducto();

    int fPosAnteriorUnidad();

    int fPosAnteriorValorClasif();

    int fPosBOF();

    int fPosBOFAgente();

    int fPosBOFAlmacen();

    int fPosBOFClasificacion();

    int fPosBOFConceptoDocto();

    int fPosBOFCteProv();

    int fPosBOFDireccion();

    int fPosBOFProducto();

    int fPosBOFUnidad();

    int fPosBOFValorClasif();

    int fPosEOF();

    int fPosEOFAgente();

    int fPosEOFAlmacen();

    int fPosEOFClasificacion();

    int fPosEOFConceptoDocto();

    int fPosEOFCteProv();

    int fPosEOFDireccion();

    int fPosEOFMovtoContable();

    int fPosEOFProducto();

    int fPosEOFUnidad();

    int fPosEOFValorClasif();

    int fPosMovimientoBOF();

    int fPosMovimientoEOF();

    int fPosPrimerAgente();

    int fPosPrimerAlmacen();

    int fPosPrimerClasificacion();

    int fPosPrimerConceptoDocto();

    int fPosPrimerCteProv();

    int fPosPrimerDireccion();

    int fPosPrimerDocumento();

    int fPosPrimerEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa);

    int fPosPrimerMovimiento();

    int fPosPrimerMovtoContable();

    int fPosPrimerProducto();

    int fPosPrimerUnidad();

    int fPosPrimerValorClasif();

    int fPosSiguienteAgente();

    int fPosSiguienteAlmacen();

    int fPosSiguienteClasificacion();

    int fPosSiguienteConceptoDocto();

    int fPosSiguienteCteProv();

    int fPosSiguienteDireccion();

    int fPosSiguienteDocumento();

    int fPosSiguienteEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa);

    int fPosSiguienteMovimiento();

    int fPosSiguienteMovtoContable();

    int fPosSiguienteProducto();

    int fPosSiguienteUnidad();

    int fPosSiguienteValorClasif();

    int fPosUltimaConceptoDocto();

    int fPosUltimaDireccion();

    int fPosUltimoAgente();

    int fPosUltimoAlmacen();

    int fPosUltimoClasificacion();

    int fPosUltimoCteProv();

    int fPosUltimoDocumento();

    int fPosUltimoMovimiento();

    int fPosUltimoProducto();

    int fPosUltimoUnidad();

    int fPosUltimoValorClasif();

    int fProyectoEmpresaDoctos(string aCodigoProyecto);

    int fRecosteoProducto(string aCodigoProducto, int aEjercicio, int aPeriodo, string aCodigoClasificacion1, string aCodigoClasificacion2,
        string aCodigoClasificacion3, string aCodigoClasificacion4, string aCodigoClasificacion5, string aCodigoClasificacion6,
        string aNombreBitacora, int aSobreEscribirBitacora, int aEsCalculoArimetico);

    int fRecuperarRelacionesCFDIs(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion, StringBuilder aUUIDs,
        string aRutaNombreArchivoInfo);

    int fRecuperaTipoProducto(ref bool aUnidades, ref bool aSerie, ref bool aLote, ref bool aPedimento, ref bool aCaracteristicas);

    int fRegresaCostoCapa(string aCodigoProducto, string aCodigoAlmacen, double aUnidades, StringBuilder aImporteCosto);

    int fRegresaCostoEstandar(string aCodigoProducto, StringBuilder aCostoEstandar);

    int fRegresaCostoPromedio(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        StringBuilder aCostoPromedio);

    int fRegresaExistencia(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, ref double aExistencia);

    int fRegresaExistenciaCaracteristicas(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, ref double aExistencia);

    int fRegresaExistenciaLotePedimento(string aCodigoProducto, string aCodigoAlmacen, string aPedimento, string aLote,
        ref double aExistencia);

    int fRegresaIVACargo(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero, double aNetoTasaExcenta,
        double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas);

    int fRegresaIVACargo_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11,
        double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16,
        double aIVATasa11, double aIVAOtrasTasas);

    int fRegresaIVACargoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11,
        double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16,
        double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI);

    int fRegresaIVAPago(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero, double aNetoTasaExcenta,
        double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas);

    int fRegresaIVAPago_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11,
        double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16,
        double aIVATasa11, double aIVAOtrasTasas);

    int fRegresaIVAPagoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11,
        double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16,
        double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI);

    int fRegresaPrecioVenta(string aCodigoConcepto, string aCodigoCliente, string aCodigoProducto, StringBuilder aPrecioVenta);

    int fRegresaUltimoCosto(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        StringBuilder aUltimoCosto);

    int fRegresPorcentajeImpuesto(int aIdConceptoDocumento, int aIdClienteProveedor, int aIdProducto, ref double aPorcentajeImpuesto);

    int fSaldarDocumento(ref tLlaveDoc aDoctoaPagar, ref tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha);

    int fSaldarDocumento_Param(string aCodConcepto_Pagar, string aSerie_Pagar, double aFolio_Pagar, string aCodConcepto_Pago,
        string aSerie_Pago, double aFolio_Pago, double aImporte, int aIdMoneda, string aFecha);

    int fSaldarDocumentoCheqPAQ(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha,
        double aTipoCambioCheqPAQ);

    int fSetDatoAgente(string aCampo, string aValor);

    int fSetDatoAlmacen(string aCampo, string aValor);

    int fSetDatoClasificacion(string aCampo, string aValor);

    int fSetDatoConceptoDocto(string aCampo, string aValor);

    int fSetDatoCteProv(string aCampo, string aValor);

    int fSetDatoDireccion(string aCampo, string aValor);

    int fSetDatoDocumento(string aCampo, string aValor);

    int fSetDatoMovimiento(string aCampo, string aValor);

    int fSetDatoMovtoContable(string aCampo, string aValor);

    int fSetDatoParametros(string aCampo, StringBuilder aValor);

    int fSetDatoProducto(string aCampo, string aValor);

    int fSetDatoUnidad(string aCampo, string aValor);

    int fSetDatoValorClasif(string aCampo, string aValor);

    int fSetDescripcionProducto(string aCampo, string aValor);

    int fSetFiltroDocumento(string aFechaInicio, string aFechaFin, string aCodigoConcepto, string aCodigoCteProv);

    int fSetFiltroMovimiento(int aIdDocumento);

    void fSetModoImportacion(bool aImportacion);

    int fSetNombrePAQ(string aSistema);

    int fSiguienteFolio(string aCodigoConcepto, StringBuilder aSerie, ref double aFolio);

    void fTerminaSDK();

    int fTimbraComplementoPagoXML(string aRutaXML, string aCodConcepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado,
        string aPass, string aRutaFormato);

    int fTimbraComplementoXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado,
        string aPass, string aRutaFormato, int aComplemento);

    int fTimbraNominaXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado, string aPass,
        string aRutaFormato);

    int fTimbraXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado, string aPass,
        string aRutaFormato);

    int InicializarSDK();

    int InicializarSDK(string usuario, string password);

    int InicializarSDK(string usuario, string password, string usuarioContabilidad, string passwordContabilidad);

    string LeeDatoAgente(string dato, int longitud = 512);

    string LeeDatoAlmacen(string dato, int longitud = 512);

    string LeeDatoCfdi(int dato, int longitud = 3000);

    string LeeDatoClasificacion(string dato, int longitud = 512);

    string LeeDatoClienteProveedor(string dato, int longitud = 512);

    string LeeDatoConcepto(string dato, int longitud = 512);

    string LeeDatoDireccion(string dato, int longitud = 512);

    string LeeDatoDocumento(string dato, int longitud = 512);

    string LeeDatoMovimiento(string dato, int longitud = 512);

    string LeeDatoParametros(string dato, int longitud = 512);

    string LeeDatoProducto(string dato, int longitud = 512);

    string LeeDatoUnidad(string dato, int longitud = 512);

    string LeeDatoValorClasificacion(string dato, int longitud = 512);

    string LeeMensajeError(int numeroError);
    string NombreLlaveRegistro { get; }

    string NombrePaq { get; }
}

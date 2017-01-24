﻿using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces
{
    public interface ISistemasComercialesSdk
    {
        int fAbreEmpresa(string aDirectorioEmpresa);

        int fActivarPrecioCompra(int aActivar);

        int fActualizaClasificacion(int aClasificacionDe, int aNumClasificacion, string aNombreClasificacion);

        int fActualizaCteProv(StringBuilder aCodigoCteProv, tCteProv astCteProv);

        int fActualizaDireccion(ref tDireccion astDireccion);

        int fActualizaProducto(ref int aCodigoProducto, tProducto astProducto);

        int fActualizaUnidad(string aNombreUnidad, ref tUnidad astUnidad);

        int fActualizaValorClasif(string aCodigoValorClasif, ref tValorClasificacion astValorClasif);

        int fAfectaDocto(ref tLlaveDoc aLlaveDocto, bool aAfecta);

        int fAfectaDocto_Param(string aCodConcepto, string aSerie, double aFolio, bool aAfecta);

        int fAfectaSerie(int aIdMovto, string aNumeroSerie);

        int fAltaCteProv(StringBuilder aIdCteProv, tCteProv astCteProv);

        int fAltaDireccion(ref int aIdDireccion, ref tDireccion astDireccion);

        int fAltaDoctoAjusteIESPSCteProv(string aCodigoClienteProveedor, int aEsCliente, string aFechaDocto, int aIdMoneda, double aTipoCambio, double aImporteIVA, double aTasaIVA, double aImporteIESPS, double aTasaIESPS, int aIdFacturaBase, string aMetodo, string aLugar, ref int aIdDoctoGenerado);

        int fAltaDoctoAjusteIVAClienteProveedor(string aCodigoClienteProveedor, int aEsCliente, int aAbsorberAjusteIVA, string aFechaDocto, int aIdMoneda, double aTipoCambio, double aImporteIVA, double aTasaIVA, int aIdFacturaBase, string aMetodo, string aLugar, ref int aIdDoctoGenerado);

        int fAltaDocumento(ref int aIdDocumento, ref tDocumento aDocumento);

        int fAltaDocumentoCargoAbono(ref tDocumento aDocumento);

        int fAltaDocumentoCargoAbonoExtras(ref tDocumento aDocumento, string aTextoExtra1, string aTextoExtra2, string aTextoExtra3, string aFechaExtra, double aImporteExtra1, double aImporteExtra2, double aImporteExtra3, double aImporteExtra4);

        int fAltaMovimiento(int aIdDocumento, ref int aIdMovimiento, ref tMovimiento astMovimiento);

        int fAltaMovimientoCaracteristicas(int aIdMovimiento, int aIdMovtoCaracteristicas, tCaracteristicas aCaracteristicas);

        int fAltaMovimientoCaracteristicas_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidades, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3);

        int fAltaMovimientoCDesct(int aIdDocumento, int aIdMovimiento, tMovimientoDesc astMovimiento);

        int fAltaMovimientoEx(ref int aIdMovimiento, tTipoProducto aTipoProducto);

        int fAltaMovimientoSeriesCapas(int aIdMovimiento, ref tSeriesCapas aSeriesCapas);

        int fAltaMovimientoSeriesCapas_Param(string aIdMovimiento, string aUnidades, string aTipoCambio, string aSeries, string aPedimento, string aAgencia, string aFechaPedimento, string aNumeroLote, string aFechaFabricacion, string aFechaCaducidad);

        int fAltaMovtoCaracteristicasUnidades(int aIdMovimiento, int aIdMovtoCaracteristicas, tCaracteristicas aCaracteristicasUnidades);

        int fAltaMovtoCaracteristicasUnidades_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidad, string aUnidades, string aUnidadesNC, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3);

        int fAltaProducto(ref int aIdProducto, tProducto astProducto);

        int fAltaUnidad(ref int aIdUnidad, ref tUnidad astUnidad);

        int fAltaValorClasif(ref int aIdValorClasif, ref tValorClasificacion astValorClasif);

        int fBorraCteProv();

        int fBorraDocumento();

        int fBorraDocumento_CW();

        int fBorraMovimiento(int aIdDocumento, int aIdMovimiento);

        int fBorraProducto();

        int fBorrarAsociacion(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago);

        int fBorrarAsociacion_Param(string aCodConcepto_Pagar, string aSerie_Pagar, string aFolio_Pagar, string aCodConcepto_Pago, string aSerie_Pago, string aFolio_Pago);

        int fBorraUnidad();

        int fBorraValorClasif();

        int fBuscaAgente(string aCodigoAgente);

        int fBuscaAlmacen(string aCodigoAlmacen);

        int fBuscaClasificacion(int aClasificacionDe, int aNumClasificacion);

        int fBuscaConceptoDocto(string aCodConcepto);

        int fBuscaCteProv(string aCodCteProv);

        int fBuscaDireccionCteProv(string aCodCteProv, int aTipoDireccion);

        int fBuscaDireccionDocumento(int aIdDocumento, int aTipoDireccion);

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

        int fCancelaDocumento();

        int fCancelaDocumento_CW();

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

        void fCierraEmpresa();

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

        int fEliminarProducto();

        int fEliminarUnidad(string aNombreUnidad);

        int fEliminarValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodigoValorClasif);

        int fEmitirDocumento(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, StringBuilder aPassword, StringBuilder aArchivoAdicional);

        int fEntregEnDiscoXML(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, int aFormato, StringBuilder aFormatoAmig);

        void fError(int aNumError, StringBuilder aMensaje, int aLen);

        int fGetCantidadParcialidades(StringBuilder atPtrPassword, StringBuilder aCantidadParcialidades);

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

        int fInformacionCliente(StringBuilder aCodigo, ref int aPermiteCredito, ref double aLimiteCredito, ref int aLimiteDoctosVencidos, ref int aPermiteExcederCredito, StringBuilder aFecha, ref double aSaldo, ref double aSaldoPendiente, ref int aDoctosVencidos);

        int fInicializaLicenseInfo(char aSistema);

        int fInicializaSDK();

        void fInicioSesionSDK(string aUsuario, string aContrasenia);

        int fInsertaAgente();

        int fInsertaAlmacen();

        int fInsertaCteProv();

        int fInsertaDatoAddendaDocto(int aIdAddenda, int aIdCatalogo, int aNumCampo, StringBuilder aDato);

        int fInsertaDatoAddendaMovto(int aIdAddenda, int aIdCatalogo, int aNumCampo, StringBuilder aDato);

        int fInsertaDatoCompEducativo(int aIdServicio, int aNumCampo, StringBuilder aDato);

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

        int fLlenaRegistroCteProv(tCteProv astCteProv, int aEsAlta);

        int fLlenaRegistroDireccion(ref tDireccion astDireccion, int aEsAlta);

        int fLlenaRegistroProducto(tProducto astProducto, int aEsAlta);

        int fLlenaRegistroUnidad(ref tUnidad astUnidad);

        int fLlenaRegistroValorClasif(ref tValorClasificacion astValorClasif);

        int fModificaCostoEntrada(string aIdMovimiento, string aCostoEntrada);

        int fObtenCeryKey(int aIdFirmarl, string aRutaKey, string aRutaCer);

        int fObtieneDatosCFDI(StringBuilder atPtrPassword);

        int fObtieneLicencia(StringBuilder aCodAcvtiva, StringBuilder aCodSitio, StringBuilder aSerie, StringBuilder aTagVersion);

        int fObtienePassProxy(StringBuilder aPassProxy);

        int fObtieneUnidadesPendientes(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen, StringBuilder aUnidades);

        int fObtieneUnidadesPendientesCarac(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, StringBuilder aUnidades);

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

        int fRecosteoProducto(string aCodigoProducto, int aEjercicio, int aPeriodo, string aCodigoClasificacion1, string aCodigoClasificacion2, string aCodigoClasificacion3, string aCodigoClasificacion4, string aCodigoClasificacion5, string aCodigoClasificacion6, string aNombreBitacora, int aSobreEscribirBitacora, int aEsCalculoArimetico);

        int fRecuperaTipoProducto(ref bool aUnidades, ref bool aSerie, ref bool aLote, ref bool aPedimento, ref bool aCaracteristicas);

        int fRegresaCostoCapa(string aCodigoProducto, string aCodigoAlmacen, double aUnidades, StringBuilder aImporteCosto);

        int fRegresaCostoEstandar(string aCodigoProducto, StringBuilder aCostoEstandar);

        int fRegresaCostoPromedio(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, StringBuilder aCostoPromedio);

        int fRegresaExistencia(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, ref double aExistencia);

        int fRegresaExistenciaCaracteristicas(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, ref double aExistencia);

        int fRegresaIVACargo(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas);

        int fRegresaIVACargoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI);

        int fRegresaIVACargo_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas);

        int fRegresaIVAPago(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas);

        int fRegresaIVAPagoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI);

        int fRegresaIVAPago_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas);

        int fRegresaPrecioVenta(string aCodigoConcepto, string aCodigoCliente, string aCodigoProducto, StringBuilder aPrecioVenta);

        int fRegresaUltimoCosto(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, StringBuilder aUltimoCosto);

        int fRegresPorcentajeImpuesto(int aIdConceptoDocumento, int aIdClienteProveedor, int aIdProducto, ref double aPorcentajeImpuesto);

        int fSaldarDocumento(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha);

        int fSaldarDocumentoCheqPAQ(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha, double aTipoCambioCheqPAQ);

        int fSaldarDocumento_Param(string aCodConcepto_Pagar, string aSerie_Pagar, string aFolio_Pagar, string aCodConcepto_Pago, string aSerie_Pago, string aFolio_Pago, double aImporte, int aIdMoneda, string aFecha);

        int fSetDatoAgente(string aCampo, string aValor);

        int fSetDatoAlmacen(string aCampo, string aValor);

        int fSetDatoClasificacion(string aCampo, string aValor);

        int fSetDatoConceptoDocto(StringBuilder aCampo, StringBuilder aValor);

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

        int fTimbraComplementoXML(string aRutaXML, string aCodCOncepto, string aUUID, string aRutaDDA, string aRutaResultado, string aPass, string aRutaFormato, int aComplemento);

        int fTimbraNominaXML(StringBuilder aRutaXML, StringBuilder aCodCOncepto, StringBuilder aUUID, StringBuilder aRutaDDA, StringBuilder aRutaResultado, StringBuilder aPass, StringBuilder aRutaFormato);

        int fTimbraXML(StringBuilder aRutaXML, StringBuilder aCodCOncepto, StringBuilder aUUID, StringBuilder aRutaDDA, StringBuilder aRutaResultado, StringBuilder aPass, StringBuilder aRutaFormato);
    }
}
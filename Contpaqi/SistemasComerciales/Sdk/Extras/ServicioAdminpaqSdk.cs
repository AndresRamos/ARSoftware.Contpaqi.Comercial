using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras
{
    public class ServicioAdminpaqSdk : ISistemasComercialesSdk
    {
        #region Generales

        public int fInicializaSDK()
        {
            return AdminpaqSdk.fInicializaSDK();
        }

        public void fTerminaSDK()
        {
            AdminpaqSdk.fTerminaSDK();
        }

        public int fSetNombrePAQ(string aSistema)
        {
            return AdminpaqSdk.fSetNombrePAQ(aSistema);
        }

        public void fError(int aNumError, StringBuilder aMensaje, int aLen)
        {
            AdminpaqSdk.fError(aNumError, aMensaje, aLen);
        }

        public void fInicioSesionSDK(string aUsuario, string aContrasenia)
        {
            AdminpaqSdk.fInicioSesionSDK(aUsuario, aContrasenia);
        }

        public void fSetModoImportacion(bool aImportacion)
        {
            AdminpaqSdk.fSetModoImportacion(aImportacion);
        }

        #endregion

        #region Empresas

        public int fPosPrimerEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa)
        {
            return AdminpaqSdk.fPosPrimerEmpresa(ref aIdEmpresa, aNombreEmpresa, aDirectorioEmpresa);
        }

        public int fPosSiguienteEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa)
        {
            return AdminpaqSdk.fPosSiguienteEmpresa(ref aIdEmpresa, aNombreEmpresa, aDirectorioEmpresa);
        }

        public int fAbreEmpresa(string aDirectorioEmpresa)
        {
            return AdminpaqSdk.fAbreEmpresa(aDirectorioEmpresa);
        }

        public void fCierraEmpresa()
        {
            AdminpaqSdk.fCierraEmpresa();
        }

        #endregion

        #region Documentos

        public int fInsertarDocumento()
        {
            return AdminpaqSdk.fInsertarDocumento();
        }

        public int fEditarDocumento()
        {
            return AdminpaqSdk.fEditarDocumento();
        }

        public int fGuardaDocumento()
        {
            return AdminpaqSdk.fGuardaDocumento();
        }

        public int fCancelarModificacionDocumento()
        {
            return AdminpaqSdk.fCancelarModificacionDocumento();
        }

        public int fBorraDocumento()
        {
            return AdminpaqSdk.fBorraDocumento();
        }

        public int fCancelaDocumento()
        {
            return AdminpaqSdk.fCancelaDocumento();
        }

        public int fBorraDocumento_CW()
        {
            return AdminpaqSdk.fBorraDocumento_CW();
        }

        public int fCancelaDocumento_CW()
        {
            return AdminpaqSdk.fCancelaDocumento_CW();
        }

        public int fAfectaDocto_Param(string aCodConcepto, string aSerie, double aFolio, bool aAfecta)
        {
            return AdminpaqSdk.fAfectaDocto_Param(aCodConcepto, aSerie, aFolio, aAfecta);
        }

        public int fSaldarDocumento_Param(string aCodConcepto_Pagar, string aSerie_Pagar, string aFolio_Pagar, string aCodConcepto_Pago, string aSerie_Pago, string aFolio_Pago, double aImporte, int aIdMoneda, string aFecha)
        {
            return AdminpaqSdk.fSaldarDocumento_Param(aCodConcepto_Pagar, aSerie_Pagar, aFolio_Pagar, aCodConcepto_Pago, aSerie_Pago, aFolio_Pago, aImporte, aIdMoneda, aFecha);
        }

        public int fBorrarAsociacion_Param(string aCodConcepto_Pagar, string aSerie_Pagar, string aFolio_Pagar, string aCodConcepto_Pago, string aSerie_Pago, string aFolio_Pago)
        {
            return AdminpaqSdk.fBorrarAsociacion_Param(aCodConcepto_Pagar, aSerie_Pagar, aFolio_Pagar, aCodConcepto_Pago, aSerie_Pago, aFolio_Pago);
        }

        public int fEditarDocumentoCheqpaq()
        {
            return AdminpaqSdk.fEditarDocumentoCheqpaq();
        }

        public int fSetDatoDocumento(string aCampo, string aValor)
        {
            return AdminpaqSdk.fSetDatoDocumento(aCampo, aValor);
        }

        public int fLeeDatoDocumento(string aCampo, StringBuilder aValor, int aLongitud)
        {
            return AdminpaqSdk.fLeeDatoDocumento(aCampo, aValor, aLongitud);
        }

        public int fSiguienteFolio(string aCodigoConcepto, StringBuilder aSerie, ref double aFolio)
        {
            return AdminpaqSdk.fSiguienteFolio(aCodigoConcepto, aSerie, ref aFolio);
        }

        public int fSetFiltroDocumento(string aFechaInicio, string aFechaFin, string aCodigoConcepto, string aCodigoCteProv)
        {
            return AdminpaqSdk.fSetFiltroDocumento(aFechaInicio, aFechaFin, aCodigoConcepto, aCodigoCteProv);
        }

        public int fCancelaFiltroDocumento()
        {
            return AdminpaqSdk.fCancelaFiltroDocumento();
        }

        public int fDocumentoImpreso(ref bool aImpreso)
        {
            return AdminpaqSdk.fDocumentoImpreso(ref aImpreso);
        }

        public int fDocumentoBloqueado(ref int aImpreso)
        {
            return AdminpaqSdk.fDocumentoBloqueado(ref aImpreso);
        }

        public int fBuscarDocumento(string aCodConcepto, string aSerie, string aFolio)
        {
            return AdminpaqSdk.fBuscarDocumento(aCodConcepto, aSerie, aFolio);
        }

        public int fBuscarIdDocumento(int aIdDocumento)
        {
            return AdminpaqSdk.fBuscarIdDocumento(aIdDocumento);
        }

        public int fPosPrimerDocumento()
        {
            return AdminpaqSdk.fPosPrimerDocumento();
        }

        public int fPosUltimoDocumento()
        {
            return AdminpaqSdk.fPosUltimoDocumento();
        }

        public int fPosSiguienteDocumento()
        {
            return AdminpaqSdk.fPosSiguienteDocumento();
        }

        public int fPosAnteriorDocumento()
        {
            return AdminpaqSdk.fPosAnteriorDocumento();
        }

        public int fPosBOF()
        {
            return fPosBOF();
        }

        public int fPosEOF()
        {
            return AdminpaqSdk.fPosEOF();
        }

        public int fAltaDocumento(ref int aIdDocumento, ref tDocumento aDocumento)
        {
            return AdminpaqSdk.fAltaDocumento(ref aIdDocumento, ref aDocumento);
        }

        public int fAltaDocumentoCargoAbono(tDocumento aDocumento)
        {
            return AdminpaqSdk.fAltaDocumentoCargoAbono(aDocumento);
        }

        public int fAltaDocumentoCargoAbonoExtras(tDocumento aDocumento, string aTextoExtra1, string aTextoExtra2, string aTextoExtra3, string aFechaExtra, double aImporteExtra1, double aImporteExtra2, double aImporteExtra3, double aImporteExtra4)
        {
            return AdminpaqSdk.fAltaDocumentoCargoAbonoExtras(aDocumento, aTextoExtra1, aTextoExtra2, aTextoExtra3, aFechaExtra, aImporteExtra1, aImporteExtra2, aImporteExtra3, aImporteExtra4);
        }

        public int fAfectaDocto(ref tLlaveDoc aLlaveDocto, bool aAfecta)
        {
            return AdminpaqSdk.fAfectaDocto(ref aLlaveDocto, aAfecta);
        }

        public int fSaldarDocumento(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha)
        {
            return AdminpaqSdk.fSaldarDocumento(aDoctoaPagar, aDoctoPago, aImporte, aIdMoneda, aFecha);
        }

        public int fSaldarDocumentoCheqPAQ(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha, double aTipoCambioCheqPAQ)
        {
            return AdminpaqSdk.fSaldarDocumentoCheqPAQ(aDoctoaPagar, aDoctoPago, aImporte, aIdMoneda, aFecha, aTipoCambioCheqPAQ);
        }

        public int fBorrarAsociacion(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago)
        {
            return AdminpaqSdk.fBorrarAsociacion(aDoctoaPagar, aDoctoPago);
        }

        public int fRegresaIVACargo(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas)
        {
            return AdminpaqSdk.fRegresaIVACargo(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVAOtrasTasas);
        }

        public int fRegresaIVAPago(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas)
        {
            return AdminpaqSdk.fRegresaIVAPago(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVAOtrasTasas);
        }

        public int fRegresaIVACargo_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas)
        {
            return AdminpaqSdk.fRegresaIVACargo_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas);
        }

        public int fRegresaIVAPago_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas)
        {
            return AdminpaqSdk.fRegresaIVAPago_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas);
        }

        public int fRegresaIVACargoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI)
        {
            return AdminpaqSdk.fRegresaIVACargoRet_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas, aRetIVA, aRetI);
        }

        public int fRegresaIVAPagoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI)
        {
            return AdminpaqSdk.fRegresaIVAPagoRet_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas, aRetIVA, aRetI);
        }

        public int fGetTamSelloDigitalYCadena(StringBuilder atPtrPassword, ref int aEspSelloDig, ref int aEspCadOrig)
        {
            return AdminpaqSdk.fGetTamSelloDigitalYCadena(atPtrPassword, ref aEspSelloDig, ref aEspCadOrig);
        }

        public int fGetSelloDigitalYCadena(StringBuilder atPtrPassword, StringBuilder atPtrSelloDigital, StringBuilder atPtrCadenaOriginal)
        {
            return AdminpaqSdk.fGetSelloDigitalYCadena(atPtrPassword, atPtrSelloDigital, atPtrCadenaOriginal);
        }

        public int fInicializaLicenseInfo(char aSistema)
        {
            return AdminpaqSdk.fInicializaLicenseInfo(aSistema);
        }

        public int fEmitirDocumento(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, StringBuilder aPassword, StringBuilder aArchivoAdicional)
        {
            return AdminpaqSdk.fEmitirDocumento(aCodConcepto, aSerie, aFolio, aPassword, aArchivoAdicional);
        }

        public int fDocumentoUUID(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, StringBuilder atPtrCFDIUUID)
        {
            return AdminpaqSdk.fDocumentoUUID(aCodConcepto, aSerie, aFolio, atPtrCFDIUUID);
        }

        public int fGetSerieCertificado(StringBuilder atPtrPassword, StringBuilder aSerieCertificado)
        {
            return AdminpaqSdk.fGetSerieCertificado(atPtrPassword, aSerieCertificado);
        }

        public int fGetNumParcialidades(StringBuilder atPtrPassword, StringBuilder aNumParcialidades)
        {
            return AdminpaqSdk.fGetNumParcialidades(atPtrPassword, aNumParcialidades);
        }

        public int fGetCantidadParcialidades(StringBuilder atPtrPassword, StringBuilder aCantidadParcialidades)
        {
            return AdminpaqSdk.fGetCantidadParcialidades(atPtrPassword, aCantidadParcialidades);
        }

        public int fActivarPrecioCompra(int aActivar)
        {
            return AdminpaqSdk.fActivarPrecioCompra(aActivar);
        }

        public int fDocumentoDevuelto(ref int aDevuelto)
        {
            return AdminpaqSdk.fDocumentoDevuelto(ref aDevuelto);
        }

        public int fEntregEnDiscoXML(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, int aFormato, StringBuilder aFormatoAmig)
        {
            return AdminpaqSdk.fEntregEnDiscoXML(aCodConcepto, aSerie, aFolio, aFormato, aFormatoAmig);
        }

        public int fObtieneDatosCFDI(StringBuilder atPtrPassword)
        {
            return AdminpaqSdk.fObtieneDatosCFDI(atPtrPassword);
        }

        public int fLeeDatoCFDI(StringBuilder aValor, int aDato)
        {
            return AdminpaqSdk.fLeeDatoCFDI(aValor, aDato);
        }

        public int fBuscaDocumento(ref tLlaveDoc aLlaveDocto)
        {
            return AdminpaqSdk.fBuscaDocumento(ref aLlaveDocto);
        }

        #endregion

        #region Movimientos


        public int fInsertarMovimiento()
        {
            return AdminpaqSdk.fInsertarMovimiento();
        }

        public int fEditarMovimiento()
        {
            return AdminpaqSdk.fEditarMovimiento();
        }

        public int fBorraMovimiento(int aIdDocumento, int aIdMovimiento)
        {
            return AdminpaqSdk.fBorraMovimiento(aIdDocumento, aIdMovimiento);
        }

        public int fDesbloqueaDocumento()
        {
            return AdminpaqSdk.fDesbloqueaDocumento();
        }

        public int fGuardaMovimiento()
        {
            return AdminpaqSdk.fGuardaMovimiento();
        }

        public int fCancelaCambiosMovimiento()
        {
            return AdminpaqSdk.fCancelaCambiosMovimiento();
        }

        public int fAltaMovimientoCaracteristicas_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidades, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3)
        {
            return AdminpaqSdk.fAltaMovimientoCaracteristicas_Param(aIdMovimiento, aIdMovtoCaracteristicas, aUnidades, aValorCaracteristica1, aValorCaracteristica2, aValorCaracteristica3);
        }

        public int fAltaMovtoCaracteristicasUnidades_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidad, string aUnidades, string aUnidadesNC, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3)
        {
            return AdminpaqSdk.fAltaMovtoCaracteristicasUnidades_Param(aIdMovimiento, aIdMovtoCaracteristicas, aUnidad, aUnidades, aUnidadesNC, aValorCaracteristica1, aValorCaracteristica2, aValorCaracteristica3);
        }

        public int fAltaMovimientoSeriesCapas_Param(string aIdMovimiento, string aUnidades, string aTipoCambio, string aSeries, string aPedimento, string aAgencia, string aFechaPedimento, string aNumeroLote, string aFechaFabricacion, string aFechaCaducidad)
        {
            return AdminpaqSdk.fAltaMovimientoSeriesCapas_Param(aIdMovimiento, aUnidades, aTipoCambio, aSeries, aPedimento, aAgencia, aFechaPedimento, aNumeroLote, aFechaFabricacion, aFechaCaducidad);
        }

        public int fCalculaMovtoSerieCapa(int aIdMovimiento)
        {
            return AdminpaqSdk.fCalculaMovtoSerieCapa(aIdMovimiento);
        }

        public int fObtieneUnidadesPendientes(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen, StringBuilder aUnidades)
        {
            return AdminpaqSdk.fObtieneUnidadesPendientes(aConceptoDocto, aCodigoProducto, aCodigoAlmacen, aUnidades);
        }

        public int fObtieneUnidadesPendientesCarac(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, StringBuilder aUnidades)
        {
            return AdminpaqSdk.fObtieneUnidadesPendientesCarac(aConceptoDocto, aCodigoProducto, aCodigoAlmacen, aValorCaracteristica1, aValorCaracteristica2, aValorCaracteristica3, aUnidades);
        }

        public int fModificaCostoEntrada(string aIdMovimiento, string aCostoEntrada)
        {
            return AdminpaqSdk.fModificaCostoEntrada(aIdMovimiento, aCostoEntrada);
        }

        public int fSetDatoMovimiento(string aCampo, string aValor)
        {
            return AdminpaqSdk.fSetDatoMovimiento(aCampo, aValor);
        }

        public int fLeeDatoMovimiento(string aCampo, StringBuilder aValor, int aLen)
        {
            return AdminpaqSdk.fLeeDatoMovimiento(aCampo, aValor, aLen);
        }

        public int fAfectaSerie(int aIdMovto, string aNumeroSerie)
        {
            return AdminpaqSdk.fAfectaSerie(aIdMovto, aNumeroSerie);
        }

        public int fSetFiltroMovimiento(int aIdDocumento)
        {
            return AdminpaqSdk.fSetFiltroMovimiento(aIdDocumento);
        }

        public int fCancelaFiltroMovimiento()
        {
            return AdminpaqSdk.fCancelaFiltroMovimiento();
        }

        public int fBuscarIdMovimiento(int aIdMovimiento)
        {
            return AdminpaqSdk.fBuscarIdMovimiento(aIdMovimiento);
        }

        public int fPosPrimerMovimiento()
        {
            return AdminpaqSdk.fPosPrimerMovimiento();
        }

        public int fPosUltimoMovimiento()
        {
            return AdminpaqSdk.fPosPrimerMovimiento();
        }

        public int fPosSiguienteMovimiento()
        {
            return AdminpaqSdk.fPosSiguienteMovimiento();
        }

        public int fPosAnteriorMovimiento()
        {
            return AdminpaqSdk.fPosAnteriorMovimiento();
        }

        public int fPosMovimientoBOF()
        {
            return AdminpaqSdk.fPosMovimientoBOF();
        }

        public int fPosMovimientoEOF()
        {
            return AdminpaqSdk.fPosMovimientoEOF();
        }

        public int fAltaDoctoAjusteIVAClienteProveedor(string aCodigoClienteProveedor, int aEsCliente, int aAbsorberAjusteIVA, string aFechaDocto, int aIdMoneda, double aTipoCambio, double aImporteIVA, double aTasaIVA, int aIdFacturaBase, string aMetodo, string aLugar, ref int aIdDoctoGenerado)
        {
            return AdminpaqSdk.fAltaDoctoAjusteIVAClienteProveedor(aCodigoClienteProveedor, aEsCliente, aAbsorberAjusteIVA, aFechaDocto, aIdMoneda, aTipoCambio, aImporteIVA, aTasaIVA, aIdFacturaBase, aMetodo, aLugar, ref aIdDoctoGenerado);
        }

        public int fAltaDoctoAjusteIESPSCteProv(string aCodigoClienteProveedor, int aEsCliente, string aFechaDocto, int aIdMoneda, double aTipoCambio, double aImporteIVA, double aTasaIVA, double aImporteIESPS, double aTasaIESPS, int aIdFacturaBase, string aMetodo, string aLugar, ref int aIdDoctoGenerado)
        {
            return AdminpaqSdk.fAltaDoctoAjusteIESPSCteProv(aCodigoClienteProveedor, aEsCliente, aFechaDocto, aIdMoneda, aTipoCambio, aImporteIVA, aTasaIVA, aImporteIESPS, aTasaIESPS, aIdFacturaBase, aMetodo, aLugar, ref aIdDoctoGenerado);
        }

        public int fAltaMovimiento(int aIdDocumento, ref int aIdMovimiento, ref tMovimiento astMovimiento)
        {
            return AdminpaqSdk.fAltaMovimiento(aIdDocumento, ref aIdMovimiento, ref astMovimiento);
        }
        public int fAltaMovimientoEx(ref int aIdMovimiento, tTipoProducto aTipoProducto)
        {
            return AdminpaqSdk.fAltaMovimientoEx(ref aIdMovimiento, aTipoProducto);
        }

        public int fAltaMovimientoCDesct(int aIdDocumento, int aIdMovimiento, tMovimientoDesc astMovimiento)
        {
            return AdminpaqSdk.fAltaMovimientoCDesct(aIdDocumento, aIdMovimiento, astMovimiento);
        }

        public int fAltaMovimientoCaracteristicas(int aIdMovimiento, int aIdMovtoCaracteristicas, tCaracteristicas aCaracteristicas)
        {
            return AdminpaqSdk.fAltaMovimientoCaracteristicas(aIdMovimiento, aIdMovtoCaracteristicas, aCaracteristicas);
        }

        public int fAltaMovtoCaracteristicasUnidades(int aIdMovimiento, int aIdMovtoCaracteristicas, tCaracteristicas aCaracteristicasUnidades)
        {
            return AdminpaqSdk.fAltaMovtoCaracteristicasUnidades(aIdMovimiento, aIdMovtoCaracteristicas, aCaracteristicasUnidades);
        }

        public int fAltaMovimientoSeriesCapas(int aIdMovimiento, ref tSeriesCapas aSeriesCapas)
        {
            return AdminpaqSdk.fAltaMovimientoSeriesCapas(aIdMovimiento, ref aSeriesCapas);
        }

        #endregion

        #region Clientes y Proveedores

        public int fInsertaCteProv()
        {
            return AdminpaqSdk.fInsertaCteProv();
        }

        public int fEditaCteProv()
        {
            return AdminpaqSdk.fEditaCteProv();
        }

        public int fGuardaCteProv()
        {
            return AdminpaqSdk.fGuardaCteProv();
        }

        public int fBorraCteProv()
        {
            return AdminpaqSdk.fBorraCteProv();
        }

        public int fCancelarModificacionCteProv()
        {
            return AdminpaqSdk.fCancelarModificacionCteProv();
        }

        public int fEliminarCteProv(string aCodigoCteProv)
        {
            return AdminpaqSdk.fEliminarCteProv(aCodigoCteProv);
        }

        public int fSetDatoCteProv(string aCampo, string aValor)
        {
            return AdminpaqSdk.fSetDatoCteProv(aCampo, aValor);
        }

        public int fLeeDatoCteProv(string aCampo, StringBuilder aValor, int aLen)
        {
            return AdminpaqSdk.fLeeDatoCteProv(aCampo, aValor, aLen);
        }

        public int fBuscaCteProv(string aCodCteProv)
        {
            return AdminpaqSdk.fBuscaCteProv(aCodCteProv);
        }

        public int fBuscaIdCteProv(int aIdCteProv)
        {
            return AdminpaqSdk.fBuscaIdCteProv(aIdCteProv);
        }

        public int fPosPrimerCteProv()
        {
            return AdminpaqSdk.fPosPrimerCteProv();
        }

        public int fPosUltimoCteProv()
        {
            return AdminpaqSdk.fPosUltimoCteProv();
        }

        public int fPosSiguienteCteProv()
        {
            return AdminpaqSdk.fPosSiguienteCteProv();
        }

        public int fPosAnteriorCteProv()
        {
            return AdminpaqSdk.fPosAnteriorCteProv();
        }

        public int fPosBOFCteProv()
        {
            return AdminpaqSdk.fPosBOFCteProv();
        }

        public int fPosEOFCteProv()
        {
            return AdminpaqSdk.fPosEOFCteProv();
        }

        public int fInformacionCliente(StringBuilder aCodigo, ref int aPermiteCredito, ref double aLimiteCredito, ref int aLimiteDoctosVencidos, ref int aPermiteExcederCredito, StringBuilder aFecha, ref double aSaldo, ref double aSaldoPendiente, ref int aDoctosVencidos)
        {
            return AdminpaqSdk.fInformacionCliente(aCodigo, ref aPermiteCredito, ref aLimiteCredito, ref aLimiteDoctosVencidos, ref aPermiteExcederCredito, aFecha, ref aSaldo, ref aSaldoPendiente, ref aDoctosVencidos);
        }

        public int fAltaCteProv(StringBuilder aIdCteProv, tCteProv astCteProv)
        {
            return AdminpaqSdk.fAltaCteProv(aIdCteProv, astCteProv);
        }

        public int fActualizaCteProv(StringBuilder aCodigoCteProv, tCteProv astCteProv)
        {
            return AdminpaqSdk.fActualizaCteProv(aCodigoCteProv, astCteProv);
        }

        public int fLlenaRegistroCteProv(tCteProv astCteProv, int aEsAlta)
        {
            return AdminpaqSdk.fLlenaRegistroCteProv(astCteProv, aEsAlta);
        }

        #endregion

        #region Productos

        public int fInsertaProducto()
        {
            return AdminpaqSdk.fInsertaProducto();
        }

        public int fEditaProducto()
        {
            return AdminpaqSdk.fEditaProducto();
        }

        public int fGuardaProducto()
        {
            return AdminpaqSdk.fGuardaProducto();
        }

        public int fBorraProducto()
        {
            return AdminpaqSdk.fBorraProducto();
        }

        public int fCancelarModificacionProducto()
        {
            return AdminpaqSdk.fCancelarModificacionProducto();
        }

        public int fEliminarProducto()
        {
            return AdminpaqSdk.fEliminarProducto();
        }

        public int fSetDatoProducto(string aCampo, string aValor)
        {
            return AdminpaqSdk.fSetDatoProducto(aCampo, aValor);
        }

        public int fSetDescripcionProducto(string aCampo, string aValor)
        {
            return AdminpaqSdk.fSetDescripcionProducto(aCampo, aValor);
        }

        public int fAltaProducto(ref int aIdProducto, tProducto astProducto)
        {
            return AdminpaqSdk.fAltaProducto(ref aIdProducto, astProducto);
        }

        public int fLeeDatoProducto(string aCampo, StringBuilder aValor, int aLen)
        {
            return AdminpaqSdk.fLeeDatoProducto(aCampo, aValor, aLen);
        }

        public int fRecuperaTipoProducto(ref bool aUnidades, ref bool aSerie, ref bool aLote, ref bool aPedimento, ref bool aCaracteristicas)
        {
            return AdminpaqSdk.fRecuperaTipoProducto(ref aUnidades, ref aSerie, ref aLote, ref aPedimento, ref aCaracteristicas);
        }

        public int fRecosteoProducto(string aCodigoProducto, int aEjercicio, int aPeriodo, string aCodigoClasificacion1, string aCodigoClasificacion2, string aCodigoClasificacion3, string aCodigoClasificacion4, string aCodigoClasificacion5, string aCodigoClasificacion6, string aNombreBitacora, int aSobreEscribirBitacora, int aEsCalculoArimetico)
        {
            return AdminpaqSdk.fRecosteoProducto(aCodigoProducto, aEjercicio, aPeriodo, aCodigoClasificacion1, aCodigoClasificacion2, aCodigoClasificacion3, aCodigoClasificacion4, aCodigoClasificacion5, aCodigoClasificacion6, aNombreBitacora, aSobreEscribirBitacora, aEsCalculoArimetico);
        }

        public int fRegresaPrecioVenta(string aCodigoConcepto, string aCodigoCliente, string aCodigoProducto, StringBuilder aPrecioVenta)
        {
            return AdminpaqSdk.fRegresaPrecioVenta(aCodigoConcepto, aCodigoCliente, aCodigoProducto, aPrecioVenta);
        }

        public int fBuscaProducto(string aCodProducto)
        {
            return AdminpaqSdk.fBuscaProducto(aCodProducto);
        }

        public int fBuscaIdProducto(int aIdProducto)
        {
            return AdminpaqSdk.fBuscaIdProducto(aIdProducto);
        }

        public int fPosPrimerProducto()
        {
            return AdminpaqSdk.fPosPrimerProducto();
        }

        public int fPosUltimoProducto()
        {
            return AdminpaqSdk.fPosUltimoProducto();
        }

        public int fPosSiguienteProducto()
        {
            return AdminpaqSdk.fPosSiguienteProducto();
        }

        public int fPosAnteriorProducto()
        {
            return AdminpaqSdk.fPosAnteriorProducto();
        }

        public int fPosBOFProducto()
        {
            return AdminpaqSdk.fPosBOFProducto();
        }

        public int fPosEOFProducto()
        {
            return AdminpaqSdk.fPosEOFProducto();
        }

        public int fActualizaProducto(ref int aCodigoProducto, tProducto astProducto)
        {
            return AdminpaqSdk.fActualizaProducto(ref aCodigoProducto, astProducto);
        }

        public int fLlenaRegistroProducto(tProducto astProducto, int aEsAlta)
        {
            return AdminpaqSdk.fLlenaRegistroProducto(astProducto, aEsAlta);
        }

        #endregion

        #region Addendas

        public int fInsertaDatoCompEducativo(int aIdServicio, int aNumCampo, StringBuilder aDato)
        {
            return AdminpaqSdk.fInsertaDatoCompEducativo(aIdServicio, aNumCampo, aDato);
        }

        public int fInsertaDatoAddendaDocto(int aIdAddenda, int aIdCatalogo, int aNumCampo, StringBuilder aDato)
        {
            return AdminpaqSdk.fInsertaDatoAddendaDocto(aIdAddenda, aIdCatalogo, aNumCampo, aDato);
        }

        public int fInsertaDatoAddendaMovto(int aIdAddenda, int aIdCatalogo, int aNumCampo, StringBuilder aDato)
        {
            return AdminpaqSdk.fInsertaDatoAddendaMovto(aIdAddenda, aIdCatalogo, aNumCampo, aDato);
        }

        public int fObtenCeryKey(int aIdFirmarl, string aRutaKey, string aRutaCer)
        {
            return AdminpaqSdk.fObtenCeryKey(aIdFirmarl, aRutaKey, aRutaCer);
        }

        public int fObtieneLicencia(StringBuilder aCodAcvtiva, StringBuilder aCodSitio, StringBuilder aSerie, StringBuilder aTagVersion)
        {
            return AdminpaqSdk.fObtieneLicencia(aCodAcvtiva, aCodSitio, aSerie, aTagVersion);
        }

        public int fObtienePassProxy(StringBuilder aPassProxy)
        {
            return AdminpaqSdk.fObtienePassProxy(aPassProxy);
        }

        public int fTimbraXML(StringBuilder aRutaXML, StringBuilder aCodCOncepto, StringBuilder aUUID, StringBuilder aRutaDDA, StringBuilder aRutaResultado, StringBuilder aPass, StringBuilder aRutaFormato)
        {
            return AdminpaqSdk.fTimbraXML(aRutaXML, aCodCOncepto, aUUID, aRutaDDA, aRutaResultado, aPass, aRutaFormato);
        }

        public int fTimbraNominaXML(StringBuilder aRutaXML, StringBuilder aCodCOncepto, StringBuilder aUUID, StringBuilder aRutaDDA, StringBuilder aRutaResultado, StringBuilder aPass, StringBuilder aRutaFormato)
        {
            return AdminpaqSdk.fTimbraNominaXML(aRutaXML, aCodCOncepto, aUUID, aRutaDDA, aRutaResultado, aPass, aRutaFormato);
        }

        public int fTimbraComplementoXML(string aRutaXML, string aCodCOncepto, string aUUID, string aRutaDDA, string aRutaResultado, string aPass, string aRutaFormato, int aComplemento)
        {
            return AdminpaqSdk.fTimbraComplementoXML(aRutaXML, aCodCOncepto, aUUID, aRutaDDA, aRutaResultado, aPass, aRutaFormato, aComplemento);
        }

        public int fCancelaUUID(string aUUID, string aIdDConcepto, string aPass)
        {
            return AdminpaqSdk.fCancelaUUID(aUUID, aIdDConcepto, aPass);
        }

        public int fCancelaNominaUUID(string aUUID, string aIdDConcepto, string aPass)
        {
            return AdminpaqSdk.fCancelaNominaUUID(aUUID, aIdDConcepto, aPass);
        }

        #endregion

        #region Direcciones

        public int fInsertaDireccion()
        {
            return AdminpaqSdk.fInsertaDireccion();
        }

        public int fEditaDireccion()
        {
            return AdminpaqSdk.fEditaDireccion();
        }

        public int fGuardaDireccion()
        {
            return AdminpaqSdk.fGuardaDireccion();
        }

        public int fCancelarModificacionDireccion()
        {
            return AdminpaqSdk.fCancelarModificacionDireccion();
        }

        public int fLeeDatoDireccion(string aCampo, StringBuilder aValor, int aLen)
        {
            return AdminpaqSdk.fLeeDatoDireccion(aCampo, aValor, aLen);
        }

        public int fSetDatoDireccion(string aCampo, string aValor)
        {
            return AdminpaqSdk.fSetDatoDireccion(aCampo, aValor);
        }

        public int fBuscaDireccionEmpresa()
        {
            return AdminpaqSdk.fBuscaDireccionEmpresa();
        }

        public int fBuscaDireccionCteProv(string aCodCteProv, int aTipoDireccion)
        {
            return AdminpaqSdk.fBuscaDireccionCteProv(aCodCteProv, aTipoDireccion);
        }

        public int fBuscaDireccionDocumento(int aIdDocumento, int aTipoDireccion)
        {
            return AdminpaqSdk.fBuscaDireccionDocumento(aIdDocumento, aTipoDireccion);
        }

        public int fPosPrimerDireccion()
        {
            return AdminpaqSdk.fPosPrimerDireccion();
        }

        public int fPosUltimaDireccion()
        {
            return AdminpaqSdk.fPosUltimaDireccion();
        }

        public int fPosSiguienteDireccion()
        {
            return AdminpaqSdk.fPosSiguienteDireccion();
        }

        public int fPosAnteriorDireccion()
        {
            return AdminpaqSdk.fPosAnteriorDireccion();
        }

        public int fPosBOFDireccion()
        {
            return AdminpaqSdk.fPosBOFDireccion();
        }

        public int fPosEOFDireccion()
        {
            return AdminpaqSdk.fPosEOFDireccion();
        }

        public int fAltaDireccion(ref int aIdDireccion, ref tDireccion astDireccion)
        {
            return AdminpaqSdk.fAltaDireccion(ref aIdDireccion, ref astDireccion);
        }

        public int fActualizaDireccion(ref tDireccion astDireccion)
        {
            return AdminpaqSdk.fActualizaDireccion(ref astDireccion);
        }

        public int fLlenaRegistroDireccion(ref tDireccion astDireccion, int aEsAlta)
        {
            return AdminpaqSdk.fLlenaRegistroDireccion(ref astDireccion, aEsAlta);
        }

        #endregion

        #region Existencias

        public int fRegresaExistencia(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, ref double aExistencia)
        {
            return AdminpaqSdk.fRegresaExistencia(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, ref aExistencia);
        }

        public int fRegresaExistenciaCaracteristicas(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, ref double aExistencia)
        {
            return AdminpaqSdk.fRegresaExistenciaCaracteristicas(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, aValorCaracteristica1, aValorCaracteristica2, aValorCaracteristica3, ref aExistencia);
        }

        #endregion

        #region Costo Historico

        public int fRegresaCostoPromedio(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, StringBuilder aCostoPromedio)
        {
            return AdminpaqSdk.fRegresaCostoPromedio(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, aCostoPromedio);
        }

        public int fRegresaUltimoCosto(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, StringBuilder aUltimoCosto)
        {
            return AdminpaqSdk.fRegresaUltimoCosto(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, aUltimoCosto);
        }

        public int fRegresaCostoEstandar(string aCodigoProducto, StringBuilder aCostoEstandar)
        {
            return AdminpaqSdk.fRegresaCostoEstandar(aCodigoProducto, aCostoEstandar);
        }

        public int fRegresaCostoCapa(string aCodigoProducto, string aCodigoAlmacen, double aUnidades, StringBuilder aImporteCosto)
        {
            return AdminpaqSdk.fRegresaCostoCapa(aCodigoProducto, aCodigoAlmacen, aUnidades, aImporteCosto);
        }

        #endregion

        #region Conceptos De Documentos

        public int fLeeDatoConceptoDocto(string aCampo, StringBuilder aValor, int aLen)
        {
            return AdminpaqSdk.fLeeDatoConceptoDocto(aCampo, aValor, aLen);
        }

        public int fRegresPorcentajeImpuesto(int aIdConceptoDocumento, int aIdClienteProveedor, int aIdProducto, ref double aPorcentajeImpuesto)
        {
            return AdminpaqSdk.fRegresPorcentajeImpuesto(aIdConceptoDocumento, aIdClienteProveedor, aIdProducto, ref aPorcentajeImpuesto);
        }

        public int fEditaConceptoDocto()
        {
            return AdminpaqSdk.fEditaConceptoDocto();
        }

        public int fSetDatoConceptoDocto(StringBuilder aCampo, StringBuilder aValor)
        {
            return AdminpaqSdk.fSetDatoConceptoDocto(aCampo, aValor);
        }

        public int fGuardaConceptoDocto()
        {
            return AdminpaqSdk.fGuardaConceptoDocto();
        }

        public int fBuscaConceptoDocto(string aCodConcepto)
        {
            return AdminpaqSdk.fBuscaConceptoDocto(aCodConcepto);
        }

        public int fBuscaIdConceptoDocto(int aIdConcepto)
        {
            return AdminpaqSdk.fBuscaIdConceptoDocto(aIdConcepto);
        }

        public int fPosPrimerConceptoDocto()
        {
            return AdminpaqSdk.fPosPrimerConceptoDocto();
        }

        public int fPosUltimaConceptoDocto()
        {
            return AdminpaqSdk.fPosUltimaConceptoDocto();
        }

        public int fPosSiguienteConceptoDocto()
        {
            return AdminpaqSdk.fPosSiguienteConceptoDocto();
        }

        public int fPosAnteriorConceptoDocto()
        {
            return AdminpaqSdk.fPosAnteriorConceptoDocto();
        }

        public int fPosBOFConceptoDocto()
        {
            return AdminpaqSdk.fPosBOFConceptoDocto();
        }

        public int fPosEOFConceptoDocto()
        {
            return AdminpaqSdk.fPosEOFConceptoDocto();
        }

        #endregion

        #region Paramentros

        public int fEditaParametros()
        {
            return AdminpaqSdk.fEditaParametros();
        }

        public int fLeeDatoParametros(string aCampo, StringBuilder aValor, int aLen)
        {
            return AdminpaqSdk.fLeeDatoParametros(aCampo, aValor, aLen);
        }

        public int fGuardaParametros()
        {
            return AdminpaqSdk.fGuardaParametros();
        }

        public int fSetDatoParametros(string aCampo, StringBuilder aValor)
        {
            return AdminpaqSdk.fSetDatoParametros(aCampo, aValor);
        }

        #endregion

        #region Catalago De Clasificaciones

        public int fEditaClasificacion()
        {
            return AdminpaqSdk.fEditaClasificacion();
        }

        public int fGuardaClasificacion()
        {
            return AdminpaqSdk.fGuardaClasificacion();
        }
        public int fCancelarModificacionClasificacion()
        {
            return AdminpaqSdk.fGuardaClasificacion();
        }

        public int fActualizaClasificacion(int aClasificacionDe, int aNumClasificacion, string aNombreClasificacion)
        {
            return AdminpaqSdk.fActualizaClasificacion(aClasificacionDe, aNumClasificacion, aNombreClasificacion);
        }

        public int fLeeDatoClasificacion(string aCampo, StringBuilder aValor, int aLen)
        {
            return AdminpaqSdk.fLeeDatoClasificacion(aCampo, aValor, aLen);
        }

        public int fSetDatoClasificacion(string aCampo, string aValor)
        {
            return AdminpaqSdk.fSetDatoClasificacion(aCampo, aValor);
        }

        public int fBuscaClasificacion(int aClasificacionDe, int aNumClasificacion)
        {
            return AdminpaqSdk.fBuscaClasificacion(aClasificacionDe, aNumClasificacion);
        }

        public int fBuscaIdClasificacion(int aIdClasificacion)
        {
            return AdminpaqSdk.fBuscaIdClasificacion(aIdClasificacion);
        }

        public int fPosPrimerClasificacion()
        {
            return AdminpaqSdk.fPosPrimerClasificacion();
        }

        public int fPosUltimoClasificacion()
        {
            return AdminpaqSdk.fPosUltimoClasificacion();
        }

        public int fPosSiguienteClasificacion()
        {
            return AdminpaqSdk.fPosSiguienteClasificacion();
        }

        public int fPosAnteriorClasificacion()
        {
            return AdminpaqSdk.fPosAnteriorClasificacion();
        }

        public int fPosBOFClasificacion()
        {
            return AdminpaqSdk.fPosBOFClasificacion();
        }

        public int fPosEOFClasificacion()
        {
            return AdminpaqSdk.fPosEOFClasificacion();
        }

        #endregion

        #region Catalogo De Valores De Clasificaciones

        public int fInsertaValorClasif()
        {
            return AdminpaqSdk.fInsertaValorClasif();
        }

        public int fEditaValorClasif()
        {
            return AdminpaqSdk.fEditaValorClasif();
        }

        public int fGuardaValorClasif()
        {
            return AdminpaqSdk.fEditaValorClasif();
        }

        public int fBorraValorClasif()
        {
            return AdminpaqSdk.fBorraValorClasif();
        }

        public int fCancelarModificacionValorClasif()
        {
            return AdminpaqSdk.fBorraValorClasif();
        }

        public int fEliminarValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodigoValorClasif)
        {
            return AdminpaqSdk.fEliminarValorClasif(aClasificacionDe, aNumClasificacion, aCodigoValorClasif);
        }

        public int fSetDatoValorClasif(string aCampo, string aValor)
        {
            return AdminpaqSdk.fSetDatoValorClasif(aCampo, aValor);
        }

        public int fLeeDatoValorClasif(string aCampo, StringBuilder aValor, int aLen)
        {
            return AdminpaqSdk.fLeeDatoValorClasif(aCampo, aValor, aLen);
        }

        public int fBuscaValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodValorClasif)
        {
            return AdminpaqSdk.fBuscaValorClasif(aClasificacionDe, aNumClasificacion, aCodValorClasif);
        }

        public int fBuscaIdValorClasif(int aIdValorClasif)
        {
            return AdminpaqSdk.fBuscaIdValorClasif(aIdValorClasif);
        }

        public int fPosPrimerValorClasif()
        {
            return AdminpaqSdk.fPosPrimerValorClasif();
        }

        public int fPosUltimoValorClasif()
        {
            return AdminpaqSdk.fPosUltimoValorClasif();
        }

        public int fPosSiguienteValorClasif()
        {
            return AdminpaqSdk.fPosSiguienteValorClasif();
        }

        public int fPosAnteriorValorClasif()
        {
            return AdminpaqSdk.fPosAnteriorValorClasif();
        }
        public int fPosBOFValorClasif()
        {
            return AdminpaqSdk.fPosBOFValorClasif();
        }

        public int fPosEOFValorClasif()
        {
            return AdminpaqSdk.fPosEOFValorClasif();
        }

        public int fAltaValorClasif(ref int aIdValorClasif, ref tValorClasificacion astValorClasif)
        {
            return AdminpaqSdk.fAltaValorClasif(ref aIdValorClasif, ref astValorClasif);
        }

        public int fActualizaValorClasif(string aCodigoValorClasif, ref tValorClasificacion astValorClasif)
        {
            return AdminpaqSdk.fActualizaValorClasif(aCodigoValorClasif, ref astValorClasif);
        }

        public int fLlenaRegistroValorClasif(ref tValorClasificacion astValorClasif)
        {
            return AdminpaqSdk.fLlenaRegistroValorClasif(ref astValorClasif);
        }

        #endregion

        #region Catalogo De Unidades De Medida Y Peso

        public int fInsertaUnidad()
        {
            return AdminpaqSdk.fInsertaUnidad();
        }

        public int fEditaUnidad()
        {
            return AdminpaqSdk.fEditaUnidad();
        }

        public int fGuardaUnidad()
        {
            return AdminpaqSdk.fGuardaUnidad();
        }

        public int fBorraUnidad()
        {
            return AdminpaqSdk.fBorraUnidad();
        }

        public int fCancelarModificacionUnidad()
        {
            return AdminpaqSdk.fBorraUnidad();
        }

        public int fEliminarUnidad(string aNombreUnidad)
        {
            return AdminpaqSdk.fEliminarUnidad(aNombreUnidad);
        }

        public int fLeeDatoUnidad(string aCampo, StringBuilder aValor, int aLen)
        {
            return AdminpaqSdk.fLeeDatoUnidad(aCampo, aValor, aLen);
        }

        public int fSetDatoUnidad(string aCampo, string aValor)
        {
            return AdminpaqSdk.fSetDatoUnidad(aCampo, aValor);
        }

        public int fBuscaUnidad(string aNombreUnidad)
        {
            return AdminpaqSdk.fBuscaUnidad(aNombreUnidad);
        }

        public int fBuscaIdUnidad(int aIdUnidad)
        {
            return AdminpaqSdk.fBuscaIdUnidad(aIdUnidad);
        }

        public int fPosPrimerUnidad()
        {
            return AdminpaqSdk.fPosPrimerUnidad();
        }

        public int fPosUltimoUnidad()
        {
            return AdminpaqSdk.fPosUltimoUnidad();
        }

        public int fPosSiguienteUnidad()
        {
            return AdminpaqSdk.fPosSiguienteUnidad();
        }

        public int fPosAnteriorUnidad()
        {
            return AdminpaqSdk.fPosAnteriorUnidad();
        }

        public int fPosBOFUnidad()
        {
            return AdminpaqSdk.fPosBOFUnidad();
        }

        public int fPosEOFUnidad()
        {
            return AdminpaqSdk.fPosBOFUnidad();
        }

        public int fAltaUnidad(ref int aIdUnidad, ref tUnidad astUnidad)
        {
            return AdminpaqSdk.fAltaUnidad(ref aIdUnidad, ref astUnidad);
        }

        public int fActualizaUnidad(string aNombreUnidad, ref tUnidad astUnidad)
        {
            return AdminpaqSdk.fActualizaUnidad(aNombreUnidad, ref astUnidad);
        }

        public int fLlenaRegistroUnidad(ref tUnidad astUnidad)
        {
            return AdminpaqSdk.fLlenaRegistroUnidad(ref astUnidad);
        }

        #endregion

        #region Catalogo De Agentes

        public int fInsertaAgente()
        {
            return AdminpaqSdk.fInsertaAgente();
        }

        public int fEditaAgente()
        {
            return AdminpaqSdk.fEditaAgente();
        }

        public int fGuardaAgente()
        {
            return AdminpaqSdk.fGuardaAgente();
        }

        public int fCancelarModificacionAgente()
        {
            return AdminpaqSdk.fCancelarModificacionAgente();
        }

        public int fSetDatoAgente(string aCampo, string aValor)
        {
            return AdminpaqSdk.fCancelarModificacionAgente();
        }

        public int fLeeDatoAgente(string aCampo, StringBuilder aValor, int aLen)
        {
            return AdminpaqSdk.fLeeDatoAgente(aCampo, aValor, aLen);
        }

        public int fBuscaAgente(string aCodigoAgente)
        {
            return AdminpaqSdk.fBuscaAgente(aCodigoAgente);
        }

        public int fBuscaIdAgente(int aIdAgente)
        {
            return AdminpaqSdk.fBuscaIdAgente(aIdAgente);
        }

        public int fPosPrimerAgente()
        {
            return AdminpaqSdk.fPosPrimerAgente();
        }

        public int fPosUltimoAgente()
        {
            return AdminpaqSdk.fPosUltimoAgente();
        }

        public int fPosSiguienteAgente()
        {
            return AdminpaqSdk.fPosSiguienteAgente();
        }

        public int fPosAnteriorAgente()
        {
            return AdminpaqSdk.fPosAnteriorAgente();
        }

        public int fPosBOFAgente()
        {
            return AdminpaqSdk.fPosBOFAgente();
        }

        public int fPosEOFAgente()
        {
            return AdminpaqSdk.fPosEOFAgente();
        }

        #endregion

        #region Catalago De Almacenes

        public int fInsertaAlmacen()
        {
            return AdminpaqSdk.fInsertaAlmacen();
        }

        public int fEditaAlmacen()
        {
            return AdminpaqSdk.fEditaAlmacen();
        }

        public int fGuardaAlmacen()
        {
            return AdminpaqSdk.fGuardaAlmacen();
        }

        public int fCancelarModificacionAlmacen()
        {
            return AdminpaqSdk.fCancelarModificacionAlmacen();
        }

        public int fLeeDatoAlmacen(string aCampo, StringBuilder aValor, int aLen)
        {
            return AdminpaqSdk.fLeeDatoAlmacen(aCampo, aValor, aLen);
        }

        public int fSetDatoAlmacen(string aCampo, string aValor)
        {
            return AdminpaqSdk.fSetDatoAlmacen(aCampo, aValor);
        }

        public int fBuscaAlmacen(string aCodigoAlmacen)
        {
            return AdminpaqSdk.fBuscaAlmacen(aCodigoAlmacen);
        }

        public int fBuscaIdAlmacen(int aIdAlmacen)
        {
            return AdminpaqSdk.fBuscaIdAlmacen(aIdAlmacen);
        }

        public int fPosPrimerAlmacen()
        {
            return AdminpaqSdk.fPosPrimerAlmacen();
        }

        public int fPosUltimoAlmacen()
        {
            return AdminpaqSdk.fPosUltimoAlmacen();
        }

        public int fPosSiguienteAlmacen()
        {
            return AdminpaqSdk.fPosSiguienteAlmacen();
        }

        public int fPosAnteriorAlmacen()
        {
            return AdminpaqSdk.fPosAnteriorAlmacen();
        }

        public int fPosBOFAlmacen()
        {
            return AdminpaqSdk.fPosBOFAlmacen();
        }

        public int fPosEOFAlmacen()
        {
            return AdminpaqSdk.fPosEOFAlmacen();
        }

        #endregion

        #region Movimientos Contables

        public int fEditaMovtoContable()
        {
            return AdminpaqSdk.fEditaMovtoContable();
        }

        public int fGuardaMovtoContable()
        {
            return AdminpaqSdk.fGuardaMovtoContable();
        }

        public int fLeeDatoMovtoContable(string aCampo, StringBuilder aValor, int aLen)
        {
            return AdminpaqSdk.fLeeDatoMovtoContable(aCampo, aValor, aLen);
        }

        public int fSetDatoMovtoContable(string aCampo, string aValor)
        {
            return AdminpaqSdk.fSetDatoMovtoContable(aCampo, aValor);
        }

        public int fPosPrimerMovtoContable()
        {
            return AdminpaqSdk.fPosPrimerMovtoContable();
        }

        public int fPosSiguienteMovtoContable()
        {
            return AdminpaqSdk.fPosSiguienteMovtoContable();
        }

        public int fPosEOFMovtoContable()
        {
            return AdminpaqSdk.fPosEOFMovtoContable();
        }

        #endregion

    }
}

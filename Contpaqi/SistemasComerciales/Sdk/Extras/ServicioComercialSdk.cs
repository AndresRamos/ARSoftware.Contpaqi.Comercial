using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras
{
    public class ServicioComercialSdk : ISistemasComercialesSdk
    {
        #region Generales

        public int fInicializaSDK()
        {
            return ComercialSdk.fInicializaSDK();
        }

        public void fTerminaSDK()
        {
            ComercialSdk.fTerminaSDK();
        }

        public int fSetNombrePAQ(string aSistema)
        {
            return ComercialSdk.fSetNombrePAQ(aSistema);
        }

        public void fError(int aNumError, StringBuilder aMensaje, int aLen)
        {
            ComercialSdk.fError(aNumError, aMensaje, aLen);
        }

        public void fInicioSesionSDK(string aUsuario, string aContrasenia)
        {
            ComercialSdk.fInicioSesionSDK(aUsuario, aContrasenia);
        }

        public void fSetModoImportacion(bool aImportacion)
        {
            ComercialSdk.fSetModoImportacion(aImportacion);
        }

        #endregion Generales

        #region Empresas

        public int fPosPrimerEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa)
        {
            return ComercialSdk.fPosPrimerEmpresa(ref aIdEmpresa, aNombreEmpresa, aDirectorioEmpresa);
        }

        public int fPosSiguienteEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa)
        {
            return ComercialSdk.fPosSiguienteEmpresa(ref aIdEmpresa, aNombreEmpresa, aDirectorioEmpresa);
        }

        public int fAbreEmpresa(string aDirectorioEmpresa)
        {
            return ComercialSdk.fAbreEmpresa(aDirectorioEmpresa);
        }

        public void fCierraEmpresa()
        {
            ComercialSdk.fCierraEmpresa();
        }

        #endregion Empresas

        #region Documentos

        public int fInsertarDocumento()
        {
            return ComercialSdk.fInsertarDocumento();
        }

        public int fEditarDocumento()
        {
            return ComercialSdk.fEditarDocumento();
        }

        public int fGuardaDocumento()
        {
            return ComercialSdk.fGuardaDocumento();
        }

        public int fCancelarModificacionDocumento()
        {
            return ComercialSdk.fCancelarModificacionDocumento();
        }

        public int fBorraDocumento()
        {
            return ComercialSdk.fBorraDocumento();
        }

        public int fCancelaDocumento()
        {
            return ComercialSdk.fCancelaDocumento();
        }

        public int fBorraDocumento_CW()
        {
            return ComercialSdk.fBorraDocumento_CW();
        }

        public int fCancelaDocumento_CW()
        {
            return ComercialSdk.fCancelaDocumento_CW();
        }

        public int fAfectaDocto_Param(string aCodConcepto, string aSerie, double aFolio, bool aAfecta)
        {
            return ComercialSdk.fAfectaDocto_Param(aCodConcepto, aSerie, aFolio, aAfecta);
        }

        public int fSaldarDocumento_Param(string aCodConcepto_Pagar, string aSerie_Pagar, string aFolio_Pagar, string aCodConcepto_Pago, string aSerie_Pago, string aFolio_Pago, double aImporte, int aIdMoneda, string aFecha)
        {
            return ComercialSdk.fSaldarDocumento_Param(aCodConcepto_Pagar, aSerie_Pagar, aFolio_Pagar, aCodConcepto_Pago, aSerie_Pago, aFolio_Pago, aImporte, aIdMoneda, aFecha);
        }

        public int fBorrarAsociacion_Param(string aCodConcepto_Pagar, string aSerie_Pagar, string aFolio_Pagar, string aCodConcepto_Pago, string aSerie_Pago, string aFolio_Pago)
        {
            return ComercialSdk.fBorrarAsociacion_Param(aCodConcepto_Pagar, aSerie_Pagar, aFolio_Pagar, aCodConcepto_Pago, aSerie_Pago, aFolio_Pago);
        }

        public int fEditarDocumentoCheqpaq()
        {
            return ComercialSdk.fEditarDocumentoCheqpaq();
        }

        public int fSetDatoDocumento(string aCampo, string aValor)
        {
            return ComercialSdk.fSetDatoDocumento(aCampo, aValor);
        }

        public int fLeeDatoDocumento(string aCampo, StringBuilder aValor, int aLongitud)
        {
            return ComercialSdk.fLeeDatoDocumento(aCampo, aValor, aLongitud);
        }

        public int fSiguienteFolio(string aCodigoConcepto, StringBuilder aSerie, ref double aFolio)
        {
            return ComercialSdk.fSiguienteFolio(aCodigoConcepto, aSerie, ref aFolio);
        }

        public int fSetFiltroDocumento(string aFechaInicio, string aFechaFin, string aCodigoConcepto, string aCodigoCteProv)
        {
            return ComercialSdk.fSetFiltroDocumento(aFechaInicio, aFechaFin, aCodigoConcepto, aCodigoCteProv);
        }

        public int fCancelaFiltroDocumento()
        {
            return ComercialSdk.fCancelaFiltroDocumento();
        }

        public int fDocumentoImpreso(ref bool aImpreso)
        {
            return ComercialSdk.fDocumentoImpreso(ref aImpreso);
        }

        public int fDocumentoBloqueado(ref int aImpreso)
        {
            return ComercialSdk.fDocumentoBloqueado(ref aImpreso);
        }

        public int fBuscarDocumento(string aCodConcepto, string aSerie, string aFolio)
        {
            return ComercialSdk.fBuscarDocumento(aCodConcepto, aSerie, aFolio);
        }

        public int fBuscarIdDocumento(int aIdDocumento)
        {
            return ComercialSdk.fBuscarIdDocumento(aIdDocumento);
        }

        public int fPosPrimerDocumento()
        {
            return ComercialSdk.fPosPrimerDocumento();
        }

        public int fPosUltimoDocumento()
        {
            return ComercialSdk.fPosUltimoDocumento();
        }

        public int fPosSiguienteDocumento()
        {
            return ComercialSdk.fPosSiguienteDocumento();
        }

        public int fPosAnteriorDocumento()
        {
            return ComercialSdk.fPosAnteriorDocumento();
        }

        public int fPosBOF()
        {
            return fPosBOF();
        }

        public int fPosEOF()
        {
            return ComercialSdk.fPosEOF();
        }

        public int fAltaDocumento(ref int aIdDocumento, ref tDocumento aDocumento)
        {
            return ComercialSdk.fAltaDocumento(ref aIdDocumento, ref aDocumento);
        }

        public int fAltaDocumentoCargoAbono(ref tDocumento aDocumento)
        {
            return ComercialSdk.fAltaDocumentoCargoAbono(ref aDocumento);
        }

        public int fAltaDocumentoCargoAbonoExtras(ref tDocumento aDocumento, string aTextoExtra1, string aTextoExtra2, string aTextoExtra3, string aFechaExtra, double aImporteExtra1, double aImporteExtra2, double aImporteExtra3, double aImporteExtra4)
        {
            return ComercialSdk.fAltaDocumentoCargoAbonoExtras(ref aDocumento, aTextoExtra1, aTextoExtra2, aTextoExtra3, aFechaExtra, aImporteExtra1, aImporteExtra2, aImporteExtra3, aImporteExtra4);
        }

        public int fAfectaDocto(ref tLlaveDoc aLlaveDocto, bool aAfecta)
        {
            return ComercialSdk.fAfectaDocto(ref aLlaveDocto, aAfecta);
        }

        public int fSaldarDocumento(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha)
        {
            return ComercialSdk.fSaldarDocumento(aDoctoaPagar, aDoctoPago, aImporte, aIdMoneda, aFecha);
        }

        public int fSaldarDocumentoCheqPAQ(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha, double aTipoCambioCheqPAQ)
        {
            return ComercialSdk.fSaldarDocumentoCheqPAQ(aDoctoaPagar, aDoctoPago, aImporte, aIdMoneda, aFecha, aTipoCambioCheqPAQ);
        }

        public int fBorrarAsociacion(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago)
        {
            return ComercialSdk.fBorrarAsociacion(aDoctoaPagar, aDoctoPago);
        }

        public int fRegresaIVACargo(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas)
        {
            return ComercialSdk.fRegresaIVACargo(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVAOtrasTasas);
        }

        public int fRegresaIVAPago(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas)
        {
            return ComercialSdk.fRegresaIVAPago(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVAOtrasTasas);
        }

        public int fRegresaIVACargo_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas)
        {
            return ComercialSdk.fRegresaIVACargo_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas);
        }

        public int fRegresaIVAPago_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas)
        {
            return ComercialSdk.fRegresaIVAPago_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas);
        }

        public int fRegresaIVACargoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI)
        {
            return ComercialSdk.fRegresaIVACargoRet_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas, aRetIVA, aRetI);
        }

        public int fRegresaIVAPagoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI)
        {
            return ComercialSdk.fRegresaIVAPagoRet_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas, aRetIVA, aRetI);
        }

        public int fGetTamSelloDigitalYCadena(StringBuilder atPtrPassword, ref int aEspSelloDig, ref int aEspCadOrig)
        {
            return ComercialSdk.fGetTamSelloDigitalYCadena(atPtrPassword, ref aEspSelloDig, ref aEspCadOrig);
        }

        public int fGetSelloDigitalYCadena(StringBuilder atPtrPassword, StringBuilder atPtrSelloDigital, StringBuilder atPtrCadenaOriginal)
        {
            return ComercialSdk.fGetSelloDigitalYCadena(atPtrPassword, atPtrSelloDigital, atPtrCadenaOriginal);
        }

        public int fInicializaLicenseInfo(char aSistema)
        {
            return ComercialSdk.fInicializaLicenseInfo(aSistema);
        }

        public int fEmitirDocumento(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, StringBuilder aPassword, StringBuilder aArchivoAdicional)
        {
            return ComercialSdk.fEmitirDocumento(aCodConcepto, aSerie, aFolio, aPassword, aArchivoAdicional);
        }

        public int fDocumentoUUID(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, StringBuilder atPtrCFDIUUID)
        {
            return ComercialSdk.fDocumentoUUID(aCodConcepto, aSerie, aFolio, atPtrCFDIUUID);
        }

        public int fGetSerieCertificado(StringBuilder atPtrPassword, StringBuilder aSerieCertificado)
        {
            return ComercialSdk.fGetSerieCertificado(atPtrPassword, aSerieCertificado);
        }

        public int fGetNumParcialidades(StringBuilder atPtrPassword, StringBuilder aNumParcialidades)
        {
            return ComercialSdk.fGetNumParcialidades(atPtrPassword, aNumParcialidades);
        }

        public int fGetCantidadParcialidades(StringBuilder atPtrPassword, StringBuilder aCantidadParcialidades)
        {
            return ComercialSdk.fGetCantidadParcialidades(atPtrPassword, aCantidadParcialidades);
        }

        public int fActivarPrecioCompra(int aActivar)
        {
            return ComercialSdk.fActivarPrecioCompra(aActivar);
        }

        public int fDocumentoDevuelto(ref int aDevuelto)
        {
            return ComercialSdk.fDocumentoDevuelto(ref aDevuelto);
        }

        public int fEntregEnDiscoXML(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, int aFormato, StringBuilder aFormatoAmig)
        {
            return ComercialSdk.fEntregEnDiscoXML(aCodConcepto, aSerie, aFolio, aFormato, aFormatoAmig);
        }

        public int fObtieneDatosCFDI(StringBuilder atPtrPassword)
        {
            return ComercialSdk.fObtieneDatosCFDI(atPtrPassword);
        }

        public int fLeeDatoCFDI(StringBuilder aValor, int aDato)
        {
            return ComercialSdk.fLeeDatoCFDI(aValor, aDato);
        }

        public int fBuscaDocumento(ref tLlaveDoc aLlaveDocto)
        {
            return ComercialSdk.fBuscaDocumento(ref aLlaveDocto);
        }

        #endregion Documentos

        #region Movimientos

        public int fInsertarMovimiento()
        {
            return ComercialSdk.fInsertarMovimiento();
        }

        public int fEditarMovimiento()
        {
            return ComercialSdk.fEditarMovimiento();
        }

        public int fBorraMovimiento(int aIdDocumento, int aIdMovimiento)
        {
            return ComercialSdk.fBorraMovimiento(aIdDocumento, aIdMovimiento);
        }

        public int fDesbloqueaDocumento()
        {
            return ComercialSdk.fDesbloqueaDocumento();
        }

        public int fGuardaMovimiento()
        {
            return ComercialSdk.fGuardaMovimiento();
        }

        public int fCancelaCambiosMovimiento()
        {
            return ComercialSdk.fCancelaCambiosMovimiento();
        }

        public int fAltaMovimientoCaracteristicas_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidades, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3)
        {
            return ComercialSdk.fAltaMovimientoCaracteristicas_Param(aIdMovimiento, aIdMovtoCaracteristicas, aUnidades, aValorCaracteristica1, aValorCaracteristica2, aValorCaracteristica3);
        }

        public int fAltaMovtoCaracteristicasUnidades_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidad, string aUnidades, string aUnidadesNC, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3)
        {
            return ComercialSdk.fAltaMovtoCaracteristicasUnidades_Param(aIdMovimiento, aIdMovtoCaracteristicas, aUnidad, aUnidades, aUnidadesNC, aValorCaracteristica1, aValorCaracteristica2, aValorCaracteristica3);
        }

        public int fAltaMovimientoSeriesCapas_Param(string aIdMovimiento, string aUnidades, string aTipoCambio, string aSeries, string aPedimento, string aAgencia, string aFechaPedimento, string aNumeroLote, string aFechaFabricacion, string aFechaCaducidad)
        {
            return ComercialSdk.fAltaMovimientoSeriesCapas_Param(aIdMovimiento, aUnidades, aTipoCambio, aSeries, aPedimento, aAgencia, aFechaPedimento, aNumeroLote, aFechaFabricacion, aFechaCaducidad);
        }

        public int fCalculaMovtoSerieCapa(int aIdMovimiento)
        {
            return ComercialSdk.fCalculaMovtoSerieCapa(aIdMovimiento);
        }

        public int fObtieneUnidadesPendientes(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen, StringBuilder aUnidades)
        {
            return ComercialSdk.fObtieneUnidadesPendientes(aConceptoDocto, aCodigoProducto, aCodigoAlmacen, aUnidades);
        }

        public int fObtieneUnidadesPendientesCarac(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, StringBuilder aUnidades)
        {
            return ComercialSdk.fObtieneUnidadesPendientesCarac(aConceptoDocto, aCodigoProducto, aCodigoAlmacen, aValorCaracteristica1, aValorCaracteristica2, aValorCaracteristica3, aUnidades);
        }

        public int fModificaCostoEntrada(string aIdMovimiento, string aCostoEntrada)
        {
            return ComercialSdk.fModificaCostoEntrada(aIdMovimiento, aCostoEntrada);
        }

        public int fSetDatoMovimiento(string aCampo, string aValor)
        {
            return ComercialSdk.fSetDatoMovimiento(aCampo, aValor);
        }

        public int fLeeDatoMovimiento(string aCampo, StringBuilder aValor, int aLen)
        {
            return ComercialSdk.fLeeDatoMovimiento(aCampo, aValor, aLen);
        }

        public int fAfectaSerie(int aIdMovto, string aNumeroSerie)
        {
            return ComercialSdk.fAfectaSerie(aIdMovto, aNumeroSerie);
        }

        public int fSetFiltroMovimiento(int aIdDocumento)
        {
            return ComercialSdk.fSetFiltroMovimiento(aIdDocumento);
        }

        public int fCancelaFiltroMovimiento()
        {
            return ComercialSdk.fCancelaFiltroMovimiento();
        }

        public int fBuscarIdMovimiento(int aIdMovimiento)
        {
            return ComercialSdk.fBuscarIdMovimiento(aIdMovimiento);
        }

        public int fPosPrimerMovimiento()
        {
            return ComercialSdk.fPosPrimerMovimiento();
        }

        public int fPosUltimoMovimiento()
        {
            return ComercialSdk.fPosPrimerMovimiento();
        }

        public int fPosSiguienteMovimiento()
        {
            return ComercialSdk.fPosSiguienteMovimiento();
        }

        public int fPosAnteriorMovimiento()
        {
            return ComercialSdk.fPosAnteriorMovimiento();
        }

        public int fPosMovimientoBOF()
        {
            return ComercialSdk.fPosMovimientoBOF();
        }

        public int fPosMovimientoEOF()
        {
            return ComercialSdk.fPosMovimientoEOF();
        }

        public int fAltaDoctoAjusteIVAClienteProveedor(string aCodigoClienteProveedor, int aEsCliente, int aAbsorberAjusteIVA, string aFechaDocto, int aIdMoneda, double aTipoCambio, double aImporteIVA, double aTasaIVA, int aIdFacturaBase, string aMetodo, string aLugar, ref int aIdDoctoGenerado)
        {
            return ComercialSdk.fAltaDoctoAjusteIVAClienteProveedor(aCodigoClienteProveedor, aEsCliente, aAbsorberAjusteIVA, aFechaDocto, aIdMoneda, aTipoCambio, aImporteIVA, aTasaIVA, aIdFacturaBase, aMetodo, aLugar, ref aIdDoctoGenerado);
        }

        public int fAltaDoctoAjusteIESPSCteProv(string aCodigoClienteProveedor, int aEsCliente, string aFechaDocto, int aIdMoneda, double aTipoCambio, double aImporteIVA, double aTasaIVA, double aImporteIESPS, double aTasaIESPS, int aIdFacturaBase, string aMetodo, string aLugar, ref int aIdDoctoGenerado)
        {
            return ComercialSdk.fAltaDoctoAjusteIESPSCteProv(aCodigoClienteProveedor, aEsCliente, aFechaDocto, aIdMoneda, aTipoCambio, aImporteIVA, aTasaIVA, aImporteIESPS, aTasaIESPS, aIdFacturaBase, aMetodo, aLugar, ref aIdDoctoGenerado);
        }

        public int fAltaMovimiento(int aIdDocumento, ref int aIdMovimiento, ref tMovimiento astMovimiento)
        {
            return ComercialSdk.fAltaMovimiento(aIdDocumento, ref aIdMovimiento, ref astMovimiento);
        }

        public int fAltaMovimientoEx(ref int aIdMovimiento, tTipoProducto aTipoProducto)
        {
            return ComercialSdk.fAltaMovimientoEx(ref aIdMovimiento, aTipoProducto);
        }

        public int fAltaMovimientoCDesct(int aIdDocumento, int aIdMovimiento, tMovimientoDesc astMovimiento)
        {
            return ComercialSdk.fAltaMovimientoCDesct(aIdDocumento, aIdMovimiento, astMovimiento);
        }

        public int fAltaMovimientoCaracteristicas(int aIdMovimiento, int aIdMovtoCaracteristicas, tCaracteristicas aCaracteristicas)
        {
            return ComercialSdk.fAltaMovimientoCaracteristicas(aIdMovimiento, aIdMovtoCaracteristicas, aCaracteristicas);
        }

        public int fAltaMovtoCaracteristicasUnidades(int aIdMovimiento, int aIdMovtoCaracteristicas, tCaracteristicas aCaracteristicasUnidades)
        {
            return ComercialSdk.fAltaMovtoCaracteristicasUnidades(aIdMovimiento, aIdMovtoCaracteristicas, aCaracteristicasUnidades);
        }

        public int fAltaMovimientoSeriesCapas(int aIdMovimiento, ref tSeriesCapas aSeriesCapas)
        {
            return ComercialSdk.fAltaMovimientoSeriesCapas(aIdMovimiento, ref aSeriesCapas);
        }

        #endregion Movimientos

        #region Clientes y Proveedores

        public int fInsertaCteProv()
        {
            return ComercialSdk.fInsertaCteProv();
        }

        public int fEditaCteProv()
        {
            return ComercialSdk.fEditaCteProv();
        }

        public int fGuardaCteProv()
        {
            return ComercialSdk.fGuardaCteProv();
        }

        public int fBorraCteProv()
        {
            return ComercialSdk.fBorraCteProv();
        }

        public int fCancelarModificacionCteProv()
        {
            return ComercialSdk.fCancelarModificacionCteProv();
        }

        public int fEliminarCteProv(string aCodigoCteProv)
        {
            return ComercialSdk.fEliminarCteProv(aCodigoCteProv);
        }

        public int fSetDatoCteProv(string aCampo, string aValor)
        {
            return ComercialSdk.fSetDatoCteProv(aCampo, aValor);
        }

        public int fLeeDatoCteProv(string aCampo, StringBuilder aValor, int aLen)
        {
            return ComercialSdk.fLeeDatoCteProv(aCampo, aValor, aLen);
        }

        public int fBuscaCteProv(string aCodCteProv)
        {
            return ComercialSdk.fBuscaCteProv(aCodCteProv);
        }

        public int fBuscaIdCteProv(int aIdCteProv)
        {
            return ComercialSdk.fBuscaIdCteProv(aIdCteProv);
        }

        public int fPosPrimerCteProv()
        {
            return ComercialSdk.fPosPrimerCteProv();
        }

        public int fPosUltimoCteProv()
        {
            return ComercialSdk.fPosUltimoCteProv();
        }

        public int fPosSiguienteCteProv()
        {
            return ComercialSdk.fPosSiguienteCteProv();
        }

        public int fPosAnteriorCteProv()
        {
            return ComercialSdk.fPosAnteriorCteProv();
        }

        public int fPosBOFCteProv()
        {
            return ComercialSdk.fPosBOFCteProv();
        }

        public int fPosEOFCteProv()
        {
            return ComercialSdk.fPosEOFCteProv();
        }

        public int fInformacionCliente(StringBuilder aCodigo, ref int aPermiteCredito, ref double aLimiteCredito, ref int aLimiteDoctosVencidos, ref int aPermiteExcederCredito, StringBuilder aFecha, ref double aSaldo, ref double aSaldoPendiente, ref int aDoctosVencidos)
        {
            return ComercialSdk.fInformacionCliente(aCodigo, ref aPermiteCredito, ref aLimiteCredito, ref aLimiteDoctosVencidos, ref aPermiteExcederCredito, aFecha, ref aSaldo, ref aSaldoPendiente, ref aDoctosVencidos);
        }

        public int fAltaCteProv(StringBuilder aIdCteProv, tCteProv astCteProv)
        {
            return ComercialSdk.fAltaCteProv(aIdCteProv, astCteProv);
        }

        public int fActualizaCteProv(StringBuilder aCodigoCteProv, tCteProv astCteProv)
        {
            return ComercialSdk.fActualizaCteProv(aCodigoCteProv, astCteProv);
        }

        public int fLlenaRegistroCteProv(tCteProv astCteProv, int aEsAlta)
        {
            return ComercialSdk.fLlenaRegistroCteProv(astCteProv, aEsAlta);
        }

        #endregion Clientes y Proveedores

        #region Productos

        public int fInsertaProducto()
        {
            return ComercialSdk.fInsertaProducto();
        }

        public int fEditaProducto()
        {
            return ComercialSdk.fEditaProducto();
        }

        public int fGuardaProducto()
        {
            return ComercialSdk.fGuardaProducto();
        }

        public int fBorraProducto()
        {
            return ComercialSdk.fBorraProducto();
        }

        public int fCancelarModificacionProducto()
        {
            return ComercialSdk.fCancelarModificacionProducto();
        }

        public int fEliminarProducto()
        {
            return ComercialSdk.fEliminarProducto();
        }

        public int fSetDatoProducto(string aCampo, string aValor)
        {
            return ComercialSdk.fSetDatoProducto(aCampo, aValor);
        }

        public int fSetDescripcionProducto(string aCampo, string aValor)
        {
            return ComercialSdk.fSetDescripcionProducto(aCampo, aValor);
        }

        public int fAltaProducto(ref int aIdProducto, tProducto astProducto)
        {
            return ComercialSdk.fAltaProducto(ref aIdProducto, astProducto);
        }

        public int fLeeDatoProducto(string aCampo, StringBuilder aValor, int aLen)
        {
            return ComercialSdk.fLeeDatoProducto(aCampo, aValor, aLen);
        }

        public int fRecuperaTipoProducto(ref bool aUnidades, ref bool aSerie, ref bool aLote, ref bool aPedimento, ref bool aCaracteristicas)
        {
            return ComercialSdk.fRecuperaTipoProducto(ref aUnidades, ref aSerie, ref aLote, ref aPedimento, ref aCaracteristicas);
        }

        public int fRecosteoProducto(string aCodigoProducto, int aEjercicio, int aPeriodo, string aCodigoClasificacion1, string aCodigoClasificacion2, string aCodigoClasificacion3, string aCodigoClasificacion4, string aCodigoClasificacion5, string aCodigoClasificacion6, string aNombreBitacora, int aSobreEscribirBitacora, int aEsCalculoArimetico)
        {
            return ComercialSdk.fRecosteoProducto(aCodigoProducto, aEjercicio, aPeriodo, aCodigoClasificacion1, aCodigoClasificacion2, aCodigoClasificacion3, aCodigoClasificacion4, aCodigoClasificacion5, aCodigoClasificacion6, aNombreBitacora, aSobreEscribirBitacora, aEsCalculoArimetico);
        }

        public int fRegresaPrecioVenta(string aCodigoConcepto, string aCodigoCliente, string aCodigoProducto, StringBuilder aPrecioVenta)
        {
            return ComercialSdk.fRegresaPrecioVenta(aCodigoConcepto, aCodigoCliente, aCodigoProducto, aPrecioVenta);
        }

        public int fBuscaProducto(string aCodProducto)
        {
            return ComercialSdk.fBuscaProducto(aCodProducto);
        }

        public int fBuscaIdProducto(int aIdProducto)
        {
            return ComercialSdk.fBuscaIdProducto(aIdProducto);
        }

        public int fPosPrimerProducto()
        {
            return ComercialSdk.fPosPrimerProducto();
        }

        public int fPosUltimoProducto()
        {
            return ComercialSdk.fPosUltimoProducto();
        }

        public int fPosSiguienteProducto()
        {
            return ComercialSdk.fPosSiguienteProducto();
        }

        public int fPosAnteriorProducto()
        {
            return ComercialSdk.fPosAnteriorProducto();
        }

        public int fPosBOFProducto()
        {
            return ComercialSdk.fPosBOFProducto();
        }

        public int fPosEOFProducto()
        {
            return ComercialSdk.fPosEOFProducto();
        }

        public int fActualizaProducto(ref int aCodigoProducto, tProducto astProducto)
        {
            return ComercialSdk.fActualizaProducto(ref aCodigoProducto, astProducto);
        }

        public int fLlenaRegistroProducto(tProducto astProducto, int aEsAlta)
        {
            return ComercialSdk.fLlenaRegistroProducto(astProducto, aEsAlta);
        }

        #endregion Productos

        #region Addendas

        public int fInsertaDatoCompEducativo(int aIdServicio, int aNumCampo, StringBuilder aDato)
        {
            return ComercialSdk.fInsertaDatoCompEducativo(aIdServicio, aNumCampo, aDato);
        }

        public int fInsertaDatoAddendaDocto(int aIdAddenda, int aIdCatalogo, int aNumCampo, StringBuilder aDato)
        {
            return ComercialSdk.fInsertaDatoAddendaDocto(aIdAddenda, aIdCatalogo, aNumCampo, aDato);
        }

        public int fInsertaDatoAddendaMovto(int aIdAddenda, int aIdCatalogo, int aNumCampo, StringBuilder aDato)
        {
            return ComercialSdk.fInsertaDatoAddendaMovto(aIdAddenda, aIdCatalogo, aNumCampo, aDato);
        }

        public int fObtenCeryKey(int aIdFirmarl, string aRutaKey, string aRutaCer)
        {
            return ComercialSdk.fObtenCeryKey(aIdFirmarl, aRutaKey, aRutaCer);
        }

        public int fObtieneLicencia(StringBuilder aCodAcvtiva, StringBuilder aCodSitio, StringBuilder aSerie, StringBuilder aTagVersion)
        {
            return ComercialSdk.fObtieneLicencia(aCodAcvtiva, aCodSitio, aSerie, aTagVersion);
        }

        public int fObtienePassProxy(StringBuilder aPassProxy)
        {
            return ComercialSdk.fObtienePassProxy(aPassProxy);
        }

        public int fTimbraXML(StringBuilder aRutaXML, StringBuilder aCodCOncepto, StringBuilder aUUID, StringBuilder aRutaDDA, StringBuilder aRutaResultado, StringBuilder aPass, StringBuilder aRutaFormato)
        {
            return ComercialSdk.fTimbraXML(aRutaXML, aCodCOncepto, aUUID, aRutaDDA, aRutaResultado, aPass, aRutaFormato);
        }

        public int fTimbraNominaXML(StringBuilder aRutaXML, StringBuilder aCodCOncepto, StringBuilder aUUID, StringBuilder aRutaDDA, StringBuilder aRutaResultado, StringBuilder aPass, StringBuilder aRutaFormato)
        {
            return ComercialSdk.fTimbraNominaXML(aRutaXML, aCodCOncepto, aUUID, aRutaDDA, aRutaResultado, aPass, aRutaFormato);
        }

        public int fTimbraComplementoXML(string aRutaXML, string aCodCOncepto, string aUUID, string aRutaDDA, string aRutaResultado, string aPass, string aRutaFormato, int aComplemento)
        {
            return ComercialSdk.fTimbraComplementoXML(aRutaXML, aCodCOncepto, aUUID, aRutaDDA, aRutaResultado, aPass, aRutaFormato, aComplemento);
        }

        public int fCancelaUUID(string aUUID, string aIdDConcepto, string aPass)
        {
            return ComercialSdk.fCancelaUUID(aUUID, aIdDConcepto, aPass);
        }

        public int fCancelaNominaUUID(string aUUID, string aIdDConcepto, string aPass)
        {
            return ComercialSdk.fCancelaNominaUUID(aUUID, aIdDConcepto, aPass);
        }

        #endregion Addendas

        #region Direcciones

        public int fInsertaDireccion()
        {
            return ComercialSdk.fInsertaDireccion();
        }

        public int fEditaDireccion()
        {
            return ComercialSdk.fEditaDireccion();
        }

        public int fGuardaDireccion()
        {
            return ComercialSdk.fGuardaDireccion();
        }

        public int fCancelarModificacionDireccion()
        {
            return ComercialSdk.fCancelarModificacionDireccion();
        }

        public int fLeeDatoDireccion(string aCampo, StringBuilder aValor, int aLen)
        {
            return ComercialSdk.fLeeDatoDireccion(aCampo, aValor, aLen);
        }

        public int fSetDatoDireccion(string aCampo, string aValor)
        {
            return ComercialSdk.fSetDatoDireccion(aCampo, aValor);
        }

        public int fBuscaDireccionEmpresa()
        {
            return ComercialSdk.fBuscaDireccionEmpresa();
        }

        public int fBuscaDireccionCteProv(string aCodCteProv, int aTipoDireccion)
        {
            return ComercialSdk.fBuscaDireccionCteProv(aCodCteProv, aTipoDireccion);
        }

        public int fBuscaDireccionDocumento(int aIdDocumento, int aTipoDireccion)
        {
            return ComercialSdk.fBuscaDireccionDocumento(aIdDocumento, aTipoDireccion);
        }

        public int fPosPrimerDireccion()
        {
            return ComercialSdk.fPosPrimerDireccion();
        }

        public int fPosUltimaDireccion()
        {
            return ComercialSdk.fPosUltimaDireccion();
        }

        public int fPosSiguienteDireccion()
        {
            return ComercialSdk.fPosSiguienteDireccion();
        }

        public int fPosAnteriorDireccion()
        {
            return ComercialSdk.fPosAnteriorDireccion();
        }

        public int fPosBOFDireccion()
        {
            return ComercialSdk.fPosBOFDireccion();
        }

        public int fPosEOFDireccion()
        {
            return ComercialSdk.fPosEOFDireccion();
        }

        public int fAltaDireccion(ref int aIdDireccion, ref tDireccion astDireccion)
        {
            return ComercialSdk.fAltaDireccion(ref aIdDireccion, ref astDireccion);
        }

        public int fActualizaDireccion(ref tDireccion astDireccion)
        {
            return ComercialSdk.fActualizaDireccion(ref astDireccion);
        }

        public int fLlenaRegistroDireccion(ref tDireccion astDireccion, int aEsAlta)
        {
            return ComercialSdk.fLlenaRegistroDireccion(ref astDireccion, aEsAlta);
        }

        #endregion Direcciones

        #region Existencias

        public int fRegresaExistencia(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, ref double aExistencia)
        {
            return ComercialSdk.fRegresaExistencia(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, ref aExistencia);
        }

        public int fRegresaExistenciaCaracteristicas(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, ref double aExistencia)
        {
            return ComercialSdk.fRegresaExistenciaCaracteristicas(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, aValorCaracteristica1, aValorCaracteristica2, aValorCaracteristica3, ref aExistencia);
        }

        #endregion Existencias

        #region Costo Historico

        public int fRegresaCostoPromedio(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, StringBuilder aCostoPromedio)
        {
            return ComercialSdk.fRegresaCostoPromedio(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, aCostoPromedio);
        }

        public int fRegresaUltimoCosto(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, StringBuilder aUltimoCosto)
        {
            return ComercialSdk.fRegresaUltimoCosto(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, aUltimoCosto);
        }

        public int fRegresaCostoEstandar(string aCodigoProducto, StringBuilder aCostoEstandar)
        {
            return ComercialSdk.fRegresaCostoEstandar(aCodigoProducto, aCostoEstandar);
        }

        public int fRegresaCostoCapa(string aCodigoProducto, string aCodigoAlmacen, double aUnidades, StringBuilder aImporteCosto)
        {
            return ComercialSdk.fRegresaCostoCapa(aCodigoProducto, aCodigoAlmacen, aUnidades, aImporteCosto);
        }

        #endregion Costo Historico

        #region Conceptos De Documentos

        public int fLeeDatoConceptoDocto(string aCampo, StringBuilder aValor, int aLen)
        {
            return ComercialSdk.fLeeDatoConceptoDocto(aCampo, aValor, aLen);
        }

        public int fRegresPorcentajeImpuesto(int aIdConceptoDocumento, int aIdClienteProveedor, int aIdProducto, ref double aPorcentajeImpuesto)
        {
            return ComercialSdk.fRegresPorcentajeImpuesto(aIdConceptoDocumento, aIdClienteProveedor, aIdProducto, ref aPorcentajeImpuesto);
        }

        public int fEditaConceptoDocto()
        {
            return ComercialSdk.fEditaConceptoDocto();
        }

        public int fSetDatoConceptoDocto(StringBuilder aCampo, StringBuilder aValor)
        {
            return ComercialSdk.fSetDatoConceptoDocto(aCampo, aValor);
        }

        public int fGuardaConceptoDocto()
        {
            return ComercialSdk.fGuardaConceptoDocto();
        }

        public int fBuscaConceptoDocto(string aCodConcepto)
        {
            return ComercialSdk.fBuscaConceptoDocto(aCodConcepto);
        }

        public int fBuscaIdConceptoDocto(int aIdConcepto)
        {
            return ComercialSdk.fBuscaIdConceptoDocto(aIdConcepto);
        }

        public int fPosPrimerConceptoDocto()
        {
            return ComercialSdk.fPosPrimerConceptoDocto();
        }

        public int fPosUltimaConceptoDocto()
        {
            return ComercialSdk.fPosUltimaConceptoDocto();
        }

        public int fPosSiguienteConceptoDocto()
        {
            return ComercialSdk.fPosSiguienteConceptoDocto();
        }

        public int fPosAnteriorConceptoDocto()
        {
            return ComercialSdk.fPosAnteriorConceptoDocto();
        }

        public int fPosBOFConceptoDocto()
        {
            return ComercialSdk.fPosBOFConceptoDocto();
        }

        public int fPosEOFConceptoDocto()
        {
            return ComercialSdk.fPosEOFConceptoDocto();
        }

        #endregion Conceptos De Documentos

        #region Paramentros

        public int fEditaParametros()
        {
            return ComercialSdk.fEditaParametros();
        }

        public int fLeeDatoParametros(string aCampo, StringBuilder aValor, int aLen)
        {
            return ComercialSdk.fLeeDatoParametros(aCampo, aValor, aLen);
        }

        public int fGuardaParametros()
        {
            return ComercialSdk.fGuardaParametros();
        }

        public int fSetDatoParametros(string aCampo, StringBuilder aValor)
        {
            return ComercialSdk.fSetDatoParametros(aCampo, aValor);
        }

        #endregion Paramentros

        #region Catalago De Clasificaciones

        public int fEditaClasificacion()
        {
            return ComercialSdk.fEditaClasificacion();
        }

        public int fGuardaClasificacion()
        {
            return ComercialSdk.fGuardaClasificacion();
        }

        public int fCancelarModificacionClasificacion()
        {
            return ComercialSdk.fGuardaClasificacion();
        }

        public int fActualizaClasificacion(int aClasificacionDe, int aNumClasificacion, string aNombreClasificacion)
        {
            return ComercialSdk.fActualizaClasificacion(aClasificacionDe, aNumClasificacion, aNombreClasificacion);
        }

        public int fLeeDatoClasificacion(string aCampo, StringBuilder aValor, int aLen)
        {
            return ComercialSdk.fLeeDatoClasificacion(aCampo, aValor, aLen);
        }

        public int fSetDatoClasificacion(string aCampo, string aValor)
        {
            return ComercialSdk.fSetDatoClasificacion(aCampo, aValor);
        }

        public int fBuscaClasificacion(int aClasificacionDe, int aNumClasificacion)
        {
            return ComercialSdk.fBuscaClasificacion(aClasificacionDe, aNumClasificacion);
        }

        public int fBuscaIdClasificacion(int aIdClasificacion)
        {
            return ComercialSdk.fBuscaIdClasificacion(aIdClasificacion);
        }

        public int fPosPrimerClasificacion()
        {
            return ComercialSdk.fPosPrimerClasificacion();
        }

        public int fPosUltimoClasificacion()
        {
            return ComercialSdk.fPosUltimoClasificacion();
        }

        public int fPosSiguienteClasificacion()
        {
            return ComercialSdk.fPosSiguienteClasificacion();
        }

        public int fPosAnteriorClasificacion()
        {
            return ComercialSdk.fPosAnteriorClasificacion();
        }

        public int fPosBOFClasificacion()
        {
            return ComercialSdk.fPosBOFClasificacion();
        }

        public int fPosEOFClasificacion()
        {
            return ComercialSdk.fPosEOFClasificacion();
        }

        #endregion Catalago De Clasificaciones

        #region Catalogo De Valores De Clasificaciones

        public int fInsertaValorClasif()
        {
            return ComercialSdk.fInsertaValorClasif();
        }

        public int fEditaValorClasif()
        {
            return ComercialSdk.fEditaValorClasif();
        }

        public int fGuardaValorClasif()
        {
            return ComercialSdk.fEditaValorClasif();
        }

        public int fBorraValorClasif()
        {
            return ComercialSdk.fBorraValorClasif();
        }

        public int fCancelarModificacionValorClasif()
        {
            return ComercialSdk.fBorraValorClasif();
        }

        public int fEliminarValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodigoValorClasif)
        {
            return ComercialSdk.fEliminarValorClasif(aClasificacionDe, aNumClasificacion, aCodigoValorClasif);
        }

        public int fSetDatoValorClasif(string aCampo, string aValor)
        {
            return ComercialSdk.fSetDatoValorClasif(aCampo, aValor);
        }

        public int fLeeDatoValorClasif(string aCampo, StringBuilder aValor, int aLen)
        {
            return ComercialSdk.fLeeDatoValorClasif(aCampo, aValor, aLen);
        }

        public int fBuscaValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodValorClasif)
        {
            return ComercialSdk.fBuscaValorClasif(aClasificacionDe, aNumClasificacion, aCodValorClasif);
        }

        public int fBuscaIdValorClasif(int aIdValorClasif)
        {
            return ComercialSdk.fBuscaIdValorClasif(aIdValorClasif);
        }

        public int fPosPrimerValorClasif()
        {
            return ComercialSdk.fPosPrimerValorClasif();
        }

        public int fPosUltimoValorClasif()
        {
            return ComercialSdk.fPosUltimoValorClasif();
        }

        public int fPosSiguienteValorClasif()
        {
            return ComercialSdk.fPosSiguienteValorClasif();
        }

        public int fPosAnteriorValorClasif()
        {
            return ComercialSdk.fPosAnteriorValorClasif();
        }

        public int fPosBOFValorClasif()
        {
            return ComercialSdk.fPosBOFValorClasif();
        }

        public int fPosEOFValorClasif()
        {
            return ComercialSdk.fPosEOFValorClasif();
        }

        public int fAltaValorClasif(ref int aIdValorClasif, ref tValorClasificacion astValorClasif)
        {
            return ComercialSdk.fAltaValorClasif(ref aIdValorClasif, ref astValorClasif);
        }

        public int fActualizaValorClasif(string aCodigoValorClasif, ref tValorClasificacion astValorClasif)
        {
            return ComercialSdk.fActualizaValorClasif(aCodigoValorClasif, ref astValorClasif);
        }

        public int fLlenaRegistroValorClasif(ref tValorClasificacion astValorClasif)
        {
            return ComercialSdk.fLlenaRegistroValorClasif(ref astValorClasif);
        }

        #endregion Catalogo De Valores De Clasificaciones

        #region Catalogo De Unidades De Medida Y Peso

        public int fInsertaUnidad()
        {
            return ComercialSdk.fInsertaUnidad();
        }

        public int fEditaUnidad()
        {
            return ComercialSdk.fEditaUnidad();
        }

        public int fGuardaUnidad()
        {
            return ComercialSdk.fGuardaUnidad();
        }

        public int fBorraUnidad()
        {
            return ComercialSdk.fBorraUnidad();
        }

        public int fCancelarModificacionUnidad()
        {
            return ComercialSdk.fBorraUnidad();
        }

        public int fEliminarUnidad(string aNombreUnidad)
        {
            return ComercialSdk.fEliminarUnidad(aNombreUnidad);
        }

        public int fLeeDatoUnidad(string aCampo, StringBuilder aValor, int aLen)
        {
            return ComercialSdk.fLeeDatoUnidad(aCampo, aValor, aLen);
        }

        public int fSetDatoUnidad(string aCampo, string aValor)
        {
            return ComercialSdk.fSetDatoUnidad(aCampo, aValor);
        }

        public int fBuscaUnidad(string aNombreUnidad)
        {
            return ComercialSdk.fBuscaUnidad(aNombreUnidad);
        }

        public int fBuscaIdUnidad(int aIdUnidad)
        {
            return ComercialSdk.fBuscaIdUnidad(aIdUnidad);
        }

        public int fPosPrimerUnidad()
        {
            return ComercialSdk.fPosPrimerUnidad();
        }

        public int fPosUltimoUnidad()
        {
            return ComercialSdk.fPosUltimoUnidad();
        }

        public int fPosSiguienteUnidad()
        {
            return ComercialSdk.fPosSiguienteUnidad();
        }

        public int fPosAnteriorUnidad()
        {
            return ComercialSdk.fPosAnteriorUnidad();
        }

        public int fPosBOFUnidad()
        {
            return ComercialSdk.fPosBOFUnidad();
        }

        public int fPosEOFUnidad()
        {
            return ComercialSdk.fPosBOFUnidad();
        }

        public int fAltaUnidad(ref int aIdUnidad, ref tUnidad astUnidad)
        {
            return ComercialSdk.fAltaUnidad(ref aIdUnidad, ref astUnidad);
        }

        public int fActualizaUnidad(string aNombreUnidad, ref tUnidad astUnidad)
        {
            return ComercialSdk.fActualizaUnidad(aNombreUnidad, ref astUnidad);
        }

        public int fLlenaRegistroUnidad(ref tUnidad astUnidad)
        {
            return ComercialSdk.fLlenaRegistroUnidad(ref astUnidad);
        }

        #endregion Catalogo De Unidades De Medida Y Peso

        #region Catalogo De Agentes

        public int fInsertaAgente()
        {
            return ComercialSdk.fInsertaAgente();
        }

        public int fEditaAgente()
        {
            return ComercialSdk.fEditaAgente();
        }

        public int fGuardaAgente()
        {
            return ComercialSdk.fGuardaAgente();
        }

        public int fCancelarModificacionAgente()
        {
            return ComercialSdk.fCancelarModificacionAgente();
        }

        public int fSetDatoAgente(string aCampo, string aValor)
        {
            return ComercialSdk.fCancelarModificacionAgente();
        }

        public int fLeeDatoAgente(string aCampo, StringBuilder aValor, int aLen)
        {
            return ComercialSdk.fLeeDatoAgente(aCampo, aValor, aLen);
        }

        public int fBuscaAgente(string aCodigoAgente)
        {
            return ComercialSdk.fBuscaAgente(aCodigoAgente);
        }

        public int fBuscaIdAgente(int aIdAgente)
        {
            return ComercialSdk.fBuscaIdAgente(aIdAgente);
        }

        public int fPosPrimerAgente()
        {
            return ComercialSdk.fPosPrimerAgente();
        }

        public int fPosUltimoAgente()
        {
            return ComercialSdk.fPosUltimoAgente();
        }

        public int fPosSiguienteAgente()
        {
            return ComercialSdk.fPosSiguienteAgente();
        }

        public int fPosAnteriorAgente()
        {
            return ComercialSdk.fPosAnteriorAgente();
        }

        public int fPosBOFAgente()
        {
            return ComercialSdk.fPosBOFAgente();
        }

        public int fPosEOFAgente()
        {
            return ComercialSdk.fPosEOFAgente();
        }

        #endregion Catalogo De Agentes

        #region Catalago De Almacenes

        public int fInsertaAlmacen()
        {
            return ComercialSdk.fInsertaAlmacen();
        }

        public int fEditaAlmacen()
        {
            return ComercialSdk.fEditaAlmacen();
        }

        public int fGuardaAlmacen()
        {
            return ComercialSdk.fGuardaAlmacen();
        }

        public int fCancelarModificacionAlmacen()
        {
            return ComercialSdk.fCancelarModificacionAlmacen();
        }

        public int fLeeDatoAlmacen(string aCampo, StringBuilder aValor, int aLen)
        {
            return ComercialSdk.fLeeDatoAlmacen(aCampo, aValor, aLen);
        }

        public int fSetDatoAlmacen(string aCampo, string aValor)
        {
            return ComercialSdk.fSetDatoAlmacen(aCampo, aValor);
        }

        public int fBuscaAlmacen(string aCodigoAlmacen)
        {
            return ComercialSdk.fBuscaAlmacen(aCodigoAlmacen);
        }

        public int fBuscaIdAlmacen(int aIdAlmacen)
        {
            return ComercialSdk.fBuscaIdAlmacen(aIdAlmacen);
        }

        public int fPosPrimerAlmacen()
        {
            return ComercialSdk.fPosPrimerAlmacen();
        }

        public int fPosUltimoAlmacen()
        {
            return ComercialSdk.fPosUltimoAlmacen();
        }

        public int fPosSiguienteAlmacen()
        {
            return ComercialSdk.fPosSiguienteAlmacen();
        }

        public int fPosAnteriorAlmacen()
        {
            return ComercialSdk.fPosAnteriorAlmacen();
        }

        public int fPosBOFAlmacen()
        {
            return ComercialSdk.fPosBOFAlmacen();
        }

        public int fPosEOFAlmacen()
        {
            return ComercialSdk.fPosEOFAlmacen();
        }

        #endregion Catalago De Almacenes

        #region Movimientos Contables

        public int fEditaMovtoContable()
        {
            return ComercialSdk.fEditaMovtoContable();
        }

        public int fGuardaMovtoContable()
        {
            return ComercialSdk.fGuardaMovtoContable();
        }

        public int fLeeDatoMovtoContable(string aCampo, StringBuilder aValor, int aLen)
        {
            return ComercialSdk.fLeeDatoMovtoContable(aCampo, aValor, aLen);
        }

        public int fSetDatoMovtoContable(string aCampo, string aValor)
        {
            return ComercialSdk.fSetDatoMovtoContable(aCampo, aValor);
        }

        public int fPosPrimerMovtoContable()
        {
            return ComercialSdk.fPosPrimerMovtoContable();
        }

        public int fPosSiguienteMovtoContable()
        {
            return ComercialSdk.fPosSiguienteMovtoContable();
        }

        public int fPosEOFMovtoContable()
        {
            return ComercialSdk.fPosEOFMovtoContable();
        }

        #endregion Movimientos Contables
    }
}
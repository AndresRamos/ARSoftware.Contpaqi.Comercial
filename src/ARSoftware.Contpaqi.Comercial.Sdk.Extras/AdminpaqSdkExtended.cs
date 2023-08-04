using System;
using System.IO;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras;

public class AdminpaqSdkExtended : IContpaqiSdk
{
    public int fAbreEmpresa(string aDirectorioEmpresa)
    {
        return AdminpaqSdk.fAbreEmpresa(aDirectorioEmpresa);
    }

    public int fActivarPrecioCompra(int aActivar)
    {
        return AdminpaqSdk.fActivarPrecioCompra(aActivar);
    }

    public int fActualizaClasificacion(int aClasificacionDe, int aNumClasificacion, string aNombreClasificacion)
    {
        return AdminpaqSdk.fActualizaClasificacion(aClasificacionDe, aNumClasificacion, aNombreClasificacion);
    }

    public int fActualizaCteProv(string aCodigoCteProv, ref tCteProv astCteProv)
    {
        return AdminpaqSdk.fActualizaCteProv(aCodigoCteProv, ref astCteProv);
    }

    public int fActualizaDireccion(ref tDireccion astDireccion)
    {
        return AdminpaqSdk.fActualizaDireccion(ref astDireccion);
    }

    public int fActualizaProducto(string aCodigoProducto, ref tProducto astProducto)
    {
        return AdminpaqSdk.fActualizaProducto(aCodigoProducto, ref astProducto);
    }

    public int fActualizaUnidad(string aNombreUnidad, ref tUnidad astUnidad)
    {
        return AdminpaqSdk.fActualizaUnidad(aNombreUnidad, ref astUnidad);
    }

    public int fActualizaValorClasif(string aCodigoValorClasif, ref tValorClasificacion astValorClasif)
    {
        return AdminpaqSdk.fActualizaValorClasif(aCodigoValorClasif, ref astValorClasif);
    }

    public int fAfectaDocto(ref tLlaveDoc aLlaveDocto, bool aAfecta)
    {
        return AdminpaqSdk.fAfectaDocto(ref aLlaveDocto, aAfecta);
    }

    public int fAfectaDocto_Param(string aCodConcepto, string aSerie, double aFolio, bool aAfecta)
    {
        return AdminpaqSdk.fAfectaDocto_Param(aCodConcepto, aSerie, aFolio, aAfecta);
    }

    public int fAfectaSerie(int aIdMovto, string aNumeroSerie)
    {
        return AdminpaqSdk.fAfectaSerie(aIdMovto, aNumeroSerie);
    }

    public int fAgregarRelacionCFDI(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion, string aConceptoRelacionar,
        string aSerieRelacionar, string aFolioRelacionar)
    {
        return AdminpaqSdk.fAgregarRelacionCFDI(aCodConcepto, aSerie, aFolio, aTipoRelacion, aConceptoRelacionar, aSerieRelacionar,
            aFolioRelacionar);
    }

    public int fAgregarRelacionCFDI2(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion, string aUUID)
    {
        return AdminpaqSdk.fAgregarRelacionCFDI2(aCodConcepto, aSerie, aFolio, aTipoRelacion, aUUID);
    }

    public int fAltaCteProv(ref int aIdCteProv, ref tCteProv astCteProv)
    {
        return AdminpaqSdk.fAltaCteProv(ref aIdCteProv, ref astCteProv);
    }

    public int fAltaCuentaBancariaCliente(ref int aIdCtaBancaria, string aCuentaBancaria, string aNombreCuenta, string aNombreMoneda,
        string aClaveBanco, string aClabe, string aRfcBanco, string aNombreBancoExtranjero, string aCodigoCliente)
    {
        throw new NotImplementedException();
    }

    public int fAltaCuentaBancariaEmpresa(ref int aIdCtaBancaria, string aCuentaBancaria, string aNombreCuenta, string aNombreMoneda,
        string aClaveBanco, string aClabe, string aRfcBanco, string aNombreBancoExtranjero)
    {
        throw new NotImplementedException();
    }

    public int fAltaDireccion(ref int aIdDireccion, ref tDireccion astDireccion)
    {
        return AdminpaqSdk.fAltaDireccion(ref aIdDireccion, ref astDireccion);
    }

    public int fAltaDoctoAjusteIESPSCteProv(string aCodigoClienteProveedor, int aEsCliente, string aFechaDocto, int aIdMoneda,
        double aTipoCambio, double aImporteIVA, double aTasaIVA, double aImporteIESPS, double aTasaIESPS, int aIdFacturaBase,
        string aMetodo, string aLugar, ref int aIdDoctoGenerado)
    {
        return AdminpaqSdk.fAltaDoctoAjusteIESPSCteProv(aCodigoClienteProveedor, aEsCliente, aFechaDocto, aIdMoneda, aTipoCambio,
            aImporteIVA, aTasaIVA, aImporteIESPS, aTasaIESPS, aIdFacturaBase, aMetodo, aLugar, ref aIdDoctoGenerado);
    }

    public int fAltaDoctoAjusteIVAClienteProveedor(string aCodigoClienteProveedor, int aEsCliente, int aAbsorberAjusteIVA,
        string aFechaDocto, int aIdMoneda, double aTipoCambio, double aImporteIVA, double aTasaIVA, int aIdFacturaBase, string aMetodo,
        string aLugar, ref int aIdDoctoGenerado)
    {
        return AdminpaqSdk.fAltaDoctoAjusteIVAClienteProveedor(aCodigoClienteProveedor, aEsCliente, aAbsorberAjusteIVA, aFechaDocto,
            aIdMoneda, aTipoCambio, aImporteIVA, aTasaIVA, aIdFacturaBase, aMetodo, aLugar, ref aIdDoctoGenerado);
    }

    public int fAltaDocumento(ref int aIdDocumento, ref tDocumento aDocumento)
    {
        return AdminpaqSdk.fAltaDocumento(ref aIdDocumento, ref aDocumento);
    }

    public int fAltaDocumentoCargoAbono(ref tDocumento aDocumento)
    {
        return AdminpaqSdk.fAltaDocumentoCargoAbono(ref aDocumento);
    }

    public int fAltaDocumentoCargoAbonoExtras(ref tDocumento aDocumento, string aTextoExtra1, string aTextoExtra2, string aTextoExtra3,
        string aFechaExtra, double aImporteExtra1, double aImporteExtra2, double aImporteExtra3, double aImporteExtra4)
    {
        return AdminpaqSdk.fAltaDocumentoCargoAbonoExtras(ref aDocumento, aTextoExtra1, aTextoExtra2, aTextoExtra3, aFechaExtra,
            aImporteExtra1, aImporteExtra2, aImporteExtra3, aImporteExtra4);
    }

    public int fAltaMovimiento(int aIdDocumento, ref int aIdMovimiento, ref tMovimiento astMovimiento)
    {
        return AdminpaqSdk.fAltaMovimiento(aIdDocumento, ref aIdMovimiento, ref astMovimiento);
    }

    public int fAltaMovimientoCaracteristicas(int aIdMovimiento, ref int aIdMovtoCaracteristicas, ref tCaracteristicas aCaracteristicas)
    {
        return AdminpaqSdk.fAltaMovimientoCaracteristicas(aIdMovimiento, ref aIdMovtoCaracteristicas, ref aCaracteristicas);
    }

    public int fAltaMovimientoCaracteristicas_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidades,
        string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3)
    {
        return AdminpaqSdk.fAltaMovimientoCaracteristicas_Param(aIdMovimiento, aIdMovtoCaracteristicas, aUnidades, aValorCaracteristica1,
            aValorCaracteristica2, aValorCaracteristica3);
    }

    public int fAltaMovimientoCDesct(int aIdDocumento, ref int aIdMovimiento, ref tMovimientoDesc astMovimiento)
    {
        return AdminpaqSdk.fAltaMovimientoCDesct(aIdDocumento, ref aIdMovimiento, ref astMovimiento);
    }

    public int fAltaMovimientoEx(ref int aIdMovimiento, ref tTipoProducto aTipoProducto)
    {
        return AdminpaqSdk.fAltaMovimientoEx(ref aIdMovimiento, ref aTipoProducto);
    }

    public int fAltaMovimientoSeriesCapas(int aIdMovimiento, ref tSeriesCapas aSeriesCapas)
    {
        return AdminpaqSdk.fAltaMovimientoSeriesCapas(aIdMovimiento, ref aSeriesCapas);
    }

    public int fAltaMovimientoSeriesCapas_Param(string aIdMovimiento, string aUnidades, string aTipoCambio, string aSeries,
        string aPedimento, string aAgencia, string aFechaPedimento, string aNumeroLote, string aFechaFabricacion, string aFechaCaducidad)
    {
        return AdminpaqSdk.fAltaMovimientoSeriesCapas_Param(aIdMovimiento, aUnidades, aTipoCambio, aSeries, aPedimento, aAgencia,
            aFechaPedimento, aNumeroLote, aFechaFabricacion, aFechaCaducidad);
    }

    public int fAltaMovtoCaracteristicasUnidades(int aIdMovimiento, ref int aIdMovtoCaracteristicas,
        ref tCaracteristicas aCaracteristicasUnidades)
    {
        return AdminpaqSdk.fAltaMovtoCaracteristicasUnidades(aIdMovimiento, ref aIdMovtoCaracteristicas, ref aCaracteristicasUnidades);
    }

    public int fAltaMovtoCaracteristicasUnidades_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidad,
        string aUnidades, string aUnidadesNC, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3)
    {
        return AdminpaqSdk.fAltaMovtoCaracteristicasUnidades_Param(aIdMovimiento, aIdMovtoCaracteristicas, aUnidad, aUnidades, aUnidadesNC,
            aValorCaracteristica1, aValorCaracteristica2, aValorCaracteristica3);
    }

    public int fAltaProducto(ref int aIdProducto, ref tProducto astProducto)
    {
        return AdminpaqSdk.fAltaProducto(ref aIdProducto, ref astProducto);
    }

    public int fAltaUnidad(ref int aIdUnidad, ref tUnidad astUnidad)
    {
        return AdminpaqSdk.fAltaUnidad(ref aIdUnidad, ref astUnidad);
    }

    public int fAltaValorClasif(ref int aIdValorClasif, ref tValorClasificacion astValorClasif)
    {
        return AdminpaqSdk.fAltaValorClasif(ref aIdValorClasif, ref astValorClasif);
    }

    public int fBorraCteProv()
    {
        return AdminpaqSdk.fBorraCteProv();
    }

    public int fBorraCuentaBancariaCliente(string aCuentaBancaria, string aCodigoCliente)
    {
        throw new NotImplementedException();
    }

    public int fBorraCuentaBancariaEmpresa(string aCuentaBancaria)
    {
        throw new NotImplementedException();
    }

    public int fBorraDocumento()
    {
        return AdminpaqSdk.fBorraDocumento();
    }

    public int fBorraDocumento_CW()
    {
        return AdminpaqSdk.fBorraDocumento_CW();
    }

    public int fBorraMovimiento(int aIdDocumento, int aIdMovimiento)
    {
        throw new NotImplementedException();
    }

    public int fBorraProducto()
    {
        return AdminpaqSdk.fBorraProducto();
    }

    public int fBorrarAsociacion(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago)
    {
        return AdminpaqSdk.fBorrarAsociacion(aDoctoaPagar, aDoctoPago);
    }

    public int fBorrarAsociacion_Param(string aCodConcepto_Pagar, string aSerie_Pagar, double aFolio_Pagar, string aCodConcepto_Pago,
        string aSerie_Pago, double aFolio_Pago)
    {
        return AdminpaqSdk.fBorrarAsociacion_Param(aCodConcepto_Pagar, aSerie_Pagar, aFolio_Pagar, aCodConcepto_Pago, aSerie_Pago,
            aFolio_Pago);
    }

    public int fBorraUnidad()
    {
        return AdminpaqSdk.fBorraUnidad();
    }

    public int fBorraValorClasif()
    {
        return AdminpaqSdk.fBorraValorClasif();
    }

    public int fBuscaAgente(string aCodigoAgente)
    {
        return AdminpaqSdk.fBuscaAgente(aCodigoAgente);
    }

    public int fBuscaAlmacen(string aCodigoAlmacen)
    {
        return AdminpaqSdk.fBuscaAlmacen(aCodigoAlmacen);
    }

    public int fBuscaClasificacion(int aClasificacionDe, int aNumClasificacion)
    {
        return AdminpaqSdk.fBuscaClasificacion(aClasificacionDe, aNumClasificacion);
    }

    public int fBuscaConceptoDocto(string aCodConcepto)
    {
        return AdminpaqSdk.fBuscaConceptoDocto(aCodConcepto);
    }

    public int fBuscaCteProv(string aCodCteProv)
    {
        return AdminpaqSdk.fBuscaCteProv(aCodCteProv);
    }

    public int fBuscaDireccionCteProv(string aCodCteProv, byte aTipoDireccion)
    {
        return AdminpaqSdk.fBuscaDireccionCteProv(aCodCteProv, aTipoDireccion);
    }

    public int fBuscaDireccionDocumento(int aIdDocumento, byte aTipoDireccion)
    {
        return AdminpaqSdk.fBuscaDireccionDocumento(aIdDocumento, aTipoDireccion);
    }

    public int fBuscaDireccionEmpresa()
    {
        return AdminpaqSdk.fBuscaDireccionEmpresa();
    }

    public int fBuscaDocumento(ref tLlaveDoc aLlaveDocto)
    {
        return AdminpaqSdk.fBuscaDocumento(ref aLlaveDocto);
    }

    public int fBuscaIdAgente(int aIdAgente)
    {
        return AdminpaqSdk.fBuscaIdAgente(aIdAgente);
    }

    public int fBuscaIdAlmacen(int aIdAlmacen)
    {
        return AdminpaqSdk.fBuscaIdAlmacen(aIdAlmacen);
    }

    public int fBuscaIdClasificacion(int aIdClasificacion)
    {
        return AdminpaqSdk.fBuscaIdClasificacion(aIdClasificacion);
    }

    public int fBuscaIdConceptoDocto(int aIdConcepto)
    {
        return AdminpaqSdk.fBuscaIdConceptoDocto(aIdConcepto);
    }

    public int fBuscaIdCteProv(int aIdCteProv)
    {
        return AdminpaqSdk.fBuscaIdCteProv(aIdCteProv);
    }

    public int fBuscaIdProducto(int aIdProducto)
    {
        return AdminpaqSdk.fBuscaIdProducto(aIdProducto);
    }

    public int fBuscaIdUnidad(int aIdUnidad)
    {
        return AdminpaqSdk.fBuscaIdUnidad(aIdUnidad);
    }

    public int fBuscaIdValorClasif(int aIdValorClasif)
    {
        return AdminpaqSdk.fBuscaIdValorClasif(aIdValorClasif);
    }

    public int fBuscaProducto(string aCodProducto)
    {
        return AdminpaqSdk.fBuscaProducto(aCodProducto);
    }

    public int fBuscarDocumento(string aCodConcepto, string aSerie, string aFolio)
    {
        return AdminpaqSdk.fBuscarDocumento(aCodConcepto, aSerie, aFolio);
    }

    public int fBuscarIdDocumento(int aIdDocumento)
    {
        return AdminpaqSdk.fBuscarIdDocumento(aIdDocumento);
    }

    public int fBuscarIdMovimiento(int aIdMovimiento)
    {
        return AdminpaqSdk.fBuscarIdMovimiento(aIdMovimiento);
    }

    public int fBuscaUnidad(string aNombreUnidad)
    {
        return AdminpaqSdk.fBuscaUnidad(aNombreUnidad);
    }

    public int fBuscaValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodValorClasif)
    {
        return AdminpaqSdk.fBuscaValorClasif(aClasificacionDe, aNumClasificacion, aCodValorClasif);
    }

    public int fCalculaMovtoSerieCapa(int aIdMovimiento)
    {
        return AdminpaqSdk.fCalculaMovtoSerieCapa(aIdMovimiento);
    }

    public int fCancelaCambiosMovimiento()
    {
        return AdminpaqSdk.fCancelaCambiosMovimiento();
    }

    public int fCancelaComplementoPagoUUID(string aUUID, string aIdDConcepto, string aPass)
    {
        return AdminpaqSdk.fCancelaComplementoPagoUUID(aUUID, aIdDConcepto, aPass);
    }

    public int fCancelaDoctoInfo(string aPass)
    {
        return AdminpaqSdk.fCancelaDoctoInfo(aPass);
    }

    public int fCancelaDocumento()
    {
        return AdminpaqSdk.fCancelaDocumento();
    }

    public int fCancelaDocumento_CW()
    {
        return AdminpaqSdk.fCancelaDocumento_CW();
    }

    public int fCancelaDocumentoAdministrativamente()
    {
        throw new NotImplementedException();
    }

    public int fCancelaDocumentoConMotivo(string aMotivoCancelacion, string aUUIDRemplaza)
    {
        return AdminpaqSdk.fCancelaDocumentoConMotivo(aMotivoCancelacion, aUUIDRemplaza);
    }

    public int fCancelaFiltroDocumento()
    {
        return AdminpaqSdk.fCancelaFiltroDocumento();
    }

    public int fCancelaFiltroMovimiento()
    {
        return AdminpaqSdk.fCancelaFiltroMovimiento();
    }

    public int fCancelaNominaUUID(string aUUID, string aIdDConcepto, string aPass)
    {
        return AdminpaqSdk.fCancelaNominaUUID(aUUID, aIdDConcepto, aPass);
    }

    public int fCancelarModificacionAgente()
    {
        return AdminpaqSdk.fCancelarModificacionAgente();
    }

    public int fCancelarModificacionAlmacen()
    {
        return AdminpaqSdk.fCancelarModificacionAlmacen();
    }

    public int fCancelarModificacionClasificacion()
    {
        return AdminpaqSdk.fCancelarModificacionClasificacion();
    }

    public int fCancelarModificacionCteProv()
    {
        return AdminpaqSdk.fCancelarModificacionCteProv();
    }

    public int fCancelarModificacionDireccion()
    {
        return AdminpaqSdk.fCancelarModificacionDireccion();
    }

    public int fCancelarModificacionDocumento()
    {
        return AdminpaqSdk.fCancelarModificacionDocumento();
    }

    public int fCancelarModificacionProducto()
    {
        return AdminpaqSdk.fCancelarModificacionProducto();
    }

    public int fCancelarModificacionUnidad()
    {
        return AdminpaqSdk.fCancelarModificacionUnidad();
    }

    public int fCancelarModificacionValorClasif()
    {
        return AdminpaqSdk.fCancelarModificacionValorClasif();
    }

    public int fCancelaUUID(string aUUID, string aIdDConcepto, string aPass)
    {
        return AdminpaqSdk.fCancelaUUID(aUUID, aIdDConcepto, aPass);
    }

    public int fCancelaUUID40(string aUUID, string aMotivoCancelacion, string aUUIDReemplaza, string RFCReceptor, double aTotal,
        string aIdDConcepto, string aPass, ref int aEstatusCancelacion)
    {
        return AdminpaqSdk.fCancelaUUID40(aUUID, aMotivoCancelacion, aUUIDReemplaza, RFCReceptor, aTotal, aIdDConcepto, aPass,
            ref aEstatusCancelacion);
    }

    public void fCierraEmpresa()
    {
        AdminpaqSdk.fCierraEmpresa();
    }

    public int fCuentaBancariaEmpresaDoctos(string aCuentaBancaria)
    {
        throw new NotImplementedException();
    }

    public int fDesbloqueaDocumento()
    {
        throw new NotImplementedException();
    }

    public int fDocumentoBloqueado(ref int aImpreso)
    {
        return AdminpaqSdk.fDocumentoBloqueado(ref aImpreso);
    }

    public int fDocumentoDevuelto(ref int aDevuelto)
    {
        return AdminpaqSdk.fDocumentoDevuelto(ref aDevuelto);
    }

    public int fDocumentoImpreso(ref bool aImpreso)
    {
        return AdminpaqSdk.fDocumentoImpreso(ref aImpreso);
    }

    public int fDocumentoUUID(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, StringBuilder atPtrCFDIUUID)
    {
        return AdminpaqSdk.fDocumentoUUID(aCodConcepto, aSerie, aFolio, atPtrCFDIUUID);
    }

    public int fEditaAgente()
    {
        return AdminpaqSdk.fEditaAgente();
    }

    public int fEditaAlmacen()
    {
        return AdminpaqSdk.fEditaAlmacen();
    }

    public int fEditaClasificacion()
    {
        return AdminpaqSdk.fEditaClasificacion();
    }

    public int fEditaConceptoDocto()
    {
        return AdminpaqSdk.fEditaConceptoDocto();
    }

    public int fEditaCteProv()
    {
        return AdminpaqSdk.fEditaCteProv();
    }

    public int fEditaDireccion()
    {
        return AdminpaqSdk.fEditaDireccion();
    }

    public int fEditaMovtoContable()
    {
        return AdminpaqSdk.fEditaMovtoContable();
    }

    public int fEditaParametros()
    {
        return AdminpaqSdk.fEditaParametros();
    }

    public int fEditaProducto()
    {
        return AdminpaqSdk.fEditaProducto();
    }

    public int fEditarDocumento()
    {
        return AdminpaqSdk.fEditarDocumento();
    }

    public int fEditarDocumentoCheqpaq()
    {
        return AdminpaqSdk.fEditarDocumentoCheqpaq();
    }

    public int fEditarMovimiento()
    {
        return AdminpaqSdk.fEditarMovimiento();
    }

    public int fEditaUnidad()
    {
        return AdminpaqSdk.fEditaUnidad();
    }

    public int fEditaValorClasif()
    {
        return AdminpaqSdk.fEditaValorClasif();
    }

    public int fEliminarCteProv(string aCodigoCteProv)
    {
        return AdminpaqSdk.fEliminarCteProv(aCodigoCteProv);
    }

    public int fEliminarProducto(string aCodigoProducto)
    {
        return AdminpaqSdk.fEliminarProducto(aCodigoProducto);
    }

    public int fEliminarRelacionesCFDIs(string aCodConcepto, string aSerie, string aFolio)
    {
        return AdminpaqSdk.fEliminarRelacionesCFDIs(aCodConcepto, aSerie, aFolio);
    }

    public int fEliminarUnidad(string aNombreUnidad)
    {
        return AdminpaqSdk.fEliminarUnidad(aNombreUnidad);
    }

    public int fEliminarValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodigoValorClasif)
    {
        return AdminpaqSdk.fEliminarValorClasif(aClasificacionDe, aNumClasificacion, aCodigoValorClasif);
    }

    public int fEmitirDocumento(string aCodConcepto, string aSerie, double aFolio, string aPassword, string aArchivoAdicional)
    {
        return AdminpaqSdk.fEmitirDocumento(aCodConcepto, aSerie, aFolio, aPassword, aArchivoAdicional);
    }

    public int fEntregEnDiscoXML(string aCodConcepto, string aSerie, double aFolio, int aFormato, string aFormatoAmig)
    {
        return AdminpaqSdk.fEntregEnDiscoXML(aCodConcepto, aSerie, aFolio, aFormato, aFormatoAmig);
    }

    public void fError(int aNumError, StringBuilder aMensaje, int aLen)
    {
        AdminpaqSdk.fError(aNumError, aMensaje, aLen);
    }

    public int fGetCantidadParcialidades(StringBuilder atPtrPassword, StringBuilder aCantidadParcialidades)
    {
        return AdminpaqSdk.fGetCantidadParcialidades(atPtrPassword, aCantidadParcialidades);
    }

    public int fGetDatosCFDI(StringBuilder aSerieCertEmisor, StringBuilder aFolioFiscalUUID, StringBuilder aSerieCertSAT,
        StringBuilder aFechaHora, StringBuilder aSelloDigCFDI, StringBuilder aSelloSAAT, StringBuilder aCadOrigComplSAT,
        StringBuilder aRegimen, StringBuilder aLugarExpedicion, StringBuilder aMoneda, StringBuilder aFolioFiscalOrig,
        StringBuilder aSerieFolioFiscalOrig, StringBuilder aFechaFolioFiscalOrig, StringBuilder aMontoFolioFiscalOrig)
    {
        throw new NotImplementedException();
    }

    public int fGetNumParcialidades(StringBuilder atPtrPassword, StringBuilder aNumParcialidades)
    {
        return AdminpaqSdk.fGetNumParcialidades(atPtrPassword, aNumParcialidades);
    }

    public int fGetSelloDigitalYCadena(StringBuilder atPtrPassword, StringBuilder atPtrSelloDigital, StringBuilder atPtrCadenaOriginal)
    {
        return AdminpaqSdk.fGetSelloDigitalYCadena(atPtrPassword, atPtrSelloDigital, atPtrCadenaOriginal);
    }

    public int fGetSerieCertificado(StringBuilder atPtrPassword, StringBuilder aSerieCertificado)
    {
        return AdminpaqSdk.fGetSerieCertificado(atPtrPassword, aSerieCertificado);
    }

    public int fGetTamSelloDigitalYCadena(StringBuilder atPtrPassword, ref int aEspSelloDig, ref int aEspCadOrig)
    {
        return AdminpaqSdk.fGetTamSelloDigitalYCadena(atPtrPassword, ref aEspSelloDig, ref aEspCadOrig);
    }

    public int fGuardaAgente()
    {
        return AdminpaqSdk.fGuardaAgente();
    }

    public int fGuardaAlmacen()
    {
        return AdminpaqSdk.fGuardaAlmacen();
    }

    public int fGuardaClasificacion()
    {
        return AdminpaqSdk.fGuardaClasificacion();
    }

    public int fGuardaConceptoDocto()
    {
        return AdminpaqSdk.fGuardaConceptoDocto();
    }

    public int fGuardaCteProv()
    {
        return AdminpaqSdk.fGuardaCteProv();
    }

    public int fGuardaDireccion()
    {
        return AdminpaqSdk.fGuardaDireccion();
    }

    public int fGuardaDocumento()
    {
        return AdminpaqSdk.fGuardaDocumento();
    }

    public int fGuardaMovimiento()
    {
        return AdminpaqSdk.fGuardaMovimiento();
    }

    public int fGuardaMovtoContable()
    {
        return AdminpaqSdk.fGuardaMovtoContable();
    }

    public int fGuardaParametros()
    {
        return AdminpaqSdk.fGuardaParametros();
    }

    public int fGuardaProducto()
    {
        return AdminpaqSdk.fGuardaProducto();
    }

    public int fGuardaUnidad()
    {
        return AdminpaqSdk.fGuardaUnidad();
    }

    public int fGuardaValorClasif()
    {
        return AdminpaqSdk.fGuardaValorClasif();
    }

    public int fInformacionCliente(StringBuilder aCodigo, ref int aPermiteCredito, ref double aLimiteCredito, ref int aLimiteDoctosVencidos,
        ref int aPermiteExcederCredito, StringBuilder aFecha, ref double aSaldo, ref double aSaldoPendiente, ref int aDoctosVencidos)
    {
        return AdminpaqSdk.fInformacionCliente(aCodigo, ref aPermiteCredito, ref aLimiteCredito, ref aLimiteDoctosVencidos,
            ref aPermiteExcederCredito, aFecha, ref aSaldo, ref aSaldoPendiente, ref aDoctosVencidos);
    }

    public int fInicializaLicenseInfo(byte aSistema)
    {
        return AdminpaqSdk.fInicializaLicenseInfo(aSistema);
    }

    public int fInicializaSDK()
    {
        return AdminpaqSdk.fInicializaSDK();
    }

    public void fInicioSesionSDK(string aUsuario, string aContrasenia)
    {
        throw new NotImplementedException();
    }

    public void fInicioSesionSDKCONTPAQi(string aUsuario, string aContrasenia)
    {
        throw new NotImplementedException();
    }

    public int fInsertaAgente()
    {
        return AdminpaqSdk.fInsertaAgente();
    }

    public int fInsertaAlmacen()
    {
        return AdminpaqSdk.fInsertaAlmacen();
    }

    public int fInsertaCteProv()
    {
        return AdminpaqSdk.fInsertaCteProv();
    }

    public int fInsertaDatoAddendaDocto(int aIdAddenda, int aIdCatalogo, int aNumCampo, string aDato)
    {
        return AdminpaqSdk.fInsertaDatoAddendaDocto(aIdAddenda, aIdCatalogo, aNumCampo, aDato);
    }

    public int fInsertaDatoAddendaMovto(int aIdAddenda, int aIdCatalogo, int aNumCampo, string aDato)
    {
        return AdminpaqSdk.fInsertaDatoAddendaMovto(aIdAddenda, aIdCatalogo, aNumCampo, aDato);
    }

    public int fInsertaDatoCompEducativo(int aIdServicio, int aNumCampo, string aDato)
    {
        return AdminpaqSdk.fInsertaDatoCompEducativo(aIdServicio, aNumCampo, aDato);
    }

    public int fInsertaDireccion()
    {
        return AdminpaqSdk.fInsertaDireccion();
    }

    public int fInsertaProducto()
    {
        return AdminpaqSdk.fInsertaProducto();
    }

    public int fInsertarDocumento()
    {
        return AdminpaqSdk.fInsertarDocumento();
    }

    public int fInsertarMovimiento()
    {
        return AdminpaqSdk.fInsertarMovimiento();
    }

    public int fInsertaUnidad()
    {
        return AdminpaqSdk.fInsertaUnidad();
    }

    public int fInsertaValorClasif()
    {
        return AdminpaqSdk.fInsertaValorClasif();
    }

    public int fLeeDatoAgente(string aCampo, StringBuilder aValor, int aLen)
    {
        return AdminpaqSdk.fLeeDatoAgente(aCampo, aValor, aLen);
    }

    public int fLeeDatoAlmacen(string aCampo, StringBuilder aValor, int aLen)
    {
        return AdminpaqSdk.fLeeDatoAlmacen(aCampo, aValor, aLen);
    }

    public int fLeeDatoCFDI(StringBuilder aValor, int aDato)
    {
        return AdminpaqSdk.fLeeDatoCFDI(aValor, aDato);
    }

    public int fLeeDatoClasificacion(string aCampo, StringBuilder aValor, int aLen)
    {
        return AdminpaqSdk.fLeeDatoClasificacion(aCampo, aValor, aLen);
    }

    public int fLeeDatoConceptoDocto(string aCampo, StringBuilder aValor, int aLen)
    {
        return AdminpaqSdk.fLeeDatoConceptoDocto(aCampo, aValor, aLen);
    }

    public int fLeeDatoCteProv(string aCampo, StringBuilder aValor, int aLen)
    {
        return AdminpaqSdk.fLeeDatoCteProv(aCampo, aValor, aLen);
    }

    public int fLeeDatoDireccion(string aCampo, StringBuilder aValor, int aLen)
    {
        return AdminpaqSdk.fLeeDatoDireccion(aCampo, aValor, aLen);
    }

    public int fLeeDatoDocumento(string aCampo, StringBuilder aValor, int aLongitud)
    {
        return AdminpaqSdk.fLeeDatoDocumento(aCampo, aValor, aLongitud);
    }

    public int fLeeDatoMovimiento(string aCampo, StringBuilder aValor, int aLen)
    {
        return AdminpaqSdk.fLeeDatoMovimiento(aCampo, aValor, aLen);
    }

    public int fLeeDatoMovtoContable(string aCampo, StringBuilder aValor, int aLen)
    {
        return AdminpaqSdk.fLeeDatoMovtoContable(aCampo, aValor, aLen);
    }

    public int fLeeDatoParametros(string aCampo, StringBuilder aValor, int aLen)
    {
        return AdminpaqSdk.fLeeDatoParametros(aCampo, aValor, aLen);
    }

    public int fLeeDatoProducto(string aCampo, StringBuilder aValor, int aLen)
    {
        return AdminpaqSdk.fLeeDatoProducto(aCampo, aValor, aLen);
    }

    public int fLeeDatoUnidad(string aCampo, StringBuilder aValor, int aLen)
    {
        return AdminpaqSdk.fLeeDatoUnidad(aCampo, aValor, aLen);
    }

    public int fLeeDatoValorClasif(string aCampo, StringBuilder aValor, int aLen)
    {
        return AdminpaqSdk.fLeeDatoValorClasif(aCampo, aValor, aLen);
    }

    public int fLlenaRegistroCteProv(ref tCteProv astCteProv, int aEsAlta)
    {
        return AdminpaqSdk.fLlenaRegistroCteProv(ref astCteProv, aEsAlta);
    }

    public int fLlenaRegistroDireccion(ref tDireccion astDireccion, int aEsAlta)
    {
        return AdminpaqSdk.fLlenaRegistroDireccion(ref astDireccion, aEsAlta);
    }

    public int fLlenaRegistroProducto(ref tProducto astProducto, int aEsAlta)
    {
        return AdminpaqSdk.fLlenaRegistroProducto(ref astProducto, aEsAlta);
    }

    public int fLlenaRegistroUnidad(ref tUnidad astUnidad)
    {
        return AdminpaqSdk.fLlenaRegistroUnidad(ref astUnidad);
    }

    public int fLlenaRegistroValorClasif(ref tValorClasificacion astValorClasif)
    {
        return AdminpaqSdk.fLlenaRegistroValorClasif(ref astValorClasif);
    }

    public int fModificaCostoEntrada(string aIdMovimiento, string aCostoEntrada)
    {
        return AdminpaqSdk.fModificaCostoEntrada(aIdMovimiento, aCostoEntrada);
    }

    public int fModificaCuentaBancariaCliente(string aCuentaBancaria, string aNombreCuenta, string aNombreMoneda, string aClaveBanco,
        string aRfcBanco, string aClabe, string aNombreExtranjero, string aCodigoCliente)
    {
        throw new NotImplementedException();
    }

    public int fModificaCuentaBancariaEmpresa(string aCuentaBancaria, string aNombreCuenta, string aNombreMoneda, string aClaveBanco,
        string aRfcBanco, string aClabe, string aNombreExtranjero)
    {
        throw new NotImplementedException();
    }

    public int fObtenCeryKey(int aIdFirmarl, string aRutaKey, string aRutaCer)
    {
        return AdminpaqSdk.fObtenCeryKey(aIdFirmarl, aRutaKey, aRutaCer);
    }

    public int fObtieneDatosCFDI(string atPtrPassword)
    {
        return AdminpaqSdk.fObtieneDatosCFDI(atPtrPassword);
    }

    public int fObtieneLicencia(StringBuilder aCodAcvtiva, StringBuilder aCodSitio, StringBuilder aSerie, StringBuilder aTagVersion)
    {
        return AdminpaqSdk.fObtieneLicencia(aCodAcvtiva, aCodSitio, aSerie, aTagVersion);
    }

    public int fObtienePassProxy(StringBuilder aPassProxy)
    {
        return AdminpaqSdk.fObtienePassProxy(aPassProxy);
    }

    public int fObtieneUnidadesPendientes(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen, StringBuilder aUnidades)
    {
        return AdminpaqSdk.fObtieneUnidadesPendientes(aConceptoDocto, aCodigoProducto, aCodigoAlmacen, aUnidades);
    }

    public int fObtieneUnidadesPendientesCarac(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen,
        string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, StringBuilder aUnidades)
    {
        return AdminpaqSdk.fObtieneUnidadesPendientesCarac(aConceptoDocto, aCodigoProducto, aCodigoAlmacen, aValorCaracteristica1,
            aValorCaracteristica2, aValorCaracteristica3, aUnidades);
    }

    public int fPosAnteriorAgente()
    {
        return AdminpaqSdk.fPosAnteriorAgente();
    }

    public int fPosAnteriorAlmacen()
    {
        return AdminpaqSdk.fPosAnteriorAlmacen();
    }

    public int fPosAnteriorClasificacion()
    {
        return AdminpaqSdk.fPosAnteriorClasificacion();
    }

    public int fPosAnteriorConceptoDocto()
    {
        return AdminpaqSdk.fPosAnteriorConceptoDocto();
    }

    public int fPosAnteriorCteProv()
    {
        return AdminpaqSdk.fPosAnteriorCteProv();
    }

    public int fPosAnteriorDireccion()
    {
        return AdminpaqSdk.fPosAnteriorDireccion();
    }

    public int fPosAnteriorDocumento()
    {
        return AdminpaqSdk.fPosAnteriorDocumento();
    }

    public int fPosAnteriorMovimiento()
    {
        return AdminpaqSdk.fPosAnteriorMovimiento();
    }

    public int fPosAnteriorProducto()
    {
        return AdminpaqSdk.fPosAnteriorProducto();
    }

    public int fPosAnteriorUnidad()
    {
        return AdminpaqSdk.fPosAnteriorUnidad();
    }

    public int fPosAnteriorValorClasif()
    {
        return AdminpaqSdk.fPosAnteriorValorClasif();
    }

    public int fPosBOF()
    {
        return AdminpaqSdk.fPosBOF();
    }

    public int fPosBOFAgente()
    {
        return AdminpaqSdk.fPosBOFAgente();
    }

    public int fPosBOFAlmacen()
    {
        return AdminpaqSdk.fPosBOFAlmacen();
    }

    public int fPosBOFClasificacion()
    {
        return AdminpaqSdk.fPosBOFClasificacion();
    }

    public int fPosBOFConceptoDocto()
    {
        return AdminpaqSdk.fPosBOFConceptoDocto();
    }

    public int fPosBOFCteProv()
    {
        return AdminpaqSdk.fPosBOFCteProv();
    }

    public int fPosBOFDireccion()
    {
        return AdminpaqSdk.fPosBOFDireccion();
    }

    public int fPosBOFProducto()
    {
        return AdminpaqSdk.fPosBOFProducto();
    }

    public int fPosBOFUnidad()
    {
        return AdminpaqSdk.fPosBOFUnidad();
    }

    public int fPosBOFValorClasif()
    {
        return AdminpaqSdk.fPosBOFValorClasif();
    }

    public int fPosEOF()
    {
        return AdminpaqSdk.fPosEOF();
    }

    public int fPosEOFAgente()
    {
        return AdminpaqSdk.fPosEOFAgente();
    }

    public int fPosEOFAlmacen()
    {
        return AdminpaqSdk.fPosEOFAlmacen();
    }

    public int fPosEOFClasificacion()
    {
        return AdminpaqSdk.fPosEOFClasificacion();
    }

    public int fPosEOFConceptoDocto()
    {
        return AdminpaqSdk.fPosEOFConceptoDocto();
    }

    public int fPosEOFCteProv()
    {
        return AdminpaqSdk.fPosEOFCteProv();
    }

    public int fPosEOFDireccion()
    {
        return AdminpaqSdk.fPosEOFDireccion();
    }

    public int fPosEOFMovtoContable()
    {
        return AdminpaqSdk.fPosEOFMovtoContable();
    }

    public int fPosEOFProducto()
    {
        return AdminpaqSdk.fPosEOFProducto();
    }

    public int fPosEOFUnidad()
    {
        return AdminpaqSdk.fPosEOFUnidad();
    }

    public int fPosEOFValorClasif()
    {
        return AdminpaqSdk.fPosEOFValorClasif();
    }

    public int fPosMovimientoBOF()
    {
        return AdminpaqSdk.fPosMovimientoBOF();
    }

    public int fPosMovimientoEOF()
    {
        return AdminpaqSdk.fPosMovimientoEOF();
    }

    public int fPosPrimerAgente()
    {
        return AdminpaqSdk.fPosPrimerAgente();
    }

    public int fPosPrimerAlmacen()
    {
        return AdminpaqSdk.fPosPrimerAlmacen();
    }

    public int fPosPrimerClasificacion()
    {
        return AdminpaqSdk.fPosPrimerClasificacion();
    }

    public int fPosPrimerConceptoDocto()
    {
        return AdminpaqSdk.fPosPrimerConceptoDocto();
    }

    public int fPosPrimerCteProv()
    {
        return AdminpaqSdk.fPosPrimerCteProv();
    }

    public int fPosPrimerDireccion()
    {
        return AdminpaqSdk.fPosPrimerDireccion();
    }

    public int fPosPrimerDocumento()
    {
        return AdminpaqSdk.fPosPrimerDocumento();
    }

    public int fPosPrimerEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa)
    {
        return AdminpaqSdk.fPosPrimerEmpresa(ref aIdEmpresa, aNombreEmpresa, aDirectorioEmpresa);
    }

    public int fPosPrimerMovimiento()
    {
        return AdminpaqSdk.fPosPrimerMovimiento();
    }

    public int fPosPrimerMovtoContable()
    {
        return AdminpaqSdk.fPosPrimerMovtoContable();
    }

    public int fPosPrimerProducto()
    {
        return AdminpaqSdk.fPosPrimerProducto();
    }

    public int fPosPrimerUnidad()
    {
        return AdminpaqSdk.fPosPrimerUnidad();
    }

    public int fPosPrimerValorClasif()
    {
        return AdminpaqSdk.fPosPrimerValorClasif();
    }

    public int fPosSiguienteAgente()
    {
        return AdminpaqSdk.fPosSiguienteAgente();
    }

    public int fPosSiguienteAlmacen()
    {
        return AdminpaqSdk.fPosSiguienteAlmacen();
    }

    public int fPosSiguienteClasificacion()
    {
        return AdminpaqSdk.fPosSiguienteClasificacion();
    }

    public int fPosSiguienteConceptoDocto()
    {
        return AdminpaqSdk.fPosSiguienteConceptoDocto();
    }

    public int fPosSiguienteCteProv()
    {
        return AdminpaqSdk.fPosSiguienteCteProv();
    }

    public int fPosSiguienteDireccion()
    {
        return AdminpaqSdk.fPosSiguienteDireccion();
    }

    public int fPosSiguienteDocumento()
    {
        return AdminpaqSdk.fPosSiguienteDocumento();
    }

    public int fPosSiguienteEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa)
    {
        return AdminpaqSdk.fPosSiguienteEmpresa(ref aIdEmpresa, aNombreEmpresa, aDirectorioEmpresa);
    }

    public int fPosSiguienteMovimiento()
    {
        return AdminpaqSdk.fPosSiguienteMovimiento();
    }

    public int fPosSiguienteMovtoContable()
    {
        return AdminpaqSdk.fPosSiguienteMovtoContable();
    }

    public int fPosSiguienteProducto()
    {
        return AdminpaqSdk.fPosSiguienteProducto();
    }

    public int fPosSiguienteUnidad()
    {
        return AdminpaqSdk.fPosSiguienteUnidad();
    }

    public int fPosSiguienteValorClasif()
    {
        return AdminpaqSdk.fPosSiguienteValorClasif();
    }

    public int fPosUltimaConceptoDocto()
    {
        return AdminpaqSdk.fPosUltimaConceptoDocto();
    }

    public int fPosUltimaDireccion()
    {
        return AdminpaqSdk.fPosUltimaDireccion();
    }

    public int fPosUltimoAgente()
    {
        return AdminpaqSdk.fPosUltimoAgente();
    }

    public int fPosUltimoAlmacen()
    {
        return AdminpaqSdk.fPosUltimoAlmacen();
    }

    public int fPosUltimoClasificacion()
    {
        return AdminpaqSdk.fPosUltimoClasificacion();
    }

    public int fPosUltimoCteProv()
    {
        return AdminpaqSdk.fPosUltimoCteProv();
    }

    public int fPosUltimoDocumento()
    {
        return AdminpaqSdk.fPosUltimoDocumento();
    }

    public int fPosUltimoMovimiento()
    {
        return AdminpaqSdk.fPosUltimoMovimiento();
    }

    public int fPosUltimoProducto()
    {
        return AdminpaqSdk.fPosUltimoProducto();
    }

    public int fPosUltimoUnidad()
    {
        return AdminpaqSdk.fPosUltimoUnidad();
    }

    public int fPosUltimoValorClasif()
    {
        return AdminpaqSdk.fPosUltimoValorClasif();
    }

    public int fProyectoEmpresaDoctos(string aCodigoProyecto)
    {
        throw new NotImplementedException();
    }

    public int fRecosteoProducto(string aCodigoProducto, int aEjercicio, int aPeriodo, string aCodigoClasificacion1,
        string aCodigoClasificacion2, string aCodigoClasificacion3, string aCodigoClasificacion4, string aCodigoClasificacion5,
        string aCodigoClasificacion6, string aNombreBitacora, int aSobreEscribirBitacora, int aEsCalculoArimetico)
    {
        return AdminpaqSdk.fRecosteoProducto(aCodigoProducto, aEjercicio, aPeriodo, aCodigoClasificacion1, aCodigoClasificacion2,
            aCodigoClasificacion3, aCodigoClasificacion4, aCodigoClasificacion5, aCodigoClasificacion6, aNombreBitacora,
            aSobreEscribirBitacora, aEsCalculoArimetico);
    }

    public int fRecuperarRelacionesCFDIs(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion, StringBuilder aUUIDs,
        string aRutaNombreArchivoInfo)
    {
        return AdminpaqSdk.fRecuperarRelacionesCFDIs(aCodConcepto, aSerie, aFolio, aTipoRelacion, aUUIDs, aRutaNombreArchivoInfo);
    }

    public int fRecuperaTipoProducto(ref bool aUnidades, ref bool aSerie, ref bool aLote, ref bool aPedimento, ref bool aCaracteristicas)
    {
        return AdminpaqSdk.fRecuperaTipoProducto(ref aUnidades, ref aSerie, ref aLote, ref aPedimento, ref aCaracteristicas);
    }

    public int fRegresaCostoCapa(string aCodigoProducto, string aCodigoAlmacen, double aUnidades, StringBuilder aImporteCosto)
    {
        return AdminpaqSdk.fRegresaCostoCapa(aCodigoProducto, aCodigoAlmacen, aUnidades, aImporteCosto);
    }

    public int fRegresaCostoEstandar(string aCodigoProducto, StringBuilder aCostoEstandar)
    {
        return AdminpaqSdk.fRegresaCostoEstandar(aCodigoProducto, aCostoEstandar);
    }

    public int fRegresaCostoPromedio(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        StringBuilder aCostoPromedio)
    {
        return AdminpaqSdk.fRegresaCostoPromedio(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, aCostoPromedio);
    }

    public int fRegresaExistencia(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        ref double aExistencia)
    {
        return AdminpaqSdk.fRegresaExistencia(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, ref aExistencia);
    }

    public int fRegresaExistenciaCaracteristicas(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, ref double aExistencia)
    {
        return AdminpaqSdk.fRegresaExistenciaCaracteristicas(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, aValorCaracteristica1,
            aValorCaracteristica2, aValorCaracteristica3, ref aExistencia);
    }

    public int fRegresaExistenciaLotePedimento(string aCodigoProducto, string aCodigoAlmacen, string aPedimento, string aLote,
        ref double aExistencia)
    {
        throw new NotImplementedException();
    }

    public int fRegresaIVACargo(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero,
        double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas)
    {
        return AdminpaqSdk.fRegresaIVACargo(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas,
            aIVATasa15, aIVATasa10, aIVAOtrasTasas);
    }

    public int fRegresaIVACargo_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11,
        double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16,
        double aIVATasa11, double aIVAOtrasTasas)
    {
        return AdminpaqSdk.fRegresaIVACargo_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero,
            aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas);
    }

    public int fRegresaIVACargoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16,
        double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10,
        double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI)
    {
        return AdminpaqSdk.fRegresaIVACargoRet_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero,
            aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas, aRetIVA, aRetI);
    }

    public int fRegresaIVAPago(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero, double aNetoTasaExcenta,
        double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas)
    {
        return AdminpaqSdk.fRegresaIVAPago(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas,
            aIVATasa15, aIVATasa10, aIVAOtrasTasas);
    }

    public int fRegresaIVAPago_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11,
        double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16,
        double aIVATasa11, double aIVAOtrasTasas)
    {
        return AdminpaqSdk.fRegresaIVAPago_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero,
            aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas);
    }

    public int fRegresaIVAPagoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16,
        double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10,
        double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI)
    {
        return AdminpaqSdk.fRegresaIVAPagoRet_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero,
            aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas, aRetIVA, aRetI);
    }

    public int fRegresaPrecioVenta(string aCodigoConcepto, string aCodigoCliente, string aCodigoProducto, StringBuilder aPrecioVenta)
    {
        return AdminpaqSdk.fRegresaPrecioVenta(aCodigoConcepto, aCodigoCliente, aCodigoProducto, aPrecioVenta);
    }

    public int fRegresaUltimoCosto(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        StringBuilder aUltimoCosto)
    {
        return AdminpaqSdk.fRegresaUltimoCosto(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, aUltimoCosto);
    }

    public int fRegresPorcentajeImpuesto(int aIdConceptoDocumento, int aIdClienteProveedor, int aIdProducto, ref double aPorcentajeImpuesto)
    {
        return AdminpaqSdk.fRegresPorcentajeImpuesto(aIdConceptoDocumento, aIdClienteProveedor, aIdProducto, ref aPorcentajeImpuesto);
    }

    public int fSaldarDocumento(ref tLlaveDoc aDoctoaPagar, ref tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha)
    {
        return AdminpaqSdk.fSaldarDocumento(ref aDoctoaPagar, ref aDoctoPago, aImporte, aIdMoneda, aFecha);
    }

    public int fSaldarDocumento_Param(string aCodConcepto_Pagar, string aSerie_Pagar, double aFolio_Pagar, string aCodConcepto_Pago,
        string aSerie_Pago, double aFolio_Pago, double aImporte, int aIdMoneda, string aFecha)
    {
        return AdminpaqSdk.fSaldarDocumento_Param(aCodConcepto_Pagar, aSerie_Pagar, aFolio_Pagar, aCodConcepto_Pago, aSerie_Pago,
            aFolio_Pago, aImporte, aIdMoneda, aFecha);
    }

    public int fSaldarDocumentoCheqPAQ(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha,
        double aTipoCambioCheqPAQ)
    {
        return AdminpaqSdk.fSaldarDocumentoCheqPAQ(aDoctoaPagar, aDoctoPago, aImporte, aIdMoneda, aFecha, aTipoCambioCheqPAQ);
    }

    public int fSetDatoAgente(string aCampo, string aValor)
    {
        return AdminpaqSdk.fSetDatoAgente(aCampo, aValor);
    }

    public int fSetDatoAlmacen(string aCampo, string aValor)
    {
        return AdminpaqSdk.fSetDatoAlmacen(aCampo, aValor);
    }

    public int fSetDatoClasificacion(string aCampo, string aValor)
    {
        return AdminpaqSdk.fSetDatoClasificacion(aCampo, aValor);
    }

    public int fSetDatoConceptoDocto(string aCampo, string aValor)
    {
        return AdminpaqSdk.fSetDatoConceptoDocto(aCampo, aValor);
    }

    public int fSetDatoCteProv(string aCampo, string aValor)
    {
        return AdminpaqSdk.fSetDatoCteProv(aCampo, aValor);
    }

    public int fSetDatoDireccion(string aCampo, string aValor)
    {
        return AdminpaqSdk.fSetDatoDireccion(aCampo, aValor);
    }

    public int fSetDatoDocumento(string aCampo, string aValor)
    {
        return AdminpaqSdk.fSetDatoDocumento(aCampo, aValor);
    }

    public int fSetDatoMovimiento(string aCampo, string aValor)
    {
        return AdminpaqSdk.fSetDatoMovimiento(aCampo, aValor);
    }

    public int fSetDatoMovtoContable(string aCampo, string aValor)
    {
        return AdminpaqSdk.fSetDatoMovtoContable(aCampo, aValor);
    }

    public int fSetDatoParametros(string aCampo, StringBuilder aValor)
    {
        return AdminpaqSdk.fSetDatoParametros(aCampo, aValor);
    }

    public int fSetDatoProducto(string aCampo, string aValor)
    {
        return AdminpaqSdk.fSetDatoProducto(aCampo, aValor);
    }

    public int fSetDatoUnidad(string aCampo, string aValor)
    {
        return AdminpaqSdk.fSetDatoUnidad(aCampo, aValor);
    }

    public int fSetDatoValorClasif(string aCampo, string aValor)
    {
        return AdminpaqSdk.fSetDatoValorClasif(aCampo, aValor);
    }

    public int fSetDescripcionProducto(string aCampo, string aValor)
    {
        return AdminpaqSdk.fSetDescripcionProducto(aCampo, aValor);
    }

    public int fSetFiltroDocumento(string aFechaInicio, string aFechaFin, string aCodigoConcepto, string aCodigoCteProv)
    {
        return AdminpaqSdk.fSetFiltroDocumento(aFechaInicio, aFechaFin, aCodigoConcepto, aCodigoCteProv);
    }

    public int fSetFiltroMovimiento(int aIdDocumento)
    {
        return AdminpaqSdk.fSetFiltroMovimiento(aIdDocumento);
    }

    public void fSetModoImportacion(bool aImportacion)
    {
        AdminpaqSdk.fSetModoImportacion(aImportacion);
    }

    public int fSetNombrePAQ(string aSistema)
    {
        return AdminpaqSdk.fSetNombrePAQ(aSistema);
    }

    public int fSiguienteFolio(string aCodigoConcepto, StringBuilder aSerie, ref double aFolio)
    {
        return AdminpaqSdk.fSiguienteFolio(aCodigoConcepto, aSerie, ref aFolio);
    }

    public void fTerminaSDK()
    {
        AdminpaqSdk.fTerminaSDK();
    }

    public int fTimbraComplementoPagoXML(string aRutaXML, string aCodConcepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado,
        string aPass, string aRutaFormato)
    {
        return AdminpaqSdk.fTimbraComplementoPagoXML(aRutaXML, aCodConcepto, aUUID, aRutaDDA, aRutaResultado, aPass, aRutaFormato);
    }

    public int fTimbraComplementoXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado,
        string aPass, string aRutaFormato, int aComplemento)
    {
        return AdminpaqSdk.fTimbraComplementoXML(aRutaXML, aCodCOncepto, aUUID, aRutaDDA, aRutaResultado, aPass, aRutaFormato,
            aComplemento);
    }

    public int fTimbraNominaXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado,
        string aPass, string aRutaFormato)
    {
        return AdminpaqSdk.fTimbraNominaXML(aRutaXML, aCodCOncepto, aUUID, aRutaDDA, aRutaResultado, aPass, aRutaFormato);
    }

    public int fTimbraXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado, string aPass,
        string aRutaFormato)
    {
        return AdminpaqSdk.fTimbraXML(aRutaXML, aCodCOncepto, aUUID, aRutaDDA, aRutaResultado, aPass, aRutaFormato);
    }

    public int InicializarSDK()
    {
        SetCurrentDirectory();
        int result = fSetNombrePAQ(NombrePaq);
        if (result == SdkConstantes.CodigoExito) result = fInicializaLicenseInfo(LicenseInfoSdk.Adminpaq);

        return result;
    }

    public int InicializarSDK(string usuario, string password)
    {
        throw new NotImplementedException();
    }

    public int InicializarSDK(string usuario, string password, string usuarioContabilidad, string passwordContabilidad)
    {
        throw new NotImplementedException();
    }

    public string LeeDatoAgente(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        AdminpaqSdk.fLeeDatoAgente(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoAlmacen(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        AdminpaqSdk.fLeeDatoAlmacen(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoCfdi(int dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        fLeeDatoCFDI(valor, dato).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoClasificacion(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        AdminpaqSdk.fLeeDatoClasificacion(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoClienteProveedor(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        AdminpaqSdk.fLeeDatoCteProv(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoConcepto(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        AdminpaqSdk.fLeeDatoConceptoDocto(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoDireccion(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        AdminpaqSdk.fLeeDatoDireccion(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoDocumento(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        AdminpaqSdk.fLeeDatoDocumento(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoMovimiento(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        AdminpaqSdk.fLeeDatoMovimiento(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoParametros(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        AdminpaqSdk.fLeeDatoParametros(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoProducto(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        AdminpaqSdk.fLeeDatoProducto(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoUnidad(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        AdminpaqSdk.fLeeDatoUnidad(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoValorClasificacion(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        AdminpaqSdk.fLeeDatoValorClasif(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeMensajeError(int numeroError)
    {
        var mensajeError = new StringBuilder(512);
        fError(numeroError, mensajeError, 512);
        return mensajeError.ToString();
    }

    public string NombreLlaveRegistro => AdminpaqSdkConstants.NombreLlaveRegistro;

    public string NombrePaq => AdminpaqSdkConstants.NombrePaq;

    private void SetCurrentDirectory()
    {
        string lEntrada = RegistryHelper.GetDirectorioBaseFromRegistry(NombreLlaveRegistro);
        Directory.SetCurrentDirectory(lEntrada);
    }
}

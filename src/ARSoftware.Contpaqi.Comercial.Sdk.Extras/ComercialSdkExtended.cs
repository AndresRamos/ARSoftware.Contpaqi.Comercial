using System;
using System.IO;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras;

public class ComercialSdkExtended : IContpaqiSdk
{
    public int fAbreEmpresa(string aDirectorioEmpresa)
    {
        return ComercialSdk.fAbreEmpresa(aDirectorioEmpresa);
    }

    public int fActivarPrecioCompra(int aActivar)
    {
        return ComercialSdk.fActivarPrecioCompra(aActivar);
    }

    public int fActualizaClasificacion(int aClasificacionDe, int aNumClasificacion, string aNombreClasificacion)
    {
        return ComercialSdk.fActualizaClasificacion(aClasificacionDe, aNumClasificacion, aNombreClasificacion);
    }

    public int fActualizaCteProv(string aCodigoCteProv, ref tCteProv astCteProv)
    {
        return ComercialSdk.fActualizaCteProv(aCodigoCteProv, ref astCteProv);
    }

    public int fActualizaDireccion(ref tDireccion astDireccion)
    {
        return ComercialSdk.fActualizaDireccion(ref astDireccion);
    }

    public int fActualizaProducto(string aCodigoProducto, ref tProducto astProducto)
    {
        return ComercialSdk.fActualizaProducto(aCodigoProducto, ref astProducto);
    }

    public int fActualizaUnidad(string aNombreUnidad, ref tUnidad astUnidad)
    {
        return ComercialSdk.fActualizaUnidad(aNombreUnidad, ref astUnidad);
    }

    public int fActualizaValorClasif(string aCodigoValorClasif, ref tValorClasificacion astValorClasif)
    {
        return ComercialSdk.fActualizaValorClasif(aCodigoValorClasif, ref astValorClasif);
    }

    public int fAfectaDocto(ref tLlaveDoc aLlaveDocto, bool aAfecta)
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fAfectaDocto_Param(string aCodConcepto, string aSerie, double aFolio, bool aAfecta)
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fAfectaSerie(int aIdMovto, string aNumeroSerie)
    {
        return ComercialSdk.fAfectaSerie(aIdMovto, aNumeroSerie);
    }

    public int fAgregarRelacionCFDI(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion, string aConceptoRelacionar,
        string aSerieRelacionar, string aFolioRelacionar)
    {
        return ComercialSdk.fAgregarRelacionCFDI(aCodConcepto, aSerie, aFolio, aTipoRelacion, aConceptoRelacionar, aSerieRelacionar,
            aFolioRelacionar);
    }

    public int fAgregarRelacionCFDI2(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion, string aUUID)
    {
        return ComercialSdk.fAgregarRelacionCFDI2(aCodConcepto, aSerie, aFolio, aTipoRelacion, aUUID);
    }

    public int fAltaCteProv(ref int aIdCteProv, ref tCteProv astCteProv)
    {
        return ComercialSdk.fAltaCteProv(ref aIdCteProv, ref astCteProv);
    }

    public int fAltaCuentaBancariaCliente(ref int aIdCtaBancaria, string aCuentaBancaria, string aNombreCuenta, string aNombreMoneda,
        string aClaveBanco, string aClabe, string aRfcBanco, string aNombreBancoExtranjero, string aCodigoCliente)
    {
        return ComercialSdk.fAltaCuentaBancariaCliente(ref aIdCtaBancaria, aCuentaBancaria, aNombreCuenta, aNombreMoneda, aClaveBanco,
            aClabe, aRfcBanco, aNombreBancoExtranjero, aCodigoCliente);
    }

    public int fAltaCuentaBancariaEmpresa(ref int aIdCtaBancaria, string aCuentaBancaria, string aNombreCuenta, string aNombreMoneda,
        string aClaveBanco, string aClabe, string aRfcBanco, string aNombreBancoExtranjero)
    {
        return ComercialSdk.fAltaCuentaBancariaEmpresa(ref aIdCtaBancaria, aCuentaBancaria, aNombreCuenta, aNombreMoneda, aClaveBanco,
            aClabe, aRfcBanco, aNombreBancoExtranjero);
    }

    public int fAltaDireccion(ref int aIdDireccion, ref tDireccion astDireccion)
    {
        return ComercialSdk.fAltaDireccion(ref aIdDireccion, ref astDireccion);
    }

    public int fAltaDoctoAjusteIESPSCteProv(string aCodigoClienteProveedor, int aEsCliente, string aFechaDocto, int aIdMoneda,
        double aTipoCambio, double aImporteIVA, double aTasaIVA, double aImporteIESPS, double aTasaIESPS, int aIdFacturaBase,
        string aMetodo, string aLugar, ref int aIdDoctoGenerado)
    {
        return ComercialSdk.fAltaDoctoAjusteIESPSCteProv(aCodigoClienteProveedor, aEsCliente, aFechaDocto, aIdMoneda, aTipoCambio,
            aImporteIVA, aTasaIVA, aImporteIESPS, aTasaIESPS, aIdFacturaBase, aMetodo, aLugar, ref aIdDoctoGenerado);
    }

    public int fAltaDoctoAjusteIVAClienteProveedor(string aCodigoClienteProveedor, int aEsCliente, int aAbsorberAjusteIVA,
        string aFechaDocto, int aIdMoneda, double aTipoCambio, double aImporteIVA, double aTasaIVA, int aIdFacturaBase, string aMetodo,
        string aLugar, ref int aIdDoctoGenerado)
    {
        return ComercialSdk.fAltaDoctoAjusteIVAClienteProveedor(aCodigoClienteProveedor, aEsCliente, aAbsorberAjusteIVA, aFechaDocto,
            aIdMoneda, aTipoCambio, aImporteIVA, aTasaIVA, aIdFacturaBase, aMetodo, aLugar, ref aIdDoctoGenerado);
    }

    public int fAltaDocumento(ref int aIdDocumento, ref tDocumento aDocumento)
    {
        return ComercialSdk.fAltaDocumento(ref aIdDocumento, ref aDocumento);
    }

    public int fAltaDocumentoCargoAbono(ref tDocumento aDocumento)
    {
        return ComercialSdk.fAltaDocumentoCargoAbono(ref aDocumento);
    }

    public int fAltaDocumentoCargoAbonoExtras(ref tDocumento aDocumento, string aTextoExtra1, string aTextoExtra2, string aTextoExtra3,
        string aFechaExtra, double aImporteExtra1, double aImporteExtra2, double aImporteExtra3, double aImporteExtra4)
    {
        return ComercialSdk.fAltaDocumentoCargoAbonoExtras(ref aDocumento, aTextoExtra1, aTextoExtra2, aTextoExtra3, aFechaExtra,
            aImporteExtra1, aImporteExtra2, aImporteExtra3, aImporteExtra4);
    }

    public int fAltaMovimiento(int aIdDocumento, ref int aIdMovimiento, ref tMovimiento astMovimiento)
    {
        return ComercialSdk.fAltaMovimiento(aIdDocumento, ref aIdMovimiento, ref astMovimiento);
    }

    public int fAltaMovimientoCaracteristicas(int aIdMovimiento, ref int aIdMovtoCaracteristicas, ref tCaracteristicas aCaracteristicas)
    {
        return ComercialSdk.fAltaMovimientoCaracteristicas(aIdMovimiento, ref aIdMovtoCaracteristicas, ref aCaracteristicas);
    }

    public int fAltaMovimientoCaracteristicas_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidades,
        string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3)
    {
        return ComercialSdk.fAltaMovimientoCaracteristicas_Param(aIdMovimiento, aIdMovtoCaracteristicas, aUnidades, aValorCaracteristica1,
            aValorCaracteristica2, aValorCaracteristica3);
    }

    public int fAltaMovimientoCDesct(int aIdDocumento, ref int aIdMovimiento, ref tMovimientoDesc astMovimiento)
    {
        return ComercialSdk.fAltaMovimientoCDesct(aIdDocumento, ref aIdMovimiento, ref astMovimiento);
    }

    public int fAltaMovimientoEx(ref int aIdMovimiento, ref tTipoProducto aTipoProducto)
    {
        return ComercialSdk.fAltaMovimientoEx(ref aIdMovimiento, ref aTipoProducto);
    }

    public int fAltaMovimientoSeriesCapas(int aIdMovimiento, ref tSeriesCapas aSeriesCapas)
    {
        return ComercialSdk.fAltaMovimientoSeriesCapas(aIdMovimiento, ref aSeriesCapas);
    }

    public int fAltaMovimientoSeriesCapas_Param(string aIdMovimiento, string aUnidades, string aTipoCambio, string aSeries,
        string aPedimento, string aAgencia, string aFechaPedimento, string aNumeroLote, string aFechaFabricacion, string aFechaCaducidad)
    {
        return ComercialSdk.fAltaMovimientoSeriesCapas_Param(aIdMovimiento, aUnidades, aTipoCambio, aSeries, aPedimento, aAgencia,
            aFechaPedimento, aNumeroLote, aFechaFabricacion, aFechaCaducidad);
    }

    public int fAltaMovtoCaracteristicasUnidades(int aIdMovimiento, ref int aIdMovtoCaracteristicas,
        ref tCaracteristicas aCaracteristicasUnidades)
    {
        return ComercialSdk.fAltaMovtoCaracteristicasUnidades(aIdMovimiento, ref aIdMovtoCaracteristicas, ref aCaracteristicasUnidades);
    }

    public int fAltaMovtoCaracteristicasUnidades_Param(string aIdMovimiento, string aIdMovtoCaracteristicas, string aUnidad,
        string aUnidades, string aUnidadesNC, string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3)
    {
        return ComercialSdk.fAltaMovtoCaracteristicasUnidades_Param(aIdMovimiento, aIdMovtoCaracteristicas, aUnidad, aUnidades, aUnidadesNC,
            aValorCaracteristica1, aValorCaracteristica2, aValorCaracteristica3);
    }

    public int fAltaProducto(ref int aIdProducto, ref tProducto astProducto)
    {
        return ComercialSdk.fAltaProducto(ref aIdProducto, ref astProducto);
    }

    public int fAltaUnidad(ref int aIdUnidad, ref tUnidad astUnidad)
    {
        return ComercialSdk.fAltaUnidad(ref aIdUnidad, ref astUnidad);
    }

    public int fAltaValorClasif(ref int aIdValorClasif, ref tValorClasificacion astValorClasif)
    {
        return ComercialSdk.fAltaValorClasif(ref aIdValorClasif, ref astValorClasif);
    }

    public int fBorraCteProv()
    {
        return ComercialSdk.fBorraCteProv();
    }

    public int fBorraCuentaBancariaCliente(string aCuentaBancaria, string aCodigoCliente)
    {
        return ComercialSdk.fBorraCuentaBancariaCliente(aCuentaBancaria, aCodigoCliente);
    }

    public int fBorraCuentaBancariaEmpresa(string aCuentaBancaria)
    {
        return ComercialSdk.fBorraCuentaBancariaEmpresa(aCuentaBancaria);
    }

    public int fBorraDocumento()
    {
        return ComercialSdk.fBorraDocumento();
    }

    public int fBorraDocumento_CW()
    {
        return ComercialSdk.fBorraDocumento_CW();
    }

    public int fBorraMovimiento(int aIdDocumento, int aIdMovimiento)
    {
        return ComercialSdk.fBorraMovimiento(aIdDocumento, aIdMovimiento);
    }

    public int fBorraProducto()
    {
        return ComercialSdk.fBorraProducto();
    }

    public int fBorrarAsociacion(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago)
    {
        return ComercialSdk.fBorrarAsociacion(aDoctoaPagar, aDoctoPago);
    }

    public int fBorrarAsociacion_Param(string aCodConcepto_Pagar, string aSerie_Pagar, double aFolio_Pagar, string aCodConcepto_Pago,
        string aSerie_Pago, double aFolio_Pago)
    {
        return ComercialSdk.fBorrarAsociacion_Param(aCodConcepto_Pagar, aSerie_Pagar, aFolio_Pagar, aCodConcepto_Pago, aSerie_Pago,
            aFolio_Pago);
    }

    public int fBorraUnidad()
    {
        return ComercialSdk.fBorraUnidad();
    }

    public int fBorraValorClasif()
    {
        return ComercialSdk.fBorraValorClasif();
    }

    public int fBuscaAgente(string aCodigoAgente)
    {
        return ComercialSdk.fBuscaAgente(aCodigoAgente);
    }

    public int fBuscaAlmacen(string aCodigoAlmacen)
    {
        return ComercialSdk.fBuscaAlmacen(aCodigoAlmacen);
    }

    public int fBuscaClasificacion(int aClasificacionDe, int aNumClasificacion)
    {
        return ComercialSdk.fBuscaClasificacion(aClasificacionDe, aNumClasificacion);
    }

    public int fBuscaConceptoDocto(string aCodConcepto)
    {
        return ComercialSdk.fBuscaConceptoDocto(aCodConcepto);
    }

    public int fBuscaCteProv(string aCodCteProv)
    {
        return ComercialSdk.fBuscaCteProv(aCodCteProv);
    }

    public int fBuscaDireccionCteProv(string aCodCteProv, byte aTipoDireccion)
    {
        return ComercialSdk.fBuscaDireccionCteProv(aCodCteProv, aTipoDireccion);
    }

    public int fBuscaDireccionDocumento(int aIdDocumento, byte aTipoDireccion)
    {
        return ComercialSdk.fBuscaDireccionDocumento(aIdDocumento, aTipoDireccion);
    }

    public int fBuscaDireccionEmpresa()
    {
        return ComercialSdk.fBuscaDireccionEmpresa();
    }

    public int fBuscaDocumento(ref tLlaveDoc aLlaveDocto)
    {
        return ComercialSdk.fBuscaDocumento(ref aLlaveDocto);
    }

    public int fBuscaIdAgente(int aIdAgente)
    {
        return ComercialSdk.fBuscaIdAgente(aIdAgente);
    }

    public int fBuscaIdAlmacen(int aIdAlmacen)
    {
        return ComercialSdk.fBuscaIdAlmacen(aIdAlmacen);
    }

    public int fBuscaIdClasificacion(int aIdClasificacion)
    {
        return ComercialSdk.fBuscaIdClasificacion(aIdClasificacion);
    }

    public int fBuscaIdConceptoDocto(int aIdConcepto)
    {
        return ComercialSdk.fBuscaIdConceptoDocto(aIdConcepto);
    }

    public int fBuscaIdCteProv(int aIdCteProv)
    {
        return ComercialSdk.fBuscaIdCteProv(aIdCteProv);
    }

    public int fBuscaIdProducto(int aIdProducto)
    {
        return ComercialSdk.fBuscaIdProducto(aIdProducto);
    }

    public int fBuscaIdUnidad(int aIdUnidad)
    {
        return ComercialSdk.fBuscaIdUnidad(aIdUnidad);
    }

    public int fBuscaIdValorClasif(int aIdValorClasif)
    {
        return ComercialSdk.fBuscaIdValorClasif(aIdValorClasif);
    }

    public int fBuscaProducto(string aCodProducto)
    {
        return ComercialSdk.fBuscaProducto(aCodProducto);
    }

    public int fBuscarDocumento(string aCodConcepto, string aSerie, string aFolio)
    {
        return ComercialSdk.fBuscarDocumento(aCodConcepto, aSerie, aFolio);
    }

    public int fBuscarIdDocumento(int aIdDocumento)
    {
        return ComercialSdk.fBuscarIdDocumento(aIdDocumento);
    }

    public int fBuscarIdMovimiento(int aIdMovimiento)
    {
        return ComercialSdk.fBuscarIdMovimiento(aIdMovimiento);
    }

    public int fBuscaUnidad(string aNombreUnidad)
    {
        return ComercialSdk.fBuscaUnidad(aNombreUnidad);
    }

    public int fBuscaValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodValorClasif)
    {
        return ComercialSdk.fBuscaValorClasif(aClasificacionDe, aNumClasificacion, aCodValorClasif);
    }

    public int fCalculaMovtoSerieCapa(int aIdMovimiento)
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fCancelaCambiosMovimiento()
    {
        return ComercialSdk.fCancelaCambiosMovimiento();
    }

    public int fCancelaComplementoPagoUUID(string aUUID, string aIdDConcepto, string aPass)
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fCancelaDoctoInfo(string aPass)
    {
        return ComercialSdk.fCancelaDoctoInfo(aPass);
    }

    public int fCancelaDocumento()
    {
        return ComercialSdk.fCancelaDocumento();
    }

    public int fCancelaDocumento_CW()
    {
        return ComercialSdk.fCancelaDocumento_CW();
    }

    public int fCancelaDocumentoAdministrativamente()
    {
        return ComercialSdk.fCancelaDocumentoAdministrativamente();
    }

    public int fCancelaDocumentoConMotivo(string aMotivoCancelacion, string aUUIDRemplaza)
    {
        return ComercialSdk.fCancelaDocumentoConMotivo(aMotivoCancelacion, aUUIDRemplaza);
    }

    public int fCancelaFiltroDocumento()
    {
        return ComercialSdk.fCancelaFiltroDocumento();
    }

    public int fCancelaFiltroMovimiento()
    {
        return ComercialSdk.fCancelaFiltroMovimiento();
    }

    public int fCancelaNominaUUID(string aUUID, string aIdDConcepto, string aPass)
    {
        return ComercialSdk.fCancelaNominaUUID(aUUID, aIdDConcepto, aPass);
    }

    public int fCancelarModificacionAgente()
    {
        return ComercialSdk.fCancelarModificacionAgente();
    }

    public int fCancelarModificacionAlmacen()
    {
        return ComercialSdk.fCancelarModificacionAlmacen();
    }

    public int fCancelarModificacionClasificacion()
    {
        return ComercialSdk.fCancelarModificacionClasificacion();
    }

    public int fCancelarModificacionCteProv()
    {
        return ComercialSdk.fCancelarModificacionCteProv();
    }

    public int fCancelarModificacionDireccion()
    {
        return ComercialSdk.fCancelarModificacionDireccion();
    }

    public int fCancelarModificacionDocumento()
    {
        return ComercialSdk.fCancelarModificacionDocumento();
    }

    public int fCancelarModificacionProducto()
    {
        return ComercialSdk.fCancelarModificacionProducto();
    }

    public int fCancelarModificacionUnidad()
    {
        return ComercialSdk.fCancelarModificacionUnidad();
    }

    public int fCancelarModificacionValorClasif()
    {
        return ComercialSdk.fCancelarModificacionValorClasif();
    }

    public int fCancelaUUID(string aUUID, string aIdDConcepto, string aPass)
    {
        return ComercialSdk.fCancelaUUID(aUUID, aIdDConcepto, aPass);
    }

    public int fCancelaUUID40(string aUUID, string aMotivoCancelacion, string aUUIDReemplaza, string RFCReceptor, double aTotal,
        string aIdDConcepto, string aPass, ref int aEstatusCancelacion)
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public void fCierraEmpresa()
    {
        ComercialSdk.fCierraEmpresa();
    }

    public int fCuentaBancariaEmpresaDoctos(string aCuentaBancaria)
    {
        return ComercialSdk.fCuentaBancariaEmpresaDoctos(aCuentaBancaria);
    }

    public int fDesbloqueaDocumento()
    {
        return ComercialSdk.fDesbloqueaDocumento();
    }

    public int fDocumentoBloqueado(ref int aImpreso)
    {
        return ComercialSdk.fDocumentoBloqueado(ref aImpreso);
    }

    public int fDocumentoDevuelto(ref int aDevuelto)
    {
        return ComercialSdk.fDocumentoDevuelto(ref aDevuelto);
    }

    public int fDocumentoImpreso(ref bool aImpreso)
    {
        return ComercialSdk.fDocumentoImpreso(ref aImpreso);
    }

    public int fDocumentoUUID(StringBuilder aCodConcepto, StringBuilder aSerie, double aFolio, StringBuilder atPtrCFDIUUID)
    {
        return ComercialSdk.fDocumentoUUID(aCodConcepto, aSerie, aFolio, atPtrCFDIUUID);
    }

    public int fEditaAgente()
    {
        return ComercialSdk.fEditaAgente();
    }

    public int fEditaAlmacen()
    {
        return ComercialSdk.fEditaAlmacen();
    }

    public int fEditaClasificacion()
    {
        return ComercialSdk.fEditaClasificacion();
    }

    public int fEditaConceptoDocto()
    {
        return ComercialSdk.fEditaConceptoDocto();
    }

    public int fEditaCteProv()
    {
        return ComercialSdk.fEditaCteProv();
    }

    public int fEditaDireccion()
    {
        return ComercialSdk.fEditaDireccion();
    }

    public int fEditaMovtoContable()
    {
        return ComercialSdk.fEditaMovtoContable();
    }

    public int fEditaParametros()
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fEditaProducto()
    {
        return ComercialSdk.fEditaProducto();
    }

    public int fEditarDocumento()
    {
        return ComercialSdk.fEditarDocumento();
    }

    public int fEditarDocumentoCheqpaq()
    {
        return ComercialSdk.fEditarDocumentoCheqpaq();
    }

    public int fEditarMovimiento()
    {
        return ComercialSdk.fEditarMovimiento();
    }

    public int fEditaUnidad()
    {
        return ComercialSdk.fEditaUnidad();
    }

    public int fEditaValorClasif()
    {
        return ComercialSdk.fEditaValorClasif();
    }

    public int fEliminarCteProv(string aCodigoCteProv)
    {
        return ComercialSdk.fEliminarCteProv(aCodigoCteProv);
    }

    public int fEliminarProducto(string aCodigoProducto)
    {
        return ComercialSdk.fEliminarProducto(aCodigoProducto);
    }

    public int fEliminarRelacionesCFDIs(string aCodConcepto, string aSerie, string aFolio)
    {
        return ComercialSdk.fEliminarRelacionesCFDIs(aCodConcepto, aSerie, aFolio);
    }

    public int fEliminarUnidad(string aNombreUnidad)
    {
        return ComercialSdk.fEliminarUnidad(aNombreUnidad);
    }

    public int fEliminarValorClasif(int aClasificacionDe, int aNumClasificacion, string aCodigoValorClasif)
    {
        return ComercialSdk.fEliminarValorClasif(aClasificacionDe, aNumClasificacion, aCodigoValorClasif);
    }

    public int fEmitirDocumento(string aCodConcepto, string aSerie, double aFolio, string aPassword, string aArchivoAdicional)
    {
        return ComercialSdk.fEmitirDocumento(aCodConcepto, aSerie, aFolio, aPassword, aArchivoAdicional);
    }

    public int fEntregEnDiscoXML(string aCodConcepto, string aSerie, double aFolio, int aFormato, string aFormatoAmig)
    {
        return ComercialSdk.fEntregEnDiscoXML(aCodConcepto, aSerie, aFolio, aFormato, aFormatoAmig);
    }

    public void fError(int aNumError, StringBuilder aMensaje, int aLen)
    {
        ComercialSdk.fError(aNumError, aMensaje, aLen);
    }

    public int fGetCantidadParcialidades(StringBuilder atPtrPassword, StringBuilder aCantidadParcialidades)
    {
        return ComercialSdk.fGetCantidadParcialidades(atPtrPassword, aCantidadParcialidades);
    }

    public int fGetDatosCFDI(StringBuilder aSerieCertEmisor, StringBuilder aFolioFiscalUUID, StringBuilder aSerieCertSAT,
        StringBuilder aFechaHora, StringBuilder aSelloDigCFDI, StringBuilder aSelloSAAT, StringBuilder aCadOrigComplSAT,
        StringBuilder aRegimen, StringBuilder aLugarExpedicion, StringBuilder aMoneda, StringBuilder aFolioFiscalOrig,
        StringBuilder aSerieFolioFiscalOrig, StringBuilder aFechaFolioFiscalOrig, StringBuilder aMontoFolioFiscalOrig)
    {
        return ComercialSdk.fGetDatosCFDI(aSerieCertEmisor, aFolioFiscalUUID, aSerieCertSAT, aFechaHora, aSelloDigCFDI, aSelloSAAT,
            aCadOrigComplSAT, aRegimen, aLugarExpedicion, aMoneda, aFolioFiscalOrig, aSerieFolioFiscalOrig, aFechaFolioFiscalOrig,
            aMontoFolioFiscalOrig);
    }

    public int fGetNumParcialidades(StringBuilder atPtrPassword, StringBuilder aNumParcialidades)
    {
        return ComercialSdk.fGetNumParcialidades(atPtrPassword, aNumParcialidades);
    }

    public int fGetSelloDigitalYCadena(StringBuilder atPtrPassword, StringBuilder atPtrSelloDigital, StringBuilder atPtrCadenaOriginal)
    {
        return ComercialSdk.fGetSelloDigitalYCadena(atPtrPassword, atPtrSelloDigital, atPtrCadenaOriginal);
    }

    public int fGetSerieCertificado(StringBuilder atPtrPassword, StringBuilder aSerieCertificado)
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fGetTamSelloDigitalYCadena(StringBuilder atPtrPassword, ref int aEspSelloDig, ref int aEspCadOrig)
    {
        return ComercialSdk.fGetTamSelloDigitalYCadena(atPtrPassword, ref aEspSelloDig, ref aEspCadOrig);
    }

    public int fGuardaAgente()
    {
        return ComercialSdk.fGuardaAgente();
    }

    public int fGuardaAlmacen()
    {
        return ComercialSdk.fGuardaAlmacen();
    }

    public int fGuardaClasificacion()
    {
        return ComercialSdk.fGuardaClasificacion();
    }

    public int fGuardaConceptoDocto()
    {
        return ComercialSdk.fGuardaConceptoDocto();
    }

    public int fGuardaCteProv()
    {
        return ComercialSdk.fGuardaCteProv();
    }

    public int fGuardaDireccion()
    {
        return ComercialSdk.fGuardaDireccion();
    }

    public int fGuardaDocumento()
    {
        return ComercialSdk.fGuardaDocumento();
    }

    public int fGuardaMovimiento()
    {
        return ComercialSdk.fGuardaMovimiento();
    }

    public int fGuardaMovtoContable()
    {
        return ComercialSdk.fGuardaMovtoContable();
    }

    public int fGuardaParametros()
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fGuardaProducto()
    {
        return ComercialSdk.fGuardaProducto();
    }

    public int fGuardaUnidad()
    {
        return ComercialSdk.fGuardaUnidad();
    }

    public int fGuardaValorClasif()
    {
        return ComercialSdk.fGuardaValorClasif();
    }

    public int fInformacionCliente(StringBuilder aCodigo, ref int aPermiteCredito, ref double aLimiteCredito, ref int aLimiteDoctosVencidos,
        ref int aPermiteExcederCredito, StringBuilder aFecha, ref double aSaldo, ref double aSaldoPendiente, ref int aDoctosVencidos)
    {
        return ComercialSdk.fInformacionCliente(aCodigo, ref aPermiteCredito, ref aLimiteCredito, ref aLimiteDoctosVencidos,
            ref aPermiteExcederCredito, aFecha, ref aSaldo, ref aSaldoPendiente, ref aDoctosVencidos);
    }

    public int fInicializaLicenseInfo(byte aSistema)
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fInicializaSDK()
    {
        return ComercialSdk.fInicializaSDK();
    }

    public void fInicioSesionSDK(string aUsuario, string aContrasenia)
    {
        ComercialSdk.fInicioSesionSDK(aUsuario, aContrasenia);
    }

    public void fInicioSesionSDKCONTPAQi(string aUsuario, string aContrasenia)
    {
        ComercialSdk.fInicioSesionSDKCONTPAQi(aUsuario, aContrasenia);
    }

    public int fInsertaAgente()
    {
        return ComercialSdk.fInsertaAgente();
    }

    public int fInsertaAlmacen()
    {
        return ComercialSdk.fInsertaAlmacen();
    }

    public int fInsertaCteProv()
    {
        return ComercialSdk.fInsertaCteProv();
    }

    public int fInsertaDatoAddendaDocto(int aIdAddenda, int aIdCatalogo, int aNumCampo, string aDato)
    {
        return ComercialSdk.fInsertaDatoAddendaDocto(aIdAddenda, aIdCatalogo, aNumCampo, aDato);
    }

    public int fInsertaDatoAddendaMovto(int aIdAddenda, int aIdCatalogo, int aNumCampo, string aDato)
    {
        return ComercialSdk.fInsertaDatoAddendaMovto(aIdAddenda, aIdCatalogo, aNumCampo, aDato);
    }

    public int fInsertaDatoCompEducativo(int aIdServicio, int aNumCampo, string aDato)
    {
        return ComercialSdk.fInsertaDatoCompEducativo(aIdServicio, aNumCampo, aDato);
    }

    public int fInsertaDireccion()
    {
        return ComercialSdk.fInsertaDireccion();
    }

    public int fInsertaProducto()
    {
        return ComercialSdk.fInsertaProducto();
    }

    public int fInsertarDocumento()
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fInsertarMovimiento()
    {
        return ComercialSdk.fInsertarMovimiento();
    }

    public int fInsertaUnidad()
    {
        return ComercialSdk.fInsertaUnidad();
    }

    public int fInsertaValorClasif()
    {
        return ComercialSdk.fInsertaValorClasif();
    }

    public int fLeeDatoAgente(string aCampo, StringBuilder aValor, int aLen)
    {
        return ComercialSdk.fLeeDatoAgente(aCampo, aValor, aLen);
    }

    public int fLeeDatoAlmacen(string aCampo, StringBuilder aValor, int aLen)
    {
        return ComercialSdk.fLeeDatoAlmacen(aCampo, aValor, aLen);
    }

    public int fLeeDatoCFDI(StringBuilder aValor, int aDato)
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fLeeDatoClasificacion(string aCampo, StringBuilder aValor, int aLen)
    {
        return ComercialSdk.fLeeDatoClasificacion(aCampo, aValor, aLen);
    }

    public int fLeeDatoConceptoDocto(string aCampo, StringBuilder aValor, int aLen)
    {
        return ComercialSdk.fLeeDatoConceptoDocto(aCampo, aValor, aLen);
    }

    public int fLeeDatoCteProv(string aCampo, StringBuilder aValor, int aLen)
    {
        return ComercialSdk.fLeeDatoCteProv(aCampo, aValor, aLen);
    }

    public int fLeeDatoDireccion(string aCampo, StringBuilder aValor, int aLen)
    {
        return ComercialSdk.fLeeDatoDireccion(aCampo, aValor, aLen);
    }

    public int fLeeDatoDocumento(string aCampo, StringBuilder aValor, int aLongitud)
    {
        return ComercialSdk.fLeeDatoDocumento(aCampo, aValor, aLongitud);
    }

    public int fLeeDatoMovimiento(string aCampo, StringBuilder aValor, int aLen)
    {
        return ComercialSdk.fLeeDatoMovimiento(aCampo, aValor, aLen);
    }

    public int fLeeDatoMovtoContable(string aCampo, StringBuilder aValor, int aLen)
    {
        return ComercialSdk.fLeeDatoMovtoContable(aCampo, aValor, aLen);
    }

    public int fLeeDatoParametros(string aCampo, StringBuilder aValor, int aLen)
    {
        return ComercialSdk.fLeeDatoParametros(aCampo, aValor, aLen);
    }

    public int fLeeDatoProducto(string aCampo, StringBuilder aValor, int aLen)
    {
        return ComercialSdk.fLeeDatoProducto(aCampo, aValor, aLen);
    }

    public int fLeeDatoUnidad(string aCampo, StringBuilder aValor, int aLen)
    {
        return ComercialSdk.fLeeDatoUnidad(aCampo, aValor, aLen);
    }

    public int fLeeDatoValorClasif(string aCampo, StringBuilder aValor, int aLen)
    {
        return ComercialSdk.fLeeDatoValorClasif(aCampo, aValor, aLen);
    }

    public int fLlenaRegistroCteProv(ref tCteProv astCteProv, int aEsAlta)
    {
        return ComercialSdk.fLlenaRegistroCteProv(ref astCteProv, aEsAlta);
    }

    public int fLlenaRegistroDireccion(ref tDireccion astDireccion, int aEsAlta)
    {
        return ComercialSdk.fLlenaRegistroDireccion(ref astDireccion, aEsAlta);
    }

    public int fLlenaRegistroProducto(ref tProducto astProducto, int aEsAlta)
    {
        return ComercialSdk.fLlenaRegistroProducto(ref astProducto, aEsAlta);
    }

    public int fLlenaRegistroUnidad(ref tUnidad astUnidad)
    {
        return ComercialSdk.fLlenaRegistroUnidad(ref astUnidad);
    }

    public int fLlenaRegistroValorClasif(ref tValorClasificacion astValorClasif)
    {
        return ComercialSdk.fLlenaRegistroValorClasif(ref astValorClasif);
    }

    public int fModificaCostoEntrada(string aIdMovimiento, string aCostoEntrada)
    {
        return ComercialSdk.fModificaCostoEntrada(aIdMovimiento, aCostoEntrada);
    }

    public int fModificaCuentaBancariaCliente(string aCuentaBancaria, string aNombreCuenta, string aNombreMoneda, string aClaveBanco,
        string aRfcBanco, string aClabe, string aNombreExtranjero, string aCodigoCliente)
    {
        return ComercialSdk.fModificaCuentaBancariaCliente(aCuentaBancaria, aNombreCuenta, aNombreMoneda, aClaveBanco, aRfcBanco, aClabe,
            aNombreExtranjero, aCodigoCliente);
    }

    public int fModificaCuentaBancariaEmpresa(string aCuentaBancaria, string aNombreCuenta, string aNombreMoneda, string aClaveBanco,
        string aRfcBanco, string aClabe, string aNombreExtranjero)
    {
        return ComercialSdk.fModificaCuentaBancariaEmpresa(aCuentaBancaria, aNombreCuenta, aNombreMoneda, aClaveBanco, aRfcBanco, aClabe,
            aNombreExtranjero);
    }

    public int fObtenCeryKey(int aIdFirmarl, string aRutaKey, string aRutaCer)
    {
        return ComercialSdk.fObtenCeryKey(aIdFirmarl, aRutaKey, aRutaCer);
    }

    public int fObtieneDatosCFDI(string atPtrPassword)
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fObtieneLicencia(StringBuilder aCodAcvtiva, StringBuilder aCodSitio, StringBuilder aSerie, StringBuilder aTagVersion)
    {
        return ComercialSdk.fObtieneLicencia(aCodAcvtiva, aCodSitio, aSerie, aTagVersion);
    }

    public int fObtienePassProxy(StringBuilder aPassProxy)
    {
        return ComercialSdk.fObtienePassProxy(aPassProxy);
    }

    public int fObtieneUnidadesPendientes(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen, StringBuilder aUnidades)
    {
        return ComercialSdk.fObtieneUnidadesPendientes(aConceptoDocto, aCodigoProducto, aCodigoAlmacen, aUnidades);
    }

    public int fObtieneUnidadesPendientesCarac(string aConceptoDocto, string aCodigoProducto, string aCodigoAlmacen,
        string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, StringBuilder aUnidades)
    {
        return ComercialSdk.fObtieneUnidadesPendientesCarac(aConceptoDocto, aCodigoProducto, aCodigoAlmacen, aValorCaracteristica1,
            aValorCaracteristica2, aValorCaracteristica3, aUnidades);
    }

    public int fPosAnteriorAgente()
    {
        return ComercialSdk.fPosAnteriorAgente();
    }

    public int fPosAnteriorAlmacen()
    {
        return ComercialSdk.fPosAnteriorAlmacen();
    }

    public int fPosAnteriorClasificacion()
    {
        return ComercialSdk.fPosAnteriorClasificacion();
    }

    public int fPosAnteriorConceptoDocto()
    {
        return ComercialSdk.fPosAnteriorConceptoDocto();
    }

    public int fPosAnteriorCteProv()
    {
        return ComercialSdk.fPosAnteriorCteProv();
    }

    public int fPosAnteriorDireccion()
    {
        return ComercialSdk.fPosAnteriorDireccion();
    }

    public int fPosAnteriorDocumento()
    {
        return ComercialSdk.fPosAnteriorDocumento();
    }

    public int fPosAnteriorMovimiento()
    {
        return ComercialSdk.fPosAnteriorMovimiento();
    }

    public int fPosAnteriorProducto()
    {
        return ComercialSdk.fPosAnteriorProducto();
    }

    public int fPosAnteriorUnidad()
    {
        return ComercialSdk.fPosAnteriorUnidad();
    }

    public int fPosAnteriorValorClasif()
    {
        return ComercialSdk.fPosAnteriorValorClasif();
    }

    public int fPosBOF()
    {
        return ComercialSdk.fPosBOF();
    }

    public int fPosBOFAgente()
    {
        return ComercialSdk.fPosBOFAgente();
    }

    public int fPosBOFAlmacen()
    {
        return ComercialSdk.fPosBOFAlmacen();
    }

    public int fPosBOFClasificacion()
    {
        return ComercialSdk.fPosBOFClasificacion();
    }

    public int fPosBOFConceptoDocto()
    {
        return ComercialSdk.fPosBOFConceptoDocto();
    }

    public int fPosBOFCteProv()
    {
        return ComercialSdk.fPosBOFCteProv();
    }

    public int fPosBOFDireccion()
    {
        return ComercialSdk.fPosBOFDireccion();
    }

    public int fPosBOFProducto()
    {
        return ComercialSdk.fPosBOFProducto();
    }

    public int fPosBOFUnidad()
    {
        return ComercialSdk.fPosBOFUnidad();
    }

    public int fPosBOFValorClasif()
    {
        return ComercialSdk.fPosBOFValorClasif();
    }

    public int fPosEOF()
    {
        return ComercialSdk.fPosEOF();
    }

    public int fPosEOFAgente()
    {
        return ComercialSdk.fPosEOFAgente();
    }

    public int fPosEOFAlmacen()
    {
        return ComercialSdk.fPosEOFAlmacen();
    }

    public int fPosEOFClasificacion()
    {
        return ComercialSdk.fPosEOFClasificacion();
    }

    public int fPosEOFConceptoDocto()
    {
        return ComercialSdk.fPosEOFConceptoDocto();
    }

    public int fPosEOFCteProv()
    {
        return ComercialSdk.fPosEOFCteProv();
    }

    public int fPosEOFDireccion()
    {
        return ComercialSdk.fPosEOFDireccion();
    }

    public int fPosEOFMovtoContable()
    {
        return ComercialSdk.fPosEOFMovtoContable();
    }

    public int fPosEOFProducto()
    {
        return ComercialSdk.fPosEOFProducto();
    }

    public int fPosEOFUnidad()
    {
        return ComercialSdk.fPosEOFUnidad();
    }

    public int fPosEOFValorClasif()
    {
        return ComercialSdk.fPosEOFValorClasif();
    }

    public int fPosMovimientoBOF()
    {
        return ComercialSdk.fPosMovimientoBOF();
    }

    public int fPosMovimientoEOF()
    {
        return ComercialSdk.fPosMovimientoEOF();
    }

    public int fPosPrimerAgente()
    {
        return ComercialSdk.fPosPrimerAgente();
    }

    public int fPosPrimerAlmacen()
    {
        return ComercialSdk.fPosPrimerAlmacen();
    }

    public int fPosPrimerClasificacion()
    {
        return ComercialSdk.fPosPrimerClasificacion();
    }

    public int fPosPrimerConceptoDocto()
    {
        return ComercialSdk.fPosPrimerConceptoDocto();
    }

    public int fPosPrimerCteProv()
    {
        return ComercialSdk.fPosPrimerCteProv();
    }

    public int fPosPrimerDireccion()
    {
        return ComercialSdk.fPosPrimerDireccion();
    }

    public int fPosPrimerDocumento()
    {
        return ComercialSdk.fPosPrimerDocumento();
    }

    public int fPosPrimerEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa)
    {
        return ComercialSdk.fPosPrimerEmpresa(ref aIdEmpresa, aNombreEmpresa, aDirectorioEmpresa);
    }

    public int fPosPrimerMovimiento()
    {
        return ComercialSdk.fPosPrimerMovimiento();
    }

    public int fPosPrimerMovtoContable()
    {
        return ComercialSdk.fPosPrimerMovtoContable();
    }

    public int fPosPrimerProducto()
    {
        return ComercialSdk.fPosPrimerProducto();
    }

    public int fPosPrimerUnidad()
    {
        return ComercialSdk.fPosPrimerUnidad();
    }

    public int fPosPrimerValorClasif()
    {
        return ComercialSdk.fPosPrimerValorClasif();
    }

    public int fPosSiguienteAgente()
    {
        return ComercialSdk.fPosSiguienteAgente();
    }

    public int fPosSiguienteAlmacen()
    {
        return ComercialSdk.fPosSiguienteAlmacen();
    }

    public int fPosSiguienteClasificacion()
    {
        return ComercialSdk.fPosSiguienteClasificacion();
    }

    public int fPosSiguienteConceptoDocto()
    {
        return ComercialSdk.fPosSiguienteConceptoDocto();
    }

    public int fPosSiguienteCteProv()
    {
        return ComercialSdk.fPosSiguienteCteProv();
    }

    public int fPosSiguienteDireccion()
    {
        return ComercialSdk.fPosSiguienteDireccion();
    }

    public int fPosSiguienteDocumento()
    {
        return ComercialSdk.fPosSiguienteDocumento();
    }

    public int fPosSiguienteEmpresa(ref int aIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa)
    {
        return ComercialSdk.fPosSiguienteEmpresa(ref aIdEmpresa, aNombreEmpresa, aDirectorioEmpresa);
    }

    public int fPosSiguienteMovimiento()
    {
        return ComercialSdk.fPosSiguienteMovimiento();
    }

    public int fPosSiguienteMovtoContable()
    {
        return ComercialSdk.fPosSiguienteMovtoContable();
    }

    public int fPosSiguienteProducto()
    {
        return ComercialSdk.fPosSiguienteProducto();
    }

    public int fPosSiguienteUnidad()
    {
        return ComercialSdk.fPosSiguienteUnidad();
    }

    public int fPosSiguienteValorClasif()
    {
        return ComercialSdk.fPosSiguienteValorClasif();
    }

    public int fPosUltimaConceptoDocto()
    {
        return ComercialSdk.fPosUltimaConceptoDocto();
    }

    public int fPosUltimaDireccion()
    {
        return ComercialSdk.fPosUltimaDireccion();
    }

    public int fPosUltimoAgente()
    {
        return ComercialSdk.fPosUltimoAgente();
    }

    public int fPosUltimoAlmacen()
    {
        return ComercialSdk.fPosUltimoAlmacen();
    }

    public int fPosUltimoClasificacion()
    {
        return ComercialSdk.fPosUltimoClasificacion();
    }

    public int fPosUltimoCteProv()
    {
        return ComercialSdk.fPosUltimoCteProv();
    }

    public int fPosUltimoDocumento()
    {
        return ComercialSdk.fPosUltimoDocumento();
    }

    public int fPosUltimoMovimiento()
    {
        return ComercialSdk.fPosUltimoMovimiento();
    }

    public int fPosUltimoProducto()
    {
        return ComercialSdk.fPosUltimoProducto();
    }

    public int fPosUltimoUnidad()
    {
        return ComercialSdk.fPosUltimoUnidad();
    }

    public int fPosUltimoValorClasif()
    {
        return ComercialSdk.fPosUltimoValorClasif();
    }

    public int fProyectoEmpresaDoctos(string aCodigoProyecto)
    {
        return ComercialSdk.fProyectoEmpresaDoctos(aCodigoProyecto);
    }

    public int fRecosteoProducto(string aCodigoProducto, int aEjercicio, int aPeriodo, string aCodigoClasificacion1,
        string aCodigoClasificacion2, string aCodigoClasificacion3, string aCodigoClasificacion4, string aCodigoClasificacion5,
        string aCodigoClasificacion6, string aNombreBitacora, int aSobreEscribirBitacora, int aEsCalculoArimetico)
    {
        return ComercialSdk.fRecosteoProducto(aCodigoProducto, aEjercicio, aPeriodo, aCodigoClasificacion1, aCodigoClasificacion2,
            aCodigoClasificacion3, aCodigoClasificacion4, aCodigoClasificacion5, aCodigoClasificacion6, aNombreBitacora,
            aSobreEscribirBitacora, aEsCalculoArimetico);
    }

    public int fRecuperarRelacionesCFDIs(string aCodConcepto, string aSerie, string aFolio, string aTipoRelacion, StringBuilder aUUIDs,
        string aRutaNombreArchivoInfo)
    {
        return ComercialSdk.fRecuperarRelacionesCFDIs(aCodConcepto, aSerie, aFolio, aTipoRelacion, aUUIDs, aRutaNombreArchivoInfo);
    }

    public int fRecuperaTipoProducto(ref bool aUnidades, ref bool aSerie, ref bool aLote, ref bool aPedimento, ref bool aCaracteristicas)
    {
        return ComercialSdk.fRecuperaTipoProducto(ref aUnidades, ref aSerie, ref aLote, ref aPedimento, ref aCaracteristicas);
    }

    public int fRegresaCostoCapa(string aCodigoProducto, string aCodigoAlmacen, double aUnidades, StringBuilder aImporteCosto)
    {
        return ComercialSdk.fRegresaCostoCapa(aCodigoProducto, aCodigoAlmacen, aUnidades, aImporteCosto);
    }

    public int fRegresaCostoEstandar(string aCodigoProducto, StringBuilder aCostoEstandar)
    {
        return ComercialSdk.fRegresaCostoEstandar(aCodigoProducto, aCostoEstandar);
    }

    public int fRegresaCostoPromedio(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        StringBuilder aCostoPromedio)
    {
        return ComercialSdk.fRegresaCostoPromedio(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, aCostoPromedio);
    }

    public int fRegresaExistencia(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        ref double aExistencia)
    {
        return ComercialSdk.fRegresaExistencia(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, ref aExistencia);
    }

    public int fRegresaExistenciaCaracteristicas(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        string aValorCaracteristica1, string aValorCaracteristica2, string aValorCaracteristica3, ref double aExistencia)
    {
        return ComercialSdk.fRegresaExistenciaCaracteristicas(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, aValorCaracteristica1,
            aValorCaracteristica2, aValorCaracteristica3, ref aExistencia);
    }

    public int fRegresaExistenciaLotePedimento(string aCodigoProducto, string aCodigoAlmacen, string aPedimento, string aLote,
        ref double aExistencia)
    {
        return ComercialSdk.fRegresaExistenciaLotePedimento(aCodigoProducto, aCodigoAlmacen, aPedimento, aLote, ref aExistencia);
    }

    public int fRegresaIVACargo(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero,
        double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas)
    {
        return ComercialSdk.fRegresaIVACargo(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas,
            aIVATasa15, aIVATasa10, aIVAOtrasTasas);
    }

    public int fRegresaIVACargo_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11,
        double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16,
        double aIVATasa11, double aIVAOtrasTasas)
    {
        return ComercialSdk.fRegresaIVACargo_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero,
            aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas);
    }

    public int fRegresaIVACargoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16,
        double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10,
        double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI)
    {
        return ComercialSdk.fRegresaIVACargoRet_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero,
            aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas, aRetIVA, aRetI);
    }

    public int fRegresaIVAPago(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasaCero, double aNetoTasaExcenta,
        double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVAOtrasTasas)
    {
        return ComercialSdk.fRegresaIVAPago(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasaCero, aNetoTasaExcenta, aNetoOtrasTasas,
            aIVATasa15, aIVATasa10, aIVAOtrasTasas);
    }

    public int fRegresaIVAPago_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16, double aNetoTasa11,
        double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10, double aIVATasa16,
        double aIVATasa11, double aIVAOtrasTasas)
    {
        return ComercialSdk.fRegresaIVAPago_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero,
            aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas);
    }

    public int fRegresaIVAPagoRet_2010(tLlaveDoc aLlaveDocto, double aNetoTasa15, double aNetoTasa10, double aNetoTasa16,
        double aNetoTasa11, double aNetoTasaCero, double aNetoTasaExcenta, double aNetoOtrasTasas, double aIVATasa15, double aIVATasa10,
        double aIVATasa16, double aIVATasa11, double aIVAOtrasTasas, double aRetIVA, double aRetI)
    {
        return ComercialSdk.fRegresaIVAPagoRet_2010(aLlaveDocto, aNetoTasa15, aNetoTasa10, aNetoTasa16, aNetoTasa11, aNetoTasaCero,
            aNetoTasaExcenta, aNetoOtrasTasas, aIVATasa15, aIVATasa10, aIVATasa16, aIVATasa11, aIVAOtrasTasas, aRetIVA, aRetI);
    }

    public int fRegresaPrecioVenta(string aCodigoConcepto, string aCodigoCliente, string aCodigoProducto, StringBuilder aPrecioVenta)
    {
        return ComercialSdk.fRegresaPrecioVenta(aCodigoConcepto, aCodigoCliente, aCodigoProducto, aPrecioVenta);
    }

    public int fRegresaUltimoCosto(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia,
        StringBuilder aUltimoCosto)
    {
        return ComercialSdk.fRegresaUltimoCosto(aCodigoProducto, aCodigoAlmacen, aAnio, aMes, aDia, aUltimoCosto);
    }

    public int fRegresPorcentajeImpuesto(int aIdConceptoDocumento, int aIdClienteProveedor, int aIdProducto, ref double aPorcentajeImpuesto)
    {
        return ComercialSdk.fRegresPorcentajeImpuesto(aIdConceptoDocumento, aIdClienteProveedor, aIdProducto, ref aPorcentajeImpuesto);
    }

    public int fSaldarDocumento(ref tLlaveDoc aDoctoaPagar, ref tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha)
    {
        return ComercialSdk.fSaldarDocumento(ref aDoctoaPagar, ref aDoctoPago, aImporte, aIdMoneda, aFecha);
    }

    public int fSaldarDocumento_Param(string aCodConcepto_Pagar, string aSerie_Pagar, double aFolio_Pagar, string aCodConcepto_Pago,
        string aSerie_Pago, double aFolio_Pago, double aImporte, int aIdMoneda, string aFecha)
    {
        return ComercialSdk.fSaldarDocumento_Param(aCodConcepto_Pagar, aSerie_Pagar, aFolio_Pagar, aCodConcepto_Pago, aSerie_Pago,
            aFolio_Pago, aImporte, aIdMoneda, aFecha);
    }

    public int fSaldarDocumentoCheqPAQ(tLlaveDoc aDoctoaPagar, tLlaveDoc aDoctoPago, double aImporte, int aIdMoneda, string aFecha,
        double aTipoCambioCheqPAQ)
    {
        return ComercialSdk.fSaldarDocumentoCheqPAQ(aDoctoaPagar, aDoctoPago, aImporte, aIdMoneda, aFecha, aTipoCambioCheqPAQ);
    }

    public int fSetDatoAgente(string aCampo, string aValor)
    {
        return ComercialSdk.fSetDatoAgente(aCampo, aValor);
    }

    public int fSetDatoAlmacen(string aCampo, string aValor)
    {
        return ComercialSdk.fSetDatoAlmacen(aCampo, aValor);
    }

    public int fSetDatoClasificacion(string aCampo, string aValor)
    {
        return ComercialSdk.fSetDatoClasificacion(aCampo, aValor);
    }

    public int fSetDatoConceptoDocto(string aCampo, string aValor)
    {
        return ComercialSdk.fSetDatoConceptoDocto(aCampo, aValor);
    }

    public int fSetDatoCteProv(string aCampo, string aValor)
    {
        return ComercialSdk.fSetDatoCteProv(aCampo, aValor);
    }

    public int fSetDatoDireccion(string aCampo, string aValor)
    {
        return ComercialSdk.fSetDatoDireccion(aCampo, aValor);
    }

    public int fSetDatoDocumento(string aCampo, string aValor)
    {
        return ComercialSdk.fSetDatoDocumento(aCampo, aValor);
    }

    public int fSetDatoMovimiento(string aCampo, string aValor)
    {
        return ComercialSdk.fSetDatoMovimiento(aCampo, aValor);
    }

    public int fSetDatoMovtoContable(string aCampo, string aValor)
    {
        return ComercialSdk.fSetDatoMovtoContable(aCampo, aValor);
    }

    public int fSetDatoParametros(string aCampo, StringBuilder aValor)
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fSetDatoProducto(string aCampo, string aValor)
    {
        return ComercialSdk.fSetDatoProducto(aCampo, aValor);
    }

    public int fSetDatoUnidad(string aCampo, string aValor)
    {
        return ComercialSdk.fSetDatoUnidad(aCampo, aValor);
    }

    public int fSetDatoValorClasif(string aCampo, string aValor)
    {
        return ComercialSdk.fSetDatoValorClasif(aCampo, aValor);
    }

    public int fSetDescripcionProducto(string aCampo, string aValor)
    {
        return ComercialSdk.fSetDescripcionProducto(aCampo, aValor);
    }

    public int fSetFiltroDocumento(string aFechaInicio, string aFechaFin, string aCodigoConcepto, string aCodigoCteProv)
    {
        return ComercialSdk.fSetFiltroDocumento(aFechaInicio, aFechaFin, aCodigoConcepto, aCodigoCteProv);
    }

    public int fSetFiltroMovimiento(int aIdDocumento)
    {
        return ComercialSdk.fSetFiltroMovimiento(aIdDocumento);
    }

    public void fSetModoImportacion(bool aImportacion)
    {
        ComercialSdk.fSetModoImportacion(aImportacion);
    }

    public int fSetNombrePAQ(string aSistema)
    {
        return ComercialSdk.fSetNombrePAQ(aSistema);
    }

    public int fSiguienteFolio(string aCodigoConcepto, StringBuilder aSerie, ref double aFolio)
    {
        return ComercialSdk.fSiguienteFolio(aCodigoConcepto, aSerie, ref aFolio);
    }

    public void fTerminaSDK()
    {
        ComercialSdk.fTerminaSDK();
    }

    public int fTimbraComplementoPagoXML(string aRutaXML, string aCodConcepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado,
        string aPass, string aRutaFormato)
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fTimbraComplementoXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado,
        string aPass, string aRutaFormato, int aComplemento)
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fTimbraNominaXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado,
        string aPass, string aRutaFormato)
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int fTimbraXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado, string aPass,
        string aRutaFormato)
    {
        throw new NotImplementedException("Esta funcion no funciona en CONTPAQi Comercial.");
    }

    public int InicializarSDK()
    {
        SetCurrentDirectory();
        return fSetNombrePAQ(NombrePaq);
    }

    public int InicializarSDK(string usuario, string password)
    {
        SetCurrentDirectory();
        fInicioSesionSDK(usuario, password);
        return fSetNombrePAQ(NombrePaq);
    }

    public int InicializarSDK(string usuario, string password, string usuarioContabilidad, string passwordContabilidad)
    {
        int sdkResult = InicializarSDK(usuario, password);
        if (sdkResult == SdkResultConstants.Success) fInicioSesionSDKCONTPAQi(usuarioContabilidad, passwordContabilidad);
        return sdkResult;
    }

    public string LeeDatoAgente(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        ComercialSdk.fLeeDatoAgente(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoAlmacen(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        ComercialSdk.fLeeDatoAlmacen(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
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
        ComercialSdk.fLeeDatoClasificacion(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoClienteProveedor(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        ComercialSdk.fLeeDatoCteProv(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoConcepto(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        ComercialSdk.fLeeDatoConceptoDocto(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoDireccion(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        ComercialSdk.fLeeDatoDireccion(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoDocumento(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        ComercialSdk.fLeeDatoDocumento(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoMovimiento(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        ComercialSdk.fLeeDatoMovimiento(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoParametros(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        ComercialSdk.fLeeDatoParametros(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoProducto(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        ComercialSdk.fLeeDatoProducto(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoUnidad(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        ComercialSdk.fLeeDatoUnidad(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeDatoValorClasificacion(string dato, int longitud)
    {
        var valor = new StringBuilder(longitud);
        ComercialSdk.fLeeDatoValorClasif(dato, valor, longitud).ToResultadoSdk(this).ThrowIfError();
        return valor.ToString();
    }

    public string LeeMensajeError(int numeroError)
    {
        var mensajeError = new StringBuilder(512);
        fError(numeroError, mensajeError, 512);
        return mensajeError.ToString();
    }

    public string NombreLlaveRegistro => ComercialSdkConstants.NombreLlaveRegistro;

    public string NombrePaq => ComercialSdkConstants.NombrePaq;

    private void SetCurrentDirectory()
    {
        string lEntrada = RegistryHelper.GetDirectorioBaseFromRegistry(NombreLlaveRegistro);
        Directory.SetCurrentDirectory(lEntrada);
    }
}

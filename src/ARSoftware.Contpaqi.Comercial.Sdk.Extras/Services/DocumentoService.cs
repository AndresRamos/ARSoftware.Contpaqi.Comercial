﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;

public class DocumentoService : IDocumentoService
{
    private readonly IAgenteRepository<AgenteDto> _agenteRepository;
    private readonly IContpaqiSdk _sdk;

    public DocumentoService(IContpaqiSdk sdk, IAgenteRepository<AgenteDto> agenteRepository)
    {
        _sdk = sdk;
        _agenteRepository = agenteRepository;
    }

    /// <inheritdoc />
    public void Actualizar(int documentoId, Dictionary<string, string> datosDocumento)
    {
        _sdk.fBuscarIdDocumento(documentoId).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditarDocumento().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosDocumento);
        _sdk.fGuardaDocumento().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Actualizar(string codigoConcepto, string serie, string folio, Dictionary<string, string> datosDocumento)
    {
        _sdk.fBuscarDocumento(codigoConcepto, serie, folio).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditarDocumento().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosDocumento);
        _sdk.fGuardaDocumento().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Actualizar(tLlaveDoc tLlaveDocumento, Dictionary<string, string> datosDocumento)
    {
        _sdk.fBuscaDocumento(ref tLlaveDocumento).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditarDocumento().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosDocumento);
        _sdk.fGuardaDocumento().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Actualizar(Documento documento)
    {
        Dictionary<string, string> datosDocumento = documento.ToDatosDictionary();
        datosDocumento.Remove(nameof(admDocumentos.CIDDOCUMENTO));
        datosDocumento.Remove(nameof(admDocumentos.CIDCONCEPTODOCUMENTO));
        datosDocumento.Remove(nameof(admDocumentos.CSERIEDOCUMENTO));
        datosDocumento.Remove(nameof(admDocumentos.CFOLIO));
        datosDocumento.Remove(nameof(admDocumentos.CFECHA));
        datosDocumento.Remove(nameof(admDocumentos.CIDCLIENTEPROVEEDOR));
        datosDocumento.Remove(nameof(admDocumentos.CIDMONEDA));
        datosDocumento.Remove(nameof(admDocumentos.CTIPOCAMBIO));
        datosDocumento.Remove(nameof(admDocumentos.CIDAGENTE));
        datosDocumento.Remove(nameof(admDocumentos.CTOTAL));

        if (documento.Agente is not null)
        {
            AgenteDto? agente = null;

            if (documento.Agente.Id != 0)
                agente = _agenteRepository.BuscarPorId(documento.Agente.Id);
            else if (string.IsNullOrWhiteSpace(documento.Agente.Codigo) == false)
                agente = _agenteRepository.BuscarPorCodigo(documento.Agente.Codigo);

            if (agente is not null) datosDocumento.Add(nameof(admDocumentos.CIDAGENTE), agente.CIDAGENTE.ToString());
        }

        if (documento.Id != 0)
            Actualizar(documento.Id, datosDocumento);
        else
            Actualizar(documento.Concepto.Codigo, documento.Serie, documento.Folio.ToString(), datosDocumento);
    }

    /// <inheritdoc />
    public tLlaveDoc BuscarSiguienteSerieYFolio(string codigoConcepto)
    {
        double folio = 0;
        var serie = new StringBuilder();
        _sdk.fSiguienteFolio(codigoConcepto, serie, ref folio).ToResultadoSdk(_sdk).ThrowIfError();
        return new tLlaveDoc { aCodConcepto = codigoConcepto, aSerie = serie.ToString(), aFolio = folio };
    }

    /// <inheritdoc />
    public void Cancelar(int idDocumento, string contrasenaCertificado)
    {
        _sdk.fBuscarIdDocumento(idDocumento).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fCancelaDoctoInfo(contrasenaCertificado).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fCancelaDocumento().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Cancelar(int idDocumento, string contrasenaCertificado, MotivoCancelacionEnum motivoCancelacion, string uuidRemplazo)
    {
        _sdk.fBuscarIdDocumento(idDocumento).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fCancelaDoctoInfo(contrasenaCertificado).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fCancelaDocumentoConMotivo(motivoCancelacion.Value, uuidRemplazo);
    }

    /// <inheritdoc />
    public void Cancelar(tLlaveDoc tLlaveDocumento, string contrasenaCertificado, MotivoCancelacionEnum motivoCancelacion,
        string uuidRemplazo)
    {
        _sdk.fBuscaDocumento(ref tLlaveDocumento).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fCancelaDoctoInfo(contrasenaCertificado).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fCancelaDocumentoConMotivo(motivoCancelacion.Value, uuidRemplazo);
    }

    /// <inheritdoc />
    public void CancelarAdministrativamente(int idDocumento)
    {
        _sdk.fBuscarIdDocumento(idDocumento).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fCancelaDocumentoAdministrativamente().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void CancelarAdministrativamente(string codigoConcepto, string serie, string folio)
    {
        _sdk.fBuscarDocumento(codigoConcepto, serie, folio).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fCancelaDocumentoAdministrativamente().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void CancelarAdministrativamente(tLlaveDoc tLlaveDocumento)
    {
        _sdk.fBuscaDocumento(ref tLlaveDocumento).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fCancelaDocumentoAdministrativamente().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public int Crear(tDocumento documento)
    {
        var documentoId = 0;
        _sdk.fAltaDocumento(ref documentoId, ref documento).ToResultadoSdk(_sdk).ThrowIfError();
        return documentoId;
    }

    /// <inheritdoc />
    public int Crear(Dictionary<string, string> datosDocumento)
    {
        _sdk.fInsertarDocumento().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosDocumento);
        _sdk.fGuardaDocumento().ToResultadoSdk(_sdk).ThrowIfError();
        string idDocumentoDato = _sdk.LeeDatoDocumento(nameof(admDocumentos.CIDDOCUMENTO), SdkConstantes.kLongId);
        return int.Parse(idDocumentoDato);
    }

    /// <inheritdoc />
    public int Crear(Documento documento)
    {
        tDocumento documentoSdk = documento.ToSdkDocumento();
        int nuevoDocumentoId = Crear(documentoSdk);

        var datosDocumento = new Dictionary<string, string>(documento.DatosExtra);

        if (!string.IsNullOrEmpty(documento.Observaciones))
            datosDocumento.TryAdd(nameof(admDocumentos.COBSERVACIONES), documento.Observaciones);

        if (documento.FormaPago is not null) datosDocumento.TryAdd(nameof(admDocumentos.CMETODOPAG), documento.FormaPago.Value);

        if (documento.MetodoPago is not null)
            datosDocumento.TryAdd(nameof(admDocumentos.CCANTPARCI), MetodoPagoHelper.ConvertToSdkValue(documento.MetodoPago).ToString());

        Actualizar(nuevoDocumentoId, datosDocumento);

        return nuevoDocumentoId;
    }

    /// <inheritdoc />
    public int CrearCargoAbono(tDocumento documento)
    {
        _sdk.fAltaDocumentoCargoAbono(ref documento).ToResultadoSdk(_sdk).ThrowIfError();
        string idDocumentoDato = _sdk.LeeDatoDocumento(nameof(admDocumentos.CIDDOCUMENTO), SdkConstantes.kLongId);
        return int.Parse(idDocumentoDato);
    }

    /// <inheritdoc />
    public int CrearCargoAbono(Documento documento)
    {
        tDocumento documentoSdk = documento.ToSdkDocumento();
        return CrearCargoAbono(documentoSdk);
    }

    /// <inheritdoc />
    public void DesbloquearDocumento(int idDocumento)
    {
        _sdk.fBuscarIdDocumento(idDocumento).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fDesbloqueaDocumento().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void DesbloquearDocumento(LlaveDocumento llave)
    {
        var llaveSdk = new tLlaveDoc { aCodConcepto = llave.ConceptoCodigo, aSerie = llave.Serie, aFolio = llave.Folio };
        _sdk.fBuscaDocumento(ref llaveSdk);
        _sdk.fDesbloqueaDocumento().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Eliminar(int idDocumento)
    {
        _sdk.fBuscarIdDocumento(idDocumento).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fBorraDocumento().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Eliminar(string codigoConcepto, string serie, string folio)
    {
        _sdk.fBuscarDocumento(codigoConcepto, serie, folio).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fBorraDocumento().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Eliminar(tLlaveDoc tLlaveDocumento)
    {
        _sdk.fBuscaDocumento(ref tLlaveDocumento).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fBorraDocumento().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void GenerarDocumentoDigital(string codigoConceptoDocumento, string serieDocumento, double folioDocumento,
        TipoArchivoDigital tipoArchivo, string rutaPlantilla)
    {
        _sdk.fEntregEnDiscoXML(codigoConceptoDocumento, serieDocumento, folioDocumento, (int)tipoArchivo, rutaPlantilla)
            .ToResultadoSdk(_sdk)
            .ThrowIfError();
    }

    /// <inheritdoc />
    public void GenerarDocumentoDigital(tLlaveDoc documento, TipoArchivoDigital tipoArchivo, string rutaPlantilla)
    {
        _sdk.fEntregEnDiscoXML(documento.aCodConcepto, documento.aSerie, documento.aFolio, (int)tipoArchivo, rutaPlantilla)
            .ToResultadoSdk(_sdk)
            .ThrowIfError();
    }

    /// <inheritdoc />
    public void GenerarDocumentoDigital(tLlaveDoc documento, TipoArchivoDigital tipoArchivo, string rutaPlantilla,
        string rutaDirectorioEmpresa, string rutaArchivoDestino)
    {
        GenerarDocumentoDigital(documento, tipoArchivo, rutaPlantilla);
        string rutaArchivoDigital = ArchivoDigitalHelper.GenerarRutaArchivoDigital(tipoArchivo, rutaDirectorioEmpresa, documento.aSerie,
            documento.aFolio.ToString(CultureInfo.InvariantCulture));
        File.Copy(rutaArchivoDigital, rutaArchivoDestino, true);
    }

    /// <inheritdoc />
    public void RelacionarDocumentos(tLlaveDoc documento, string tipoRelacion, tLlaveDoc documentoRelacionado)
    {
        _sdk.fAgregarRelacionCFDI(documento.aCodConcepto, documento.aSerie, documento.aFolio.ToString(CultureInfo.InvariantCulture),
                tipoRelacion, documentoRelacionado.aCodConcepto, documentoRelacionado.aSerie,
                documentoRelacionado.aFolio.ToString(CultureInfo.InvariantCulture))
            .ToResultadoSdk(_sdk)
            .ThrowIfError();
    }

    /// <inheritdoc />
    public void RelacionarDocumentos(tLlaveDoc documento, string tipoRelacion, string uuid)
    {
        _sdk.fAgregarRelacionCFDI2(documento.aCodConcepto, documento.aSerie, documento.aFolio.ToString(CultureInfo.InvariantCulture),
                tipoRelacion, uuid)
            .ToResultadoSdk(_sdk)
            .ThrowIfError();
    }

    /// <inheritdoc />
    public void SaldarDocumento(tLlaveDoc documentoAPagar, tLlaveDoc documentoPago, DateTime fecha, double importe, int monedaId)
    {
        _sdk.fSaldarDocumento(ref documentoAPagar, ref documentoPago, importe, monedaId, fecha.ToSdkFecha())
            .ToResultadoSdk(_sdk)
            .ThrowIfError();
    }

    /// <inheritdoc />
    public void Timbrar(string codigoConceptoDocumento, string serieDocumento, double folioDocumento, string contrasenaCertificado,
        string rutaArchivoAdicional)
    {
        _sdk.fEmitirDocumento(codigoConceptoDocumento, serieDocumento, folioDocumento, contrasenaCertificado, rutaArchivoAdicional)
            .ToResultadoSdk(_sdk)
            .ThrowIfError();
    }

    /// <inheritdoc />
    public void Timbrar(tLlaveDoc documento, string contrasenaCertificado, string rutaArchivoAdicional = "")
    {
        _sdk.fEmitirDocumento(documento.aCodConcepto, documento.aSerie, documento.aFolio, contrasenaCertificado, rutaArchivoAdicional)
            .ToResultadoSdk(_sdk)
            .ThrowIfError();
    }

    public void SetDatos(Dictionary<string, string> datos)
    {
        foreach (KeyValuePair<string, string> dato in datos)
            _sdk.fSetDatoDocumento(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
    }
}

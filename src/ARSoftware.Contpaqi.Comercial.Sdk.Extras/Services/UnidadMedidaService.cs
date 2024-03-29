﻿using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;

public class UnidadMedidaService : IUnidadMedidaService
{
    private readonly IContpaqiSdk _sdk;

    public UnidadMedidaService(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public void Actualizar(string nombreUnidad, tUnidad unidad)
    {
        _sdk.fActualizaUnidad(nombreUnidad, ref unidad).ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Actualizar(int idUnidad, Dictionary<string, string> datosUnidad)
    {
        _sdk.fBuscaIdUnidad(idUnidad).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditaUnidad().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosUnidad);
        _sdk.fGuardaUnidad().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Actualizar(string nombreUnidad, Dictionary<string, string> datosUnidad)
    {
        _sdk.fBuscaUnidad(nombreUnidad).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditaUnidad().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosUnidad);
        _sdk.fGuardaUnidad().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Actualizar(UnidadMedida unidad)
    {
        Dictionary<string, string> datosUnidad = unidad.ToDatosDictionary();
        datosUnidad.Remove(nameof(admUnidadesMedidaPeso.CIDUNIDAD));
        if (unidad.Id != 0)
            Actualizar(unidad.Id, datosUnidad);
        else
            Actualizar(unidad.Nombre, datosUnidad);
    }

    /// <inheritdoc />
    public int Crear(tUnidad unidad)
    {
        var idUnidad = 0;
        _sdk.fAltaUnidad(ref idUnidad, ref unidad).ToResultadoSdk(_sdk).ThrowIfError();
        return idUnidad;
    }

    /// <inheritdoc />
    public int Crear(Dictionary<string, string> datosUnidad)
    {
        _sdk.fInsertaUnidad().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosUnidad);
        _sdk.fGuardaUnidad().ToResultadoSdk(_sdk).ThrowIfError();
        string idUnidadDato = _sdk.LeeDatoUnidad(nameof(admUnidadesMedidaPeso.CIDUNIDAD), SdkConstantes.kLongId);
        return int.Parse(idUnidadDato);
    }

    /// <inheritdoc />
    public int Crear(UnidadMedida unidad)
    {
        tUnidad unidadSdk = unidad.ToSdkUnidad();
        int nuevaUnidadId = Crear(unidadSdk);

        var datosUnidad = new Dictionary<string, string>(unidad.DatosExtra);
        if (!string.IsNullOrWhiteSpace(unidad.ClaveSat)) datosUnidad.TryAdd(nameof(admUnidadesMedidaPeso.CCLAVEINT), unidad.ClaveSat);
        Actualizar(nuevaUnidadId, datosUnidad);

        return nuevaUnidadId;
    }

    /// <inheritdoc />
    public void Eliminar(int idUnidad)
    {
        _sdk.fBuscaIdUnidad(idUnidad).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fBorraUnidad().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Eliminar(string nombreUnidad)
    {
        _sdk.fEliminarUnidad(nombreUnidad).ToResultadoSdk(_sdk).ThrowIfError();
    }

    public void SetDatos(Dictionary<string, string> datos)
    {
        foreach (KeyValuePair<string, string> dato in datos) _sdk.fSetDatoUnidad(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
    }
}

using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;

public class AlmacenService : IAlmacenService
{
    private readonly IContpaqiSdk _sdk;

    public AlmacenService(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public void Actualizar(int idAlmacen, Dictionary<string, string> datosAlmacen)
    {
        _sdk.fBuscaIdAlmacen(idAlmacen).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosAlmacen);
        _sdk.fGuardaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Actualizar(string codigoAlmacen, Dictionary<string, string> datosAlmacen)
    {
        _sdk.fBuscaAlmacen(codigoAlmacen).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosAlmacen);
        _sdk.fGuardaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public int Crear(Dictionary<string, string> datosAlmacen)
    {
        _sdk.fInsertaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosAlmacen);
        _sdk.fGuardaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
        string idAlmacenDato = _sdk.LeeDatoAlmacen(nameof(admAlmacenes.CIDALMACEN), SdkConstantes.kLongId);
        return int.Parse(idAlmacenDato);
    }

    /// <inheritdoc />
    public int Crear(Almacen almacen)
    {
        Dictionary<string, string> datosAlmacen = almacen.ToDatosDictionary();
        datosAlmacen.Remove(nameof(admAlmacenes.CIDALMACEN));
        datosAlmacen.TryAdd(nameof(admAlmacenes.CFECHAALTAALMACEN), DateTime.Today.ToSdkFecha());
        return Crear(datosAlmacen);
    }

    public void SetDatos(Dictionary<string, string> datos)
    {
        foreach (KeyValuePair<string, string> dato in datos) _sdk.fSetDatoAlmacen(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
    }
}

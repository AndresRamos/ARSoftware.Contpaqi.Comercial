using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;

public class ValorClasificacionService : IValorClasificacionService
{
    private readonly IContpaqiSdk _sdk;

    public ValorClasificacionService(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public void Actualizar(int idValorClasificacion, Dictionary<string, string> datosValorClasificacion)
    {
        _sdk.fBuscaIdValorClasif(idValorClasificacion).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditaValorClasif().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosValorClasificacion);
        _sdk.fGuardaValorClasif().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Actualizar(string codigoValorClasificacion, ref tValorClasificacion valorClasificacion)
    {
        _sdk.fActualizaValorClasif(codigoValorClasificacion, ref valorClasificacion).ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public int Crear(tValorClasificacion valorClasificacion)
    {
        var idValorClasificacion = 0;
        _sdk.fAltaValorClasif(ref idValorClasificacion, ref valorClasificacion).ToResultadoSdk(_sdk).ThrowIfError();
        return idValorClasificacion;
    }

    /// <inheritdoc />
    public int Crear(Dictionary<string, string> datosValorClasificacion)
    {
        _sdk.fInsertaValorClasif().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosValorClasificacion);
        _sdk.fGuardaValorClasif().ToResultadoSdk(_sdk).ThrowIfError();
        string idValorDato = _sdk.LeeDatoValorClasificacion(nameof(admClasificacionesValores.CIDVALORCLASIFICACION), SdkConstantes.kLongId);
        return int.Parse(idValorDato);
    }

    /// <inheritdoc />
    public void Eliminar(int idValorClasificacion)
    {
        _sdk.fBuscaIdValorClasif(idValorClasificacion).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fBorraValorClasif().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Eliminar(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion, string codigoValorClasificacion)
    {
        _sdk.fEliminarValorClasif((int)tipoClasificacion, (int)numeroClasificacion, codigoValorClasificacion)
            .ToResultadoSdk(_sdk)
            .ThrowIfError();
    }

    public void SetDatos(Dictionary<string, string> datos)
    {
        foreach (KeyValuePair<string, string> dato in datos)
            _sdk.fSetDatoValorClasif(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
    }
}

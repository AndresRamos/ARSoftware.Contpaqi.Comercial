using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;

public class ClasificacionService : IClasificacionService
{
    private readonly IContpaqiSdk _sdk;

    public ClasificacionService(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    public void Actualizar(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion,
        Dictionary<string, string> datosClasificacion)
    {
        _sdk.fBuscaClasificacion((int)tipoClasificacion, (int)numeroClasificacion).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditaClasificacion().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosClasificacion);
        _sdk.fGuardaClasificacion().ToResultadoSdk(_sdk).ThrowIfError();
    }

    public void Actualizar(int idClasificacion, Dictionary<string, string> datosClasificacion)
    {
        _sdk.fBuscaIdClasificacion(idClasificacion).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditaClasificacion().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosClasificacion);
        _sdk.fGuardaClasificacion().ToResultadoSdk(_sdk).ThrowIfError();
    }

    public void SetDatos(Dictionary<string, string> datos)
    {
        foreach (KeyValuePair<string, string> dato in datos)
            _sdk.fSetDatoClasificacion(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
    }
}

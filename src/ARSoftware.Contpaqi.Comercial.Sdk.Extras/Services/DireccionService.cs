using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;

public class DireccionService : IDireccionService
{
    private readonly IContpaqiSdk _sdk;

    public DireccionService(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public void Actualizar(tDireccion direccion)
    {
        _sdk.fActualizaDireccion(ref direccion).ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Actualizar(int idDireccion, Dictionary<string, string> datosDireccion)
    {
        if (!datosDireccion.Any()) return;

        _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
        string idDireccionDato = _sdk.LeeDatoDireccion(nameof(admDomicilios.CIDDIRECCION), SdkConstantes.kLongId);
        if (idDireccion == int.Parse(idDireccionDato))
        {
            _sdk.fEditaDireccion().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatos(datosDireccion);
            _sdk.fGuardaDireccion().ToResultadoSdk(_sdk).ThrowIfError();

            return;
        }

        while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
        {
            idDireccionDato = _sdk.LeeDatoDireccion(nameof(admDomicilios.CIDDIRECCION), SdkConstantes.kLongId);
            if (idDireccion == int.Parse(idDireccionDato))
            {
                _sdk.fEditaDireccion().ToResultadoSdk(_sdk).ThrowIfError();
                SetDatos(datosDireccion);
                _sdk.fGuardaDireccion().ToResultadoSdk(_sdk).ThrowIfError();
            }

            if (_sdk.fPosEOFDireccion() == 1) return;
        }
    }

    /// <inheritdoc />
    public void Actualizar(string codigoClienteProveedor, Direccion direccion)
    {
        tDireccion direccionSdk = direccion.ToSdkDireccion();
        direccionSdk.cCodCteProv = codigoClienteProveedor;
        Actualizar(direccionSdk);
    }

    /// <inheritdoc />
    public int Crear(tDireccion direccion)
    {
        var idDireccion = 0;
        _sdk.fAltaDireccion(ref idDireccion, ref direccion).ToResultadoSdk(_sdk).ThrowIfError();
        return idDireccion;
    }

    /// <inheritdoc />
    public int Crear(Dictionary<string, string> datosDireccion)
    {
        _sdk.fInsertaDireccion().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosDireccion);
        _sdk.fGuardaDireccion().ToResultadoSdk(_sdk).ThrowIfError();
        string idDireccionDato = _sdk.LeeDatoDireccion(nameof(admDomicilios.CIDDIRECCION), SdkConstantes.kLongId);
        return int.Parse(idDireccionDato);
    }

    /// <inheritdoc />
    public int Crear(string codigoClienteProveedor, Direccion direccion)
    {
        _sdk.fBuscaCteProv(codigoClienteProveedor).ToResultadoSdk(_sdk).ThrowIfError();
        tDireccion sdkDireccion = direccion.ToSdkDireccion();
        sdkDireccion.cCodCteProv = codigoClienteProveedor;
        int nuevaDireccionId = Crear(sdkDireccion);
        return nuevaDireccionId;
    }

    public void SetDatos(Dictionary<string, string> datos)
    {
        foreach (KeyValuePair<string, string> dato in datos)
            _sdk.fSetDatoDireccion(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
    }
}

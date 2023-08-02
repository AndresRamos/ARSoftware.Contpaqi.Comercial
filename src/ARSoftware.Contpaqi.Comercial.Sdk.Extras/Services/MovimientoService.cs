using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;

public class MovimientoService : IMovimientoService
{
    private readonly IContpaqiSdk _sdk;

    public MovimientoService(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public void Actualizar(int idMovimiento, Dictionary<string, string> datosMovimiento)
    {
        _sdk.fBuscarIdMovimiento(idMovimiento).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditarMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosMovimiento);
        _sdk.fGuardaMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public int Crear(int idDocumento, tMovimientoDesc movimiento)
    {
        var movimientoId = 0;
        _sdk.fAltaMovimientoCDesct(idDocumento, ref movimientoId, ref movimiento).ToResultadoSdk(_sdk).ThrowIfError();
        return movimientoId;
    }

    /// <inheritdoc />
    public int Crear(int idDocumento, tMovimiento movimiento)
    {
        var movimientoId = 0;
        _sdk.fAltaMovimiento(idDocumento, ref movimientoId, ref movimiento).ToResultadoSdk(_sdk).ThrowIfError();
        return movimientoId;
    }

    /// <inheritdoc />
    public int Crear(int idDocumento, Movimiento movimiento)
    {
        int nuevoMovimientoId;

        if (movimiento.Descuentos is not null)
        {
            tMovimientoDesc movimientoSdk = movimiento.ToSdkMovimientoDescuento();
            nuevoMovimientoId = Crear(idDocumento, movimientoSdk);
        }
        else
        {
            tMovimiento movimientoSdk = movimiento.ToSdkMovimiento();
            nuevoMovimientoId = Crear(idDocumento, movimientoSdk);
        }

        var datosMovimiento = new Dictionary<string, string>(movimiento.DatosExtra);

        if (!string.IsNullOrWhiteSpace(movimiento.Observaciones))
            datosMovimiento.TryAdd(nameof(admMovimientos.COBSERVAMOV), movimiento.Observaciones);

        movimiento.AddImpuestosToDictionary(datosMovimiento);

        movimiento.AddRetencionesToDictionary(datosMovimiento);

        Actualizar(nuevoMovimientoId, datosMovimiento);

        foreach (SeriesCapas movimientoSeriesCapas in movimiento.SeriesCapas)
            CrearSeriesCapas(nuevoMovimientoId, movimientoSeriesCapas.ToSdkSeriesCapas());

        return nuevoMovimientoId;
    }

    /// <inheritdoc />
    public int Crear(Dictionary<string, string> datosMovimiento)
    {
        _sdk.fInsertarMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosMovimiento);
        _sdk.fGuardaMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
        string idMovimientoDato = _sdk.LeeDatoMovimiento(nameof(admMovimientos.CIDMOVIMIENTO), SdkConstantes.kLongId);
        return int.Parse(idMovimientoDato);
    }

    /// <inheritdoc />
    public void CrearSeriesCapas(int movimientoId, tSeriesCapas seriesCapas)
    {
        _sdk.fAltaMovimientoSeriesCapas(movimientoId, ref seriesCapas).ToResultadoSdk(_sdk).ThrowIfError();
    }

    /// <inheritdoc />
    public void Eliminar(int idDocumento, int idMovimiento)
    {
        _sdk.fBuscarIdMovimiento(idMovimiento).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fBorraMovimiento(idDocumento, idMovimiento).ToResultadoSdk(_sdk).ThrowIfError();
    }

    public void SetDatos(Dictionary<string, string> datos)
    {
        foreach (KeyValuePair<string, string> dato in datos)
            _sdk.fSetDatoMovimiento(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
    }
}

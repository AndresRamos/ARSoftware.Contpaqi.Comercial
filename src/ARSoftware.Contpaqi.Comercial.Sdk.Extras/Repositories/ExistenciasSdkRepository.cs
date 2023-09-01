using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

public class ExistenciasSdkRepository : IExistenciasRepository
{
    private readonly IContpaqiSdk _sdk;

    public ExistenciasSdkRepository(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public double BuscaExistencias(string codigoProducto, string codigoAlmacen, DateOnly fecha)
    {
        var existencias = 0.0;
        _sdk.fRegresaExistencia(codigoProducto, codigoAlmacen, fecha.Year.ToString(), fecha.Month.ToString(), fecha.Day.ToString(),
                ref existencias)
            .ToResultadoSdk(_sdk)
            .ThrowIfError();
        return existencias;
    }

    /// <inheritdoc />
    public double BuscaExistenciasConCaracteristicas(string codigoProducto, string codigoAlmacen, DateOnly fecha,
        string abreviaturaValorCaracteristica1, string abreviaturaValorCaracteristica2, string abreviaturaValorCaracteristica3)
    {
        var existencias = 0.0;
        _sdk.fRegresaExistenciaCaracteristicas(codigoProducto, codigoAlmacen, fecha.Year.ToString(), fecha.Month.ToString(),
                fecha.Day.ToString(), abreviaturaValorCaracteristica1, abreviaturaValorCaracteristica2, abreviaturaValorCaracteristica3,
                ref existencias)
            .ToResultadoSdk(_sdk)
            .ThrowIfError();
        return existencias;
    }

    /// <inheritdoc />
    public double BuscaExistenciasConCapas(string codigoProducto, string codigoAlmacen, string pedimento, string lote)
    {
        var existencias = 0.0;
        _sdk.fRegresaExistenciaLotePedimento(codigoProducto, codigoAlmacen, pedimento, lote, ref existencias)
            .ToResultadoSdk(_sdk)
            .ThrowIfError();
        return existencias;
    }
}

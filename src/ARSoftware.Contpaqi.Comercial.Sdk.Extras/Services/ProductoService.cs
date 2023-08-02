using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;

public class ProductoService : IProductoService
{
    private readonly IContpaqiSdk _sdk;

    public ProductoService(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    public void Actualizar(string codigoProducto, tProducto producto)
    {
        _sdk.fActualizaProducto(codigoProducto, ref producto).ToResultadoSdk(_sdk).ThrowIfError();
    }

    public void Actualizar(int idProducto, Dictionary<string, string> datosProducto)
    {
        _sdk.fBuscaIdProducto(idProducto).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditaProducto().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosProducto);
        _sdk.fGuardaProducto().ToResultadoSdk(_sdk).ThrowIfError();
    }

    public void Actualizar(string codigoProducto, Dictionary<string, string> datosProducto)
    {
        _sdk.fBuscaProducto(codigoProducto).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditaProducto().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosProducto);
        _sdk.fGuardaProducto().ToResultadoSdk(_sdk).ThrowIfError();
    }

    public int Crear(tProducto producto)
    {
        var idProducto = 0;
        _sdk.fAltaProducto(ref idProducto, ref producto).ToResultadoSdk(_sdk).ThrowIfError();
        return idProducto;
    }

    public int Crear(Dictionary<string, string> datosProducto)
    {
        _sdk.fInsertaProducto().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosProducto);
        _sdk.fGuardaProducto().ToResultadoSdk(_sdk).ThrowIfError();
        string idProductoDato = _sdk.LeeDatoProducto(nameof(admProductos.CIDPRODUCTO), SdkConstantes.kLongId);
        return int.Parse(idProductoDato);
    }

    /// <inheritdoc />
    public int Crear(Producto producto)
    {
        tProducto productoSdk = producto.ToSdkProducto();
        int nuevoProductoId = Crear(productoSdk);

        var datosProducto = new Dictionary<string, string>(producto.DatosExtra);
        if (!string.IsNullOrWhiteSpace(producto.ClaveSat)) datosProducto.TryAdd(nameof(admProductos.CCLAVESAT), producto.ClaveSat);
        Actualizar(nuevoProductoId, datosProducto);

        return nuevoProductoId;
    }

    public void Eliminar(int idProducto)
    {
        _sdk.fBuscaIdProducto(idProducto).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fBorraProducto().ToResultadoSdk(_sdk).ThrowIfError();
    }

    public void Eliminar(string codigoProducto)
    {
        _sdk.fEliminarProducto(codigoProducto).ToResultadoSdk(_sdk).ThrowIfError();
    }

    public void SetDatos(Dictionary<string, string> datos)
    {
        foreach (KeyValuePair<string, string> dato in datos)
            _sdk.fSetDatoProducto(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
    }
}

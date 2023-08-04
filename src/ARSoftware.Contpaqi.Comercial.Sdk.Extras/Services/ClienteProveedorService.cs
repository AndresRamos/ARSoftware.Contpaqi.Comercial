using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;

public class ClienteProveedorService : IClienteProveedorService
{
    private readonly IContpaqiSdk _sdk;

    public ClienteProveedorService(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    public void Actualizar(int idClienteProveedor, Dictionary<string, string> datosClienteProveedor)
    {
        _sdk.fBuscaIdCteProv(idClienteProveedor).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditaCteProv().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosClienteProveedor);
        _sdk.fGuardaCteProv().ToResultadoSdk(_sdk).ThrowIfError();
    }

    public void Actualizar(string codigoClienteProveedor, Dictionary<string, string> datosClienteProveedor)
    {
        _sdk.fBuscaCteProv(codigoClienteProveedor).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fEditaCteProv().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosClienteProveedor);
        _sdk.fGuardaCteProv().ToResultadoSdk(_sdk).ThrowIfError();
    }

    public void Actualizar(tCteProv clienteProveedor)
    {
        _sdk.fActualizaCteProv(clienteProveedor.cCodigoCliente, ref clienteProveedor).ToResultadoSdk(_sdk).ThrowIfError();
    }

    public int Crear(tCteProv clienteProveedor)
    {
        var idClienteProveedor = 0;
        _sdk.fAltaCteProv(ref idClienteProveedor, ref clienteProveedor).ToResultadoSdk(_sdk).ThrowIfError();
        return idClienteProveedor;
    }

    public int Crear(Dictionary<string, string> datosClienteProveedor)
    {
        _sdk.fInsertaCteProv().ToResultadoSdk(_sdk).ThrowIfError();
        SetDatos(datosClienteProveedor);
        _sdk.fGuardaCteProv().ToResultadoSdk(_sdk).ThrowIfError();
        string idClienteProveedorDato = _sdk.LeeDatoClienteProveedor(nameof(admClientes.CIDCLIENTEPROVEEDOR), SdkConstantes.kLongId);
        return int.Parse(idClienteProveedorDato);
    }

    public int Crear(ClienteProveedor clienteProveedor)
    {
        tCteProv cliente = clienteProveedor.ToSdkCteProv();
        cliente.cFechaAlta = DateTime.Today.ToSdkFecha();
        cliente.cNombreMoneda = "Peso Mexicano";
        cliente.cBanVentaCredito = 1;
        cliente.cEstatus = 1;
        int nuevoClienteId = Crear(cliente);

        var datosClienteProveedor = new Dictionary<string, string>(clienteProveedor.DatosExtra);
        if (clienteProveedor.UsoCfdi is not null)
            datosClienteProveedor.TryAdd(nameof(admClientes.CUSOCFDI), clienteProveedor.UsoCfdi.Value);
        if (clienteProveedor.RegimenFiscal is not null)
            datosClienteProveedor.TryAdd(nameof(admClientes.CREGIMFISC), clienteProveedor.RegimenFiscal.Value);
        Actualizar(nuevoClienteId, datosClienteProveedor);

        return nuevoClienteId;
    }

    public void Eliminar(int idClienteProveedor)
    {
        _sdk.fBuscaIdCteProv(idClienteProveedor).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fBorraCteProv().ToResultadoSdk(_sdk).ThrowIfError();
    }

    public void Eliminar(string codigoClienteProveedor)
    {
        _sdk.fEliminarCteProv(codigoClienteProveedor).ToResultadoSdk(_sdk).ThrowIfError();
    }

    public void SetDatos(Dictionary<string, string> datos)
    {
        foreach (KeyValuePair<string, string> dato in datos) _sdk.fSetDatoCteProv(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
    }
}

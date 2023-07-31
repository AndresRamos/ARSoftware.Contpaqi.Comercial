using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

/// <summary>
///     Repositorio de SDK para consultar clientes y proveedores.
/// </summary>
/// <typeparam name="T">
///     El tipo de cliente o proveedor utilizado por el repositorio.
/// </typeparam>
public class ClienteProveedorSdkRepository<T> : IClienteProveedorRepository<T> where T : class, new()
{
    private readonly IContpaqiSdk _sdk;

    public ClienteProveedorSdkRepository(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public T? BuscarPorCodigo(string codigoCliente)
    {
        return _sdk.fBuscaCteProv(codigoCliente) == SdkResultConstants.Success ? LeerDatosClienteProveedorActual() : null;
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idCliente)
    {
        return _sdk.fBuscaIdCteProv(idCliente) == SdkResultConstants.Success ? LeerDatosClienteProveedorActual() : null;
    }

    /// <inheritdoc />
    public List<T> TraerClientes()
    {
        var lista = new List<T>();

        var tipoDeCliente = new StringBuilder(7);

        _sdk.fPosPrimerCteProv().ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
        if (TipoClienteHelper.IsCliente(tipoDeCliente.ToString())) lista.Add(LeerDatosClienteProveedorActual());

        while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
        {
            _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (TipoClienteHelper.IsCliente(tipoDeCliente.ToString())) lista.Add(LeerDatosClienteProveedorActual());

            if (_sdk.fPosEOFCteProv() == 1) break;
        }

        return lista;
    }

    /// <inheritdoc />
    public List<T> TraerPorTipo(TipoCliente tipoCliente)
    {
        var lista = new List<T>();

        _sdk.fPosPrimerCteProv().ToResultadoSdk(_sdk).ThrowIfError();
        var tipoDeCliente = new StringBuilder(7);
        _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
        if (tipoCliente == TipoClienteHelper.ConvertFromSdkValue(tipoDeCliente.ToString())) lista.Add(LeerDatosClienteProveedorActual());

        while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
        {
            _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (tipoCliente == TipoClienteHelper.ConvertFromSdkValue(tipoDeCliente.ToString()))
                lista.Add(LeerDatosClienteProveedorActual());

            if (_sdk.fPosEOFCteProv() == 1) break;
        }

        return lista;
    }

    /// <inheritdoc />
    public List<T> TraerProveedores()
    {
        var lista = new List<T>();
        var tipoDeCliente = new StringBuilder(7);

        _sdk.fPosPrimerCteProv().ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
        if (TipoClienteHelper.IsProveedor(tipoDeCliente.ToString())) lista.Add(LeerDatosClienteProveedorActual());

        while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
        {
            _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (TipoClienteHelper.IsProveedor(tipoDeCliente.ToString())) lista.Add(LeerDatosClienteProveedorActual());

            if (_sdk.fPosEOFCteProv() == 1) break;
        }

        return lista;
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        var lista = new List<T>();

        _sdk.fPosPrimerCteProv().ToResultadoSdk(_sdk).ThrowIfError();
        lista.Add(LeerDatosClienteProveedorActual());
        while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
        {
            lista.Add(LeerDatosClienteProveedorActual());
            if (_sdk.fPosEOFCteProv() == 1) break;
        }

        return lista;
    }

    private T LeerDatosClienteProveedorActual()
    {
        var clienteProveedor = new T();

        LeerYAsignarDatos(clienteProveedor);

        return clienteProveedor;
    }

    private void LeerYAsignarDatos(T cliente)
    {
        Type sqlModelType = typeof(admClientes);

        foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
        {
            try
            {
                if (!sqlModelType.HasProperty(propertyDescriptor.Name)) continue;

                propertyDescriptor.SetValue(cliente,
                    _sdk.LeeDatoClienteProveedor(propertyDescriptor.Name)
                        .Trim()
                        .ConvertFromSdkValueString(propertyDescriptor.PropertyType));
            }
            catch (ContpaqiSdkException e)
            {
                throw new ContpaqiSdkInvalidOperationException(
                    $"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}. Error: {e.MensajeErrorSdk}",
                    e);
            }
        }
    }
}

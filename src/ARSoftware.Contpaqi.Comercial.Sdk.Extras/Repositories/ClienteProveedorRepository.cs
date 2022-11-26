﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories
{
    public class ClienteProveedorRepository<T> : IClienteProveedorRepository<T> where T : class, new()
    {
        private readonly IContpaqiSdk _sdk;

        public ClienteProveedorRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public T BuscarPorCodigo(string codigoCliente)
        {
            return _sdk.fBuscaCteProv(codigoCliente) == SdkResultConstants.Success ? LeerDatosClienteProveedorActual() : null;
        }

        public T BuscarPorId(int idCliente)
        {
            return _sdk.fBuscaIdCteProv(idCliente) == SdkResultConstants.Success ? LeerDatosClienteProveedorActual() : null;
        }

        public IEnumerable<T> TraerClientes()
        {
            var tipoDeCliente = new StringBuilder(7);

            _sdk.fPosPrimerCteProv().ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (TipoClienteHelper.IsCliente(tipoDeCliente.ToString()))
                yield return LeerDatosClienteProveedorActual();

            while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
                if (TipoClienteHelper.IsCliente(tipoDeCliente.ToString()))
                    yield return LeerDatosClienteProveedorActual();

                if (_sdk.fPosEOFCteProv() == 1)
                    break;
            }
        }

        public IEnumerable<T> TraerPorTipo(TipoCliente tipoCliente)
        {
            _sdk.fPosPrimerCteProv().ToResultadoSdk(_sdk).ThrowIfError();
            var tipoDeCliente = new StringBuilder(7);
            _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (tipoCliente == TipoClienteHelper.ConvertFromSdkValue(tipoDeCliente.ToString()))
                yield return LeerDatosClienteProveedorActual();

            while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
                if (tipoCliente == TipoClienteHelper.ConvertFromSdkValue(tipoDeCliente.ToString()))
                    yield return LeerDatosClienteProveedorActual();

                if (_sdk.fPosEOFCteProv() == 1)
                    break;
            }
        }

        public IEnumerable<T> TraerProveedores()
        {
            var tipoDeCliente = new StringBuilder(7);

            _sdk.fPosPrimerCteProv().ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (TipoClienteHelper.IsProveedor(tipoDeCliente.ToString()))
                yield return LeerDatosClienteProveedorActual();

            while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
                if (TipoClienteHelper.IsProveedor(tipoDeCliente.ToString()))
                    yield return LeerDatosClienteProveedorActual();

                if (_sdk.fPosEOFCteProv() == 1)
                    break;
            }
        }

        public IEnumerable<T> TraerTodo()
        {
            _sdk.fPosPrimerCteProv().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosClienteProveedorActual();
            while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
            {
                yield return LeerDatosClienteProveedorActual();
                if (_sdk.fPosEOFCteProv() == 1)
                    break;
            }
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
                    if (!sqlModelType.HasProperty(propertyDescriptor.Name))
                        continue;

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
}

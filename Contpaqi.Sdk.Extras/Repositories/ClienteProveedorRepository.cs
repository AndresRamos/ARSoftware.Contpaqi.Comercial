using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Contpaqi.Comercial.Sql.Models.Empresa;
using Contpaqi.Sdk.Extras.Extensions;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Repositories
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
            {
                yield return LeerDatosClienteProveedorActual();
            }

            while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
                if (TipoClienteHelper.IsCliente(tipoDeCliente.ToString()))
                {
                    yield return LeerDatosClienteProveedorActual();
                }

                if (_sdk.fPosEOFCteProv() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<T> TraerPorTipo(TipoCliente tipoCliente)
        {
            _sdk.fPosPrimerCteProv().ToResultadoSdk(_sdk).ThrowIfError();
            var tipoDeCliente = new StringBuilder(7);
            _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (tipoCliente == TipoClienteHelper.ConvertFromSdkValue(tipoDeCliente.ToString()))
            {
                yield return LeerDatosClienteProveedorActual();
            }

            while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
                if (tipoCliente == TipoClienteHelper.ConvertFromSdkValue(tipoDeCliente.ToString()))
                {
                    yield return LeerDatosClienteProveedorActual();
                }

                if (_sdk.fPosEOFCteProv() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<T> TraerProveedores()
        {
            var tipoDeCliente = new StringBuilder(7);

            _sdk.fPosPrimerCteProv().ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (TipoClienteHelper.IsProveedor(tipoDeCliente.ToString()))
            {
                yield return LeerDatosClienteProveedorActual();
            }

            while (_sdk.fPosSiguienteCteProv() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoDeCliente, 7).ToResultadoSdk(_sdk).ThrowIfError();
                if (TipoClienteHelper.IsProveedor(tipoDeCliente.ToString()))
                {
                    yield return LeerDatosClienteProveedorActual();
                }

                if (_sdk.fPosEOFCteProv() == 1)
                {
                    break;
                }
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
                {
                    break;
                }
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
                    {
                        continue;
                    }

                    propertyDescriptor.SetValue(cliente,
                        _sdk.LeeDatoClienteProveedor(propertyDescriptor.Name)
                            .Trim()
                            .ConvertFromSdkValueString(propertyDescriptor.PropertyType));
                }
                catch (Exception e)
                {
                    throw new Exception($"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}", e);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories
{
    public class ProductoRepository<T> : IProductoRepository<T> where T : class, new()
    {
        private readonly IContpaqiSdk _sdk;

        public ProductoRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public T BuscarPorCodigo(string codigoProducto)
        {
            return _sdk.fBuscaProducto(codigoProducto) == SdkResultConstants.Success ? LeerDatosProductoActual() : null;
        }

        public T BuscarPorId(int idProducto)
        {
            return _sdk.fBuscaIdProducto(idProducto) == SdkResultConstants.Success ? LeerDatosProductoActual() : null;
        }

        public IEnumerable<T> TraerPorTipo(TipoProducto tipoProducto)
        {
            _sdk.fPosPrimerProducto().ToResultadoSdk(_sdk).ThrowIfError();

            var tipoProductoDato = new StringBuilder(7);
            _sdk.fLeeDatoProducto("CTIPOPRODUCTO", tipoProductoDato, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (tipoProducto == TipoProductoHelper.ConvertFromSdkValue(tipoProductoDato.ToString()))
            {
                yield return LeerDatosProductoActual();
            }

            while (_sdk.fPosSiguienteProducto() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoProducto("CTIPOPRODUCTO", tipoProductoDato, 7).ToResultadoSdk(_sdk).ThrowIfError();

                if (tipoProducto == TipoProductoHelper.ConvertFromSdkValue(tipoProductoDato.ToString()))
                {
                    yield return LeerDatosProductoActual();
                }

                if (_sdk.fPosEOFProducto() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<T> TraerTodo()
        {
            _sdk.fPosPrimerProducto().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosProductoActual();
            while (_sdk.fPosSiguienteProducto() == SdkResultConstants.Success)
            {
                yield return LeerDatosProductoActual();
                if (_sdk.fPosEOFProducto() == 1)
                {
                    break;
                }
            }
        }

        private T LeerDatosProductoActual()
        {
            var productoComercial = new T();

            LeerYAsignarDatos(productoComercial);

            return productoComercial;
        }

        private void LeerYAsignarDatos(T producto)
        {
            Type sqlModelType = typeof(admProductos);

            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
            {
                try
                {
                    if (!sqlModelType.HasProperty(propertyDescriptor.Name))
                    {
                        continue;
                    }

                    propertyDescriptor.SetValue(producto,
                        _sdk.LeeDatoProducto(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
                }
                catch (Exception e)
                {
                    throw new Exception($"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}", e);
                }
            }
        }
    }
}

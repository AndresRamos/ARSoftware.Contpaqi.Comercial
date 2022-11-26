using System;
using System.Collections.Generic;
using System.ComponentModel;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories
{
    public class AlmacenRepository<T> : IAlmacenRepository<T> where T : class, new()
    {
        private readonly IContpaqiSdk _sdk;

        public AlmacenRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public T BuscarPorCodigo(string codigoAlmacen)
        {
            return _sdk.fBuscaAlmacen(codigoAlmacen) == SdkResultConstants.Success ? LeerDatosAlmacenActual() : null;
        }

        public T BuscarPorId(int idAlmacen)
        {
            return _sdk.fBuscaIdAlmacen(idAlmacen) == SdkResultConstants.Success ? LeerDatosAlmacenActual() : null;
        }

        public IEnumerable<T> TraerTodo()
        {
            _sdk.fPosPrimerAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosAlmacenActual();

            while (_sdk.fPosSiguienteAlmacen() == SdkResultConstants.Success)
            {
                yield return LeerDatosAlmacenActual();
                if (_sdk.fPosEOFAlmacen() == 1)
                    break;
            }
        }

        private T LeerDatosAlmacenActual()
        {
            var almacen = new T();

            LeerYAsignarDatos(almacen);

            return almacen;
        }

        private void LeerYAsignarDatos(T almacen)
        {
            Type sqlModelType = typeof(admAlmacenes);

            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
            {
                try
                {
                    if (!sqlModelType.HasProperty(propertyDescriptor.Name))
                        continue;

                    propertyDescriptor.SetValue(almacen,
                        _sdk.LeeDatoAlmacen(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
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

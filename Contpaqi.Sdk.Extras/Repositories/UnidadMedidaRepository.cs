using System;
using System.Collections.Generic;
using System.ComponentModel;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories
{
    public class UnidadMedidaRepository<T> : IUnidadMedidaRepository<T> where T : class, new()
    {
        private readonly IContpaqiSdk _sdk;

        public UnidadMedidaRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public T BuscarPorId(int idUnidad)
        {
            return _sdk.fBuscaIdUnidad(idUnidad) == SdkResultConstants.Success ? LeerDatosUnindadActual() : null;
        }

        public T BuscarPorNombre(string nombreUnidad)
        {
            return _sdk.fBuscaUnidad(nombreUnidad) == SdkResultConstants.Success ? LeerDatosUnindadActual() : null;
        }

        public IEnumerable<T> TraerTodo()
        {
            _sdk.fPosPrimerUnidad().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosUnindadActual();
            while (_sdk.fPosSiguienteUnidad() == SdkResultConstants.Success)
            {
                yield return LeerDatosUnindadActual();
                if (_sdk.fPosEOFUnidad() == 1)
                {
                    break;
                }
            }
        }

        private T LeerDatosUnindadActual()
        {
            var unidad = new T();

            LeerYAsignarDatos(unidad);

            return unidad;
        }

        private void LeerYAsignarDatos(T unidad)
        {
            Type sqlModelType = typeof(admUnidadesMedidaPeso);

            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
            {
                try
                {
                    if (!sqlModelType.HasProperty(propertyDescriptor.Name))
                    {
                        continue;
                    }

                    propertyDescriptor.SetValue(unidad,
                        _sdk.LeeDatoUnidad(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
                }
                catch (Exception e)
                {
                    throw new Exception($"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}", e);
                }
            }
        }
    }
}

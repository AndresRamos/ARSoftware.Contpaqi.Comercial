using System;
using System.ComponentModel;
using Contpaqi.Comercial.Sql.Models.Empresa;
using Contpaqi.Sdk.Extras.Extensions;
using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class ParametrosRepository<T> : IParametrosRepository<T> where T : class, new()
    {
        private readonly IContpaqiSdk _sdk;

        public ParametrosRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public T Buscar()
        {
            var parametros = new T();

            LeerYAsignarDatos(parametros);

            return parametros;
        }

        private void LeerYAsignarDatos(T parametros)
        {
            Type sqlModelType = typeof(admParametros);

            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
            {
                try
                {
                    if (!sqlModelType.HasProperty(propertyDescriptor.Name))
                    {
                        continue;
                    }

                    propertyDescriptor.SetValue(parametros,
                        _sdk.LeeDatoParametros(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
                }
                catch (Exception e)
                {
                    throw new Exception($"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}", e);
                }
            }
        }
    }
}

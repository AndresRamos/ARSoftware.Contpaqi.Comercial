using System;
using System.Collections.Generic;
using System.ComponentModel;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories
{
    public class AgenteRepository<T> : IAgenteRepository<T> where T : class, new()
    {
        private readonly IContpaqiSdk _sdk;

        public AgenteRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public T BuscarPorCodigo(string codigoAgente)
        {
            return _sdk.fBuscaAgente(codigoAgente) == SdkResultConstants.Success ? LeerDatosAgenteActual() : null;
        }

        public T BuscarPorId(int idAgente)
        {
            return _sdk.fBuscaIdAgente(idAgente) == SdkResultConstants.Success ? LeerDatosAgenteActual() : null;
        }

        public IEnumerable<T> TraerTodo()
        {
            _sdk.fPosPrimerAgente().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosAgenteActual();

            while (_sdk.fPosSiguienteAgente() == SdkResultConstants.Success)
            {
                yield return LeerDatosAgenteActual();
                if (_sdk.fPosEOFAgente() == 1)
                {
                    break;
                }
            }
        }

        private T LeerDatosAgenteActual()
        {
            var agente = new T();

            LeerYAsignarDatos(agente);

            return agente;
        }

        private void LeerYAsignarDatos(T agente)
        {
            Type sqlModelType = typeof(admAgentes);

            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
            {
                try
                {
                    if (!sqlModelType.HasProperty(propertyDescriptor.Name))
                    {
                        continue;
                    }

                    propertyDescriptor.SetValue(agente,
                        _sdk.LeeDatoAgente(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
                }
                catch (Exception e)
                {
                    throw new Exception($"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}", e);
                }
            }
        }
    }
}

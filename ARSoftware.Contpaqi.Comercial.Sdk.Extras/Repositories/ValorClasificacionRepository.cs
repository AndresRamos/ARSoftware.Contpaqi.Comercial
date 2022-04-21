using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories
{
    public class ValorClasificacionRepository<T> : IValorClasificacionRepository<T> where T : class, new()
    {
        private readonly IContpaqiSdk _sdk;

        public ValorClasificacionRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public T BuscarPorId(int idValorClasificacion)
        {
            return _sdk.fBuscaIdValorClasif(idValorClasificacion) == SdkResultConstants.Success
                ? LeerDatosValorClasificacionActual()
                : null;
        }

        public T BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacion tipoClasificacion,
                                                         int numeroClasificacion,
                                                         string codigoValorClasificacion)
        {
            return _sdk.fBuscaValorClasif((int)tipoClasificacion, numeroClasificacion, codigoValorClasificacion) ==
                   SdkResultConstants.Success
                ? LeerDatosValorClasificacionActual()
                : null;
        }

        public IEnumerable<T> TraerPorClasificacionId(int idClasificacion)
        {
            _sdk.fPosPrimerValorClasif().ToResultadoSdk(_sdk).ThrowIfError();
            var id = new StringBuilder(12);
            _sdk.fLeeDatoValorClasif("CIDCLASIFICACION", id, SdkConstantes.kLongId).ToResultadoSdk(_sdk).ThrowIfError();
            if (idClasificacion == int.Parse(id.ToString()))
            {
                yield return LeerDatosValorClasificacionActual();
            }

            while (_sdk.fPosSiguienteValorClasif() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoValorClasif("CIDCLASIFICACION", id, SdkConstantes.kLongId).ToResultadoSdk(_sdk).ThrowIfError();
                if (idClasificacion == int.Parse(id.ToString()))
                {
                    yield return LeerDatosValorClasificacionActual();
                }

                if (_sdk.fPosEOFValorClasif() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<T> TraerPorClasificacionTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion)
        {
            _sdk.fBuscaClasificacion((int)tipoClasificacion, (int)numeroClasificacion).ToResultadoSdk(_sdk).ThrowIfError();
            string idClasificacion = _sdk.LeeDatoClasificacion(nameof(admClasificaciones.CIDCLASIFICACION));
            return TraerPorClasificacionId(int.Parse(idClasificacion));
        }

        public IEnumerable<T> TraerTodo()
        {
            _sdk.fPosPrimerValorClasif().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosValorClasificacionActual();
            while (_sdk.fPosSiguienteValorClasif() == SdkResultConstants.Success)
            {
                yield return LeerDatosValorClasificacionActual();
                if (_sdk.fPosEOFValorClasif() == 1)
                {
                    break;
                }
            }
        }

        private T LeerDatosValorClasificacionActual()
        {
            var valorClasificacion = new T();

            LeerYAsignarDatos(valorClasificacion);

            return valorClasificacion;
        }

        private void LeerYAsignarDatos(T valor)
        {
            Type sqlModelType = typeof(admClasificacionesValores);

            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
            {
                try
                {
                    if (!sqlModelType.HasProperty(propertyDescriptor.Name))
                    {
                        continue;
                    }

                    propertyDescriptor.SetValue(valor,
                        _sdk.LeeDatoValorClasificacion(propertyDescriptor.Name)
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

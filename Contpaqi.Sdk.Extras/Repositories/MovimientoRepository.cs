using System;
using System.Collections.Generic;
using System.ComponentModel;
using Contpaqi.Comercial.Sql.Models.Empresa;
using Contpaqi.Sdk.Extras.Extensions;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class MovimientoRepository<T> : IMovimientoRepository<T> where T : class, new()
    {
        private readonly IContpaqiSdk _sdk;

        public MovimientoRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public T BuscarPorId(int idMovimiento)
        {
            return _sdk.fBuscarIdMovimiento(idMovimiento) == SdkResultConstants.Success ? LeerDatosMovimientoActual() : null;
        }

        public IEnumerable<T> TraerPorDocumentoId(int idDocumento)
        {
            _sdk.fCancelaFiltroMovimiento().ToResultadoSdk(_sdk).ThrowIfError();

            SdkResult resultadoSdk = _sdk.fSetFiltroMovimiento(idDocumento).ToResultadoSdk(_sdk);

            if (!resultadoSdk.IsSuccess)
            {
                _sdk.fCancelaFiltroMovimiento().ToResultadoSdk(_sdk).ThrowIfError();

                if (resultadoSdk.Result ==
                    2) // Si el resultado es "2" significa que no hay movimientos en el filtro pero no creo que se considere un error para tirar una excepcion
                {
                    yield break;
                }

                resultadoSdk.ThrowIfError();
            }

            _sdk.fPosPrimerMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosMovimientoActual();

            while (_sdk.fPosSiguienteMovimiento() == SdkResultConstants.Success)
            {
                yield return LeerDatosMovimientoActual();
                if (_sdk.fPosMovimientoEOF() == 1)
                {
                    break;
                }
            }

            _sdk.fCancelaFiltroMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public IEnumerable<T> TraerTodo()
        {
            _sdk.fPosPrimerMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosMovimientoActual();
            while (_sdk.fPosSiguienteMovimiento() == SdkResultConstants.Success)
            {
                yield return LeerDatosMovimientoActual();
                if (_sdk.fPosMovimientoEOF() == 1)
                {
                    break;
                }
            }
        }

        private T LeerDatosMovimientoActual()
        {
            var movimiento = new T();

            //movimiento.Consecutivo = double.TryParse(consecutivo.ToString(), out var consecutivoReslt) ? Convert.ToInt32(consecutivoReslt) : 0; // Int.Parse falla por que regresa 1.00

            LeerYAsignarDatos(movimiento);

            return movimiento;
        }

        private void LeerYAsignarDatos(T movimiento)
        {
            Type sqlModelType = typeof(admMovimientos);

            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
            {
                try
                {
                    if (!sqlModelType.HasProperty(propertyDescriptor.Name))
                    {
                        continue;
                    }

                    propertyDescriptor.SetValue(movimiento,
                        _sdk.LeeDatoMovimiento(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
                }
                catch (Exception e)
                {
                    throw new Exception($"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}", e);
                }
            }
        }
    }
}

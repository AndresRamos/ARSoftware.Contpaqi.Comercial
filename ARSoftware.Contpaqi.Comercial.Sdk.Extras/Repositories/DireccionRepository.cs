using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories
{
    public class DireccionRepository<T> : IDireccionRepository<T> where T : class, new()
    {
        private readonly IContpaqiSdk _sdk;

        public DireccionRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public T BuscarPorCliente(string codigoClienteProveedor, byte tipoDireccion)
        {
            return _sdk.fBuscaDireccionCteProv(codigoClienteProveedor, tipoDireccion) == SdkResultConstants.Success
                ? LeerDatosDireccionActual()
                : null;
        }

        public T BuscarPorDocumento(int idDocumento, byte tipoDireccion)
        {
            return _sdk.fBuscaDireccionDocumento(idDocumento, tipoDireccion) == SdkResultConstants.Success
                ? LeerDatosDireccionActual()
                : null;
        }

        public T BuscarPorId(int idDireccion)
        {
            var idDireccionDato = new StringBuilder(12);

            _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CIDDIRECCION", idDireccionDato, SdkConstantes.kLongId).ToResultadoSdk(_sdk).ThrowIfError();
            if (idDireccion == int.Parse(idDireccionDato.ToString()))
            {
                return LeerDatosDireccionActual();
            }

            while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoDireccion("CIDDIRECCION", idDireccionDato, SdkConstantes.kLongId).ToResultadoSdk(_sdk).ThrowIfError();
                if (idDireccion == int.Parse(idDireccionDato.ToString()))
                {
                    return LeerDatosDireccionActual();
                }

                if (_sdk.fPosEOFDireccion() == 1)
                {
                    break;
                }
            }

            return null;
        }

        public IEnumerable<T> TraerPorTipo(TipoCatalogoDireccion tipoCatalogoDireccion)
        {
            var tipoCatalogo = new StringBuilder(7);

            _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CTIPOCATALOGO", tipoCatalogo, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (tipoCatalogoDireccion == TipoCatalogoDireccionHelper.ConvertFromSdkValue(tipoCatalogo.ToString()))
            {
                yield return LeerDatosDireccionActual();
            }

            while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoDireccion("CTIPOCATALOGO", tipoCatalogo, 7).ToResultadoSdk(_sdk).ThrowIfError();
                if (tipoCatalogoDireccion == TipoCatalogoDireccionHelper.ConvertFromSdkValue(tipoCatalogo.ToString()))
                {
                    yield return LeerDatosDireccionActual();
                }

                if (_sdk.fPosEOFDireccion() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<T> TraerPorTipoYIdCatalogo(TipoCatalogoDireccion tipoCatalogoDireccion, int idCatalogo)
        {
            var tipoCatalogo = new StringBuilder(7);
            var idCatalogoDato = new StringBuilder(12);

            _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CTIPOCATALOGO", tipoCatalogo, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CIDCATALOGO", idCatalogoDato, SdkConstantes.kLongId).ToResultadoSdk(_sdk).ThrowIfError();
            if (tipoCatalogoDireccion == TipoCatalogoDireccionHelper.ConvertFromSdkValue(tipoCatalogo.ToString()) &&
                idCatalogo == int.Parse(idCatalogoDato.ToString()))
            {
                yield return LeerDatosDireccionActual();
            }

            while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoDireccion("CTIPOCATALOGO", tipoCatalogo, 7).ToResultadoSdk(_sdk).ThrowIfError();
                _sdk.fLeeDatoDireccion("CIDCATALOGO", idCatalogoDato, SdkConstantes.kLongId).ToResultadoSdk(_sdk).ThrowIfError();
                if (tipoCatalogoDireccion == TipoCatalogoDireccionHelper.ConvertFromSdkValue(tipoCatalogo.ToString()) &&
                    idCatalogo == int.Parse(idCatalogoDato.ToString()))
                {
                    yield return LeerDatosDireccionActual();
                }

                if (_sdk.fPosEOFDireccion() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<T> TraerTodo()
        {
            _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosDireccionActual();

            while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
            {
                yield return LeerDatosDireccionActual();

                if (_sdk.fPosEOFDireccion() == 1)
                {
                    break;
                }
            }
        }

        private T LeerDatosDireccionActual()
        {
            var direccion = new T();

            LeerYAsignarDatos(direccion);

            return direccion;
        }

        private void LeerYAsignarDatos(T direccion)
        {
            Type sqlModelType = typeof(admDomicilios);

            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
            {
                try
                {
                    if (!sqlModelType.HasProperty(propertyDescriptor.Name))
                    {
                        continue;
                    }

                    propertyDescriptor.SetValue(direccion,
                        _sdk.LeeDatoDireccion(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
                }
                catch (Exception e)
                {
                    throw new Exception($"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}", e);
                }
            }
        }
    }
}

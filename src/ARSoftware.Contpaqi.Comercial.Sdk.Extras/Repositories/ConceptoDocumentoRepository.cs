using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories
{
    public class ConceptoDocumentoRepository<T> : IConceptoDocumentoRepository<T> where T : class, new()
    {
        private readonly IContpaqiSdk _sdk;

        public ConceptoDocumentoRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public T BuscarPorCodigo(string codigoConcepto)
        {
            return _sdk.fBuscaConceptoDocto(codigoConcepto) == SdkResultConstants.Success ? LeerDatosConceptoDocumentoActual() : null;
        }

        public T BuscarPorId(int idConcepto)
        {
            return _sdk.fBuscaIdConceptoDocto(idConcepto) == SdkResultConstants.Success ? LeerDatosConceptoDocumentoActual() : null;
        }

        public IEnumerable<T> TraerPorDocumentoModeloId(int documentoModeloId)
        {
            var idDocumentoModelo = new StringBuilder(12);

            _sdk.fPosPrimerConceptoDocto().ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoConceptoDocto("CIDDOCUMENTODE", idDocumentoModelo, SdkConstantes.kLongId).ToResultadoSdk(_sdk).ThrowIfError();
            if (documentoModeloId == int.Parse(idDocumentoModelo.ToString()))
                yield return LeerDatosConceptoDocumentoActual();

            while (_sdk.fPosSiguienteConceptoDocto() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoConceptoDocto("CIDDOCUMENTODE", idDocumentoModelo, SdkConstantes.kLongId).ToResultadoSdk(_sdk).ThrowIfError();
                if (documentoModeloId == int.Parse(idDocumentoModelo.ToString()))
                    yield return LeerDatosConceptoDocumentoActual();

                if (_sdk.fPosEOFConceptoDocto() == 1)
                    break;
            }
        }

        public IEnumerable<T> TraerTodo()
        {
            _sdk.fPosPrimerConceptoDocto().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosConceptoDocumentoActual();

            while (_sdk.fPosSiguienteConceptoDocto() == SdkResultConstants.Success)
            {
                yield return LeerDatosConceptoDocumentoActual();
                if (_sdk.fPosEOFConceptoDocto() == 1)
                    break;
            }
        }

        private T LeerDatosConceptoDocumentoActual()
        {
            var conceptoDeDocumento = new T();

            LeerYAsignarDatos(conceptoDeDocumento);

            return conceptoDeDocumento;
        }

        private void LeerYAsignarDatos(T concepto)
        {
            Type sqlModelType = typeof(admConceptos);

            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
            {
                if (!sqlModelType.HasProperty(propertyDescriptor.Name))
                    continue;

                try
                {
                    propertyDescriptor.SetValue(concepto,
                        _sdk.LeeDatoConcepto(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
                }
                catch (ContpaqiSdkException e)
                {
                    // Hay propiedades en Comercial que no estan en el esquema de la base de datos de Factura Electronica
                    if (e.CodigoErrorSdk == SdkErrorConstants.NombreCampoInvalido)
                        continue;

                    throw new ContpaqiSdkInvalidOperationException(
                        $"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}. Error: {e.MensajeErrorSdk}",
                        e);
                }
            }
        }
    }
}

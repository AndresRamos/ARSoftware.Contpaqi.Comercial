using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories
{
    public class DocumentoRepository<T> : IDocumentoRepository<T> where T : class, new()
    {
        private readonly IContpaqiSdk _sdk;

        public DocumentoRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public T BuscarPorId(int idDocumento)
        {
            return _sdk.fBuscarIdDocumento(idDocumento) == SdkResultConstants.Success ? LeerDatosDocumentoActual() : null;
        }

        public T BuscarPorLlave(string codigoConcepto, string serie, string folio)
        {
            return _sdk.fBuscarDocumento(codigoConcepto, serie, folio) == SdkResultConstants.Success ? LeerDatosDocumentoActual() : null;
        }

        public T BuscarPorLlave(LlaveDocumento llaveDocumento)
        {
            var llave = new tLlaveDoc
            {
                aCodConcepto = llaveDocumento.CodigoConcepto, aSerie = llaveDocumento.Serie, aFolio = llaveDocumento.Folio
            };

            return _sdk.fBuscaDocumento(ref llave) == SdkResultConstants.Success ? LeerDatosDocumentoActual() : null;
        }

        public LlaveDocumento BuscarSiguienteSerieYFolio(string codigoConcepto)
        {
            double folio = 0;
            var serie = new StringBuilder();
            _sdk.fSiguienteFolio(codigoConcepto, serie, ref folio).ToResultadoSdk(_sdk).ThrowIfError();
            return new LlaveDocumento { CodigoConcepto = codigoConcepto, Serie = serie.ToString(), Folio = folio };
        }

        public IEnumerable<T> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin,
            string codigoConcepto, string codigoClienteProveedor)
        {
            _sdk.fCancelaFiltroDocumento().ToResultadoSdk(_sdk).ThrowIfError();

            SdkResult resultadoSdk = _sdk.fSetFiltroDocumento(fechaInicio.ToSdkFecha(),
                    fechaFin.ToSdkFecha(), codigoConcepto, codigoClienteProveedor)
                .ToResultadoSdk(_sdk);

            if (!resultadoSdk.IsSuccess)
            {
                _sdk.fCancelaFiltroDocumento().ToResultadoSdk(_sdk).ThrowIfError();

                // Si el resultado es "2" significa que no hay documentos en el filtro pero no creo que se considere un error para tirar una excepcion
                if (resultadoSdk.Result == 2) yield break;

                resultadoSdk.ThrowIfError();
            }

            _sdk.fPosPrimerDocumento().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosDocumentoActual();
            while (_sdk.fPosSiguienteDocumento() == SdkResultConstants.Success)
            {
                yield return LeerDatosDocumentoActual();
                if (_sdk.fPosEOF() == 1) break;
            }

            _sdk.fCancelaFiltroDocumento().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public IEnumerable<T> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin,
            string codigoConcepto, IEnumerable<string> codigosClienteProveedor)
        {
            foreach (string codigoClienteProveedor in codigosClienteProveedor)
            {
                foreach (T documento in TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(fechaInicio, fechaFin, codigoConcepto,
                             codigoClienteProveedor))
                    yield return documento;
            }
        }

        public IEnumerable<T> TraerTodo()
        {
            _sdk.fPosPrimerDocumento().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosDocumentoActual();
            while (_sdk.fPosSiguienteDocumento() == SdkResultConstants.Success)
            {
                yield return LeerDatosDocumentoActual();
                if (_sdk.fPosEOF() == 1) break;
            }
        }

        private T LeerDatosDocumentoActual()
        {
            var documento = new T();

            LeerYAsignarDatos(documento);

            return documento;
        }

        private void LeerYAsignarDatos(T documento)
        {
            Type sqlModelType = typeof(admDocumentos);

            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
            {
                try
                {
                    if (!sqlModelType.HasProperty(propertyDescriptor.Name)) continue;

                    propertyDescriptor.SetValue(documento,
                        _sdk.LeeDatoDocumento(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
                }
                catch (ContpaqiSdkException e)
                {
                    // Hay propiedades en Comercial que no estan en el esquema de la base de datos de Factura Electronica
                    if (e.CodigoErrorSdk == SdkErrorConstants.NombreCampoInvalido) continue;

                    throw new ContpaqiSdkInvalidOperationException(
                        $"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}. Error: {e.MensajeErrorSdk}",
                        e);
                }
            }
        }
    }
}
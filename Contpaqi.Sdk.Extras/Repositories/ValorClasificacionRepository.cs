using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class ValorClasificacionRepository : IValorClasificacionRepository<ValorClasificacion>
    {
        private readonly IContpaqiSdk _sdk;

        public ValorClasificacionRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public ValorClasificacion BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacionEnum tipoClasificacion, int numeroClasificacion, string codigoValorClasificacion)
        {
            return _sdk.fBuscaValorClasif((int) tipoClasificacion, numeroClasificacion, codigoValorClasificacion) == SdkResultConstants.Success ? LeerDatosValorClasificacionActual() : null;
        }

        public ValorClasificacion BuscarPorId(int idValorClasificacion)
        {
            return _sdk.fBuscaIdValorClasif(idValorClasificacion) == SdkResultConstants.Success ? LeerDatosValorClasificacionActual() : null;
        }

        public IEnumerable<ValorClasificacion> TraerTodo()
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

        public IEnumerable<ValorClasificacion> TraerPorClasificacionId(int idClasificacion)
        {
            _sdk.fPosPrimerValorClasif().ToResultadoSdk(_sdk).ThrowIfError();
            var id = new StringBuilder(12);
            _sdk.fLeeDatoValorClasif("CIDCLASIFICACION", id, 12).ToResultadoSdk(_sdk).ThrowIfError();
            if (idClasificacion == int.Parse(id.ToString()))
            {
                yield return LeerDatosValorClasificacionActual();
            }

            while (_sdk.fPosSiguienteValorClasif() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoValorClasif("CIDCLASIFICACION", id, 12).ToResultadoSdk(_sdk).ThrowIfError();
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

        private ValorClasificacion LeerDatosValorClasificacionActual()
        {
            var id = new StringBuilder(12);
            var idClasificacion = new StringBuilder(12);
            var codigo = new StringBuilder(4);
            var valor = new StringBuilder(61);

            _sdk.fLeeDatoValorClasif("CIDVALORCLASIFICACION", id, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoValorClasif("CIDCLASIFICACION", idClasificacion, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoValorClasif("CCODIGOVALORCLASIFICACION", codigo, 4).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoValorClasif("CVALORCLASIFICACION", valor, 61).ToResultadoSdk(_sdk).ThrowIfError();

            var valorClasi = new ValorClasificacion();
            valorClasi.Id = int.Parse(id.ToString());
            valorClasi.IdClasificacion = int.Parse(idClasificacion.ToString());
            valorClasi.Codigo = codigo.ToString();
            valorClasi.Valor = valor.ToString();
            return valorClasi;
        }
    }
}
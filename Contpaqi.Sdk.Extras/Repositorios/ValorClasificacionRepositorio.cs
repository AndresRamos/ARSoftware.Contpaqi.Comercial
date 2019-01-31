using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;

namespace Contpaqi.Sdk.Extras.Repositorios
{
    public class ValorClasificacionRepositorio
    {
        private readonly ErrorContpaqiSdkRepositorio _errorContpaqiSdkRepositorio;
        private readonly IContpaqiSdk _sdk;

        public ValorClasificacionRepositorio(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _errorContpaqiSdkRepositorio = new ErrorContpaqiSdkRepositorio(sdk);
        }

        public ValorClasificacion BuscaValorClasificacion(int clasificacionDe, int numClasificacion, string codigoValorClasificacion)
        {
            return _sdk.fBuscaValorClasif(clasificacionDe, numClasificacion, codigoValorClasificacion) == 0 ? LeerDatosValorClasificacionActual() : null;
        }

        public ValorClasificacion BuscaValorClasificacion(int idValorClasificacion)
        {
            return _sdk.fBuscaIdValorClasif(idValorClasificacion) == 0 ? LeerDatosValorClasificacionActual() : null;
        }

        public tValorClasificacion ExtrarTValorClasificacion(ValorClasificacion valorClasificacion)
        {
            var tValorClasificacion = new tValorClasificacion();
            tValorClasificacion.cNumClasificacion = valorClasificacion.Id;
            tValorClasificacion.cClasificacionDe = valorClasificacion.IdClasificacion;
            tValorClasificacion.cCodigoValorClasificacion = valorClasificacion.Codigo;
            tValorClasificacion.cValorClasificacion = valorClasificacion.Valor;
            return tValorClasificacion;
        }

        public List<ValorClasificacion> TraerValoresClasificacion()
        {
            var valresClasificacion = new List<ValorClasificacion>();
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fPosPrimerValorClasif();
            valresClasificacion.Add(LeerDatosValorClasificacionActual());
            while (_sdk.fPosSiguienteValorClasif() == 0)
            {
                valresClasificacion.Add(LeerDatosValorClasificacionActual());
                if (_sdk.fPosEOFValorClasif() == 1)
                {
                    break;
                }
            }

            return valresClasificacion;
        }

        public List<ValorClasificacion> TraerValoresClasificacion(int idClasificacion)
        {
            var valresClasificacion = new List<ValorClasificacion>();
            var id = new StringBuilder(12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fPosPrimerValorClasif();
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CIDCLASIFICACION", id, 12);
            if (idClasificacion.ToString() == id.ToString())
            {
                valresClasificacion.Add(LeerDatosValorClasificacionActual());
            }

            while (_sdk.fPosSiguienteValorClasif() == 0)
            {
                _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CIDCLASIFICACION", id, 12);
                if (idClasificacion.ToString() == id.ToString())
                {
                    valresClasificacion.Add(LeerDatosValorClasificacionActual());
                }

                if (_sdk.fPosEOFValorClasif() == 1)
                {
                    break;
                }
            }

            return valresClasificacion;
        }

        private ValorClasificacion LeerDatosValorClasificacionActual()
        {
            var id = new StringBuilder(12);
            var idClasificacion = new StringBuilder(12);
            var codigo = new StringBuilder(4);
            var valor = new StringBuilder(61);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CIDVALORCLASIFICACION", id, 12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CIDCLASIFICACION", idClasificacion, 12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CCODIGOVALORCLASIFICACION", codigo, 4);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CVALORCLASIFICACION", valor, 61);
            var valorClasi = new ValorClasificacion
            {
                Id = int.Parse(id.ToString()),
                IdClasificacion = int.Parse(idClasificacion.ToString()),
                Codigo = codigo.ToString(),
                Valor = valor.ToString()
            };
            return valorClasi;
        }
    }
}
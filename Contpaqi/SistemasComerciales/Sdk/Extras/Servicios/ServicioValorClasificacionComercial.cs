using System.Collections.Generic;
using System.Text;
using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioValorClasificacionComercial
    {
        private readonly ServicioErrorComercial _errorComercialServicio;
        private readonly ISistemasComercialesSdk _sdk;

        public ServicioValorClasificacionComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _errorComercialServicio = new ServicioErrorComercial(sdk);
        }

        public ValorClasificacionComercial BuscaValorClasificacion(int clasificacionDe, int numClasificacion, string codigoValorClasificacion)
        {
            return _sdk.fBuscaValorClasif(clasificacionDe, numClasificacion, codigoValorClasificacion) == 0 ? LeerDatosValorClasificacionActual() : null;
        }

        public ValorClasificacionComercial BuscaValorClasificacion(int idValorClasificacion)
        {
            return _sdk.fBuscaIdValorClasif(idValorClasificacion) == 0 ? LeerDatosValorClasificacionActual() : null;
        }

        public tValorClasificacion ExtrarTValorClasificacion(ValorClasificacionComercial valorClasificacion)
        {
            var tValorClasificacion = new tValorClasificacion();
            tValorClasificacion.cNumClasificacion = valorClasificacion.IdValorClasificacion;
            tValorClasificacion.cClasificacionDe = valorClasificacion.IdClasificacion;
            tValorClasificacion.cCodigoValorClasificacion = valorClasificacion.CodigoValorClasificacion;
            tValorClasificacion.cValorClasificacion = valorClasificacion.ValorClasificacion;
            return tValorClasificacion;
        }

        public List<ValorClasificacionComercial> TraerValoresClasificacion()
        {
            var valresClasificacion = new List<ValorClasificacionComercial>();
            _errorComercialServicio.ResultadoSdk = _sdk.fPosPrimerValorClasif();
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

        public List<ValorClasificacionComercial> TraerValoresClasificacion(int idClasificacion)
        {
            var valresClasificacion = new List<ValorClasificacionComercial>();
            var id = new StringBuilder(12);
            _errorComercialServicio.ResultadoSdk = _sdk.fPosPrimerValorClasif();
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CIDCLASIFICACION", id, 12);
            if (idClasificacion.ToString() == id.ToString())
            {
                valresClasificacion.Add(LeerDatosValorClasificacionActual());
            }
            while (_sdk.fPosSiguienteValorClasif() == 0)
            {
                _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CIDCLASIFICACION", id, 12);
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

        private ValorClasificacionComercial LeerDatosValorClasificacionActual()
        {
            var idValorClasificacion = new StringBuilder(12);
            var idClasificacion = new StringBuilder(12);
            var codigoValorClasificacion = new StringBuilder(4);
            var valorClasificacion = new StringBuilder(61);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CIDVALORCLASIFICACION", idValorClasificacion, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CIDCLASIFICACION", idClasificacion, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CCODIGOVALORCLASIFICACION", codigoValorClasificacion, 4);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CVALORCLASIFICACION", valorClasificacion, 61);
            var valorClasi = new ValorClasificacionComercial();
            valorClasi.IdValorClasificacion = int.Parse(idValorClasificacion.ToString());
            valorClasi.IdClasificacion = int.Parse(idClasificacion.ToString());
            valorClasi.CodigoValorClasificacion = codigoValorClasificacion.ToString();
            valorClasi.ValorClasificacion = valorClasificacion.ToString();
            return valorClasi;
        }
    }
}
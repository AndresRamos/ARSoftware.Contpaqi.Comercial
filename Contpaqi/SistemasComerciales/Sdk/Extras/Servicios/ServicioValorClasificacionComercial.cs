using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    class ServicioValorClasificacionComercial
    {
        private readonly ISistemasComercialesSdk _sdk;
        private readonly ServicioErrorComercial _errorComercialServicio;

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
            tValorClasificacion tValorClasificacion = new tValorClasificacion();
            tValorClasificacion.cNumClasificacion = valorClasificacion.NumClasificacion;
            tValorClasificacion.cClasificacionDe = valorClasificacion.ClasificacionDe;
            tValorClasificacion.cCodigoValorClasificacion = valorClasificacion.CodigoValorClasificacion;
            tValorClasificacion.cValorClasificacion = valorClasificacion.ValorClasificacion;
            return tValorClasificacion;
        }

        private ValorClasificacionComercial LeerDatosValorClasificacionActual()
        {
            StringBuilder numClasificacion = new StringBuilder(12);
            StringBuilder clasificacionDe = new StringBuilder(12);
            StringBuilder codigoValorClasificacion = new StringBuilder(4);
            StringBuilder valorClasificacion = new StringBuilder(61);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CIDVALORCLASIFICACION", numClasificacion, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CIDCLASIFICACION", clasificacionDe, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CCODIGOVALORCLASIFICACION", codigoValorClasificacion, 4);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoValorClasif("CVALORCLASIFICACION", valorClasificacion, 61);
            ValorClasificacionComercial valorClasi = new ValorClasificacionComercial();
            valorClasi.NumClasificacion = int.Parse(numClasificacion.ToString());
            valorClasi.ClasificacionDe = int.Parse(clasificacionDe.ToString());
            valorClasi.CodigoValorClasificacion = codigoValorClasificacion.ToString();
            valorClasi.ValorClasificacion = valorClasificacion.ToString();
            return valorClasi;
        }
    }
}

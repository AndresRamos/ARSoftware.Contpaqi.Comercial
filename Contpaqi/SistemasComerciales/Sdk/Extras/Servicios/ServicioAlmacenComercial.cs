using System.Collections.Generic;
using System.Text;
using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioAlmacenComercial
    {
        private readonly ServicioErrorComercial _errorComercialServicio;
        private readonly ISistemasComercialesSdk _sdk;

        public ServicioAlmacenComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _errorComercialServicio = new ServicioErrorComercial(sdk);
        }

        public AlmacenComercial BuscarAlmacen(int idAlmacen)
        {
            return _sdk.fBuscaIdAlmacen(idAlmacen) == 0 ? LeerDatosAlmacenActual() : null;
        }

        public AlmacenComercial BuscarAlmacen(string codigoAlmacen)
        {
            return _sdk.fBuscaAlmacen(codigoAlmacen) == 0 ? LeerDatosAlmacenActual() : null;
        }

        public List<AlmacenComercial> TraerAlmacenes()
        {
            var almacenesList = new List<AlmacenComercial>();
            _errorComercialServicio.ResultadoSdk = _sdk.fPosPrimerAlmacen();
            almacenesList.Add(LeerDatosAlmacenActual());
            while (_sdk.fPosSiguienteAlmacen() == 0)
            {
                almacenesList.Add(LeerDatosAlmacenActual());
                if (_sdk.fPosEOFAlmacen() == 1)
                {
                    break;
                }
            }
            return almacenesList;
        }

        private AlmacenComercial LeerDatosAlmacenActual()
        {
            var idAlmacen = new StringBuilder(12);
            var codigoAlmacen = new StringBuilder(31);
            var nombreAlmacen = new StringBuilder(61);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoAlmacen("CIDALMACEN", idAlmacen, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoAlmacen("CCODIGOALMACEN", codigoAlmacen, 31);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoAlmacen("CNOMBREALMACEN", nombreAlmacen, 61);
            var almacen = new AlmacenComercial();
            almacen.IdAlmacen = int.Parse(idAlmacen.ToString());
            almacen.CodigoAlmacen = codigoAlmacen.ToString();
            almacen.NombreAlmacen = nombreAlmacen.ToString();
            return almacen;
        }
    }
}
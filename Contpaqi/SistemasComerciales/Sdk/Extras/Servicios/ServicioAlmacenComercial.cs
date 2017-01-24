using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;
using System.Collections.Generic;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioAlmacenComercial
    {
        private readonly ISistemasComercialesSdk _sdk;
        private readonly ServicioErrorComercial _errorComercialServicio;

        public ServicioAlmacenComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _errorComercialServicio = new ServicioErrorComercial(sdk);
        }

        public List<AlmacenComercial> TraerAlmacenes()
        {
            List<AlmacenComercial> almacenesList = new List<AlmacenComercial>();
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

        public AlmacenComercial BuscarAlmacen(int idAlmacen)
        {
            return _sdk.fBuscaIdAlmacen(idAlmacen) == 0 ? LeerDatosAlmacenActual() : null;
        }

        public AlmacenComercial BuscarAlmacen(string codigoAlmacen)
        {
            return _sdk.fBuscaAlmacen(codigoAlmacen) == 0 ? LeerDatosAlmacenActual() : null;
        }

        public AlmacenComercial LeerDatosAlmacenActual()
        {
            StringBuilder idAlmacen = new StringBuilder(12);
            StringBuilder codigoAlmacen = new StringBuilder(31);
            StringBuilder nombreAlmacen = new StringBuilder(61);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoAlmacen("CIDALMACEN", idAlmacen, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoAlmacen("CCODIGOALMACEN", codigoAlmacen, 31);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoAlmacen("CNOMBREALMACEN", nombreAlmacen, 61);
            AlmacenComercial almacen = new AlmacenComercial();
            almacen.IdAlmacen = int.Parse(idAlmacen.ToString());
            almacen.CodigoAlmacen = codigoAlmacen.ToString();
            almacen.NombreAlmacen = nombreAlmacen.ToString();
            return almacen;
        }
    }
}
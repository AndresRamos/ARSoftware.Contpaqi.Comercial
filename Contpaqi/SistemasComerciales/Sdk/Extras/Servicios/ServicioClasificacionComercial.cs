using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos.Enums;
using System.Collections.Generic;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioClasificacionComercial
    {
        private readonly ServicioErrorComercial _errorComercialServicio;
        private readonly ISistemasComercialesSdk _sdk;

        public ServicioClasificacionComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _errorComercialServicio = new ServicioErrorComercial(sdk);
        }

        public ClasificacionComercial BuscaClasificacion(TipoClasificacionEnum tipo, int numero)
        {
            return _sdk.fBuscaClasificacion((int)tipo, numero) == 0 ? LeerDatosClasificacionActual() : null;
        }

        public ClasificacionComercial BuscaClasificacion(int idClasificacion)
        {
            return _sdk.fBuscaIdClasificacion(idClasificacion) == 0 ? LeerDatosClasificacionActual() : null;
        }

        public List<ClasificacionComercial> TraerClasificaciones(TipoClasificacionEnum tipo)
        {
            List<ClasificacionComercial> clasificaciones = new List<ClasificacionComercial>();
            for (int i = 1; i < 7; i++)
            {
                var clasificacion = BuscaClasificacion(tipo, i);
                if (clasificacion != null)
                {
                    clasificaciones.Add(clasificacion);
                }
            }
            return clasificaciones;
        }

        private ClasificacionComercial LeerDatosClasificacionActual()
        {
            StringBuilder idClasificacion = new StringBuilder(12);
            StringBuilder nombreClasificacion = new StringBuilder(61);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoClasificacion("CIDCLASIFICACION", idClasificacion, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoClasificacion("CNOMBRECLASIFICACION", nombreClasificacion, 61);
            ClasificacionComercial clasificacion = new ClasificacionComercial();
            clasificacion.IdClasificacion = int.Parse(idClasificacion.ToString());
            clasificacion.NombreClasificacion = nombreClasificacion.ToString();
            return clasificacion;
        }
    }
}
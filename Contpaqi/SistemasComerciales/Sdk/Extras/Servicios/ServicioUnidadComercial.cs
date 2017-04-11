using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioUnidadComercial
    {
        private readonly ServicioErrorComercial _errorComercialServicio;
        private readonly ISistemasComercialesSdk _sdk;

        public ServicioUnidadComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _errorComercialServicio = new ServicioErrorComercial(sdk);
        }

        public UnidadComercial BuscarUnidad(string nombreUnidad)
        {
            return _sdk.fBuscaUnidad(nombreUnidad) == 0 ? LeerDatosUnindadActual() : null;
        }

        public UnidadComercial BuscarUnidad(int idUnidad)
        {
            return _sdk.fBuscaIdUnidad(idUnidad) == 0 ? LeerDatosUnindadActual() : null;
        }

        public IEnumerable<UnidadComercial> TraerUnidades()
        {
            List<UnidadComercial> UnidadesList = new List<UnidadComercial>();
            _errorComercialServicio.ResultadoSdk = _sdk.fPosPrimerUnidad();
            UnidadesList.Add(LeerDatosUnindadActual());
            while (_sdk.fPosSiguienteUnidad() == 0)
            {
                UnidadesList.Add(LeerDatosUnindadActual());
                if (_sdk.fPosEOFUnidad() == 1)
                {
                    break;
                }
            }
            return UnidadesList;
        }

        private UnidadComercial LeerDatosUnindadActual()
        {
            StringBuilder id = new StringBuilder(12);
            StringBuilder nombre = new StringBuilder(Constantes.kLongNombre);
            StringBuilder abreviatura = new StringBuilder(Constantes.kLongAbreviatura);
            StringBuilder despliegue = new StringBuilder(Constantes.kLongAbreviatura);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoUnidad("CIDUNIDAD", id, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoUnidad("CNOMBREUNIDAD", nombre, Constantes.kLongNombre);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoUnidad("CABREVIATURA", abreviatura, Constantes.kLongAbreviatura);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoUnidad("CDESPLIEGUE", despliegue, Constantes.kLongAbreviatura);
            UnidadComercial unidad = new UnidadComercial();
            unidad.IdUnidad = int.Parse(id.ToString());
            unidad.NombreUnidad = nombre.ToString();
            unidad.Abreviatura = abreviatura.ToString();
            unidad.Despliegue = despliegue.ToString();
            return unidad;
        }
    }
}
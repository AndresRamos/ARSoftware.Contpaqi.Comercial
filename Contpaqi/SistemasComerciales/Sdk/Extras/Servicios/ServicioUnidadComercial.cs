using System.Collections.Generic;
using System.Text;
using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;

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
            var unidadesList = new List<UnidadComercial>();
            _errorComercialServicio.ResultadoSdk = _sdk.fPosPrimerUnidad();
            unidadesList.Add(LeerDatosUnindadActual());
            while (_sdk.fPosSiguienteUnidad() == 0)
            {
                unidadesList.Add(LeerDatosUnindadActual());
                if (_sdk.fPosEOFUnidad() == 1)
                {
                    break;
                }
            }
            return unidadesList;
        }

        private UnidadComercial LeerDatosUnindadActual()
        {
            var id = new StringBuilder(12);
            var nombre = new StringBuilder(Constantes.kLongNombre);
            var abreviatura = new StringBuilder(Constantes.kLongAbreviatura);
            var despliegue = new StringBuilder(Constantes.kLongAbreviatura);
            var claveSat = new StringBuilder(4);
            var claveSatComercioExterior = new StringBuilder(4);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoUnidad("CIDUNIDAD", id, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoUnidad("CNOMBREUNIDAD", nombre, Constantes.kLongNombre);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoUnidad("CABREVIATURA", abreviatura, Constantes.kLongAbreviatura);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoUnidad("CDESPLIEGUE", despliegue, Constantes.kLongAbreviatura);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoUnidad("CCLAVEINT", claveSat, Constantes.kLongAbreviatura);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoUnidad("CCLAVESAT", claveSatComercioExterior, Constantes.kLongAbreviatura);
            var unidad = new UnidadComercial();
            unidad.IdUnidad = int.Parse(id.ToString());
            unidad.NombreUnidad = nombre.ToString();
            unidad.Abreviatura = abreviatura.ToString();
            unidad.Despliegue = despliegue.ToString();
            unidad.ClaveSat = claveSat.ToString();
            unidad.ClaveSatComercioExterior = claveSatComercioExterior.ToString();
            return unidad;
        }
    }
}
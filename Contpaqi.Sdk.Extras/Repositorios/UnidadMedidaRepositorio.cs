using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;

namespace Contpaqi.Sdk.Extras.Repositorios
{
    public class UnidadMedidaRepositorio
    {
        private readonly ErrorContpaqiSdkRepositorio _errorContpaqiSdkRepositorio;
        private readonly IContpaqiSdk _sdk;

        public UnidadMedidaRepositorio(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _errorContpaqiSdkRepositorio = new ErrorContpaqiSdkRepositorio(sdk);
        }

        public UnidadMedida BuscarUnidad(string nombreUnidad)
        {
            return _sdk.fBuscaUnidad(nombreUnidad) == 0 ? LeerDatosUnindadActual() : null;
        }

        public UnidadMedida BuscarUnidad(int idUnidad)
        {
            return _sdk.fBuscaIdUnidad(idUnidad) == 0 ? LeerDatosUnindadActual() : null;
        }

        public IEnumerable<UnidadMedida> TraerUnidades()
        {
            var unidadesList = new List<UnidadMedida>();
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fPosPrimerUnidad();
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

        private UnidadMedida LeerDatosUnindadActual()
        {
            var id = new StringBuilder(12);
            var nombre = new StringBuilder(Constantes.kLongNombre);
            var abreviatura = new StringBuilder(Constantes.kLongAbreviatura);
            var despliegue = new StringBuilder(Constantes.kLongAbreviatura);
            var claveSat = new StringBuilder(4);
            var claveSatComercioExterior = new StringBuilder(4);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoUnidad("CIDUNIDAD", id, 12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoUnidad("CNOMBREUNIDAD", nombre, Constantes.kLongNombre);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoUnidad("CABREVIATURA", abreviatura, Constantes.kLongAbreviatura);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoUnidad("CDESPLIEGUE", despliegue, Constantes.kLongAbreviatura);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoUnidad("CCLAVEINT", claveSat, Constantes.kLongAbreviatura);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoUnidad("CCLAVESAT", claveSatComercioExterior, Constantes.kLongAbreviatura);
            var unidad = new UnidadMedida();
            unidad.Id = int.Parse(id.ToString());
            unidad.Nombre = nombre.ToString();
            unidad.Abreviatura = abreviatura.ToString();
            unidad.Despliegue = despliegue.ToString();
            unidad.ClaveSat = claveSat.ToString();
            unidad.ClaveSatComercioExterior = claveSatComercioExterior.ToString();
            return unidad;
        }
    }
}
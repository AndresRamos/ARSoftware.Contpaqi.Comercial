using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;
using Contpaqi.Sdk.Extras.Modelos.Enums;

namespace Contpaqi.Sdk.Extras.Repositorios
{
    public class ClasificacionRepositorio
    {
        private readonly ErrorContpaqiSdkRepositorio _errorContpaqiSdkRepositorio;
        private readonly IContpaqiSdk _sdk;

        public ClasificacionRepositorio(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _errorContpaqiSdkRepositorio = new ErrorContpaqiSdkRepositorio(sdk);
        }

        public Clasificacion BuscaClasificacion(TipoClasificacionEnum tipo, int numero)
        {
            return _sdk.fBuscaClasificacion((int) tipo, numero) == 0 ? LeerDatosClasificacionActual() : null;
        }

        public Clasificacion BuscaClasificacion(int idClasificacion)
        {
            return _sdk.fBuscaIdClasificacion(idClasificacion) == 0 ? LeerDatosClasificacionActual() : null;
        }

        public List<Clasificacion> TraerClasificaciones(TipoClasificacionEnum tipo)
        {
            var clasificaciones = new List<Clasificacion>();
            for (var i = 1; i < 7; i++)
            {
                var clasificacion = BuscaClasificacion(tipo, i);
                if (clasificacion != null)
                {
                    clasificaciones.Add(clasificacion);
                }
            }

            return clasificaciones;
        }

        private Clasificacion LeerDatosClasificacionActual()
        {
            var id = new StringBuilder(12);
            var nombre = new StringBuilder(61);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoClasificacion("CIDCLASIFICACION", id, 12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoClasificacion("CNOMBRECLASIFICACION", nombre, 61);
            var clasificacion = new Clasificacion
            {
                Id = int.Parse(id.ToString()),
                Nombre = nombre.ToString()
            };
            return clasificacion;
        }
    }
}
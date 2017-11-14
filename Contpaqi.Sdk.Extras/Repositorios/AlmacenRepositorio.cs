using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;

namespace Contpaqi.Sdk.Extras.Repositorios
{
    public class AlmacenRepositorio
    {
        private readonly ErrorContpaqiSdkRepositorio _errorContpaqiSdkRepositorio;
        private readonly IContpaqiSdk _sdk;

        public AlmacenRepositorio(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _errorContpaqiSdkRepositorio = new ErrorContpaqiSdkRepositorio(sdk);
        }

        public Almacen BuscarAlmacen(int idAlmacen)
        {
            return _sdk.fBuscaIdAlmacen(idAlmacen) == 0 ? LeerDatosAlmacenActual() : null;
        }

        public Almacen BuscarAlmacen(string codigoAlmacen)
        {
            return _sdk.fBuscaAlmacen(codigoAlmacen) == 0 ? LeerDatosAlmacenActual() : null;
        }

        public List<Almacen> TraerAlmacenes()
        {
            var almacenesList = new List<Almacen>();
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fPosPrimerAlmacen();
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

        private Almacen LeerDatosAlmacenActual()
        {
            var id = new StringBuilder(12);
            var codigo = new StringBuilder(31);
            var nombre = new StringBuilder(61);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoAlmacen("CIDALMACEN", id, 12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoAlmacen("CCODIGOALMACEN", codigo, 31);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoAlmacen("CNOMBREALMACEN", nombre, 61);
            var almacen = new Almacen
            {
                Id = int.Parse(id.ToString()),
                Codigo = codigo.ToString(),
                Nombre = nombre.ToString()
            };
            return almacen;
        }
    }
}
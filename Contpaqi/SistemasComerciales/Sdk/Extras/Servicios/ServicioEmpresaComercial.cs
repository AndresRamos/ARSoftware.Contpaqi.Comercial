using System.Collections.Generic;
using System.Text;
using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioEmpresaComercial
    {
        private readonly ServicioErrorComercial _errorComercialServicio;
        private readonly ISistemasComercialesSdk _sdk;

        public ServicioEmpresaComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _errorComercialServicio = new ServicioErrorComercial(sdk);
        }

        public List<EmpresaComercial> TraerEmpresas()
        {
            var empresasList = new List<EmpresaComercial>();
            var id = 0;
            var nombre = new StringBuilder(Constantes.kLongNombre);
            var ruta = new StringBuilder(Constantes.kLongRuta);
            _errorComercialServicio.ResultadoSdk = _sdk.fPosPrimerEmpresa(ref id, nombre, ruta);
            var empresa = new EmpresaComercial
            {
                IdEmpresa = id,
                NombreEmpresa = nombre.ToString(),
                Ruta = ruta.ToString()
            };
            empresasList.Add(empresa);
            while (_sdk.fPosSiguienteEmpresa(ref id, nombre, ruta) == 0)
            {
                empresa = new EmpresaComercial
                {
                    IdEmpresa = id,
                    NombreEmpresa = nombre.ToString(),
                    Ruta = ruta.ToString()
                };
                empresasList.Add(empresa);
            }
            return empresasList;
        }
    }
}
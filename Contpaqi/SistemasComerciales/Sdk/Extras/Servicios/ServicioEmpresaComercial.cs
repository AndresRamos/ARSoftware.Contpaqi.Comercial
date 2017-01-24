using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;
using System.Collections.Generic;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioEmpresaComercial
    {
        private readonly ISistemasComercialesSdk _sdk;
        private readonly ServicioErrorComercial _errorComercialServicio;

        public ServicioEmpresaComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _errorComercialServicio = new ServicioErrorComercial(sdk);
        }

        public List<EmpresaComercial> TraerEmpresas()
        {
            List<EmpresaComercial> empresasList = new List<EmpresaComercial>();
            int id = 0;
            StringBuilder nombre = new StringBuilder(Constantes.kLongNombre);
            StringBuilder ruta = new StringBuilder(Constantes.kLongRuta);
            _errorComercialServicio.ResultadoSdk = _sdk.fPosPrimerEmpresa(ref id, nombre, ruta);
            EmpresaComercial empresa = new EmpresaComercial
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
using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;

namespace Contpaqi.Sdk.Extras.Repositorios
{
    public class EmpresaRepositorio
    {
        private readonly ErrorContpaqiSdkRepositorio _errorContpaqiSdkRepositorio;
        private readonly IContpaqiSdk _sdk;

        public EmpresaRepositorio(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _errorContpaqiSdkRepositorio = new ErrorContpaqiSdkRepositorio(sdk);
        }

        public List<Empresa> TraerEmpresas()
        {
            var empresasList = new List<Empresa>();
            var id = 0;
            var nombre = new StringBuilder(Constantes.kLongNombre);
            var ruta = new StringBuilder(Constantes.kLongRuta);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fPosPrimerEmpresa(ref id, nombre, ruta);
            var empresa = new Empresa
            {
                Id = id,
                Nombre = nombre.ToString(),
                Ruta = ruta.ToString()
            };
            empresasList.Add(empresa);
            while (_sdk.fPosSiguienteEmpresa(ref id, nombre, ruta) == 0)
            {
                empresa = new Empresa
                {
                    Id = id,
                    Nombre = nombre.ToString(),
                    Ruta = ruta.ToString()
                };
                empresasList.Add(empresa);
            }
            return empresasList;
        }
    }
}
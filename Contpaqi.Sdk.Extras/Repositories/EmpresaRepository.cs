using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class EmpresaRepository : IEmpresaRepository<Empresa>
    {
        private readonly IContpaqiSdk _sdk;

        public EmpresaRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public IEnumerable<Empresa> GetAll()
        {
            var id = 0;
            var nombre = new StringBuilder(Constantes.kLongNombre);
            var ruta = new StringBuilder(Constantes.kLongRuta);

            _sdk.fPosPrimerEmpresa(ref id, nombre, ruta).ToResultadoSdk(_sdk).ThrowIfError();
            var empresa = new Empresa();
            empresa.Id = id;
            empresa.Nombre = nombre.ToString();
            empresa.Ruta = ruta.ToString();
            yield return empresa;

            while (_sdk.fPosSiguienteEmpresa(ref id, nombre, ruta) == SdkResultConstants.Success)
            {
                empresa = new Empresa();
                empresa.Id = id;
                empresa.Nombre = nombre.ToString();
                empresa.Ruta = ruta.ToString();
                yield return empresa;
            }
        }
    }
}
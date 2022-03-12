using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Constantes;
using Contpaqi.Sdk.Extras.Extensions;
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

        public IEnumerable<Empresa> TraerTodo()
        {
            var id = 0;
            var nombre = new StringBuilder(ConstantesSdk.kLongNombre);
            var ruta = new StringBuilder(ConstantesSdk.kLongRuta);

            _sdk.fPosPrimerEmpresa(ref id, nombre, ruta).ToResultadoSdk(_sdk).ThrowIfError();
            var empresa = new Empresa();
            empresa.CIDEMPRESA = id;
            empresa.CNOMBREEMPRESA = nombre.ToString();
            empresa.CRUTADATOS = ruta.ToString();
            yield return empresa;

            while (_sdk.fPosSiguienteEmpresa(ref id, nombre, ruta) == SdkResultConstants.Success)
            {
                empresa = new Empresa();
                empresa.CIDEMPRESA = id;
                empresa.CNOMBREEMPRESA = nombre.ToString();
                empresa.CRUTADATOS = ruta.ToString();
                yield return empresa;
            }
        }
    }
}

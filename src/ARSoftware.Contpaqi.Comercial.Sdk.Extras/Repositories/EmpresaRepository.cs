using System.Collections.Generic;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories
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
            var nombre = new StringBuilder(SdkConstantes.kLongNombre);
            var ruta = new StringBuilder(SdkConstantes.kLongRuta);

            _sdk.fPosPrimerEmpresa(ref id, nombre, ruta).ToResultadoSdk(_sdk).ThrowIfError();
            var empresa = new Empresa();
            empresa.CIDEMPRESA = id;
            empresa.CNOMBREEMPRESA = nombre.ToString();
            empresa.CRUTADATOS = ruta.ToString();
            empresa.CRUTARESPALDOS = ruta.ToString();
            yield return empresa;

            while (_sdk.fPosSiguienteEmpresa(ref id, nombre, ruta) == SdkResultConstants.Success)
            {
                empresa = new Empresa();
                empresa.CIDEMPRESA = id;
                empresa.CNOMBREEMPRESA = nombre.ToString();
                empresa.CRUTADATOS = ruta.ToString();
                empresa.CRUTARESPALDOS = ruta.ToString();
                yield return empresa;
            }
        }
    }
}

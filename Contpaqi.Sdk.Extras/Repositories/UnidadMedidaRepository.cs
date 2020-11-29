using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class UnidadMedidaRepository : IUnidadMedidaRepository<UnidadMedida>
    {
        private readonly IContpaqiSdk _sdk;

        public UnidadMedidaRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public UnidadMedida FindByNombre(string nombreUnidad)
        {
            return _sdk.fBuscaUnidad(nombreUnidad) == SdkResultConstants.Success ? LeerDatosUnindadActual() : null;
        }

        public UnidadMedida FindById(int idUnidad)
        {
            return _sdk.fBuscaIdUnidad(idUnidad) == SdkResultConstants.Success ? LeerDatosUnindadActual() : null;
        }

        public IEnumerable<UnidadMedida> GetAll()
        {
            _sdk.fPosPrimerUnidad().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosUnindadActual();
            while (_sdk.fPosSiguienteUnidad() == SdkResultConstants.Success)
            {
                yield return LeerDatosUnindadActual();
                if (_sdk.fPosEOFUnidad() == 1)
                {
                    break;
                }
            }
        }

        private UnidadMedida LeerDatosUnindadActual()
        {
            var id = new StringBuilder(12);
            var nombre = new StringBuilder(Constantes.kLongNombre);
            var abreviatura = new StringBuilder(Constantes.kLongAbreviatura);
            var despliegue = new StringBuilder(Constantes.kLongAbreviatura);
            var claveSat = new StringBuilder(4);
            var claveSatComercioExterior = new StringBuilder(4);

            _sdk.fLeeDatoUnidad("CIDUNIDAD", id, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoUnidad("CNOMBREUNIDAD", nombre, Constantes.kLongNombre).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoUnidad("CABREVIATURA", abreviatura, Constantes.kLongAbreviatura).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoUnidad("CDESPLIEGUE", despliegue, Constantes.kLongAbreviatura).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoUnidad("CCLAVEINT", claveSat, Constantes.kLongAbreviatura).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoUnidad("CCLAVESAT", claveSatComercioExterior, Constantes.kLongAbreviatura).ToResultadoSdk(_sdk).ThrowIfError();

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
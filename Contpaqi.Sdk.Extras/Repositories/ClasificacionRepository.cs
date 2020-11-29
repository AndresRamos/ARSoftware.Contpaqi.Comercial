using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class ClasificacionRepository : IClasificacionRepository<Clasificacion>
    {
        private readonly IContpaqiSdk _sdk;
        private readonly IValorClasificacionRepository<ValorClasificacion> _valorClasificacionRepository;

        public ClasificacionRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _valorClasificacionRepository = new ValorClasificacionRepository(sdk);
        }

        public Clasificacion FindByTipoAndNumero(TipoClasificacionEnum tipo, int numero)
        {
            return _sdk.fBuscaClasificacion((int) tipo, numero) == SdkResultConstants.Success ? LeerDatosClasificacionActual() : null;
        }

        public Clasificacion FindById(int idClasificacion)
        {
            return _sdk.fBuscaIdClasificacion(idClasificacion) == SdkResultConstants.Success ? LeerDatosClasificacionActual() : null;
        }

        public IEnumerable<Clasificacion> GetAllByTipo(TipoClasificacionEnum tipo)
        {
            for (var i = 1; i < 7; i++)
            {
                yield return FindByTipoAndNumero(tipo, i);
            }
        }

        public IEnumerable<Clasificacion> GetAll()
        {
            _sdk.fPosPrimerClasificacion().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosClasificacionActual();

            while (_sdk.fPosSiguienteClasificacion() == SdkResultConstants.Success)
            {
                yield return LeerDatosClasificacionActual();
                if (_sdk.fPosEOFClasificacion() == 1)
                {
                    break;
                }
            }
        }

        private Clasificacion LeerDatosClasificacionActual()
        {
            var id = new StringBuilder(12);
            var nombre = new StringBuilder(61);

            _sdk.fLeeDatoClasificacion("CIDCLASIFICACION", id, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoClasificacion("CNOMBRECLASIFICACION", nombre, 61).ToResultadoSdk(_sdk).ThrowIfError();

            var clasificacion = new Clasificacion();
            clasificacion.Id = int.Parse(id.ToString());
            clasificacion.Nombre = nombre.ToString();
            clasificacion.Valores = _valorClasificacionRepository.GetAllByClasificacionId(clasificacion.Id).ToList();

            return clasificacion;
        }
    }
}
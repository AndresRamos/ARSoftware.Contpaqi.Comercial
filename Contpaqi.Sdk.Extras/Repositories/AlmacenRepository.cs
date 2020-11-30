using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class AlmacenRepository : IAlmacenRepository<Almacen>
    {
        private readonly IContpaqiSdk _sdk;

        public AlmacenRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public Almacen BuscarPorId(int idAlmacen)
        {
            return _sdk.fBuscaIdAlmacen(idAlmacen) == SdkResultConstants.Success ? LeerDatosAlmacenActual() : null;
        }

        public Almacen BuscarPorCodigo(string codigoAlmacen)
        {
            return _sdk.fBuscaAlmacen(codigoAlmacen) == SdkResultConstants.Success ? LeerDatosAlmacenActual() : null;
        }

        public IEnumerable<Almacen> TraerTodo()
        {
            _sdk.fPosPrimerAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosAlmacenActual();

            while (_sdk.fPosSiguienteAlmacen() == SdkResultConstants.Success)
            {
                yield return LeerDatosAlmacenActual();
                if (_sdk.fPosEOFAlmacen() == 1)
                {
                    break;
                }
            }
        }

        private Almacen LeerDatosAlmacenActual()
        {
            var id = new StringBuilder(12);
            var codigo = new StringBuilder(31);
            var nombre = new StringBuilder(61);

            _sdk.fLeeDatoAlmacen("CIDALMACEN", id, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoAlmacen("CCODIGOALMACEN", codigo, 31).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoAlmacen("CNOMBREALMACEN", nombre, 61).ToResultadoSdk(_sdk).ThrowIfError();

            var almacen = new Almacen();
            almacen.Id = int.Parse(id.ToString());
            almacen.Codigo = codigo.ToString();
            almacen.Nombre = nombre.ToString();
            return almacen;
        }
    }
}
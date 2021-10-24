using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Services
{
    public class AlmacenService : IAlmacenService
    {
        private readonly IContpaqiSdk _sdk;

        public AlmacenService(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public int Crear(Dictionary<string, string> datosAlmacen)
        {
            _sdk.fInsertaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatosAlmacen(datosAlmacen);
            _sdk.fGuardaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();

            var idAlmacenDato = new StringBuilder(12);
            _sdk.fLeeDatoAlmacen("CIDALMACEN", idAlmacenDato, 12).ToResultadoSdk(_sdk).ThrowIfError();
            return int.Parse(idAlmacenDato.ToString());
        }

        public void Actualizar(int almacenId, Dictionary<string, string> datosAlmacen)
        {
            _sdk.fBuscaIdAlmacen(almacenId).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fEditaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatosAlmacen(datosAlmacen);
            _sdk.fGuardaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void Actualizar(string almacenCodigo, Dictionary<string, string> datosAlmacen)
        {
            _sdk.fBuscaAlmacen(almacenCodigo).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fEditaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatosAlmacen(datosAlmacen);
            _sdk.fGuardaAlmacen().ToResultadoSdk(_sdk).ThrowIfError();
        }

        private void SetDatosAlmacen(Dictionary<string, string> datosAlmacen)
        {
            foreach (var dato in datosAlmacen)
            {
                _sdk.fSetDatoAlmacen(dato.Key, dato.Value);
            }
        }
    }
}
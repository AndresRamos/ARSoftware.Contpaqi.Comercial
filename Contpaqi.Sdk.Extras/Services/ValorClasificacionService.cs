using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Services
{
    public class ValorClasificacionService : IValorClasificacionService
    {
        private readonly IContpaqiSdk _sdk;

        public ValorClasificacionService(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public int Crear(tValorClasificacion valorClasificacion)
        {
            var idValorClasificacion = 0;
            _sdk.fAltaValorClasif(ref idValorClasificacion, ref valorClasificacion).ToResultadoSdk(_sdk).ThrowIfError();
            return idValorClasificacion;
        }

        public void Actualizar(int idValorClasificacion, Dictionary<string, string> datosValorClasificacion)
        {
            _sdk.fBuscaIdValorClasif(idValorClasificacion).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fEditaValorClasif().ToResultadoSdk(_sdk).ThrowIfError();

            foreach (var dato in datosValorClasificacion)
            {
                _sdk.fSetDatoValorClasif(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
            }

            _sdk.fGuardaValorClasif().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void Eliminar(int idValorClasificacion)
        {
            _sdk.fBuscaIdValorClasif(idValorClasificacion).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fBorraValorClasif().ToResultadoSdk(_sdk).ThrowIfError();
        }
    }
}
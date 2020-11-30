using System.Text;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class SdkErrorRepository : ISdkErrorRepository<SdkError>
    {
        private readonly IContpaqiSdk _sdk;

        public SdkErrorRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public string BuscarMensajePorNumero(int numeroError)
        {
            var mensajeError = new StringBuilder(512);
            _sdk.fError(numeroError, mensajeError, 512);
            return mensajeError.ToString();
        }

        public SdkError BuscarPorNumero(int numeroError)
        {
            return new SdkError {Numero = numeroError, Mensaje = BuscarMensajePorNumero(numeroError)};
        }
    }
}
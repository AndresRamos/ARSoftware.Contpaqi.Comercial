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

        public string FindMensajeByNumero(int numeroError)
        {
            var mensajeError = new StringBuilder(512);
            _sdk.fError(numeroError, mensajeError, 512);
            return mensajeError.ToString();
        }

        public SdkError FindByNumero(int numeroError)
        {
            return new SdkError {Numero = numeroError, Mensaje = FindMensajeByNumero(numeroError)};
        }
    }
}
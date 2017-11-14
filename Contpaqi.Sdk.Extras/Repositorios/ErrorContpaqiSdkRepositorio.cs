using System.Text;
using Contpaqi.Sdk.Extras.Excepciones;
using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Repositorios
{
    public class ErrorContpaqiSdkRepositorio
    {
        private readonly IContpaqiSdk _sdk;

        public ErrorContpaqiSdkRepositorio(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public int ResultadoSdk
        {
            set
            {
                if (value != 0)
                {
                    var mensajeError = LeerError(value);
                    throw new ContpaqiSdkException(value, mensajeError);
                }
            }
        }


        public string LeerError(int error)
        {
            var mensageDelError = new StringBuilder(512);
            _sdk.fError(error, mensageDelError, 512);
            return mensageDelError.ToString();
        }
    }
}
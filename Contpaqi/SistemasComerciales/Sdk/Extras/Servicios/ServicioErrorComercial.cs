using System.Text;
using Contpaqi.SistemasComerciales.Sdk.Extras.Excepciones;
using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioErrorComercial
    {
        private readonly ISistemasComercialesSdk _sdk;

        public ServicioErrorComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
        }

        public int ResultadoSdk
        {
            set
            {
                if (value != 0)
                {
                    var mensageDelError = LeerError(value);
                    throw new SistemasComercialesSdkException(value, mensageDelError);
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
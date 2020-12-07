using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Models
{
    public class SdkError : ISdkError
    {
        public SdkError()
        {
        }

        public SdkError(int numero, string mensaje)
        {
            Numero = numero;
            Mensaje = mensaje;
        }

        public int Numero { get; set; }

        public string Mensaje { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{Numero} - {Mensaje}";
        }
    }
}
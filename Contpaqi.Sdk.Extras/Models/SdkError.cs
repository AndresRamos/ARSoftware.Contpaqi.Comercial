namespace Contpaqi.Sdk.Extras.Models
{
    public class SdkError
    {
        public SdkError()
        {
        }

        public SdkError(int numero, string mensaje)
        {
            Numero = numero;
            Mensaje = mensaje;
        }

        public string Mensaje { get; set; } = string.Empty;

        public string MensajeConNumero => $"Mensaje:{Mensaje} Numero:{Numero}";

        public int Numero { get; set; }

        public override string ToString()
        {
            return $"{Numero} - {Mensaje}";
        }
    }
}

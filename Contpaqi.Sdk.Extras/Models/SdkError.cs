using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Models
{
    public class SdkError : ISdkError
    {
        public int Numero { get; set; } = 0;

        public string Mensaje { get; set; } = "";
    }
}
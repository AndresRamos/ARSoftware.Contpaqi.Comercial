using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Models
{
    public class ClienteProveedorLookup : IClienteProveedor
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string RazonSocial { get; set; }

        public string Rfc { get; set; }

        public TipoClienteEnum Tipo { get; set; }

        public int Estatus { get; set; }

        public override string ToString()
        {
            return $"{Codigo} - {RazonSocial}";
        }
    }
}
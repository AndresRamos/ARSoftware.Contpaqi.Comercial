namespace Contpaqi.SistemasComerciales.Sdk.Extras.Modelos
{
    public class DireccionComercial
    {
        public DireccionComercial()
        {
            ClienteProveedor = new ClienteProveedorComercial();
        }

        public string CodCteProv;
        public int TipoCatalogo;
        public int TipoDireccion;
        public string NombreCalle;
        public string NumeroExterior;
        public string NumeroInterior;
        public string Colonia;
        public string CodigoPostal;
        public string Telefono1;
        public string Telefono2;
        public string Telefono3;
        public string Telefono4;
        public string Email;
        public string DireccionWeb;
        public string Ciudad;
        public string Estado;
        public string Pais;
        public string TextoExtra;

        // Propiedades Extras
        public int IdDireccion { get; set; }

        public int IdCatalogo { get; set; }

        public ClienteProveedorComercial ClienteProveedor { get; set; }
    }
}
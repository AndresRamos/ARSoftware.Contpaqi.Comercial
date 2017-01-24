using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioDireccionComercial
    {
        private readonly ISistemasComercialesSdk _sdk;
        private readonly ServicioErrorComercial _errorComercialServicio;
        private readonly ServicioClienteProveedorComercial _servicioClienteProveedorComercial;

        public ServicioDireccionComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _errorComercialServicio = new ServicioErrorComercial(sdk);
            _servicioClienteProveedorComercial = new ServicioClienteProveedorComercial(sdk);
        }

        public DireccionComercial BuscarDireccion(string codigoClienteProveedor, int tipoDireccion)
        {
            return _sdk.fBuscaDireccionCteProv(codigoClienteProveedor, tipoDireccion) == 0 ? LeerDatosDireccionActual() : null;
        }

        private DireccionComercial LeerDatosDireccionActual()
        {
            StringBuilder TipoCatalogo = new StringBuilder(7);
            StringBuilder TipoDireccion = new StringBuilder(7);
            StringBuilder NombreCalle = new StringBuilder(61);
            StringBuilder NumeroExterior = new StringBuilder(31);
            StringBuilder NumeroInterior = new StringBuilder(31);
            StringBuilder Colonia = new StringBuilder(61);
            StringBuilder CodigoPostal = new StringBuilder(7);
            StringBuilder Telefono1 = new StringBuilder(16);
            StringBuilder Telefono2 = new StringBuilder(16);
            StringBuilder Telefono3 = new StringBuilder(16);
            StringBuilder Telefono4 = new StringBuilder(16);
            StringBuilder Email = new StringBuilder(51);
            StringBuilder DireccionWeb = new StringBuilder(51);
            StringBuilder Ciudad = new StringBuilder(61);
            StringBuilder Estado = new StringBuilder(61);
            StringBuilder Pais = new StringBuilder(61);
            StringBuilder TextoExtra = new StringBuilder(61);
            StringBuilder IdDireccion = new StringBuilder(12);
            StringBuilder IdCatalogo = new StringBuilder(12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CTIPOCATALOGO", TipoCatalogo, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CTIPODIRECCION", TipoDireccion, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CNOMBRECALLE", NombreCalle, 61);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CNUMEROEXTERIOR", NumeroExterior, 31);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CNUMEROINTERIOR", NumeroInterior, 31);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CCOLONIA", Colonia, 61);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CCODIGOPOSTAL", CodigoPostal, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CTELEFONO1", Telefono1, 16);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CTELEFONO2", Telefono2, 16);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CTELEFONO3", Telefono3, 16);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CTELEFONO4", Telefono4, 16);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CEMAIL", Email, 51);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CDIRECCIONWEB", DireccionWeb, 51);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CCIUDAD", Ciudad, 61);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CESTADO", Estado, 61);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CPAIS", Pais, 61);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CTEXTOEXTRA", TextoExtra, 61);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CIDDIRECCION", IdDireccion, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoDireccion("CIDCATALOGO", IdCatalogo, 12);
            DireccionComercial direccion = new DireccionComercial();
            direccion.TipoCatalogo = int.Parse(TipoCatalogo.ToString());
            direccion.TipoDireccion = int.Parse(TipoDireccion.ToString());
            direccion.NombreCalle = NombreCalle.ToString();
            direccion.NumeroExterior = NumeroExterior.ToString();
            direccion.NumeroInterior = NumeroInterior.ToString();
            direccion.Colonia = Colonia.ToString();
            direccion.CodigoPostal = CodigoPostal.ToString();
            direccion.Telefono1 = Telefono1.ToString();
            direccion.Telefono2 = Telefono2.ToString();
            direccion.Telefono3 = Telefono3.ToString();
            direccion.Telefono4 = Telefono4.ToString();
            direccion.Email = Email.ToString();
            direccion.DireccionWeb = DireccionWeb.ToString();
            direccion.Ciudad = Ciudad.ToString();
            direccion.Estado = Estado.ToString();
            direccion.Pais = Pais.ToString();
            direccion.TextoExtra = TextoExtra.ToString();
            direccion.IdDireccion = int.Parse(IdDireccion.ToString());
            direccion.IdCatalogo = int.Parse(IdCatalogo.ToString());
            if (direccion.TipoCatalogo == 1 || direccion.TipoCatalogo == 2)
            {
                direccion.ClienteProveedor = _servicioClienteProveedorComercial.BuscarClienteProveedor(direccion.IdCatalogo);
                direccion.CodCteProv = direccion.ClienteProveedor.CodigoCliente;
            }
            return direccion;
        }
    }
}
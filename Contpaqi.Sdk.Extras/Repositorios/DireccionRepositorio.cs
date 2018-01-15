using System.Text;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;

namespace Contpaqi.Sdk.Extras.Repositorios
{
    public class DireccionRepositorio
    {
        private readonly ClienteProveedorRepositorio _clienteProveedorRepositorio;
        private readonly ErrorContpaqiSdkRepositorio _errorContpaqiSdkRepositorio;
        private readonly IContpaqiSdk _sdk;

        public DireccionRepositorio(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _errorContpaqiSdkRepositorio = new ErrorContpaqiSdkRepositorio(sdk);
            _clienteProveedorRepositorio = new ClienteProveedorRepositorio(sdk);
        }

        public Direccion BuscarDireccion(string codigoClienteProveedor, byte tipoDireccion)
        {
            return _sdk.fBuscaDireccionCteProv(codigoClienteProveedor, tipoDireccion) == 0 ? LeerDatosDireccionActual() : null;
        }

        private Direccion LeerDatosDireccionActual()
        {
            var tipoCatalogo = new StringBuilder(7);
            var tipoDireccion = new StringBuilder(7);
            var nombreCalle = new StringBuilder(61);
            var numeroExterior = new StringBuilder(31);
            var numeroInterior = new StringBuilder(31);
            var colonia = new StringBuilder(61);
            var codigoPostal = new StringBuilder(7);
            var telefono1 = new StringBuilder(16);
            var telefono2 = new StringBuilder(16);
            var telefono3 = new StringBuilder(16);
            var telefono4 = new StringBuilder(16);
            var email = new StringBuilder(51);
            var direccionWeb = new StringBuilder(51);
            var ciudad = new StringBuilder(61);
            var estado = new StringBuilder(61);
            var pais = new StringBuilder(61);
            var textoExtra = new StringBuilder(61);
            var idDireccion = new StringBuilder(12);
            var idCatalogo = new StringBuilder(12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CTIPOCATALOGO", tipoCatalogo, 7);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CTIPODIRECCION", tipoDireccion, 7);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CNOMBRECALLE", nombreCalle, 61);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CNUMEROEXTERIOR", numeroExterior, 31);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CNUMEROINTERIOR", numeroInterior, 31);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CCOLONIA", colonia, 61);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CCODIGOPOSTAL", codigoPostal, 7);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CTELEFONO1", telefono1, 16);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CTELEFONO2", telefono2, 16);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CTELEFONO3", telefono3, 16);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CTELEFONO4", telefono4, 16);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CEMAIL", email, 51);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CDIRECCIONWEB", direccionWeb, 51);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CCIUDAD", ciudad, 61);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CESTADO", estado, 61);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CPAIS", pais, 61);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CTEXTOEXTRA", textoExtra, 61);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CIDDIRECCION", idDireccion, 12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoDireccion("CIDCATALOGO", idCatalogo, 12);
            var direccion = new Direccion();
            direccion.TipoCatalogo = int.Parse(tipoCatalogo.ToString());
            direccion.TipoDireccion = int.Parse(tipoDireccion.ToString());
            direccion.NombreCalle = nombreCalle.ToString();
            direccion.NumeroExterior = numeroExterior.ToString();
            direccion.NumeroInterior = numeroInterior.ToString();
            direccion.Colonia = colonia.ToString();
            direccion.CodigoPostal = codigoPostal.ToString();
            direccion.Telefono1 = telefono1.ToString();
            direccion.Telefono2 = telefono2.ToString();
            direccion.Telefono3 = telefono3.ToString();
            direccion.Telefono4 = telefono4.ToString();
            direccion.Email = email.ToString();
            direccion.DireccionWeb = direccionWeb.ToString();
            direccion.Ciudad = ciudad.ToString();
            direccion.Estado = estado.ToString();
            direccion.Pais = pais.ToString();
            direccion.TextoExtra = textoExtra.ToString();
            direccion.Id = int.Parse(idDireccion.ToString());
            direccion.IdCatalogo = int.Parse(idCatalogo.ToString());
            if (direccion.TipoCatalogo == 1 || direccion.TipoCatalogo == 2)
            {
                direccion.ClienteProveedor = _clienteProveedorRepositorio.BuscarClienteProveedor(direccion.IdCatalogo);
                direccion.CodCteProv = direccion.ClienteProveedor.Codigo;
            }
            return direccion;
        }
    }
}
using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioSistemasComerciales
    {
        public ServicioSistemasComerciales(ISistemasComercialesSdk sdk)
        {
            SistemasComercialesSdk = sdk;
            ServicioAgenteComercial = new ServicioAgenteComercial(sdk);
            ServicioAlmacenComercial = new ServicioAlmacenComercial(sdk);
            ServicioClasificacionComercial = new ServicioClasificacionComercial(sdk);
            ServicioClienteProveedorComercial = new ServicioClienteProveedorComercial(sdk);
            ServicioConceptoDocumentoComercial = new ServicioConceptoDocumentoComercial(sdk);
            ServicioDireccionComercial = new ServicioDireccionComercial(sdk);
            ServicioDocumentoComercial = new ServicioDocumentoComercial(sdk);
            ServicioEmpresaComercial = new ServicioEmpresaComercial(sdk);
            ServicioErrorComercial = new ServicioErrorComercial(sdk);
            ServicioMovimientoComercial = new ServicioMovimientoComercial(sdk);
            ServicioProductoComercial = new ServicioProductoComercial(sdk);
            ServicioUnidadComercial = new ServicioUnidadComercial(sdk);
            ServicioValorClasificacionComercial = new ServicioValorClasificacionComercial(sdk);
        }

        public ServicioAgenteComercial ServicioAgenteComercial { get; }

        public ServicioAlmacenComercial ServicioAlmacenComercial { get; }

        public ServicioClasificacionComercial ServicioClasificacionComercial { get; }

        public ServicioClienteProveedorComercial ServicioClienteProveedorComercial { get; }

        public ServicioConceptoDocumentoComercial ServicioConceptoDocumentoComercial { get; }

        public ServicioDireccionComercial ServicioDireccionComercial { get; }

        public ServicioDocumentoComercial ServicioDocumentoComercial { get; }

        public ServicioEmpresaComercial ServicioEmpresaComercial { get; }

        public ServicioErrorComercial ServicioErrorComercial { get; }

        public ServicioMovimientoComercial ServicioMovimientoComercial { get; }

        public ServicioProductoComercial ServicioProductoComercial { get; }

        public ServicioUnidadComercial ServicioUnidadComercial { get; }

        public ServicioValorClasificacionComercial ServicioValorClasificacionComercial { get; }

        public ISistemasComercialesSdk SistemasComercialesSdk { get; }
    }
}
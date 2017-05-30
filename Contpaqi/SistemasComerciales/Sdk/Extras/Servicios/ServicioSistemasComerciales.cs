using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioSistemasComerciales
    {
        private ServicioAgenteComercial _servicioAgenteComercial;
        private ServicioAlmacenComercial _servicioAlmacenComercial;
        private ServicioClienteProveedorComercial _servicioClienteProveedorComercial;
        private ServicioConceptoDocumentoComercial _servicioConceptoDocumentoComercial;
        private ServicioDireccionComercial _servicioDireccionComercial;
        private ServicioDocumentoComercial _servicioDocumentoComercial;
        private ServicioEmpresaComercial _servicioEmpresaComercial;
        private ServicioErrorComercial _servicioErrorComercial;
        private ServicioMovimientoComercial _servicioMovimientoComercial;
        private ServicioProductoComercial _servicioProductoComercial;
        private ServicioUnidadComercial _servicioUnidadComercial;
        private ServicioValorClasificacionComercial _servicioValorClasificacionComercial;

        public ServicioSistemasComerciales(ISistemasComercialesSdk sdk)
        {
            _servicioAgenteComercial = new ServicioAgenteComercial(sdk);
            _servicioAlmacenComercial = new ServicioAlmacenComercial(sdk);
            _servicioClienteProveedorComercial = new ServicioClienteProveedorComercial(sdk);
            _servicioConceptoDocumentoComercial = new ServicioConceptoDocumentoComercial(sdk);
            _servicioDireccionComercial = new ServicioDireccionComercial(sdk);
            _servicioDocumentoComercial = new ServicioDocumentoComercial(sdk);
            _servicioEmpresaComercial = new ServicioEmpresaComercial(sdk);
            _servicioErrorComercial = new ServicioErrorComercial(sdk);
            _servicioMovimientoComercial = new ServicioMovimientoComercial(sdk);
            _servicioProductoComercial = new ServicioProductoComercial(sdk);
            _servicioUnidadComercial = new ServicioUnidadComercial(sdk);
            _servicioValorClasificacionComercial = new ServicioValorClasificacionComercial(sdk);
        }

        public ServicioAgenteComercial ServicioAgenteComercial
        {
            get { return _servicioAgenteComercial; }
            private set { _servicioAgenteComercial = value; }
        }

        public ServicioAlmacenComercial ServicioAlmacenComercial
        {
            get { return _servicioAlmacenComercial; }
            private set { _servicioAlmacenComercial = value; }
        }

        public ServicioClienteProveedorComercial ServicioClienteProveedorComercial
        {
            get { return _servicioClienteProveedorComercial; }
            private set { _servicioClienteProveedorComercial = value; }
        }

        public ServicioConceptoDocumentoComercial ServicioConceptoDocumentoComercial
        {
            get { return _servicioConceptoDocumentoComercial; }
            private set { _servicioConceptoDocumentoComercial = value; }
        }

        public ServicioDireccionComercial ServicioDireccionComercial
        {
            get { return _servicioDireccionComercial; }
            private set { _servicioDireccionComercial = value; }
        }

        public ServicioDocumentoComercial ServicioDocumentoComercial
        {
            get { return _servicioDocumentoComercial; }
            private set { _servicioDocumentoComercial = value; }
        }

        public ServicioEmpresaComercial ServicioEmpresaComercial
        {
            get { return _servicioEmpresaComercial; }
            private set { _servicioEmpresaComercial = value; }
        }

        public ServicioErrorComercial ServicioErrorComercial
        {
            get { return _servicioErrorComercial; }
            private set { _servicioErrorComercial = value; }
        }

        public ServicioMovimientoComercial ServicioMovimientoComercial
        {
            get { return _servicioMovimientoComercial; }
            private set { _servicioMovimientoComercial = value; }
        }

        public ServicioProductoComercial ServicioProductoComercial
        {
            get { return _servicioProductoComercial; }
            private set { _servicioProductoComercial = value; }
        }

        public ServicioUnidadComercial ServicioUnidadComercial
        {
            get { return _servicioUnidadComercial; }
            private set { _servicioUnidadComercial = value; }
        }

        public ServicioValorClasificacionComercial ServicioValorClasificacionComercial
        {
            get { return _servicioValorClasificacionComercial; }
            private set { _servicioValorClasificacionComercial = value; }
        }
    }
}
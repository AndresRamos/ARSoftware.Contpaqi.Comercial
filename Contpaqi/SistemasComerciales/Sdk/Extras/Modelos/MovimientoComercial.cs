namespace Contpaqi.SistemasComerciales.Sdk.Extras.Modelos
{
    public class MovimientoComercial
    {
        public MovimientoComercial()
        {
            Producto = new ProductoComercial();
            Almacen = new AlmacenComercial();
            ValorClasificacion = new ValorClasificacionComercial();
        }

        // Propiedades tMovimiento
        public int Consecutivo { get; set; }

        public double Unidades { get; set; }

        public double Precio { get; set; }

        public double Costo { get; set; }

        public string CodigoProducto { get; set; }

        public string CodigoAlmacen { get; set; }

        public string Referencia { get; set; }

        public string CodigoValorClasificacion { get; set; }

        // Propiedades Extras
        public int IdMovimiento { get; set; }

        public string TextoExtra1 { get; set; }

        public string Observaciones { get; set; }

        public int IdAlmacen { get; set; }

        public int IdProducto { get; set; }

        public int IdValorClasificacion { get; set; }

        public ProductoComercial Producto { get; set; }

        public AlmacenComercial Almacen { get; set; }

        public ValorClasificacionComercial ValorClasificacion { get; set; }
    }
}
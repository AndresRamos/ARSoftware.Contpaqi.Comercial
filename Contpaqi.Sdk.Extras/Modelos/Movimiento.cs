namespace Contpaqi.Sdk.Extras.Modelos
{
    public class Movimiento
    {
        public Movimiento()
        {
            Producto = new Producto();
            Almacen = new Almacen();
            ValorClasificacion = new ValorClasificacion();
            CodigoAlmacen = "1";
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
        public int Id { get; set; }

        public string TextoExtra1 { get; set; }

        public string Observaciones { get; set; }

        public int IdAlmacen { get; set; }

        public int IdProducto { get; set; }

        public int IdValorClasificacion { get; set; }

        public Producto Producto { get; set; }

        public Almacen Almacen { get; set; }

        public ValorClasificacion ValorClasificacion { get; set; }
    }
}
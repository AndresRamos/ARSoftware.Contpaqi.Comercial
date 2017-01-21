using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;
using System.Collections.Generic;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioProductoComercial
    {
        private readonly ISistemasComercialesSdk _sdk;
        private readonly ServicioErrorComercial _errorComercialServicio;

        public ServicioProductoComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _errorComercialServicio = new ServicioErrorComercial(sdk);
        }

        public List<ProductoComercial> TraerProductos()
        {
            List<ProductoComercial> productosList = new List<ProductoComercial>();
            _errorComercialServicio.ResultadoSdk = _sdk.fPosPrimerProducto();
            productosList.Add(LeerDatosProductoActual());
            while (_sdk.fPosSiguienteProducto() == 0)
            {
                productosList.Add(LeerDatosProductoActual());
                if (_sdk.fPosEOFProducto() == 1)
                {
                    break;
                }
            };
            return productosList;
        }

        public ProductoComercial BuscarProducto(int id)
        {
            return _sdk.fBuscaIdProducto(id) == 0 ? LeerDatosProductoActual() : null;
        }

        public ProductoComercial BuscarProducto(string codigo)
        {
            return _sdk.fBuscaProducto(codigo) == 0 ? LeerDatosProductoActual() : null;
        }

        private ProductoComercial LeerDatosProductoActual()
        {
            StringBuilder codigoProducto = new StringBuilder(Constantes.kLongCodigo);
            StringBuilder nombreProducto = new StringBuilder(Constantes.kLongNombre);
            StringBuilder descripcionProducto = new StringBuilder(Constantes.kLongNombreProducto);
            StringBuilder tipoProducto = new StringBuilder(7);
            StringBuilder fechaAltaProducto = new StringBuilder(9);
            StringBuilder fechaBaja = new StringBuilder(9);
            StringBuilder statusProducto = new StringBuilder(7);
            StringBuilder controlExistencia = new StringBuilder(7);
            StringBuilder metodoCosteo = new StringBuilder(7);
            StringBuilder codigoUnidadBase = new StringBuilder(12);
            StringBuilder codigoUnidadNoConvertible = new StringBuilder(12);
            StringBuilder precio1 = new StringBuilder(9);
            StringBuilder precio2 = new StringBuilder(9);
            StringBuilder precio3 = new StringBuilder(9);
            StringBuilder precio4 = new StringBuilder(9);
            StringBuilder precio5 = new StringBuilder(9);
            StringBuilder precio6 = new StringBuilder(9);
            StringBuilder precio7 = new StringBuilder(9);
            StringBuilder precio8 = new StringBuilder(9);
            StringBuilder precio9 = new StringBuilder(9);
            StringBuilder precio10 = new StringBuilder(9);
            StringBuilder impuesto1 = new StringBuilder(9);
            StringBuilder impuesto2 = new StringBuilder(9);
            StringBuilder impuesto3 = new StringBuilder(9);
            StringBuilder retencion1 = new StringBuilder(9);
            StringBuilder retencion2 = new StringBuilder(9);
            StringBuilder nombreCaracteristica1 = new StringBuilder(12);
            StringBuilder nombreCaracteristica2 = new StringBuilder(12);
            StringBuilder nombreCaracteristica3 = new StringBuilder(12);
            StringBuilder codigoValorClasificacion1 = new StringBuilder(12);
            StringBuilder codigoValorClasificacion2 = new StringBuilder(12);
            StringBuilder codigoValorClasificacion3 = new StringBuilder(12);
            StringBuilder codigoValorClasificacion4 = new StringBuilder(12);
            StringBuilder codigoValorClasificacion5 = new StringBuilder(12);
            StringBuilder codigoValorClasificacion6 = new StringBuilder(12);
            StringBuilder textoExtra1 = new StringBuilder(51);
            StringBuilder textoExtra2 = new StringBuilder(51);
            StringBuilder textoExtra3 = new StringBuilder(51);
            StringBuilder fechaExtra = new StringBuilder(9);
            StringBuilder importeExtra1 = new StringBuilder(9);
            StringBuilder importeExtra2 = new StringBuilder(9);
            StringBuilder importeExtra3 = new StringBuilder(9);
            StringBuilder importeExtra4 = new StringBuilder(9);
            StringBuilder id = new StringBuilder(12);
            StringBuilder segmentoContable1 = new StringBuilder(21);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CCODIGOPRODUCTO", codigoProducto, Constantes.kLongCodigo);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CNOMBREPRODUCTO", nombreProducto, Constantes.kLongNombre);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CDESCRIPCIONPRODUCTO", descripcionProducto, Constantes.kLongNombreProducto);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CTIPOPRODUCTO", tipoProducto, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CFECHAALTAPRODUCTO", fechaAltaProducto, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CFECHABAJA", fechaBaja, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CSTATUSPRODUCTO", statusProducto, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CCONTROLEXISTENCIA", controlExistencia, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CMETODOCOSTEO", metodoCosteo, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDUNIDADBASE", codigoUnidadBase, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDUNIDADNOCONVERTIBLE", codigoUnidadNoConvertible, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CPRECIO1", precio1, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CPRECIO2", precio2, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CPRECIO3", precio3, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CPRECIO4", precio4, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CPRECIO5", precio5, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CPRECIO6", precio6, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CPRECIO7", precio7, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CPRECIO8", precio8, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CPRECIO9", precio9, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CPRECIO10", precio10, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIMPUESTO1", impuesto1, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIMPUESTO2", impuesto2, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIMPUESTO3", impuesto3, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CRETENCION1", retencion1, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CRETENCION2", retencion2, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDPADRECARACTERISTICA1", nombreCaracteristica1, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDPADRECARACTERISTICA2", nombreCaracteristica2, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDPADRECARACTERISTICA3", nombreCaracteristica3, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION1", codigoValorClasificacion1, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION2", codigoValorClasificacion2, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION3", codigoValorClasificacion3, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION4", codigoValorClasificacion4, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION5", codigoValorClasificacion5, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION6", codigoValorClasificacion6, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CTEXTOEXTRA1", textoExtra1, 51);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CTEXTOEXTRA2", textoExtra2, 51);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CTEXTOEXTRA3", textoExtra3, 51);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CFECHAEXTRA", fechaExtra, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIMPORTEEXTRA1", importeExtra1, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIMPORTEEXTRA2", importeExtra2, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIMPORTEEXTRA3", importeExtra3, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIMPORTEEXTRA4", importeExtra4, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDPRODUCTO", id, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CSEGCONTPRODUCTO1", segmentoContable1, 12);
            ProductoComercial ProductoComercial = new ProductoComercial();
            ProductoComercial.CodigoProducto = codigoProducto.ToString();
            ProductoComercial.NombreProducto = nombreProducto.ToString();
            ProductoComercial.DescripcionProducto = descripcionProducto.ToString();
            ProductoComercial.TipoProducto = int.Parse(tipoProducto.ToString());
            ProductoComercial.FechaAltaProducto = fechaAltaProducto.ToString();
            ProductoComercial.FechaBaja = fechaBaja.ToString();
            ProductoComercial.StatusProducto = int.Parse(statusProducto.ToString());
            ProductoComercial.ControlExistencia = int.Parse(controlExistencia.ToString());
            ProductoComercial.MetodoCosteo = int.Parse(metodoCosteo.ToString());
            ProductoComercial.CodigoUnidadBase = codigoUnidadBase.ToString();
            ProductoComercial.CodigoUnidadNoConvertible = codigoUnidadNoConvertible.ToString();
            ProductoComercial.Precio1 = double.Parse(precio1.ToString());
            ProductoComercial.Precio2 = double.Parse(precio2.ToString());
            ProductoComercial.Precio3 = double.Parse(precio3.ToString());
            ProductoComercial.Precio4 = double.Parse(precio4.ToString());
            ProductoComercial.Precio5 = double.Parse(precio5.ToString());
            ProductoComercial.Precio6 = double.Parse(precio6.ToString());
            ProductoComercial.Precio7 = double.Parse(precio7.ToString());
            ProductoComercial.Precio8 = double.Parse(precio8.ToString());
            ProductoComercial.Precio9 = double.Parse(precio9.ToString());
            ProductoComercial.Precio10 = double.Parse(precio10.ToString());
            ProductoComercial.Impuesto1 = double.Parse(impuesto1.ToString());
            ProductoComercial.Impuesto2 = double.Parse(impuesto2.ToString());
            ProductoComercial.Impuesto3 = double.Parse(impuesto3.ToString());
            ProductoComercial.Retencion1 = double.Parse(retencion1.ToString());
            ProductoComercial.Retencion2 = double.Parse(retencion2.ToString());
            ProductoComercial.NombreCaracteristica1 = nombreCaracteristica1.ToString();
            ProductoComercial.NombreCaracteristica2 = nombreCaracteristica2.ToString();
            ProductoComercial.NombreCaracteristica3 = nombreCaracteristica3.ToString();
            ProductoComercial.CodigoValorClasificacion1 = codigoValorClasificacion1.ToString();
            ProductoComercial.CodigoValorClasificacion2 = codigoValorClasificacion2.ToString();
            ProductoComercial.CodigoValorClasificacion3 = codigoValorClasificacion3.ToString();
            ProductoComercial.CodigoValorClasificacion4 = codigoValorClasificacion4.ToString();
            ProductoComercial.CodigoValorClasificacion5 = codigoValorClasificacion5.ToString();
            ProductoComercial.CodigoValorClasificacion6 = codigoValorClasificacion6.ToString();
            ProductoComercial.TextoExtra1 = textoExtra1.ToString();
            ProductoComercial.TextoExtra2 = textoExtra2.ToString();
            ProductoComercial.TextoExtra3 = textoExtra3.ToString();
            ProductoComercial.FechaExtra = fechaExtra.ToString();
            ProductoComercial.ImporteExtra1 = double.Parse(importeExtra1.ToString());
            ProductoComercial.ImporteExtra2 = double.Parse(importeExtra2.ToString());
            ProductoComercial.ImporteExtra3 = double.Parse(importeExtra3.ToString());
            ProductoComercial.ImporteExtra4 = double.Parse(importeExtra4.ToString());
            ProductoComercial.IdProducto = int.Parse(id.ToString());
            ProductoComercial.SegmentoContable1 = segmentoContable1.ToString();
            return ProductoComercial;
        }
    }
}

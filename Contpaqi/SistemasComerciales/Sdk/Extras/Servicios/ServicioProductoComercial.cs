using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;
using System.Collections.Generic;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioProductoComercial
    {
        private readonly ServicioErrorComercial _errorComercialServicio;
        private readonly ServicioUnidadComercial _servicioUnidadComercial;
        private readonly ServicioValorClasificacionComercial _servicioValorClasificacionComercial;
        private readonly ISistemasComercialesSdk _sdk;

        public ServicioProductoComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _servicioUnidadComercial = new ServicioUnidadComercial(sdk);
            _servicioValorClasificacionComercial = new ServicioValorClasificacionComercial(sdk);
            _errorComercialServicio = new ServicioErrorComercial(sdk);
        }

        public ProductoComercial BuscarProducto(int id)
        {
            return _sdk.fBuscaIdProducto(id) == 0 ? LeerDatosProductoActual() : null;
        }

        public ProductoComercial BuscarProducto(string codigo)
        {
            return _sdk.fBuscaProducto(codigo) == 0 ? LeerDatosProductoActual() : null;
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
            StringBuilder idValorClasificacion1 = new StringBuilder(12);
            StringBuilder idValorClasificacion2 = new StringBuilder(12);
            StringBuilder idValorClasificacion3 = new StringBuilder(12);
            StringBuilder idValorClasificacion4 = new StringBuilder(12);
            StringBuilder idValorClasificacion5 = new StringBuilder(12);
            StringBuilder idValorClasificacion6 = new StringBuilder(12);
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
            StringBuilder idUnidadBase = new StringBuilder(12);
            StringBuilder idUnidadNoConvertible = new StringBuilder(12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CCODIGOPRODUCTO", codigoProducto, Constantes.kLongCodigo);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CNOMBREPRODUCTO", nombreProducto, Constantes.kLongNombre);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CDESCRIPCIONPRODUCTO", descripcionProducto, Constantes.kLongNombreProducto);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CTIPOPRODUCTO", tipoProducto, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CFECHAALTAPRODUCTO", fechaAltaProducto, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CFECHABAJA", fechaBaja, 9);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CSTATUSPRODUCTO", statusProducto, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CCONTROLEXISTENCIA", controlExistencia, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CMETODOCOSTEO", metodoCosteo, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDUNIDADBASE", idUnidadBase, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDUNIDADNOCONVERTIBLE", idUnidadNoConvertible, 12);
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
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION1", idValorClasificacion1, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION2", idValorClasificacion2, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION3", idValorClasificacion3, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION4", idValorClasificacion4, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION5", idValorClasificacion5, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION6", idValorClasificacion6, 12);
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
            ProductoComercial productoComercial = new ProductoComercial();
            productoComercial.CodigoProducto = codigoProducto.ToString();
            productoComercial.NombreProducto = nombreProducto.ToString();
            productoComercial.DescripcionProducto = descripcionProducto.ToString();
            productoComercial.TipoProducto = int.Parse(tipoProducto.ToString());
            productoComercial.FechaAltaProducto = fechaAltaProducto.ToString();
            productoComercial.FechaBaja = fechaBaja.ToString();
            productoComercial.StatusProducto = int.Parse(statusProducto.ToString());
            productoComercial.ControlExistencia = int.Parse(controlExistencia.ToString());
            productoComercial.MetodoCosteo = int.Parse(metodoCosteo.ToString());
            productoComercial.Precio1 = double.Parse(precio1.ToString());
            productoComercial.Precio2 = double.Parse(precio2.ToString());
            productoComercial.Precio3 = double.Parse(precio3.ToString());
            productoComercial.Precio4 = double.Parse(precio4.ToString());
            productoComercial.Precio5 = double.Parse(precio5.ToString());
            productoComercial.Precio6 = double.Parse(precio6.ToString());
            productoComercial.Precio7 = double.Parse(precio7.ToString());
            productoComercial.Precio8 = double.Parse(precio8.ToString());
            productoComercial.Precio9 = double.Parse(precio9.ToString());
            productoComercial.Precio10 = double.Parse(precio10.ToString());
            productoComercial.Impuesto1 = double.Parse(impuesto1.ToString());
            productoComercial.Impuesto2 = double.Parse(impuesto2.ToString());
            productoComercial.Impuesto3 = double.Parse(impuesto3.ToString());
            productoComercial.Retencion1 = double.Parse(retencion1.ToString());
            productoComercial.Retencion2 = double.Parse(retencion2.ToString());
            productoComercial.NombreCaracteristica1 = nombreCaracteristica1.ToString();
            productoComercial.NombreCaracteristica2 = nombreCaracteristica2.ToString();
            productoComercial.NombreCaracteristica3 = nombreCaracteristica3.ToString();
            productoComercial.TextoExtra1 = textoExtra1.ToString();
            productoComercial.TextoExtra2 = textoExtra2.ToString();
            productoComercial.TextoExtra3 = textoExtra3.ToString();
            productoComercial.FechaExtra = fechaExtra.ToString();
            productoComercial.ImporteExtra1 = double.Parse(importeExtra1.ToString());
            productoComercial.ImporteExtra2 = double.Parse(importeExtra2.ToString());
            productoComercial.ImporteExtra3 = double.Parse(importeExtra3.ToString());
            productoComercial.ImporteExtra4 = double.Parse(importeExtra4.ToString());
            productoComercial.IdProducto = int.Parse(id.ToString());
            productoComercial.SegmentoContable1 = segmentoContable1.ToString();
            // Unidades
            productoComercial.IdUnidadBase = int.Parse(idUnidadBase.ToString());
            productoComercial.IdUnidadNoConvertible = int.Parse(idUnidadNoConvertible.ToString());
            productoComercial.UnidadBase = _servicioUnidadComercial.BuscarUnidad(productoComercial.IdUnidadBase);
            productoComercial.UnidadNoConvertible = _servicioUnidadComercial.BuscarUnidad(productoComercial.IdUnidadNoConvertible);
            productoComercial.CodigoUnidadBase = productoComercial.UnidadBase.NombreUnidad;
            productoComercial.CodigoUnidadNoConvertible = productoComercial.UnidadNoConvertible.NombreUnidad;
            // Clasificaciones
            productoComercial.IdValorClasificacion1 = int.Parse(idValorClasificacion1.ToString());
            productoComercial.IdValorClasificacion2 = int.Parse(idValorClasificacion2.ToString());
            productoComercial.IdValorClasificacion3 = int.Parse(idValorClasificacion3.ToString());
            productoComercial.IdValorClasificacion4 = int.Parse(idValorClasificacion4.ToString());
            productoComercial.IdValorClasificacion5 = int.Parse(idValorClasificacion5.ToString());
            productoComercial.IdValorClasificacion6 = int.Parse(idValorClasificacion6.ToString());
            productoComercial.ValorClasificacion1 = _servicioValorClasificacionComercial.BuscaValorClasificacion(productoComercial.IdValorClasificacion1);
            productoComercial.ValorClasificacion2 = _servicioValorClasificacionComercial.BuscaValorClasificacion(productoComercial.IdValorClasificacion2);
            productoComercial.ValorClasificacion3 = _servicioValorClasificacionComercial.BuscaValorClasificacion(productoComercial.IdValorClasificacion3);
            productoComercial.ValorClasificacion4 = _servicioValorClasificacionComercial.BuscaValorClasificacion(productoComercial.IdValorClasificacion4);
            productoComercial.ValorClasificacion5 = _servicioValorClasificacionComercial.BuscaValorClasificacion(productoComercial.IdValorClasificacion5);
            productoComercial.ValorClasificacion6 = _servicioValorClasificacionComercial.BuscaValorClasificacion(productoComercial.IdValorClasificacion6);
            productoComercial.CodigoValorClasificacion1 = productoComercial.ValorClasificacion1.CodigoValorClasificacion;
            productoComercial.CodigoValorClasificacion2 = productoComercial.ValorClasificacion2.CodigoValorClasificacion;
            productoComercial.CodigoValorClasificacion3 = productoComercial.ValorClasificacion3.CodigoValorClasificacion;
            productoComercial.CodigoValorClasificacion4 = productoComercial.ValorClasificacion4.CodigoValorClasificacion;
            productoComercial.CodigoValorClasificacion5 = productoComercial.ValorClasificacion5.CodigoValorClasificacion;
            productoComercial.CodigoValorClasificacion6 = productoComercial.ValorClasificacion6.CodigoValorClasificacion;
            return productoComercial;
        }
    }
}
using System.Collections.Generic;
using System.Text;
using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioProductoComercial
    {
        private readonly ServicioErrorComercial _errorComercialServicio;
        private readonly ISistemasComercialesSdk _sdk;
        private readonly ServicioUnidadComercial _servicioUnidadComercial;
        private readonly ServicioValorClasificacionComercial _servicioValorClasificacionComercial;

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
            var productosList = new List<ProductoComercial>();
            _errorComercialServicio.ResultadoSdk = _sdk.fPosPrimerProducto();
            productosList.Add(LeerDatosProductoActual());
            while (_sdk.fPosSiguienteProducto() == 0)
            {
                productosList.Add(LeerDatosProductoActual());
                if (_sdk.fPosEOFProducto() == 1)
                {
                    break;
                }
            }
            return productosList;
        }

        private ProductoComercial LeerDatosProductoActual()
        {
            var codigoProducto = new StringBuilder(Constantes.kLongCodigo);
            var nombreProducto = new StringBuilder(Constantes.kLongNombre);
            var descripcionProducto = new StringBuilder(Constantes.kLongNombreProducto);
            var tipoProducto = new StringBuilder(7);
            var fechaAltaProducto = new StringBuilder(Constantes.kLongFecha);
            var fechaBaja = new StringBuilder(9);
            var statusProducto = new StringBuilder(7);
            var controlExistencia = new StringBuilder(7);
            var metodoCosteo = new StringBuilder(7);
            var precio1 = new StringBuilder(9);
            var precio2 = new StringBuilder(9);
            var precio3 = new StringBuilder(9);
            var precio4 = new StringBuilder(9);
            var precio5 = new StringBuilder(9);
            var precio6 = new StringBuilder(9);
            var precio7 = new StringBuilder(9);
            var precio8 = new StringBuilder(9);
            var precio9 = new StringBuilder(9);
            var precio10 = new StringBuilder(9);
            var impuesto1 = new StringBuilder(9);
            var impuesto2 = new StringBuilder(9);
            var impuesto3 = new StringBuilder(9);
            var retencion1 = new StringBuilder(9);
            var retencion2 = new StringBuilder(9);
            var nombreCaracteristica1 = new StringBuilder(12);
            var nombreCaracteristica2 = new StringBuilder(12);
            var nombreCaracteristica3 = new StringBuilder(12);
            var idValorClasificacion1 = new StringBuilder(12);
            var idValorClasificacion2 = new StringBuilder(12);
            var idValorClasificacion3 = new StringBuilder(12);
            var idValorClasificacion4 = new StringBuilder(12);
            var idValorClasificacion5 = new StringBuilder(12);
            var idValorClasificacion6 = new StringBuilder(12);
            var textoExtra1 = new StringBuilder(51);
            var textoExtra2 = new StringBuilder(51);
            var textoExtra3 = new StringBuilder(51);
            var fechaExtra = new StringBuilder(9);
            var importeExtra1 = new StringBuilder(9);
            var importeExtra2 = new StringBuilder(9);
            var importeExtra3 = new StringBuilder(9);
            var importeExtra4 = new StringBuilder(9);
            var id = new StringBuilder(12);
            var segmentoContable1 = new StringBuilder(21);
            var claveSat = new StringBuilder(9);
            var idUnidadBase = new StringBuilder(12);
            var idUnidadNoConvertible = new StringBuilder(12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CCODIGOPRODUCTO", codigoProducto, Constantes.kLongCodigo);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CNOMBREPRODUCTO", nombreProducto, Constantes.kLongNombre);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CDESCRIPCIONPRODUCTO", descripcionProducto, Constantes.kLongNombreProducto);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CTIPOPRODUCTO", tipoProducto, 7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CFECHAALTAPRODUCTO", fechaAltaProducto, Constantes.kLongFecha);
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
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoProducto("CCLAVESAT", claveSat, 9);
            var productoComercial = new ProductoComercial();
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
            productoComercial.ClaveSat = claveSat.ToString();
            // Unidades
            productoComercial.IdUnidadBase = int.Parse(idUnidadBase.ToString());
            productoComercial.IdUnidadNoConvertible = int.Parse(idUnidadNoConvertible.ToString());
            productoComercial.UnidadBase = _servicioUnidadComercial.BuscarUnidad(productoComercial.IdUnidadBase);
            productoComercial.UnidadNoConvertible = _servicioUnidadComercial.BuscarUnidad(productoComercial.IdUnidadNoConvertible);
            productoComercial.CodigoUnidadBase = productoComercial.UnidadBase.NombreUnidad;
            productoComercial.CodigoUnidadNoConvertible = productoComercial.UnidadNoConvertible.NombreUnidad;
            // Clasificaciones
            productoComercial.IdValorClasificacion1 = int.TryParse(idValorClasificacion1.ToString(), out var _idValorClasificacion1) ? _idValorClasificacion1 : 0;
            productoComercial.IdValorClasificacion2 = int.TryParse(idValorClasificacion2.ToString(), out var _idValorClasificacion2) ? _idValorClasificacion2 : 0;
            productoComercial.IdValorClasificacion3 = int.TryParse(idValorClasificacion3.ToString(), out var _idValorClasificacion3) ? _idValorClasificacion3 : 0;
            productoComercial.IdValorClasificacion4 = int.TryParse(idValorClasificacion4.ToString(), out var _idValorClasificacion4) ? _idValorClasificacion4 : 0;
            productoComercial.IdValorClasificacion5 = int.TryParse(idValorClasificacion5.ToString(), out var _idValorClasificacion5) ? _idValorClasificacion5 : 0;
            productoComercial.IdValorClasificacion6 = int.TryParse(idValorClasificacion6.ToString(), out var _idValorClasificacion6) ? _idValorClasificacion6 : 0;
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
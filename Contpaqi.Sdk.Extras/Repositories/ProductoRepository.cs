using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class ProductoRepository : IProductoRepository<Producto>
    {
        private readonly IContpaqiSdk _sdk;
        private readonly IUnidadMedidaRepository<UnidadMedida> _unidadMedidaRepository;
        private readonly IValorClasificacionRepository<ValorClasificacion> _valorClasificacionRepository;

        public ProductoRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _unidadMedidaRepository = new UnidadMedidaRepository(sdk);
            _valorClasificacionRepository = new ValorClasificacionRepository(sdk);
        }

        public Producto BuscarPorId(int idProducto)
        {
            return _sdk.fBuscaIdProducto(idProducto) == SdkResultConstants.Success ? LeerDatosProductoActual() : null;
        }

        public Producto BuscarPorCodigo(string codigoProducto)
        {
            return _sdk.fBuscaProducto(codigoProducto) == SdkResultConstants.Success ? LeerDatosProductoActual() : null;
        }

        public IEnumerable<Producto> TraerTodo()
        {
            _sdk.fPosPrimerProducto().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosProductoActual();
            while (_sdk.fPosSiguienteProducto() == SdkResultConstants.Success)
            {
                yield return LeerDatosProductoActual();
                if (_sdk.fPosEOFProducto() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<Producto> TraerPorTipo(TipoProductoEnum tipoProducto)
        {
            _sdk.fPosPrimerProducto().ToResultadoSdk(_sdk).ThrowIfError();

            var tipoProductoDato = new StringBuilder(7);
            _sdk.fLeeDatoProducto("CTIPOPRODUCTO", tipoProductoDato, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (tipoProducto == TipoProductoHelper.ConvertoToTipoProductoEnum(tipoProductoDato.ToString()))
            {
                yield return LeerDatosProductoActual();
            }

            while (_sdk.fPosSiguienteProducto() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoProducto("CTIPOPRODUCTO", tipoProductoDato, 7).ToResultadoSdk(_sdk).ThrowIfError();

                if (tipoProducto == TipoProductoHelper.ConvertoToTipoProductoEnum(tipoProductoDato.ToString()))
                {
                    yield return LeerDatosProductoActual();
                }

                if (_sdk.fPosEOFProducto() == 1)
                {
                    break;
                }
            }
        }

        private Producto LeerDatosProductoActual()
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
            _sdk.fLeeDatoProducto("CCODIGOPRODUCTO", codigoProducto, Constantes.kLongCodigo).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CNOMBREPRODUCTO", nombreProducto, Constantes.kLongNombre).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CDESCRIPCIONPRODUCTO", descripcionProducto, Constantes.kLongNombreProducto).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CTIPOPRODUCTO", tipoProducto, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CFECHAALTAPRODUCTO", fechaAltaProducto, Constantes.kLongFecha).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CFECHABAJA", fechaBaja, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CSTATUSPRODUCTO", statusProducto, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CCONTROLEXISTENCIA", controlExistencia, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CMETODOCOSTEO", metodoCosteo, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIDUNIDADBASE", idUnidadBase, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIDUNIDADNOCONVERTIBLE", idUnidadNoConvertible, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CPRECIO1", precio1, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CPRECIO2", precio2, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CPRECIO3", precio3, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CPRECIO4", precio4, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CPRECIO5", precio5, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CPRECIO6", precio6, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CPRECIO7", precio7, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CPRECIO8", precio8, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CPRECIO9", precio9, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CPRECIO10", precio10, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIMPUESTO1", impuesto1, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIMPUESTO2", impuesto2, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIMPUESTO3", impuesto3, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CRETENCION1", retencion1, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CRETENCION2", retencion2, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIDPADRECARACTERISTICA1", nombreCaracteristica1, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIDPADRECARACTERISTICA2", nombreCaracteristica2, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIDPADRECARACTERISTICA3", nombreCaracteristica3, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION1", idValorClasificacion1, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION2", idValorClasificacion2, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION3", idValorClasificacion3, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION4", idValorClasificacion4, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION5", idValorClasificacion5, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIDVALORCLASIFICACION6", idValorClasificacion6, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CTEXTOEXTRA1", textoExtra1, 51).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CTEXTOEXTRA2", textoExtra2, 51).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CTEXTOEXTRA3", textoExtra3, 51).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CFECHAEXTRA", fechaExtra, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIMPORTEEXTRA1", importeExtra1, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIMPORTEEXTRA2", importeExtra2, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIMPORTEEXTRA3", importeExtra3, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIMPORTEEXTRA4", importeExtra4, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CIDPRODUCTO", id, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CSEGCONTPRODUCTO1", segmentoContable1, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoProducto("CCLAVESAT", claveSat, 9).ToResultadoSdk(_sdk).ThrowIfError();
            var productoComercial = new Producto();
            productoComercial.Codigo = codigoProducto.ToString();
            productoComercial.Nombre = nombreProducto.ToString();
            productoComercial.Descripcion = descripcionProducto.ToString();
            productoComercial.Tipo = int.Parse(tipoProducto.ToString());
            productoComercial.FechaAlta = fechaAltaProducto.ToString();
            productoComercial.FechaBaja = fechaBaja.ToString();
            productoComercial.Status = int.Parse(statusProducto.ToString());
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
            productoComercial.Id = int.Parse(id.ToString());
            productoComercial.SegmentoContable1 = segmentoContable1.ToString();
            productoComercial.ClaveSat = claveSat.ToString();
            // Unidades
            productoComercial.IdUnidadBase = int.Parse(idUnidadBase.ToString());
            productoComercial.IdUnidadNoConvertible = int.Parse(idUnidadNoConvertible.ToString());
            productoComercial.UnidadBase = _unidadMedidaRepository.BuscarPorId(productoComercial.IdUnidadBase);
            productoComercial.UnidadNoConvertible = _unidadMedidaRepository.BuscarPorId(productoComercial.IdUnidadNoConvertible);
            productoComercial.CodigoUnidadBase = productoComercial.UnidadBase.Nombre;
            productoComercial.CodigoUnidadNoConvertible = productoComercial.UnidadNoConvertible.Nombre;
            // Clasificaciones
            productoComercial.IdValorClasificacion1 = int.TryParse(idValorClasificacion1.ToString(), out var idValorClasificacion1Result) ? idValorClasificacion1Result : 0;
            productoComercial.IdValorClasificacion2 = int.TryParse(idValorClasificacion2.ToString(), out var idValorClasificacion2Result) ? idValorClasificacion2Result : 0;
            productoComercial.IdValorClasificacion3 = int.TryParse(idValorClasificacion3.ToString(), out var idValorClasificacion3Result) ? idValorClasificacion3Result : 0;
            productoComercial.IdValorClasificacion4 = int.TryParse(idValorClasificacion4.ToString(), out var idValorClasificacion4Result) ? idValorClasificacion4Result : 0;
            productoComercial.IdValorClasificacion5 = int.TryParse(idValorClasificacion5.ToString(), out var idValorClasificacion5Result) ? idValorClasificacion5Result : 0;
            productoComercial.IdValorClasificacion6 = int.TryParse(idValorClasificacion6.ToString(), out var idValorClasificacion6Result) ? idValorClasificacion6Result : 0;
            productoComercial.ValorClasificacion1 = _valorClasificacionRepository.BuscarPorId(productoComercial.IdValorClasificacion1);
            productoComercial.ValorClasificacion2 = _valorClasificacionRepository.BuscarPorId(productoComercial.IdValorClasificacion2);
            productoComercial.ValorClasificacion3 = _valorClasificacionRepository.BuscarPorId(productoComercial.IdValorClasificacion3);
            productoComercial.ValorClasificacion4 = _valorClasificacionRepository.BuscarPorId(productoComercial.IdValorClasificacion4);
            productoComercial.ValorClasificacion5 = _valorClasificacionRepository.BuscarPorId(productoComercial.IdValorClasificacion5);
            productoComercial.ValorClasificacion6 = _valorClasificacionRepository.BuscarPorId(productoComercial.IdValorClasificacion6);
            productoComercial.CodigoValorClasificacion1 = productoComercial.ValorClasificacion1.Codigo;
            productoComercial.CodigoValorClasificacion2 = productoComercial.ValorClasificacion2.Codigo;
            productoComercial.CodigoValorClasificacion3 = productoComercial.ValorClasificacion3.Codigo;
            productoComercial.CodigoValorClasificacion4 = productoComercial.ValorClasificacion4.Codigo;
            productoComercial.CodigoValorClasificacion5 = productoComercial.ValorClasificacion5.Codigo;
            productoComercial.CodigoValorClasificacion6 = productoComercial.ValorClasificacion6.Codigo;
            return productoComercial;
        }
    }
}
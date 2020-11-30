using System;
using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class MovimientoRepository : IMovimientoRepository<Movimiento>
    {
        private readonly IAlmacenRepository<Almacen> _almacenRepository;
        private readonly IProductoRepository<Producto> _productoRepository;
        private readonly IContpaqiSdk _sdk;
        private readonly IValorClasificacionRepository<ValorClasificacion> _valorClasificacionRepository;

        public MovimientoRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _productoRepository = new ProductoRepository(sdk);
            _almacenRepository = new AlmacenRepository(sdk);
            _valorClasificacionRepository = new ValorClasificacionRepository(sdk);
        }

        public Movimiento BuscarPorId(int idMovimiento)
        {
            return _sdk.fBuscarIdMovimiento(idMovimiento) == SdkResultConstants.Success ? LeerDatosMovimientoActual() : null;
        }

        public IEnumerable<Movimiento> TraerTodo()
        {
            _sdk.fPosPrimerMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosMovimientoActual();
            while (_sdk.fPosSiguienteMovimiento() == SdkResultConstants.Success)
            {
                yield return LeerDatosMovimientoActual();
                if (_sdk.fPosMovimientoEOF() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<Movimiento> TraerPorDocumentoId(int idDocumento)
        {
            _sdk.fCancelaFiltroMovimiento().ToResultadoSdk(_sdk).ThrowIfError();

            var resultadoSdk = _sdk.fSetFiltroMovimiento(idDocumento).ToResultadoSdk(_sdk);

            if (!resultadoSdk.IsSuccess)
            {
                _sdk.fCancelaFiltroMovimiento().ToResultadoSdk(_sdk).ThrowIfError();

                if (resultadoSdk.Result == 2) // Si el resultado es "2" significa que no hay movimientos en el filtro pero no creo que se considere un error para tirar una excepcion
                {
                    yield break;
                }

                resultadoSdk.ThrowIfError();
            }

            _sdk.fPosPrimerMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosMovimientoActual();

            while (_sdk.fPosSiguienteMovimiento() == SdkResultConstants.Success)
            {
                yield return LeerDatosMovimientoActual();
                if (_sdk.fPosMovimientoEOF() == 1)
                {
                    break;
                }
            }

            _sdk.fCancelaFiltroMovimiento().ToResultadoSdk(_sdk).ThrowIfError();
        }

        private Movimiento LeerDatosMovimientoActual()
        {
            var consecutivo = new StringBuilder(9);
            var unidades = new StringBuilder(9);
            var precio = new StringBuilder(9);
            var costo = new StringBuilder(9);
            var referencia = new StringBuilder(Constantes.kLongReferencia);
            var idValorClasificacion = new StringBuilder(Constantes.kLongCodigo);
            var id = new StringBuilder(12);
            var neto = new StringBuilder(9);
            var porcentajeImpuesto1 = new StringBuilder(9);
            var impuesto1 = new StringBuilder(9);
            var total = new StringBuilder(9);
            var textoExtra1 = new StringBuilder(Constantes.kLongTextoExtra);
            var textoExtra2 = new StringBuilder(Constantes.kLongTextoExtra);
            var textoExtra3 = new StringBuilder(Constantes.kLongTextoExtra);
            var productoId = new StringBuilder(Constantes.kLongCodigo);
            var almacenId = new StringBuilder(Constantes.kLongCodigo);
            var observaciones = new StringBuilder(250);
            var importeDescuento1 = new StringBuilder(9);
            var importeDescuento2 = new StringBuilder(9);
            var importeDescuento3 = new StringBuilder(9);
            var importeDescuento4 = new StringBuilder(9);
            var importeDescuento5 = new StringBuilder(9);
            var porcentajeDescuento1 = new StringBuilder(9);
            var porcentajeDescuento2 = new StringBuilder(9);
            var porcentajeDescuento3 = new StringBuilder(9);
            var porcentajeDescuento4 = new StringBuilder(9);
            var porcentajeDescuento5 = new StringBuilder(9);
            _sdk.fLeeDatoMovimiento("CNUMEROMOVIMIENTO", consecutivo, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CUNIDADES", unidades, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CPRECIO", precio, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CCOSTOCAPTURADO", costo, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CREFERENCIA", referencia, Constantes.kLongReferencia).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CIDVALORCLASIFICACION", idValorClasificacion, Constantes.kLongCodigo).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CIDMOVIMIENTO", id, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CNETO", neto, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CPORCENTAJEIMPUESTO1", porcentajeImpuesto1, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CIMPUESTO1", impuesto1, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CTOTAL", total, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CTEXTOEXTRA1", textoExtra1, Constantes.kLongTextoExtra).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CTEXTOEXTRA2", textoExtra2, Constantes.kLongTextoExtra).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CTEXTOEXTRA3", textoExtra3, Constantes.kLongTextoExtra).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CIDPRODUCTO", productoId, Constantes.kLongCodigo).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CIDALMACEN", almacenId, Constantes.kLongCodigo).ToResultadoSdk(_sdk).ThrowIfError(); // Lee el id del almacen
            _sdk.fLeeDatoMovimiento("COBSERVAMOV", observaciones, 250).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CDESCUENTO1", importeDescuento1, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CDESCUENTO2", importeDescuento2, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CDESCUENTO3", importeDescuento3, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CDESCUENTO4", importeDescuento4, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CDESCUENTO4", importeDescuento5, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CPORCENTAJEDESCUENTO1", porcentajeDescuento1, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CPORCENTAJEDESCUENTO2", porcentajeDescuento2, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CPORCENTAJEDESCUENTO3", porcentajeDescuento3, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CPORCENTAJEDESCUENTO4", porcentajeDescuento4, 9).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoMovimiento("CPORCENTAJEDESCUENTO5", porcentajeDescuento5, 9).ToResultadoSdk(_sdk).ThrowIfError();

            var movimiento = new Movimiento();
            movimiento.Consecutivo = double.TryParse(consecutivo.ToString(), out var consecutivoReslt) ? Convert.ToInt32(consecutivoReslt) : 0; // Int.Parse falla por que regresa 1.00
            movimiento.Unidades = double.Parse(unidades.ToString());
            movimiento.Precio = double.Parse(precio.ToString());
            movimiento.Costo = double.Parse(costo.ToString());
            movimiento.Referencia = referencia.ToString();
            movimiento.IdValorClasificacion = int.TryParse(idValorClasificacion.ToString(), out var idValorClasificacionResult) ? idValorClasificacionResult : 0;
            movimiento.Id = int.Parse(id.ToString());
            movimiento.Neto = double.Parse(neto.ToString());
            movimiento.PorcentajeImpuesto1 = double.Parse(porcentajeImpuesto1.ToString());
            movimiento.Impuesto1 = double.Parse(impuesto1.ToString());
            movimiento.Total = double.Parse(total.ToString());
            movimiento.TextoExtra1 = textoExtra1.ToString();
            movimiento.TextoExtra2 = textoExtra2.ToString();
            movimiento.TextoExtra3 = textoExtra3.ToString();
            movimiento.Observaciones = observaciones.ToString();
            movimiento.IdAlmacen = int.Parse(almacenId.ToString());
            movimiento.IdProducto = int.Parse(productoId.ToString());
            movimiento.Producto = _productoRepository.BuscarPorId(movimiento.IdProducto);
            movimiento.CodigoProducto = movimiento.Producto.Codigo;
            movimiento.Almacen = _almacenRepository.BuscarPorId(movimiento.IdAlmacen);
            movimiento.CodigoAlmacen = movimiento.Almacen.Codigo;
            movimiento.ValorClasificacion = _valorClasificacionRepository.BuscarPorId(movimiento.IdValorClasificacion);
            movimiento.CodigoValorClasificacion = movimiento.ValorClasificacion.Codigo;
            movimiento.ImporteDescuento1 = double.Parse(importeDescuento1.ToString());
            movimiento.ImporteDescuento2 = double.Parse(importeDescuento2.ToString());
            movimiento.ImporteDescuento3 = double.Parse(importeDescuento3.ToString());
            movimiento.ImporteDescuento4 = double.Parse(importeDescuento4.ToString());
            movimiento.ImporteDescuento5 = double.Parse(importeDescuento5.ToString());
            movimiento.PorcentajeDescuento1 = double.Parse(porcentajeDescuento1.ToString());
            movimiento.PorcentajeDescuento2 = double.Parse(porcentajeDescuento2.ToString());
            movimiento.PorcentajeDescuento3 = double.Parse(porcentajeDescuento3.ToString());
            movimiento.PorcentajeDescuento4 = double.Parse(porcentajeDescuento4.ToString());
            movimiento.PorcentajeDescuento5 = double.Parse(porcentajeDescuento5.ToString());
            return movimiento;
        }
    }
}
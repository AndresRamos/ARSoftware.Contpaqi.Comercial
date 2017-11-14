using System;
using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;

namespace Contpaqi.Sdk.Extras.Repositorios
{
    public class MovimientoRepositorio
    {
        private readonly AlmacenRepositorio _almacenRepositorio;
        private readonly ErrorContpaqiSdkRepositorio _errorContpaqiSdkRepositorio;
        private readonly ProductoRepositorio _productoRepositorio;
        private readonly IContpaqiSdk _sdk;
        private readonly ValorClasificacionRepositorio _valorClasificacionRepositorio;

        public MovimientoRepositorio(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _productoRepositorio = new ProductoRepositorio(sdk);
            _errorContpaqiSdkRepositorio = new ErrorContpaqiSdkRepositorio(sdk);
            _almacenRepositorio = new AlmacenRepositorio(sdk);
            _valorClasificacionRepositorio = new ValorClasificacionRepositorio(sdk);
        }

        public tMovimiento ExtraerTMovimiento(Movimiento movimiento)
        {
            var nuevoTMovimiento = new tMovimiento();
            nuevoTMovimiento.aConsecutivo = movimiento.Consecutivo;
            nuevoTMovimiento.aUnidades = movimiento.Unidades;
            nuevoTMovimiento.aPrecio = movimiento.Precio;
            nuevoTMovimiento.aCosto = movimiento.Costo;
            nuevoTMovimiento.aCodProdSer = movimiento.CodigoProducto;
            nuevoTMovimiento.aCodAlmacen = movimiento.CodigoAlmacen;
            nuevoTMovimiento.aReferencia = movimiento.Referencia;
            nuevoTMovimiento.aCodClasificacion = movimiento.CodigoValorClasificacion;
            return nuevoTMovimiento;
        }

        public List<Movimiento> TraerMovimientos()
        {
            var movimientosList = new List<Movimiento>();
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fPosPrimerMovimiento();
            movimientosList.Add(LeerDatosMovimientoActual());
            while (_sdk.fPosSiguienteMovimiento() == 0)
            {
                movimientosList.Add(LeerDatosMovimientoActual());
                if (_sdk.fPosMovimientoEOF() == 1)
                {
                    break;
                }
            }
            return movimientosList;
        }

        public List<Movimiento> TraerMovimientos(int idDocumento)
        {
            var movimientosList = new List<Movimiento>();
            if (_sdk.fSetFiltroMovimiento(idDocumento) == 0)
            {
                _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fPosPrimerMovimiento();
                movimientosList.Add(LeerDatosMovimientoActual());
                while (_sdk.fPosSiguienteMovimiento() == 0)
                {
                    movimientosList.Add(LeerDatosMovimientoActual());
                    if (_sdk.fPosMovimientoEOF() == 1)
                    {
                        break;
                    }
                }
            }
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fCancelaFiltroMovimiento();
            return movimientosList;
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
            var textoExtra1 = new StringBuilder(Constantes.kLongTextoExtra);
            var productoId = new StringBuilder(Constantes.kLongCodigo);
            var almacenId = new StringBuilder(Constantes.kLongCodigo);
            var observaciones = new StringBuilder(250);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CNUMEROMOVIMIENTO", consecutivo, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CUNIDADES", unidades, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CPRECIO", precio, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CCOSTOCAPTURADO", costo, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CREFERENCIA", referencia, Constantes.kLongReferencia);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CIDVALORCLASIFICACION", idValorClasificacion, Constantes.kLongCodigo);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CIDMOVIMIENTO", id, 12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CTEXTOEXTRA1", textoExtra1, Constantes.kLongTextoExtra);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CIDPRODUCTO", productoId, Constantes.kLongCodigo);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CIDALMACEN", almacenId, Constantes.kLongCodigo); // Lee el id del almacen
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("COBSERVAMOV", observaciones, 250);
            var movimiento = new Movimiento();
            movimiento.Consecutivo = double.TryParse(consecutivo.ToString(), out var _consecutivo) ? Convert.ToInt32(_consecutivo) : 0; // Int.Parse falla por que regresa 1.00
            movimiento.Unidades = double.Parse(unidades.ToString());
            movimiento.Precio = double.Parse(precio.ToString());
            movimiento.Costo = double.Parse(costo.ToString());
            movimiento.Referencia = referencia.ToString();
            movimiento.IdValorClasificacion = int.TryParse(idValorClasificacion.ToString(), out var _idValorClasificacion) ? _idValorClasificacion : 0;
            movimiento.Id = int.Parse(id.ToString());
            movimiento.TextoExtra1 = textoExtra1.ToString();
            movimiento.Observaciones = observaciones.ToString();
            movimiento.IdAlmacen = int.Parse(almacenId.ToString());
            movimiento.IdProducto = int.Parse(productoId.ToString());
            movimiento.Producto = _productoRepositorio.BuscarProducto(movimiento.IdProducto);
            movimiento.CodigoProducto = movimiento.Producto.Codigo;
            movimiento.Almacen = _almacenRepositorio.BuscarAlmacen(movimiento.IdAlmacen);
            movimiento.CodigoAlmacen = movimiento.Almacen.Codigo;
            movimiento.ValorClasificacion = _valorClasificacionRepositorio.BuscaValorClasificacion(movimiento.IdValorClasificacion);
            movimiento.CodigoValorClasificacion = movimiento.ValorClasificacion.Codigo;
            return movimiento;
        }
    }
}
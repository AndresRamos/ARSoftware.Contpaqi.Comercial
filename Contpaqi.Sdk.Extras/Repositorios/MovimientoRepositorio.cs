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

        public tMovimientoDesc ExtraerTMovimientoDesc(Movimiento movimiento)
        {
            var nuevoTMovimientoDesc = new tMovimientoDesc();
            nuevoTMovimientoDesc.aConsecutivo = movimiento.Consecutivo;
            nuevoTMovimientoDesc.aUnidades = movimiento.Unidades;
            nuevoTMovimientoDesc.aPrecio = movimiento.Precio;
            nuevoTMovimientoDesc.aCosto = movimiento.Costo;
            nuevoTMovimientoDesc.aCodProdSer = movimiento.CodigoProducto;
            nuevoTMovimientoDesc.aCodAlmacen = movimiento.CodigoAlmacen;
            nuevoTMovimientoDesc.aReferencia = movimiento.Referencia;
            nuevoTMovimientoDesc.aCodClasificacion = movimiento.CodigoValorClasificacion;
            nuevoTMovimientoDesc.aImporteDescto1 = movimiento.ImporteDescuento1;
            nuevoTMovimientoDesc.aImporteDescto2 = movimiento.ImporteDescuento2;
            nuevoTMovimientoDesc.aImporteDescto3 = movimiento.ImporteDescuento3;
            nuevoTMovimientoDesc.aImporteDescto4 = movimiento.ImporteDescuento4;
            nuevoTMovimientoDesc.aImporteDescto5 = movimiento.ImporteDescuento5;
            nuevoTMovimientoDesc.aPorcDescto1 = movimiento.PorcentajeDescuento1;
            nuevoTMovimientoDesc.aPorcDescto2 = movimiento.PorcentajeDescuento2;
            nuevoTMovimientoDesc.aPorcDescto3 = movimiento.PorcentajeDescuento3;
            nuevoTMovimientoDesc.aPorcDescto4 = movimiento.PorcentajeDescuento4;
            nuevoTMovimientoDesc.aPorcDescto5 = movimiento.PorcentajeDescuento5;
            return nuevoTMovimientoDesc;
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
            var neto = new StringBuilder(9);
            var porcentajeImpuesto1 = new StringBuilder(9);
            var impuesto1 = new StringBuilder(9);
            var total = new StringBuilder(9);
            var textoExtra1 = new StringBuilder(Constantes.kLongTextoExtra);
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
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CNUMEROMOVIMIENTO", consecutivo, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CUNIDADES", unidades, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CPRECIO", precio, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CCOSTOCAPTURADO", costo, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CREFERENCIA", referencia, Constantes.kLongReferencia);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CIDVALORCLASIFICACION", idValorClasificacion, Constantes.kLongCodigo);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CIDMOVIMIENTO", id, 12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CNETO", neto, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CPORCENTAJEIMPUESTO1", porcentajeImpuesto1, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CIMPUESTO1", impuesto1, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CTOTAL", total, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CTEXTOEXTRA1", textoExtra1, Constantes.kLongTextoExtra);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CIDPRODUCTO", productoId, Constantes.kLongCodigo);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CIDALMACEN", almacenId, Constantes.kLongCodigo); // Lee el id del almacen
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("COBSERVAMOV", observaciones, 250);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CDESCUENTO1", importeDescuento1, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CDESCUENTO2", importeDescuento2, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CDESCUENTO3", importeDescuento3, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CDESCUENTO4", importeDescuento4, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CDESCUENTO4", importeDescuento5, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CPORCENTAJEDESCUENTO1", porcentajeDescuento1, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CPORCENTAJEDESCUENTO2", porcentajeDescuento2, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CPORCENTAJEDESCUENTO3", porcentajeDescuento3, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CPORCENTAJEDESCUENTO4", porcentajeDescuento4, 9);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoMovimiento("CPORCENTAJEDESCUENTO5", porcentajeDescuento5, 9);

            var movimiento = new Movimiento();
            movimiento.Consecutivo = double.TryParse(consecutivo.ToString(), out var _consecutivo) ? Convert.ToInt32(_consecutivo) : 0; // Int.Parse falla por que regresa 1.00
            movimiento.Unidades = double.Parse(unidades.ToString());
            movimiento.Precio = double.Parse(precio.ToString());
            movimiento.Costo = double.Parse(costo.ToString());
            movimiento.Referencia = referencia.ToString();
            movimiento.IdValorClasificacion = int.TryParse(idValorClasificacion.ToString(), out var _idValorClasificacion) ? _idValorClasificacion : 0;
            movimiento.Id = int.Parse(id.ToString());
            movimiento.Neto = double.Parse(neto.ToString());
            movimiento.PorcentajeImpuesto1= double.Parse(porcentajeImpuesto1.ToString());
            movimiento.Impuesto1 = double.Parse(impuesto1.ToString());
            movimiento.Total = double.Parse(total.ToString());
            movimiento.TextoExtra1 = textoExtra1.ToString();
            movimiento.Observaciones = observaciones.ToString();
            movimiento.IdAlmacen = int.Parse(almacenId.ToString());
            movimiento.IdProducto = int.Parse(productoId.ToString());
            movimiento.Producto = _productoRepositorio.BuscarPorId(movimiento.IdProducto);
            movimiento.CodigoProducto = movimiento.Producto.Codigo;
            movimiento.Almacen = _almacenRepositorio.BuscarAlmacen(movimiento.IdAlmacen);
            movimiento.CodigoAlmacen = movimiento.Almacen.Codigo;
            movimiento.ValorClasificacion = _valorClasificacionRepositorio.BuscaValorClasificacion(movimiento.IdValorClasificacion);
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
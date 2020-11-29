using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class MovimientoHelper
    {
        public static tMovimiento ToTMovimiento(this Movimiento movimiento)
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

        public static tMovimientoDesc ToTMovimientoDesc(this Movimiento movimiento)
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
    }
}
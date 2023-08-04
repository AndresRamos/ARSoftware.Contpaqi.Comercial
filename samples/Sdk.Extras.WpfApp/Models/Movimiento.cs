using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.WpfApp.Models;

public class Movimiento : admMovimientos
{
    public Almacen Almacen { get; set; } = new();
    public Producto Producto { get; set; } = new();
    public ValorClasificacion ValorClasificacion { get; set; } = new();

    public tMovimiento ToTMovimiento()
    {
        var nuevoTMovimiento = new tMovimiento
        {
            aConsecutivo = (int)CNUMEROMOVIMIENTO,
            aUnidades = CUNIDADES,
            aPrecio = CPRECIO,
            aCosto = CCOSTOCAPTURADO,
            aCodProdSer = Producto.CCODIGOPRODUCTO,
            aCodAlmacen = Almacen.CCODIGOALMACEN,
            aReferencia = CREFERENCIA,
            aCodClasificacion = ValorClasificacion.CCODIGOVALORCLASIFICACION
        };
        return nuevoTMovimiento;
    }

    public tMovimientoDesc ToTMovimientoDesc()
    {
        var nuevoTMovimientoDesc = new tMovimientoDesc
        {
            aConsecutivo = (int)CNUMEROMOVIMIENTO,
            aUnidades = CUNIDADES,
            aPrecio = CPRECIO,
            aCosto = CCOSTOCAPTURADO,
            aCodProdSer = Producto.CCODIGOPRODUCTO,
            aCodAlmacen = Almacen.CCODIGOALMACEN,
            aReferencia = CREFERENCIA,
            aCodClasificacion = ValorClasificacion.CCODIGOVALORCLASIFICACION,
            aImporteDescto1 = CDESCUENTO1,
            aImporteDescto2 = CDESCUENTO2,
            aImporteDescto3 = CDESCUENTO3,
            aImporteDescto4 = CDESCUENTO4,
            aImporteDescto5 = CDESCUENTO5,
            aPorcDescto1 = CPORCENTAJEDESCUENTO1,
            aPorcDescto2 = CPORCENTAJEDESCUENTO2,
            aPorcDescto3 = CPORCENTAJEDESCUENTO3,
            aPorcDescto4 = CPORCENTAJEDESCUENTO4,
            aPorcDescto5 = CPORCENTAJEDESCUENTO5
        };
        return nuevoTMovimientoDesc;
    }
}

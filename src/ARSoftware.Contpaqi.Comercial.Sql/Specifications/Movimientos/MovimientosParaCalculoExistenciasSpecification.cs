using System;
using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Movimientos;

/// <summary>
///     Especificación para obtener los movimientos de un producto en un almacén para el cálculo de existencias.
/// </summary>
public sealed class MovimientosParaCalculoExistenciasSpecification : Specification<admMovimientos>
{
    public MovimientosParaCalculoExistenciasSpecification(int idProducto, int idAlmacen, DateTime fechaCorte)
    {
        Query.Where(m => m.CIDPRODUCTO == idProducto && m.CIDALMACEN == idAlmacen && m.CFECHA <= fechaCorte && m.CAFECTADOINVENTARIO == 1);
    }
}

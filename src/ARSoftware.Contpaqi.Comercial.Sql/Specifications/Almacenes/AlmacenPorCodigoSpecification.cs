using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Almacenes;

/// <summary>
///     Especificación para obtener un almacén por su código.
/// </summary>
public sealed class AlmacenPorCodigoSpecification : SingleResultSpecification<admAlmacenes>
{
    public AlmacenPorCodigoSpecification(string codigoAlmacen)
    {
        Query.Where(almacen => almacen.CCODIGOALMACEN == codigoAlmacen);
    }
}

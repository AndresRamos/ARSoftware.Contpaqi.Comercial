using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Almacenes;

/// <summary>
///     Especificación para obtener un almacén por su id.
/// </summary>
public sealed class AlmacenPorIdSpecification : SingleResultSpecification<admAlmacenes>
{
    public AlmacenPorIdSpecification(int idAlmacen)
    {
        Query.Where(almacen => almacen.CIDALMACEN == idAlmacen);
    }
}

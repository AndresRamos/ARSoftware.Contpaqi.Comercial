using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

public sealed class AlmacenPorCodigoSpecification : SingleResultSpecification<admAlmacenes>
{
    public AlmacenPorCodigoSpecification(string codigoAlmacen)
    {
        Query.Where(almacen => almacen.CCODIGOALMACEN == codigoAlmacen);
    }
}

public sealed class AlmacenPorIdSpecification : SingleResultSpecification<admAlmacenes>
{
    public AlmacenPorIdSpecification(int idAlmacen)
    {
        Query.Where(almacen => almacen.CIDALMACEN == idAlmacen);
    }
}
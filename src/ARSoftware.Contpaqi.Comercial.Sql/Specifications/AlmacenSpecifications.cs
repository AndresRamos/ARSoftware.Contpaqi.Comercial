using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

public sealed class AlmacenPorCodigoSpecificaion : SingleResultSpecification<admAlmacenes>
{
    public AlmacenPorCodigoSpecificaion(string codigoAlmacen)
    {
        Query.Where(almacen => almacen.CCODIGOALMACEN == codigoAlmacen);
    }
}

public sealed class AlmacenPorIdSpecificaion : SingleResultSpecification<admAlmacenes>
{
    public AlmacenPorIdSpecificaion(int idAlmacen)
    {
        Query.Where(almacen => almacen.CIDALMACEN == idAlmacen);
    }
}
using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

public sealed class MovimientoPorIdSpecification : SingleResultSpecification<admMovimientos>
{
    public MovimientoPorIdSpecification(int idMovimiento)
    {
        Query.Where(movimiento => movimiento.CIDMOVIMIENTO == idMovimiento);
    }
}

public sealed class MovimientosPorDocumentoIdSpecification : Specification<admMovimientos>
{
    public MovimientosPorDocumentoIdSpecification(int idDocumento)
    {
        Query.Where(movimiento => movimiento.CIDDOCUMENTO == idDocumento);
    }
}
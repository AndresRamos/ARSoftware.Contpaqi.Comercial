using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

public sealed class UnidadMedidaPorIdSpecification : SingleResultSpecification<admUnidadesMedidaPeso>
{
    public UnidadMedidaPorIdSpecification(int idUnidad)
    {
        Query.Where(unidad => unidad.CIDUNIDAD == idUnidad);
    }
}

public sealed class UnidadMedidaPorNombreSpecification : SingleResultSpecification<admUnidadesMedidaPeso>
{
    public UnidadMedidaPorNombreSpecification(string nombreUnidad)
    {
        Query.Where(unidad => unidad.CNOMBREUNIDAD == nombreUnidad);
    }
}
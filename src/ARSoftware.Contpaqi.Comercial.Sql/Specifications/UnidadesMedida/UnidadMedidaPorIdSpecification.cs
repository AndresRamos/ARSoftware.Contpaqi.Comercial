using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.UnidadesMedida;

/// <summary>
///     Especificación para obtener una unidad de medida por su id.
/// </summary>
public sealed class UnidadMedidaPorIdSpecification : SingleResultSpecification<admUnidadesMedidaPeso>
{
    public UnidadMedidaPorIdSpecification(int idUnidad)
    {
        Query.Where(unidad => unidad.CIDUNIDAD == idUnidad);
    }
}

using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.UnidadesMedida;

/// <summary>
///     Especificación para obtener una unidad de medida por su nombre.
/// </summary>
public sealed class UnidadMedidaPorNombreSpecification : SingleResultSpecification<admUnidadesMedidaPeso>
{
    public UnidadMedidaPorNombreSpecification(string nombreUnidad)
    {
        Query.Where(unidad => unidad.CNOMBREUNIDAD == nombreUnidad);
    }
}

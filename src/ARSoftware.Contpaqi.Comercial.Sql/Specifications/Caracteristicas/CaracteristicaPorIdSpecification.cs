using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Caracteristicas;

/// <summary>
///     Especificación para obtener una característica por su id.
/// </summary>
public sealed class CaracteristicaPorIdSpecification : SingleResultSpecification<admCaracteristicas>
{
    public CaracteristicaPorIdSpecification(int idCaracteristica)
    {
        Query.Where(almacen => almacen.CIDPADRECARACTERISTICA == idCaracteristica);
    }
}

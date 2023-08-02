using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Direcciones;

/// <summary>
///     Especificación para obtener una dirección por su id.
/// </summary>
public sealed class DireccionPorIdSpecification : SingleResultSpecification<admDomicilios>
{
    public DireccionPorIdSpecification(int idDireccion)
    {
        Query.Where(direccion => direccion.CIDDIRECCION == idDireccion);
    }
}

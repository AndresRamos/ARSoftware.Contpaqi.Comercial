using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

public sealed class EmpresaPorNombreSpecification : SingleResultSpecification<Empresas>
{
    public EmpresaPorNombreSpecification(string nombreEmpresa)
    {
        Query.Where(empresa => empresa.CNOMBREEMPRESA == nombreEmpresa);
    }
}

using Ardalis.Specification;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Empresas;

public sealed class EmpresaPorNombreSpecification : SingleResultSpecification<Models.Generales.Empresas>
{
    public EmpresaPorNombreSpecification(string nombreEmpresa)
    {
        Query.Where(empresa => empresa.CNOMBREEMPRESA == nombreEmpresa);
    }
}

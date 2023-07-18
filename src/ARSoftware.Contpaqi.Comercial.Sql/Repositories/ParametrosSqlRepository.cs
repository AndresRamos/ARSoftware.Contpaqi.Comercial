using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class ParametrosSqlRepository : IParametrosRepository<admParametros>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ParametrosSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admParametros Buscar()
    {
        return _context.admParametros.Single();
    }
}
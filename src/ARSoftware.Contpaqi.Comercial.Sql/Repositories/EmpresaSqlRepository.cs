using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class EmpresaSqlRepository : IEmpresaRepository<Empresas>
{
    private readonly ContpaqiComercialGeneralesDbContext _context;

    public EmpresaSqlRepository(ContpaqiComercialGeneralesDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public IEnumerable<Empresas> TraerTodo()
    {
        return _context.Empresas.ToList();
    }
}
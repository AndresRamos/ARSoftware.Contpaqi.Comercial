using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class AlmacenSqlRepository : RepositoryBase<admAlmacenes>, IAlmacenRepository<admAlmacenes>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public AlmacenSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admAlmacenes BuscarPorCodigo(string codigoAlmacen)
    {
        return _context.admAlmacenes.WithSpecification(new AlmacenPorCodigoSpecificaion(codigoAlmacen)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admAlmacenes BuscarPorId(int idAlmacen)
    {
        return _context.admAlmacenes.WithSpecification(new AlmacenPorIdSpecificaion(idAlmacen)).SingleOrDefault();
    }

    /// <inheritdoc />
    public IEnumerable<admAlmacenes> TraerTodo()
    {
        return _context.admAlmacenes.ToList();
    }
}
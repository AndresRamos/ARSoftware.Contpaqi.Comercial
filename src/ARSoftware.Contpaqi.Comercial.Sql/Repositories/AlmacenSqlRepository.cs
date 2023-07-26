using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar almacenes.
/// </summary>
public sealed class AlmacenSqlRepository : ContpaqiComercialSqlRepositoryBase<admAlmacenes>, IAlmacenRepository<admAlmacenes>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public AlmacenSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admAlmacenes? BuscarPorCodigo(string codigoAlmacen)
    {
        return _context.admAlmacenes.WithSpecification(new AlmacenPorCodigoSpecification(codigoAlmacen)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admAlmacenes? BuscarPorId(int idAlmacen)
    {
        return _context.admAlmacenes.WithSpecification(new AlmacenPorIdSpecification(idAlmacen)).SingleOrDefault();
    }

    /// <inheritdoc />
    public List<admAlmacenes> TraerTodo()
    {
        return _context.admAlmacenes.ToList();
    }
}
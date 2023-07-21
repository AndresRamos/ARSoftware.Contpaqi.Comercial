using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar movimientos.
/// </summary>
public sealed class MovimientoSqlRepository : RepositoryBase<admMovimientos>, IMovimientoRepository<admMovimientos>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public MovimientoSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admMovimientos? BuscarPorId(int idMovimiento)
    {
        return _context.admMovimientos.WithSpecification(new MovimientoPorIdSpecification(idMovimiento)).SingleOrDefault();
    }

    /// <inheritdoc />
    public IEnumerable<admMovimientos> TraerPorDocumentoId(int idDocumento)
    {
        return _context.admMovimientos.WithSpecification(new MovimientosPorDocumentoIdSpecification(idDocumento)).ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admMovimientos> TraerTodo()
    {
        return _context.admMovimientos.ToList();
    }
}
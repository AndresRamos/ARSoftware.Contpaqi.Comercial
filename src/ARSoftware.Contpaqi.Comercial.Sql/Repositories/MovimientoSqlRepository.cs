using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class MovimientoSqlRepository : IMovimientoRepository<admMovimientos>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public MovimientoSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admMovimientos BuscarPorId(int idMovimiento)
    {
        return _context.admMovimientos.SingleOrDefault(movimiento => movimiento.CIDMOVIMIENTO == idMovimiento);
    }

    /// <inheritdoc />
    public IEnumerable<admMovimientos> TraerPorDocumentoId(int idDocumento)
    {
        return _context.admMovimientos.Where(movimiento => movimiento.CIDDOCUMENTO == idDocumento).ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admMovimientos> TraerTodo()
    {
        return _context.admMovimientos.ToList();
    }
}
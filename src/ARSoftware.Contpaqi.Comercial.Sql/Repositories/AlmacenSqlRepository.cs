using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class AlmacenSqlRepository : IAlmacenRepository<admAlmacenes>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public AlmacenSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admAlmacenes BuscarPorCodigo(string codigoAlmacen)
    {
        return _context.admAlmacenes.SingleOrDefault(almacen => almacen.CCODIGOALMACEN == codigoAlmacen);
    }

    /// <inheritdoc />
    public admAlmacenes BuscarPorId(int idAlmacen)
    {
        return _context.admAlmacenes.SingleOrDefault(almacen => almacen.CIDALMACEN == idAlmacen);
    }

    /// <inheritdoc />
    public IEnumerable<admAlmacenes> TraerTodo()
    {
        return _context.admAlmacenes.ToList();
    }
}
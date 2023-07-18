using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class UnidadMedidaSqlRepository : IUnidadMedidaRepository<admUnidadesMedidaPeso>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public UnidadMedidaSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admUnidadesMedidaPeso BuscarPorId(int idUnidad)
    {
        return _context.admUnidadesMedidaPeso.SingleOrDefault(unidad => unidad.CIDUNIDAD == idUnidad);
    }

    /// <inheritdoc />
    public admUnidadesMedidaPeso BuscarPorNombre(string nombreUnidad)
    {
        return _context.admUnidadesMedidaPeso.SingleOrDefault(unidad => unidad.CNOMBREUNIDAD == nombreUnidad);
    }

    /// <inheritdoc />
    public IEnumerable<admUnidadesMedidaPeso> TraerTodo()
    {
        return _context.admUnidadesMedidaPeso.ToList();
    }
}
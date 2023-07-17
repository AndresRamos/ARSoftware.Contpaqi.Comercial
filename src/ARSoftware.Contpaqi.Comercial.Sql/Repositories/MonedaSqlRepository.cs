using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class MonedaSqlRepository : IMonedaRepository<admMonedas>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public MonedaSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admMonedas BuscarPorId(int idMoneda)
    {
        return _context.admMonedas.SingleOrDefault(moneda => moneda.CIDMONEDA == idMoneda);
    }

    /// <inheritdoc />
    public admMonedas BuscarPorNombre(string nombreMoneda)
    {
        return _context.admMonedas.SingleOrDefault(moneda => moneda.CNOMBREMONEDA == nombreMoneda);
    }

    /// <inheritdoc />
    public IEnumerable<admMonedas> TraerTodo()
    {
        return _context.admMonedas.ToList();
    }
}
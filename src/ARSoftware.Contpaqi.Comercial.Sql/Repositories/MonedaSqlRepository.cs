using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar monedas.
/// </summary>
public sealed class MonedaSqlRepository : RepositoryBase<admMonedas>, IMonedaRepository<admMonedas>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public MonedaSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admMonedas? BuscarPorId(int idMoneda)
    {
        return _context.admMonedas.WithSpecification(new MonedaPorIdSpecification(idMoneda)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admMonedas? BuscarPorNombre(string nombreMoneda)
    {
        return _context.admMonedas.WithSpecification(new MonedaPorNombreSpecification(nombreMoneda)).SingleOrDefault();
    }

    /// <inheritdoc />
    public IEnumerable<admMonedas> TraerTodo()
    {
        return _context.admMonedas.ToList();
    }
}
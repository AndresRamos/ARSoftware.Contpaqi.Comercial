using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar unidades de medida.
/// </summary>
public sealed class UnidadMedidaSqlRepository : RepositoryBase<admUnidadesMedidaPeso>, IUnidadMedidaRepository<admUnidadesMedidaPeso>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public UnidadMedidaSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admUnidadesMedidaPeso? BuscarPorId(int idUnidad)
    {
        return _context.admUnidadesMedidaPeso.WithSpecification(new UnidadMedidaPorIdSpecification(idUnidad)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admUnidadesMedidaPeso? BuscarPorNombre(string nombreUnidad)
    {
        return _context.admUnidadesMedidaPeso.WithSpecification(new UnidadMedidaPorNombreSpecification(nombreUnidad)).SingleOrDefault();
    }

    /// <inheritdoc />
    public List<admUnidadesMedidaPeso> TraerTodo()
    {
        return _context.admUnidadesMedidaPeso.ToList();
    }
}
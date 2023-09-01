using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.UnidadesMedida;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar unidades de medida y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean las unidades de medida.
/// </typeparam>
public sealed class UnidadMedidaSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admUnidadesMedidaPeso, T>,
    IUnidadMedidaSqlRepository<T> where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    public UnidadMedidaSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idUnidad)
    {
        return _context.admUnidadesMedidaPeso.WithSpecification(new UnidadMedidaPorIdSpecification(idUnidad))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorNombre(string nombreUnidad)
    {
        return _context.admUnidadesMedidaPeso.WithSpecification(new UnidadMedidaPorNombreSpecification(nombreUnidad))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.admUnidadesMedidaPeso.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorIdAsync(int idUnidad, CancellationToken cancellationToken)
    {
        return await _context.admUnidadesMedidaPeso.WithSpecification(new UnidadMedidaPorIdSpecification(idUnidad))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorNombreAsync(string nombreUnidad, CancellationToken cancellationToken)
    {
        return await _context.admUnidadesMedidaPeso.WithSpecification(new UnidadMedidaPorNombreSpecification(nombreUnidad))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken)
    {
        return await _context.admUnidadesMedidaPeso.ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Empresas;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar empresas y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean las empresas.
/// </typeparam>
public sealed class EmpresaSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<Empresas, T>, IEmpresaSqlRepository<T>
    where T : class, new()
{
    private readonly ContpaqiComercialGeneralesDbContext _context;
    private readonly IMapper _mapper;

    public EmpresaSqlRepository(ContpaqiComercialGeneralesDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorNombre(string nombreEmpresa)
    {
        return _context.Empresas.WithSpecification(new EmpresaPorNombreSpecification(nombreEmpresa))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .FirstOrDefault();
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.Empresas.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorNombreAsync(string nombreEmpresa, CancellationToken cancellationToken)
    {
        return await _context.Empresas.WithSpecification(new EmpresaPorNombreSpecification(nombreEmpresa))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken)
    {
        return await _context.Empresas.ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
    }
}

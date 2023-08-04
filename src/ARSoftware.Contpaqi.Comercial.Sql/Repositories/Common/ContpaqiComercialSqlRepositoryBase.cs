using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;

public abstract class ContpaqiComercialSqlRepositoryBase<T> : IContpaqiComercialSqlRepositoryBase<T> where T : class
{
    private readonly DbContext _dbContext;
    private readonly ISpecificationEvaluator _specificationEvaluator;

    public ContpaqiComercialSqlRepositoryBase(DbContext dbContext) : this(dbContext, SpecificationEvaluator.Default)
    {
    }

    public ContpaqiComercialSqlRepositoryBase(DbContext dbContext, ISpecificationEvaluator specificationEvaluator)
    {
        _dbContext = dbContext;
        _specificationEvaluator = specificationEvaluator;
    }

    /// <inheritdoc />
    public virtual async Task<bool> AnyAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification, true).AnyAsync(cancellationToken);
    }

    /// <inheritdoc />
    public virtual async Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification, true).CountAsync(cancellationToken);
    }

    /// <inheritdoc />
    public virtual async Task<T?> FirstOrDefaultAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification).FirstOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public virtual async Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        List<T> queryResult = await ApplySpecification(specification).ToListAsync(cancellationToken);

        return specification.PostProcessingAction == null ? queryResult : specification.PostProcessingAction(queryResult).ToList();
    }

    /// <inheritdoc />
    public virtual async Task<T?> SingleOrDefaultAsync(ISingleResultSpecification<T> specification,
        CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification).SingleOrDefaultAsync(cancellationToken);
    }

    /// <summary>
    ///     Aplica la especificación al query.
    /// </summary>
    /// <param name="specification">
    ///     Especificación a aplicar.
    /// </param>
    /// <param name="evaluateCriteriaOnly">
    ///     Indica si solo se evaluarán los criterios de la especificación.
    /// </param>
    /// <returns>
    ///     Un query con la especificacion aplicada.
    /// </returns>
    protected virtual IQueryable<T> ApplySpecification(ISpecification<T> specification, bool evaluateCriteriaOnly = false)
    {
        return _specificationEvaluator.GetQuery(_dbContext.Set<T>().AsQueryable(), specification, evaluateCriteriaOnly);
    }
}

public abstract class ContpaqiComercialSqlRepositoryBase<T, TResult> : IContpaqiComercialSqlRepositoryBase<T, TResult> where T : class
{
    private readonly DbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ISpecificationEvaluator _specificationEvaluator;

    public ContpaqiComercialSqlRepositoryBase(DbContext dbContext, IMapper mapper) : this(dbContext, mapper, SpecificationEvaluator.Default)
    {
    }

    public ContpaqiComercialSqlRepositoryBase(DbContext dbContext, IMapper mapper, ISpecificationEvaluator specificationEvaluator)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _specificationEvaluator = specificationEvaluator;
    }

    /// <inheritdoc />
    public virtual async Task<bool> AnyAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification, true).AnyAsync(cancellationToken);
    }

    /// <inheritdoc />
    public virtual async Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification, true).CountAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TResult?> FirstOrDefaultAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification)
            .ProjectTo<TResult>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<TResult>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification).ProjectTo<TResult>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TResult?> SingleOrDefaultAsync(ISingleResultSpecification<T> specification,
        CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification)
            .ProjectTo<TResult>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <summary>
    ///     Aplica la especificación al query.
    /// </summary>
    /// <param name="specification">
    ///     Especificación a aplicar.
    /// </param>
    /// <param name="evaluateCriteriaOnly">
    ///     Indica si solo se evaluarán los criterios de la especificación.
    /// </param>
    /// <returns>
    ///     Un query con la especificacion aplicada.
    /// </returns>
    protected virtual IQueryable<T> ApplySpecification(ISpecification<T> specification, bool evaluateCriteriaOnly = false)
    {
        return _specificationEvaluator.GetQuery(_dbContext.Set<T>().AsQueryable(), specification, evaluateCriteriaOnly);
    }
}

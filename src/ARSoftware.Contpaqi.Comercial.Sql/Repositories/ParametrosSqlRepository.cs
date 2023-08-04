using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar parámetros.
/// </summary>
public sealed class ParametrosSqlRepository : ContpaqiComercialSqlRepositoryBase<admParametros>, IParametrosRepository<admParametros>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ParametrosSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admParametros Buscar()
    {
        return _context.admParametros.Single();
    }
}

/// <summary>
///     Repositorio de SQL para consultar parámetros y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los parametros.
/// </typeparam>
public sealed class ParametrosSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admParametros, T>, IParametrosRepository<T>
    where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    public ParametrosSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T Buscar()
    {
        return _context.admParametros.ProjectTo<T>(_mapper.ConfigurationProvider).Single();
    }
}

using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar parámetros y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los parametros.
/// </typeparam>
public sealed class ParametrosSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admParametros, T>, IParametrosSqlRepository<T>
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

    /// <inheritdoc />
    public async Task<T> BuscarAsync(CancellationToken cancellationToken)
    {
        return await _context.admParametros.ProjectTo<T>(_mapper.ConfigurationProvider).SingleAsync(cancellationToken);
    }
}

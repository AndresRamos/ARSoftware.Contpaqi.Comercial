using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Conceptos;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar conceptos de documento y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los conceptos de documento.
/// </typeparam>
public sealed class ConceptoDocumentoSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admConceptos, T>,
    IConceptoDocumentoSqlRepository<T> where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    public ConceptoDocumentoSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorCodigo(string codigoConcepto)
    {
        return _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idConcepto)
    {
        return _context.admConceptos.WithSpecification(new ConceptoPorIdSpecification(idConcepto))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public List<T> TraerPorDocumentoModeloId(int idDocumentoModelo)
    {
        return _context.admConceptos.WithSpecification(new ConceptosPorDocumentoModeloIdSpecification(idDocumentoModelo))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToList();
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.admConceptos.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorCodigoAsync(string codigoConcepto, CancellationToken cancellationToken)
    {
        return await _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorIdAsync(int idConcepto, CancellationToken cancellationToken)
    {
        return await _context.admConceptos.WithSpecification(new ConceptoPorIdSpecification(idConcepto))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerPorDocumentoModeloIdAsync(int idDocumentoModelo, CancellationToken cancellationToken)
    {
        return await _context.admConceptos.WithSpecification(new ConceptosPorDocumentoModeloIdSpecification(idDocumentoModelo))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken)
    {
        return await _context.admConceptos.ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
    }
}

using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Conceptos;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar conceptos de documento.
/// </summary>
public sealed class ConceptoDocumentoSqlRepository : ContpaqiComercialSqlRepositoryBase<admConceptos>,
    IConceptoDocumentoRepository<admConceptos>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ConceptoDocumentoSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admConceptos? BuscarPorCodigo(string codigoConcepto)
    {
        return _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admConceptos? BuscarPorId(int idConcepto)
    {
        return _context.admConceptos.WithSpecification(new ConceptoPorIdSpecification(idConcepto)).SingleOrDefault();
    }

    /// <inheritdoc />
    public List<admConceptos> TraerPorDocumentoModeloId(int idDocumentoModelo)
    {
        return _context.admConceptos.WithSpecification(new ConceptosPorDocumentoModeloIdSpecification(idDocumentoModelo)).ToList();
    }

    /// <inheritdoc />
    public List<admConceptos> TraerTodo()
    {
        return _context.admConceptos.ToList();
    }
}

/// <summary>
///     Repositorio de SQL para consultar conceptos de documento y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los conceptos de documento.
/// </typeparam>
public sealed class ConceptoDocumentoSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admConceptos, T>, IConceptoDocumentoRepository<T>
    where T : class, new()
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
}

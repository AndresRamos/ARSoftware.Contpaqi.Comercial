using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar documentos modelo.
/// </summary>
public sealed class DocumentoModeloSqlRepository : ContpaqiComercialSqlRepositoryBase<admDocumentosModelo>,
    IDocumentoModeloRepository<admDocumentosModelo>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public DocumentoModeloSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public List<admDocumentosModelo> TraerTodo()
    {
        return _context.admDocumentosModelo.ToList();
    }
}

/// <summary>
///     Repositorio de SQL para consultar documentos modelo y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los documentos modelo.
/// </typeparam>
public sealed class DocumentoModeloSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admDocumentosModelo, T>,
    IDocumentoModeloRepository<T> where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    public DocumentoModeloSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.admDocumentosModelo.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }
}

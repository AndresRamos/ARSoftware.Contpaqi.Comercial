using System.Collections.Generic;
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
///     Repositorio de SQL para consultar documentos modelo y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los documentos modelo.
/// </typeparam>
public sealed class DocumentoModeloSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admDocumentosModelo, T>,
    IDocumentoModeloSqlRepository<T> where T : class, new()
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

    /// <inheritdoc />
    public async Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken)
    {
        return await _context.admDocumentosModelo.ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
    }
}

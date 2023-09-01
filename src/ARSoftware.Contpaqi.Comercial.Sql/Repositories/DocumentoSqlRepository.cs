using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Clientes;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Conceptos;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Documentos;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

// ReSharper disable CompareOfFloatsByEqualityOperator

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar documentos y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los documentos.
/// </typeparam>
public sealed class DocumentoSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admDocumentos, T>, IDocumentoSqlRepository<T>
    where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    public DocumentoSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idDocumento)
    {
        return _context.admDocumentos.WithSpecification(new DocumentoPorIdSpecification(idDocumento))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorLlave(string codigoConcepto, string serie, double folio)
    {
        var concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto))
                .Select(c => new { c.CIDCONCEPTODOCUMENTO })
                .SingleOrDefault() ??
            throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        return _context.admDocumentos.WithSpecification(new DocumentoPorLlaveSpecification(concepto.CIDCONCEPTODOCUMENTO, serie, folio))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorLlave(LlaveDocumento llaveDocumento)
    {
        var concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(llaveDocumento.ConceptoCodigo))
                .Select(c => new { c.CIDCONCEPTODOCUMENTO })
                .SingleOrDefault() ?? throw new ArgumentException($"El concepto con codigo {llaveDocumento.ConceptoCodigo} no existe.",
                nameof(llaveDocumento.ConceptoCodigo));

        return _context.admDocumentos
            .WithSpecification(
                new DocumentoPorLlaveSpecification(concepto.CIDCONCEPTODOCUMENTO, llaveDocumento.Serie, llaveDocumento.Folio))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public LlaveDocumento BuscarSiguienteSerieYFolio(string codigoConcepto)
    {
        admConceptos concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto)).SingleOrDefault() ??
            throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        return new LlaveDocumento
        {
            ConceptoCodigo = concepto.CCODIGOCONCEPTO, Serie = concepto.CSERIEPOROMISION, Folio = concepto.CNOFOLIO
        };
    }

    /// <inheritdoc />
    public List<T> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto,
        string codigoClienteProveedor)
    {
        var concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto))
                .Select(c => new { c.CIDCONCEPTODOCUMENTO })
                .SingleOrDefault() ??
            throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        var cliente =
            _context.admClientes.WithSpecification(new ClientePorCodigoSpecification(codigoClienteProveedor))
                .Select(c => new { c.CIDCLIENTEPROVEEDOR })
                .SingleOrDefault() ?? throw new ArgumentException($"El cliente/proveedor con codigo {codigoClienteProveedor} no existe.",
                nameof(codigoClienteProveedor));

        return _context.admDocumentos
            .WithSpecification(new DocumentosPorRangoFechaYConceptoYClienteSpecification(fechaInicio, fechaFin,
                concepto.CIDCONCEPTODOCUMENTO, cliente.CIDCLIENTEPROVEEDOR))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToList();
    }

    /// <inheritdoc />
    public List<T> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto,
        IEnumerable<string> codigosClienteProveedor)
    {
        var concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto))
                .Select(c => new { c.CIDCONCEPTODOCUMENTO })
                .SingleOrDefault() ??
            throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        var documentos = new List<T>();

        foreach (string codigoClienteProveedor in codigosClienteProveedor)
        {
            var cliente =
                _context.admClientes.WithSpecification(new ClientePorCodigoSpecification(codigoClienteProveedor))
                    .Select(c => new { c.CIDCLIENTEPROVEEDOR })
                    .SingleOrDefault() ??
                throw new ArgumentException($"El cliente/proveedor con codigo {codigoClienteProveedor} no existe.",
                    nameof(codigoClienteProveedor));

            documentos.AddRange(_context.admDocumentos
                .WithSpecification(new DocumentosPorRangoFechaYConceptoYClienteSpecification(fechaInicio, fechaFin,
                    concepto.CIDCONCEPTODOCUMENTO, cliente.CIDCLIENTEPROVEEDOR))
                .ProjectTo<T>(_mapper.ConfigurationProvider)
                .ToList());
        }

        return documentos;
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.admDocumentos.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorIdAsync(int idDocumento, CancellationToken cancellationToken)
    {
        return await _context.admDocumentos.WithSpecification(new DocumentoPorIdSpecification(idDocumento))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorLlaveAsync(string codigoConcepto, string serie, double folio, CancellationToken cancellationToken)
    {
        var concepto =
            await _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto))
                .Select(c => new { c.CIDCONCEPTODOCUMENTO })
                .SingleOrDefaultAsync(cancellationToken) ??
            throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        return await _context.admDocumentos
            .WithSpecification(new DocumentoPorLlaveSpecification(concepto.CIDCONCEPTODOCUMENTO, serie, folio))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorLlaveAsync(LlaveDocumento llaveDocumento, CancellationToken cancellationToken)
    {
        var concepto =
            await _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(llaveDocumento.ConceptoCodigo))
                .Select(c => new { c.CIDCONCEPTODOCUMENTO })
                .SingleOrDefaultAsync(cancellationToken) ?? throw new ArgumentException(
                $"El concepto con codigo {llaveDocumento.ConceptoCodigo} no existe.", nameof(llaveDocumento.ConceptoCodigo));

        return await _context.admDocumentos
            .WithSpecification(
                new DocumentoPorLlaveSpecification(concepto.CIDCONCEPTODOCUMENTO, llaveDocumento.Serie, llaveDocumento.Folio))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedorAsync(DateTime fechaInicio, DateTime fechaFin,
        string codigoConcepto, string codigoClienteProveedor, CancellationToken cancellationToken)
    {
        var concepto =
            await _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto))
                .Select(c => new { c.CIDCONCEPTODOCUMENTO })
                .SingleOrDefaultAsync(cancellationToken) ??
            throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        var cliente =
            await _context.admClientes.WithSpecification(new ClientePorCodigoSpecification(codigoClienteProveedor))
                .Select(c => new { c.CIDCLIENTEPROVEEDOR })
                .SingleOrDefaultAsync(cancellationToken) ??
            throw new ArgumentException($"El cliente/proveedor con codigo {codigoClienteProveedor} no existe.",
                nameof(codigoClienteProveedor));

        return await _context.admDocumentos
            .WithSpecification(new DocumentosPorRangoFechaYConceptoYClienteSpecification(fechaInicio, fechaFin,
                concepto.CIDCONCEPTODOCUMENTO, cliente.CIDCLIENTEPROVEEDOR))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedorAsync(DateTime fechaInicio, DateTime fechaFin,
        string codigoConcepto, IEnumerable<string> codigosClienteProveedor, CancellationToken cancellationToken)
    {
        var concepto =
            await _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto))
                .Select(c => new { c.CIDCONCEPTODOCUMENTO })
                .SingleOrDefaultAsync(cancellationToken) ??
            throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        var documentos = new List<T>();

        foreach (string codigoClienteProveedor in codigosClienteProveedor)
        {
            var cliente =
                await _context.admClientes.WithSpecification(new ClientePorCodigoSpecification(codigoClienteProveedor))
                    .Select(c => new { c.CIDCLIENTEPROVEEDOR })
                    .SingleOrDefaultAsync(cancellationToken) ?? throw new ArgumentException(
                    $"El cliente/proveedor con codigo {codigoClienteProveedor} no existe.", nameof(codigoClienteProveedor));

            documentos.AddRange(await _context.admDocumentos
                .WithSpecification(new DocumentosPorRangoFechaYConceptoYClienteSpecification(fechaInicio, fechaFin,
                    concepto.CIDCONCEPTODOCUMENTO, cliente.CIDCLIENTEPROVEEDOR))
                .ProjectTo<T>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken));
        }

        return documentos;
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken)
    {
        return await _context.admDocumentos.ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
    }
}

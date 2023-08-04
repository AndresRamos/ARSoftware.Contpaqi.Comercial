using System;
using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Clientes;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Conceptos;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Documentos;
using AutoMapper;
using AutoMapper.QueryableExtensions;

// ReSharper disable CompareOfFloatsByEqualityOperator

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar documentos.
/// </summary>
public sealed class DocumentoSqlRepository : ContpaqiComercialSqlRepositoryBase<admDocumentos>, IDocumentoRepository<admDocumentos>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public DocumentoSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admDocumentos? BuscarPorId(int idDocumento)
    {
        return _context.admDocumentos.WithSpecification(new DocumentoPorIdSpecification(idDocumento)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admDocumentos? BuscarPorLlave(string codigoConcepto, string serie, double folio)
    {
        admConceptos concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto)).SingleOrDefault() ??
            throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        return _context.admDocumentos.WithSpecification(new DocumentoPorLlaveSpecification(concepto.CIDCONCEPTODOCUMENTO, serie, folio))
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public admDocumentos? BuscarPorLlave(LlaveDocumento llaveDocumento)
    {
        admConceptos concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(llaveDocumento.ConceptoCodigo)).SingleOrDefault() ??
            throw new ArgumentException($"El concepto con codigo {llaveDocumento.ConceptoCodigo} no existe.",
                nameof(llaveDocumento.ConceptoCodigo));

        return _context.admDocumentos
            .WithSpecification(
                new DocumentoPorLlaveSpecification(concepto.CIDCONCEPTODOCUMENTO, llaveDocumento.Serie, llaveDocumento.Folio))
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
    public List<admDocumentos> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin,
        string codigoConcepto, string codigoClienteProveedor)
    {
        admConceptos concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto)).SingleOrDefault() ??
            throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        admClientes cliente =
            _context.admClientes.WithSpecification(new ClientePorCodigoSpecification(codigoClienteProveedor)).SingleOrDefault() ??
            throw new ArgumentException($"El cliente/proveedor con codigo {codigoClienteProveedor} no existe.",
                nameof(codigoClienteProveedor));

        return _context.admDocumentos
            .WithSpecification(new DocumentosPorRangoFechaYConceptoYClienteSpecification(fechaInicio, fechaFin,
                concepto.CIDCONCEPTODOCUMENTO, cliente.CIDCLIENTEPROVEEDOR))
            .ToList();
    }

    /// <inheritdoc />
    public List<admDocumentos> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin,
        string codigoConcepto, IEnumerable<string> codigosClienteProveedor)
    {
        admConceptos concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto)).SingleOrDefault() ??
            throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        var documentos = new List<admDocumentos>();

        foreach (string codigoClienteProveedor in codigosClienteProveedor)
        {
            admClientes cliente =
                _context.admClientes.WithSpecification(new ClientePorCodigoSpecification(codigoClienteProveedor)).SingleOrDefault() ??
                throw new ArgumentException($"El cliente/proveedor con codigo {codigoClienteProveedor} no existe.",
                    nameof(codigoClienteProveedor));

            documentos.AddRange(_context.admDocumentos
                .WithSpecification(new DocumentosPorRangoFechaYConceptoYClienteSpecification(fechaInicio, fechaFin,
                    concepto.CIDCONCEPTODOCUMENTO, cliente.CIDCLIENTEPROVEEDOR))
                .ToList());
        }

        return documentos;
    }

    /// <inheritdoc />
    public List<admDocumentos> TraerTodo()
    {
        return _context.admDocumentos.ToList();
    }
}

/// <summary>
///     Repositorio de SQL para consultar documentos y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los documentos.
/// </typeparam>
public sealed class DocumentoSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admDocumentos, T>, IDocumentoRepository<T>
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
        admConceptos concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto)).SingleOrDefault() ??
            throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        return _context.admDocumentos.WithSpecification(new DocumentoPorLlaveSpecification(concepto.CIDCONCEPTODOCUMENTO, serie, folio))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorLlave(LlaveDocumento llaveDocumento)
    {
        admConceptos concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(llaveDocumento.ConceptoCodigo)).SingleOrDefault() ??
            throw new ArgumentException($"El concepto con codigo {llaveDocumento.ConceptoCodigo} no existe.",
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
        admConceptos concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto)).SingleOrDefault() ??
            throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        admClientes cliente =
            _context.admClientes.WithSpecification(new ClientePorCodigoSpecification(codigoClienteProveedor)).SingleOrDefault() ??
            throw new ArgumentException($"El cliente/proveedor con codigo {codigoClienteProveedor} no existe.",
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
        admConceptos concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto)).SingleOrDefault() ??
            throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        var documentos = new List<T>();

        foreach (string codigoClienteProveedor in codigosClienteProveedor)
        {
            admClientes cliente =
                _context.admClientes.WithSpecification(new ClientePorCodigoSpecification(codigoClienteProveedor)).SingleOrDefault() ??
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
}

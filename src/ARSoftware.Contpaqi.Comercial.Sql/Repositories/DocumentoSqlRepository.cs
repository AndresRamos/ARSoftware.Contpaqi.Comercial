using System;
using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications;

// ReSharper disable CompareOfFloatsByEqualityOperator

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class DocumentoSqlRepository : IDocumentoRepository<admDocumentos>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public DocumentoSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admDocumentos BuscarPorId(int idDocumento)
    {
        return _context.admDocumentos.WithSpecification(new DocumentoPorIdSpecification(idDocumento)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admDocumentos BuscarPorLlave(string codigoConcepto, string serie, string folio)
    {
        admConceptos concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto)).SingleOrDefault() ??
            throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        var folioDouble = Convert.ToDouble(folio);

        return _context.admDocumentos
            .WithSpecification(new DocumentoPorLlaveSpecification(concepto.CIDCONCEPTODOCUMENTO, serie, folioDouble))
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public admDocumentos BuscarPorLlave(LlaveDocumento llaveDocumento)
    {
        admConceptos concepto =
            _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(llaveDocumento.CodigoConcepto)).SingleOrDefault() ??
            throw new ArgumentException($"El concepto con codigo {llaveDocumento.CodigoConcepto} no existe.",
                nameof(llaveDocumento.CodigoConcepto));

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
            CodigoConcepto = concepto.CCODIGOCONCEPTO, Serie = concepto.CSERIEPOROMISION, Folio = concepto.CNOFOLIO
        };
    }

    /// <inheritdoc />
    public IEnumerable<admDocumentos> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin,
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
            .WithSpecification(new DocumentosPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(fechaInicio, fechaFin,
                concepto.CIDCONCEPTODOCUMENTO, cliente.CIDCLIENTEPROVEEDOR))
            .ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admDocumentos> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin,
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
                .WithSpecification(new DocumentosPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(fechaInicio, fechaFin,
                    concepto.CIDCONCEPTODOCUMENTO, cliente.CIDCLIENTEPROVEEDOR))
                .ToList());
        }

        return documentos;
    }

    /// <inheritdoc />
    public IEnumerable<admDocumentos> TraerTodo()
    {
        return _context.admDocumentos.ToList();
    }
}
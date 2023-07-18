using System;
using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

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
        return _context.admDocumentos.SingleOrDefault(documento => documento.CIDDOCUMENTO == idDocumento);
    }

    /// <inheritdoc />
    public admDocumentos BuscarPorLlave(string codigoConcepto, string serie, string folio)
    {
        admConceptos concepto = _context.admConceptos.SingleOrDefault(concepto => concepto.CCODIGOCONCEPTO == codigoConcepto) ??
                                throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        var folioDouble = Convert.ToDouble(folio);

        return _context.admDocumentos.SingleOrDefault(documento =>
            documento.CIDCONCEPTODOCUMENTO == concepto.CIDCONCEPTODOCUMENTO &&
            documento.CSERIEDOCUMENTO == serie &&
            documento.CFOLIO == folioDouble);
    }

    /// <inheritdoc />
    public admDocumentos BuscarPorLlave(LlaveDocumento llaveDocumento)
    {
        admConceptos concepto =
            _context.admConceptos.SingleOrDefault(concepto => concepto.CCODIGOCONCEPTO == llaveDocumento.CodigoConcepto) ??
            throw new ArgumentException($"El concepto con codigo {llaveDocumento.CodigoConcepto} no existe.",
                nameof(llaveDocumento.CodigoConcepto));

        return _context.admDocumentos.SingleOrDefault(documento =>
            documento.CIDCONCEPTODOCUMENTO == concepto.CIDCONCEPTODOCUMENTO &&
            documento.CSERIEDOCUMENTO == llaveDocumento.Serie &&
            documento.CFOLIO == llaveDocumento.Folio);
    }

    /// <inheritdoc />
    public LlaveDocumento BuscarSiguienteSerieYFolio(string codigoConcepto)
    {
        admConceptos concepto = _context.admConceptos.SingleOrDefault(concepto => concepto.CCODIGOCONCEPTO == codigoConcepto) ??
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
        admConceptos concepto = _context.admConceptos.SingleOrDefault(concepto => concepto.CCODIGOCONCEPTO == codigoConcepto) ??
                                throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        admClientes cliente = _context.admClientes.SingleOrDefault(cliente => cliente.CCODIGOCLIENTE == codigoClienteProveedor) ??
                              throw new ArgumentException($"El cliente/proveedor con codigo {codigoClienteProveedor} no existe.",
                                  nameof(codigoClienteProveedor));

        return _context.admDocumentos.Where(documento =>
                documento.CFECHA >= fechaInicio &&
                documento.CFECHA <= fechaFin &&
                documento.CIDCONCEPTODOCUMENTO == concepto.CIDCONCEPTODOCUMENTO &&
                documento.CIDCLIENTEPROVEEDOR == cliente.CIDCLIENTEPROVEEDOR)
            .ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admDocumentos> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin,
        string codigoConcepto, IEnumerable<string> codigosClienteProveedor)
    {
        admConceptos concepto = _context.admConceptos.SingleOrDefault(concepto => concepto.CCODIGOCONCEPTO == codigoConcepto) ??
                                throw new ArgumentException($"El concepto con codigo {codigoConcepto} no existe.", nameof(codigoConcepto));

        var documentos = new List<admDocumentos>();

        foreach (string codigoClienteProveedor in codigosClienteProveedor)
        {
            admClientes cliente = _context.admClientes.SingleOrDefault(cliente => cliente.CCODIGOCLIENTE == codigoClienteProveedor) ??
                                  throw new ArgumentException($"El cliente/proveedor con codigo {codigoClienteProveedor} no existe.",
                                      nameof(codigoClienteProveedor));

            documentos.AddRange(_context.admDocumentos.Where(documento =>
                    documento.CFECHA >= fechaInicio &&
                    documento.CFECHA <= fechaFin &&
                    documento.CIDCONCEPTODOCUMENTO == concepto.CIDCONCEPTODOCUMENTO &&
                    documento.CIDCLIENTEPROVEEDOR == cliente.CIDCLIENTEPROVEEDOR)
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
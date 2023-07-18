using System;
using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class DireccionSqlRepository : IDireccionRepository<admDomicilios>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public DireccionSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admDomicilios BuscarPorCliente(string codigoClienteProveedor, byte tipoDireccion)
    {
        var repository = new ClienteProveedorSqlRepository(_context);

        admClientes cliente = repository.BuscarPorCodigo(codigoClienteProveedor) ??
                              throw new ArgumentException($"El cliente con codigo {codigoClienteProveedor} no existe.",
                                  nameof(codigoClienteProveedor));

        return _context.admDomicilios.FirstOrDefault(direccion =>
            direccion.CTIPOCATALOGO == (int)TipoCatalogoDireccion.Documentos &&
            direccion.CIDCATALOGO == cliente.CIDCLIENTEPROVEEDOR &&
            direccion.CTIPODIRECCION == tipoDireccion);
    }

    /// <inheritdoc />
    public admDomicilios BuscarPorDocumento(int idDocumento, byte tipoDireccion)
    {
        return _context.admDomicilios.FirstOrDefault(direccion =>
            direccion.CTIPOCATALOGO == (int)TipoCatalogoDireccion.Documentos &&
            direccion.CIDCATALOGO == idDocumento &&
            direccion.CTIPODIRECCION == tipoDireccion);
    }

    /// <inheritdoc />
    public admDomicilios BuscarPorId(int idDireccion)
    {
        return _context.admDomicilios.SingleOrDefault(direccion => direccion.CIDDIRECCION == idDireccion);
    }

    /// <inheritdoc />
    public IEnumerable<admDomicilios> TraerPorTipo(TipoCatalogoDireccion tipoCatalogoDireccion)
    {
        return _context.admDomicilios.Where(direccion => direccion.CTIPOCATALOGO == (int)tipoCatalogoDireccion).ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admDomicilios> TraerPorTipoYIdCatalogo(TipoCatalogoDireccion tipoCatalogoDireccion, int idCatalogo)
    {
        return _context.admDomicilios.Where(direccion =>
                direccion.CTIPOCATALOGO == (int)tipoCatalogoDireccion && direccion.CIDCATALOGO == idCatalogo)
            .ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admDomicilios> TraerTodo()
    {
        return _context.admDomicilios.ToList();
    }
}
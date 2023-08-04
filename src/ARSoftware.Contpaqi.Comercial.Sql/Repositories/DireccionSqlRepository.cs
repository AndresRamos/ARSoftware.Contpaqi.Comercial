using System;
using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Clientes;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Direcciones;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar direcciones.
/// </summary>
public sealed class DireccionSqlRepository : ContpaqiComercialSqlRepositoryBase<admDomicilios>, IDireccionRepository<admDomicilios>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public DireccionSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admDomicilios? BuscarPorCliente(string codigoClienteProveedor, TipoDireccion tipoDireccion)
    {
        admClientes cliente =
            _context.admClientes.WithSpecification(new ClientePorCodigoSpecification(codigoClienteProveedor)).SingleOrDefault() ??
            throw new ArgumentException($"El cliente con codigo {codigoClienteProveedor} no existe.", nameof(codigoClienteProveedor));

        return _context.admDomicilios.WithSpecification(new DireccionesPorClienteSpecification(cliente.CIDCLIENTEPROVEEDOR, tipoDireccion))
            .FirstOrDefault();
    }

    /// <inheritdoc />
    public admDomicilios? BuscarPorDocumento(int idDocumento, TipoDireccion tipoDireccion)
    {
        return _context.admDomicilios.WithSpecification(new DireccionPorDocumentoSpecification(idDocumento, tipoDireccion))
            .FirstOrDefault();
    }

    /// <inheritdoc />
    public admDomicilios? BuscarPorId(int idDireccion)
    {
        return _context.admDomicilios.WithSpecification(new DireccionPorIdSpecification(idDireccion)).SingleOrDefault();
    }

    /// <inheritdoc />
    public List<admDomicilios> TraerPorTipo(TipoCatalogoDireccion tipoCatalogoDireccion)
    {
        return _context.admDomicilios.WithSpecification(new DireccionPorTipoCatalogoSpecification(tipoCatalogoDireccion)).ToList();
    }

    /// <inheritdoc />
    public List<admDomicilios> TraerPorTipoYIdCatalogo(TipoCatalogoDireccion tipoCatalogoDireccion, int idCatalogo)
    {
        return _context.admDomicilios
            .WithSpecification(new DireccionPorTipoCatalogoYIdCatalogoSpecification(tipoCatalogoDireccion, idCatalogo))
            .ToList();
    }

    /// <inheritdoc />
    public List<admDomicilios> TraerTodo()
    {
        return _context.admDomicilios.ToList();
    }
}

/// <summary>
///     Repositorio de SQL para consultar direcciones y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean las direcciones.
/// </typeparam>
public sealed class DireccionSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admDomicilios, T>, IDireccionRepository<T>
    where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    public DireccionSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorCliente(string codigoClienteProveedor, TipoDireccion tipoDireccion)
    {
        admClientes cliente =
            _context.admClientes.WithSpecification(new ClientePorCodigoSpecification(codigoClienteProveedor)).SingleOrDefault() ??
            throw new ArgumentException($"El cliente con codigo {codigoClienteProveedor} no existe.", nameof(codigoClienteProveedor));

        return _context.admDomicilios.WithSpecification(new DireccionesPorClienteSpecification(cliente.CIDCLIENTEPROVEEDOR, tipoDireccion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .FirstOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorDocumento(int idDocumento, TipoDireccion tipoDireccion)
    {
        return _context.admDomicilios.WithSpecification(new DireccionPorDocumentoSpecification(idDocumento, tipoDireccion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .FirstOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idDireccion)
    {
        return _context.admDomicilios.WithSpecification(new DireccionPorIdSpecification(idDireccion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public List<T> TraerPorTipo(TipoCatalogoDireccion tipoCatalogoDireccion)
    {
        return _context.admDomicilios.WithSpecification(new DireccionPorTipoCatalogoSpecification(tipoCatalogoDireccion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToList();
    }

    /// <inheritdoc />
    public List<T> TraerPorTipoYIdCatalogo(TipoCatalogoDireccion tipoCatalogoDireccion, int idCatalogo)
    {
        return _context.admDomicilios
            .WithSpecification(new DireccionPorTipoCatalogoYIdCatalogoSpecification(tipoCatalogoDireccion, idCatalogo))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToList();
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.admDomicilios.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }
}

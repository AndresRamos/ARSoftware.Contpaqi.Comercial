using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Clientes;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar clientes y proveedores.
/// </summary>
public sealed class ClienteProveedorSqlRepository : ContpaqiComercialSqlRepositoryBase<admClientes>,
    IClienteProveedorRepository<admClientes>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ClienteProveedorSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admClientes? BuscarPorCodigo(string codigoCliente)
    {
        return _context.admClientes.WithSpecification(new ClientePorCodigoSpecification(codigoCliente)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admClientes? BuscarPorId(int idCliente)
    {
        return _context.admClientes.WithSpecification(new ClientePorIdSpecification(idCliente)).SingleOrDefault();
    }

    /// <inheritdoc />
    public List<admClientes> TraerClientes()
    {
        return _context.admClientes.WithSpecification(new ClientesSpecification()).ToList();
    }

    /// <inheritdoc />
    public List<admClientes> TraerPorTipo(TipoCliente tipoCliente)
    {
        return _context.admClientes.WithSpecification(new ClientesPorTipoSpecification(tipoCliente)).ToList();
    }

    /// <inheritdoc />
    public List<admClientes> TraerProveedores()
    {
        return _context.admClientes.WithSpecification(new ProveedoresSpecification()).ToList();
    }

    /// <inheritdoc />
    public List<admClientes> TraerTodo()
    {
        return _context.admClientes.ToList();
    }
}

/// <summary>
///     Repositorio de SQL para consultar clientes y proveedores y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los clientes y proveedores.
/// </typeparam>
public sealed class ClienteProveedorSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admClientes, T>, IClienteProveedorRepository<T>
    where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    public ClienteProveedorSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorCodigo(string codigoCliente)
    {
        return _context.admClientes.WithSpecification(new ClientePorCodigoSpecification(codigoCliente))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idCliente)
    {
        return _context.admClientes.WithSpecification(new ClientePorIdSpecification(idCliente))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public List<T> TraerClientes()
    {
        return _context.admClientes.WithSpecification(new ClientesSpecification()).ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }

    /// <inheritdoc />
    public List<T> TraerPorTipo(TipoCliente tipoCliente)
    {
        return _context.admClientes.WithSpecification(new ClientesPorTipoSpecification(tipoCliente))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToList();
    }

    /// <inheritdoc />
    public List<T> TraerProveedores()
    {
        return _context.admClientes.WithSpecification(new ProveedoresSpecification()).ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.admClientes.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }
}

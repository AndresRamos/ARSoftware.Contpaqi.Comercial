using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Clientes;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar clientes y proveedores y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los clientes y proveedores.
/// </typeparam>
public sealed class ClienteProveedorSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admClientes, T>, IClienteProveedorSqlRepository<T>
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

    /// <inheritdoc />
    public async Task<T?> BuscarPorCodigoAsync(string codigoCliente, CancellationToken cancellationToken)
    {
        return await _context.admClientes.WithSpecification(new ClientePorCodigoSpecification(codigoCliente))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorIdAsync(int idCliente, CancellationToken cancellationToken)
    {
        return await _context.admClientes.WithSpecification(new ClientePorIdSpecification(idCliente))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerClientesAsync(CancellationToken cancellationToken)
    {
        return await _context.admClientes.WithSpecification(new ClientesSpecification())
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerPorTipoAsync(TipoCliente tipoCliente, CancellationToken cancellationToken)
    {
        return await _context.admClientes.WithSpecification(new ClientesPorTipoSpecification(tipoCliente))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerProveedoresAsync(CancellationToken cancellationToken)
    {
        return await _context.admClientes.WithSpecification(new ProveedoresSpecification())
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken)
    {
        return await _context.admClientes.ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
    }
}

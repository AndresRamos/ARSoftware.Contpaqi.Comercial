using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class ClienteProveedorSqlRepository : IClienteProveedorRepository<admClientes>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ClienteProveedorSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admClientes BuscarPorCodigo(string codigoCliente)
    {
        return _context.admClientes.SingleOrDefault(cliente => cliente.CCODIGOCLIENTE == codigoCliente);
    }

    /// <inheritdoc />
    public admClientes BuscarPorId(int idCliente)
    {
        return _context.admClientes.SingleOrDefault(cliente => cliente.CIDCLIENTEPROVEEDOR == idCliente);
    }

    /// <inheritdoc />
    public IEnumerable<admClientes> TraerClientes()
    {
        return _context.admClientes.Where(cliente =>
                cliente.CTIPOCLIENTE == (int)TipoCliente.Cliente || cliente.CTIPOCLIENTE == (int)TipoCliente.ClienteProveedor)
            .ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admClientes> TraerPorTipo(TipoCliente tipoCliente)
    {
        return _context.admClientes.Where(cliente => cliente.CTIPOCLIENTE == (int)tipoCliente).ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admClientes> TraerProveedores()
    {
        return _context.admClientes.Where(cliente =>
                cliente.CTIPOCLIENTE == (int)TipoCliente.Proveedor || cliente.CTIPOCLIENTE == (int)TipoCliente.ClienteProveedor)
            .ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admClientes> TraerTodo()
    {
        return _context.admClientes.ToList();
    }
}
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp.Ejemplos;

internal class BuscarClientesProveedoresDtoConRepositorio : IBuscarClientesProveedores
{
    private readonly ClienteProveedorSqlRepository<ClienteDto> _clienteProveedorRepository;
    private readonly ILogger<BuscarClientesProveedoresDtoConRepositorio> _logger;

    public BuscarClientesProveedoresDtoConRepositorio(ClienteProveedorSqlRepository<ClienteDto> clienteProveedorRepository,
        ILogger<BuscarClientesProveedoresDtoConRepositorio> logger)
    {
        _clienteProveedorRepository = clienteProveedorRepository;
        _logger = logger;
    }

    public void BuscarPorCodigo(string codigoCliente)
    {
        ClienteDto? clienteProveedor = _clienteProveedorRepository.BuscarPorCodigo(codigoCliente);

        _logger.LogInformation("{@Cliente}", clienteProveedor);
    }

    public void BuscarPorId(int idCliente)
    {
        ClienteDto? clienteProveedor = _clienteProveedorRepository.BuscarPorId(idCliente);

        _logger.LogInformation("{@Cliente}", clienteProveedor);
    }

    public void TraerClientes()
    {
        List<ClienteDto> clientes = _clienteProveedorRepository.TraerClientes();

        _logger.LogInformation("{@Clientes}", clientes);
    }

    public void TraerPorTipo(TipoCliente tipoCliente)
    {
        List<ClienteDto> clientesProveedores = _clienteProveedorRepository.TraerPorTipo(tipoCliente);

        _logger.LogInformation("{@Clientes}", clientesProveedores);
    }

    public void TraerProveedores()
    {
        List<ClienteDto> proveedores = _clienteProveedorRepository.TraerProveedores();

        _logger.LogInformation("{@Clientes}", proveedores);
    }

    public void TraerTodo()
    {
        List<ClienteDto> clientesProveedores = _clienteProveedorRepository.TraerTodo();

        _logger.LogInformation("{@Clientes}", clientesProveedores);
    }

    public void CorrerEjemplos()
    {
        BuscarPorCodigo("01");

        BuscarPorId(1);

        TraerClientes();

        TraerPorTipo(TipoCliente.ClienteProveedor);

        TraerProveedores();

        TraerTodo();
    }
}
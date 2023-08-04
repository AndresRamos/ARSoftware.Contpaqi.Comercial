using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

internal class BuscarClientesProveedoresDtoConRepositorio : IBuscarClientesProveedores
{
    private readonly IClienteProveedorRepository<ClienteProveedorDto> _clienteProveedorRepository;
    private readonly ILogger<BuscarClientesProveedoresDtoConRepositorio> _logger;

    public BuscarClientesProveedoresDtoConRepositorio(IClienteProveedorRepository<ClienteProveedorDto> clienteProveedorRepository,
        ILogger<BuscarClientesProveedoresDtoConRepositorio> logger)
    {
        _clienteProveedorRepository = clienteProveedorRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorCodigo()
    {
        var codigoCliente = "PRUEBA";

        ClienteProveedorDto? clienteProveedor = _clienteProveedorRepository.BuscarPorCodigo(codigoCliente);

        _logger.LogInformation("{@Cliente}", clienteProveedor);
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idCliente = 1;

        ClienteProveedorDto? clienteProveedor = _clienteProveedorRepository.BuscarPorId(idCliente);

        _logger.LogInformation("{@Cliente}", clienteProveedor);
    }

    /// <inheritdoc />
    public void TraerClientes()
    {
        List<ClienteProveedorDto> clientes = _clienteProveedorRepository.TraerClientes();

        _logger.LogInformation("{@Clientes}", clientes);
    }

    /// <inheritdoc />
    public void TraerPorTipo()
    {
        var tipoCliente = TipoCliente.Cliente;

        List<ClienteProveedorDto> clientesProveedores = _clienteProveedorRepository.TraerPorTipo(tipoCliente);

        _logger.LogInformation("{@Clientes}", clientesProveedores);
    }

    /// <inheritdoc />
    public void TraerProveedores()
    {
        List<ClienteProveedorDto> proveedores = _clienteProveedorRepository.TraerProveedores();

        _logger.LogInformation("{@Clientes}", proveedores);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<ClienteProveedorDto> clientesProveedores = _clienteProveedorRepository.TraerTodo();

        _logger.LogInformation("{@Clientes}", clientesProveedores);
    }
}

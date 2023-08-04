using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sdk.Extras.ConsoleApp;

public class BuscarClientesDtoConRepositorio : IBuscarClientesProveedores
{
    private readonly IClienteProveedorRepository<ClienteProveedorDto> _clienteProveedorRepository;
    private readonly ILogger<BuscarClientesDtoConRepositorio> _logger;

    public BuscarClientesDtoConRepositorio(IClienteProveedorRepository<ClienteProveedorDto> clienteProveedorRepository,
        ILogger<BuscarClientesDtoConRepositorio> logger)
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

        List<ClienteProveedorDto> clientes = _clienteProveedorRepository.TraerPorTipo(tipoCliente);

        _logger.LogInformation("{@Clientes}", clientes);
    }

    /// <inheritdoc />
    public void TraerProveedores()
    {
        List<ClienteProveedorDto> clientes = _clienteProveedorRepository.TraerProveedores();

        _logger.LogInformation("{@Clientes}", clientes);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<ClienteProveedorDto> clientes = _clienteProveedorRepository.TraerTodo();

        _logger.LogInformation("{@Clientes}", clientes);
    }
}

using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sdk.Extras.ConsoleApp;

public class BuscarClientesConRepositorio : IBuscarClientesProveedores
{
    private readonly IClienteProveedorRepository<admClientes> _clienteProveedorRepository;
    private readonly ILogger<BuscarClientesConRepositorio> _logger;

    public BuscarClientesConRepositorio(IClienteProveedorRepository<admClientes> clienteProveedorRepository,
        ILogger<BuscarClientesConRepositorio> logger)
    {
        _clienteProveedorRepository = clienteProveedorRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorCodigo()
    {
        var codigoCliente = "PRUEBA";

        admClientes? clienteProveedor = _clienteProveedorRepository.BuscarPorCodigo(codigoCliente);

        _logger.LogInformation("{@Cliente}", clienteProveedor);
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idCliente = 1;

        admClientes? clienteProveedor = _clienteProveedorRepository.BuscarPorId(idCliente);

        _logger.LogInformation("{@Cliente}", clienteProveedor);
    }

    /// <inheritdoc />
    public void TraerClientes()
    {
        List<admClientes> clientes = _clienteProveedorRepository.TraerClientes();

        _logger.LogInformation("{@Clientes}", clientes);
    }

    /// <inheritdoc />
    public void TraerPorTipo()
    {
        var tipoCliente = TipoCliente.Cliente;
        List<admClientes> clientes = _clienteProveedorRepository.TraerPorTipo(tipoCliente);

        _logger.LogInformation("{@Clientes}", clientes);
    }

    /// <inheritdoc />
    public void TraerProveedores()
    {
        List<admClientes> clientes = _clienteProveedorRepository.TraerProveedores();

        _logger.LogInformation("{@Clientes}", clientes);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<admClientes> clientes = _clienteProveedorRepository.TraerTodo();

        _logger.LogInformation("{@Clientes}", clientes);
    }
}

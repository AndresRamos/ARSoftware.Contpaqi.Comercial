using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

internal class BuscarClientesProveedoresConRepositorio : IBuscarClientesProveedores
{
    private readonly ClienteProveedorSqlRepository _clienteProveedorRepository;
    private readonly ILogger<BuscarClientesProveedoresConRepositorio> _logger;

    public BuscarClientesProveedoresConRepositorio(ClienteProveedorSqlRepository clienteProveedorRepository,
        ILogger<BuscarClientesProveedoresConRepositorio> logger)
    {
        _clienteProveedorRepository = clienteProveedorRepository;
        _logger = logger;
    }

    public void BuscarPorCodigo(string codigoCliente)
    {
        admClientes? clienteProveedor = _clienteProveedorRepository.BuscarPorCodigo(codigoCliente);

        _logger.LogInformation("{@Cliente}", clienteProveedor);
    }

    public void BuscarPorId(int idCliente)
    {
        admClientes? clienteProveedor = _clienteProveedorRepository.BuscarPorId(idCliente);

        _logger.LogInformation("{@Cliente}", clienteProveedor);
    }

    public void TraerClientes()
    {
        List<admClientes> clientes = _clienteProveedorRepository.TraerClientes();

        _logger.LogInformation("{@Clientes}", clientes);
    }

    public void TraerPorTipo(TipoCliente tipoCliente)
    {
        List<admClientes> clientesProveedores = _clienteProveedorRepository.TraerPorTipo(tipoCliente);

        _logger.LogInformation("{@Clientes}", clientesProveedores);
    }

    public void TraerProveedores()
    {
        List<admClientes> proveedores = _clienteProveedorRepository.TraerProveedores();

        _logger.LogInformation("{@Proveedores}", proveedores);
    }

    public void TraerTodo()
    {
        List<admClientes> clientesProveedores = _clienteProveedorRepository.TraerTodo();

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
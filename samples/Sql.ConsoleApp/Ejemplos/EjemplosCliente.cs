using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

internal class EjemplosCliente
{
    private readonly IClienteProveedorRepository<admClientes> _clienteProveedorRepository;
    private readonly ILogger<EjemplosCliente> _logger;

    public EjemplosCliente(IClienteProveedorRepository<admClientes> clienteProveedorRepository, ILogger<EjemplosCliente> logger)
    {
        _clienteProveedorRepository = clienteProveedorRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de clientes.");

        BuscarPorCodigo("01");

        BuscarPorId(1);

        TraerClientes();

        TraerPorTipo(TipoCliente.ClienteProveedor);

        TraerProveedores();

        TraerTodo();
    }

    private void BuscarPorCodigo(string codigo)
    {
        _logger.LogInformation("Buscando cliente con Codigo: {Codigo}", codigo);

        long startTime = Stopwatch.GetTimestamp();

        admClientes? clienteProveedor = _clienteProveedorRepository.BuscarPorCodigo(codigo);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (clienteProveedor is not null)
            LogCliente(clienteProveedor);
        else
            _logger.LogInformation("No se encontro el cliente con codigo: {Codigo}", codigo);
    }

    private void BuscarPorId(int id)
    {
        _logger.LogInformation("Buscando cliente con Id: {Id}", id);

        long startTime = Stopwatch.GetTimestamp();

        admClientes? clienteProveedor = _clienteProveedorRepository.BuscarPorId(id);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (clienteProveedor is not null)
            LogCliente(clienteProveedor);
        else
            _logger.LogInformation("No se encontro el cliente con id: {Id}", id);
    }

    private void TraerClientes()
    {
        _logger.LogInformation("Buscando clientes.");

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admClientes> clientes = _clienteProveedorRepository.TraerClientes();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admClientes clienteProveedor in clientes) LogCliente(clienteProveedor);
    }

    private void TraerPorTipo(TipoCliente tipoCliente)
    {
        _logger.LogInformation("Buscando clientes con Tipo: {TipoCliente}", tipoCliente);

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admClientes> clientes = _clienteProveedorRepository.TraerPorTipo(tipoCliente);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admClientes clienteProveedor in clientes) LogCliente(clienteProveedor);
    }

    private void TraerProveedores()
    {
        _logger.LogInformation("Buscando proveedores.");

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admClientes> proveedores = _clienteProveedorRepository.TraerProveedores();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admClientes proveedor in proveedores) LogCliente(proveedor);
    }

    private void TraerTodo()
    {
        _logger.LogInformation("Buscando clientes y proveedores.");

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admClientes> clientesProveedores = _clienteProveedorRepository.TraerTodo();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admClientes clienteProveedor in clientesProveedores) LogCliente(clienteProveedor);
    }

    private void LogCliente(admClientes clienteProveedor)
    {
        _logger.LogInformation(
            "Id: {Id}, Codigo: {Codigo}, Razon Social: {RazonSocial}, RFC: {Rfc}, Tipo: {Tipo}, Uso CFDI: {UsoCfdi}, Regimen Fiscal: {RegimenFiscal}",
            clienteProveedor.CIDCLIENTEPROVEEDOR, clienteProveedor.CCODIGOCLIENTE, clienteProveedor.CRAZONSOCIAL, clienteProveedor.CRFC,
            clienteProveedor.CTIPOCLIENTE, clienteProveedor.CUSOCFDI, clienteProveedor.CREGIMFISC);
    }
}
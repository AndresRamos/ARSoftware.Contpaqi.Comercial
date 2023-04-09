using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Sdk.Extras.ConsoleApp.Dtos;

namespace Sdk.Extras.ConsoleApp.Ejemplos;

public sealed class EjemplosCliente
{
    private const string CodigoPruebas = "CTEPRUEBAS";
    private const string RazonSocialPruebas = "CLIENTE DE PRUEBAS";
    private const string RfcPruebas = "XAXX010101000";
    private const string UsoCfdiPruebas = "G01";
    private const string RegimenFiscalPruebas = "616";
    private readonly IClienteProveedorRepository<ClienteDto> _clienteProveedorDtoRepository;
    private readonly IClienteProveedorRepository<ClienteProveedor> _clienteProveedorRepository;
    private readonly IClienteProveedorService _clienteProveedorService;
    private readonly ILogger<EjemplosCliente> _logger;

    public EjemplosCliente(IClienteProveedorRepository<ClienteProveedor> clienteProveedorRepository,
                           ILogger<EjemplosCliente> logger,
                           IClienteProveedorService clienteProveedorService,
                           IClienteProveedorRepository<ClienteDto> clienteProveedorDtoRepository)
    {
        _clienteProveedorRepository = clienteProveedorRepository;
        _logger = logger;
        _clienteProveedorService = clienteProveedorService;
        _clienteProveedorDtoRepository = clienteProveedorDtoRepository;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo pruebas de clientes.");

        int clienteId = CrearClientePrueba();

        BuscarClientePorId(clienteId);

        ModificarClientePrueba();

        BuscarClientePorCodigo(CodigoPruebas);

        BuscarTodosLosClientes();

        BuscarTodosLosClientesUtilizandoDto();

        BuscarClientesPorTipo(TipoCliente.Cliente);

        BuscarSoloClientes();

        BuscarSoloProveedores();

        EliminiarClientePrueba();
    }

    private void BuscarClientePorId(int clienteId)
    {
        _logger.LogInformation("Buscando cliente por id: {ClienteId}", clienteId);
        long startTime = Stopwatch.GetTimestamp();
        ClienteProveedor? cliente = _clienteProveedorRepository.BuscarPorId(clienteId);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        if (cliente is not null)
            LogCliente(cliente);
        else
            _logger.LogWarning("No se encontro el cliente con id {ClienteId}", clienteId);
    }

    private void BuscarClientePorCodigo(string clienteCodigo)
    {
        _logger.LogInformation("Buscando cliente por codigo: {ClienteCodigo}", clienteCodigo);
        long startTime = Stopwatch.GetTimestamp();
        ClienteProveedor? cliente = _clienteProveedorRepository.BuscarPorCodigo(clienteCodigo);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        if (cliente is not null)
            LogCliente(cliente);
        else
            _logger.LogWarning("No se encontro el cliente con codigo {ClienteCodigo}", clienteCodigo);
    }

    private void BuscarClientesPorTipo(TipoCliente tipoCliente)
    {
        _logger.LogInformation("Buscando por tipo {TipoCliente}", tipoCliente);
        long startTime = Stopwatch.GetTimestamp();
        List<ClienteProveedor> clientes = _clienteProveedorRepository.TraerPorTipo(tipoCliente).ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroClientes} clientes.", clientes.Count);
        foreach (ClienteProveedor cliente in clientes)
            LogCliente(cliente);
    }

    private void BuscarTodosLosClientes()
    {
        _logger.LogInformation("Buscando todos los clientes.");
        long startTime = Stopwatch.GetTimestamp();
        List<ClienteProveedor> clientes = _clienteProveedorRepository.TraerTodo().ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroClientes} clientes.", clientes.Count);
        foreach (ClienteProveedor cliente in clientes)
            LogCliente(cliente);
    }

    private void BuscarTodosLosClientesUtilizandoDto()
    {
        _logger.LogInformation("Buscando todos los clientes utilizando un DTO.");
        long startTime = Stopwatch.GetTimestamp();
        List<ClienteDto> clientes = _clienteProveedorDtoRepository.TraerTodo().ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroClientes} clientes.", clientes.Count);
        foreach (ClienteDto cliente in clientes)
            LogCliente(cliente);
    }

    private void BuscarSoloClientes()
    {
        _logger.LogInformation("Buscando solo clientes.");
        long startTime = Stopwatch.GetTimestamp();
        List<ClienteProveedor> clientes = _clienteProveedorRepository.TraerClientes().ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroClientes} clientes.", clientes.Count);
        foreach (ClienteProveedor cliente in clientes)
            LogCliente(cliente);
    }

    private void BuscarSoloProveedores()
    {
        _logger.LogInformation("Buscando solo proveedores.");
        long startTime = Stopwatch.GetTimestamp();
        List<ClienteProveedor> proveedores = _clienteProveedorRepository.TraerProveedores().ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroClientes} proveedores.", proveedores.Count);
        foreach (ClienteProveedor cliente in proveedores)
            LogCliente(cliente);
    }

    private int CrearClientePrueba()
    {
        _logger.LogInformation("Creando cliente.");
        var cliente = new ClienteProveedor();
        cliente.CCODIGOCLIENTE = CodigoPruebas;
        cliente.CRAZONSOCIAL = RazonSocialPruebas;
        cliente.CRFC = RfcPruebas;
        tCteProv clienteSdk = cliente.ToTCteProv();
        long startTime = Stopwatch.GetTimestamp();
        int clienteId = _clienteProveedorService.Crear(clienteSdk);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        return clienteId;
    }

    private void ModificarClientePrueba()
    {
        _logger.LogInformation("Modificando cliente.");
        var datosCliente = new Dictionary<string, string>
        {
            { nameof(admClientes.CRAZONSOCIAL), RazonSocialPruebas },
            { nameof(admClientes.CUSOCFDI), UsoCfdiPruebas },
            { nameof(admClientes.CREGIMFISC), RegimenFiscalPruebas }
        };

        long startTime = Stopwatch.GetTimestamp();
        _clienteProveedorService.Actualizar(CodigoPruebas, datosCliente);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
    }

    private void EliminiarClientePrueba()
    {
        _logger.LogInformation("Eliminando cliente.");
        long startTime = Stopwatch.GetTimestamp();
        _clienteProveedorService.Eliminar(CodigoPruebas);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
    }

    private void LogCliente(ClienteProveedor clienteProveedor)
    {
        _logger.LogInformation(
            "Id: {Id}, Codigo: {Codigo}, Razon Social: {RazonSocial}, RFC: {Rfc}, Tipo: {Tipo}, Uso CFDI: {UsoCfdi}, Regimen Fiscal: {RegimenFiscal}",
            clienteProveedor.CIDCLIENTEPROVEEDOR,
            clienteProveedor.CCODIGOCLIENTE,
            clienteProveedor.CRAZONSOCIAL,
            clienteProveedor.CRFC,
            clienteProveedor.Tipo,
            clienteProveedor.CUSOCFDI,
            clienteProveedor.CREGIMFISC);
    }

    private void LogCliente(ClienteDto clienteProveedor)
    {
        _logger.LogInformation(
            "Id: {Id}, Codigo: {Codigo}, Razon Social: {RazonSocial}, RFC: {Rfc}, Tipo: {Tipo}, Uso CFDI: {UsoCfdi}, Regimen Fiscal: {RegimenFiscal}",
            clienteProveedor.CIDCLIENTEPROVEEDOR,
            clienteProveedor.CCODIGOCLIENTE,
            clienteProveedor.CRAZONSOCIAL,
            clienteProveedor.CRFC,
            clienteProveedor.CTIPOCLIENTE,
            clienteProveedor.CUSOCFDI,
            clienteProveedor.CREGIMFISC);
    }
}

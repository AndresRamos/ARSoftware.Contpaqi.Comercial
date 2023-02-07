using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sdk.Extras.ConsoleApp.Catalogos;

public sealed class ClienteSdk
{
    private readonly IClienteProveedorRepository<ClienteProveedor> _clienteProveedorRepository;
    private readonly IClienteProveedorService _clienteProveedorService;
    private readonly ILogger<ClienteSdk> _logger;

    public ClienteSdk(IClienteProveedorRepository<ClienteProveedor> clienteProveedorRepository,
                      ILogger<ClienteSdk> logger,
                      IClienteProveedorService clienteProveedorService)
    {
        _clienteProveedorRepository = clienteProveedorRepository;
        _logger = logger;
        _clienteProveedorService = clienteProveedorService;
    }

    public IEnumerable<ClienteProveedor> BuscarTodo()
    {
        _logger.LogInformation("BuscarTodo()");
        return _clienteProveedorRepository.TraerTodo().ToList();
    }

    public IEnumerable<ClienteProveedor> BuscarClientes()
    {
        _logger.LogInformation("BuscarClientes()");
        return _clienteProveedorRepository.TraerClientes().ToList();
    }

    public IEnumerable<ClienteProveedor> BuscarProveedores()
    {
        _logger.LogInformation("BuscarProveedores()");
        return _clienteProveedorRepository.TraerProveedores().ToList();
    }

    public IEnumerable<ClienteProveedor> BuscarPorTipo(TipoCliente tipoCliente)
    {
        _logger.LogInformation("BuscarPorTipo({Tipo})", tipoCliente);
        return _clienteProveedorRepository.TraerPorTipo(tipoCliente).ToList();
    }

    public ClienteProveedor BuscarPorId(int clienteId)
    {
        _logger.LogInformation("BuscarPorId({clienteId})", clienteId);
        return _clienteProveedorRepository.BuscarPorId(clienteId);
    }

    public ClienteProveedor BuscarPorCodigo(string clienteCodigo)
    {
        _logger.LogInformation("BuscarPorCodigo({clienteCodigo})", clienteCodigo);
        return _clienteProveedorRepository.BuscarPorCodigo(clienteCodigo);
    }

    public int CrearClientePrueba()
    {
        _logger.LogInformation("CrearClientePrueba()");
        var clientePrueba = new ClienteProveedor();
        clientePrueba.CCODIGOCLIENTE = "CTEPRUEBAS";
        clientePrueba.CRAZONSOCIAL = "CLIENTE PRUEBAS";
        clientePrueba.CRFC = "AAA010101AAA";

        int idClienteNuevo = _clienteProveedorService.Crear(clientePrueba.ToTCteProv());
        return idClienteNuevo;
    }

    public void ModificarClientePrueba()
    {
        _logger.LogInformation("ModificarClientePrueba()");
        var datosCliente = new Dictionary<string, string>
        {
            { nameof(admClientes.CRAZONSOCIAL), "CLIENTE DE PRUEBAS COMERCIAL" },
            { nameof(admClientes.CUSOCFDI), "G01" },
            { nameof(admClientes.CREGIMFISC), "616" }
        };

        _clienteProveedorService.Actualizar("CTEPRUEBAS", datosCliente);
    }

    public void EliminiarClientePrueba()
    {
        _logger.LogInformation("EliminiarClientePrueba()");
        _clienteProveedorService.Eliminar("CTEPRUEBAS");
    }

    public void LogClientes(IEnumerable<ClienteProveedor> clientes)
    {
        _logger.LogInformation("CLIENTES");
        foreach (ClienteProveedor clienteProveedor in clientes)
            LogCliente(clienteProveedor);
    }

    public void LogCliente(ClienteProveedor clienteProveedor)
    {
        _logger.LogInformation("    {Codigo} - {RazonSocial} - {RFC} - {Tipo} - {UsoCfdi} - {RegimenFiscal}",
            clienteProveedor.CCODIGOCLIENTE,
            clienteProveedor.CRAZONSOCIAL,
            clienteProveedor.CRFC,
            clienteProveedor.Tipo,
            clienteProveedor.CUSOCFDI,
            clienteProveedor.CREGIMFISC);
    }
}

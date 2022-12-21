using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
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

    public List<ClienteProveedor> BuscarTodo()
    {
        _logger.LogInformation("Buscando todos los clientes.");
        List<ClienteProveedor> clientes = _clienteProveedorRepository.TraerTodo().ToList();

        foreach (ClienteProveedor cliente in clientes)
            Log(cliente);

        return clientes;
    }

    public ClienteProveedor? BuscarPorId(int clienteId)
    {
        _logger.LogInformation("Buscando cliente por id. Id:[{ClienteId}]", clienteId);
        ClienteProveedor? cliente = _clienteProveedorRepository.BuscarPorId(clienteId);
        Log(cliente);
        return cliente;
    }

    public ClienteProveedor BuscarPorCodigo(string clienteCodigo)
    {
        _logger.LogInformation("Buscando cliente por codigo. Codigo:[{ClienteCodigo}]", clienteCodigo);
        ClienteProveedor? cliente = _clienteProveedorRepository.BuscarPorCodigo(clienteCodigo);
        Log(cliente);
        return cliente;
    }

    public int Crear()
    {
        var clienteNuevo = new ClienteProveedor();
        clienteNuevo.CCODIGOCLIENTE = "PRUEBA01";
        clienteNuevo.CRAZONSOCIAL = "CLIENTE PRUEBA 01";
        clienteNuevo.CRFC = "XAXX010101000";
        clienteNuevo.Tipo = TipoCliente.ClienteProveedor;

        tCteProv clienteSdk = clienteNuevo.ToTCteProv();

        _logger.LogInformation("Creando cliente {@Cliente}.", clienteSdk);
        int id = _clienteProveedorService.Crear(clienteSdk);
        _logger.LogInformation("Cliente creado.");

        return id;
    }

    public void Modificar(int idCliente)
    {
        _logger.LogInformation("Modificando cliente.");
        var datosCliente = new Dictionary<string, string>
        {
            { "CRAZONSOCIAL", "CLIENTE PRUEBA 2" }, { "CUSOCFDI", "G03" }, { "CREGIMFISC", "601" }
        };

        _logger.LogInformation("Modificando cliente. Datos: {@DatosCliente}", datosCliente);
        _clienteProveedorService.Actualizar(idCliente, datosCliente);
        _logger.LogInformation("Cliente actualizado.");
    }

    public void Eliminar(int idCliente)
    {
        _logger.LogInformation("Eliminando cliente.");
        _clienteProveedorService.Eliminar(idCliente);
        _logger.LogInformation("Cliente eliminado.");
    }

    private void Log(ClienteProveedor cliente)
    {
        _logger.LogInformation("Id:[{Id}] Codigo:[{Codigo}] Nombre:[{RazonSocial}] RFC:[{CRFC}] Tipo:[{Tipo}] Uso:[{Uso}]",
            cliente.CIDCLIENTEPROVEEDOR,
            cliente.CCODIGOCLIENTE,
            cliente.CRAZONSOCIAL,
            cliente.CRFC,
            cliente.Tipo,
            cliente.CUSOCFDI);
    }
}





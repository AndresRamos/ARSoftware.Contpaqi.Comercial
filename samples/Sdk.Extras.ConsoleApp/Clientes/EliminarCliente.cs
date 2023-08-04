using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp;

public class EliminarCliente
{
    private readonly IClienteProveedorService _clienteProveedorService;

    public EliminarCliente(IClienteProveedorService clienteProveedorService)
    {
        _clienteProveedorService = clienteProveedorService;
    }

    public void Eliminar()
    {
        var codigoCliente = "PRUEBA";

        _clienteProveedorService.Eliminar(codigoCliente);
    }
}

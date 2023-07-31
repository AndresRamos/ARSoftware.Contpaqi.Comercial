using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.ConsoleApp;

public class EditarCliente
{
    private readonly IClienteProveedorService _clienteProveedorService;

    public EditarCliente(IClienteProveedorService clienteProveedorService)
    {
        _clienteProveedorService = clienteProveedorService;
    }

    public void Editar()
    {
        var codigoCliente = "PRUEBA";

        var datosCliente = new Dictionary<string, string>
        {
            { nameof(admClientes.CRAZONSOCIAL), "CLIENTE DE PRUEBAS MODIFICADO" },
            { nameof(admClientes.CTEXTOEXTRA1), "Texto Modificado" },
            { nameof(admClientes.CTEXTOEXTRA2), "Texto Extra 2" }
        };

        _clienteProveedorService.Actualizar(codigoCliente, datosCliente);
    }
}

using Sdk.ConsoleApp.Catalogos;

namespace Sdk.ConsoleApp.Pruebas;

public sealed class ClientePrueba
{
    public static void ActualizaClientePrueba()
    {
        ClienteSdk cliente = ClienteSdk.BuscarClientePorCodigo("CTEPRUEBA01");

        cliente.RazonSocial = "CLIENTE PRUEBA MODIFICADO";
        cliente.Rfc = "AAA010101AAA";

        ClienteSdk.ActualizarCliente(cliente);
    }

    public static int CrearClientePrueba()
    {
        var clientePrueba = new ClienteSdk { Codigo = "CTEPRUEBA01", RazonSocial = "CLIENTE PRUEBA 01", Tipo = 1 };

        int nuevoClienteId = ClienteSdk.CrearCliente(clientePrueba);

        return nuevoClienteId;
    }

    public static void EliminarClientePrueba()
    {
        ClienteSdk cliente = ClienteSdk.BuscarClientePorCodigo("CTEPRUEBA01");

        ClienteSdk.EliminarCliente(cliente);
    }
}

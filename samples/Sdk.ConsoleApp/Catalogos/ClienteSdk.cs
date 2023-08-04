using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extensiones;

namespace Sdk.ConsoleApp.Catalogos;

/// <summary>
///     Tabla admClientes - Tabla de Clientes y Proveedores
/// </summary>
public sealed class ClienteSdk
{
    /// <summary>
    ///     Campo CCODIGOCLIENTE - Código del cliente o proveedor.
    /// </summary>
    public string Codigo { get; set; }

    /// <summary>
    ///     Campo CIDCLIENTEPROVEEDOR - Identificador del cliente o proveedor.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Campo CRAZONSOCIAL - Razón Social del cliente o proveedor.
    /// </summary>
    public string RazonSocial { get; set; }

    /// <summary>
    ///     Campo CRFC - Registro Federal de Contribuyentes del cliente.
    /// </summary>
    public string Rfc { get; set; }

    /// <summary>
    ///     Campo CTIPOCLIENTE - Tipo de cliente o proveedor: 1 = Cliente 2 = Cliente/Proveedor 3 = Proveedor
    /// </summary>
    public int Tipo { get; set; }

    /// <summary>
    ///     Actualiza un cliente.
    /// </summary>
    /// <param name="cliente">Cliente del que se asignaran los datos a modificar.</param>
    public static void ActualizarCliente(ClienteSdk cliente)
    {
        // Buscar el cliente por código
        // Si el cliente existe el SDK se posiciona en el registro
        ComercialSdk.fBuscaCteProv(cliente.Codigo).TirarSiEsError();

        // Activar el modo de edición
        ComercialSdk.fEditaCteProv().TirarSiEsError();

        // Actualizar los campos del registro donde el SDK esta posicionado
        ComercialSdk.fSetDatoCteProv("CRAZONSOCIAL", cliente.RazonSocial).TirarSiEsError();
        ComercialSdk.fSetDatoCteProv("CRFC", cliente.Rfc).TirarSiEsError();

        // Guardar los cambios realizados al registro
        ComercialSdk.fGuardaCteProv().TirarSiEsError();
    }

    /// <summary>
    ///     Busca un cliente por código.
    /// </summary>
    /// <param name="clienteCodigo">El código del cliente a buscar.</param>
    /// <returns>El cliente a buscar.</returns>
    public static ClienteSdk BuscarClientePorCodigo(string clienteCodigo)
    {
        // Buscar el cliente por código
        // Si el cliente existe el SDK se posiciona en el registro
        ComercialSdk.fBuscaCteProv(clienteCodigo).TirarSiEsError();

        // Leer los datos del registro donde el SDK esta posicionado
        return LeerDatosCliente();
    }

    /// <summary>
    ///     Busca un cliente por id.
    /// </summary>
    /// <param name="clienteId">El id del cliente a buscar.</param>
    /// <returns>El cliente a buscar.</returns>
    public static ClienteSdk BuscarClientePorId(int clienteId)
    {
        // Buscar el cliente por id
        // Si el cliente existe el SDK se posiciona en el registro
        ComercialSdk.fBuscaIdCteProv(clienteId).TirarSiEsError();

        // Leer los datos del registro donde el SDK esta posicionado
        return LeerDatosCliente();
    }

    /// <summary>
    ///     Busca todos los clientes.
    /// </summary>
    /// <returns>La lista de clientes.</returns>
    public static List<ClienteSdk> BuscarClientes()
    {
        var clientesList = new List<ClienteSdk>();

        // Posicionar el SDK en el primer registro
        int resultado = ComercialSdk.fPosPrimerCteProv();
        if (resultado == SdkConstantes.CodigoExito)
            // Leer los datos del registro donde el SDK esta posicionado
            clientesList.Add(LeerDatosCliente());
        else
            return clientesList;

        // Crear un loop y posicionar el SDK en el siguiente registro
        while (ComercialSdk.fPosSiguienteCteProv() == SdkConstantes.CodigoExito)
        {
            // Leer los datos del registro donde el SDK esta posicionado
            clientesList.Add(LeerDatosCliente());

            // Checar si el SDK esta posicionado en el ultimo registro
            // Si el SDK esta posicionado en el ultimo registro salir del loop
            if (ComercialSdk.fPosEOFCteProv() == 1) break;
        }

        return clientesList;
    }

    /// <summary>
    ///     Crea un cliente nuevo.
    /// </summary>
    /// <param name="cliente">Cliente del cual se asignaran los datos.</param>
    /// <returns>El id del cliente creado.</returns>
    public static int CrearCliente(ClienteSdk cliente)
    {
        // Instanciar un cliente con la estructura tCteProv del SDK
        var clienteNuevo = new tCteProv
        {
            cCodigoCliente = cliente.Codigo,
            cRazonSocial = cliente.RazonSocial,
            cRFC = cliente.Rfc,
            cTipoCliente = cliente.Tipo,
            cFechaAlta = DateTime.Today.ToString(FormatosFechaSdk.Fecha),
            cEstatus = 1
        };

        // Declarar una variable donde se asignara el id del cliente nuevo
        var clienteNuevoId = 0;

        // Crear cliente nuevo
        ComercialSdk.fAltaCteProv(ref clienteNuevoId, ref clienteNuevo).TirarSiEsError();

        return clienteNuevoId;
    }

    /// <summary>
    ///     Elimina un cliente.
    /// </summary>
    /// <param name="cliente">El cliente a eliminar.</param>
    public static void EliminarCliente(ClienteSdk cliente)
    {
        // Buscar el cliente por código
        // Si el cliente existe el SDK se posiciona en el registro
        ComercialSdk.fBuscaCteProv(cliente.Codigo).TirarSiEsError();

        // Borrar el registro de la base de datos 
        ComercialSdk.fBorraCteProv().TirarSiEsError();
    }

    /// <summary>
    ///     Lee los datos del cliente donde el SDK esta posicionado.
    /// </summary>
    /// <returns>Regresa un cliente con los sus datos asignados.</returns>
    private static ClienteSdk LeerDatosCliente()
    {
        // Declarar variables a leer de la base de datos
        var idBd = new StringBuilder(3000);
        var codigoBd = new StringBuilder(3000);
        var razonSocialBd = new StringBuilder(3000);
        var rfcBd = new StringBuilder(3000);
        var tipoBd = new StringBuilder(3000);

        // Leer los datos del registro donde el SDK esta posicionado
        ComercialSdk.fLeeDatoCteProv("CIDCLIENTEPROVEEDOR", idBd, 3000).TirarSiEsError();
        ComercialSdk.fLeeDatoCteProv("CCODIGOCLIENTE", codigoBd, 3000).TirarSiEsError();
        ComercialSdk.fLeeDatoCteProv("CRAZONSOCIAL", razonSocialBd, 3000).TirarSiEsError();
        ComercialSdk.fLeeDatoCteProv("CRFC", rfcBd, 3000).TirarSiEsError();
        ComercialSdk.fLeeDatoCteProv("CTIPOCLIENTE", tipoBd, 3000).TirarSiEsError();

        // Instanciar un cliente y asignar los datos de la base de datos
        return new ClienteSdk
        {
            Id = int.Parse(idBd.ToString()),
            Codigo = codigoBd.ToString(),
            RazonSocial = razonSocialBd.ToString(),
            Rfc = rfcBd.ToString(),
            Tipo = int.Parse(tipoBd.ToString())
        };
    }

    public override string ToString()
    {
        return $"{Id} - {Codigo} - {RazonSocial} - {Rfc} - {Tipo}";
    }
}

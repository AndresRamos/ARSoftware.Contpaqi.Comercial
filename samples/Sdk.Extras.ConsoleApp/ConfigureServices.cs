using Microsoft.Extensions.DependencyInjection;

namespace Sdk.Extras.ConsoleApp;

public static class ConfigureServices
{
    public static IServiceCollection AddEjemplos(this IServiceCollection serviceCollection)
    {
        // Agentes
        serviceCollection.AddTransient<BuscarAgentesConRepositorio>();
        serviceCollection.AddTransient<BuscarAgentesDtoConRepositorio>();
        serviceCollection.AddTransient<CrearAgente>();
        serviceCollection.AddTransient<EditarAgente>();

        // Almacenes
        serviceCollection.AddTransient<BuscarAlmacenesConRepositorio>();
        serviceCollection.AddTransient<BuscarAlmacenesDtoConRepositorio>();
        serviceCollection.AddTransient<CrearAlmacen>();
        serviceCollection.AddTransient<EditarAlmacen>();

        // Clasificaciones
        serviceCollection.AddTransient<BuscarClasificacionesConRepositorio>();

        // Clientes
        serviceCollection.AddTransient<BuscarClientesConRepositorio>();
        serviceCollection.AddTransient<BuscarClientesDtoConRepositorio>();
        serviceCollection.AddTransient<CrearCliente>();
        serviceCollection.AddTransient<EditarCliente>();
        serviceCollection.AddTransient<EliminarCliente>();

        // Conceptos
        serviceCollection.AddTransient<BuscarConceptosDocumentoConRepositorio>();
        serviceCollection.AddTransient<BuscarConceptosDocumentoDtoConRepositorio>();

        // Documentos
        serviceCollection.AddTransient<BuscarDocumentosConRepositorio>();
        serviceCollection.AddTransient<BuscarDocumentosDtoConRepositorio>();
        serviceCollection.AddTransient<CancelarDocumento>();
        serviceCollection.AddTransient<CrearDocumentoCargoAbono>();
        serviceCollection.AddTransient<CrearFactura>();
        serviceCollection.AddTransient<EliminarDocumento>();
        serviceCollection.AddTransient<GenerarDocumentoDigitalDocumento>();
        serviceCollection.AddTransient<SaldarDocumento>();
        serviceCollection.AddTransient<TimbrarDocumento>();

        // Empresas
        serviceCollection.AddTransient<BuscarEmpresasConRepositorio>();
        serviceCollection.AddTransient<BuscarEmpresasDtoConRepositorio>();

        // Movimientos
        serviceCollection.AddTransient<BuscarMovimientosConRepositorio>();
        serviceCollection.AddTransient<BuscarMovimientosDtoConRepositorio>();
        serviceCollection.AddTransient<CrearMovimiento>();
        serviceCollection.AddTransient<EditarMovimiento>();
        serviceCollection.AddTransient<EliminarMovimiento>();

        // Parametros
        serviceCollection.AddTransient<BuscarParametrosConRepositorio>();
        serviceCollection.AddTransient<BuscarParametrosDtoConRepositorio>();

        // Productos
        serviceCollection.AddTransient<BuscarProductosConRepositorio>();
        serviceCollection.AddTransient<BuscarProductosDtoConRepositorio>();
        serviceCollection.AddTransient<CrearProducto>();
        serviceCollection.AddTransient<EditarProducto>();
        serviceCollection.AddTransient<EliminarProducto>();

        // Sesion
        serviceCollection.AddTransient<AbrirEmpresa>();
        serviceCollection.AddTransient<CerrarEmpresa>();
        serviceCollection.AddTransient<IniciarSesion>();
        serviceCollection.AddTransient<TerminasSesion>();

        // Unidades Medida
        serviceCollection.AddTransient<BuscarUnidadesMedidaConRepositorio>();
        serviceCollection.AddTransient<BuscarUnidadesMedidaDtoConRepositorio>();

        // Valores Clasificacion
        serviceCollection.AddTransient<BuscarValoresClasificacionConRepositorio>();

        return serviceCollection;
    }
}

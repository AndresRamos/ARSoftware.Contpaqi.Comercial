using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using Sql.ConsoleApp;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(services => { services.AddSqlServices(); })
    .ConfigureLogging(builder =>
    {
        //builder.SetMinimumLevel(LogLevel.Information);

        //builder.AddFilter("Microsoft", LogLevel.Warning);
        //builder.AddSimpleConsole(options => { options.SingleLine = true; });
        builder.ClearProviders();
    })
    .UseSerilog((hostingContext, loggerConfiguration) =>
    {
        loggerConfiguration.MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Information);
        loggerConfiguration.WriteTo.Console(LogEventLevel.Information);
        //loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration).Enrich.FromLogContext();
    })
    .Build();

await host.StartAsync();

var logger = host.Services.GetRequiredService<ILogger<Program>>();

try
{
    logger.LogInformation("Iniciando Programa");

    // Ejemplos del uso del SQL
    // Se pueden ejecutar de forma independiente. Descomenta los ejemplos que quieres ejecutar.

    // Buscar Empresas
    //host.Services.GetRequiredService<BuscarEmpresasConRepositorio>().CorrerEjemplos();
    //host.Services.GetRequiredService<BuscarEmpresasDtoConRepositorio>().CorrerEjemplos();

    // Buscar Agentes
    //host.Services.GetRequiredService<BuscarAgentesConRepositorio>().CorrerEjemplos();
    //host.Services.GetRequiredService<BuscarAgentesDtoConRepositorio>().CorrerEjemplos();

    // Buscar Almacenes
    //host.Services.GetRequiredService<BuscarAlmacenesConRepositorio>().CorrerEjemplos();
    //host.Services.GetRequiredService<BuscarAlmacenesDtoConRepositorio>().CorrerEjemplos();

    // Buscar Clasificaciones
    //host.Services.GetRequiredService<BuscarClasificacionesConRepositorio>().CorrerEjemplos();

    // Buscar Clientes Proveedores
    //host.Services.GetRequiredService<BuscarClientesProveedoresConRepositorio>().CorrerEjemplos();
    //host.Services.GetRequiredService<BuscarClientesProveedoresDtoConRepositorio>().CorrerEjemplos();

    // Buscar Conceptos Documento
    //host.Services.GetRequiredService<BuscarConceptosDocumentoConRepositorio>().CorrerEjemplos();
    //host.Services.GetRequiredService<BuscarConceptosDocumentoDtoConRepositorio>().CorrerEjemplos();

    // Buscar Documentos
    //host.Services.GetRequiredService<BuscarDocumentosConRepositorio>().CorrerEjemplos();
    //host.Services.GetRequiredService<BuscarDocumentosDtoConRepositorio>().CorrerEjemplos();

    // Buscar Documentos Modelo
    //host.Services.GetRequiredService<BuscarDocumentosModeloConRepositorio>().CorrerEjemplos();
    //host.Services.GetRequiredService<BuscarDocumentosModeloDtoConRepositorio>().CorrerEjemplos();

    // Buscar Monedas
    //host.Services.GetRequiredService<BuscarMonedasConRepositorio>().CorrerEjemplos();
    //host.Services.GetRequiredService<BuscarMonedasDtoConRepositorio>().CorrerEjemplos();

    // Buscar Movimientos
    //host.Services.GetRequiredService<BuscarMovimientosConRepositorio>().CorrerEjemplos();
    //host.Services.GetRequiredService<BuscarMovimientosDtoConRepositorio>().CorrerEjemplos();

    // Buscar Parametros
    //host.Services.GetRequiredService<BuscarParametrosConRepositorio>().CorrerEjemplos();
    //host.Services.GetRequiredService<BuscarParametrosDtoConRepositorio>().CorrerEjemplos();

    // Buscar Productos
    //host.Services.GetRequiredService<BuscarProductosConRepositorio>().CorrerEjemplos();
    //host.Services.GetRequiredService<BuscarProductosDtoConRepositorio>().CorrerEjemplos();

    // Buscar Unidades Medida
    //host.Services.GetRequiredService<BuscarUnidadesMedidaConRepositorio>().CorrerEjemplos();
    //host.Services.GetRequiredService<BuscarUnidadesMedidaDtoConRepositorio>().CorrerEjemplos();

    // Buscar Valores Clasificacion
    //host.Services.GetRequiredService<BuscarValoresClasificacionConRepositorio>().CorrerEjemplos();
}
catch (Exception e)
{
    logger.LogCritical(e, "Ocurrio un error");
}

await host.StopAsync();
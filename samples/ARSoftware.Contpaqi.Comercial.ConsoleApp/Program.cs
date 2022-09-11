using ARSoftware.Contpaqi.Comercial.ConsoleApp;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder(args)
                 .ConfigureServices(collection =>
                 {
                     // Agregar servicios del SDK
                     collection.AddSdkServices();
                 })
                 .Build();

await host.StartAsync();

try
{
    // Iniciar sesion
    Console.WriteLine("Iniciando sesion.");
    var comercialSdkSesionService = host.Services.GetRequiredService<IComercialSdkSesionService>();
    comercialSdkSesionService.IniciarSesionSdk("SUPERVISOR", "");

    // Buscar y seleccionar empresa
    Console.WriteLine("Buscando empresas.");
    var empresasRepository = host.Services.GetRequiredService<IEmpresaRepository<Empresa>>();
    List<Empresa> empresas = empresasRepository.TraerTodo().OrderBy(e => e.CNOMBREEMPRESA).ToList();

    Console.WriteLine("EMPRESAS:");
    foreach (Empresa empresa in empresas)
        Console.WriteLine($"ID:{empresa.CIDEMPRESA} NOMBRE:{empresa.CNOMBREEMPRESA} RUTA:{empresa.CRUTADATOS}");
    Console.Write("Seleccionar empresa ingresando el id: ");

    string? empresaIdInput = Console.ReadLine();
    bool parseResult = int.TryParse(empresaIdInput, out int empresaId);
    if (!parseResult)
        throw new InvalidOperationException("El id ingreso no es un numero valido.");

    Empresa? empresaSeleccionada = empresas.FirstOrDefault(e => e.CIDEMPRESA == empresaId);
    if (empresaSeleccionada is null)
        throw new InvalidOperationException("El id no pertenece a una empresa en la lista.");

    Console.WriteLine($"Empresa {empresaSeleccionada.CNOMBREEMPRESA} seleccionada.");

    // Abrir empresa
    Console.WriteLine("Abriendo empresa.");
    comercialSdkSesionService.AbrirEmpresa(empresaSeleccionada.CRUTADATOS);

    // Listar productos
    Console.WriteLine("Buscando productos.");
    var productoRepository = host.Services.GetRequiredService<IProductoRepository<Producto>>();

    Console.WriteLine("PRODUCTOS:");
    foreach (Producto producto in productoRepository.TraerTodo())
        Console.WriteLine($"ID:{producto.CIDPRODUCTO} CODIGO:{producto.CCODIGOPRODUCTO} NOMBRE:{producto.CNOMBREPRODUCTO}");

    // Cerrar empresa
    Console.WriteLine("Cerrando empresa.");
    comercialSdkSesionService.CerrarEmpresa();

    // Terminar session
    Console.WriteLine("Cerrando sesion.");
    comercialSdkSesionService.TerminarSesionSdk();
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}
finally
{
    await host.StopAsync();
}

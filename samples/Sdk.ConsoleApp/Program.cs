using Sdk.ConsoleApp;
using Sdk.ConsoleApp.Catalogos;

Console.WriteLine("CONTPAQi Comercial SDK");

try
{
    // 1. Inicializar el SDK
    Console.WriteLine("Iniciando SDK.");
    ConexionSdk.IniciarSdk("SUPERVISOR", "");

    // 2. Abrir empresa

    // Buscar empresas
    Console.WriteLine("Buscando empresas.");
    List<EmpresaSdk> empresaList = EmpresaSdk.BuscarEmpresas();

    // Mostrar el listado de empresas
    Console.WriteLine("Lista de empresas:");
    foreach (EmpresaSdk empresaSdk in empresaList.OrderBy(e => e.Nombre))
        Console.WriteLine($"Id:{empresaSdk.Id} Nombre:{empresaSdk.Nombre} Ruta:{empresaSdk.Ruta}");
    Console.WriteLine();

    Console.WriteLine("Selecciona una empresa del listado. Ingresa el Id:");
    string empresaKey = Console.ReadLine();
    int empresaId = int.Parse(empresaKey ?? throw new InvalidOperationException());
    EmpresaSdk empresaSeleccionada = empresaList.First(e => e.Id == empresaId);

    Console.WriteLine($"Abriendo empresa {empresaSeleccionada.Nombre}.");
    ConexionSdk.AbrirEmpresa(empresaSeleccionada.Ruta);
    Console.WriteLine();

    // 3. Correr nuestros procesos
}
catch (Exception e)
{
    Console.WriteLine(e);
}
finally
{
    // 4. Cerrar empresa
    ConexionSdk.CerrarEmpresa();

    // 5. Terminar el SDK
    ConexionSdk.TerminarSdk();
}

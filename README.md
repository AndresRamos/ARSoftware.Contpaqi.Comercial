# :toolbox: AR Software Contpaqi Comercial

AR Software Contpaqi Comercial es una colección de proyectos que te permitirá trabajar y hacer interfaz con el sistema de CONTPAQi Comercial Premium para crear, modificar, y consultar catálogos y documentos respetando las reglas de negocio requeridas por el sistema.

**Los proyectos del SDK tambien son comptabiles con los sistemas de Factura Electronica y Adminpaq*

# :eyes: Que encontraras en este repositorio?

En este repositorio podrás encontrar proyectos para trabajar programáticamente con el sistema de CONTPAQi Comercial Premium utilizando el SDK o trabajando directamente con las bases de datos de SQL.

| Paquete  | NuGet | Descripcion | Documentacion
| --- | --- | --- | ---
| [ARSoftware.Contpaqi.Comercial.Sdk](src/ARSoftware.Contpaqi.Comercial.Sdk) | [![Nuget](https://img.shields.io/nuget/v/ARSoftware.Contpaqi.Comercial.Sdk?style=for-the-badge)](https://www.nuget.org/packages/ARSoftware.Contpaqi.Comercial.Sdk)  | Este proyecto es un wrapper del SDK con todas las funciones, estructuras, y constantes del SDK ya declaradas correctamente y listas para mandar a invocar en tu desarrollo. | <ul><li>[Curso](https://www.arsoft.net/courses/contpaqi-comercial-sdk-course)</li><li>[Wiki](https://github.com/AndresRamos/ARSoftware.Contpaqi.Comercial/wiki#sdk)</li><li>[Ejemplos](samples/Sdk.ConsoleApp)</li></ul> 
| [ARSoftware.Contpaqi.Comercial.Sdk.Extras](src/ARSoftware.Contpaqi.Comercial.Sdk.Extras) | [![Nuget](https://img.shields.io/nuget/v/ARSoftware.Contpaqi.Comercial.Sdk.Extras?style=for-the-badge)](https://www.nuget.org/packages/ARSoftware.Contpaqi.Comercial.Sdk.Extras)  | Este proyecto expone diferentes servicios que encapsulan las diferentes funcionalidades del SDK, como la de iniciar sesión, abrir empresas, consultar catálogos, crear y editar catálogos, crear documentos, timbrar y cancelar documentos, y mucho más. | <ul><li>[Curso](https://www.arsoft.net/courses/contpaqi-comercial-sdk-extras-course)</li><li>[Wiki](https://github.com/AndresRamos/ARSoftware.Contpaqi.Comercial/wiki#sdk-extras)</li><li>[Ejemplos](samples/Sdk.Extras.ConsoleApp)</li></ul>
| [ARSoftware.Contpaqi.Comercial.Sql](src/ARSoftware.Contpaqi.Comercial.Sql) | [![Nuget](https://img.shields.io/nuget/v/ARSoftware.Contpaqi.Comercial.Sql?style=for-the-badge)](https://www.nuget.org/packages/ARSoftware.Contpaqi.Comercial.Sql)  | Este proyecto tiene declarados los DbContexts de Entity Framework para poder consultar las bases de datos de SQL. |
| [ARSoftware.Contpaqi.Comercial.Sql.Models](src/ARSoftware.Contpaqi.Comercial.Sql.Models) | [![Nuget](https://img.shields.io/nuget/v/ARSoftware.Contpaqi.Comercial.Sql.Models?style=for-the-badge)](https://www.nuget.org/packages/ARSoftware.Contpaqi.Comercial.Sql.Models)  | Este proyecto tiene declaradas las clases de los esquemas de las bases de datos de SQL de CONTPAQi Comercial |

# :man_technologist: Consultoria
Si lo que buscas es contratar a un desarrollador para crear tu aplicación o interfaz para trabajar con los sistema de CONTPAQi, puedes contactarme directamente desde mi [página web](https://www.arsoft.net/).

Me especializo en el desarrollo de aplicaciones e interfaces para los sistemas de CONTPAQi y me gustaría agendar una reunión contigo para platicar más sobre tus necesidades y requerimientos.

# Ejemplo

Ejemplo de como facilmente podemos crear y timbrar una factura haciendo uso de los repositorios y servicios en [ARSoftware.Contpaqi.Comercial.Sdk.Extras](src/ARSoftware.Contpaqi.Comercial.Sdk.Extras).

```csharp
// Registrar servicios del SDK con el proveedor de proveedor de servicios (dependency injection)
IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(collection => { collection.AddContpaqiComercialSdkServices(TipoContpaqiSdk.Comercial); })
    .Build();

await host.StartAsync();

// Buscar los servicios a utilizar
var comercialSdkSesionService = host.Services.GetRequiredService<IComercialSdkSesionService>(); // Para iniciar y terminar conexion con el sdk
var empresaRepository = host.Services.GetRequiredService<IEmpresaRepository<Empresa>>(); // Para buscar empresas
var conceptoDocumentoRepository = host.Services.GetRequiredService<IConceptoDocumentoRepository<ConceptoDocumento>>(); // Para buscar conceptos
var clienteRepository = host.Services.GetRequiredService<IClienteProveedorRepository<ClienteProveedor>>(); // Para buscar clientes
var productoRepository = host.Services.GetRequiredService<IProductoRepository<Producto>>(); // Para buscar productos
var almacenRepository = host.Services.GetRequiredService<IAlmacenRepository<Almacen>>(); // Para buscar almacenes
var documentoService = host.Services.GetRequiredService<IDocumentoService>(); // Para crear y timbrar documentos
var movimientoService = host.Services.GetRequiredService<IMovimientoService>(); // Para crear movimientos

// Iniciar conexion con el sdk
comercialSdkSesionService.IniciarSesionSdk("SUPERVISOR", "Passw0rd!");

// Buscar empresa de prueba
List<Empresa> empresas = empresaRepository.TraerTodo().ToList();
Empresa empresaSeleccionada = empresas.First(e => e.CNOMBREEMPRESA == "EMPRESA PRUEBA");

// Abrir empresa
comercialSdkSesionService.AbrirEmpresa(empresaSeleccionada.CRUTADATOS);

// Instanciar modelo y asignar datos de la factura
var factura = new Documento();
factura.ConceptoDocumento = conceptoDocumentoRepository.BuscarPorCodigo("400"); // Buscar y asignar concepto de prueba
factura.ClienteProveedor = clienteRepository.BuscarPorCodigo("CTE001"); // Buscar y asignar cliente de prueba
factura.CREFERENCIA = "Referencia documento";
factura.FormaPago = FormaPago._03;
factura.MetodoPago = MetodoPago.PPD;
factura.COBSERVACIONES = "Observaciones documento";

// Buscar y asignar el folio consecutivo del concepto
tLlaveDoc siguienteFolio = documentoService.BuscarSiguienteSerieYFolio(factura.ConceptoDocumento.CCODIGOCONCEPTO);
factura.CSERIEDOCUMENTO = siguienteFolio.aSerie;
factura.CFOLIO = siguienteFolio.aFolio;

// Crear documento
int documentoId = documentoService.Crear(factura.ToTDocumento());

// Actualizar datos extra del documento (que no son parte de la estructura tDocumento)
var datosDocumento = new Dictionary<string, string>
{
    { nameof(admDocumentos.COBSERVACIONES), factura.COBSERVACIONES },
    { nameof(admDocumentos.CMETODOPAG), factura.CMETODOPAG },
    { nameof(admDocumentos.CCANTPARCI), factura.CCANTPARCI.ToString() }
};

documentoService.Actualizar(documentoId, datosDocumento);

// Instanciar modelo y asignar datos del un movimiento para la factura
var movimiento = new Movimiento();
movimiento.Producto = productoRepository.BuscarPorCodigo("SERV001"); // Buscar y asignar producto de prueba
movimiento.CUNIDADES = 1;
movimiento.CPRECIO = 100;
movimiento.CREFERENCIA = "Referencia movimiento";
movimiento.Almacen = almacenRepository.BuscarPorCodigo("1"); // Buscar y asignar almancen

// Crear movimiento
int movimientoId = movimientoService.Crear(documentoId, movimiento.ToTMovimiento());

// Timbrar Documento
documentoService.Timbrar(factura.ToTLlaveDoc(), "12345678a");

// Generar PDF
documentoService.GenerarDocumentoDigital(factura.ToTLlaveDoc(), TipoArchivoDigital.Pdf, "C://rutaDeLaPlantillaPdf.rdl");

// Cerrar empresa
comercialSdkSesionService.CerrarEmpresa();

// Terminar SDK
comercialSdkSesionService.TerminarSesionSdk();

await host.StopAsync();
```

# :heart: Como me puedes ayudar?

## :star: Dame una estrella
Si estas utilizando alguno de los proyectos dentro de este repositorio por favor dale una estrella. Te lo agradeceria! :pray:

## :money_with_wings: Patrociname
Si este proyecto es de beneficio para ti y te beneficia economicamente aumentando tus ingresos y/o productividad, me puedes ayudar donando al proyecto o convirtiendote en un patrocinador.
# :toolbox: AR Software Contpaqi Comercial

AR Software Contpaqi Comercial es una colección de proyectos que te permitirá trabajar y hacer interfaz con el sistema de CONTPAQi Comercial Premium para crear, modificar, y consultar catálogos y documentos respetando las reglas de negocio requeridas por el sistema.

**Los proyectos del SDK tambien son comptabiles con los sistemas de Factura Electronica y Adminpaq*

# :eyes: Que encontraras en este repositorio?

En este repositorio podrás encontrar proyectos para trabajar programáticamente con el sistema de CONTPAQi Comercial Premium utilizando el SDK o trabajando directamente con las bases de datos de SQL.

| Paquete  | NuGet | Descripcion | Documentacion
| --- | --- | --- | ---
| [ARSoftware.Contpaqi.Comercial.Sdk](src/ARSoftware.Contpaqi.Comercial.Sdk) | [![Nuget](https://img.shields.io/nuget/v/ARSoftware.Contpaqi.Comercial.Sdk?style=for-the-badge)](https://www.nuget.org/packages/ARSoftware.Contpaqi.Comercial.Sdk)  | Este proyecto es un wrapper del SDK con todas las funciones, estructuras, y constantes del SDK ya declaradas correctamente y listas para mandar a invocar en tu desarrollo. | <ul><li>[Curso](https://www.arsoft.net/courses/contpaqi-comercial-sdk-course)</li><li>[Wiki](https://github.com/AndresRamos/ARSoftware.Contpaqi.Comercial/wiki#sdk)</li><li>[Ejemplos](samples/Sdk.ConsoleApp)</li></ul> 
| [ARSoftware.Contpaqi.Comercial.Sdk.Extras](src/ARSoftware.Contpaqi.Comercial.Sdk.Extras) | [![Nuget](https://img.shields.io/nuget/v/ARSoftware.Contpaqi.Comercial.Sdk.Extras?style=for-the-badge)](https://www.nuget.org/packages/ARSoftware.Contpaqi.Comercial.Sdk.Extras)  | Este proyecto expone diferentes servicios que encapsulan las diferentes funcionalidades del SDK, como la de iniciar sesión, abrir empresas, consultar catálogos, crear y editar catálogos, crear documentos, timbrar y cancelar documentos, y mucho más. | <ul><li>[Curso](https://www.arsoft.net/courses/contpaqi-comercial-sdk-extras-course)</li><li>[Wiki](https://github.com/AndresRamos/ARSoftware.Contpaqi.Comercial/wiki#sdk-extras)</li><li>[Ejemplos](samples/Sdk.Extras.ConsoleApp)</li></ul>
| [ARSoftware.Contpaqi.Comercial.Sdk.Abstractions](src/ARSoftware.Contpaqi.Comercial.Sdk.Abstractions) | [![Nuget](https://img.shields.io/nuget/v/ARSoftware.Contpaqi.Comercial.Sdk.Abstractions?style=for-the-badge)](https://www.nuget.org/packages/ARSoftware.Contpaqi.Comercial.Sdk.Abstractions)  | Este proyecto inlcluye los modelos e interfaces utlizados por el SDK y SQL | 
| [ARSoftware.Contpaqi.Comercial.Sql](src/ARSoftware.Contpaqi.Comercial.Sql) | [![Nuget](https://img.shields.io/nuget/v/ARSoftware.Contpaqi.Comercial.Sql?style=for-the-badge)](https://www.nuget.org/packages/ARSoftware.Contpaqi.Comercial.Sql)  | Este proyecto tiene declarados los DbContexts de Entity Framework para poder consultar las bases de datos de SQL. |
| [ARSoftware.Contpaqi.Comercial.Sql.Models](src/ARSoftware.Contpaqi.Comercial.Sql.Models) | [![Nuget](https://img.shields.io/nuget/v/ARSoftware.Contpaqi.Comercial.Sql.Models?style=for-the-badge)](https://www.nuget.org/packages/ARSoftware.Contpaqi.Comercial.Sql.Models)  | Este proyecto tiene declaradas las clases de los esquemas de las bases de datos de SQL de CONTPAQi Comercial |

# :man_technologist: Consultoria
Si lo que buscas es contratar a un desarrollador para crear tu aplicación o interfaz para trabajar con los sistema de CONTPAQi, puedes contactarme directamente desde mi [página web](https://www.arsoft.net/).

Me especializo en el desarrollo de aplicaciones e interfaces para los sistemas de CONTPAQi y me gustaría agendar una reunión contigo para platicar más sobre tus necesidades y requerimientos.

# Ejemplos

## Registrar Servicios
```csharp
IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(services =>
    {
        // Agregar servicios del SDK
        services.AddContpaqiComercialSdkServices();
    })
    .Build();

IServiceProvider services = host.Services;

var sdkSesionService = services.GetRequiredService<IComercialSdkSesionService>();
```

## Crear y timbrar una factura haciendo uso de los repositorios y servicios en [ARSoftware.Contpaqi.Comercial.Sdk.Extras](src/ARSoftware.Contpaqi.Comercial.Sdk.Extras).

```csharp
// Iniciar sesion
var sdkSesionService = services.GetRequiredService<IComercialSdkSesionService>();
sdkSesionService.IniciarSesionSdk("SUPERVISOR", "");

// Buscar empresa
var empresaRepository = services.GetRequiredService<IEmpresaRepository<EmpresaDto>>();
EmpresaDto empresa = empresaRepository.BuscarPorNombre("EMPRESA PRUEBA") ?? throw new Exception("No se encontro la empresa.");

// Abrir empresa
sdkSesionService.AbrirEmpresa(empresa.CRUTADATOS);

// Buscar siguiente folio del concepto
var _documentoService = services.GetRequiredService<IDocumentoService>();
tLlaveDoc llaveDocumento = _documentoService.BuscarSiguienteSerieYFolio("PRUEBAFACTURA");

// Crear estructura de una factura
var documento = new Documento
{
    Concepto = new ConceptoDocumento { Codigo = "PRUEBAFACTURA" },
    Serie = llaveDocumento.aSerie,
    Folio = (int)llaveDocumento.aFolio,
    Fecha = DateTime.Today,
    Cliente = new ClienteProveedor { Codigo = "PRUEBA" },
    Referencia = "Referencia",
    FormaPago = FormaPago._03,
    MetodoPago = MetodoPago.PPD,
    Observaciones = "Observaciones",
    Moneda = Moneda.PesoMexicano,
    TipoCambio = 1,
    Agente = new Agente { Codigo = "PRUEBA" }
};

// Agregar datos extra
documento.DatosExtra.Add(nameof(admDocumentos.CTEXTOEXTRA1), "Texto Extra 1");
documento.DatosExtra.Add(nameof(admDocumentos.CTEXTOEXTRA2), "Texto Extra 2");

// Crear estructura de un movimiento
var movimiento = new Movimiento
{
    Producto = new Producto { Codigo = "PRUEBA" },
    Almacen = new Almacen { Codigo = "1" },
    Unidades = 1,
    Precio = 100,
    Referencia = "Referencia",
    Observaciones = "Observaciones"
};

// Agregar datos extra del movimiento
movimiento.DatosExtra.Add(nameof(admMovimientos.CTEXTOEXTRA1), "Texto Extra 1");

// Agregar movimiento a la factura
documento.Movimientos.Add(movimiento);

// Crear factura
int nuevoDocumentoId = _documentoService.Crear(documento);

// Crear movimientos
var _movimientoService = services.GetRequiredService<IMovimientoService>();
foreach (Movimiento mov in documento.Movimientos) _movimientoService.Crear(nuevoDocumentoId, mov);

// Timbrar factura
_documentoService.Timbrar(llaveDocumento, "12345678a");

// Generar XML de la factura
_documentoService.GenerarDocumentoDigital(llaveDocumento, TipoArchivoDigital.Xml);

// Generar PDF de la factura
_documentoService.GenerarDocumentoDigital(llaveDocumento, TipoArchivoDigital.Pdf,
    @"\\AR-SERVER\Compac\Empresas\Reportes\Formatos Digitales\reportes_Servidor\COMERCIAL\Facturav40.rdl");

// Cerrar empresa
sdkSesionService.CerrarEmpresa();

// Terminar sesion
sdkSesionService.TerminarSesionSdk();
```

## Consultar Catalogos
```csharp
// Buscar productos de tipo admProductos
// admProductos es la estructura de la tabla de productos de Contpaqi Comercial y tiene todas las columnas de la tabla.
var productoRepository = provider.GetRequiredService<IProductoRepository<admProductos>>();
List<admProductos> productos = productoRepository.TraerTodo();

foreach (admProductos admProductos in productos)
{
    int prodcutoId = admProductos.CIDPRODUCTO;
    string productoCodigo = admProductos.CCODIGOPRODUCTO;
}

// Buscar productos de tipo ProductoDto
// ProductoDto es una estructura simplificada de la tabla de productos de Contpaqi Comercial y solo tiene las columnas mas utilizadas.
// Mientras las propiedades tengan el mismo nombre que la columna de la tabla, se pueden mapear automaticamente.
var productoDtoRepository = provider.GetRequiredService<IProductoRepository<ProductoDto>>();
List<ProductoDto> productosDto = productoDtoRepository.TraerTodo();

foreach (ProductoDto productoDto in productosDto)
{
    int prodcutoId = productoDto.CIDPRODUCTO;
    string productoCodigo = productoDto.CCODIGOPRODUCTO;
}
```

# Licencia

**Este proyecto no es Open Source.** Si deseas utilizarlo en tu organizacion, debes adquirir una licencia de uso.

El costo de la licencia anual es de $300 dlls por RFC.

Para informacion de como adquirir una licencia de uso puedes contactarme en mi [pagina web](https://www.arsoft.net/).

# :heart: Como me puedes ayudar?

## :star: Dame una estrella
Si estas utilizando alguno de los proyectos dentro de este repositorio por favor dale una estrella. Te lo agradeceria! :pray:
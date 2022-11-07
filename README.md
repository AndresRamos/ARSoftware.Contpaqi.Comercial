# AR Software Contpaqi Comercial

Si estas buscando información o una utilería para hacer una interface y trabajar programáticamente con el sistema de CONTPAQi Comercial estas en el lugar correcto.

En este repositorio podrás encontrar proyectos para trabajar con el sistema de CONTPAQi Comercial utilizando el SDK o trabajando directamente con las bases de datos de SQL.

## Proyectos para trabajar con el SDK:
- [ARSoftware.Contpaqi.Comercial.Sdk](src/ARSoftware.Contpaqi.Comercial.Sdk)
- [ARSoftware.Contpaqi.Comercial.Sdk.Extras](src/ARSoftware.Contpaqi.Comercial.Sdk.Extras)

## Proyectos para trabajar con las bases de datos de SQL:
- [ARSoftware.Contpaqi.Comercial.Sql.Models](src/ARSoftware.Contpaqi.Comercial.Sql.Models)
- [ARSoftware.Contpaqi.Comercial.Sql](src/ARSoftware.Contpaqi.Comercial.Sql)

# Consultoria
Si lo que buscas es contratar a un desarrollador para crear tu aplicación o interfaz, puedes contactarme directamente desde mi [página web](https://www.arsoft.net/).

Me especializo en el desarrollo de aplicaciones e interfaces para los sistemas de CONTPAQi y me gustaría agendar una reunión contigo para platicar más sobre tus necesidades y requerimientos.

# ARSoftware.Contpaqi.Comercial.Sdk

El SDK es una librería proporcionada por CONTPAQi que nos permite consultar y crear catálogos y documentos respetando las reglas de negocio requeridas por el sistema.

Este proyecto es un wrapper del SDK con todas las funciones, estructuras, y constantes del SDK ya declaradas correctamente y listas para mandar a invocar en tu desarrollo.

Ejemplo:

```csharp
using ARSoftware.Contpaqi.Comercial.Sdk;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.Extensiones;

// Ingresar programaticamente el usuario y contrasena del sistema de Comercial
ComercialSdk.fInicioSesionSDK("usuario", "contrasena");

// Iniciar conexion
ComercialSdk.fSetNombrePAQ(NombresPaqSdk.Comercial).TirarSiEsError();

// Abrir empresa
ComercialSdk.fAbreEmpresa("rutaEmpresa").TirarSiEsError();

// Crear documento
var nuevoDocumento = new tDocumento();
var nuevoDocumentoId = 0;
ComercialSdk.fAltaDocumento(ref nuevoDocumentoId, ref nuevoDocumento).TirarSiEsError();

// Cerrar empresa
ComercialSdk.fCierraEmpresa();

// Terminar Conexion
ComercialSdk.fTerminaSDK();
```

## Instalar utilizando [NuGet](https://www.nuget.org/packages/ARSoftware.Contpaqi.Comercial.Sdk/)

```
NuGet\Install-Package ARSoftware.Contpaqi.Comercial.Sdk
```

## Documentacion

Puedes encontrar información acerca del cómo utilizar el SDK en:
* [Wiki](https://github.com/AndresRamos/ARSoftware.Contpaqi.Comercial/wiki)
* [Proyecto de ejemplo](samples/ARSoftware.Contpaqi.Comercial.ConsoleApp)
* [Curso Del SDK De CONTPAQi Comercial](https://www.arsoft.net/courses/contpaqi-comercial-sdk-course)

# ARSoftware.Contpaqi.Comercial.Sdk.Extras

Este proyecto contiene clases, servicios, y repositorios que extienden y dan funcionalidad al proyecto ARSoftware.Contpaqi.Comercial.Sdk que solo contienen las funciones y estructuras definidas.

Este proyecto expone diferentes servicios que encapsulan las diferentes funcionalidades del SDK, como la de iniciar sesión, abrir empresas, consultar catálogos, crear y editar catálogos, crear documentos, timbrar y cancelar documentos, y mucho más.

## Instalar utilizando [NuGet](https://www.nuget.org/packages/ARSoftware.Contpaqi.Comercial.Sdk.Extras/)

```
NuGet\Install-Package ARSoftware.Contpaqi.Comercial.Sdk.Extras
```

## Documentacion
* [Proyecto de ejemplo](samples/ARSoftware.Contpaqi.Comercial.Ejemplos)

# ARSoftware.Contpaqi.Comercial.Sql

Este proyecto tiene declarados los DbContexts de Entity Framework para poder consultar las bases de datos de SQL.

## Instalar utilizando [NuGet](https://www.nuget.org/packages/ARSoftware.Contpaqi.Comercial.Sql/)

```
NuGet\Install-Package ARSoftware.Contpaqi.Comercial.Sql
```

# ARSoftware.Contpaqi.Comercial.Sql.Models

Este proyecto tiene declaradas las clases de los esquemas de las bases de datos de SQL de CONTPAQi Comercial

## Instalar utilizando [NuGet](https://www.nuget.org/packages/ARSoftware.Contpaqi.Comercial.Sql.Models/)

```
NuGet\Install-Package ARSoftware.Contpaqi.Comercial.Sql.Models
```

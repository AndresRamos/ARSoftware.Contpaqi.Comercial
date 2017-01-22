# Contpaqi

Este proyecto incluye clases listas para conectarse al SDK de Adminpaq y Comercial.

Tambien incluye unas clases para conectarse directamente a la base de datos de los sistemas de Contabilidad y Comercial usando Entity Framework.

Las classes ComercialSdk.cs y  AdminpaqSdk.cs tienen todas las funciones definidas.

Es importante saber que no todas las funciones en las clases del SDK tienen los parametros correctos dado a que no es facil saber si un char* es de tipo string o StringBuilder, o cuales parametros deben ser por referencia.

Si encuentran parametros incorrectos o funciones faltantes porfavor dejenmelo saber.

Esta libreria la uso para todos mis proyectos y es la base para otras librerias que uso y pense pudiera ser de ayuda o otros desarrolladores.

Eh incluido varias classes y servicios en Contpaqi.SistemasComerciales.Sdk.Extras que hacen muchas cosas como ir a buscar informacion.
Este es un buen lugar para ver como usar el SDK. 

Tratare de incluir ejemplos de como usar la libreria despues.

# Comercial
## Como inicializar el SDK de Comercial

```csharp
using Contpaqi.SistemasComerciales.Sdk;
using Contpaqi.SistemasComerciales.Sdk.Extras;
using System.Text;

namespace Comercial
{
     class Program
    {
        static void Main(string[] args)
        {
            int contpaqResult = 1; // 0 = exito. > 0 = error
            contpaqResult = InicializacionComercialSdk.InicializarSDK();
            if (contpaqResult != 0)
            {
                Console.WriteLine(ErroresComercial.LeerError(contpaqResult));
            }
            else
            {
                ComercialSdk.fTerminaSDK();
            }
        }
    }
}
```

## Como utilizar el SDK de Comercial

```csharp
using Contpaqi.SistemasComerciales.Sdk;
using Contpaqi.SistemasComerciales.Sdk.Extras;
using System.Text;

namespace Comercial
{
     class Program
    {
        static void Main(string[] args)
        {
            int contpaqResult = 1; // 0 = exito. > 0 = error
            contpaqResult = InicializacionComercialSdk.InicializarSDK();
            if (contpaqResult != 0)
            {
                Console.WriteLine(ErroresComercial.LeerError(contpaqResult));
            }
            else
            {
                int empresaId = 0;
                StringBuilder nombre = new StringBuilder(Constantes.kLongNombre);
                StringBuilder ruta = new StringBuilder(Constantes.kLongRuta);
                contpaqResult = ComercialSdk.fPosPrimerEmpresa(ref empresaId, nombre, ruta);
                Console.WriteLine($"Id {empresaId} Nombre {nombre} Ruta{ruta}");
                while (ComercialSdk.fPosSiguienteEmpresa(ref empresaId, nombre, ruta) == 0)
                {
                    Console.WriteLine($"{empresaId} {nombre} | {ruta}");
                };
                ComercialSdk.fTerminaSDK();
            }
        }
    }
}
```

# Adminpaq
## Como inicializar el SDK de Adminpaq

```csharp
using Contpaqi.SistemasComerciales.Sdk;
using Contpaqi.SistemasComerciales.Sdk.Extras;
using System.Text;

namespace Adminpaq
{
     class Program
    {
        static void Main(string[] args)
        {
            int contpaqResult = 1; // 0 = exito. > 0 = error
            contpaqResult = InicializacionAdminpaqSdk.InicializarSDK();
            if (contpaqResult != 0)
            {
                System.Console.WriteLine(ErroresAdminpaq.LeerError(contpaqResult));
            }
            else
            {
                AdminpaqSdk.fTerminaSDK();
            }
        }
    }
}
```

## Como utilizar el SDK de Adminpaq

```csharp
using Contpaqi.SistemasComerciales.Sdk;
using Contpaqi.SistemasComerciales.Sdk.Extras;
using System.Text;

namespace Adminpaq
{
     class Program
    {
        static void Main(string[] args)
        {
            int contpaqResult = 1; // 0 = exito. > 0 = error
            contpaqResult = InicializacionAdminpaqSdk.InicializarSDK();
            if (contpaqResult != 0)
            {
                Console.WriteLine(ErroresAdminpaq.LeerError(contpaqResult));
            }
            else
            {
                int empresaId = 0;
                StringBuilder nombre = new StringBuilder(Constantes.kLongNombre);
                StringBuilder ruta = new StringBuilder(Constantes.kLongRuta);
                contpaqResult = AdminpaqSdk.fPosPrimerEmpresa(ref empresaId, nombre, ruta);
                Console.WriteLine($"Id {empresaId} Nombre {nombre} Ruta{ruta}");
                while (AdminpaqSdk.fPosSiguienteEmpresa(ref empresaId, nombre, ruta) == 0)
                {
                    Console.WriteLine($"{empresaId} {nombre} | {ruta}");
                };
                AdminpaqSdk.fTerminaSDK();
            }
        }
    }
}
```

# Contpaqi

Este proyecto incluye clases listas para conectarse al SDK de Adminpaq y Comercial.

Tambien incluye unas clases para conectarse directamente a la base de datos de los sistemas de Contabilidad y Comercial usando Entity Framework.

Es importante saber que no todas las funciones en las clases del SDK tienen los parametros correctos dado a que no es facil saber si un char* es de tipo string o StringBuilder, o cuales parametros deben ser por referencia.

Si encuentran parametros incorrectos o funciones faltantes porfavor dejenmelo saber.

Esta libreria la uso para todos mis proyectos y es la base para otras librerias que uso y pense pudiera ser de ayuda o otros desarrolladores.

Tratare de incluir ejemplos de como usar la libreria despues.

## Como inicializar el SDK de Comercial

```csharp
using Contpaqi.SistemasComerciales.Sdk;
using Contpaqi.SistemasComerciales.Sdk.Extras;

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


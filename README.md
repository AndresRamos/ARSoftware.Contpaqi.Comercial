# ARSoftware.Contpaqi.Comercial

Este repositorio consiste de dos tipos de proyectos para interactuar con el sistema de CONTPAQi Comercial Premium: Proyectos que utilizan SDK y proyectos que utilizan las bases de datos de SQL.

Proyectos SDK:
- [ARSoftware.Contpaqi.Comercial.Sdk](https://github.com/AndresRamos/ARSoftware.Contpaqi.Comercial/tree/master/src/ARSoftware.Contpaqi.Comercial.Sdk)
- [ARSoftware.Contpaqi.Comercial.Sdk.Extras](https://github.com/AndresRamos/ARSoftware.Contpaqi.Comercial/tree/master/src//ARSoftware.Contpaqi.Comercial.Sdk.Extras)
Estos proyectos tambien permiten trabajar con Factura Electronica y Adminpaq, pero solamente estan probadas para el sistema de Comercial.

Poryectos SQL
- [ARSoftware.Contpaqi.Comercial.Sql.Models](https://github.com/AndresRamos/ARSoftware.Contpaqi.Comercial/tree/master/src/ARSoftware.Contpaqi.Comercial.Sql.Models)
- [ARSoftware.Contpaqi.Comercial.Sql](https://github.com/AndresRamos/ARSoftware.Contpaqi.Comercial/tree/master/src//ARSoftware.Contpaqi.Comercial.Sql)

## ARSoftware.Contpaqi.Comercial.Sdk
Nuget: ```Install-Package ARSoftware.Contpaqi.Comercial.Sdk```

Este proyecto incluye todas las declaraciones de los metodos, datos abstractos, y constantes del SDK de CONTPAQi Comercial que nos provee CONTPAQi.

## ARSoftware.Contpaqi.Comercial.Sdk.Extras
Nuget: ```Install-Package ARSoftware.Contpaqi.Comercial.Sdk.Extras```

Este proyecto contiene clases, servicios, y repositorios que extiended y dan funcionalidad al proyecto ARSoftware.Contpaqi.Comercial.Sdk que solo contienen los metodos definidos.
Este proyecto contiene diferentes servicios que encapsulan las diferentes funcionalidad de SDK como la de iniciar sesion y abrir empresas, consultar catalogos y crear y editar catalogos.

## ARSoftware.Contpaqi.Comercial.Sql
Nuget: ```Install-Package ARSoftware.Contpaqi.Comercial.Sql```

Este proyecto tienen declarados los DbContexts de Entity Framework para poder consultar las bases de datos de SQL. 

## ARSoftware.Contpaqi.Comercial.Sql.Models
Nuget: ```Install-Package Install-Package ARSoftware.Contpaqi.Comercial.Sql.Models```

Este proyecto tiene declaradas las clases de los esquemas de las bases de datos de SQL de CONTPAQi Comercial

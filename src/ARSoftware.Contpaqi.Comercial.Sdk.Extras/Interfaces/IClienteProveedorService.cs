using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface IClienteProveedorService
{
    /// <summary>
    ///     Actualiza un cliente o proveedor por su Id. Los datos a actualizar se pasan en un diccionario donde la llave es el
    ///     nombre de la columna de la tabla de clientes en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="idClienteProveedor">El Id del cliente o proveedor a actualizar.</param>
    /// <param name="datosClienteProveedor">Datos del cliente o proveedor a actualizar.</param>
    void Actualizar(int idClienteProveedor, Dictionary<string, string> datosClienteProveedor);

    /// <summary>
    ///     Actualiza un cliente o proveedor por su código. Los datos a actualizar se pasan en un diccionario donde la llave es
    ///     el nombre de la columna de la tabla de clientes en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="codigoClienteProveedor">Código del cliente o proveedor a actualizar.</param>
    /// <param name="datosClienteProveedor">Datos del cliente o proveedor a actualizar.</param>
    void Actualizar(string codigoClienteProveedor, Dictionary<string, string> datosClienteProveedor);

    /// <summary>
    ///     Actualiza un cliente o proveedor por dato abstracto.
    /// </summary>
    /// <param name="clienteProveedor">Cliente o proveedor a actualizar.</param>
    void Actualizar(tCteProv clienteProveedor);

    /// <summary>
    ///     Actualiza un cliente o proveedor. Se actualizan todos los campos en el modelo por lo que es necesario que todas las
    ///     propiedades
    ///     del modelo tengan un valor valido.
    /// </summary>
    /// <param name="clienteProveedor">Cliente o proveedor a actualizar.</param>
    void Actualizar(ClienteProveedor clienteProveedor);

    /// <summary>
    ///     Crear un cliente o proveedor por dato abstracto.
    /// </summary>
    /// <param name="clienteProveedor">Cliente o proveedor a actualizar.</param>
    /// <returns></returns>
    int Crear(tCteProv clienteProveedor);

    /// <summary>
    ///     Crea un cliente o proveedor. Los datos del cliente o proveedor se pasan en un diccionario donde la llave es el
    ///     nombre de la columna de la tabla de clientes en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="datosClienteProveedor">Datos del cliente o proveedor a crear.</param>
    /// <returns>El Id del cliente creado.</returns>
    int Crear(Dictionary<string, string> datosClienteProveedor);

    /// <summary>
    ///     Crear un cliente o proveedor.
    /// </summary>
    /// <param name="clienteProveedor">Cliente o proveedor a crear.</param>
    /// <returns>El Id del cliente creado.</returns>
    int Crear(ClienteProveedor clienteProveedor);

    /// <summary>
    ///     Elimina un cliente o proveedor por su Id.
    /// </summary>
    /// <param name="idClienteProveedor">El Id del cliente o proveedor a eliminar.</param>
    void Eliminar(int idClienteProveedor);

    /// <summary>
    ///     Elimina un cliente o proveedor por su código.
    /// </summary>
    /// <param name="codigoClienteProveedor">El código del cliente o proveedor a eliminar.</param>
    void Eliminar(string codigoClienteProveedor);
}

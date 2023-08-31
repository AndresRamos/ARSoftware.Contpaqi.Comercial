using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface IAlmacenService
{
    /// <summary>
    ///     Actualiza un almacén por su Id. Los datos a actualizar se pasan en un diccionario donde la llave es el nombre de la
    ///     columna de la tabla de almacenes en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="idAlmacen">El Id del almacén a actualizar.</param>
    /// <param name="datosAlmacen">Datos del almacén a actualizar.</param>
    void Actualizar(int idAlmacen, Dictionary<string, string> datosAlmacen);

    /// <summary>
    ///     Actualiza un almacén por su código. Los datos a actualizar se pasan en un diccionario donde la llave es el nombre
    ///     de la columna de la tabla de almacenes en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="codigoAlmacen">Código del almacén a actualizar.</param>
    /// <param name="datosAlmacen">Datos del almacén a actualizar.</param>
    void Actualizar(string codigoAlmacen, Dictionary<string, string> datosAlmacen);

    /// <summary>
    ///     Crea un almacén. Los datos del almacén se pasan en un diccionario donde la llave es el nombre de la columna de la
    ///     tabla de almacenes en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="datosAlmacen">Datos del almacén a crear.</param>
    /// <returns>El Id del almacén creado.</returns>
    int Crear(Dictionary<string, string> datosAlmacen);

    /// <summary>
    ///     Crear un almacén.
    /// </summary>
    /// <param name="almacen">Almacén a crear.</param>
    /// <returns>El Id del almacén creado.</returns>
    int Crear(Almacen almacen);
}

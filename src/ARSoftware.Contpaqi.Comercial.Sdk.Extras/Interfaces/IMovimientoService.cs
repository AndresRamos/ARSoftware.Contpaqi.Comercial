using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface IMovimientoService
{
    /// <summary>
    ///     Actualiza un movimiento por su id. Los datos a actualizar se pasan en un diccionario donde la llave es el nombre de
    ///     la columna de la tabla de movimientos en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="idMovimiento">El id del movimiento a actualizar.</param>
    /// <param name="datosMovimiento">Datos del movimiento a actualizar.</param>
    void Actualizar(int idMovimiento, Dictionary<string, string> datosMovimiento);

    /// <summary>
    ///     Crear un movimiento por dato abstracto.
    /// </summary>
    /// <param name="idDocumento">El id del documento al que se le va a crear el movimiento.</param>
    /// <param name="movimiento">Movimiento a crear.</param>
    /// <returns>El id del movimiento creado.</returns>
    int Crear(int idDocumento, tMovimiento movimiento);

    /// <summary>
    ///     Crear un movimiento de descuento por dato abstracto.
    /// </summary>
    /// <param name="idDocumento">El id del documento al que se le va a crear el movimiento.</param>
    /// <param name="movimiento">Movimiento a crear.</param>
    /// <returns>El id del movimiento creado.</returns>
    int Crear(int idDocumento, tMovimientoDesc movimiento);

    /// <summary>
    ///     Crea un movimiento. Los datos del movimiento se pasan en un diccionario donde la llave es el nombre de la columna
    ///     de la tabla de movimiento en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="datosMovimiento">Datos del movimiento a crear.</param>
    /// <returns></returns>
    int Crear(Dictionary<string, string> datosMovimiento);

    /// <summary>
    ///     Crea un movimiento.
    /// </summary>
    /// <param name="idDocumento">El id del documento al que se le va a crear el movimiento.</param>
    /// <param name="movimiento">Movimiento a crear.</param>
    /// <returns>El id del movimiento creado.</returns>
    int Crear(int idDocumento, Movimiento movimiento);

    /// <summary>
    ///     Crea la series o capas de un movimiento.
    /// </summary>
    /// <param name="movimientoId">Id del movimiento al que se le va a crear la serie o capas.</param>
    /// <param name="seriesCapas">Las series o capas a crear.</param>
    void CrearSeriesCapas(int movimientoId, tSeriesCapas seriesCapas);

    /// <summary>
    ///     Elimina un movimiento por su id.
    /// </summary>
    /// <param name="idDocumento">Id del documento al que pertenece el movimiento a eliminar.</param>
    /// <param name="idMovimiento">Id del movimiento a eliminar.</param>
    void Eliminar(int idDocumento, int idMovimiento);
}

using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface IAgenteService
{
    /// <summary>
    ///     Actualiza un agente por su Id. Los datos a actualizar se pasan en un diccionario donde la llave es el nombre de la
    ///     columna de la tabla de agentes en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="idAgente">El Id del agente a actualizar.</param>
    /// <param name="datosAgente">Datos del agente a actualizar.</param>
    void Actualizar(int idAgente, Dictionary<string, string> datosAgente);

    /// <summary>
    ///     Actualiza un agente por su código. Los datos a actualizar se pasan en un diccionario donde la llave es el nombre de
    ///     la columna de la tabla de agentes en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="codigoAgente">El código del agente a actualizar.</param>
    /// <param name="datosAgente">Datos del agente a actualizar.</param>
    void Actualizar(string codigoAgente, Dictionary<string, string> datosAgente);

    /// <summary>
    ///     Crea un agente. Los datos del agente se pasan en un diccionario donde la llave es el nombre de la columna de la
    ///     tabla de agentes en la base de datos y el valor es un valor valido para la columna.
    /// </summary>
    /// <param name="datosAgente">Datos del agente a crear.</param>
    /// <returns>El Id del agente creado.</returns>
    int Crear(Dictionary<string, string> datosAgente);

    /// <summary>
    ///     Crea un agente.
    /// </summary>
    /// <param name="agente">Agente a crear.</param>
    /// <returns>El Id del agente creado. </returns>
    int Crear(Agente agente);
}

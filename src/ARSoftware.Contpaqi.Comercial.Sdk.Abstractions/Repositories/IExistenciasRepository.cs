using System;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar existencias de productos.
/// </summary>
public interface IExistenciasRepository
{
    /// <summary>
    ///     Busca las existencias de un producto en un almacén en una fecha determinada.
    /// </summary>
    /// <param name="codigoProducto">Código del producto.</param>
    /// <param name="codigoAlmacen">Código del almacén.</param>
    /// <param name="fecha">Fecha</param>
    /// <returns>
    ///     Las existencias del producto en el almacén en la fecha proporcionada.
    /// </returns>
    double BuscaExistencias(string codigoProducto, string codigoAlmacen, DateOnly fecha);

    /// <summary>
    ///     Busca las existencias de un producto con características en un almacén en una fecha determinada.
    /// </summary>
    /// <param name="codigoProducto">Código del producto.</param>
    /// <param name="codigoAlmacen">Código del almacén.</param>
    /// <param name="fecha">Fecha</param>
    /// <param name="abreviaturaValorCaracteristica1">Abreviatura del Valor de la Característica 1 del producto.</param>
    /// <param name="abreviaturaValorCaracteristica2">Abreviatura del Valor de la Característica 2 del producto.</param>
    /// <param name="abreviaturaValorCaracteristica3">Abreviatura del Valor de la Característica 3 del producto.</param>
    /// <returns>
    ///     Las existencias del producto con características en el almacén en la fecha proporcionada.
    /// </returns>
    double BuscaExistenciasConCaracteristicas(string codigoProducto, string codigoAlmacen, DateOnly fecha,
        string abreviaturaValorCaracteristica1, string abreviaturaValorCaracteristica2, string abreviaturaValorCaracteristica3);

    /// <summary>
    ///     Busca las existencias de un producto por lote y/o pedimento.
    /// </summary>
    /// <param name="codigoProducto">Código del producto.</param>
    /// <param name="codigoAlmacen">Código del almacén.</param>
    /// <param name="pedimento">Numero de pedimento.</param>
    /// <param name="lote">Numero de lote.</param>
    /// <returns>
    ///     Las existencias del producto por lote y/o pedimento.
    /// </returns>
    double BuscaExistenciasConCapas(string codigoProducto, string codigoAlmacen, string pedimento, string lote);
}

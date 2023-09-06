using System;
using System.Threading;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sql.Interfaces;

/// <inheritdoc cref="IExistenciasRepository" />
public interface IExistenciasSqlRepository : IExistenciasRepository
{
    /// <summary>
    ///     Busca las existencias de un producto en un almacén en una fecha determinada.
    /// </summary>
    /// <param name="codigoProducto">Código del producto.</param>
    /// <param name="codigoAlmacen">Código del almacén.</param>
    /// <param name="fecha">Fecha</param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Las existencias del producto en el almacén en la fecha proporcionada.
    /// </returns>
    Task<double> BuscaExistenciasAsync(string codigoProducto, string codigoAlmacen, DateOnly fecha, CancellationToken cancellationToken);

    /// <summary>
    ///     Busca las existencias de un producto con características en un almacén en una fecha determinada.
    /// </summary>
    /// <param name="codigoProducto">Código del producto.</param>
    /// <param name="codigoAlmacen">Código del almacén.</param>
    /// <param name="fecha">Fecha</param>
    /// <param name="abreviaturaValorCaracteristica1">Abreviatura del Valor de la Característica 1 del producto.</param>
    /// <param name="abreviaturaValorCaracteristica2">Abreviatura del Valor de la Característica 2 del producto.</param>
    /// <param name="abreviaturaValorCaracteristica3">Abreviatura del Valor de la Característica 3 del producto.</param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Las existencias del producto con características en el almacén en la fecha proporcionada.
    /// </returns>
    Task<double> BuscaExistenciasConCaracteristicasAsync(string codigoProducto, string codigoAlmacen, DateOnly fecha,
        string abreviaturaValorCaracteristica1, string abreviaturaValorCaracteristica2, string abreviaturaValorCaracteristica3,
        CancellationToken cancellationToken);

    /// <summary>
    ///     Busca las existencias de un producto por lote y/o pedimento.
    /// </summary>
    /// <param name="codigoProducto">Código del producto.</param>
    /// <param name="codigoAlmacen">Código del almacén.</param>
    /// <param name="pedimento">Numero de pedimento.</param>
    /// <param name="lote">Numero de lote.</param>
    /// <param name="cancellationToken">
    ///     Token de cancelación.
    /// </param>
    /// <returns>
    ///     Las existencias del producto por lote y/o pedimento.
    /// </returns>
    Task<double> BuscaExistenciasConCapasAsync(string codigoProducto, string codigoAlmacen, string pedimento, string lote,
        CancellationToken cancellationToken);
}

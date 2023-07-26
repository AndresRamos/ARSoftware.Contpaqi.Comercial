using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;

/// <summary>
///     Movimiento solo con las propiedades mas comunes.
///     Este modelo se puede utilizar para consultar el catalogo de movimientos cuando solo se necesitan algunas
///     propiedades.
///     Las propiedades de este modelo tienen los los mismos nombres que las propiedades del modelo de SQL para facilitar
///     la asignacion de valores cuando se utiliza con los repositorios genericos de Movimientos, como por ejemplo los que
///     implementan <see cref="IMovimientoRepository{T}" /> de <see cref="MovimientoDto" />.
/// </summary>
public class MovimientoDto
{
    /// <summary>
    ///     Id del movimiento.
    /// </summary>
    public int CIDMOVIMIENTO { get; set; }

    /// <summary>
    ///     Identificador del producto del movimiento.
    /// </summary>
    public int CIDPRODUCTO { get; set; }

    /// <summary>
    ///     Identificador del almacén del movimiento.
    /// </summary>
    public int CIDALMACEN { get; set; }

    /// <summary>
    ///     Cantidad de unidad base del movimiento.
    /// </summary>
    public double CUNIDADES { get; set; }

    /// <summary>
    ///     Precio del producto.
    /// </summary>
    public double CPRECIO { get; set; }

    /// <summary>
    ///     Importe del neto para el movimiento.
    /// </summary>
    public double CNETO { get; set; }

    /// <summary>
    ///     Importe del total del movimiento.
    /// </summary>
    public double CTOTAL { get; set; }

    /// <summary>
    ///     Referencia del movimiento.
    /// </summary>
    public string CREFERENCIA { get; set; } = string.Empty;

    /// <summary>
    ///     Observaciones del movimiento.
    /// </summary>
    public string? COBSERVAMOV { get; set; } = string.Empty;
}
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;

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

    /// <summary>
    ///     Importe del Impuesto 1 para el movimiento.
    /// </summary>
    public double CIMPUESTO1 { get; set; }

    /// <summary>
    ///     Porcentaje del impuesto 1.
    /// </summary>
    public double CPORCENTAJEIMPUESTO1 { get; set; }

    /// <summary>
    ///     Importe del Impuesto 2 para el movimiento.
    /// </summary>
    public double CIMPUESTO2 { get; set; }

    /// <summary>
    ///     Porcentaje del impuesto 2.
    /// </summary>
    public double CPORCENTAJEIMPUESTO2 { get; set; }

    /// <summary>
    ///     Importe del Impuesto 3 para el movimiento.
    /// </summary>
    public double CIMPUESTO3 { get; set; }

    /// <summary>
    ///     Porcentaje del impuesto 3.
    /// </summary>
    public double CPORCENTAJEIMPUESTO3 { get; set; }

    /// <summary>
    ///     Importe de la retención 1 para el movimiento.
    /// </summary>
    public double CRETENCION1 { get; set; }

    /// <summary>
    ///     Porcentaje de la retención 1.
    /// </summary>
    public double CPORCENTAJERETENCION1 { get; set; }

    /// <summary>
    ///     Importe de la retención 2 para el movimiento.
    /// </summary>
    public double CRETENCION2 { get; set; }

    /// <summary>
    ///     Porcentaje de la retención 2.
    /// </summary>
    public double CPORCENTAJERETENCION2 { get; set; }

    /// <summary>
    ///     Importe del descuento 1 para el movimiento.
    /// </summary>
    public double CDESCUENTO1 { get; set; }

    /// <summary>
    ///     Porcentaje del descuento 1.
    /// </summary>
    public double CPORCENTAJEDESCUENTO1 { get; set; }

    /// <summary>
    ///     Importe del descuento 2 para el movimiento.
    /// </summary>
    public double CDESCUENTO2 { get; set; }

    /// <summary>
    ///     Porcentaje del descuento 2.
    /// </summary>
    public double CPORCENTAJEDESCUENTO2 { get; set; }

    /// <summary>
    ///     Importe del descuento 3 para el movimiento.
    /// </summary>
    public double CDESCUENTO3 { get; set; }

    /// <summary>
    ///     Porcentaje del descuento 3.
    /// </summary>
    public double CPORCENTAJEDESCUENTO3 { get; set; }

    /// <summary>
    ///     Importe del descuento 4 para el movimiento.
    /// </summary>
    public double CDESCUENTO4 { get; set; }

    /// <summary>
    ///     Porcentaje del descuento 4.
    /// </summary>
    public double CPORCENTAJEDESCUENTO4 { get; set; }

    /// <summary>
    ///     Importe del descuento 5 para el movimiento.
    /// </summary>
    public double CDESCUENTO5 { get; set; }

    /// <summary>
    ///     Porcentaje del descuento 5.
    /// </summary>
    public double CPORCENTAJEDESCUENTO5 { get; set; }
}

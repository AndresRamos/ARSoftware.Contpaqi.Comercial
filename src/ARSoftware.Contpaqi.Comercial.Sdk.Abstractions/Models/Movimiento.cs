using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.ValueObjects;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

public class Movimiento
{
    /// <summary>
    ///     Id del movimiento.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Producto del movimiento.
    /// </summary>
    public Producto Producto { get; set; } = new();

    /// <summary>
    ///     Almacen del movimiento
    /// </summary>
    public Almacen? Almacen { get; set; } = new();

    /// <summary>
    ///     Cantidad de unidad base del movimiento.
    /// </summary>
    public double Unidades { get; set; }

    /// <summary>
    ///     Precio del producto
    /// </summary>
    public decimal Precio { get; set; }

    /// <summary>
    ///     Subtotal del movimiento.
    /// </summary>
    public decimal Subtotal { get; set; }

    /// <summary>
    ///     Descuentos del movimiento.
    /// </summary>
    public DescuentosMovimiento? Descuentos { get; set; }

    /// <summary>
    ///     Impuestos del movimiento.
    /// </summary>
    public ImpuestosMovimiento? Impuestos { get; set; }

    /// <summary>
    ///     Retenciones del movimiento.
    /// </summary>
    public RetencionesMovimiento? Retenciones { get; set; }

    /// <summary>
    ///     Total del movimiento
    /// </summary>
    public decimal Total { get; set; }

    /// <summary>
    ///     Referencia del movimiento.
    /// </summary>
    public string Referencia { get; set; } = string.Empty;

    /// <summary>
    ///     Observaciones del movimiento.
    /// </summary>
    public string? Observaciones { get; set; }

    /// <summary>
    ///     Series o capas del movimiento.
    /// </summary>
    public List<SeriesCapas> SeriesCapas { get; set; } = new();

    /// <summary>
    ///     Datos extra del movimiento.
    /// </summary>
    public Dictionary<string, string> DatosExtra { get; set; } = new();
}

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.ValueObjects;

public class Descuento
{
    /// <summary>
    ///     Tasa del descuento.
    /// </summary>
    public decimal Tasa { get; set; }

    /// <summary>
    ///     Importe del descuento.
    /// </summary>
    public decimal Importe { get; set; }
}

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.ValueObjects;

public class Impuesto
{
    /// <summary>
    ///     Tasa del impuesto.
    /// </summary>
    public decimal Tasa { get; set; }

    /// <summary>
    ///     Importe del impuesto.
    /// </summary>
    public decimal Importe { get; set; }
}

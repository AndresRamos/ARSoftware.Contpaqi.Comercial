namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.ValueObjects;

public class RetencionesMovimiento
{
    /// <summary>
    ///     Retencion 1 del movimiento. Normalmente es la Retencion ISR.
    /// </summary>
    public Retencion Retencion1 { get; set; } = new();

    /// <summary>
    ///     Retencion 2 del movimiento. Normalmente es la Retencion IVA.
    /// </summary>
    public Retencion Retencion2 { get; set; } = new();
}

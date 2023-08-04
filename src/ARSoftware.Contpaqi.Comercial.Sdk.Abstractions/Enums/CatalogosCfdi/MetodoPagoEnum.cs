using Ardalis.SmartEnum;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;

public sealed class MetodoPagoEnum : SmartEnum<MetodoPagoEnum, string>
{
    /// <summary>
    ///     PUE - Pago en una sola exhibición
    /// </summary>
    public static readonly MetodoPagoEnum PUE = new("Pago en una sola exhibición", "PUE");

    /// <summary>
    ///     PPD - Pago en parcialidades o diferido
    /// </summary>
    public static readonly MetodoPagoEnum PPD = new("Pago en parcialidades o diferido", "PPD");

    private MetodoPagoEnum(string descripcion, string clave) : base(descripcion, clave)
    {
    }
}

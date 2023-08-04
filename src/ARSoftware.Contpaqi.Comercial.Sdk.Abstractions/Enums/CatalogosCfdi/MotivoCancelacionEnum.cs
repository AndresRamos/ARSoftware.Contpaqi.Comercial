using Ardalis.SmartEnum;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;

public sealed class MotivoCancelacionEnum : SmartEnum<MotivoCancelacionEnum, string>
{
    /// <summary>
    ///     01 - Comprobantes emitidos con errores con relación.
    /// </summary>
    public static readonly MotivoCancelacionEnum _01 = new("Comprobantes emitidos con errores con relación.", "01");

    /// <summary>
    ///     02 - Comprobantes emitidos con errores sin relación.
    /// </summary>
    public static readonly MotivoCancelacionEnum _02 = new("Comprobantes emitidos con errores sin relación.", "02");

    /// <summary>
    ///     03 - No se llevó a cabo la operación.
    /// </summary>
    public static readonly MotivoCancelacionEnum _03 = new("No se llevó a cabo la operación.", "03");

    /// <summary>
    ///     04 - Operación nominativa relacionada en una factura global.
    /// </summary>
    public static readonly MotivoCancelacionEnum _04 = new("Operación nominativa relacionada en una factura global.", "04");

    private MotivoCancelacionEnum(string descripcion, string clave) : base(descripcion, clave)
    {
    }
}

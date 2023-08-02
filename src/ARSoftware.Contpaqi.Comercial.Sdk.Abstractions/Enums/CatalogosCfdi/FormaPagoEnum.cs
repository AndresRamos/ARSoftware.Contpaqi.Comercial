using Ardalis.SmartEnum;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;

public sealed class FormaPagoEnum : SmartEnum<FormaPagoEnum, string>
{
    /// <summary>
    ///     01 - Efectivo
    /// </summary>
    public static readonly FormaPagoEnum _01 = new("Efectivo", "01");

    /// <summary>
    ///     02 - Cheque nominativo
    /// </summary>
    public static readonly FormaPagoEnum _02 = new("Cheque nominativo", "02");

    /// <summary>
    ///     03 - Transferencia electrónica de fondos
    /// </summary>
    public static readonly FormaPagoEnum _03 = new("Transferencia electrónica de fondos", "03");

    /// <summary>
    ///     04 - Tarjeta de crédito
    /// </summary>
    public static readonly FormaPagoEnum _04 = new("Tarjeta de crédito", "04");

    /// <summary>
    ///     05 - Monedero electrónico
    /// </summary>
    public static readonly FormaPagoEnum _05 = new("Monedero electrónico", "05");

    /// <summary>
    ///     06 - Dinero electrónico
    /// </summary>
    public static readonly FormaPagoEnum _06 = new("Dinero electrónico", "06");

    /// <summary>
    ///     08 - Vales de despensa
    /// </summary>
    public static readonly FormaPagoEnum _08 = new("Vales de despensa", "08");

    /// <summary>
    ///     12 - Dación en pago
    /// </summary>
    public static readonly FormaPagoEnum _12 = new("Dación en pago", "12");

    /// <summary>
    ///     13 - Pago por subrogación
    /// </summary>
    public static readonly FormaPagoEnum _13 = new("Pago por subrogación", "13");

    /// <summary>
    ///     14 - Pago por consignación
    /// </summary>
    public static readonly FormaPagoEnum _14 = new("Pago por consignación", "14");

    /// <summary>
    ///     15 - Condonación
    /// </summary>
    public static readonly FormaPagoEnum _15 = new("Condonación", "15");

    /// <summary>
    ///     17 - Compensación
    /// </summary>
    public static readonly FormaPagoEnum _17 = new("Compensación", "17");

    /// <summary>
    ///     23 - Novación
    /// </summary>
    public static readonly FormaPagoEnum _23 = new("Novación", "23");

    /// <summary>
    ///     24 - Confusión
    /// </summary>
    public static readonly FormaPagoEnum _24 = new("Confusión", "24");

    /// <summary>
    ///     25 - Remisión de deuda
    /// </summary>
    public static readonly FormaPagoEnum _25 = new("Remisión de deuda", "25");

    /// <summary>
    ///     26 - Prescripción o caducidad
    /// </summary>
    public static readonly FormaPagoEnum _26 = new("Prescripción o caducidad", "26");

    /// <summary>
    ///     27 - A satisfacción del acreedor
    /// </summary>
    public static readonly FormaPagoEnum _27 = new("A satisfacción del acreedor", "27");

    /// <summary>
    ///     28 - Tarjeta de débito
    /// </summary>
    public static readonly FormaPagoEnum _28 = new("Tarjeta de débito", "28");

    /// <summary>
    ///     29 - Tarjeta de servicios
    /// </summary>
    public static readonly FormaPagoEnum _29 = new("Tarjeta de servicios", "29");

    /// <summary>
    ///     30 - Aplicación de anticipos
    /// </summary>
    public static readonly FormaPagoEnum _30 = new("Aplicación de anticipos", "30");

    /// <summary>
    ///     31 - Intermediario pagos
    /// </summary>
    public static readonly FormaPagoEnum _31 = new("Intermediario pagos", "31");

    /// <summary>
    ///     99 - Por definir
    /// </summary>
    public static readonly FormaPagoEnum _99 = new("Por definir", "99");

    private FormaPagoEnum(string descripcion, string clave) : base(descripcion, clave)
    {
    }
}

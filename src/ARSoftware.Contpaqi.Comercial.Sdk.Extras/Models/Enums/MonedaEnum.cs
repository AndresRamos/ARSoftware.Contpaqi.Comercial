using Ardalis.SmartEnum;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

public sealed class MonedaEnum : SmartEnum<MonedaEnum>
{
    public static readonly MonedaEnum Ninguna = new("(Ninguna)", 0);
    public static readonly MonedaEnum PesoMexicano = new("Peso Mexicano", 1);
    public static readonly MonedaEnum DolarAmericano = new("Dólar Americano", 2);

    /// <inheritdoc />
    private MonedaEnum(string name, int value) : base(name, value)
    {
    }
}

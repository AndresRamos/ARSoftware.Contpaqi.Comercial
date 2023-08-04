using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;
using AutoMapper;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Common.Mappings.Converters;

public class MetodoPagoEnumValueConverter : IValueConverter<int, MetodoPagoEnum?>
{
    /// <inheritdoc />
    public MetodoPagoEnum? Convert(int sourceMember, ResolutionContext context)
    {
        switch (sourceMember.ToString())
        {
            case "1":
                return MetodoPagoEnum.PUE;
            case "2":
                return MetodoPagoEnum.PPD;
            default:
                return null;
        }
    }
}

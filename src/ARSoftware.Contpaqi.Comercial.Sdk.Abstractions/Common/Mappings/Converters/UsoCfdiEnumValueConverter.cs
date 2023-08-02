using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;
using AutoMapper;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Common.Mappings.Converters;

public class UsoCfdiEnumValueConverter : IValueConverter<string, UsoCfdiEnum?>
{
    /// <inheritdoc />
    public UsoCfdiEnum? Convert(string sourceMember, ResolutionContext context)
    {
        return UsoCfdiEnum.TryFromValue(sourceMember, out UsoCfdiEnum result) ? result : null;
    }
}

using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;
using AutoMapper;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Common.Mappings.Converters;

public class FormaPagoEnumValueConverter : IValueConverter<string, FormaPagoEnum?>
{
    /// <inheritdoc />
    public FormaPagoEnum? Convert(string sourceMember, ResolutionContext context)
    {
        return FormaPagoEnum.TryFromValue(sourceMember, out FormaPagoEnum result) ? result : null;
    }
}

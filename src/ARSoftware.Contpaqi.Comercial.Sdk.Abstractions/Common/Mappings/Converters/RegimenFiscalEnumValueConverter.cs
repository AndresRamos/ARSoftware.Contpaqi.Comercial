using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;
using AutoMapper;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Common.Mappings.Converters;

public class RegimenFiscalEnumValueConverter : IValueConverter<string, RegimenFiscalEnum?>
{
    /// <inheritdoc />
    public RegimenFiscalEnum? Convert(string sourceMember, ResolutionContext context)
    {
        return RegimenFiscalEnum.TryFromValue(sourceMember, out RegimenFiscalEnum result) ? result : null;
    }
}

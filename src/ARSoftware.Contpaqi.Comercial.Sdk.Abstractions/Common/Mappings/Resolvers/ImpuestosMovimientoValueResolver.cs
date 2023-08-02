using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.ValueObjects;
using AutoMapper;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Common.Mappings.Resolvers;

public class ImpuestosMovimientoValueResolver : IValueResolver<MovimientoDto, Movimiento, ImpuestosMovimiento?>
{
    /// <inheritdoc />
    public ImpuestosMovimiento Resolve(MovimientoDto source, Movimiento destination, ImpuestosMovimiento? destMember,
        ResolutionContext context)
    {
        return new ImpuestosMovimiento
        {
            Impuesto1 = new Impuesto { Tasa = (decimal)source.CPORCENTAJEIMPUESTO1, Importe = (decimal)source.CIMPUESTO1 },
            Impuesto2 = new Impuesto { Tasa = (decimal)source.CPORCENTAJEIMPUESTO2, Importe = (decimal)source.CIMPUESTO2 },
            Impuesto3 = new Impuesto { Tasa = (decimal)source.CPORCENTAJEIMPUESTO3, Importe = (decimal)source.CIMPUESTO3 }
        };
    }
}

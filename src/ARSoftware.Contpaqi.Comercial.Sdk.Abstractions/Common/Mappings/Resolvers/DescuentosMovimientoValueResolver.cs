using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.ValueObjects;
using AutoMapper;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Common.Mappings.Resolvers;

public class DescuentosMovimientoValueResolver : IValueResolver<MovimientoDto, Movimiento, DescuentosMovimiento?>
{
    /// <inheritdoc />
    public DescuentosMovimiento Resolve(MovimientoDto source, Movimiento destination, DescuentosMovimiento? destMember,
        ResolutionContext context)
    {
        return new DescuentosMovimiento
        {
            Descuento1 = new Descuento { Tasa = (decimal)source.CPORCENTAJEDESCUENTO1, Importe = (decimal)source.CDESCUENTO1 },
            Descuento2 = new Descuento { Tasa = (decimal)source.CPORCENTAJEDESCUENTO2, Importe = (decimal)source.CDESCUENTO2 },
            Descuento3 = new Descuento { Tasa = (decimal)source.CPORCENTAJEDESCUENTO3, Importe = (decimal)source.CDESCUENTO3 },
            Descuento4 = new Descuento { Tasa = (decimal)source.CPORCENTAJEDESCUENTO4, Importe = (decimal)source.CDESCUENTO4 },
            Descuento5 = new Descuento { Tasa = (decimal)source.CPORCENTAJEDESCUENTO5, Importe = (decimal)source.CDESCUENTO5 }
        };
    }
}

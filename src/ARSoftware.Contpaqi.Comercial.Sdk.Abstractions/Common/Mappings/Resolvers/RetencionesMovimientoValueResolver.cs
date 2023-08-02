using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.ValueObjects;
using AutoMapper;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Common.Mappings.Resolvers;

public class RetencionesMovimientoValueResolver : IValueResolver<MovimientoDto, Movimiento, RetencionesMovimiento?>
{
    /// <inheritdoc />
    public RetencionesMovimiento Resolve(MovimientoDto source, Movimiento destination, RetencionesMovimiento? destMember,
        ResolutionContext context)
    {
        return new RetencionesMovimiento
        {
            Retencion1 = new Retencion { Tasa = (decimal)source.CPORCENTAJERETENCION1, Importe = (decimal)source.CRETENCION1 },
            Retencion2 = new Retencion { Tasa = (decimal)source.CPORCENTAJERETENCION2, Importe = (decimal)source.CRETENCION2 }
        };
    }
}

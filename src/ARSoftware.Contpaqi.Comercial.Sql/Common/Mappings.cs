using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using AutoMapper;

namespace ARSoftware.Contpaqi.Comercial.Sql.Common;

public sealed class Mappings : Profile
{
    public Mappings()
    {
        CreateMap<admAgentes, AgenteDto>();
    }
}
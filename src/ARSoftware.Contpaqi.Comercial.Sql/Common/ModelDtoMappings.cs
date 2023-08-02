using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;
using AutoMapper;

namespace ARSoftware.Contpaqi.Comercial.Sql.Common;

public sealed class ModelDtoMappings : Profile
{
    public ModelDtoMappings()
    {
        CreateMap<admAgentes, AgenteDto>();
        CreateMap<admAlmacenes, AlmacenDto>();
        CreateMap<admClientes, ClienteProveedorDto>();
        CreateMap<admConceptos, ConceptoDocumentoDto>();
        CreateMap<admDomicilios, DireccionDto>();
        CreateMap<admDocumentos, DocumentoDto>();
        CreateMap<admDocumentosModelo, DocumentoModeloDto>();
        CreateMap<Empresas, EmpresaDto>();
        CreateMap<admFoliosDigitales, FolioDigitalDto>();
        CreateMap<admMonedas, MonedaDto>();
        CreateMap<admMovimientos, MovimientoDto>();
        CreateMap<admParametros, ParametrosDto>();
        CreateMap<admProductos, ProductoDto>();
        CreateMap<admUnidadesMedidaPeso, UnidadMedidaDto>();
    }
}

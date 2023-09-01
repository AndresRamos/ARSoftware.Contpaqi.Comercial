using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;
using AutoMapper;

namespace ARSoftware.Contpaqi.Comercial.Sql.Common;

public sealed class ModelDtoMappings : Profile
{
    public ModelDtoMappings()
    {
        CreateMap<admAgentes, admAgentes>();
        CreateMap<admAgentes, AgenteDto>();

        CreateMap<admAlmacenes, admAlmacenes>();
        CreateMap<admAlmacenes, AlmacenDto>();

        CreateMap<admClasificaciones, admClasificaciones>();

        CreateMap<admClientes, admClientes>();
        CreateMap<admClientes, ClienteProveedorDto>();

        CreateMap<admConceptos, admConceptos>();
        CreateMap<admConceptos, ConceptoDocumentoDto>();

        CreateMap<admDomicilios, admDomicilios>();
        CreateMap<admDomicilios, DireccionDto>();

        CreateMap<admDocumentosModelo, admDocumentosModelo>();
        CreateMap<admDocumentosModelo, DocumentoModeloDto>();

        CreateMap<admDocumentos, admDocumentos>();
        CreateMap<admDocumentos, DocumentoDto>();

        CreateMap<Empresas, Empresas>();
        CreateMap<Empresas, EmpresaDto>();

        CreateMap<admFoliosDigitales, admFoliosDigitales>();
        CreateMap<admFoliosDigitales, FolioDigitalDto>();

        CreateMap<admMonedas, admMonedas>();
        CreateMap<admMonedas, MonedaDto>();

        CreateMap<admMovimientos, admMovimientos>();
        CreateMap<admMovimientos, MovimientoDto>();

        CreateMap<admParametros, ParametrosDto>();
        CreateMap<admProductos, ProductoDto>();
        CreateMap<admUnidadesMedidaPeso, UnidadMedidaDto>();
    }
}

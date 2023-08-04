using System;
using System.IO;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Common.Mappings.Converters;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Common.Mappings.Resolvers;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using AutoMapper;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Common.Mappings;

public sealed class DtoToModelMappings : Profile
{
    public DtoToModelMappings()
    {
        CreateMap<AgenteDto, Agente>()
            .ForMember(des => des.Id, opt => opt.MapFrom(src => src.CIDAGENTE))
            .ForMember(des => des.Codigo, opt => opt.MapFrom(src => src.CCODIGOAGENTE))
            .ForMember(des => des.Nombre, opt => opt.MapFrom(src => src.CNOMBREAGENTE))
            .ForMember(des => des.Tipo, opt => opt.MapFrom(src => Enum.Parse<TipoAgente>(src.CTIPOAGENTE.ToString())));

        CreateMap<AlmacenDto, Almacen>()
            .ForMember(des => des.Id, opt => opt.MapFrom(src => src.CIDALMACEN))
            .ForMember(des => des.Codigo, opt => opt.MapFrom(src => src.CCODIGOALMACEN))
            .ForMember(des => des.Nombre, opt => opt.MapFrom(src => src.CNOMBREALMACEN));

        CreateMap<ClienteProveedorDto, ClienteProveedor>()
            .ForMember(des => des.Id, opt => opt.MapFrom(src => src.CIDCLIENTEPROVEEDOR))
            .ForMember(des => des.Codigo, opt => opt.MapFrom(src => src.CCODIGOCLIENTE))
            .ForMember(des => des.RazonSocial, opt => opt.MapFrom(src => src.CRAZONSOCIAL))
            .ForMember(des => des.Rfc, opt => opt.MapFrom(src => src.CRFC))
            .ForMember(des => des.Tipo, opt => opt.MapFrom(src => Enum.Parse<TipoCliente>(src.CTIPOCLIENTE.ToString())))
            .ForMember(des => des.UsoCfdi, opt => opt.ConvertUsing(new UsoCfdiEnumValueConverter(), src => src.CUSOCFDI))
            .ForMember(des => des.RegimenFiscal, opt => opt.ConvertUsing(new RegimenFiscalEnumValueConverter(), src => src.CREGIMFISC));

        CreateMap<ConceptoDocumentoDto, ConceptoDocumento>()
            .ForMember(des => des.Id, opt => opt.MapFrom(src => src.CIDCONCEPTODOCUMENTO))
            .ForMember(des => des.Codigo, opt => opt.MapFrom(src => src.CCODIGOCONCEPTO))
            .ForMember(des => des.Nombre, opt => opt.MapFrom(src => src.CNOMBRECONCEPTO));

        CreateMap<DireccionDto, Direccion>()
            .ForMember(des => des.Id, opt => opt.MapFrom(src => src.CIDDIRECCION))
            .ForMember(des => des.TipoCatalogo, opt => opt.MapFrom(src => Enum.Parse<TipoCatalogoDireccion>(src.CTIPOCATALOGO.ToString())))
            .ForMember(des => des.Tipo, opt => opt.MapFrom(src => Enum.Parse<TipoDireccion>(src.CTIPODIRECCION.ToString())))
            .ForMember(des => des.Calle, opt => opt.MapFrom(src => src.CNOMBRECALLE))
            .ForMember(des => des.NumeroExterior, opt => opt.MapFrom(src => src.CNUMEROEXTERIOR))
            .ForMember(des => des.NumeroInterior, opt => opt.MapFrom(src => src.CNUMEROINTERIOR))
            .ForMember(des => des.Colonia, opt => opt.MapFrom(src => src.CCOLONIA))
            .ForMember(des => des.Ciudad, opt => opt.MapFrom(src => src.CCIUDAD))
            .ForMember(des => des.Estado, opt => opt.MapFrom(src => src.CESTADO))
            .ForMember(des => des.CodigoPostal, opt => opt.MapFrom(src => src.CCODIGOPOSTAL))
            .ForMember(des => des.Pais, opt => opt.MapFrom(src => src.CPAIS));

        CreateMap<DocumentoDto, Documento>()
            .ForMember(des => des.Id, opt => opt.MapFrom(src => src.CIDDOCUMENTO))
            .ForMember(des => des.Serie, opt => opt.MapFrom(src => src.CSERIEDOCUMENTO))
            .ForMember(des => des.Folio, opt => opt.MapFrom(src => src.CFOLIO))
            .ForMember(des => des.Fecha, opt => opt.MapFrom(src => src.CFECHA))
            .ForMember(des => des.TipoCambio, opt => opt.MapFrom(src => src.CTIPOCAMBIO))
            .ForMember(des => des.Referencia, opt => opt.MapFrom(src => src.CREFERENCIA))
            .ForMember(des => des.Observaciones, opt => opt.MapFrom(src => src.COBSERVACIONES))
            .ForMember(des => des.Total, opt => opt.MapFrom(src => src.CTOTAL))
            .ForMember(des => des.FormaPago, opt => opt.ConvertUsing(new FormaPagoEnumValueConverter(), src => src.CMETODOPAG))
            .ForMember(des => des.MetodoPago, opt => opt.ConvertUsing(new MetodoPagoEnumValueConverter(), src => src.CCANTPARCI));

        CreateMap<DocumentoModeloDto, DocumentoModelo>()
            .ForMember(des => des.Id, opt => opt.MapFrom(src => src.CIDDOCUMENTODE))
            .ForMember(des => des.Descripcion, opt => opt.MapFrom(src => src.CDESCRIPCION));

        CreateMap<EmpresaDto, Empresa>()
            .ForMember(des => des.Id, opt => opt.MapFrom(src => src.CIDEMPRESA))
            .ForMember(des => des.Nombre, opt => opt.MapFrom(src => src.CNOMBREEMPRESA))
            .ForMember(des => des.Ruta, opt => opt.MapFrom(src => src.CRUTADATOS))
            .ForMember(des => des.BaseDatos, opt => opt.MapFrom(src => new DirectoryInfo(src.CRUTADATOS).Name));

        CreateMap<FolioDigitalDto, FolioDigital>()
            .ForMember(des => des.Id, opt => opt.MapFrom(src => src.CIDFOLDIG))
            .ForMember(des => des.Uuid, opt => opt.MapFrom(src => src.CUUID));

        CreateMap<MonedaDto, Moneda>()
            .ForMember(des => des.Id, opt => opt.MapFrom(src => src.CIDMONEDA))
            .ForMember(des => des.Nombre, opt => opt.MapFrom(src => src.CNOMBREMONEDA));

        CreateMap<MovimientoDto, Movimiento>()
            .ForMember(des => des.Id, opt => opt.MapFrom(src => src.CIDMOVIMIENTO))
            .ForMember(des => des.Unidades, opt => opt.MapFrom(src => src.CUNIDADES))
            .ForMember(des => des.Precio, opt => opt.MapFrom(src => src.CPRECIO))
            .ForMember(des => des.Subtotal, opt => opt.MapFrom(src => src.CNETO))
            .ForMember(des => des.Descuentos, opt => opt.MapFrom<DescuentosMovimientoValueResolver>())
            .ForMember(des => des.Impuestos, opt => opt.MapFrom<ImpuestosMovimientoValueResolver>())
            .ForMember(des => des.Retenciones, opt => opt.MapFrom<RetencionesMovimientoValueResolver>())
            .ForMember(des => des.Total, opt => opt.MapFrom(src => src.CTOTAL))
            .ForMember(des => des.Referencia, opt => opt.MapFrom(src => src.CREFERENCIA))
            .ForMember(des => des.Observaciones, opt => opt.MapFrom(src => src.COBSERVAMOV));

        CreateMap<ParametrosDto, Parametros>()
            .ForMember(des => des.Rfc, opt => opt.MapFrom(src => src.CRFCEMPRESA))
            .ForMember(des => des.GuidAdd, opt => opt.MapFrom(src => src.CGUIDDSL));

        CreateMap<ProductoDto, Producto>()
            .ForMember(des => des.Id, opt => opt.MapFrom(src => src.CIDPRODUCTO))
            .ForMember(des => des.Codigo, opt => opt.MapFrom(src => src.CCODIGOPRODUCTO))
            .ForMember(des => des.Nombre, opt => opt.MapFrom(src => src.CNOMBREPRODUCTO))
            .ForMember(des => des.Tipo, opt => opt.MapFrom(src => Enum.Parse<TipoProducto>(src.CTIPOPRODUCTO.ToString())))
            .ForMember(des => des.ClaveSat, opt => opt.MapFrom(src => src.CCLAVESAT));

        CreateMap<UnidadMedidaDto, UnidadMedida>()
            .ForMember(des => des.Id, opt => opt.MapFrom(src => src.CIDUNIDAD))
            .ForMember(des => des.Abreviatura, opt => opt.MapFrom(src => src.CABREVIATURA))
            .ForMember(des => des.Nombre, opt => opt.MapFrom(src => src.CNOMBREUNIDAD))
            .ForMember(des => des.ClaveSat, opt => opt.MapFrom(src => src.CCLAVEINT));
    }
}

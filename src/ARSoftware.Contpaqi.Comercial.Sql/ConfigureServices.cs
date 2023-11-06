using System.Reflection;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Common.Mappings;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ARSoftware.Contpaqi.Comercial.Sql;

public static class ConfigureServices
{
    public static IServiceCollection AddContpaqiComercialSqlRepositories(this IServiceCollection services,
        ServiceLifetime lifetime = ServiceLifetime.Transient)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(typeof(DtoToModelMappings));

        services.Add(new ServiceDescriptor(typeof(AgenteSqlRepository<>), typeof(AgenteSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IAgenteRepository<>), typeof(AgenteSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IAgenteSqlRepository<>), typeof(AgenteSqlRepository<>), lifetime));

        services.Add(new ServiceDescriptor(typeof(AlmacenSqlRepository<>), typeof(AlmacenSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IAlmacenRepository<>), typeof(AlmacenSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IAlmacenSqlRepository<>), typeof(AlmacenSqlRepository<>), lifetime));

        services.Add(new ServiceDescriptor(typeof(ClasificacionSqlRepository<>), typeof(ClasificacionSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IClasificacionRepository<>), typeof(ClasificacionSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IClasificacionSqlRepository<>), typeof(ClasificacionSqlRepository<>), lifetime));

        services.Add(new ServiceDescriptor(typeof(ClienteProveedorSqlRepository<>), typeof(ClienteProveedorSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IClienteProveedorRepository<>), typeof(ClienteProveedorSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IClienteProveedorSqlRepository<>), typeof(ClienteProveedorSqlRepository<>), lifetime));

        services.Add(new ServiceDescriptor(typeof(ConceptoDocumentoSqlRepository<>), typeof(ConceptoDocumentoSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IConceptoDocumentoRepository<>), typeof(ConceptoDocumentoSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IConceptoDocumentoSqlRepository<>), typeof(ConceptoDocumentoSqlRepository<>), lifetime));

        services.Add(new ServiceDescriptor(typeof(DireccionSqlRepository<>), typeof(DireccionSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IDireccionRepository<>), typeof(DireccionSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IDireccionSqlRepository<>), typeof(DireccionSqlRepository<>), lifetime));

        services.Add(new ServiceDescriptor(typeof(DocumentoModeloSqlRepository<>), typeof(DocumentoModeloSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IDocumentoModeloRepository<>), typeof(DocumentoModeloSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IDocumentoModeloSqlRepository<>), typeof(DocumentoModeloSqlRepository<>), lifetime));

        services.Add(new ServiceDescriptor(typeof(DocumentoSqlRepository<>), typeof(DocumentoSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IDocumentoRepository<>), typeof(DocumentoSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IDocumentoSqlRepository<>), typeof(DocumentoSqlRepository<>), lifetime));

        services.Add(new ServiceDescriptor(typeof(EmpresaSqlRepository<>), typeof(EmpresaSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IEmpresaRepository<>), typeof(EmpresaSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IEmpresaSqlRepository<>), typeof(EmpresaSqlRepository<>), lifetime));

        services.Add(new ServiceDescriptor(typeof(IExistenciasRepository), typeof(ExistenciasSqlRepository), lifetime));
        services.Add(new ServiceDescriptor(typeof(IExistenciasSqlRepository), typeof(ExistenciasSqlRepository), lifetime));

        services.Add(new ServiceDescriptor(typeof(MonedaSqlRepository<>), typeof(MonedaSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IMonedaRepository<>), typeof(MonedaSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IMonedaSqlRepository<>), typeof(MonedaSqlRepository<>), lifetime));

        services.Add(new ServiceDescriptor(typeof(MovimientoSqlRepository<>), typeof(MovimientoSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IMovimientoRepository<>), typeof(MovimientoSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IMovimientoSqlRepository<>), typeof(MovimientoSqlRepository<>), lifetime));

        services.Add(new ServiceDescriptor(typeof(ParametrosSqlRepository<>), typeof(ParametrosSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IParametrosRepository<>), typeof(ParametrosSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IParametrosSqlRepository<>), typeof(ParametrosSqlRepository<>), lifetime));

        services.Add(new ServiceDescriptor(typeof(ProductoSqlRepository<>), typeof(ProductoSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IProductoRepository<>), typeof(ProductoSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IProductoSqlRepository<>), typeof(ProductoSqlRepository<>), lifetime));

        services.Add(new ServiceDescriptor(typeof(UnidadMedidaSqlRepository<>), typeof(UnidadMedidaSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IUnidadMedidaRepository<>), typeof(UnidadMedidaSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IUnidadMedidaSqlRepository<>), typeof(UnidadMedidaSqlRepository<>), lifetime));

        services.Add(new ServiceDescriptor(typeof(ValorClasificacionSqlRepository<>), typeof(ValorClasificacionSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IValorClasificacionRepository<>), typeof(ValorClasificacionSqlRepository<>), lifetime));
        services.Add(new ServiceDescriptor(typeof(IValorClasificacionSqlRepository<>), typeof(ValorClasificacionSqlRepository<>),
            lifetime));

        return services;
    }
}

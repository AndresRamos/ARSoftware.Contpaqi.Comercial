using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class ValorClasificacionSqlRepository : RepositoryBase<admClasificacionesValores>,
    IValorClasificacionRepository<admClasificacionesValores>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ValorClasificacionSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admClasificacionesValores BuscarPorId(int idValorClasificacion)
    {
        return _context.admClasificacionesValores.WithSpecification(new ValorClasificacionPorIdSpecification(idValorClasificacion))
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public admClasificacionesValores BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacion tipoClasificacion,
        NumeroClasificacion numeroClasificacion, string codigoValorClasificacion)
    {
        admClasificaciones clasificacion = _context.admClasificaciones
            .WithSpecification(new ClasificacionPorTipoYNumeroSpecification(tipoClasificacion, numeroClasificacion))
            .Single();

        return _context.admClasificacionesValores
            .WithSpecification(
                new ValorClasificacionPorClasificacionIdYCodigoSpecification(clasificacion.CIDCLASIFICACION, codigoValorClasificacion))
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public IEnumerable<admClasificacionesValores> TraerPorClasificacionId(int idClasificacion)
    {
        return _context.admClasificacionesValores
            .WithSpecification(new ValoresClasificacionPorClasificacionIdSpecification(idClasificacion))
            .ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admClasificacionesValores> TraerPorClasificacionTipoYNumero(TipoClasificacion tipoClasificacion,
        NumeroClasificacion numeroClasificacion)
    {
        admClasificaciones clasificacion = _context.admClasificaciones
            .WithSpecification(new ClasificacionPorTipoYNumeroSpecification(tipoClasificacion, numeroClasificacion))
            .Single();

        return _context.admClasificacionesValores
            .WithSpecification(new ValoresClasificacionPorClasificacionIdSpecification(clasificacion.CIDCLASIFICACION))
            .ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admClasificacionesValores> TraerTodo()
    {
        return _context.admClasificacionesValores.ToList();
    }
}
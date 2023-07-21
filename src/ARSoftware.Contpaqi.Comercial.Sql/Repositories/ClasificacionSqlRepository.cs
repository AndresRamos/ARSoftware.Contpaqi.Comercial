using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar clasificaciones.
/// </summary>
public sealed class ClasificacionSqlRepository : RepositoryBase<admClasificaciones>, IClasificacionRepository<admClasificaciones>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ClasificacionSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admClasificaciones? BuscarPorId(int idClasificacion)
    {
        return _context.admClasificaciones.WithSpecification(new ClasificacionPorIdSpecification(idClasificacion)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admClasificaciones? BuscarPorTipoYNumero(TipoClasificacion tipo, NumeroClasificacion numero)
    {
        return _context.admClasificaciones.WithSpecification(new ClasificacionPorTipoYNumeroSpecification(tipo, numero)).SingleOrDefault();
    }

    /// <inheritdoc />
    public List<admClasificaciones> TraerPorTipo(TipoClasificacion tipo)
    {
        return _context.admClasificaciones.WithSpecification(new ClasificacionesPorTipoSpecification(tipo)).ToList();
    }

    /// <inheritdoc />
    public List<admClasificaciones> TraerTodo()
    {
        return _context.admClasificaciones.ToList();
    }
}
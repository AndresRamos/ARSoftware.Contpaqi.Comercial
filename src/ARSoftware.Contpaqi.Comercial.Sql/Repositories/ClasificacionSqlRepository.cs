using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class ClasificacionSqlRepository : IClasificacionRepository<admClasificaciones>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ClasificacionSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admClasificaciones BuscarPorId(int idClasificacion)
    {
        return _context.admClasificaciones.SingleOrDefault(clasificacion => clasificacion.CIDCLASIFICACION == idClasificacion);
    }

    /// <inheritdoc />
    public admClasificaciones BuscarPorTipoYNumero(TipoClasificacion tipo, NumeroClasificacion numero)
    {
        // Ids de clasificaciones:
        // Agentes: 1-6
        // Clientes: 7-12
        // Proveedores: 13-18
        // Almacenes: 19-24
        // Productos: 25-30

        int idClasificacionInicio = ((int)tipo - 1) * 6 + 1;
        int idNumeroClasificacion = idClasificacionInicio + (int)numero - 1;

        // Si el tipo es TipoClasificacion.Agente y el numero es NumeroClasificacion.Dos
        // idClasificacionInicio = (1 - 1) * 6 + 1 = 1
        // idNumeroClasificacion = 1 + 2 - 1 = 2

        // Si el tipo es TipoClasificacion.Producto y el numero es NumeroClasificacion.Seis
        // idClasificacionInicio = (5 - 1) * 6 + 1 = 25
        // idNumeroClasificacion = 25 + 6 - 1 = 30

        return _context.admClasificaciones.SingleOrDefault(clasificacion => clasificacion.CIDCLASIFICACION == idNumeroClasificacion);
    }

    /// <inheritdoc />
    public IEnumerable<admClasificaciones> TraerPorTipo(TipoClasificacion tipo)
    {
        int idClasificacionInicio = ((int)tipo - 1) * 6 + 1;
        int idClasificacionFin = idClasificacionInicio + 5;

        return _context.admClasificaciones.Where(clasificacion =>
            clasificacion.CIDCLASIFICACION >= idClasificacionInicio && clasificacion.CIDCLASIFICACION <= idClasificacionFin);
    }

    /// <inheritdoc />
    public IEnumerable<admClasificaciones> TraerTodo()
    {
        return _context.admClasificaciones.ToList();
    }
}
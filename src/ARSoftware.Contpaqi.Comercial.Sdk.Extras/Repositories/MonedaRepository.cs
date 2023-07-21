using System;
using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

/// <summary>
///     Repositorio de SDK para consultar monedas.
/// </summary>
public class MonedaRepository : IMonedaRepository<Moneda>
{
    /// <inheritdoc />
    public Moneda BuscarPorId(int idMoneda)
    {
        return Moneda.ToList().SingleOrDefault(m => m.Id == idMoneda);
    }

    /// <inheritdoc />
    public Moneda BuscarPorNombre(string nombreMoneda)
    {
        return Moneda.ToList().SingleOrDefault(m => m.Nombre.IndexOf(nombreMoneda, StringComparison.OrdinalIgnoreCase) >= 0);
    }

    /// <inheritdoc />
    public IEnumerable<Moneda> TraerTodo()
    {
        return Moneda.ToList();
    }
}
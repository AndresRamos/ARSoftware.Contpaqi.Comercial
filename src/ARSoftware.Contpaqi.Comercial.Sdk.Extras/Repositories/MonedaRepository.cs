using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

/// <summary>
///     Repositorio de SDK para consultar monedas.
/// </summary>
public class MonedaRepository : IMonedaRepository<Moneda>
{
    /// <inheritdoc />
    public Moneda? BuscarPorId(int idMoneda)
    {
        return MonedaEnum.TryFromValue(idMoneda, out MonedaEnum? moneda) ? moneda.ToMoneda() : null;
    }

    /// <inheritdoc />
    public Moneda? BuscarPorNombre(string nombreMoneda)
    {
        return MonedaEnum.TryFromName(nombreMoneda, out MonedaEnum? moneda) ? moneda.ToMoneda() : null;
    }

    /// <inheritdoc />
    public List<Moneda> TraerTodo()
    {
        return MonedaEnum.List.Select(monedaEnum => monedaEnum.ToMoneda()).ToList();
    }
}

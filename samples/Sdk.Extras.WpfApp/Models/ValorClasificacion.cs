using System;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.WpfApp.Models;

public class ValorClasificacion : admClasificacionesValores
{
    public bool Contains(string filtro)
    {
        return string.IsNullOrWhiteSpace(filtro) ||
               CCODIGOVALORCLASIFICACION.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CVALORCLASIFICACION.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    public override string ToString()
    {
        return $"{CCODIGOVALORCLASIFICACION} - {CVALORCLASIFICACION}";
    }

    public tValorClasificacion ToTValorClasificacion()
    {
        return new tValorClasificacion
        {
            cNumClasificacion = CIDVALORCLASIFICACION,
            cClasificacionDe = CIDCLASIFICACION,
            cCodigoValorClasificacion = CCODIGOVALORCLASIFICACION,
            cValorClasificacion = CVALORCLASIFICACION
        };
    }
}

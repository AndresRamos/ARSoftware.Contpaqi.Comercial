using System;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.WpfApp.Models;

public class UnidadMedida : admUnidadesMedidaPeso
{
    public bool Contains(string filtro)
    {
        return string.IsNullOrWhiteSpace(filtro) ||
               CIDUNIDAD.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CNOMBREUNIDAD.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    public override string ToString()
    {
        return CNOMBREUNIDAD;
    }

    public tUnidad ToTUnidad()
    {
        return new tUnidad { cNombreUnidad = CNOMBREUNIDAD, cAbreviatura = CABREVIATURA, cDespliegue = CDESPLIEGUE };
    }
}

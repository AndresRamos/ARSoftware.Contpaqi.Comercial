using System;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

namespace Sdk.Extras.WpfApp.Models;

public class Empresa : Empresas
{
    public bool Contains(string filtro)
    {
        return string.IsNullOrWhiteSpace(filtro) ||
               CIDEMPRESA.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CNOMBREEMPRESA.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CRUTADATOS.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CRUTARESPALDOS.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    public override string ToString()
    {
        return $"{CNOMBREEMPRESA}";
    }
}

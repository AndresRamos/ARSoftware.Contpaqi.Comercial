using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.WpfApp.Models;

public class Agente : admAgentes
{
    public Agente()
    {
        CFECHAALTAAGENTE = DateTime.Today;
        CFECHAEXTRA = SdkDateTimeHelper.CreateDefaultSdkFecha();
        Tipo = TipoAgente.VentasCobro;
    }

    public TipoAgente Tipo
    {
        get => TipoAgenteHelper.ConvertFromSdkValue(CTIPOAGENTE);
        set => CTIPOAGENTE = TipoAgenteHelper.ConvertToSdkValue(value);
    }

    public bool Contains(string filtro)
    {
        return string.IsNullOrWhiteSpace(filtro) ||
               CIDAGENTE.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CCODIGOAGENTE.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CNOMBREAGENTE.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CTIPOAGENTE.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    public override string ToString()
    {
        return $"{CCODIGOAGENTE} - {CNOMBREAGENTE}";
    }
}

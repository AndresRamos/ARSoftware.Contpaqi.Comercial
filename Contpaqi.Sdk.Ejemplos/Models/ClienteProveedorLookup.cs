using System;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Models.Enums;

// ReSharper disable InconsistentNaming

namespace Contpaqi.Sdk.Ejemplos.Models;

public class ClienteProveedorLookup
{
    public int CIDCLIENTEPROVEEDOR { get; set; }
    public string CCODIGOCLIENTE { get; set; }
    public string CRAZONSOCIAL { get; set; }
    public string CRFC { get; set; }
    public int CTIPOCLIENTE { get; set; }
    public int CESTATUS { get; set; }

    public TipoCliente Tipo
    {
        get => TipoClienteHelper.ConvertFromSdkValue(CTIPOCLIENTE);
        set => CTIPOCLIENTE = TipoClienteHelper.ConvertToSdkValue(value);
    }

    public Estatus Estatus
    {
        get => EstatusHelper.ConvertFromSdkValue(CESTATUS);
        set => CESTATUS = EstatusHelper.ConvertToSdkValue(value);
    }

    public bool Contains(string filtro)
    {
        return string.IsNullOrWhiteSpace(filtro) ||
               CCODIGOCLIENTE.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
               CRAZONSOCIAL.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
               CRFC.Contains(filtro, StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{CCODIGOCLIENTE} - {CRAZONSOCIAL}";
    }
}

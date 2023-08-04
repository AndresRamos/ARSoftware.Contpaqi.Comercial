using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

// ReSharper disable InconsistentNaming

namespace Sdk.Extras.WpfApp.Models;

public class ClienteProveedorLookup
{
    public string CCODIGOCLIENTE { get; set; }
    public int CESTATUS { get; set; }
    public int CIDCLIENTEPROVEEDOR { get; set; }
    public string CRAZONSOCIAL { get; set; }
    public string CRFC { get; set; }
    public int CTIPOCLIENTE { get; set; }

    public Estatus Estatus
    {
        get => EstatusHelper.ConvertFromSdkValue(CESTATUS);
        set => CESTATUS = EstatusHelper.ConvertToSdkValue(value);
    }

    public TipoCliente Tipo
    {
        get => TipoClienteHelper.ConvertFromSdkValue(CTIPOCLIENTE);
        set => CTIPOCLIENTE = TipoClienteHelper.ConvertToSdkValue(value);
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

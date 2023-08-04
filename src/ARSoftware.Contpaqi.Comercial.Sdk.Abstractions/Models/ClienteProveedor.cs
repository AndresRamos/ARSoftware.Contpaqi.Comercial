using System.Collections.Generic;
using System.Text.Json.Serialization;
using Ardalis.SmartEnum.SystemTextJson;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

public class ClienteProveedor
{
    /// <summary>
    ///     Id del cliente o proveedor.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Código del cliente o proveedor.
    /// </summary>
    public string Codigo { get; set; } = string.Empty;

    /// <summary>
    ///     Razón Social del cliente o proveedor.
    /// </summary>
    public string RazonSocial { get; set; } = string.Empty;

    /// <summary>
    ///     Registro Federal de Contribuyentes del cliente o proveedor.
    /// </summary>
    public string Rfc { get; set; } = string.Empty;

    /// <summary>
    ///     Tipo de cliente o proveedor.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TipoCliente Tipo { get; set; }

    /// <summary>
    ///     Uso que el cliente le dará a los CFDIs.
    /// </summary>
    [JsonConverter(typeof(SmartEnumValueConverter<UsoCfdiEnum, string>))]
    public UsoCfdiEnum? UsoCfdi { get; set; }

    /// <summary>
    ///     Régimen Fiscal del cliente.
    /// </summary>
    [JsonConverter(typeof(SmartEnumValueConverter<RegimenFiscalEnum, string>))]
    public RegimenFiscalEnum? RegimenFiscal { get; set; }

    /// <summary>
    ///     Direccion fiscal del cliente.
    /// </summary>
    public Direccion? DireccionFiscal { get; set; }

    /// <summary>
    ///     Datos extra del cliente o proveedor.
    /// </summary>
    public Dictionary<string, string> DatosExtra { get; set; } = new();
}

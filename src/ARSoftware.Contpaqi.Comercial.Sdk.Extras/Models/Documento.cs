using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

public class Documento
{
    /// <summary>
    ///     Id del documento.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Concepto del documento.
    /// </summary>
    public ConceptoDocumento Concepto { get; set; } = new();

    /// <summary>
    ///     Serie del documento.
    /// </summary>
    public string Serie { get; set; } = string.Empty;

    /// <summary>
    ///     Folio del documento.
    /// </summary>
    public int Folio { get; set; }

    /// <summary>
    ///     Fecha del documento.
    /// </summary>
    public DateTime Fecha { get; set; }

    /// <summary>
    ///     Cliente o proveedor del documento.
    /// </summary>
    public ClienteProveedor? Cliente { get; set; }

    /// <summary>
    ///     Moneda del documento.
    /// </summary>
    public Moneda Moneda { get; set; } = Moneda.PesoMexicano;

    /// <summary>
    ///     Tipo de cambio del documento.
    /// </summary>
    public decimal TipoCambio { get; set; } = 1;

    /// <summary>
    ///     Agente del documento.
    /// </summary>
    public Agente? Agente { get; set; } = new();

    /// <summary>
    ///     Referencia del documento.
    /// </summary>
    public string Referencia { get; set; } = string.Empty;

    /// <summary>
    ///     Observaciones del documento.
    /// </summary>
    public string Observaciones { get; set; } = string.Empty;

    /// <summary>
    ///     Total del documento.
    /// </summary>
    public decimal Total { get; set; }

    /// <summary>
    ///     Forma de pago del documento.
    /// </summary>
    [JsonConverter(typeof(FormaPagoJsonConverter))]
    public FormaPago? FormaPago { get; set; }

    /// <summary>
    ///     Metodo de pago del documento.
    /// </summary>
    [JsonConverter(typeof(MetodoPagoJsonConverter))]
    public MetodoPago? MetodoPago { get; set; }

    /// <summary>
    ///     Movimientos del documento.
    /// </summary>
    public List<Movimiento> Movimientos { get; set; } = new();

    /// <summary>
    ///     Direccion fiscal del documento
    /// </summary>
    public Direccion? DireccionFiscal { get; set; } = new();

    /// <summary>
    ///     Folio digital del documento.
    /// </summary>
    public FolioDigital? FolioDigital { get; set; } = new();

    /// <summary>
    ///     Datos extra del documento.
    /// </summary>
    public Dictionary<string, string> DatosExtra { get; set; } = new();
}
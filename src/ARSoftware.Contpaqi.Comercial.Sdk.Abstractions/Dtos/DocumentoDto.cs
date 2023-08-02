using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;

/// <summary>
///     Documento solo con las propiedades mas comunes.
///     Este modelo se puede utilizar para consultar el catalogo de documentos cuando solo se necesitan algunas
///     propiedades.
///     Las propiedades de este modelo tienen los los mismos nombres que las propiedades del modelo de SQL para facilitar
///     la asignacion de valores cuando se utiliza con los repositorios genericos de Documentos, como por ejemplo los que
///     implementan <see cref="IDocumentoRepository{T}" /> de <see cref="DocumentoDto" />.
/// </summary>
public class DocumentoDto
{
    /// <summary>
    ///     Id del documento.
    /// </summary>
    public int CIDDOCUMENTO { get; set; }

    /// <summary>
    ///     Id del concepto del documento.
    /// </summary>
    public int CIDCONCEPTODOCUMENTO { get; set; }

    /// <summary>
    ///     Serie del documento.
    /// </summary>
    public string CSERIEDOCUMENTO { get; set; } = string.Empty;

    /// <summary>
    ///     Folio del documento.
    /// </summary>
    public double CFOLIO { get; set; }

    /// <summary>
    ///     Fecha del documento.
    /// </summary>
    public DateTime CFECHA { get; set; }

    /// <summary>
    ///     Id del cliente o proveedor del documento.
    /// </summary>
    public int CIDCLIENTEPROVEEDOR { get; set; }

    /// <summary>
    ///     Moneda asociada al documento.
    /// </summary>
    public int CIDMONEDA { get; set; }

    /// <summary>
    ///     Tipo de cambio del documento.
    /// </summary>
    public double CTIPOCAMBIO { get; set; }

    /// <summary>
    ///     Id del agente del documento.
    /// </summary>
    public int CIDAGENTE { get; set; }

    /// <summary>
    ///     Referencia del documento.
    /// </summary>
    public string CREFERENCIA { get; set; } = string.Empty;

    /// <summary>
    ///     Observaciones del documento.
    /// </summary>
    public string? COBSERVACIONES { get; set; }

    /// <summary>
    ///     Importe del total de los totales de los movimientos para el documento.
    /// </summary>
    public double CTOTAL { get; set; }

    /// <summary>
    ///     Método de pago o forma de pago en facturas.
    /// </summary>
    public string CMETODOPAG { get; set; } = string.Empty;

    /// <summary>
    ///     Cantidad de parcialidades o Método de pago para facturas
    /// </summary>
    public int CCANTPARCI { get; set; }
}

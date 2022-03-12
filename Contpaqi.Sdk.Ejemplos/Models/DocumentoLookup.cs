using System;
using System.Globalization;
using Contpaqi.Sdk.Extras.Extensions;
using Contpaqi.Sdk.Extras.Models;

// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

namespace Contpaqi.Sdk.Ejemplos.Models;

public class DocumentoLookup
{
    public int CIDDOCUMENTO { get; set; }
    public int CIDCONCEPTODOCUMENTO { get; set; }
    public string CSERIEDOCUMENTO { get; set; }
    public double CFOLIO { get; set; }
    public DateTime CFECHA { get; set; }
    public int CIDCLIENTEPROVEEDOR { get; set; }
    public int CIDMONEDA { get; set; }
    public double CTOTAL { get; set; }
    public ConceptoDocumento ConceptoDocumento { get; set; } = new();
    public ClienteProveedorLookup ClienteProveedor { get; set; } = new();

    public bool Contains(string filtro)
    {
        return string.IsNullOrWhiteSpace(filtro) ||
               CSERIEDOCUMENTO.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
               CFOLIO.ToString(CultureInfo.InvariantCulture).Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
               CFECHA.ToSdkFecha().Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
               CTOTAL.ToString(CultureInfo.InvariantCulture).Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
               ConceptoDocumento.Contains(filtro) ||
               ClienteProveedor.Contains(filtro);
    }
}

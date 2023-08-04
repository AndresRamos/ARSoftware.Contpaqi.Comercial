using System;
using System.Globalization;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;

// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

namespace Sdk.Extras.WpfApp.Models;

public class DocumentoLookup
{
    public DateTime CFECHA { get; set; }
    public double CFOLIO { get; set; }
    public int CIDCLIENTEPROVEEDOR { get; set; }
    public int CIDCONCEPTODOCUMENTO { get; set; }
    public int CIDDOCUMENTO { get; set; }
    public int CIDMONEDA { get; set; }
    public ClienteProveedorLookup ClienteProveedor { get; set; } = new();
    public ConceptoDocumento ConceptoDocumento { get; set; } = new();
    public string CSERIEDOCUMENTO { get; set; }
    public double CTOTAL { get; set; }

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

// ReSharper disable InconsistentNaming

namespace Sdk.Extras.ConsoleApp.Dtos;

public sealed class DocumentoDto
{
    public DateTime CFECHA { get; set; }
    public int CIDCONCEPTODOCUMENTO { get; set; }
    public string CSERIEDOCUMENTO { get; set; } = string.Empty;
    public double CFOLIO { get; set; }
    public string CRAZONSOCIAL { get; set; } = string.Empty;
    public double CTOTAL { get; set; }
}

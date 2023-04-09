// ReSharper disable InconsistentNaming

namespace Samples.Common.Models.Dtos;

public sealed class ClienteDto
{
    public int CIDCLIENTEPROVEEDOR { get; set; }
    public string CCODIGOCLIENTE { get; set; } = string.Empty;
    public string CRAZONSOCIAL { get; set; } = string.Empty;
    public string CRFC { get; set; } = string.Empty;
    public int CTIPOCLIENTE { get; set; }
    public string CUSOCFDI { get; set; } = string.Empty;
    public string CREGIMFISC { get; set; } = string.Empty;
}

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;

public class AgenteDto
{
    public int CIDAGENTE { get; init; }
    public string CCODIGOAGENTE { get; init; } = string.Empty;
    public string CNOMBREAGENTE { get; init; } = string.Empty;
    public int CTIPOAGENTE { get; init; }
}
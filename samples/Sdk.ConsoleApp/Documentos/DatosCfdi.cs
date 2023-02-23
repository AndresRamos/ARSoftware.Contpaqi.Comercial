// ReSharper disable UnusedAutoPropertyAccessor.Global

using System.Text;

namespace Sdk.ConsoleApp.Documentos;

public sealed class DatosCfdi
{
    public string CadenaOriginalComplementoSat { get; set; }
    public string Fecha { get; set; }
    public string FechaFolioFiscal { get; set; }
    public string FolioFiscalOriginal { get; set; }
    public string FolioFiscalUUid { get; set; }
    public string LugarExpedicion { get; set; }
    public string Moneda { get; set; }
    public string MontoFolioFiscal { get; set; }
    public string Regimen { get; set; }
    public string SelloDigital { get; set; }
    public string SelloSat { get; set; }
    public string SerieCertificadoEmisor { get; set; }
    public string SerieCertificadoSat { get; set; }
    public string SerieFolioFiscal { get; set; }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine($"{nameof(CadenaOriginalComplementoSat)} = {CadenaOriginalComplementoSat}");
        builder.AppendLine($"{nameof(Fecha)} = {Fecha}");
        builder.AppendLine($"{nameof(FechaFolioFiscal)} = {FechaFolioFiscal}");
        builder.AppendLine($"{nameof(FolioFiscalOriginal)} = {FolioFiscalOriginal}");
        builder.AppendLine($"{nameof(FolioFiscalUUid)} = {FolioFiscalUUid}");
        builder.AppendLine($"{nameof(LugarExpedicion)} = {LugarExpedicion}");
        builder.AppendLine($"{nameof(Moneda)} = {Moneda}");
        builder.AppendLine($"{nameof(MontoFolioFiscal)} = {MontoFolioFiscal}");
        builder.AppendLine($"{nameof(Regimen)} = {Regimen}");
        builder.AppendLine($"{nameof(SelloDigital)} = {SelloDigital}");
        builder.AppendLine($"{nameof(SelloSat)} = {SelloSat}");
        builder.AppendLine($"{nameof(SerieCertificadoEmisor)} = {SerieCertificadoEmisor}");
        builder.AppendLine($"{nameof(SerieCertificadoSat)} = {SerieCertificadoSat}");
        builder.AppendLine($"{nameof(SerieFolioFiscal)} = {SerieFolioFiscal}");

        return builder.ToString();
    }
}

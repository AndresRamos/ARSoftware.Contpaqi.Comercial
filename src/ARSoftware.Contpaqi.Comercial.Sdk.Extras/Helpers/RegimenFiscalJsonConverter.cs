using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public sealed class RegimenFiscalJsonConverter : JsonConverter<RegimenFiscal>
{
    public override RegimenFiscal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? regimenFiscalString = reader.GetString();
        return RegimenFiscal.FromClave(regimenFiscalString);
    }

    public override void Write(Utf8JsonWriter writer, RegimenFiscal value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Clave);
    }
}
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public sealed class UsoCfdiJsonConverter : JsonConverter<UsoCfdi>
{
    public override UsoCfdi? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? usoCfdiString = reader.GetString();
        return UsoCfdi.FromClave(usoCfdiString);
    }

    public override void Write(Utf8JsonWriter writer, UsoCfdi value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Clave);
    }
}
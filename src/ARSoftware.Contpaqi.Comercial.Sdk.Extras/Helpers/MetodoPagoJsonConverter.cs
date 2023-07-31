using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public sealed class MetodoPagoJsonConverter : JsonConverter<MetodoPago>
{
    public override MetodoPago? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? metodoPagoString = reader.GetString();
        return metodoPagoString is null ? null : MetodoPago.FromClave(metodoPagoString);
    }

    public override void Write(Utf8JsonWriter writer, MetodoPago value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Clave);
    }
}

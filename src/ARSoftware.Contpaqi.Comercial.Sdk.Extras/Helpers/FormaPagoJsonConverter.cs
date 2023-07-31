using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public sealed class FormaPagoJsonConverter : JsonConverter<FormaPago>
{
    public override FormaPago? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? formaPagoString = reader.GetString();

        return formaPagoString is null ? null : FormaPago.FromClave(formaPagoString);
    }

    public override void Write(Utf8JsonWriter writer, FormaPago value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Clave);
    }
}

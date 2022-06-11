using System.Text.Json;

namespace System;

public static class ObjectExtensions
{
    public static String ToJson(this Object value, JsonSerializerOptions? options = null) => JsonSerializer.Serialize(value, options);
    public static T? FromJson<T>(this String value, JsonSerializerOptions? options = null) => JsonSerializer.Deserialize<T>(value, options);
}
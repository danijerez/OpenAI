// ReSharper disable once CheckNamespace
namespace CSharpToJsonSchema;

/// <summary>
/// 
/// </summary>
public class OpenApiSchema
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("format")]
    public string? Format { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("description")]
    public string? Description { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
    public IReadOnlyList<string>? Enum { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("required")]
    public IReadOnlyList<string>? Required { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
    public IReadOnlyDictionary<string, OpenApiSchema>? Properties { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("items")]
    public OpenApiSchema? Items { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("additionalProperties")]
    public bool AdditionalProperties2 { get; set; }
}
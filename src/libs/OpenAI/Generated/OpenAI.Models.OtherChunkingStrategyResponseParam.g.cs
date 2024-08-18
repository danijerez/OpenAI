
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// This is returned when the chunking strategy is unknown. Typically, this is because the file was indexed before the `chunking_strategy` concept was introduced in the API.
    /// </summary>
    public sealed partial class OtherChunkingStrategyResponseParam
    {
        /// <summary>
        /// Always `other`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter))]
        public global::OpenAI.OtherChunkingStrategyResponseParamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
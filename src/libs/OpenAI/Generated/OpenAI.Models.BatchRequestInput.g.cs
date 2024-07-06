
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The per-line object of the batch input file
    /// </summary>
    public sealed partial class BatchRequestInput
    {
        /// <summary>
        /// A developer-provided per-request id that will be used to match outputs to inputs. Must be unique for each request in a batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// The HTTP method to be used for the request. Currently only `POST` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.BatchRequestInputMethodJsonConverter))]
        public global::OpenAI.BatchRequestInputMethod? Method { get; set; }

        /// <summary>
        /// The OpenAI API relative URL to be used for the request. Currently `/v1/chat/completions`, `/v1/embeddings`, and `/v1/completions` are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
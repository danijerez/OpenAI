
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantToolsFileSearch
    {
        /// <summary>
        /// The type of tool being defined: `file_search`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AssistantToolsFileSearchTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.AssistantToolsFileSearchType Type { get; set; }

        /// <summary>
        /// Overrides for the file search tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_search")]
        public global::OpenAI.AssistantToolsFileSearchFileSearch? FileSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
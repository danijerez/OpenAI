
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Occurs when a [run](/docs/api-reference/runs/object) moves to a `cancelling` status.
    /// </summary>
    public sealed partial class RunStreamEventVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RunStreamEventVariant8EventJsonConverter))]
        public global::OpenAI.RunStreamEventVariant8Event Event { get; set; }

        /// <summary>
        /// Represents an execution run on a [thread](/docs/api-reference/threads).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.RunObject Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
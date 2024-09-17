
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FineTuneChatCompletionRequestAssistantMessageVariant1
    {
        /// <summary>
        /// Controls whether the assistant message is trained against (0 or 1)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
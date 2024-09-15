
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// On an incomplete message, details about why the message is incomplete.
    /// </summary>
    public sealed partial class MessageObjectIncompleteDetails
    {
        /// <summary>
        /// The reason the message is incomplete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.MessageObjectIncompleteDetailsReason Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
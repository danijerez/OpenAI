
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The API Key used to perform the audit logged action.
    /// </summary>
    public sealed partial class AuditLogActorApiKey
    {
        /// <summary>
        /// The tracking id of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of API key. Can be either `user` or `service_account`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AuditLogActorApiKeyTypeJsonConverter))]
        public global::OpenAI.AuditLogActorApiKeyType? Type { get; set; }

        /// <summary>
        /// The user who performed the audit logged action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::OpenAI.AuditLogActorUser? User { get; set; }

        /// <summary>
        /// The service account that performed the audit logged action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account")]
        public global::OpenAI.AuditLogActorServiceAccount? ServiceAccount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUserUpdateRequest
    {
        /// <summary>
        /// `owner` or `member`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ProjectUserUpdateRequestRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.ProjectUserUpdateRequestRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The delta containing the fields that have changed on the run step.
    /// </summary>
    public sealed partial class RunStepDeltaObjectDelta
    {
        /// <summary>
        /// The details of the run step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory2))]
        public object? StepDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
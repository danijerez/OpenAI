
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Metrics at the step number during the fine-tuning job.
    /// </summary>
    public sealed partial class FineTuningJobCheckpointMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        public double? Step { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_loss")]
        public double? TrainLoss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_mean_token_accuracy")]
        public double? TrainMeanTokenAccuracy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_loss")]
        public double? ValidLoss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_mean_token_accuracy")]
        public double? ValidMeanTokenAccuracy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_valid_loss")]
        public double? FullValidLoss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_valid_mean_token_accuracy")]
        public double? FullValidMeanTokenAccuracy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
#nullable enable

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstructionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction>
    {
        /// <inheritdoc />
        public override global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstructionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstructionExtensions.ToValueString(value));
        }
    }
}